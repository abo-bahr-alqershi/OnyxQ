#!/usr/bin/env python3
import os
import re
import json
import argparse
from typing import Dict, List, Set, Tuple
from value_object_identifier import load_field_mappings, load_table_mappings, value_object_patterns, Field, Entity as VOEntity
from domain_events_generator import event_categories, module_event_categories, entity_name_patterns, Entity as EventEntity
from enhanced_enum_identifier import (
    identify_enum_fields, 
    EnumField, 
    generate_enum_code, 
    update_entity_for_enums, 
    analyze_schema_for_tables_with_enum_fields, 
    load_schema_info,
    MODULES_DIR,
    ENUM_OUTPUT_DIR
)

class DomainModelEnhancer:
    def __init__(self, entity_name: str):
        self.entity_name = entity_name
        self.table_name = None
        self.module = None
        self.field_mappings = load_field_mappings()
        self.table_mappings = load_table_mappings()
        self.schema_info = load_schema_info()
        self.value_objects = {}
        self.events = {}
        self.enum_fields = {}
        
        # Find the table name and module for the given entity name
        for table, (model, module) in self.table_mappings.items():
            if model == entity_name:
                self.table_name = table
                self.module = module
                break
        
        if not self.table_name:
            raise ValueError(f"Entity {entity_name} not found in the table mappings")
    
    def analyze(self):
        """Analyze the entity for value objects and events"""
        # Step 1: Value Objects analysis
        vo_entity = VOEntity(self.table_name, self.entity_name, self.module)
        
        # Try to find fields that belong to this entity
        # Direct match with table name
        for old_field_name, new_field_name in self.field_mappings.items():
            if old_field_name.startswith(f"{self.table_name}_"):
                field = Field(old_field_name, new_field_name)
                vo_entity.add_field(field)
        
        # Try common naming patterns
        prefixes = {
            "C_": "CUSTOMER",
            "V_": "VENDOR",
            "B_": "BANK",
            "AC_": "ACCOUNT",
            "BRN_": "S_BRN",
            "I_": "ITEMS",
            "E_": "S_EMP",
            "U_": "USER_R",
        }
        
        if self.table_name in prefixes.values():
            for prefix, table in prefixes.items():
                if table == self.table_name:
                    for old_field_name, new_field_name in self.field_mappings.items():
                        if old_field_name.startswith(prefix):
                            field = Field(old_field_name, new_field_name)
                            vo_entity.add_field(field)
        
        # If no fields were found, try heuristics based on entity name
        if not vo_entity.fields:
            # For example, if entity is Customer, look for fields with CUST, CUSTOMER, C_ prefixes
            entity_prefixes = [
                self.entity_name.upper(),
                self.entity_name[:3].upper(),
                f"{self.entity_name[:1].upper()}_"
            ]
            
            for old_field_name, new_field_name in self.field_mappings.items():
                for prefix in entity_prefixes:
                    if prefix in old_field_name:
                        field = Field(old_field_name, new_field_name)
                        vo_entity.add_field(field)
                        break
        
        # Analyze value objects
        vo_entity.analyze_value_objects()
        self.value_objects = vo_entity.get_value_object_summary()
        
        # Step 2: Event analysis
        event_entity = EventEntity(self.table_name, self.entity_name, self.module)
        event_entity.analyze_events()
        self.events = event_entity.get_events_summary()
        
        # Step 3: Enum analysis
        # We'll identify enums across all fields, but only use those relevant to this entity
        all_enum_fields = identify_enum_fields(self.field_mappings, self.table_mappings)
        
        # Filter only enum fields that belong to this entity
        self.enum_fields = {}
        for enum_name, fields in all_enum_fields.items():
            entity_enum_fields = []
            for field in fields:
                # Check if this enum field belongs to our entity
                if field.entity_name == self.entity_name:
                    entity_enum_fields.append(field)
            
            if entity_enum_fields:
                self.enum_fields[enum_name] = entity_enum_fields
    
    def generate_value_object_code(self):
        """Generate C# code for the identified value objects"""
        code_templates = {}
        
        for vo_name, properties in self.value_objects.items():
            if not properties:
                continue
                
            # Determine property types (assume string by default)
            property_types = {}
            for prop in properties:
                # Use some heuristics to determine property types
                if any(word in prop.lower() for word in ["id", "number", "count", "quantity"]):
                    property_types[prop] = "int"
                elif any(word in prop.lower() for word in ["date", "time"]):
                    property_types[prop] = "DateTime"
                elif any(word in prop.lower() for word in ["amount", "price", "cost", "rate"]):
                    property_types[prop] = "decimal"
                elif any(word in prop.lower() for word in ["flag", "is", "has", "active"]):
                    property_types[prop] = "bool"
                else:
                    property_types[prop] = "string"
            
            # Generate property declarations
            property_declarations = []
            constructor_params = []
            constructor_assignments = []
            
            for prop in properties:
                prop_type = property_types[prop]
                prop_name = prop.replace(self.entity_name, "")
                
                # Avoid empty property names
                if not prop_name:
                    prop_name = prop
                
                property_declarations.append(f"    public {prop_type} {prop_name} {{ get; }}")
                constructor_params.append(f"{prop_type} {prop_name.lower()}")
                constructor_assignments.append(f"        {prop_name} = {prop_name.lower()};")
            
            # Generate the value object code
            code = f"""using System;

namespace ERP_Pro.Domain.ERP.Modules.{self.module}.ValueObjects
{{
    public record {vo_name}
    {{
{chr(10).join(property_declarations)}

        private {vo_name}()
        {{
            // Required by EF Core
        }}

        private {vo_name}({", ".join(constructor_params)})
        {{
{chr(10).join(constructor_assignments)}
        }}

        public static {vo_name} Create({", ".join(constructor_params)})
        {{
            // Add validation logic here
            return new {vo_name}({", ".join([p.split()[1] for p in constructor_params])});
        }}
    }}
}}"""
            code_templates[vo_name] = code
        
        return code_templates
    
    def generate_event_code(self):
        """Generate C# code for the domain events"""
        code_templates = {}
        
        for event_name, event_info in self.events.items():
            # Generate event class name
            event_class_name = f"{self.entity_name}{event_name}Event"
            
            # Generate properties based on event category
            properties = [
                f"    public {self.entity_name}Id {self.entity_name}Id {{ get; }}"
            ]
            
            if event_info["category"] == "financial":
                properties.append("    public decimal Amount { get; }")
                properties.append("    public string Currency { get; }")
            
            if event_info["category"] == "status":
                properties.append("    public string PreviousStatus { get; }")
                properties.append("    public string NewStatus { get; }")
            
            if event_info["category"] == "inventory":
                properties.append("    public decimal Quantity { get; }")
                properties.append("    public string Unit { get; }")
            
            # Generate constructor parameters
            constructor_params = [f"{self.entity_name}Id {self.entity_name.lower()}Id"]
            constructor_assignments = [f"        {self.entity_name}Id = {self.entity_name.lower()}Id;"]
            
            for prop in properties[1:]:  # Skip the first property which is already in the constructor
                prop_name = prop.split()[2]
                prop_type = prop.split()[1]
                constructor_params.append(f"{prop_type} {prop_name.lower()}")
                constructor_assignments.append(f"        {prop_name} = {prop_name.lower()};")
            
            # Build the event class code
            event_code = f"""using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Modules.{self.module}.Events
{{
    /// <summary>
    /// {event_info['description']}
    /// </summary>
    public class {event_class_name} : DomainEventBase
    {{
{chr(10).join(properties)}

        public {event_class_name}({", ".join(constructor_params)})
        {{
{chr(10).join(constructor_assignments)}
        }}
    }}
}}"""
            code_templates[event_name] = event_code
        
        return code_templates
    
    def generate_entity_method_code(self):
        """Generate C# code for entity methods that raise events"""
        method_templates = {}
        
        for event_name, event_info in self.events.items():
            # Create method name (convert past tense event name to present tense method name)
            method_name = event_name
            if method_name.endswith("ed"):
                method_name = method_name[:-2]
            elif method_name.endswith("d"):
                method_name = method_name[:-1]
            
            # Special cases
            if method_name == "Creat":
                method_name = "Create"
            
            # Generate method parameters and body
            method_params = []
            event_params = [f"Id"]
            
            if event_name in ["StatusChanged", "Activated", "Deactivated"]:
                method_params.append("string newStatus")
                event_params.append("Status")
                event_params.append("newStatus")
            
            if event_name in ["PriceChanged", "BalanceChanged", "CreditLimitChanged"]:
                method_params.append("decimal newValue")
                method_params.append("string reason = null")
                event_params.append("newValue")
                event_params.append("reason ?? \"System update\"")
            
            method_code = f"""    /// <summary>
    /// {event_info['description']}
    /// </summary>
    public void {method_name}({", ".join(method_params)})
    {{
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new {self.entity_name}{event_name}Event({", ".join(event_params)}));
    }}"""
            method_templates[event_name] = method_code
        
        return method_templates
    
    def generate_enum_code(self):
        """Generate C# code for the identified enums"""
        code_templates = {}
        
        # Create module enum directory
        module_enum_dir = os.path.join(MODULES_DIR, self.module, "Enums")
        os.makedirs(module_enum_dir, exist_ok=True)
        
        for enum_name, fields in self.enum_fields.items():
            enum_code = generate_enum_code(enum_name, fields)
            code_templates[enum_name] = enum_code
            
            # Update namespace to use proper module path
            enum_code = enum_code.replace(
                f"namespace ERP_Pro.Domain.ERP.Modules.{self.module}.Enums",
                f"namespace ERP_Pro.Domain.ERP.Modules.{self.module}.Enums"
            )
            
            # Write enum file to module directory
            enum_file_path = os.path.join(module_enum_dir, f"{enum_name}.cs")
            with open(enum_file_path, "w", encoding="utf-8") as f:
                f.write(enum_code)
        
        return code_templates
    
    def generate_entity_code(self):
        """Generate code for the entity using the identified value objects and events"""
        # Get value objects
        vo_code = self.generate_value_object_code()
        
        # Generate value object properties for the entity
        vo_properties = []
        for vo_name, properties in self.value_objects.items():
            if not properties:
                continue
                
            vo_prop_name = f"{vo_name[0].lower()}{vo_name[1:]}"
            original_properties = []
            for prop in properties:
                prop_name = prop.replace(self.entity_name, "")
                if not prop_name:
                    prop_name = prop
                
                # Determine property type using heuristics
                if any(word in prop.lower() for word in ["id", "number", "count", "quantity"]):
                    prop_type = "int"
                elif any(word in prop.lower() for word in ["date", "time"]):
                    prop_type = "DateTime"
                elif any(word in prop.lower() for word in ["amount", "price", "cost", "rate"]):
                    prop_type = "decimal"
                elif any(word in prop.lower() for word in ["flag", "is", "has", "active"]):
                    prop_type = "bool"
                else:
                    prop_type = "string"
                    
                original_properties.append(f"    // Original property (keeps for backward compatibility)\n    public {prop_type} {prop_name} {{ get; private set; }} /*! {prop} */")
            
            # Add value object property
            vo_properties.append("\n".join(original_properties))
            vo_properties.append(f"    // Value object\n    public {vo_name} {vo_name} =>\n        {vo_name}.Create({', '.join([p.split('/*!')[1].strip().strip('*/') for p in original_properties if '/*!' in p])});")
        
        # Get event methods
        event_methods = self.generate_entity_method_code()
        
        # Generate enum properties
        enum_properties = []
        for enum_name, fields in self.enum_fields.items():
            for field in fields:
                # Use the new name from the field mapping for the property
                property_name = field.new_name
                
                # Generate a property with the enum type
                enum_properties.append(f"    // {field.old_name}\n    public {enum_name} {property_name} {{ get; private set; }}")
        
        # Add enum properties to the property list
        if enum_properties:
            vo_properties.append("\n    // Enum properties\n" + "\n\n".join(enum_properties))
        
        # Generate the entity code
        entity_code = f"""using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Modules.{self.module}.Events;
using ERP_Pro.Domain.ERP.Modules.{self.module}.ValueObjects;
using ERP_Pro.Domain.ERP.Modules.{self.module}.Enums;

namespace ERP_Pro.Domain.ERP.Modules.{self.module}.Entities
{{
    /// <summary>
    /// {self.entity_name} Entity
    /// </summary>
    public class {self.entity_name} : Entity<{self.entity_name}Id>
    {{
        #region Properties
        
        // Original properties and their value objects
{chr(10).join(vo_properties)}

        #endregion

        #region Constructors
        
        private {self.entity_name}()
        {{
            // Required by EF Core
        }}
        
        public {self.entity_name}(
            {self.entity_name}Id id
            // Add required parameters
        )
        {{
            Id = id;
            // Initialize properties
        }}
        
        #endregion

        #region Domain Methods
        
        // Event methods
{chr(10).join(event_methods.values())}
        
        #endregion
    }}
}}"""
        
        return entity_code
    
    def generate_report(self):
        """Generate a report of the analysis"""
        report = {
            "entity": {
                "name": self.entity_name,
                "table_name": self.table_name,
                "module": self.module
            },
            "value_objects": self.value_objects,
            "events": self.events,
            "enums": {enum_name: [{"old_name": field.old_name, "new_name": field.new_name, "type": field.field_type} for field in fields] for enum_name, fields in self.enum_fields.items()}
        }
        
        return report


def update_existing_entity_files():
    """Update existing entity files to use the proper enum types"""
    print("Updating existing entity files with enum types...")
    
    # Load all necessary data
    field_mappings = load_field_mappings()
    table_mappings = load_table_mappings()
    schema_info = load_schema_info()
    
    # Identify all enum fields
    enum_fields = identify_enum_fields(field_mappings, table_mappings)
    
    # Track entities that have been updated
    updated_entities = 0
    
    # Process each module directory
    for module_dir in os.listdir(MODULES_DIR):
        module_path = os.path.join(MODULES_DIR, module_dir)
        
        if os.path.isdir(module_path):
            entities_path = os.path.join(module_path, "Entities")
            
            if os.path.exists(entities_path):
                # Get all entity files in this module
                entity_files = [f for f in os.listdir(entities_path) if f.endswith(".cs")]
                
                for entity_file in entity_files:
                    entity_name = os.path.splitext(entity_file)[0]
                    entity_file_path = os.path.join(entities_path, entity_file)
                    
                    # Read the entity file
                    with open(entity_file_path, "r", encoding="utf-8") as f:
                        entity_code = f.read()
                    
                    # Find table for this entity
                    table_name = None
                    for table, (model, mod) in table_mappings.items():
                        if model == entity_name and mod == module_dir:
                            table_name = table
                            break
                    
                    if not table_name:
                        continue
                    
                    # Find enum fields for this entity
                    entity_enum_fields = {}
                    for enum_name, fields in enum_fields.items():
                        entity_fields = [field for field in fields if field.entity_name == entity_name]
                        if entity_fields:
                            entity_enum_fields[enum_name] = entity_fields
                    
                    if not entity_enum_fields:
                        continue
                    
                    # Update entity code
                    updated_code = update_entity_for_enums(entity_code, entity_enum_fields)
                    
                    if updated_code != entity_code:
                        # Save updated entity
                        with open(entity_file_path, "w", encoding="utf-8") as f:
                            f.write(updated_code)
                        
                        updated_entities += 1
                        print(f"Updated {entity_name} entity in {module_dir} module")
    
    print(f"Updated {updated_entities} entity files with enum types")


def main():
    parser = argparse.ArgumentParser(description='Enhance a domain model with value objects, events, and enums')
    parser.add_argument('entity_name', help='Name of the entity to enhance')
    parser.add_argument('--output-dir', default='output', help='Output directory for generated code')
    parser.add_argument('--update-existing', action='store_true', help='Update existing entity files with enum types')
    args = parser.parse_args()
    
    try:
        if args.update_existing:
            # Update existing entity files
            update_existing_entity_files()
            return
        
        # Ensure output directory exists
        os.makedirs(args.output_dir, exist_ok=True)
        
        enhancer = DomainModelEnhancer(args.entity_name)
        enhancer.analyze()
        
        report = enhancer.generate_report()
        
        # Save report
        with open(f"{args.output_dir}/{args.entity_name}_report.json", "w", encoding="utf-8") as f:
            json.dump(report, f, indent=2, ensure_ascii=False)
        
        # Create module directories if they don't exist
        module_dir = os.path.join(MODULES_DIR, enhancer.module)
        entities_dir = os.path.join(module_dir, "Entities")
        vo_dir = os.path.join(module_dir, "ValueObjects")
        events_dir = os.path.join(module_dir, "Events")
        enums_dir = os.path.join(module_dir, "Enums")
        
        os.makedirs(entities_dir, exist_ok=True)
        os.makedirs(vo_dir, exist_ok=True)
        os.makedirs(events_dir, exist_ok=True)
        os.makedirs(enums_dir, exist_ok=True)
        
        # Save value object code
        vo_code = enhancer.generate_value_object_code()
        for vo_name, code in vo_code.items():
            with open(f"{vo_dir}/{vo_name}.cs", "w", encoding="utf-8") as f:
                f.write(code)
        
        # Save event code
        event_code = enhancer.generate_event_code()
        for event_name, code in event_code.items():
            with open(f"{events_dir}/{args.entity_name}{event_name}Event.cs", "w", encoding="utf-8") as f:
                f.write(code)
        
        # Generate enum code
        enum_code = enhancer.generate_enum_code()
        
        # Save entity code
        entity_code = enhancer.generate_entity_code()
        with open(f"{entities_dir}/{args.entity_name}.cs", "w", encoding="utf-8") as f:
            f.write(entity_code)
        
        # Show summary
        print(f"Generated files for {args.entity_name} in {module_dir}/ directory")
        print(f"Value Objects identified: {', '.join(report['value_objects'].keys()) if report['value_objects'] else 'None'}")
        print(f"Events identified: {len(report['events'])} events")
        print(f"Enums identified: {len(report['enums'])} enums")
    
    except Exception as e:
        print(f"Error: {e}")


if __name__ == "__main__":
    main() 
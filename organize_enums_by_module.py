#!/usr/bin/env python3
import os
import re
import json
import shutil
import glob
from typing import Dict, List, Set, Tuple, Optional
from enhanced_enum_identifier import (
    load_field_mappings, 
    load_table_mappings, 
    load_schema_info,
    identify_enum_fields,
    EnumField,
    generate_enum_code
)

# Configuration
FIELDS_DIR = "Scheme/Feilds"
TABLE_MAPPING_FILE = "Scheme/table_models_mapping.txt"
SCHEMA_FILE = "Scheme/output.json"
MODULES_DIR = "Modules"
ENTITIES_DIR = "Entities"
ENUMS_DIR = "Enums"

def extract_module_info() -> Dict[str, List[str]]:
    """Extract module information and their entities"""
    modules = {}
    for module_dir in os.listdir(MODULES_DIR):
        module_path = os.path.join(MODULES_DIR, module_dir)
        if os.path.isdir(module_path):
            entities_path = os.path.join(module_path, ENTITIES_DIR)
            if os.path.exists(entities_path):
                entity_files = [
                    os.path.splitext(os.path.basename(f))[0]
                    for f in glob.glob(os.path.join(entities_path, "*.cs"))
                ]
                modules[module_dir] = entity_files
    
    return modules

def analyze_field_names_for_module_assignment():
    """Analyze field names to determine appropriate module placement"""
    field_mappings = load_field_mappings()
    table_mappings = load_table_mappings()
    schema_info = load_schema_info()
    
    # Get all modules
    modules = {}
    for _, (_, module) in table_mappings.items():
        if module not in modules:
            modules[module] = []
    
    # Process all field names
    field_to_module = {}
    
    # First pass: direct assignment based on table mappings
    for old_field_name, new_field_name in field_mappings.items():
        # Try to find the table this field belongs to
        for table_name, (entity_name, module) in table_mappings.items():
            if old_field_name.startswith(f"{table_name}_"):
                field_to_module[old_field_name] = module
                break
    
    # Second pass: use schema information to find parent tables
    for table_name, table_info in schema_info.items():
        for column in table_info.get('columns', []):
            field_name = column['name']
            if field_name in field_mappings and field_name not in field_to_module:
                # Find if this table is mapped
                if table_name in table_mappings:
                    field_to_module[field_name] = table_mappings[table_name][1]
    
    # Third pass: intelligent guessing based on field name patterns
    for old_field_name in field_mappings:
        if old_field_name not in field_to_module:
            # Try matching based on module names in the field name
            for module in modules:
                module_name_pattern = module.replace("&", "").replace(" ", "").lower()
                field_name_lower = old_field_name.lower()
                
                if module_name_pattern in field_name_lower:
                    field_to_module[old_field_name] = module
                    break
    
    return field_to_module

def generate_module_enum_mapping(enum_fields, field_to_module):
    """Generate mapping of enum types to modules"""
    enum_to_module = {}
    
    for enum_name, fields in enum_fields.items():
        # Count module occurrences for this enum
        module_counts = {}
        
        for field in fields:
            # First check if module is already assigned
            if field.module:
                module_counts[field.module] = module_counts.get(field.module, 0) + 1
                continue
                
            # Otherwise check if field name is in our mapping
            if field.old_name in field_to_module:
                module = field_to_module[field.old_name]
                module_counts[module] = module_counts.get(module, 0) + 1
        
        # Assign enum to the most common module
        if module_counts:
            most_common_module = max(module_counts.items(), key=lambda x: x[1])[0]
            enum_to_module[enum_name] = most_common_module
        else:
            # If no module could be determined, assign to "CoreSystem" as default
            enum_to_module[enum_name] = "CoreSystem"
    
    return enum_to_module

def organize_enums_by_module():
    """Organize enums by module"""
    # Load data
    field_mappings = load_field_mappings()
    table_mappings = load_table_mappings()
    
    # Identify all enum fields
    enum_fields = identify_enum_fields(field_mappings, table_mappings)
    
    # Analyze field names for module assignment
    field_to_module = analyze_field_names_for_module_assignment()
    
    # Generate enum-to-module mapping
    enum_to_module = generate_module_enum_mapping(enum_fields, field_to_module)
    
    # Create enums in their respective module folders
    enums_created = 0
    for enum_name, module in enum_to_module.items():
        # Create module enum directory
        module_enum_dir = os.path.join(MODULES_DIR, module, ENUMS_DIR)
        os.makedirs(module_enum_dir, exist_ok=True)
        
        # Generate enum code
        enum_code = generate_enum_code(enum_name, enum_fields[enum_name])
        
        # Update namespace to use proper module path
        enum_code = enum_code.replace(
            f"namespace ERP_Pro.Domain.ERP.{module}.Enums",
            f"namespace ERP_Pro.Domain.ERP.Modules.{module}.Enums"
        )
        
        # Write enum file
        enum_file_path = os.path.join(module_enum_dir, f"{enum_name}.cs")
        with open(enum_file_path, "w", encoding="utf-8") as f:
            f.write(enum_code)
        
        enums_created += 1
    
    print(f"Created {enums_created} enum files across {len(set(enum_to_module.values()))} modules")
    
    # Generate a detailed report
    report = {
        "enums_by_module": {},
        "field_module_assignments": {}
    }
    
    for enum_name, module in enum_to_module.items():
        if module not in report["enums_by_module"]:
            report["enums_by_module"][module] = []
        report["enums_by_module"][module].append(enum_name)
    
    for field_name, module in field_to_module.items():
        if module not in report["field_module_assignments"]:
            report["field_module_assignments"][module] = []
        report["field_module_assignments"][module].append(field_name)
    
    # Save report
    with open("enum_module_organization_report.json", "w", encoding="utf-8") as f:
        json.dump(report, f, indent=2, ensure_ascii=False)
    
    print(f"Report saved to enum_module_organization_report.json")
    
    return enum_to_module

def update_entity_files(enum_to_module):
    """Update entity files to use the organized enums"""
    # Get all modules and their entities
    modules_info = extract_module_info()
    
    entities_updated = 0
    
    # Process each module
    for module, entities in modules_info.items():
        module_path = os.path.join(MODULES_DIR, module)
        entities_path = os.path.join(module_path, ENTITIES_DIR)
        
        # Get enums for this module
        module_enums = [enum for enum, mod in enum_to_module.items() if mod == module]
        
        # Process each entity file
        for entity in entities:
            entity_file_path = os.path.join(entities_path, f"{entity}.cs")
            
            if not os.path.exists(entity_file_path):
                continue
            
            # Read entity file
            with open(entity_file_path, "r", encoding="utf-8") as f:
                entity_code = f.read()
            
            # Check if this entity has any properties that could be enums
            original_code = entity_code
            
            # Update namespace imports
            if "using ERP_Pro.Domain.ERP.Modules." not in entity_code and module_enums:
                # Find the position to insert the namespace
                last_using_index = entity_code.rfind("using")
                if last_using_index >= 0:
                    last_using_line_end = entity_code.find(";", last_using_index) + 1
                    
                    # Add the enum namespace import
                    entity_code = (
                        entity_code[:last_using_line_end] + 
                        f"\nusing ERP_Pro.Domain.ERP.Modules.{module}.Enums;" + 
                        entity_code[last_using_line_end:]
                    )
            
            # Find potential fields that could be enums
            field_mappings = load_field_mappings()
            table_mappings = load_table_mappings()
            
            # Find table name for this entity
            table_name = None
            for tbl, (ent, mod) in table_mappings.items():
                if ent == entity and mod == module:
                    table_name = tbl
                    break
            
            if not table_name:
                continue
            
            # Find potential enum fields for this entity
            enum_fields = identify_enum_fields(field_mappings, table_mappings)
            entity_enum_fields = {}
            
            for enum_name, fields in enum_fields.items():
                if enum_name in module_enums:  # Only use enums assigned to this module
                    entity_enum_fields[enum_name] = [
                        field for field in fields 
                        if field.entity_name == entity or 
                        (table_name and field.old_name.startswith(f"{table_name}_"))
                    ]
            
            # Update property declarations
            for enum_name, fields in entity_enum_fields.items():
                for field in fields:
                    # Build a pattern to match property declarations for this field
                    property_name = field.new_name
                    pattern = rf'public (?:int|string|bool|byte|short) {property_name} \{{ get; (?:private )?set; \}}'
                    
                    # Replace with enum type
                    replacement = f"public {enum_name} {property_name} {{ get; private set; }}"
                    
                    # Check if the pattern exists in the code
                    if re.search(pattern, entity_code):
                        entity_code = re.sub(pattern, replacement, entity_code)
            
            # Save the updated entity file if changes were made
            if entity_code != original_code:
                with open(entity_file_path, "w", encoding="utf-8") as f:
                    f.write(entity_code)
                entities_updated += 1
    
    print(f"Updated {entities_updated} entity files to use enum types")

def main():
    """Main function"""
    print("Organizing enums by module based on field name analysis...")
    
    # Organize enums by module
    enum_to_module = organize_enums_by_module()
    
    # Update entity files
    print("\nUpdating entity files to use the organized enums...")
    update_entity_files(enum_to_module)
    
    print("\nEnum organization and entity update completed!")

if __name__ == "__main__":
    main() 
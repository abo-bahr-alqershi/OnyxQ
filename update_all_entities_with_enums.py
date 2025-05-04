#!/usr/bin/env python3
import os
import re
import glob
from typing import Dict, List, Tuple
from enhanced_enum_identifier import (
    load_field_mappings, 
    load_table_mappings, 
    identify_enum_fields,
    EnumField,
    MODULES_DIR
)

ENTITIES_DIR = "Entities"
ENUMS_DIR = "Enums"

def find_entities_and_enums():
    """Find all entity files and their corresponding enums"""
    # Load necessary data
    field_mappings = load_field_mappings()
    table_mappings = load_table_mappings()
    
    # Identify all enum fields
    enum_fields = identify_enum_fields(field_mappings, table_mappings)
    
    # Map entity names to their source tables
    entity_table_map = {}
    for table, (entity, module) in table_mappings.items():
        entity_table_map[entity] = (table, module)
    
    # Map entities to their enum fields
    entity_enum_map = {}
    
    for enum_name, fields in enum_fields.items():
        for field in fields:
            entity_name = field.entity_name
            
            if entity_name not in entity_enum_map:
                entity_enum_map[entity_name] = {}
            
            if enum_name not in entity_enum_map[entity_name]:
                entity_enum_map[entity_name][enum_name] = []
            
            entity_enum_map[entity_name][enum_name].append(field)
    
    return entity_table_map, entity_enum_map

def update_entity_with_enums(entity_file_path: str, enum_fields: Dict[str, List[EnumField]], module: str) -> bool:
    """Update an entity file with enum properties"""
    try:
        with open(entity_file_path, 'r', encoding='utf-8') as f:
            content = f.read()
        
        original_content = content
        
        # Check if entity already imports the enum namespace
        enum_namespace = f"using ERP_Pro.Domain.ERP.Modules.{module}.Enums;"
        if enum_namespace not in content:
            # Find position to insert the import
            last_using_index = content.rfind("using")
            if last_using_index >= 0:
                last_using_line_end = content.find(";", last_using_index) + 1
                content = (
                    content[:last_using_line_end] + 
                    f"\n{enum_namespace}" + 
                    content[last_using_line_end:]
                )
        
        # Update entity properties for each enum
        for enum_name, fields in enum_fields.items():
            for field in fields:
                # Build pattern to match existing property
                property_name = field.new_name
                pattern = rf'public (?:int|string|bool|byte|short|decimal\?) {property_name} \{{ get; (?:private )?set; \}}'
                
                # Replace with enum type if found
                if re.search(pattern, content):
                    replacement = f"public {enum_name} {property_name} {{ get; private set; }}"
                    content = re.sub(pattern, replacement, content)
        
        # If content changed, write back to file
        if content != original_content:
            with open(entity_file_path, 'w', encoding='utf-8') as f:
                f.write(content)
            return True
        
        return False
    
    except Exception as e:
        print(f"Error updating {entity_file_path}: {e}")
        return False

def update_all_entities():
    """Update all entity files with enum properties"""
    print("Updating all entities with enum properties...")
    
    # Find entities and their enums
    entity_table_map, entity_enum_map = find_entities_and_enums()
    
    # Track stats
    total_entities = 0
    updated_entities = 0
    
    # Process each module directory
    for module_dir in os.listdir(MODULES_DIR):
        module_path = os.path.join(MODULES_DIR, module_dir)
        if os.path.isdir(module_path):
            entities_path = os.path.join(module_path, ENTITIES_DIR)
            if os.path.exists(entities_path):
                entity_files = glob.glob(os.path.join(entities_path, "*.cs"))
                
                for entity_file in entity_files:
                    entity_name = os.path.splitext(os.path.basename(entity_file))[0]
                    total_entities += 1
                    
                    # Check if this entity has enum properties
                    if entity_name in entity_enum_map:
                        entity_enums = entity_enum_map[entity_name]
                        
                        # Update the entity file
                        updated = update_entity_with_enums(entity_file, entity_enums, module_dir)
                        
                        if updated:
                            updated_entities += 1
                            print(f"Updated {entity_name} in {module_dir} with {len(entity_enums)} enum types")
    
    print(f"\nUpdate complete! {updated_entities} out of {total_entities} entities were updated with enum properties.")

if __name__ == "__main__":
    update_all_entities() 
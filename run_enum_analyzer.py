#!/usr/bin/env python3
import os
import json
import shutil
from enhanced_enum_identifier import (
    load_field_mappings, 
    load_table_mappings, 
    load_schema_info,
    identify_enum_fields,
    analyze_schema_for_tables_with_enum_fields,
    generate_enum_code,
    generate_enum_files_in_modules,
    ENUM_OUTPUT_DIR,
    MODULES_DIR
)
from domain_model_enhancer import update_existing_entity_files

def main():
    """Run a comprehensive enum analysis across the entire database schema and organize by modules"""
    print("Analyzing database schema for enum fields...")
    
    # Load all necessary data
    field_mappings = load_field_mappings()
    table_mappings = load_table_mappings()
    schema_info = load_schema_info()
    
    # Analyze schema for tables with enum fields
    enum_tables = analyze_schema_for_tables_with_enum_fields(schema_info)
    print(f"Found {len(enum_tables)} tables with potential enum fields")
    
    # Identify enum fields across all entities
    enum_fields = identify_enum_fields(field_mappings, table_mappings)
    print(f"Identified {len(enum_fields)} potential enum types")
    
    # Ensure output directory exists
    os.makedirs(ENUM_OUTPUT_DIR, exist_ok=True)
    
    # Generate enum files
    enum_count = 0
    for enum_name, fields in enum_fields.items():
        enum_code = generate_enum_code(enum_name, fields)
        with open(f"{ENUM_OUTPUT_DIR}/{enum_name}.cs", "w", encoding="utf-8") as f:
            f.write(enum_code)
        enum_count += 1
    
    print(f"Generated {enum_count} enum files in {ENUM_OUTPUT_DIR}")
    
    # Create a detailed JSON report
    report = {
        "summary": {
            "total_enums": len(enum_fields),
            "total_fields": sum(len(fields) for fields in enum_fields.values()),
            "tables_with_enums": len(enum_tables)
        },
        "enums": {
            enum_name: [
                {
                    "old_name": field.old_name,
                    "new_name": field.new_name,
                    "entity_name": field.entity_name,
                    "module": field.module,
                    "type": field.field_type
                } 
                for field in fields
            ] 
            for enum_name, fields in enum_fields.items()
        },
        "enum_tables": {
            table_name: [
                {"name": col["name"], "type": col["type"]} 
                for col in columns
            ] 
            for table_name, columns in enum_tables.items()
        }
    }
    
    # Save the complete report
    with open(f"{ENUM_OUTPUT_DIR}/comprehensive_enum_analysis.json", "w", encoding="utf-8") as f:
        json.dump(report, f, indent=2, ensure_ascii=False)
    
    print(f"Comprehensive report saved to {ENUM_OUTPUT_DIR}/comprehensive_enum_analysis.json")
    
    # Generate a summary by module
    module_summary = {}
    for enum_name, fields in enum_fields.items():
        # Count occurrences of each module
        module_counts = {}
        for field in fields:
            module = field.module if field.module else "CoreSystem"
            module_counts[module] = module_counts.get(module, 0) + 1
        
        # Assign enum to the most common module
        if module_counts:
            most_common_module = max(module_counts.items(), key=lambda x: x[1])[0]
            if most_common_module not in module_summary:
                module_summary[most_common_module] = []
            module_summary[most_common_module].append(enum_name)
    
    # Print modules and their enum counts
    print("\nEnum types by module:")
    for module, enums in sorted(module_summary.items()):
        print(f"{module}: {len(enums)} enum types")
    
    # Generate a module-based report
    with open(f"{ENUM_OUTPUT_DIR}/module_enum_summary.json", "w", encoding="utf-8") as f:
        json.dump(module_summary, f, indent=2, ensure_ascii=False)
    
    print(f"Module summary saved to {ENUM_OUTPUT_DIR}/module_enum_summary.json")
    
    # Now organize enums into module folders
    print("\nOrganizing enums by module folders...")
    module_enums = generate_enum_files_in_modules()
    print(f"Created enum files in {len(module_enums)} module folders")
    
    # Ask if user wants to update existing entity files
    update_entities = input("Do you want to update existing entity files with enum types? (y/n): ")
    if update_entities.lower() == 'y':
        update_existing_entity_files()

if __name__ == "__main__":
    main() 
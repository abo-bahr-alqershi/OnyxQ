#!/usr/bin/env python3
import os
import sys
import argparse
from enhanced_enum_identifier import (
    load_field_mappings,
    load_table_mappings,
    load_schema_info,
    identify_enum_fields,
    analyze_schema_for_tables_with_enum_fields,
    generate_enum_files_in_modules,
    ENUM_OUTPUT_DIR,
    MODULES_DIR
)
from domain_model_enhancer import update_existing_entity_files
from update_all_entities_with_enums import update_all_entities
from enum_project_summary import generate_project_summary

def print_step(step_num, step_name):
    """Print a formatted step header"""
    print("\n" + "=" * 80)
    print(f"STEP {step_num}: {step_name}")
    print("=" * 80 + "\n")

def main():
    """Main function to organize enums by module and update entities"""
    parser = argparse.ArgumentParser(description='Organize enums by module and update entity properties')
    parser.add_argument('--analyze-only', action='store_true', help='Only analyze and generate report without making changes')
    parser.add_argument('--summary-only', action='store_true', help='Only generate summary without making changes')
    parser.add_argument('--update-entities', action='store_true', help='Update entity files with enum properties')
    args = parser.parse_args()
    
    if args.summary_only:
        print_step(1, "GENERATING PROJECT SUMMARY")
        generate_project_summary()
        return
    
    # Step 1: Analyze database schema
    print_step(1, "ANALYZING DATABASE SCHEMA")
    field_mappings = load_field_mappings()
    table_mappings = load_table_mappings()
    schema_info = load_schema_info()
    print(f"Loaded {len(field_mappings)} field mappings")
    print(f"Loaded {len(table_mappings)} table mappings")
    print(f"Loaded schema for {len(schema_info)} tables")
    
    # Analyze schema for enum tables and fields
    enum_tables = analyze_schema_for_tables_with_enum_fields(schema_info)
    enum_fields = identify_enum_fields(field_mappings, table_mappings)
    print(f"\nFound {len(enum_tables)} tables with potential enum fields")
    print(f"Identified {len(enum_fields)} potential enum types")
    
    if args.analyze_only:
        print("\nAnalysis complete. Exiting without making changes.")
        return
    
    # Step 2: Generate enum files in module directories
    print_step(2, "GENERATING ENUM FILES IN MODULE DIRECTORIES")
    module_enums = generate_enum_files_in_modules()
    print(f"Created enum files in {len(module_enums)} module directories")
    
    # Step 3: Update entity files with enum properties
    if args.update_entities:
        print_step(3, "UPDATING ENTITY FILES WITH ENUM PROPERTIES")
        update_all_entities()
    
    # Step 4: Generate summary
    print_step(4, "GENERATING PROJECT SUMMARY")
    generate_project_summary()
    
    print("\nEnum organization process completed!")

if __name__ == "__main__":
    main() 
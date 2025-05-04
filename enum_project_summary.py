#!/usr/bin/env python3
import os
import json
import glob
from collections import defaultdict

MODULES_DIR = "Modules"
ENUMS_DIR = "Enums"
ENTITIES_DIR = "Entities"
ENUM_OUTPUT_DIR = "output/Enums"

def generate_project_summary():
    """Generate a summary of the enum organization project"""
    print("Generating summary of enum organization project...\n")
    
    # 1. Count enums by module
    module_enum_counts = {}
    
    for module_dir in os.listdir(MODULES_DIR):
        module_path = os.path.join(MODULES_DIR, module_dir)
        if os.path.isdir(module_path):
            enum_path = os.path.join(module_path, ENUMS_DIR)
            if os.path.exists(enum_path):
                enum_files = glob.glob(os.path.join(enum_path, "*.cs"))
                module_enum_counts[module_dir] = len(enum_files)
    
    # 2. Count entity files with enum references
    module_entity_counts = {}
    entity_enum_references = defaultdict(int)
    
    for module_dir in os.listdir(MODULES_DIR):
        module_path = os.path.join(MODULES_DIR, module_dir)
        if os.path.isdir(module_path):
            entities_path = os.path.join(module_path, ENTITIES_DIR)
            if os.path.exists(entities_path):
                entity_files = glob.glob(os.path.join(entities_path, "*.cs"))
                
                entities_with_enums = 0
                for entity_file in entity_files:
                    with open(entity_file, 'r', encoding='utf-8') as f:
                        content = f.read()
                        
                        # Check if entity uses any enum types
                        enum_references = 0
                        for enum_dir in os.listdir(os.path.join(MODULES_DIR, module_dir, ENUMS_DIR)) if os.path.exists(os.path.join(MODULES_DIR, module_dir, ENUMS_DIR)) else []:
                            enum_name = os.path.splitext(enum_dir)[0]
                            if f"public {enum_name}" in content:
                                enum_references += 1
                        
                        # Also check for any enum type references (not just those from the same module)
                        if "Enum" in content or "public enum" in content or "ERP_Pro.Domain.ERP.Modules" in content:
                            entities_with_enums += 1
                            entity_enum_references[module_dir] += enum_references if enum_references > 0 else 1
                        elif enum_references > 0:
                            entities_with_enums += 1
                            entity_enum_references[module_dir] += enum_references
                
                module_entity_counts[module_dir] = {
                    "total_entities": len(entity_files),
                    "entities_with_enums": entities_with_enums
                }
    
    # 3. Display summary
    total_modules = len(module_enum_counts)
    total_enums = sum(module_enum_counts.values())
    total_entities = sum(c["total_entities"] for c in module_entity_counts.values())
    total_entities_with_enums = sum(c["entities_with_enums"] for c in module_entity_counts.values())
    total_enum_references = sum(entity_enum_references.values())
    
    print("=== ENUM ORGANIZATION PROJECT SUMMARY ===")
    print(f"Total modules: {total_modules}")
    print(f"Total enums created: {total_enums}")
    print(f"Total entities: {total_entities}")
    print(f"Entities with enum references: {total_entities_with_enums}")
    print(f"Total enum references in entities: {total_enum_references}")
    print("\n=== ENUMS BY MODULE ===")
    
    for module, count in sorted(module_enum_counts.items(), key=lambda x: x[1], reverse=True):
        print(f"{module}: {count} enums")
    
    print("\n=== ENTITY STATISTICS BY MODULE ===")
    
    for module in sorted(module_entity_counts.keys()):
        if module in module_entity_counts:
            total = module_entity_counts[module]["total_entities"]
            with_enums = module_entity_counts[module]["entities_with_enums"]
            enum_refs = entity_enum_references.get(module, 0)
            percentage = with_enums / total * 100 if total > 0 else 0
            
            print(f"{module}: {with_enums}/{total} entities use enums ({percentage:.1f}%), {enum_refs} enum references")
    
    # 4. Save summary to a file
    summary = {
        "overview": {
            "total_modules": total_modules,
            "total_enums": total_enums,
            "total_entities": total_entities,
            "entities_with_enums": total_entities_with_enums,
            "total_enum_references": total_enum_references
        },
        "module_enum_counts": module_enum_counts,
        "module_entity_stats": module_entity_counts,
        "enum_references": entity_enum_references
    }
    
    with open("enum_project_summary.json", "w", encoding="utf-8") as f:
        json.dump(summary, f, indent=2, ensure_ascii=False)
    
    print("\nSummary saved to enum_project_summary.json")

if __name__ == "__main__":
    generate_project_summary() 
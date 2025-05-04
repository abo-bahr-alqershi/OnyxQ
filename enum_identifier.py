#!/usr/bin/env python3
import os
import re
import json
from collections import defaultdict
import glob
from typing import Dict, List, Set, Tuple
from value_object_identifier import load_field_mappings, load_table_mappings, Field, Entity

# Configuration
FIELDS_DIR = "Scheme/Feilds"
TABLE_MAPPING_FILE = "Scheme/table_models_mapping.txt"
ENUM_OUTPUT_DIR = "output/Enums"

# Patterns for identifying enum fields
enum_field_patterns = [
    # Type fields
    r'.*TYPE.*',
    r'.*_TYP.*',
    r'.*_TP.*',
    r'.*TYP_.*',
    r'.*TP_.*',
    # Status fields
    r'.*STATUS.*',
    r'.*_ST.*',
    r'.*ST_.*',
    r'.*STATE.*',
    # Category/Class fields
    r'.*CATEGORY.*',
    r'.*CTGRY.*',
    r'.*CLASS.*',
    r'.*CLSS.*',
    # Flag fields
    r'.*FLAG.*',
    r'.*FLG.*',
    # Level fields
    r'.*LEVEL.*',
    r'.*LVL.*',
    # Mode fields
    r'.*MODE.*',
    r'.*METHOD.*',
    r'.*MTHD.*',
    # Code fields that likely represent enums
    r'.*_CODE$',
    r'.*CODE_.*',
    # Priority/Severity 
    r'.*PRIORITY.*',
    r'.*SEVERITY.*',
    # Direction
    r'.*DIRECTION.*',
    r'.*DIR_.*',
    # Format
    r'.*FORMAT.*',
    r'.*FRMT.*',
    # Frequency
    r'.*FREQUENCY.*',
    r'.*FREQ.*',
    # Source 
    r'.*SOURCE.*',
    r'.*SRC.*',
    # Option
    r'.*OPTION.*',
    r'.*OPT.*',
    # Condition
    r'.*CONDITION.*',
    r'.*CNDTN.*',
    # Nature
    r'.*NATURE.*',
    r'.*NATUR.*'
]

# Words that indicate a field is likely NOT an enum
non_enum_indicators = [
    'DATE', 'TIME', 'DAY', 'MONTH', 'YEAR', 'ID', 'CODE_NAME', 'PARENT', 'NAME', 'DESC',
    'AMOUNT', 'AMT', 'QTY', 'COUNT', 'NUM', 'RATE', 'VALUE', 'PRICE', 'COST',
    'EMAIL', 'PHONE', 'FAX', 'ADDRESS', 'CITY', 'LOCATION', 'COUNTRY', 'URL', 'PATH',
    'TEXT', 'NOTE', 'COMMENT', 'LETTER', 'GROUP', 'COLOR', 'STYLE', 'ICON', 'IMAGE',
    'WIDTH', 'HEIGHT', 'SIZE', 'WEIGHT', 'LENGTH', 'DEPTH', 'DIMENSION', 'DISTANCE',
    'PERCENTAGE', 'PERCENT', 'RATIO', 'FACTOR', 'COEFFICIENT', 'PASSWORD', 'KEY',
    'CONTENT', 'DATA', 'INFO', 'REFERENCE', 'REF', 'SALT', 'HASH', 'TOKEN'
]

class EnumField:
    def __init__(self, old_name: str, new_name: str, entity_name: str, module: str = None):
        self.old_name = old_name
        self.new_name = new_name
        self.entity_name = entity_name
        self.module = module
        self.enum_name = self._generate_enum_name()
    
    def _generate_enum_name(self) -> str:
        """Generate an appropriate enum name based on the field name"""
        name = self.new_name
        
        # Remove common prefixes if they exist
        if name.startswith(self.entity_name):
            name = name[len(self.entity_name):]
        
        # Check if the name already ends with "Type", "Status", etc.
        enum_suffixes = ["Type", "Status", "Category", "Class", "Flag", "Level", "Mode", "Method", 
                        "State", "Option", "Format", "Source", "Priority", "Severity", "Code", 
                        "Direction", "Frequency", "Condition", "Nature"]
        
        for suffix in enum_suffixes:
            if name.endswith(suffix):
                return name
        
        # If not, try to determine the appropriate suffix
        if any(indicator in self.old_name for indicator in ["TYPE", "TYP", "TP"]):
            return f"{name}Type"
        elif any(indicator in self.old_name for indicator in ["STATUS", "ST", "STATE"]):
            return f"{name}Status"
        elif any(indicator in self.old_name for indicator in ["FLAG", "FLG"]):
            return f"{name}Flag"
        elif any(indicator in self.old_name for indicator in ["LEVEL", "LVL"]):
            return f"{name}Level"
        elif any(indicator in self.old_name for indicator in ["CATEGORY", "CTGRY"]):
            return f"{name}Category"
        elif any(indicator in self.old_name for indicator in ["CLASS", "CLSS"]):
            return f"{name}Class"
        elif any(indicator in self.old_name for indicator in ["MODE", "METHOD", "MTHD"]):
            return f"{name}Method"
        elif any(indicator in self.old_name for indicator in ["CODE"]):
            return f"{name}Code"
        elif any(indicator in self.old_name for indicator in ["PRIORITY"]):
            return f"{name}Priority"
        elif any(indicator in self.old_name for indicator in ["SEVERITY"]):
            return f"{name}Severity"
        elif any(indicator in self.old_name for indicator in ["DIRECTION", "DIR"]):
            return f"{name}Direction"
        elif any(indicator in self.old_name for indicator in ["FORMAT", "FRMT"]):
            return f"{name}Format"
        elif any(indicator in self.old_name for indicator in ["FREQUENCY", "FREQ"]):
            return f"{name}Frequency"
        elif any(indicator in self.old_name for indicator in ["SOURCE", "SRC"]):
            return f"{name}Source"
        elif any(indicator in self.old_name for indicator in ["OPTION", "OPT"]):
            return f"{name}Option"
        elif any(indicator in self.old_name for indicator in ["CONDITION", "CNDTN"]):
            return f"{name}Condition"
        elif any(indicator in self.old_name for indicator in ["NATURE", "NATUR"]):
            return f"{name}Nature"
        else:
            return f"{name}Enum"

    def __repr__(self):
        return f"{self.old_name} => {self.enum_name}"


def is_potential_enum_field(field_name: str) -> bool:
    """Check if a field name matches enum patterns and doesn't contain non-enum indicators"""
    # Skip if the field contains any of the non-enum indicators
    for indicator in non_enum_indicators:
        if indicator in field_name:
            return False
    
    # Check if the field matches any of the enum patterns
    for pattern in enum_field_patterns:
        if re.match(pattern, field_name):
            return True
    
    return False


def identify_enum_fields(field_mappings: Dict[str, str], table_mappings: Dict[str, Tuple[str, str]]) -> Dict[str, List[EnumField]]:
    """Identify potential enum fields from the field mappings"""
    enum_fields = defaultdict(list)
    
    # Create entity objects
    entities = {}
    for table_name, (model_name, module) in table_mappings.items():
        entities[table_name] = Entity(table_name, model_name, module)
    
    # Match fields to entities
    entity_fields = defaultdict(list)
    
    # Infer which fields belong to which tables
    # We'll use a simple approach matching field prefixes with table names
    for old_field_name, new_field_name in field_mappings.items():
        # Skip if not a potential enum field
        if not is_potential_enum_field(old_field_name):
            continue
        
        # Try to find the matching table
        matched_table = None
        
        # Direct prefix match (e.g., ACCOUNT_TYPE for table ACCOUNT)
        for table_name in table_mappings.keys():
            if old_field_name.startswith(f"{table_name}_"):
                matched_table = table_name
                break
        
        # Try common prefixes for specific tables
        if not matched_table:
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
            
            for prefix, table in prefixes.items():
                if old_field_name.startswith(prefix) and table in table_mappings:
                    matched_table = table
                    break
        
        # If we found a matching table, add the field to that entity
        if matched_table and matched_table in entities:
            model_name, module = table_mappings[matched_table]
            enum_field = EnumField(old_field_name, new_field_name, model_name, module)
            enum_fields[enum_field.enum_name].append(enum_field)
    
    return enum_fields


def generate_enum_code(enum_name: str, fields: List[EnumField]) -> str:
    """Generate C# enum code for the identified enum fields"""
    # Find the most common module among fields
    module_counts = {}
    for field in fields:
        if field.module:
            module_counts[field.module] = module_counts.get(field.module, 0) + 1
    
    # Use the most common module, or a default
    module = max(module_counts.items(), key=lambda x: x[1])[0] if module_counts else "Common"
    
    # Generate the enum code
    enum_code = f"""using System;

namespace ERP_Pro.Domain.ERP.{module}.Enums
{{
    /// <summary>
    /// Represents the {enum_name} enum.
    /// Generated based on fields:
    /// {', '.join([f.old_name for f in fields])}
    /// </summary>
    public enum {enum_name}
    {{
        /// <summary>
        /// Default/undefined value
        /// </summary>
        Undefined = 0,

        // TODO: Add enum values here
        
        // Examples:
        // Active = 1,
        // Inactive = 2,
        // Pending = 3,
    }}
}}"""
    
    return enum_code


def update_entity_for_enums(entity_code: str, enum_fields: Dict[str, List[EnumField]]) -> str:
    """Update entity code to use enum types instead of primitive types"""
    # This is a simplified implementation - a more robust approach would use a C# parser
    updated_code = entity_code
    
    # Gather all enums used by this entity
    used_enums = []
    
    for enum_name, fields in enum_fields.items():
        for field in fields:
            # Build a pattern to match property declarations for this field
            pattern = rf'public (?:int|string|bool) {field.new_name} \{{ get; (?:private )?set; \}}'
            
            # Replace with enum type
            replacement = f"public {enum_name} {field.new_name} {{ get; private set; }}"
            
            if re.search(pattern, updated_code):
                updated_code = re.sub(pattern, replacement, updated_code)
                
                # Add to used enums if not already included
                module = field.module or "Common"
                enum_namespace = f"ERP_Pro.Domain.ERP.{module}.Enums"
                if enum_namespace not in used_enums:
                    used_enums.append(enum_namespace)
    
    # Add enum namespace imports if they don't exist
    for enum_namespace in used_enums:
        if f"using {enum_namespace};" not in updated_code:
            # Insert after the last using statement
            last_using_index = updated_code.rfind("using")
            last_using_line_end = updated_code.find(";", last_using_index) + 1
            
            updated_code = (
                updated_code[:last_using_line_end] + 
                f"\nusing {enum_namespace};" + 
                updated_code[last_using_line_end:]
            )
    
    return updated_code


def main():
    # Load field mappings
    print("Loading field mappings...")
    field_mappings = load_field_mappings()
    print(f"Loaded {len(field_mappings)} field mappings")
    
    # Load table mappings
    print("Loading table mappings...")
    table_mappings = load_table_mappings()
    print(f"Loaded {len(table_mappings)} table mappings")
    
    # Identify enum fields
    print("Identifying enum fields...")
    enum_fields = identify_enum_fields(field_mappings, table_mappings)
    print(f"Identified {len(enum_fields)} potential enum types")
    
    # Create output directory
    os.makedirs(ENUM_OUTPUT_DIR, exist_ok=True)
    
    # Generate enum files
    for enum_name, fields in enum_fields.items():
        # Generate enum code
        enum_code = generate_enum_code(enum_name, fields)
        
        # Write to file
        with open(f"{ENUM_OUTPUT_DIR}/{enum_name}.cs", "w", encoding="utf-8") as f:
            f.write(enum_code)
    
    print(f"Generated {len(enum_fields)} enum files in {ENUM_OUTPUT_DIR}")
    
    # Create JSON report
    report = {
        "summary": {
            "total_enums": len(enum_fields),
            "total_fields": sum(len(fields) for fields in enum_fields.values())
        },
        "enums": {enum_name: [field.old_name for field in fields] for enum_name, fields in enum_fields.items()}
    }
    
    with open(f"{ENUM_OUTPUT_DIR}/enum_analysis.json", "w", encoding="utf-8") as f:
        json.dump(report, f, indent=2, ensure_ascii=False)
    
    print(f"Report saved to {ENUM_OUTPUT_DIR}/enum_analysis.json")


if __name__ == "__main__":
    main() 
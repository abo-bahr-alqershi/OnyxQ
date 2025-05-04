#!/usr/bin/env python3
import os
import re
import json
import copy
from collections import defaultdict
from typing import Dict, List, Set, Tuple, Optional
from value_object_identifier import load_field_mappings, load_table_mappings, Field, Entity

# Configuration
FIELDS_DIR = "Scheme/Feilds"
TABLE_MAPPING_FILE = "Scheme/table_models_mapping.txt"
SCHEMA_FILE = "Scheme/output.json"
ENUM_OUTPUT_DIR = "output/Enums"
MODULES_DIR = "Modules"
ENUMS_DIR = "Enums"

# Patterns for identifying enum fields based on naming
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
    r'.*NATUR.*',
    # Reason
    r'.*REASON.*',
    r'.*RSN.*',
    # Kind
    r'.*KIND.*',
    r'.*KND.*',
    # Form 
    r'.*FORM.*',
    # Style
    r'.*STYLE.*',
    r'.*STY.*',
    # Role
    r'.*ROLE.*',
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

# Field type patterns that likely represent enums
enum_type_patterns = [
    # Small integer types are often enums
    r'NUMBER\(1\s*,\s*\d*\)',  # e.g., NUMBER(1, 0) - often used for flags/boolean-like enums
    r'NUMBER\(2\s*,\s*\d*\)',  # e.g., NUMBER(2, 0) - often used for small enums
    r'NUMBER\(3\s*,\s*\d*\)',  # e.g., NUMBER(3, 0) - potentially larger enums
    r'NUMBER\(5\s*,\s*\d*\)',  # e.g., NUMBER(5, 0) - commonly used for type/status codes
    r'TINYINT',
    r'SMALLINT',
    # VARCHAR with small sizes (often used for single-character codes)
    r'VARCHAR2\(1\)',
    r'VARCHAR2\(2\)',
    r'CHAR\(1\)',
    r'CHAR\(2\)',
]

class EnumField:
    def __init__(self, old_name: str, new_name: str, entity_name: str, module: str = None, field_type: str = None):
        self.old_name = old_name
        self.new_name = new_name
        self.entity_name = entity_name
        self.module = module
        self.field_type = field_type
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
                        "Direction", "Frequency", "Condition", "Nature", "Reason", "Kind", "Form", "Style",
                        "Role"]
        
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
        elif any(indicator in self.old_name for indicator in ["REASON", "RSN"]):
            return f"{name}Reason"
        elif any(indicator in self.old_name for indicator in ["KIND", "KND"]):
            return f"{name}Kind"
        elif any(indicator in self.old_name for indicator in ["FORM"]):
            return f"{name}Form"
        elif any(indicator in self.old_name for indicator in ["STYLE", "STY"]):
            return f"{name}Style"
        elif any(indicator in self.old_name for indicator in ["ROLE"]):
            return f"{name}Role"
        else:
            return f"{name}Enum"

    def __repr__(self):
        return f"{self.old_name} => {self.enum_name} [{self.field_type}]"


def load_schema_info() -> Dict:
    """Load database schema information from the output.json file"""
    try:
        with open(SCHEMA_FILE, 'r', encoding='utf-8') as f:
            return json.load(f)
    except Exception as e:
        print(f"Error loading schema file: {e}")
        return {}


def get_field_type(schema_info: Dict, table_name: str, field_name: str) -> Optional[str]:
    """Get the field type for a given table and field name from the schema"""
    if table_name in schema_info:
        for column in schema_info[table_name].get('columns', []):
            if column['name'] == field_name:
                return column['type']
    return None


def is_potential_enum_by_type(field_type: str) -> bool:
    """Check if a field type indicates a potential enum"""
    if not field_type:
        return False
    
    for pattern in enum_type_patterns:
        if re.match(pattern, field_type):
            return True
    
    return False


def is_potential_enum_by_name(field_name: str) -> bool:
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


def analyze_field_files_for_enums():
    """Analyze field name files in the FIELDS_DIR to extract additional enum patterns"""
    field_files = [f for f in os.listdir(FIELDS_DIR) if f.endswith('.md')]
    potential_enum_fields = set()
    
    for file_name in field_files:
        try:
            with open(os.path.join(FIELDS_DIR, file_name), 'r', encoding='utf-8') as f:
                content = f.read()
                
                # Look for field mappings in the format: OLD_FIELD_NAME => NewFieldName
                mappings = re.findall(r'([A-Z0-9_]+)\s*=>\s*([A-Za-z0-9]+)', content)
                
                for old_name, new_name in mappings:
                    # Check if this field might be an enum
                    if is_potential_enum_by_name(old_name):
                        potential_enum_fields.add((old_name, new_name))
        except Exception as e:
            print(f"Error processing field file {file_name}: {e}")
    
    return potential_enum_fields


def get_related_tables(schema_info: Dict, table_name: str) -> List[str]:
    """Get tables that are related to the given table via foreign keys"""
    related_tables = []
    
    # Tables that reference this table (child tables)
    for other_table, other_info in schema_info.items():
        for fk in other_info.get('foreign_keys', []):
            if fk.get('references_table') == table_name:
                related_tables.append(other_table)
    
    # Tables referenced by this table (parent tables)
    if table_name in schema_info:
        for fk in schema_info[table_name].get('foreign_keys', []):
            referenced_table = fk.get('references_table')
            if referenced_table:
                related_tables.append(referenced_table)
    
    return related_tables


def identify_module_from_field_name(field_name: str, modules: List[str]) -> Optional[str]:
    """Try to identify module from field name patterns"""
    field_lower = field_name.lower()
    
    # Create module pattern mapping
    module_patterns = {
        module.lower().replace(" & ", "").replace(" ", ""): module
        for module in modules
    }
    
    # Check if field name contains a module pattern
    for pattern, module in module_patterns.items():
        if pattern in field_lower:
            return module
    
    return None


def identify_enum_fields(field_mappings: Dict[str, str], table_mappings: Dict[str, Tuple[str, str]]) -> Dict[str, List[EnumField]]:
    """Identify potential enum fields from the field mappings and schema info"""
    enum_fields = defaultdict(list)
    schema_info = load_schema_info()
    
    # Get list of modules
    modules = list(set(module for _, (_, module) in table_mappings.items()))
    
    # Create entity objects
    entities = {}
    for table_name, (model_name, module) in table_mappings.items():
        entities[table_name] = Entity(table_name, model_name, module)
    
    # Build a map of field names to their tables
    field_to_table = {}
    for table_name, table_info in schema_info.items():
        for column in table_info.get('columns', []):
            field_to_table[column['name']] = table_name
    
    # Get additional potential enum fields from field files
    additional_enum_fields = analyze_field_files_for_enums()
    
    # Infer which fields belong to which tables
    for old_field_name, new_field_name in field_mappings.items():
        # First try to find the exact table match in the schema
        matched_table = field_to_table.get(old_field_name)
        
        # If not found, try prefix matching
        if not matched_table:
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
        
        # If we found a matching table, check if it's a potential enum
        if matched_table and matched_table in entities:
            model_name, module = table_mappings[matched_table]
            
            # Get field type from schema
            field_type = get_field_type(schema_info, matched_table, old_field_name)
            
            # Check if field is a potential enum based on name or type
            is_enum_by_name = is_potential_enum_by_name(old_field_name)
            is_enum_by_type = is_potential_enum_by_type(field_type)
            is_enum_in_additional = (old_field_name, new_field_name) in additional_enum_fields
            
            if is_enum_by_name or is_enum_by_type or is_enum_in_additional:
                enum_field = EnumField(old_field_name, new_field_name, model_name, module, field_type)
                enum_fields[enum_field.enum_name].append(enum_field)
                
                # If this field is in a parameter or settings table, find out which entities it might be related to
                if matched_table.startswith("IAS_PARA") or "SETTINGS" in matched_table or "CONFIG" in matched_table:
                    # Check field name for clues about which entity it belongs to
                    for entity_table, (entity_name, entity_module) in table_mappings.items():
                        if entity_table == matched_table:
                            continue  # Skip the parameter table itself
                            
                        # Check if the field name suggests it's related to this entity
                        entity_prefix = entity_table.lower().replace("_", "")
                        field_lower = old_field_name.lower()
                        
                        if (entity_prefix in field_lower or 
                            entity_name.lower() in field_lower or 
                            entity_module.lower().replace(" & ", "").replace(" ", "") in field_lower):
                            
                            # Create a copy of the field but assign it to the related entity
                            related_enum_field = EnumField(
                                old_name=old_field_name,
                                new_name=new_field_name,
                                entity_name=entity_name,
                                module=entity_module,
                                field_type=field_type
                            )
                            enum_fields[related_enum_field.enum_name].append(related_enum_field)
        else:
            # Field doesn't match a known table, try to identify module from field name
            if is_potential_enum_by_name(old_field_name) or (old_field_name, new_field_name) in additional_enum_fields:
                module = identify_module_from_field_name(old_field_name, modules)
                
                if module:
                    # Create a generic entity name based on field
                    entity_name = "".join([p.capitalize() for p in old_field_name.split('_')[:2]])
                    
                    enum_field = EnumField(
                        old_name=old_field_name,
                        new_name=new_field_name,
                        entity_name=entity_name,
                        module=module,
                        field_type=None
                    )
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
    module = max(module_counts.items(), key=lambda x: x[1])[0] if module_counts else "CoreSystem"
    
    # Generate the enum code
    enum_code = f"""using System;

namespace ERP_Pro.Domain.ERP.Modules.{module}.Enums
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
            pattern = rf'public (?:int|string|bool|byte|short) {field.new_name} \{{ get; (?:private )?set; \}}'
            
            # Replace with enum type
            replacement = f"public {enum_name} {field.new_name} {{ get; private set; }}"
            
            if re.search(pattern, updated_code):
                updated_code = re.sub(pattern, replacement, updated_code)
                
                # Add to used enums if not already included
                module = field.module or "CoreSystem"
                enum_namespace = f"ERP_Pro.Domain.ERP.Modules.{module}.Enums"
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


def analyze_schema_for_tables_with_enum_fields(schema_info: Dict) -> Dict:
    """Analyze schema to find tables with potential enum fields"""
    enum_tables = {}
    
    for table_name, table_info in schema_info.items():
        enum_columns = []
        for column in table_info.get('columns', []):
            column_name = column['name']
            column_type = column['type']
            
            # Check if the column is a potential enum
            if is_potential_enum_by_name(column_name) or is_potential_enum_by_type(column_type):
                enum_columns.append({
                    'name': column_name,
                    'type': column_type
                })
        
        if enum_columns:
            enum_tables[table_name] = enum_columns
    
    return enum_tables


def generate_enum_files_in_modules():
    """Generate enum files organized by module directories"""
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
    
    # Group enums by module
    module_enums = defaultdict(list)
    for enum_name, fields in enum_fields.items():
        # Find the most common module among fields
        module_counts = {}
        for field in fields:
            if field.module:
                module_counts[field.module] = module_counts.get(field.module, 0) + 1
        
        # Use the most common module, or a default
        module = max(module_counts.items(), key=lambda x: x[1])[0] if module_counts else "CoreSystem"
        module_enums[module].append((enum_name, fields))
    
    # Generate enum files by module
    for module, enums in module_enums.items():
        # Create module enum directory
        module_enum_dir = os.path.join(MODULES_DIR, module, ENUMS_DIR)
        os.makedirs(module_enum_dir, exist_ok=True)
        
        # Generate enum files
        for enum_name, fields in enums:
            enum_code = generate_enum_code(enum_name, fields)
            enum_file_path = os.path.join(module_enum_dir, f"{enum_name}.cs")
            
            with open(enum_file_path, "w", encoding="utf-8") as f:
                f.write(enum_code)
    
    print(f"Generated enum files in {len(module_enums)} module directories")
    return module_enums


def main():
    # Load field mappings
    print("Loading field mappings...")
    field_mappings = load_field_mappings()
    print(f"Loaded {len(field_mappings)} field mappings")
    
    # Load table mappings
    print("Loading table mappings...")
    table_mappings = load_table_mappings()
    print(f"Loaded {len(table_mappings)} table mappings")
    
    # Load schema info
    print("Loading database schema...")
    schema_info = load_schema_info()
    print(f"Loaded schema for {len(schema_info)} tables")
    
    # Analyze schema for tables with enum fields
    print("Analyzing schema for enum fields...")
    enum_tables = analyze_schema_for_tables_with_enum_fields(schema_info)
    print(f"Found {len(enum_tables)} tables with potential enum fields")
    
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
    
    # Create detailed JSON report
    report = {
        "summary": {
            "total_enums": len(enum_fields),
            "total_fields": sum(len(fields) for fields in enum_fields.values()),
            "tables_with_enums": len(enum_tables)
        },
        "enums": {enum_name: [{"old_name": field.old_name, "new_name": field.new_name, "type": field.field_type} for field in fields] for enum_name, fields in enum_fields.items()},
        "enum_tables": {table_name: [{"name": col["name"], "type": col["type"]} for col in columns] for table_name, columns in enum_tables.items()}
    }
    
    with open(f"{ENUM_OUTPUT_DIR}/enum_analysis.json", "w", encoding="utf-8") as f:
        json.dump(report, f, indent=2, ensure_ascii=False)
    
    print(f"Report saved to {ENUM_OUTPUT_DIR}/enum_analysis.json")
    
    # Also try organizing enums by module
    print("\nOrganizing enums by module directory structure...")
    module_enums = generate_enum_files_in_modules()
    print(f"Completed organizing enums into module directories")


if __name__ == "__main__":
    main() 
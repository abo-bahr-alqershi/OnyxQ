#!/usr/bin/env python3
import os
import re
import json
from collections import defaultdict
import glob
from typing import Dict, List, Set, Tuple

# Configuration
FIELDS_DIR = "Scheme/Feilds"
TABLE_MAPPING_FILE = "Scheme/table_models_mapping.txt"

# Value object patterns
value_object_patterns = {
    # Contact info
    "ContactInfo": {
        "keywords": ["PHONE", "MOBILE", "EMAIL", "E_MAIL", "FAX", "WEB_SITE", "WEBSITE", "CONTACT", "HOTLINE", "TEL"],
        "min_matches": 2,
    },
    # Address
    "Address": {
        "keywords": ["ADDRESS", "CITY", "COUNTRY", "PROVINCE", "REGION", "BOX", "POSTAL", "BUILDING", "STREET", "ZIP"],
        "min_matches": 2,
    },
    # Personal info
    "PersonInfo": {
        "keywords": ["F_NM", "L_NM", "FIRST_NAME", "LAST_NAME", "BIRTH", "NATIONALITY", "PERSON", "NAME", "SEX", "GENDER"],
        "min_matches": 2,
    },
    # Identity
    "IdentityInfo": {
        "keywords": ["ID", "PASSPORT", "NATIONAL", "IDENT", "CARD", "LICENSE", "ISSUE_DATE", "EXPIRE", "SERIAL"],
        "min_matches": 2,
    },
    # Money/Currency
    "Money": {
        "keywords": ["AMT", "AMOUNT", "CURRENCY", "RATE", "PRICE", "COST", "DISCOUNT", "VAT", "TAX"],
        "min_matches": 2,
    },
    # Date Range
    "DateRange": {
        "keywords": ["FROM_DATE", "TO_DATE", "START_DATE", "END_DATE", "PERIOD", "DURATION", "STRT_DATE", "END_DATE"],
        "min_matches": 2,
    },
    # Dimensions
    "Dimension": {
        "keywords": ["WIDTH", "HEIGHT", "LENGTH", "SIZE", "WEIGHT", "VOLUME", "METER", "DIMENSION"],
        "min_matches": 2,
    },
    # Banking
    "BankInfo": {
        "keywords": ["BANK", "ACCOUNT", "IBAN", "SWIFT", "BRANCH", "BNK", "ACCNT"],
        "min_matches": 2,
    },
    # Location
    "Location": {
        "keywords": ["LAT", "LONG", "LATITUDE", "LONGITUDE", "COORDINATES", "GPS", "LOCATION", "MAP"],
        "min_matches": 2,
    },
    # Audit
    "AuditInfo": {
        "keywords": ["CREATED", "MODIFIED", "UPDATED", "USER_ID", "TERMINAL", "ACTIVE_DATE", "AUDIT"],
        "min_matches": 2,
    }
}

class Field:
    def __init__(self, old_name: str, new_name: str):
        self.old_name = old_name
        self.new_name = new_name
        self.value_object_candidates = []

    def __repr__(self):
        return f"{self.old_name} => {self.new_name}"

class Entity:
    def __init__(self, table_name: str, model_name: str, module: str):
        self.table_name = table_name
        self.model_name = model_name
        self.module = module
        self.fields = []
        self.value_objects = defaultdict(list)
    
    def add_field(self, field: Field):
        self.fields.append(field)
    
    def analyze_value_objects(self):
        # Clear existing analysis
        self.value_objects = defaultdict(list)
        
        # Group fields by possible value objects
        for field in self.fields:
            for vo_name, pattern in value_object_patterns.items():
                # Check if the field matches this value object type
                matches = sum(1 for keyword in pattern["keywords"] if keyword in field.old_name)
                if matches > 0:
                    field.value_object_candidates.append((vo_name, matches))
        
        # Assign fields to the best matching value object
        for field in self.fields:
            if field.value_object_candidates:
                # Sort by number of matches (descending)
                field.value_object_candidates.sort(key=lambda x: x[1], reverse=True)
                best_match = field.value_object_candidates[0]
                self.value_objects[best_match[0]].append(field)
        
        # Filter out value objects with too few matches
        to_remove = []
        for vo_name, fields in self.value_objects.items():
            min_matches = value_object_patterns[vo_name]["min_matches"]
            if len(fields) < min_matches:
                to_remove.append(vo_name)
        
        for vo_name in to_remove:
            del self.value_objects[vo_name]
    
    def get_value_object_summary(self):
        result = {}
        for vo_name, fields in self.value_objects.items():
            result[vo_name] = [field.new_name for field in fields]
        return result

    def __repr__(self):
        return f"{self.model_name} ({self.table_name}) in {self.module}"


def load_field_mappings() -> Dict[str, str]:
    """Load all field mappings from the markdown files in FIELDS_DIR"""
    field_mappings = {}
    
    # Get all markdown files in the directory
    files = glob.glob(os.path.join(FIELDS_DIR, "*.md"))
    
    for file_path in files:
        try:
            with open(file_path, 'r', encoding='utf-8') as f:
                for line in f:
                    line = line.strip()
                    if '=>' in line:
                        parts = line.split('=>')
                        if len(parts) == 2:
                            old_name = parts[0].strip()
                            new_name = parts[1].strip()
                            field_mappings[old_name] = new_name
        except Exception as e:
            print(f"Error reading {file_path}: {e}")
    
    return field_mappings


def load_table_mappings() -> Dict[str, Tuple[str, str]]:
    """Load table to model mappings from TABLE_MAPPING_FILE"""
    table_mappings = {}
    current_module = ""
    
    with open(TABLE_MAPPING_FILE, 'r', encoding='utf-8') as f:
        for line in f:
            line = line.strip()
            
            # Skip empty lines and comments that don't define modules
            if not line or line.startswith("#") and "(" not in line:
                continue
            
            # Check if this line defines a module
            if line.startswith("# ") and "(" in line:
                # Extract module name from format like "# النظام الأساسي (Core System)"
                module_match = re.search(r'\(([^)]+)\)', line)
                if module_match:
                    current_module = module_match.group(1).strip()
                continue
            
            # Parse table mapping line (e.g., "1. S_CMPNY => Company")
            mapping_match = re.match(r'(\d+)\.\s+([^\s]+)\s+=>\s+([^\s]+)', line)
            if mapping_match:
                table_number = mapping_match.group(1)
                table_name = mapping_match.group(2)
                model_name = mapping_match.group(3)
                table_mappings[table_name] = (model_name, current_module)
    
    return table_mappings


def identify_value_objects():
    """Main function to identify value objects in the models"""
    # Load field mappings
    print("Loading field mappings...")
    field_mappings = load_field_mappings()
    print(f"Loaded {len(field_mappings)} field mappings")
    
    # Load table mappings
    print("Loading table mappings...")
    table_mappings = load_table_mappings()
    print(f"Loaded {len(table_mappings)} table mappings")
    
    # Create entity objects
    entities = {}
    for table_name, (model_name, module) in table_mappings.items():
        entities[table_name] = Entity(table_name, model_name, module)
    
    # Infer which fields belong to which tables
    # We'll use a simple approach matching field prefixes with table names
    for old_field_name, new_field_name in field_mappings.items():
        # Try to find the matching table
        matched_table = None
        
        # Direct prefix match (e.g., ACCOUNT_NAME for table ACCOUNT)
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
            field = Field(old_field_name, new_field_name)
            entities[matched_table].add_field(field)
    
    # Analyze entities for value objects
    for entity_name, entity in entities.items():
        if entity.fields:  # Only analyze entities with fields
            entity.analyze_value_objects()
    
    # Prepare the results
    results = {
        "summary": {
            "total_entities": len(entities),
            "entities_with_fields": sum(1 for e in entities.values() if e.fields),
            "entities_with_value_objects": sum(1 for e in entities.values() if e.value_objects),
        },
        "entities": {}
    }
    
    # Add entities with value objects to the results
    for entity_name, entity in entities.items():
        if entity.value_objects:
            results["entities"][entity.model_name] = {
                "table_name": entity.table_name,
                "module": entity.module,
                "value_objects": entity.get_value_object_summary()
            }
    
    return results


def generate_guidelines():
    """Generate guidelines based on the value object identification"""
    results = identify_value_objects()
    
    print(f"Analysis complete:")
    print(f"Total entities: {results['summary']['total_entities']}")
    print(f"Entities with fields: {results['summary']['entities_with_fields']}")
    print(f"Entities with value objects: {results['summary']['entities_with_value_objects']}")
    
    # Save results to JSON
    with open("value_objects_analysis.json", "w", encoding="utf-8") as f:
        json.dump(results, f, indent=2, ensure_ascii=False)
    
    print("Results saved to value_objects_analysis.json")
    
    # Generate guidelines
    guidelines = []
    guidelines.append("# قواعد التنفيذ الآلي لاستخراج Value Objects في موديلات النطاق (Domain Models)")
    guidelines.append("\n## أنماط Value Objects الرئيسية وخصائصها")
    
    # Add value object pattern sections
    for vo_name, pattern in value_object_patterns.items():
        guidelines.append(f"\n### {vo_name}")
        guidelines.append(f"**الكلمات المفتاحية:** {', '.join(pattern['keywords'])}")
        guidelines.append(f"**الحد الأدنى للتطابق:** {pattern['min_matches']} خصائص")
        
        # Add example entities that have this value object
        example_entities = [
            (model_name, entity["value_objects"][vo_name])
            for model_name, entity in results["entities"].items()
            if vo_name in entity["value_objects"]
        ]
        
        if example_entities:
            guidelines.append("\n**أمثلة من الكيانات:**")
            for i, (model_name, fields) in enumerate(example_entities[:3]):  # Limit to 3 examples
                guidelines.append(f"- **{model_name}**: {', '.join(fields)}")
    
    # Write guidelines to file
    with open("value_objects_guidelines.md", "w", encoding="utf-8") as f:
        f.write("\n".join(guidelines))
    
    print("Guidelines saved to value_objects_guidelines.md")


if __name__ == "__main__":
    generate_guidelines() 
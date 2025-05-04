import os
import json
import re
import glob
from typing import Dict, List, Tuple, Set, Optional

# Configuration
MODULES_DIR = "Modules"
OUTPUT_JSON_PATH = "Scheme/output.json"
TABLE_MAPPING_PATH = "Scheme/table_models_mapping.txt"
FIELD_TYPES_PATH = "Scheme/field_types.txt"
FIELD_NAMES_DIR = "Scheme/Feilds"

# Define type mappings
DB_TYPE_TO_NET_TYPE = {}

# Module names (from table_models_mapping.txt)
MODULE_NAMES = {
    "النظام الأساسي": "CoreSystem",
    "الأنشطة": "Activities",
    "المستخدمين والصلاحيات": "UsersPermissions",
    "الأستاذ العام": "GeneralLedger",
    "الأصول الثابتة": "FixedAssets",
    "المالية والمحاسبة": "FinanceAccounting",
    "المبيعات والعملاء": "SalesCustomers",
    "المشتريات والموردين": "PurchasingVendors",
    "المخزون والمستودعات": "InventoryWarehousing",
    "الإنتاج والتصنيع": "ProductionManufacturing",
    "الخدمات والصيانة": "ServicesMaintenance",
    "الموارد البشرية": "HumanResources",
    "الحضور والانصراف": "Attendance",
    "التأمين والمطالبات": "InsuranceClaims",
    "الضمانات والكفالات": "GuaranteesWarranties",
    "المحطات والوقود": "StationsFuel",
    "النقل والشحن": "TransportationShipping",
    "الأطباء والمرضى": "DoctorsPatients",
    "المقالات والمحتوى": "ArticlesContent",
    "الأرشفة والمستندات": "ArchivingDocuments",
    "التتبع والمراقبة": "TrackingMonitoring",
    "المشاريع والمناطق": "ProjectsRegions",
    "الرسائل والإشعارات": "MessagesNotifications",
    "النماذج واستطلاعات الرأي": "FormsSurveys",
    "الإعدادات والمعلمات": "SettingsParameters",
    "النسخ والتكرار": "ReplicationDuplication",
    "القضاء والقانون": "JudicialLegal",
    "الضرائب والرسوم": "TaxFees",
    "خدمات الويب والواجهات": "WebServicesInterfaces",
    "الجداول المؤقتة": "TemporaryTables"
}

# Relationship types
class RelationshipType:
    ONE_TO_ONE = "OneToOne"
    ONE_TO_MANY = "OneToMany"
    MANY_TO_ONE = "ManyToOne"
    MANY_TO_MANY = "ManyToMany"

# DTO paths
class DotNetClass:
    def __init__(self, name: str, module: str):
        self.name = name
        self.module = module
        self.properties = []
        self.imports = set()
        self.related_entities = {}
        self.primary_keys = []
        self.foreign_keys = []
        # Fields for enhanced relationship detection
        self.incoming_relationships = {}  # Tables that reference this table
        self.outgoing_relationships = {}  # Tables this table references

    def add_property(self, name, type_name, is_key=False, summary_en="", summary_ar=""):
        self.properties.append({
            "name": name,
            "type": type_name,
            "is_key": is_key,
            "summary_en": summary_en,
            "summary_ar": summary_ar
        })

    def add_related_entity(self, name, type_name, relationship_type, is_collection=False):
        self.related_entities[name] = {
            "type": type_name,
            "relationship_type": relationship_type,
            "is_collection": is_collection
        }
        
    def set_primary_keys(self, keys: List[str]):
        self.primary_keys = keys
        
    def add_foreign_key(self, columns: List[str], references_table: str):
        self.foreign_keys.append({
            "columns": columns,
            "references_table": references_table
        })

    def add_incoming_relationship(self, table_name: str, columns: List[str], rel_type: str):
        """Add a table that references this table"""
        self.incoming_relationships[table_name] = {
            "columns": columns,
            "relationship_type": rel_type
        }

    def add_outgoing_relationship(self, table_name: str, columns: List[str], rel_type: str):
        """Add a table that this table references"""
        self.outgoing_relationships[table_name] = {
            "columns": columns,
            "relationship_type": rel_type
        }
        
    def generate_entity_file_content(self) -> str:
        """Generate C# entity class content"""
        base_path = f"ERP.Domain.ERP.{self.module}"
        imports = [
            "using System;",
            "using System.Collections.Generic;",
            "using ERP_Pro.Domain.Common.Primitives;",
            "using ERP_Pro.Domain.Common.ValueObjects;"
        ]
        
        if len(self.imports) > 0:
            for imp in self.imports:
                imports.append(f"using {imp};")
        
        class_content = []
        class_content.append("/// <summary>")
        class_content.append(f"/// {self.name} Entity")
        class_content.append("/// </summary>")
        class_content.append(f"public class {self.name} : Entity<{self.name}Id>")
        class_content.append("{")
        
        # Constructor
        class_content.append(f"    private {self.name}() {{ }}")
        
        # Properties
        for prop in self.properties:
            class_content.append("")
            class_content.append("    /// <summary>")
            if prop["summary_en"]:
                class_content.append(f"    /// {prop['summary_en']}")
            if prop["summary_ar"]:
                class_content.append(f"    /// {prop['summary_ar']}")
            class_content.append("    /// </summary>")
            class_content.append(f"    public {prop['type']} {prop['name']} {{ get; private set; }}")
        
        # Navigation properties
        if self.related_entities:
            class_content.append("")
            class_content.append("    #region Navigation Properties")
            for name, entity in self.related_entities.items():
                type_name = entity["type"]
                rel_type = entity.get("relationship_type", "")
                
                if rel_type == RelationshipType.ONE_TO_MANY or entity["is_collection"]:
                    class_content.append(f"    /// <summary>")
                    class_content.append(f"    /// One-to-many relationship: {self.name} to {type_name}")
                    class_content.append(f"    /// </summary>")
                    class_content.append(f"    public IReadOnlyCollection<{type_name}> {name} {{ get; private set; }}")
                else:
                    class_content.append(f"    /// <summary>")
                    class_content.append(f"    /// {rel_type} relationship to {type_name}")
                    class_content.append(f"    /// </summary>")
                    class_content.append(f"    public {type_name} {name} {{ get; private set; }}")
            class_content.append("    #endregion")
        
        class_content.append("}")
        
        return "\n".join(imports) + "\n\nnamespace ERP_Pro.Domain.ERP." + self.module + ".Entities\n{\n" + "\n".join(class_content) + "\n}\n"

    def generate_id_file_content(self) -> str:
        """Generate C# Id value object file content"""
        imports = [
            "using System;",
            "using ERP_Pro.Domain.Common.Primitives;"
        ]
        
        class_content = []
        class_content.append("/// <summary>")
        class_content.append(f"/// {self.name} Identifier Value Object")
        class_content.append("/// </summary>")
        class_content.append(f"public sealed class {self.name}Id : ValueObject")
        class_content.append("{")
        
        # Value property 
        class_content.append("    /// <summary>")
        class_content.append(f"    /// The unique identifier for the {self.name}")
        class_content.append("    /// </summary>")
        class_content.append("    public Guid Value { get; }")
        
        # Constructors
        class_content.append("")
        class_content.append("    /// <summary>")
        class_content.append(f"    /// Creates a new {self.name}Id instance")
        class_content.append("    /// </summary>")
        class_content.append(f"    public {self.name}Id(Guid value)")
        class_content.append("    {")
        class_content.append("        Value = value;")
        class_content.append("    }")
        
        # Factory method
        class_content.append("")
        class_content.append("    /// <summary>")
        class_content.append(f"    /// Creates a new {self.name}Id with a new GUID")
        class_content.append("    /// </summary>")
        class_content.append("    public static " + self.name + "Id CreateUnique()")
        class_content.append("    {")
        class_content.append("        return new " + self.name + "Id(Guid.NewGuid());")
        class_content.append("    }")
        
        # Value object implementation
        class_content.append("")
        class_content.append("    public override IEnumerable<object> GetEqualityComponents()")
        class_content.append("    {")
        class_content.append("        yield return Value;")
        class_content.append("    }")
        
        # Conversion from/to string
        class_content.append("")
        class_content.append("    public override string ToString() => Value.ToString();")
        
        # Implicit/explicit conversion operators
        class_content.append("")
        class_content.append(f"    public static implicit operator string({self.name}Id id) => id.Value.ToString();")
        class_content.append(f"    public static implicit operator Guid({self.name}Id id) => id.Value;")
        
        class_content.append("}")
        
        return "\n".join(imports) + "\n\nnamespace ERP_Pro.Domain.ERP." + self.module + ".ValueObjects\n{\n" + "\n".join(class_content) + "\n}\n"

    def generate_events_file_content(self) -> str:
        """Generate C# events file content"""
        imports = [
            "using System;",
            "using ERP_Pro.Domain.Common.Events;"
        ]
        
        class_content = []
        class_content.append("/// <summary>")
        class_content.append(f"/// Events related to {self.name} entity")
        class_content.append("/// </summary>")
        
        # Created Event
        class_content.append(f"public sealed class {self.name}CreatedEvent : DomainEvent")
        class_content.append("{")
        class_content.append(f"    public {self.name}Id {self.name}Id {{ get; }}")
        class_content.append("")
        class_content.append(f"    public {self.name}CreatedEvent({self.name}Id {self.name.lower()}Id)")
        class_content.append("    {")
        class_content.append(f"        {self.name}Id = {self.name.lower()}Id;")
        class_content.append("    }")
        class_content.append("}")
        
        # Updated Event
        class_content.append("")
        class_content.append(f"public sealed class {self.name}UpdatedEvent : DomainEvent")
        class_content.append("{")
        class_content.append(f"    public {self.name}Id {self.name}Id {{ get; }}")
        class_content.append("")
        class_content.append(f"    public {self.name}UpdatedEvent({self.name}Id {self.name.lower()}Id)")
        class_content.append("    {")
        class_content.append(f"        {self.name}Id = {self.name.lower()}Id;")
        class_content.append("    }")
        class_content.append("}")
        
        # Deleted Event
        class_content.append("")
        class_content.append(f"public sealed class {self.name}DeletedEvent : DomainEvent")
        class_content.append("{")
        class_content.append(f"    public {self.name}Id {self.name}Id {{ get; }}")
        class_content.append("")
        class_content.append(f"    public {self.name}DeletedEvent({self.name}Id {self.name.lower()}Id)")
        class_content.append("    {")
        class_content.append(f"        {self.name}Id = {self.name.lower()}Id;")
        class_content.append("    }")
        class_content.append("}")
        
        return "\n".join(imports) + "\n\nnamespace ERP_Pro.Domain.ERP." + self.module + ".Events\n{\n" + "\n".join(class_content) + "\n}\n"

def load_db_to_net_type_mapping():
    """Load database type to .NET type mapping from file"""
    global DB_TYPE_TO_NET_TYPE
    with open(FIELD_TYPES_PATH, 'r', encoding='utf-8') as f:
        for line in f:
            line = line.strip()
            if not line:
                continue
            parts = line.split('=>')
            if len(parts) == 2:
                db_type = parts[0].strip().split(',')[0].strip()
                net_type = parts[1].strip()
                DB_TYPE_TO_NET_TYPE[db_type] = net_type

def parse_module_table_mapping() -> Dict[str, Dict[str, str]]:
    """Parse the table_models_mapping.txt file to get module -> table -> model mapping"""
    module_table_mapping = {}
    current_module = None
    
    with open(TABLE_MAPPING_PATH, 'r', encoding='utf-8') as f:
        for line in f:
            line = line.strip()
            if not line or line.startswith('#'):
                # Check if this is a module definition line
                if line.startswith('# '):
                    module_name_match = re.search(r'# (.+?) \((.+?)\)', line)
                    if module_name_match:
                        arabic_name = module_name_match.group(1)
                        english_name = module_name_match.group(2)
                        if english_name in MODULE_NAMES.values():
                            current_module = english_name
                        elif arabic_name in MODULE_NAMES:
                            current_module = MODULE_NAMES[arabic_name]
                continue
            
            # Parse table -> model mapping
            mapping_match = re.search(r'\d+\.\s+(\S+)\s+=>\s+(\S+)', line)
            if mapping_match and current_module:
                old_table_name = mapping_match.group(1)
                new_model_name = mapping_match.group(2)
                
                if current_module not in module_table_mapping:
                    module_table_mapping[current_module] = {}
                    
                module_table_mapping[current_module][old_table_name] = new_model_name
    
    return module_table_mapping

def load_field_name_mapping() -> Dict[str, str]:
    """Load old field names to new field names mapping from all files in the directory"""
    field_mapping = {}
    
    for file_path in glob.glob(os.path.join(FIELD_NAMES_DIR, "*.md")):
        with open(file_path, 'r', encoding='utf-8') as f:
            for line in f:
                line = line.strip()
                if not line:
                    continue
                    
                parts = line.split('=>')
                if len(parts) == 2:
                    old_name = parts[0].strip()
                    new_name = parts[1].strip()
                    field_mapping[old_name] = new_name
    
    return field_mapping

def load_table_schema() -> Dict[str, Dict]:
    """Load table schema from output.json"""
    with open(OUTPUT_JSON_PATH, 'r', encoding='utf-8') as f:
        schema_data = json.load(f)
    
    # Create a dictionary of tables for easier lookup
    table_schema = {}
    
    # Handle both formats: array of tables or dictionary with table names as keys
    if isinstance(schema_data, list):
        # Format is an array of tables like output_tmp.json
        for table in schema_data:
            table_schema[table['name']] = table
    elif isinstance(schema_data, dict):
        # Format is a dictionary with table names as keys
        for table_name, table_data in schema_data.items():
            table_schema[table_name] = table_data
    
    return table_schema

def get_net_type_for_db_type(db_type: str) -> str:
    """Get the corresponding .NET type for a database type"""
    # Extract the base type (e.g., "NUMBER(3, 0)" -> "NUMBER(3, 0)")
    db_type_parts = db_type.split('(')
    if len(db_type_parts) > 1:
        base_type_with_params = db_type
    else:
        base_type_with_params = db_type
    
    if base_type_with_params in DB_TYPE_TO_NET_TYPE:
        return DB_TYPE_TO_NET_TYPE[base_type_with_params]
    
    # If not found with parameters, try just the base type
    base_type = db_type_parts[0]
    if base_type in DB_TYPE_TO_NET_TYPE:
        return DB_TYPE_TO_NET_TYPE[base_type]
    
    # Default to string if unknown
    print(f"Warning: Unknown DB type {db_type}, defaulting to string")
    return "string"

def create_module_directories(modules: List[str]) -> None:
    """Create the module directories"""
    if not os.path.exists(MODULES_DIR):
        os.makedirs(MODULES_DIR)
    
    for module in modules:
        module_path = os.path.join(MODULES_DIR, module)
        if not os.path.exists(module_path):
            os.makedirs(module_path)
        
        # Create subdirectories
        for subdir in ["Entities", "ValueObjects", "Events", "Enums"]:
            subdir_path = os.path.join(module_path, subdir)
            if not os.path.exists(subdir_path):
                os.makedirs(subdir_path)

def pluralize(name: str) -> str:
    """Pluralize a name for collection properties"""
    if name.endswith('y'):
        return name[:-1] + 'ies'
    elif name.endswith('s') or name.endswith('x') or name.endswith('z') or name.endswith('ch') or name.endswith('sh'):
        return name + 'es'
    else:
        return name + 's'

def analyze_relationships(module_table_mapping: Dict[str, Dict[str, str]], 
                         table_schema: Dict[str, Dict]) -> Dict[str, DotNetClass]:
    """
    Analyze relationships between tables and build a map of entities with their relationships
    Returns a dictionary mapping table names to DotNetClass objects
    """
    entities = {}
    
    # First, create all entity objects
    for module, table_mapping in module_table_mapping.items():
        for old_table, new_model in table_mapping.items():
            if old_table not in table_schema:
                continue
            
            if old_table not in entities:
                entities[old_table] = DotNetClass(new_model, module)
                if "primary_keys" in table_schema[old_table]:
                    entities[old_table].set_primary_keys(table_schema[old_table]["primary_keys"])
    
    # Build a dictionary to map from table name to entity/model name
    table_to_entity = {}
    for module, table_mapping in module_table_mapping.items():
        for old_table, new_model in table_mapping.items():
            table_to_entity[old_table] = new_model
    
    # First pass: Process direct foreign key relationships
    for old_table, entity in entities.items():
        table_data = table_schema.get(old_table, {})
        
        # Add foreign keys from this table
        foreign_keys = table_data.get("foreign_keys", [])
        for fk in foreign_keys:
            ref_table = fk["references_table"]
            if ref_table in table_to_entity:
                ref_entity_name = table_to_entity[ref_table]
                
                # Determine relationship type
                is_part_of_pk = False
                if "primary_keys" in table_data:
                    pk_columns = table_data["primary_keys"]
                    is_part_of_pk = any(column in pk_columns for column in fk["columns"])
                
                is_entire_pk = False
                if "primary_keys" in table_data:
                    pk_columns = table_data["primary_keys"]
                    is_entire_pk = set(fk["columns"]) == set(pk_columns) and len(fk["columns"]) > 0
                
                # Default relationship type
                rel_type = RelationshipType.MANY_TO_ONE
                
                if is_entire_pk:
                    rel_type = RelationshipType.ONE_TO_ONE
                elif is_part_of_pk and not is_entire_pk:
                    # Composite key with other non-FK columns
                    rel_type = RelationshipType.MANY_TO_ONE
                
                # Add relationship to this entity
                entity.add_related_entity(ref_entity_name, ref_entity_name, rel_type, False)
                
                # Add the inverse relationship to the referenced entity if it exists
                if ref_table in entities:
                    ref_entity = entities[ref_table]
                    inverse_rel_type = RelationshipType.ONE_TO_MANY if rel_type == RelationshipType.MANY_TO_ONE else RelationshipType.ONE_TO_ONE
                    
                    if inverse_rel_type == RelationshipType.ONE_TO_MANY:
                        # Use plural form for collections
                        plural_name = pluralize(entity.name)
                        ref_entity.add_related_entity(plural_name, entity.name, inverse_rel_type, True)
                    else:
                        ref_entity.add_related_entity(entity.name, entity.name, inverse_rel_type, False)
    
    # Second pass: Find junction tables for many-to-many relationships
    junction_tables = set()
    for old_table, entity in entities.items():
        table_data = table_schema.get(old_table, {})
        
        # Check if this is a junction table (only has foreign keys and composite primary key)
        if "foreign_keys" in table_data and "primary_keys" in table_data:
            foreign_keys = table_data["foreign_keys"]
            primary_keys = table_data["primary_keys"]
            
            # Junction table typically has at least 2 foreign keys 
            # and its primary key is composed entirely of those foreign keys
            if len(foreign_keys) >= 2:
                fk_columns = []
                for fk in foreign_keys:
                    fk_columns.extend(fk["columns"])
                
                # Check if primary key is composed entirely of foreign key columns
                if set(primary_keys).issubset(set(fk_columns)) and len(primary_keys) > 0:
                    junction_tables.add(old_table)
                    
                    # Get the tables referenced by this junction table
                    referenced_tables = [fk["references_table"] for fk in foreign_keys]
                    
                    # Make sure we have pairs of referenced tables
                    for i in range(len(referenced_tables)):
                        for j in range(i + 1, len(referenced_tables)):
                            table1 = referenced_tables[i]
                            table2 = referenced_tables[j]
                            
                            if table1 in entities and table2 in entities:
                                entity1 = entities[table1]
                                entity2 = entities[table2]
                                
                                # Add many-to-many relationships in both directions
                                plural_name2 = pluralize(entity2.name)
                                entity1.add_related_entity(plural_name2, entity2.name, RelationshipType.MANY_TO_MANY, True)
                                
                                plural_name1 = pluralize(entity1.name)
                                entity2.add_related_entity(plural_name1, entity1.name, RelationshipType.MANY_TO_MANY, True)
    
    # Third pass: Find indirect relationships (tables referenced by others)
    references = {}  # Map of tables to tables that reference them
    for old_table, table_data in table_schema.items():
        if "foreign_keys" in table_data:
            for fk in table_data["foreign_keys"]:
                ref_table = fk["references_table"]
                if ref_table not in references:
                    references[ref_table] = []
                
                references[ref_table].append((old_table, fk["columns"]))
    
    # Process indirect relationships
    for old_table, entity in entities.items():
        if old_table in references:
            for referencing_table, columns in references[old_table]:
                # Skip if we've already processed this as a junction table
                if referencing_table in junction_tables:
                    continue
                
                if referencing_table in entities:
                    referencing_entity = entities[referencing_table]
                    
                    # Determine the relationship type based on primary keys
                    ref_table_data = table_schema.get(referencing_table, {})
                    is_part_of_pk = False
                    if "primary_keys" in ref_table_data:
                        pk_columns = ref_table_data["primary_keys"]
                        is_part_of_pk = any(column in pk_columns for column in columns)
                    
                    is_entire_pk = False
                    if "primary_keys" in ref_table_data:
                        pk_columns = ref_table_data["primary_keys"]
                        is_entire_pk = set(columns) == set(pk_columns) and len(columns) > 0
                    
                    # Determine relationship type
                    if is_entire_pk:
                        rel_type = RelationshipType.ONE_TO_ONE
                    else:
                        rel_type = RelationshipType.ONE_TO_MANY
                    
                    # Add the relationship if it doesn't already exist
                    has_relationship = False
                    for rel_name, rel_data in entity.related_entities.items():
                        if rel_name == pluralize(referencing_entity.name) or rel_name == referencing_entity.name:
                            has_relationship = True
                            break
                    
                    if not has_relationship:
                        if rel_type == RelationshipType.ONE_TO_MANY:
                            plural_name = pluralize(referencing_entity.name)
                            entity.add_related_entity(plural_name, referencing_entity.name, rel_type, True)
                        else:
                            entity.add_related_entity(referencing_entity.name, referencing_entity.name, rel_type, False)
    
    return entities

def generate_entity_files(module_table_mapping: Dict[str, Dict[str, str]], 
                         table_schema: Dict[str, Dict],
                         field_mapping: Dict[str, str]) -> None:
    """Generate entity class files for each model"""
    # Analyze relationships between tables
    entities = analyze_relationships(module_table_mapping, table_schema)
    
    # Create a mapping from old table names to their corresponding entities
    old_table_to_entity = {}
    for old_table, entity in entities.items():
        old_table_to_entity[old_table] = entity
    
    # Process each table
    for module, table_mapping in module_table_mapping.items():
        for old_table, new_model in table_mapping.items():
            if old_table not in table_schema:
                print(f"Warning: Table {old_table} not found in schema")
                continue
            
            table_data = table_schema[old_table]
            
            # Get the pre-analyzed entity if available, otherwise create a new one
            if old_table in entities:
                entity = entities[old_table]
            else:
                entity = DotNetClass(new_model, module)
            
            # Add ID property
            entity.add_property("Id", f"{new_model}Id", True, 
                               f"The unique identifier for the {new_model}",
                               f"المعرف الفريد لـ {new_model}")
            
            # Add properties based on table columns
            if "columns" in table_data:
                for column in table_data["columns"]:
                    old_field_name = column["name"]
                    field_type = column["type"]
                    
                    # Skip system fields like AD_DATE, AD_U_ID, etc.
                    if old_field_name in ['AD_DATE', 'AD_U_ID', 'UP_DATE', 'UP_U_ID', 'UP_CNT', 'PR_REP', 
                                        'AD_TRMNL_NM', 'UP_TRMNL_NM']:
                        continue
                    
                    # Use new field name if available
                    if old_field_name in field_mapping:
                        new_field_name = field_mapping[old_field_name]
                    else:
                        # Convert snake_case to PascalCase
                        words = old_field_name.lower().split('_')
                        new_field_name = ''.join(word.capitalize() for word in words)
                    
                    # Get .NET type
                    net_type = get_net_type_for_db_type(field_type)
                    
                    # Add property
                    is_key = "primary_keys" in table_data and old_field_name in table_data["primary_keys"]
                    entity.add_property(new_field_name, net_type, is_key, 
                                     f"{new_field_name} of the {new_model}",
                                     f"{new_field_name} الخاص بـ {new_model}")
            
            # Set primary keys
            if "primary_keys" in table_data:
                entity.set_primary_keys(table_data["primary_keys"])
            
            # Handle foreign keys for import statements
            if "foreign_keys" in table_data:
                for fk in table_data["foreign_keys"]:
                    ref_table = fk["references_table"]
                    
                    # Find the module for the referenced table
                    for ref_module, ref_tables in module_table_mapping.items():
                        if ref_table in ref_tables and ref_module != module:
                            entity.imports.add(f"ERP_Pro.Domain.ERP.{ref_module}.Entities")
                            break
            
            # Generate and write entity class file
            entity_path = os.path.join(MODULES_DIR, module, "Entities", f"{new_model}.cs")
            with open(entity_path, 'w', encoding='utf-8') as f:
                f.write(entity.generate_entity_file_content())
            
            # Generate and write ID value object file
            id_path = os.path.join(MODULES_DIR, module, "ValueObjects", f"{new_model}Id.cs")
            with open(id_path, 'w', encoding='utf-8') as f:
                f.write(entity.generate_id_file_content())
            
            # Generate and write events file
            events_path = os.path.join(MODULES_DIR, module, "Events", f"{new_model}Events.cs")
            with open(events_path, 'w', encoding='utf-8') as f:
                f.write(entity.generate_events_file_content())

def main():
    # Load mappings and schema
    load_db_to_net_type_mapping()
    module_table_mapping = parse_module_table_mapping()
    field_mapping = load_field_name_mapping()
    table_schema = load_table_schema()
    
    # Create directory structure
    create_module_directories(module_table_mapping.keys())
    
    # Generate entity files
    generate_entity_files(module_table_mapping, table_schema, field_mapping)
    
    print(f"Model generation completed successfully. Files created in {MODULES_DIR} directory.")

if __name__ == "__main__":
    main() 
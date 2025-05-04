import os
import json
import re
import glob
from typing import Dict, List, Tuple, Set, Optional, Any

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

class Relationship:
    def __init__(self, from_entity: str, to_entity: str, 
                 from_fields: List[str], to_fields: List[str], 
                 type: str, navigation_property: str = None):
        self.from_entity = from_entity
        self.to_entity = to_entity
        self.from_fields = from_fields
        self.to_fields = to_fields
        self.type = type
        self.navigation_property = navigation_property if navigation_property else to_entity
        
    def __repr__(self):
        return f"Relationship({self.from_entity} → {self.to_entity}, {self.type}, {self.from_fields} → {self.to_fields})"

class Entity:
    def __init__(self, name: str, module: str, old_table_name: str):
        self.name = name
        self.module = module
        self.old_table_name = old_table_name
        self.properties = []
        self.imports = set()
        self.primary_keys = []
        self.foreign_keys = []
        self.relationships = []  # List of outgoing relationships 
        self.inverse_relationships = []  # List of incoming relationships
    
    def add_property(self, name: str, type_name: str, is_key: bool = False, 
                     summary_en: str = "", summary_ar: str = "",
                     nullable: bool = True):
        # Add nullable marker (?) for value types if nullable
        is_value_type = (type_name in ["int", "long", "decimal", "float", "double", 
                                     "DateTime", "bool", "Guid", "short", "byte"])
        
        # Only add nullable marker for value types 
        if nullable and is_value_type:
            type_name = f"{type_name}?"
            
        self.properties.append({
            "name": name,
            "type": type_name,
            "is_key": is_key,
            "summary_en": summary_en,
            "summary_ar": summary_ar,
            "nullable": nullable
        })
        
    def set_primary_keys(self, keys: List[str]):
        self.primary_keys = keys
        
    def add_foreign_key(self, columns: List[str], references_table: str):
        self.foreign_keys.append({
            "columns": columns,
            "references_table": references_table
        })
        
    def add_relationship(self, relationship: Relationship):
        self.relationships.append(relationship)
        
    def add_inverse_relationship(self, relationship: Relationship):
        self.inverse_relationships.append(relationship)
        
    def get_all_relationships(self):
        return self.relationships + self.inverse_relationships
        
    def generate_entity_file_content(self) -> str:
        """Generate C# entity class content"""
        # Add imports for referenced entities from other modules
        base_path = f"ERP.Domain.ERP.{self.module}"
        imports = [
            "using System;",
            "using System.Collections.Generic;",
            "using ERP_Pro.Domain.Common.Primitives;",
            "using ERP_Pro.Domain.Common.ValueObjects;"
        ]
        
        # Add module-specific imports
        module_imports = {}
        for rel in self.get_all_relationships():
            if rel.from_entity == self.name:
                # This is a relationship to another entity
                entity_module = find_entity_module(rel.to_entity, rel.to_entity)
                if entity_module and entity_module != self.module:
                    module_imports[entity_module] = True
            elif rel.to_entity == self.name:
                # This is a relationship from another entity
                entity_module = find_entity_module(rel.from_entity, rel.from_entity)
                if entity_module and entity_module != self.module:
                    module_imports[entity_module] = True
        
        for module_name in module_imports.keys():
            imports.append(f"using ERP_Pro.Domain.ERP.{module_name}.Entities;")
        
        # Add user-specific imports
        for imp in self.imports:
            if imp not in imports:
                imports.append(f"using {imp};")
        
        # Class definition and documentation
        class_content = []
        class_content.append("/// <summary>")
        class_content.append(f"/// {self.name} Entity")
        class_content.append("/// </summary>")
        class_content.append(f"public class {self.name} : Entity<{self.name}Id>")
        class_content.append("{")

        # Add private backing fields for collections 
        collection_backing_fields = []
        
        # Process all relationships
        outgoing_relationships = {}
        incoming_relationships = {}
        
        # Process outgoing relationships
        for rel in self.relationships:
            if rel.from_entity == self.name:
                property_name = rel.navigation_property
                entity_type = rel.to_entity
                
                if rel.type in [RelationshipType.ONE_TO_MANY, RelationshipType.MANY_TO_MANY]:
                    outgoing_relationships[property_name] = {
                        "type": entity_type,
                        "relationship_type": rel.type,
                        "is_collection": True
                    }
                    # Add backing field for collection
                    field_name = f"_{property_name[0].lower()}{property_name[1:]}"
                    collection_backing_fields.append((field_name, entity_type, property_name))
                else:
                    outgoing_relationships[property_name] = {
                        "type": entity_type,
                        "relationship_type": rel.type,
                        "is_collection": False
                    }
                    
        # Process inverse relationships
        for rel in self.inverse_relationships:
            if rel.to_entity == self.name:
                # For inverse relationships, we need to determine the property name
                if rel.type == RelationshipType.ONE_TO_MANY:
                    # This is a collection on the inverse side
                    property_name = pluralize(rel.from_entity)
                    incoming_relationships[property_name] = {
                        "type": rel.from_entity,
                        "relationship_type": RelationshipType.MANY_TO_ONE,  # Inverse of ONE_TO_MANY
                        "is_collection": True
                    }
                    # Add backing field for collection
                    field_name = f"_{property_name[0].lower()}{property_name[1:]}"
                    collection_backing_fields.append((field_name, rel.from_entity, property_name))
                elif rel.type == RelationshipType.MANY_TO_ONE:
                    # This is a single reference on the inverse side
                    property_name = rel.from_entity
                    incoming_relationships[property_name] = {
                        "type": rel.from_entity,
                        "relationship_type": RelationshipType.ONE_TO_MANY,  # Inverse of MANY_TO_ONE
                        "is_collection": False
                    }
                elif rel.type == RelationshipType.ONE_TO_ONE:
                    # This is a single reference on the inverse side
                    property_name = rel.from_entity
                    incoming_relationships[property_name] = {
                        "type": rel.from_entity,
                        "relationship_type": RelationshipType.ONE_TO_ONE,
                        "is_collection": False
                    }
                elif rel.type == RelationshipType.MANY_TO_MANY:
                    # This is a collection on the inverse side
                    property_name = pluralize(rel.from_entity)
                    incoming_relationships[property_name] = {
                        "type": rel.from_entity,
                        "relationship_type": RelationshipType.MANY_TO_MANY,
                        "is_collection": True
                    }
                    # Add backing field for collection
                    field_name = f"_{property_name[0].lower()}{property_name[1:]}"
                    collection_backing_fields.append((field_name, rel.from_entity, property_name))
        
        # Add private backing fields for collections
        for field_name, entity_type, property_name in collection_backing_fields:
            class_content.append(f"    private readonly List<{entity_type}> {field_name} = new List<{entity_type}>();")
        
        # Private default constructor 
        class_content.append("")
        class_content.append(f"    private {self.name}() {{ }}")
        
        # Generate constructor with required parameters
        required_props = [p for p in self.properties if p["is_key"] or not p["nullable"]]
        if required_props:
            constructor_params = []
            constructor_body = []
            
            for prop in required_props:
                param_name = prop["name"][0].lower() + prop["name"][1:]
                constructor_params.append(f"{prop['type']} {param_name}")
                constructor_body.append(f"        {prop['name']} = {param_name};")
            
            class_content.append("")
            class_content.append(f"    public {self.name}({', '.join(constructor_params)})")
            class_content.append("    {")
            class_content.append("\n".join(constructor_body))
            class_content.append("    }")
        
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
        if outgoing_relationships or incoming_relationships:
            class_content.append("")
            class_content.append("    #region Navigation Properties")
            
            # Combine all relationships
            all_relationships = {**outgoing_relationships, **incoming_relationships}
            
            for name, entity in all_relationships.items():
                type_name = entity["type"]
                rel_type = entity.get("relationship_type", "")
                
                if entity["is_collection"]:
                    field_name = f"_{name[0].lower()}{name[1:]}"
                    class_content.append("    /// <summary>")
                    class_content.append(f"    /// Collection relationship: {rel_type}")
                    class_content.append("    /// </summary>")
                    class_content.append(f"    public ICollection<{type_name}> {name} => {field_name};")
                else:
                    class_content.append("    /// <summary>")
                    class_content.append(f"    /// Reference relationship: {rel_type}")
                    class_content.append("    /// </summary>")
                    class_content.append(f"    public {type_name} {name} {{ get; private set; }}")
            
            class_content.append("    #endregion")
            
        # Methods region for domain logic
        class_content.append("")
        class_content.append("    #region Methods")
        class_content.append("    // Add domain logic methods here")
        class_content.append("    #endregion")
        
        # Class end
        class_content.append("}")
        
        # Generate complete file with namespace and imports
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
            "using ERP_Pro.Domain.Common.Events;",
            f"using ERP_Pro.Domain.ERP.{self.module}.ValueObjects;"
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

# Global entity registry (old_table_name -> Entity)
entity_registry = {}
entity_name_registry = {}  # model_name -> Entity

def find_entity_module(entity_name, entity_table_name=None):
    """Find the module for a given entity"""
    if entity_name in entity_name_registry:
        return entity_name_registry[entity_name].module
    
    if entity_table_name and entity_table_name in entity_registry:
        return entity_registry[entity_table_name].module
    
    return None

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
                if not line or '=>' not in line:
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
    
    return schema_data

def get_net_type_for_db_type(db_type: str) -> str:
    """Get the corresponding .NET type for a database type"""
    # Extract the base type (e.g., "NUMBER(3, 0)" -> "NUMBER")
    db_type_parts = db_type.split('(')
    base_type_with_params = db_type
    base_type = db_type_parts[0]
    
    # Try with full type and parameters first
    if base_type_with_params in DB_TYPE_TO_NET_TYPE:
        return DB_TYPE_TO_NET_TYPE[base_type_with_params]
    
    # Then try with just the base type
    if base_type in DB_TYPE_TO_NET_TYPE:
        return DB_TYPE_TO_NET_TYPE[base_type]
    
    # Default to string if unknown
    print(f"Warning: Unknown DB type {db_type}, defaulting to string")
    return "string"

def pluralize(name: str) -> str:
    """Pluralize a name for collection properties"""
    if name.endswith('y') and name[-2] not in 'aeiou':
        return name[:-1] + 'ies'
    elif name.endswith('s') or name.endswith('x') or name.endswith('z') or name.endswith('ch') or name.endswith('sh'):
        return name + 'es'
    else:
        return name + 's'

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

def create_entities(module_table_mapping: Dict[str, Dict[str, str]], 
                   table_schema: Dict[str, Dict]) -> Dict[str, Entity]:
    """Create entity objects from table schema"""
    for module, table_mapping in module_table_mapping.items():
        for old_table, new_model in table_mapping.items():
            if old_table not in table_schema:
                continue
            
            entity = Entity(new_model, module, old_table)
            entity_registry[old_table] = entity
            entity_name_registry[new_model] = entity
            
            # Set primary keys
            if "primary_keys" in table_schema[old_table]:
                entity.set_primary_keys(table_schema[old_table]["primary_keys"])
            
            # Add foreign keys
            if "foreign_keys" in table_schema[old_table]:
                for fk in table_schema[old_table]["foreign_keys"]:
                    entity.add_foreign_key(fk["columns"], fk["references_table"])
    
    return entity_registry

def analyze_relationships(entity_registry: Dict[str, Entity], 
                         table_schema: Dict[str, Dict],
                         module_table_mapping: Dict[str, Dict[str, str]]) -> None:
    """Analyze and set up relationships between entities"""
    # First, set up entity name lookup (from old table name to new entity name)
    old_table_to_entity_name = {}
    for module, table_mapping in module_table_mapping.items():
        for old_table, new_model in table_mapping.items():
            old_table_to_entity_name[old_table] = new_model
    
    # For each entity, analyze its foreign keys to establish relationships
    for old_table_name, entity in entity_registry.items():
        if old_table_name not in table_schema:
            continue
            
        table_data = table_schema[old_table_name]
        
        # Process foreign keys to establish outgoing (many-to-one) relationships
        if "foreign_keys" in table_data:
            # Tracking navigation property names to handle duplicates
            navigation_property_counts = {}
            
            for fk in table_data["foreign_keys"]:
                ref_table = fk["references_table"]
                if ref_table not in old_table_to_entity_name:
                    continue  # Skip if referenced table is not mapped
                
                ref_entity_name = old_table_to_entity_name[ref_table]
                fk_columns = fk["columns"]
                ref_entity = entity_registry.get(ref_table)
                
                if not ref_entity:
                    continue  # Skip if referenced entity is not found
                
                # Determine the relationship type based on primary keys
                
                # Check if this FK is the entire primary key
                is_entire_pk = False
                if "primary_keys" in table_data and table_data["primary_keys"]:
                    is_entire_pk = set(fk_columns) == set(table_data["primary_keys"])
                
                # Get the target table's primary keys
                ref_primary_keys = []
                if "primary_keys" in table_schema.get(ref_table, {}):
                    ref_primary_keys = table_schema[ref_table]["primary_keys"]
                
                # Determine relationship type
                if is_entire_pk and len(fk_columns) == 1 and len(ref_primary_keys) == 1:
                    # One-to-one relationship if this foreign key is the primary key
                    rel_type = RelationshipType.ONE_TO_ONE
                else:
                    # Default many-to-one relationship (this entity has a foreign key to another entity)
                    rel_type = RelationshipType.MANY_TO_ONE
                    
                    # Check for junction table (many-to-many) pattern
                    if ("foreign_keys" in table_data and len(table_data["foreign_keys"]) >= 2 and
                        "primary_keys" in table_data and 
                        all(any(pk == fk_col for fk_col in fk_col_list["columns"]) 
                            for pk in table_data["primary_keys"] 
                            for fk_col_list in table_data["foreign_keys"])):
                        # This appears to be a junction table for many-to-many relationship
                        rel_type = RelationshipType.MANY_TO_MANY
                
                # Handle duplicate navigation properties by adding a suffix
                nav_property = ref_entity_name
                if nav_property in navigation_property_counts:
                    navigation_property_counts[nav_property] += 1
                    # Use the column name to make the navigation property unique
                    if fk_columns and len(fk_columns) > 0:
                        # Try to use foreign key column name to create a meaningful navigation property name
                        column_suffix = ''.join(col.capitalize() for col in fk_columns[0].split('_'))
                        nav_property = f"{nav_property}{column_suffix}"
                    else:
                        # Fallback to using a number
                        nav_property = f"{nav_property}{navigation_property_counts[nav_property]}"
                else:
                    navigation_property_counts[nav_property] = 1
                
                # Create and add the relationship
                relationship = Relationship(
                    from_entity=entity.name,
                    to_entity=ref_entity_name,
                    from_fields=fk_columns,
                    to_fields=ref_primary_keys,
                    type=rel_type,
                    navigation_property=nav_property
                )
                
                entity.add_relationship(relationship)
                
                # Add the inverse relationship to the referenced entity
                if rel_type == RelationshipType.MANY_TO_ONE:
                    inverse_rel_type = RelationshipType.ONE_TO_MANY
                elif rel_type == RelationshipType.ONE_TO_ONE:
                    inverse_rel_type = RelationshipType.ONE_TO_ONE
                else:  # MANY_TO_MANY
                    inverse_rel_type = RelationshipType.MANY_TO_MANY
                
                # Use entity name as the inverse navigation property
                inverse_nav_property = entity.name
                
                inverse_relationship = Relationship(
                    from_entity=ref_entity_name,
                    to_entity=entity.name,
                    from_fields=ref_primary_keys,
                    to_fields=fk_columns,
                    type=inverse_rel_type,
                    navigation_property=inverse_nav_property
                )
                
                ref_entity.add_inverse_relationship(inverse_relationship)

def add_properties_to_entities(entity_registry: Dict[str, Entity], 
                             table_schema: Dict[str, Dict],
                             field_mapping: Dict[str, str]) -> None:
    """Add properties to entities based on table columns"""
    for old_table_name, entity in entity_registry.items():
        if old_table_name not in table_schema:
            continue
            
        table_data = table_schema[old_table_name]
        
        # Add ID property for domain entities
        entity.add_property("Id", f"{entity.name}Id", True, 
                         f"The unique identifier for the {entity.name}",
                         f"المعرف الفريد لـ {entity.name}",
                         nullable=False)
        
        # Add properties based on table columns
        for column in table_data["columns"]:
            old_field_name = column["name"]
            field_type = column["type"]
            
            # Skip system audit fields
            if old_field_name in ['AD_DATE', 'AD_U_ID', 'UP_DATE', 'UP_U_ID', 'UP_CNT', 'PR_REP', 
                                  'AD_TRMNL_NM', 'UP_TRMNL_NM']:
                continue
            
            # Use new field name if available, otherwise convert from snake_case
            if old_field_name in field_mapping:
                new_field_name = field_mapping[old_field_name]
            else:
                # Convert snake_case to PascalCase
                words = old_field_name.lower().split('_')
                new_field_name = ''.join(word.capitalize() for word in words)
            
            # Get .NET type
            net_type = get_net_type_for_db_type(field_type)
            
            # Determine nullability based on field type and primary key
            nullable = True
            is_key = "primary_keys" in table_data and old_field_name in table_data["primary_keys"]
            
            if is_key:
                nullable = False
            
            # For foreign key fields, we'll add the navigation property instead
            is_foreign_key = False
            if "foreign_keys" in table_data:
                for fk in table_data["foreign_keys"]:
                    if old_field_name in fk["columns"]:
                        is_foreign_key = True
                        break
            
            # Only add the property if it's not a foreign key field that will be replaced by a navigation property
            if not is_foreign_key:
                entity.add_property(
                    name=new_field_name, 
                    type_name=net_type, 
                    is_key=is_key,
                    summary_en=f"{new_field_name} of the {entity.name}",
                    summary_ar=f"{new_field_name} الخاص بـ {entity.name}",
                    nullable=nullable
                )

def write_entity_files(entity: Entity) -> None:
    """Write entity class files to disk"""
    module_path = os.path.join(MODULES_DIR, entity.module)
    
    # Entity class file
    entity_file_path = os.path.join(module_path, "Entities", f"{entity.name}.cs")
    with open(entity_file_path, 'w', encoding='utf-8') as f:
        f.write(entity.generate_entity_file_content())
    
    # ID value object file
    id_file_path = os.path.join(module_path, "ValueObjects", f"{entity.name}Id.cs")
    with open(id_file_path, 'w', encoding='utf-8') as f:
        f.write(entity.generate_id_file_content())
    
    # Events file
    events_file_path = os.path.join(module_path, "Events", f"{entity.name}Events.cs")
    with open(events_file_path, 'w', encoding='utf-8') as f:
        f.write(entity.generate_events_file_content())

def main():
    # Load mappings and schema
    print("Loading database type mappings...")
    load_db_to_net_type_mapping()
    
    print("Parsing module table mappings...")
    module_table_mapping = parse_module_table_mapping()
    
    print("Loading field name mappings...")
    field_mapping = load_field_name_mapping()
    
    print("Loading table schema...")
    table_schema = load_table_schema()
    
    # Create directory structure
    print("Creating module directories...")
    create_module_directories(module_table_mapping.keys())
    
    # Create entities
    print("Creating entity objects...")
    entity_registry = create_entities(module_table_mapping, table_schema)
    
    # Analyze relationships
    print("Analyzing relationships between entities...")
    analyze_relationships(entity_registry, table_schema, module_table_mapping)
    
    # Add properties to entities
    print("Adding properties to entities...")
    add_properties_to_entities(entity_registry, table_schema, field_mapping)
    
    # Verify relationships
    print("Verifying relationships consistency...")
    verify_relationships(entity_registry, table_schema, module_table_mapping)
    
    # Write entity files
    print("Writing entity files...")
    entity_count = 0
    relationship_count = 0
    for entity in entity_registry.values():
        write_entity_files(entity)
        entity_count += 1
        relationship_count += len(entity.relationships)
    
    print(f"Model generation completed successfully. Created {entity_count} entities with {relationship_count} relationships in {len(module_table_mapping.keys())} modules.")

def verify_relationships(entity_registry: Dict[str, Entity], 
                       table_schema: Dict[str, Dict],
                       module_table_mapping: Dict[str, Dict[str, str]]) -> None:
    """Verify that all foreign keys in the schema have corresponding relationships in entities"""
    old_to_new = {}
    new_to_old = {}
    for module, table_mapping in module_table_mapping.items():
        for old_table, new_model in table_mapping.items():
            old_to_new[old_table] = new_model
            new_to_old[new_model] = old_table
    
    missing_relationships = []
    bad_mappings = []
    fixed_entities = []
    
    for old_table_name, table_info in table_schema.items():
        if "foreign_keys" not in table_info or not table_info["foreign_keys"]:
            continue
            
        entity_name = old_to_new.get(old_table_name)
        if not entity_name:
            bad_mappings.append(old_table_name)
            continue
            
        entity = entity_registry.get(old_table_name)
        if not entity:
            missing_relationships.append(f"Table {old_table_name} mapped to {entity_name} not found in entity registry")
            continue
        
        # Check that all foreign keys have been mapped to relationships
        fk_count = len(table_info.get("foreign_keys", []))
        relationship_count = len(entity.relationships)
        
        if fk_count != relationship_count:
            missing_relationships.append(f"Entity {entity_name} (table {old_table_name}) has {fk_count} FKs but only {relationship_count} relationships")
            
            # Force recreate all relationships for this entity
            entity.relationships = []  # Clear existing relationships
            relationships_added = 0
            
            for fk in table_info.get("foreign_keys", []):
                ref_table = fk["references_table"]
                if ref_table not in old_to_new:
                    continue  # Skip if referenced table is not mapped
                    
                ref_entity_name = old_to_new.get(ref_table)
                ref_entity = entity_registry.get(ref_table)
                
                if not ref_entity:
                    continue  # Skip if referenced entity not found
                
                # Get the target table's primary keys
                ref_primary_keys = []
                if "primary_keys" in table_schema.get(ref_table, {}):
                    ref_primary_keys = table_schema[ref_table]["primary_keys"]
                
                # Create and add the relationship
                relationship = Relationship(
                    from_entity=entity.name,
                    to_entity=ref_entity_name,
                    from_fields=fk["columns"],
                    to_fields=ref_primary_keys,
                    type=RelationshipType.MANY_TO_ONE,
                    navigation_property=ref_entity_name
                )
                
                entity.add_relationship(relationship)
                relationships_added += 1
                
                # Add the inverse relationship to the referenced entity
                inverse_relationship = Relationship(
                    from_entity=ref_entity_name,
                    to_entity=entity.name,
                    from_fields=ref_primary_keys,
                    to_fields=fk["columns"],
                    type=RelationshipType.ONE_TO_MANY,
                    navigation_property=entity.name
                )
                
                ref_entity.add_inverse_relationship(inverse_relationship)
            
            if relationships_added > 0:
                fixed_entities.append(entity.name)
                print(f"Fixed entity {entity.name}: Added {relationships_added} relationships")
    
    # Check special cases that need attention
    branch_entity = None
    for entity in entity_registry.values():
        if entity.name == "Branch":
            branch_entity = entity
            break
    
    if branch_entity and len(branch_entity.relationships) == 0:
        # Check that Branch has the expected relationships
        old_table_name = new_to_old.get("Branch")
        if old_table_name and old_table_name in table_schema:
            table_info = table_schema[old_table_name]
            if "foreign_keys" in table_info:
                print(f"Manually fixing Branch entity relationships...")
                
                for fk in table_info["foreign_keys"]:
                    ref_table = fk["references_table"]
                    if ref_table not in old_to_new:
                        continue  # Skip if referenced table is not mapped
                        
                    ref_entity_name = old_to_new.get(ref_table)
                    ref_entity = entity_registry.get(ref_table)
                    
                    if not ref_entity:
                        continue  # Skip if referenced entity not found
                    
                    # Add the relationship
                    relationship = Relationship(
                        from_entity="Branch",
                        to_entity=ref_entity_name,
                        from_fields=fk["columns"],
                        to_fields=[],  # We don't have this info, but it's not critical
                        type=RelationshipType.MANY_TO_ONE,
                        navigation_property=ref_entity_name
                    )
                    
                    branch_entity.add_relationship(relationship)
                    print(f"  Added relationship: Branch -> {ref_entity_name}")
                
                fixed_entities.append("Branch")
    
    if fixed_entities:
        print(f"Fixed relationships in {len(fixed_entities)} entities: {', '.join(fixed_entities[:5])}{'...' if len(fixed_entities) > 5 else ''}")
    
    if missing_relationships:
        print(f"Warning: Found {len(missing_relationships)} entities with missing relationships")
    
    if bad_mappings:
        print(f"Warning: {len(bad_mappings)} tables in the schema have no mapping to entity names")

if __name__ == "__main__":
    main() 
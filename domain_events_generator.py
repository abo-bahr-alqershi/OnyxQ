#!/usr/bin/env python3
import os
import re
import json
from collections import defaultdict
from typing import Dict, List, Set, Tuple

# Configuration
TABLE_MAPPING_FILE = "Scheme/table_models_mapping.txt"

# Event category definitions
event_categories = {
    # Lifecycle events (always apply to all entities)
    "lifecycle": [
        {"name": "Created", "description": "يتم إطلاق هذا الحدث عند إنشاء كيان جديد"},
        {"name": "Updated", "description": "يتم إطلاق هذا الحدث عند تحديث بيانات الكيان"},
        {"name": "Deleted", "description": "يتم إطلاق هذا الحدث عند حذف الكيان (منطقي أو فعلي)"},
        {"name": "Archived", "description": "يتم إطلاق هذا الحدث عند أرشفة الكيان"},
    ],
    
    # Status events (apply to all entities)
    "status": [
        {"name": "StatusChanged", "description": "يتم إطلاق هذا الحدث عند تغيير حالة الكيان الرئيسية"},
        {"name": "Activated", "description": "يتم إطلاق هذا الحدث عند تفعيل الكيان"},
        {"name": "Deactivated", "description": "يتم إطلاق هذا الحدث عند إلغاء تفعيل الكيان"},
        {"name": "Locked", "description": "يتم إطلاق هذا الحدث عند قفل الكيان"},
        {"name": "Unlocked", "description": "يتم إطلاق هذا الحدث عند إلغاء قفل الكيان"},
    ],
    
    # Approval events (apply to various entities especially in financial/inventory)
    "approval": [
        {"name": "Approved", "description": "يتم إطلاق هذا الحدث عند الموافقة على الكيان"},
        {"name": "Rejected", "description": "يتم إطلاق هذا الحدث عند رفض الكيان"},
        {"name": "Submitted", "description": "يتم إطلاق هذا الحدث عند تقديم الكيان للموافقة"},
        {"name": "Returned", "description": "يتم إطلاق هذا الحدث عند إرجاع الكيان بعد المراجعة"},
    ],
    
    # Validation events (apply to entities requiring validation)
    "validation": [
        {"name": "Validated", "description": "يتم إطلاق هذا الحدث عند اكتمال عملية التحقق من الكيان"},
        {"name": "ValidationFailed", "description": "يتم إطلاق هذا الحدث عند فشل التحقق من الكيان"},
    ],
    
    # Financial events (specific to financial entities)
    "financial": [
        {"name": "PaymentReceived", "description": "يتم إطلاق هذا الحدث عند استلام دفعة"},
        {"name": "PaymentIssued", "description": "يتم إطلاق هذا الحدث عند إصدار دفعة"},
        {"name": "InvoiceIssued", "description": "يتم إطلاق هذا الحدث عند إصدار فاتورة"},
        {"name": "BalanceChanged", "description": "يتم إطلاق هذا الحدث عند تغير الرصيد"},
        {"name": "CreditLimitChanged", "description": "يتم إطلاق هذا الحدث عند تغيير حد الائتمان"},
        {"name": "TaxCalculated", "description": "يتم إطلاق هذا الحدث عند احتساب الضريبة"},
    ],
    
    # Accounting events
    "accounting": [
        {"name": "AccountPosted", "description": "يتم إطلاق هذا الحدث عند ترحيل حساب"},
        {"name": "JournalEntryCreated", "description": "يتم إطلاق هذا الحدث عند إنشاء قيد يومية"},
        {"name": "JournalEntryPosted", "description": "يتم إطلاق هذا الحدث عند ترحيل قيد يومية"},
        {"name": "JournalEntryReversed", "description": "يتم إطلاق هذا الحدث عند عكس قيد يومية"},
        {"name": "BudgetExceeded", "description": "يتم إطلاق هذا الحدث عند تجاوز الميزانية"},
    ],
    
    # Inventory events (specific to inventory entities)
    "inventory": [
        {"name": "ItemReceived", "description": "يتم إطلاق هذا الحدث عند استلام صنف"},
        {"name": "ItemIssued", "description": "يتم إطلاق هذا الحدث عند صرف صنف"},
        {"name": "StockLevelChanged", "description": "يتم إطلاق هذا الحدث عند تغير مستوى المخزون"},
        {"name": "StockReserved", "description": "يتم إطلاق هذا الحدث عند حجز مخزون"},
        {"name": "StockReleased", "description": "يتم إطلاق هذا الحدث عند إلغاء حجز مخزون"},
        {"name": "StockTransferred", "description": "يتم إطلاق هذا الحدث عند نقل مخزون"},
        {"name": "StockAdjusted", "description": "يتم إطلاق هذا الحدث عند تسوية مخزون"},
        {"name": "ItemExpired", "description": "يتم إطلاق هذا الحدث عند انتهاء صلاحية صنف"},
        {"name": "PriceChanged", "description": "يتم إطلاق هذا الحدث عند تغيير سعر الصنف"},
    ],
    
    # Sales events
    "sales": [
        {"name": "OrderPlaced", "description": "يتم إطلاق هذا الحدث عند إنشاء طلب"},
        {"name": "OrderConfirmed", "description": "يتم إطلاق هذا الحدث عند تأكيد طلب"},
        {"name": "OrderShipped", "description": "يتم إطلاق هذا الحدث عند شحن طلب"},
        {"name": "OrderDelivered", "description": "يتم إطلاق هذا الحدث عند توصيل طلب"},
        {"name": "OrderReturned", "description": "يتم إطلاق هذا الحدث عند إرجاع طلب"},
        {"name": "QuotationIssued", "description": "يتم إطلاق هذا الحدث عند إصدار عرض سعر"},
        {"name": "QuotationAccepted", "description": "يتم إطلاق هذا الحدث عند قبول عرض سعر"},
        {"name": "DiscountApplied", "description": "يتم إطلاق هذا الحدث عند تطبيق خصم"},
    ],
    
    # Human Resources events
    "hr": [
        {"name": "EmployeeHired", "description": "يتم إطلاق هذا الحدث عند توظيف موظف"},
        {"name": "EmployeeTerminated", "description": "يتم إطلاق هذا الحدث عند إنهاء خدمة موظف"},
        {"name": "SalaryChanged", "description": "يتم إطلاق هذا الحدث عند تغيير راتب"},
        {"name": "LeaveRequested", "description": "يتم إطلاق هذا الحدث عند طلب إجازة"},
        {"name": "LeaveApproved", "description": "يتم إطلاق هذا الحدث عند الموافقة على إجازة"},
        {"name": "AttendanceRecorded", "description": "يتم إطلاق هذا الحدث عند تسجيل حضور"},
        {"name": "PerformanceReviewed", "description": "يتم إطلاق هذا الحدث عند تقييم أداء"},
        {"name": "ContractRenewed", "description": "يتم إطلاق هذا الحدث عند تجديد عقد"},
    ],
    
    # Service events
    "service": [
        {"name": "ServiceRequested", "description": "يتم إطلاق هذا الحدث عند طلب خدمة"},
        {"name": "ServiceScheduled", "description": "يتم إطلاق هذا الحدث عند جدولة خدمة"},
        {"name": "ServiceCompleted", "description": "يتم إطلاق هذا الحدث عند إكمال خدمة"},
        {"name": "MaintenanceScheduled", "description": "يتم إطلاق هذا الحدث عند جدولة صيانة"},
        {"name": "MaintenancePerformed", "description": "يتم إطلاق هذا الحدث عند إجراء صيانة"},
        {"name": "WarrantyIssued", "description": "يتم إطلاق هذا الحدث عند إصدار ضمان"},
        {"name": "WarrantyClaimed", "description": "يتم إطلاق هذا الحدث عند المطالبة بالضمان"},
    ],
    
    # Security events
    "security": [
        {"name": "AccessGranted", "description": "يتم إطلاق هذا الحدث عند منح صلاحية الوصول"},
        {"name": "AccessRevoked", "description": "يتم إطلاق هذا الحدث عند سحب صلاحية الوصول"},
        {"name": "PermissionChanged", "description": "يتم إطلاق هذا الحدث عند تغيير الصلاحيات"},
        {"name": "PasswordChanged", "description": "يتم إطلاق هذا الحدث عند تغيير كلمة المرور"},
        {"name": "UserLoggedIn", "description": "يتم إطلاق هذا الحدث عند تسجيل دخول المستخدم"},
        {"name": "UserLoggedOut", "description": "يتم إطلاق هذا الحدث عند تسجيل خروج المستخدم"},
    ],
    
    # Relationship events
    "relationship": [
        {"name": "EntityLinked", "description": "يتم إطلاق هذا الحدث عند ربط الكيان بكيان آخر"},
        {"name": "EntityUnlinked", "description": "يتم إطلاق هذا الحدث عند فك ارتباط الكيان بكيان آخر"},
        {"name": "AssociationCreated", "description": "يتم إطلاق هذا الحدث عند إنشاء علاقة ارتباط"},
        {"name": "AssociationRemoved", "description": "يتم إطلاق هذا الحدث عند إزالة علاقة ارتباط"},
    ],
}

# Module-specific event mapping
module_event_categories = {
    "Core System": ["lifecycle", "status", "approval", "security", "relationship", "validation"],
    "Activities": ["lifecycle", "status", "relationship"],
    "Users & Permissions": ["lifecycle", "status", "security", "relationship"],
    "General Ledger": ["lifecycle", "status", "accounting", "approval", "financial", "validation"],
    "Fixed Assets": ["lifecycle", "status", "financial", "approval"],
    "Finance & Accounting": ["lifecycle", "status", "financial", "accounting", "approval", "validation"],
    "Sales & Customers": ["lifecycle", "status", "financial", "sales", "approval", "validation"],
    "Purchasing & Vendors": ["lifecycle", "status", "financial", "approval", "validation"],
    "Inventory & Warehousing": ["lifecycle", "status", "inventory", "approval", "validation"],
    "Production & Manufacturing": ["lifecycle", "status", "inventory", "approval", "validation"],
    "Services & Maintenance": ["lifecycle", "status", "service", "approval", "validation"],
    "Human Resources": ["lifecycle", "status", "hr", "approval", "validation"],
    "Attendance": ["lifecycle", "status", "hr", "validation"],
    "Insurance & Claims": ["lifecycle", "status", "financial", "approval", "validation"],
    "Guarantees & Warranties": ["lifecycle", "status", "service", "approval", "validation"],
    "Stations & Fuel": ["lifecycle", "status", "inventory", "financial", "approval", "validation"],
    "Transportation & Shipping": ["lifecycle", "status", "service", "approval", "validation"],
    "Doctors & Patients": ["lifecycle", "status", "service", "validation"],
    "Articles & Content": ["lifecycle", "status", "security"],
    "Archiving & Documents": ["lifecycle", "status", "security"],
    "Tracking & Monitoring": ["lifecycle", "status", "security"],
    "Projects & Regions": ["lifecycle", "status", "financial", "approval", "validation"],
    "Messages & Notifications": ["lifecycle", "status", "security"],
    "Forms & Surveys": ["lifecycle", "status", "approval", "validation"],
    "Settings & Parameters": ["lifecycle", "status", "security"],
    "Replication & Duplication": ["lifecycle", "status", "security"],
    "Judicial & Legal": ["lifecycle", "status", "approval", "validation"],
    "Tax & Fees": ["lifecycle", "status", "financial", "approval", "validation"],
    "Web Services & Interfaces": ["lifecycle", "status", "security"],
    "Temporary Tables": ["lifecycle"]
}

# Entity name pattern matching for specific event categories
entity_name_patterns = {
    r".*Account.*": ["accounting", "financial"],
    r".*Invoice.*": ["financial", "sales"],
    r".*Payment.*": ["financial"],
    r".*Bill.*": ["financial", "sales"],
    r".*Order.*": ["sales", "inventory"],
    r".*Customer.*": ["sales"],
    r".*Vendor.*": ["financial"],
    r".*Item.*": ["inventory"],
    r".*Stock.*": ["inventory"],
    r".*Warehouse.*": ["inventory"],
    r".*Purchase.*": ["inventory", "financial"],
    r".*Sales.*": ["sales", "financial"],
    r".*Employee.*": ["hr"],
    r".*User.*": ["security"],
    r".*Permission.*": ["security"],
    r".*Service.*": ["service"],
    r".*Maintenance.*": ["service"],
    r".*Document.*": ["security"],
    r".*Contract.*": ["financial", "approval"],
    r".*Budget.*": ["financial", "accounting"],
    r".*Tax.*": ["financial", "accounting"],
    r".*Journal.*": ["accounting"],
    r".*Voucher.*": ["financial", "accounting"],
    r".*Claim.*": ["service", "financial"],
    r".*Report.*": ["security"],
    r".*Audit.*": ["security"],
}

class Entity:
    def __init__(self, table_name: str, model_name: str, module: str):
        self.table_name = table_name
        self.model_name = model_name
        self.module = module
        self.events = {}
        self.entity_type_categories = set()
    
    def analyze_events(self):
        # Clear existing events
        self.events = {}
        
        # First, add the module-specific event categories
        module_categories = module_event_categories.get(self.module, ["lifecycle", "status"])
        for category in module_categories:
            for event in event_categories.get(category, []):
                self.events[event["name"]] = {
                    "category": category,
                    "description": event["description"],
                    "source": "module",
                }
        
        # Then, check for entity name patterns
        for pattern, categories in entity_name_patterns.items():
            if re.search(pattern, self.model_name):
                self.entity_type_categories.update(categories)
                for category in categories:
                    for event in event_categories.get(category, []):
                        # Only add if it doesn't exist or if it's not from the module
                        if event["name"] not in self.events or self.events[event["name"]]["source"] != "module":
                            self.events[event["name"]] = {
                                "category": category,
                                "description": event["description"],
                                "source": "pattern",
                            }
    
    def get_events_summary(self):
        return {name: {
            "category": event["category"], 
            "description": event["description"]
        } for name, event in self.events.items()}

    def __repr__(self):
        return f"{self.model_name} ({self.table_name}) in {self.module}"


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


def generate_domain_events():
    """Main function to generate domain events for all entities"""
    # Load table mappings
    print("Loading table mappings...")
    table_mappings = load_table_mappings()
    print(f"Loaded {len(table_mappings)} table mappings")
    
    # Create entity objects
    entities = {}
    for table_name, (model_name, module) in table_mappings.items():
        entities[table_name] = Entity(table_name, model_name, module)
    
    # Analyze entities for events
    for entity_name, entity in entities.items():
        entity.analyze_events()
    
    # Prepare the results
    results = {
        "summary": {
            "total_entities": len(entities),
            "total_event_types": len(set(event["name"] for cat in event_categories.values() for event in cat)),
            "categories": list(event_categories.keys()),
        },
        "entities": {}
    }
    
    # Add entities with events to the results
    for table_name, entity in entities.items():
        results["entities"][entity.model_name] = {
            "table_name": table_name,
            "module": entity.module,
            "events": entity.get_events_summary()
        }
    
    return results


def generate_event_code_examples(results):
    """Generate C# code examples for domain events"""
    code_examples = {}
    
    for entity_name, entity_data in results["entities"].items():
        # Skip entities with no events
        if not entity_data["events"]:
            continue
        
        # Generate event class examples
        entity_events = {}
        for event_name, event_info in entity_data["events"].items():
            event_class_name = f"{entity_name}{event_name}Event"
            
            # Generate properties based on event category
            properties = [
                f"public {entity_name}Id {entity_name}Id {{ get; }}"
            ]
            
            if event_info["category"] == "financial":
                properties.append("public decimal Amount { get; }")
                properties.append("public string Currency { get; }")
            
            if event_info["category"] == "status":
                properties.append("public string PreviousStatus { get; }")
                properties.append("public string NewStatus { get; }")
            
            if event_info["category"] == "inventory":
                properties.append("public decimal Quantity { get; }")
                properties.append("public string Unit { get; }")
            
            # Generate constructor parameters
            constructor_params = [f"{entity_name}Id {entity_name.lower()}Id"]
            constructor_assignments = [f"{entity_name}Id = {entity_name.lower()}Id"]
            
            for prop in properties[1:]:  # Skip the first property which is already in the constructor
                prop_name = prop.split(' ')[2]
                prop_type = prop.split(' ')[1]
                constructor_params.append(f"{prop_type} {prop_name.lower()}")
                constructor_assignments.append(f"{prop_name} = {prop_name.lower()}")
            
            # Build the event class code
            event_code = f"""using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.{entity_data['module']}.Events
{{
    /// <summary>
    /// {event_info['description']}
    /// </summary>
    public class {event_class_name} : DomainEventBase
    {{
        {"; ".join(properties)}
        
        public {event_class_name}({", ".join(constructor_params)})
        {{
            {"; ".join(constructor_assignments)};
        }}
    }}
}}"""
            entity_events[event_name] = event_code
        
        # Generate entity method examples that fire the events
        method_examples = {}
        for event_name, event_code in entity_events.items():
            # Create method name (convert past tense event name to present tense method name)
            method_name = event_name
            if method_name.endswith("ed"):
                method_name = method_name[:-2]
            elif method_name.endswith("d"):
                method_name = method_name[:-1]
            
            # Special cases
            if method_name == "Creat":
                method_name = "Create"
            
            # Generate method parameters and body
            method_params = []
            event_params = [f"Id"]
            
            if event_name in ["StatusChanged", "Activated", "Deactivated"]:
                method_params.append("string newStatus")
                event_params.append("Status")
                event_params.append("newStatus")
            
            if event_name in ["PriceChanged", "BalanceChanged", "CreditLimitChanged"]:
                method_params.append("decimal newValue")
                method_params.append("string reason = null")
                event_params.append("newValue")
                event_params.append("reason ?? \"System update\"")
            
            method_code = f"""
    /// <summary>
    /// {event_info['description']}
    /// </summary>
    public void {method_name}({", ".join(method_params)})
    {{
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new {entity_name}{event_name}Event({", ".join(event_params)}));
    }}"""
            method_examples[event_name] = method_code
        
        code_examples[entity_name] = {
            "events": entity_events,
            "methods": method_examples
        }
    
    return code_examples


def generate_guidelines():
    """Generate guidelines for domain events"""
    results = generate_domain_events()
    
    print(f"Analysis complete:")
    print(f"Total entities: {results['summary']['total_entities']}")
    print(f"Total event types: {results['summary']['total_event_types']}")
    
    # Save results to JSON
    with open("domain_events_analysis.json", "w", encoding="utf-8") as f:
        json.dump(results, f, indent=2, ensure_ascii=False)
    
    print("Results saved to domain_events_analysis.json")
    
    # Generate code examples
    code_examples = generate_event_code_examples(results)
    
    # Generate the guidelines
    guidelines = []
    guidelines.append("# قواعد توليد أحداث النطاق (Domain Events) للكيانات في النظام")
    guidelines.append("\n## فئات الأحداث الرئيسية")
    
    # Add event category sections
    for category, events in event_categories.items():
        guidelines.append(f"\n### فئة {category}")
        guidelines.append("| الحدث | الوصف |")
        guidelines.append("| --- | --- |")
        for event in events:
            guidelines.append(f"| {event['name']} | {event['description']} |")
    
    # Add module-specific categories
    guidelines.append("\n## فئات الأحداث حسب الوحدات (Modules)")
    guidelines.append("| الوحدة | فئات الأحداث |")
    guidelines.append("| --- | --- |")
    for module, categories in module_event_categories.items():
        guidelines.append(f"| {module} | {', '.join(categories)} |")
    
    # Add examples for specific entity types
    guidelines.append("\n## أمثلة توليد أحداث لبعض الكيانات")
    
    # Pick a few representative examples
    example_entities = ["Customer", "Invoice", "JournalVoucher", "Item", "Employee", "User"]
    
    for entity_name in example_entities:
        if entity_name in results["entities"]:
            guidelines.append(f"\n### أحداث كيان {entity_name}")
            entity_data = results["entities"][entity_name]
            guidelines.append(f"**الوحدة:** {entity_data['module']}")
            guidelines.append("\n**الأحداث المقترحة:**")
            
            for event_name, event_info in entity_data["events"].items():
                guidelines.append(f"- **{event_name}**: {event_info['description']} (فئة: {event_info['category']})")
            
            if entity_name in code_examples:
                # Show one event class example
                example_event = list(code_examples[entity_name]["events"].keys())[0]
                guidelines.append(f"\n**مثال على فئة الحدث {entity_name}{example_event}Event:**")
                guidelines.append("```csharp")
                guidelines.append(code_examples[entity_name]["events"][example_event])
                guidelines.append("```")
                
                # Show the method example
                guidelines.append(f"\n**مثال على طريقة إثارة الحدث في كيان {entity_name}:**")
                guidelines.append("```csharp")
                guidelines.append(code_examples[entity_name]["methods"][example_event])
                guidelines.append("```")
    
    # Add implementation guidelines
    guidelines.append("\n## إرشادات التنفيذ")
    guidelines.append("""
1. **إنشاء الأحداث المناسبة**: لكل كيان، حدد الأحداث المناسبة من الفئات أعلاه حسب طبيعة الكيان ووحدته.
2. **إنشاء فئات الأحداث**: أنشئ فئة C# لكل حدث تحتوي على البيانات اللازمة لفهم ما حدث.
3. **إضافة طرق عمل في الكيان**: أضف طرق تنفيذ في الكيان تقوم بإثارة الأحداث المناسبة عند حدوث تغييرات.
4. **استخدام الأحداث في تنفيذ الأعمال**: ربط معالجات الأحداث في طبقة التطبيق لتنفيذ الإجراءات اللازمة.
5. **توثيق الأحداث بدقة**: وثق كل حدث وشرح متى وكيف يتم إثارته.

### ملاحظات هامة
- **حافظ على تماسك الأحداث**: تأكد من أن كل حدث يمثل تغييرًا مهمًا وذا مغزى في حالة الكيان.
- **ضمّن البيانات الكافية**: تأكد من أن كل حدث يحتوي على معلومات كافية لفهم ماذا حدث.
- **حافظ على البساطة**: تجنب الأحداث المعقدة جدًا، فقد تشير إلى الحاجة لتقسيم المسؤوليات.
- **استخدم صيغة الماضي**: سمّ الأحداث بأفعال في صيغة الماضي (مثل: Created, Updated).
- **لا تستخدم الأحداث للاستعلامات**: استخدم الأحداث للإشعار عن تغييرات، وليس كآلية استعلام.
""")
    
    # Write guidelines to file
    with open("domain_events_guidelines.md", "w", encoding="utf-8") as f:
        f.write("\n".join(guidelines))
    
    print("Guidelines saved to domain_events_guidelines.md")


if __name__ == "__main__":
    generate_guidelines() 
import re
import sys
import os

def clean_field_name(field_name):
    """تنظيف اسم الحقل من الرموز الخاصة والأحرف غير المرغوبة"""
    # إزالة الرموز الخاصة والأحرف غير المرغوبة
    return re.sub(r'[^\w_]', '', field_name)

def is_numeric(field_name):
    """التحقق مما إذا كان اسم الحقل عبارة عن رقم فقط"""
    return field_name.isdigit()

def expand_abbreviations(word):
    """توسيع الاختصارات الشائعة في أسماء الحقول"""
    abbreviations = {
        'acc': 'account',
        'accnt': 'account',
        'acnt': 'account',
        'actv': 'activity',
        'addr': 'address',
        'admin': 'administrator',
        'amt': 'amount',
        'amnt': 'amount',
        'auth': 'authentication',
        'auto': 'automatic',
        'avg': 'average',
        'bal': 'balance',
        'calc': 'calculate',
        'cat': 'category',
        'cfg': 'config',
        'cls': 'class',
        'cnt': 'count',
        'col': 'column',
        'comm': 'commission',
        'comp': 'company',
        'conf': 'config',
        'cust': 'customer',
        'curr': 'currency',
        'db': 'database',
        'del': 'delete',
        'dept': 'department',
        'desc': 'description',
        'dev': 'development',
        'diff': 'difference',
        'dir': 'directory',
        'disp': 'display',
        'div': 'division',
        'doc': 'document',
        'dscnt': 'discount',
        'dt': 'date',
        'dtl': 'detail',
        'emp': 'employee',
        'exec': 'execute',
        'fld': 'field',
        'fmt': 'format',
        'func': 'function',
        'gen': 'generate',
        'grp': 'group',
        'hrs': 'hours',
        'hist': 'history',
        'idx': 'index',
        'img': 'image',
        'impl': 'implementation',
        'incl': 'include',
        'info': 'information',
        'init': 'initialize',
        'lang': 'language',
        'len': 'length',
        'lib': 'library',
        'lmt': 'limit',
        'loc': 'location',
        'max': 'maximum',
        'mgmt': 'management',
        'mgr': 'manager',
        'min': 'minimum',
        'misc': 'miscellaneous',
        'mod': 'modify',
        'msg': 'message',
        'mst': 'master',
        'mult': 'multiple',
        'nav': 'navigation',
        'nm': 'name',
        'no': 'number',
        'num': 'number',
        'obj': 'object',
        'org': 'organization',
        'orig': 'original',
        'parm': 'parameter',
        'param': 'parameter',
        'pct': 'percent',
        'perm': 'permission',
        'pic': 'picture',
        'pkg': 'package',
        'pref': 'preference',
        'prev': 'previous',
        'proc': 'procedure',
        'prod': 'product',
        'proj': 'project',
        'prop': 'property',
        'prov': 'provider',
        'pwd': 'password',
        'qty': 'quantity',
        'qry': 'query',
        'rcpt': 'receipt',
        'rec': 'record',
        'ref': 'reference',
        'reg': 'register',
        'rpt': 'report',
        'rslt': 'result',
        'rsp': 'response',
        'rtl': 'retail',
        'sch': 'schedule',
        'scr': 'screen',
        'sec': 'second',
        'ser': 'serial',
        'sess': 'session',
        'spec': 'specification',
        'std': 'standard',
        'str': 'string',
        'sys': 'system',
        'tbl': 'table',
        'temp': 'temporary',
        'tmp': 'temporary',
        'tot': 'total',
        'tx': 'transaction',
        'txt': 'text',
        'typ': 'type',
        'u': 'user',
        'usr': 'user',
        'util': 'utility',
        'val': 'value',
        'var': 'variable',
        'vat': 'valueAddedTax',
        'vch': 'voucher',
        'vchr': 'voucher',
        'ver': 'version',
        'wgt': 'weight',
        'wh': 'warehouse',
        'yr': 'year'
    }
    
    return abbreviations.get(word.lower(), word)

def to_camel_case(field_name):
    """تحويل اسم الحقل إلى صيغة camelCase"""
    # تجاهل الأسماء الرقمية
    if is_numeric(field_name):
        return field_name
    
    # تحويل الأحرف الكبيرة المتتالية إلى حالة أكثر قابلية للقراءة
    # مثل: VATAmount -> VatAmount
    field_name = re.sub(r'([A-Z])([A-Z]+)([A-Z][a-z]|\d|$)', r'\1\2\3', field_name)
    
    # تقسيم بناءً على الشرطة السفلية أو الحرف الكبير
    words = re.findall(r'[A-Z]?[a-z0-9]+|[A-Z]+(?=[A-Z]|$)', field_name)
    if not words:
        words = [field_name]  # في حالة عدم العثور على كلمات
    
    # توسيع الاختصارات
    expanded_words = [expand_abbreviations(word) for word in words]
    
    # تحويل الحروف الأولى من كل كلمة (باستثناء الأولى) إلى حروف كبيرة
    if not expanded_words:
        return field_name.lower()
        
    camel_case = expanded_words[0].lower()
    for word in expanded_words[1:]:
        if word:  # تجنب الكلمات الفارغة
            camel_case += word[0].upper() + word[1:].lower()
    
    return camel_case

def pascal_to_camel(pascal_case):
    """تحويل اسم من PascalCase إلى camelCase"""
    if not pascal_case or is_numeric(pascal_case):
        return pascal_case
    return pascal_case[0].lower() + pascal_case[1:]

def standardize_common_fields(field_name):
    """موحدة الحقول الشائعة إلى أسماء قياسية"""
    # قائمة بالحقول الشائعة وأسمائها القياسية الجديدة
    common_fields = {
        'id': 'id',
        'no': 'id',
        'code': 'code',
        'name': 'name',
        'desc': 'description',
        'description': 'description',
        'type': 'type',
        'ser': 'serial',
        'serial': 'serial',
        'date': 'date',
        'amount': 'amount',
        'amt': 'amount',
        'qty': 'quantity',
        'quantity': 'quantity',
        'price': 'price',
        'cost': 'cost',
        'status': 'status',
        'note': 'note',
        'notes': 'notes',
        'active': 'isActive',
        'inactive': 'isInactive',
        'del': 'isDeleted',
        'deleted': 'isDeleted',
        'created': 'createdAt',
        'created_at': 'createdAt',
        'modified': 'updatedAt',
        'updated': 'updatedAt',
        'updated_at': 'updatedAt',
        'created_by': 'createdBy',
        'updated_by': 'updatedBy',
        'u_id': 'userId',
        'user_id': 'userId',
        'branch_id': 'branchId',
        'branch_code': 'branchCode',
        'branch_name': 'branchName',
        'company_id': 'companyId',
        'company_code': 'companyCode',
        'company_name': 'companyName',
        'cmp_no': 'companyId',
        'brn_no': 'branchId',
        'ad_date': 'createdAt',
        'ad_u_id': 'createdBy',
        'up_date': 'updatedAt',
        'up_u_id': 'updatedBy',
    }
    
    # التعامل مع الأسماء الرقمية
    if is_numeric(field_name):
        return field_name
    
    # تحقق مما إذا كان الحقل شائعاً واستخدم الاسم القياسي له
    lower_field = field_name.lower()
    for common, standard in common_fields.items():
        # تطابق كامل
        if lower_field == common:
            return standard
        
        # تطابق النهاية (مثل customer_id)
        if lower_field.endswith('_' + common):
            prefix = lower_field.replace('_' + common, '')
            if prefix:
                prefix_camel = to_camel_case(prefix)
                if standard == 'id':
                    return f"{prefix_camel}Id"
                else:
                    return prefix_camel + standard[0].upper() + standard[1:]
    
    # إذا لم تكن من الحقول الشائعة، أعِد None
    return None

def handle_foreign_keys(field_name):
    """معالجة خاصة لمفاتيح الخارجية (Foreign Keys)"""
    # تجاهل الأسماء الرقمية
    if is_numeric(field_name):
        return field_name
        
    # الكثير من المفاتيح الخارجية تنتهي بـ _ID أو _NO أو _CODE وتشير إلى جدول آخر
    matches = re.search(r'^(\w+?)(?:_id|_no|_code|_ser|id|no|code|ser)$', field_name.lower())
    if matches:
        entity = matches.group(1)
        # تحويل اسم الكيان إلى camelCase
        entity_camel = to_camel_case(entity)
        return f"{entity_camel}Id"
    return None

def map_field_name(field_name):
    """تخطيط اسم الحقل القديم إلى اسم جديد بنمط التسميات الجديدة"""
    # تنظيف اسم الحقل
    clean_name = clean_field_name(field_name)
    
    # التعامل مع الأسماء الرقمية
    if is_numeric(clean_name):
        return clean_name
    
    # التحقق أولاً ما إذا كان حقلاً شائعاً
    standard_name = standardize_common_fields(clean_name)
    if standard_name:
        return standard_name
    
    # التحقق ما إذا كان مفتاحاً خارجياً
    foreign_key = handle_foreign_keys(clean_name)
    if foreign_key:
        return foreign_key
    
    # تحويل إلى camelCase
    return to_camel_case(clean_name)

def is_system_field(field_name):
    """تحديد ما إذا كان الحقل من حقول النظام التي لا ينبغي تضمينها"""
    # الحقول التي تبدأ بحرف "v_" غالبًا ما تكون متغيرات مؤقتة في الإجراءات المخزنة
    if field_name.lower().startswith(('v_', 'p_', 'l_', 't_')):
        return True
    
    # حالات خاصة أخرى
    system_fields = [
        'function', 'procedure', 'return', 'from', 'into', 'insert', 'case', 'when',
        'then', 'end', 'null', 'and', 'or', 'by', 'is', 'not', 'exists'
    ]
    
    return field_name.lower() in system_fields

def generate_field_mapping(input_file, output_file):
    """إنشاء ملف تخطيط لأسماء الحقول من القديم إلى الجديد"""
    # قراءة أسماء الحقول القديمة
    old_fields = []
    with open(input_file, 'r', encoding='utf-8') as f:
        for line in f:
            line = line.strip()
            if line and not line.startswith('#'):
                old_fields.append(line)
    
    # إنشاء التخطيط
    field_mappings = []
    for old_field in old_fields:
        # تجاهل حقول النظام والمتغيرات المؤقتة
        if is_system_field(old_field):
            continue
            
        new_field = map_field_name(old_field)
        field_mappings.append((old_field, new_field))
    
    # كتابة التخطيط إلى ملف
    with open(output_file, 'w', encoding='utf-8') as f:
        f.write("# تخطيط الحقول القديمة إلى الجديدة\n")
        f.write("# Old Field Name => New Field Name\n\n")
        
        # تصنيف حسب مجموعات
        standard_fields = []
        foreign_keys = []
        other_fields = []
        numeric_fields = []
        
        for old_field, new_field in field_mappings:
            if is_numeric(old_field):
                numeric_fields.append((old_field, new_field))
            elif new_field and 'Id' in new_field and not new_field.startswith('id'):
                foreign_keys.append((old_field, new_field))
            elif standardize_common_fields(old_field):
                standard_fields.append((old_field, new_field))
            else:
                other_fields.append((old_field, new_field))
        
        # كتابة المجموعات
        if numeric_fields:
            f.write("# --- الحقول الرقمية ---\n")
            for old_field, new_field in sorted(numeric_fields):
                f.write(f"{old_field} => {new_field}\n")
            f.write("\n")
            
        if standard_fields:
            f.write("# --- الحقول القياسية ---\n")
            for old_field, new_field in sorted(standard_fields):
                f.write(f"{old_field} => {new_field}\n")
            f.write("\n")
            
        if foreign_keys:
            f.write("# --- المفاتيح الخارجية ---\n")
            for old_field, new_field in sorted(foreign_keys):
                f.write(f"{old_field} => {new_field}\n")
            f.write("\n")
        
        f.write("# --- حقول أخرى ---\n")
        for old_field, new_field in sorted(other_fields):
            f.write(f"{old_field} => {new_field}\n")

def main():
    if len(sys.argv) != 3:
        print("الاستخدام: python field_models_mapping.py <ملف_الحقول_المستخرجة> <ملف_التخطيط_الناتج>")
        sys.exit(1)
    
    input_file = sys.argv[1]
    output_file = sys.argv[2]
    
    if not os.path.exists(input_file):
        print(f"خطأ: الملف '{input_file}' غير موجود.")
        sys.exit(1)
    
    try:
        generate_field_mapping(input_file, output_file)
        print(f"تم إنشاء تخطيط الحقول بنجاح وحفظه في '{output_file}'")
    except Exception as e:
        print(f"حدث خطأ: {e}")
        sys.exit(1)

if __name__ == "__main__":
    main() 
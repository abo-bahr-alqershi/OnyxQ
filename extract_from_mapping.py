import re
import sys

def extract_field_candidates_from_table_names(mapping_file):
    """
    استخراج أسماء محتملة للحقول من أسماء الجداول القديمة (كما هي مذكورة في ملف التخطيط)
    هذه طريقة بديلة عندما لا تتوفر ملفات SQL للجداول
    """
    # قائمة لتخزين أسماء الحقول الفريدة
    unique_fields = set()
    
    # قراءة ملف التخطيط
    with open(mapping_file, 'r', encoding='utf-8') as f:
        for line in f:
            # تخطي التعليقات والأسطر الفارغة
            if line.strip().startswith('#') or not line.strip():
                continue
                
            # استخراج اسم الجدول القديم (التنسيق: رقم. اسم_الجدول_القديم => ModelName)
            match = re.search(r'^\d+\.\s+(\w+)\s+=>', line)
            if match:
                table_name = match.group(1)
                
                # تحليل اسم الجدول لاستخلاص الحقول المحتملة
                # نفترض أن اسم الجدول قد يحتوي على أسماء حقول شائعة
                
                # حذف البادئات الشائعة مثل S_ و IAS_ و GLS_ إلخ
                cleaned_name = re.sub(r'^[A-Z]+_', '', table_name)
                
                # تقسيم اسم الجدول إلى أجزاء محتملة باستخدام الشرطة السفلية
                parts = cleaned_name.split('_')
                
                # استخراج الكلمات الشائعة التي قد تكون حقولًا
                common_fields = [
                    'ID', 'NAME', 'CODE', 'DESC', 'DESCRIPTION', 'DATE', 'AMOUNT', 
                    'TYPE', 'STATUS', 'NOTES', 'USER', 'PRICE', 'QTY', 'QUANTITY',
                    'COST', 'VALUE', 'RATE', 'BALANCE', 'LIMIT', 'ADDRESS', 'PHONE',
                    'EMAIL', 'FAX', 'MOBILE', 'WEBSITE', 'CONTACT', 'MANAGER', 'OWNER',
                    'CREATED', 'MODIFIED', 'ACTIVE', 'INACTIVE', 'DELETED', 'APPROVED',
                    'REJECTED', 'NUMBER', 'REFERENCE', 'CATEGORY'
                ]
                
                # إضافة الحقول الشائعة
                for field in common_fields:
                    unique_fields.add(field.lower())
                
                # إضافة الكلمات الشائعة من اسم الجدول
                for part in parts:
                    if len(part) > 2:  # تجاهل الأجزاء القصيرة جدًا
                        unique_fields.add(part.lower())
                
                # استخراج الإشارات إلى أنواع محددة من الحقول
                if 'MST' in table_name:
                    unique_fields.add('master_id')
                if 'DTL' in table_name:
                    unique_fields.add('detail_id')
                    unique_fields.add('master_id')
                if 'HDR' in table_name or 'HEADER' in table_name:
                    unique_fields.add('header_id')
                if 'BRN' in table_name or 'BRANCH' in table_name:
                    unique_fields.add('branch_id')
                    unique_fields.add('branch_code')
                    unique_fields.add('branch_name')
                if 'USR' in table_name or 'USER' in table_name:
                    unique_fields.add('user_id')
                    unique_fields.add('username')
                    unique_fields.add('password')
                    unique_fields.add('email')
                if 'CMPNY' in table_name or 'COMPANY' in table_name:
                    unique_fields.add('company_id')
                    unique_fields.add('company_name')
                    unique_fields.add('company_code')
                if 'ACCNT' in table_name or 'ACCOUNT' in table_name:
                    unique_fields.add('account_id')
                    unique_fields.add('account_code')
                    unique_fields.add('account_name')
                    unique_fields.add('account_type')
                    unique_fields.add('account_balance')
                if 'CST' in table_name or 'CUSTOMER' in table_name:
                    unique_fields.add('customer_id')
                    unique_fields.add('customer_name')
                    unique_fields.add('customer_code')
                    unique_fields.add('credit_limit')
                if 'VND' in table_name or 'VENDOR' in table_name:
                    unique_fields.add('vendor_id')
                    unique_fields.add('vendor_name')
                    unique_fields.add('vendor_code')
                if 'ITM' in table_name or 'ITEM' in table_name:
                    unique_fields.add('item_id')
                    unique_fields.add('item_code')
                    unique_fields.add('item_name')
                    unique_fields.add('item_price')
                    unique_fields.add('item_cost')
                    unique_fields.add('quantity')
                if 'INV' in table_name or 'INVOICE' in table_name:
                    unique_fields.add('invoice_id')
                    unique_fields.add('invoice_number')
                    unique_fields.add('invoice_date')
                    unique_fields.add('invoice_amount')
                if 'BILL' in table_name:
                    unique_fields.add('bill_id')
                    unique_fields.add('bill_number')
                    unique_fields.add('bill_date')
                    unique_fields.add('bill_amount')
                if 'TRNS' in table_name or 'TRANSFER' in table_name:
                    unique_fields.add('transfer_id')
                    unique_fields.add('transfer_date')
                    unique_fields.add('from_account')
                    unique_fields.add('to_account')
                    unique_fields.add('amount')
                if 'PAY' in table_name or 'PAYMENT' in table_name:
                    unique_fields.add('payment_id')
                    unique_fields.add('payment_date')
                    unique_fields.add('payment_amount')
                    unique_fields.add('payment_method')
                if 'RCPT' in table_name or 'RECEIPT' in table_name:
                    unique_fields.add('receipt_id')
                    unique_fields.add('receipt_number')
                    unique_fields.add('receipt_date')
                    unique_fields.add('receipt_amount')
                
                # إضافة الحقول العامة الأساسية التي توجد في معظم الجداول
                unique_fields.add('id')
                unique_fields.add('created_at')
                unique_fields.add('updated_at')
                unique_fields.add('created_by')
                unique_fields.add('updated_by')
                unique_fields.add('active')
                unique_fields.add('deleted')
                unique_fields.add('notes')
                unique_fields.add('description')
    
    return sorted(list(unique_fields))

def main():
    if len(sys.argv) != 2:
        print("الاستخدام: python extract_from_mapping.py <ملف_التخطيط>")
        sys.exit(1)
    
    mapping_file = sys.argv[1]
    
    try:
        # استخراج أسماء الحقول المحتملة
        field_names = extract_field_candidates_from_table_names(mapping_file)
        
        print("أسماء الحقول الفريدة المستخرجة من أسماء الجداول:")
        for field in field_names:
            print(field)
        
        print(f"\nإجمالي الحقول الفريدة: {len(field_names)}")
        
        # حفظ النتائج في ملف
        with open('extracted_fields.txt', 'w', encoding='utf-8') as f:
            f.write("# أسماء الحقول الفريدة المستخرجة من أسماء الجداول\n\n")
            for field in field_names:
                f.write(f"{field}\n")
            f.write(f"\n# إجمالي الحقول الفريدة: {len(field_names)}")
        
        print(f"\nتم حفظ النتائج في ملف 'extracted_fields.txt'")
        
    except FileNotFoundError:
        print(f"خطأ: الملف '{mapping_file}' غير موجود.")
        sys.exit(1)
    except Exception as e:
        print(f"خطأ: {e}")
        sys.exit(1)

if __name__ == "__main__":
    main() 
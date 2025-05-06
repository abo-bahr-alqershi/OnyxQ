# تصميم الوحدات المحللة في نظام ERP Pro (مستوحى من Onyx Pro)

## مقدمة

هذا المستند يقدم مخططًا أوليًا للكيانات والعلاقات (ERD) ومخططات تدفق العمليات الرئيسية للوحدات التي تم تحليلها بشكل جيد نسبيًا في نظام ERP Pro، بناءً على المعلومات المتاحة من ملف `screens.md` والبحث العام وخبرة أنظمة ERP.

**ملاحظة:** هذا تصميم مبدئي وقد يتطلب تعديلات وتفصيلات إضافية بناءً على تحليل أعمق أو الوصول إلى وثائق النظام الفعلية.

## 1. مخطط الكيانات والعلاقات (ERD) الأولي

```mermaid
erDiagram
    COMPANY ||--o{ BRANCH : has
    COMPANY {
        INT CMP_NO PK "معرف الشركة"
        VARCHAR CMP_A_NAME "الاسم العربي"
        VARCHAR CMP_E_NAME "الاسم الإنجليزي"
        VARCHAR CMP_ADDRESS "العنوان"
        VARCHAR CMP_PHONE "الهاتف"
        VARCHAR CMP_EMAIL "البريد الإلكتروني"
    }
    BRANCH ||--o{ WAREHOUSE : manages
    BRANCH ||--o{ USER_R : employs
    BRANCH {
        INT BRN_NO PK "معرف الفرع"
        INT CMP_NO FK "معرف الشركة"
        VARCHAR BRN_NAME "اسم الفرع"
        VARCHAR BRN_ADDRESS "العنوان"
        VARCHAR BRN_PHONE "الهاتف"
        BOOLEAN INACTIVE "غير نشط"
    }
    USER_R ||--|{ USER_GROUPS : belongs to
    USER_R {
        INT U_ID PK "معرف المستخدم"
        VARCHAR U_NAME "اسم المستخدم"
        VARCHAR U_PASS "كلمة المرور (Hashed)"
        VARCHAR U_FULL_NAME "الاسم الكامل"
        BOOLEAN U_ACTIVE "نشط"
        INT GROUP_ID FK "معرف المجموعة"
        INT DEFAULT_BRN_NO FK "الفرع الافتراضي"
        INT DEFAULT_WH_NO FK "المستودع الافتراضي"
    }
    USER_GROUPS ||--o{ USER_PRIVILEGE : has
    USER_GROUPS {
        INT GROUP_ID PK "معرف المجموعة"
        VARCHAR GROUP_NAME "اسم المجموعة"
        VARCHAR GROUP_DESC "الوصف"
        BOOLEAN IS_ADMIN "مدير نظام"
    }
    USER_PRIVILEGE {
        INT PRIVILEGE_ID PK "معرف الصلاحية"
        INT GROUP_ID FK "معرف المجموعة"
        VARCHAR SCREEN_NAME "اسم الشاشة/الوحدة"
        BOOLEAN CAN_VIEW "عرض"
        BOOLEAN CAN_ADD "إضافة"
        BOOLEAN CAN_EDIT "تعديل"
        BOOLEAN CAN_DELETE "حذف"
        BOOLEAN CAN_PRINT "طباعة"
        BOOLEAN CAN_APPROVE "اعتماد"
    }

    CHART_OF_ACCOUNTS ||--o{ ACCOUNT : has
    CHART_OF_ACCOUNTS {
        INT ACC_ID PK "معرف الحساب"
        VARCHAR ACC_CODE "رمز الحساب"
        VARCHAR ACC_NAME "اسم الحساب"
        VARCHAR ACC_TYPE "نوع الحساب (رئيسي/فرعي)"
        INT PARENT_ACC_ID FK "معرف الحساب الأب"
        INT ACC_LEVEL "مستوى الحساب"
        BOOLEAN IS_ACTIVE "نشط"
    }
    ACCOUNT ||--o{ JOURNAL_ENTRY_DETAIL : used in
    ACCOUNT {
        INT ACC_DETAIL_ID PK "معرف الحساب التفصيلي"
        INT ACC_ID FK "معرف الحساب الرئيسي"
        VARCHAR ACC_DETAIL_NAME "اسم الحساب التفصيلي"
        BOOLEAN ALLOW_TRANSACTION "يسمح بالحركات"
    }
    COST_CENTER ||--o{ JOURNAL_ENTRY_DETAIL : assigned to
    COST_CENTER {
        INT CC_ID PK "معرف مركز التكلفة"
        VARCHAR CC_CODE "رمز المركز"
        VARCHAR CC_NAME "اسم المركز"
        BOOLEAN IS_ACTIVE "نشط"
    }
    JOURNAL_ENTRY ||--o{ JOURNAL_ENTRY_DETAIL : contains
    JOURNAL_ENTRY {
        INT JE_ID PK "معرف قيد اليومية"
        VARCHAR JE_NUMBER "رقم القيد"
        DATE JE_DATE "تاريخ القيد"
        VARCHAR JE_DESC "الوصف"
        VARCHAR JE_STATUS "الحالة (مدخل/مرحل/ملغي)"
        INT USER_ID FK "معرف المستخدم"
        INT BRN_NO FK "معرف الفرع"
    }
    JOURNAL_ENTRY_DETAIL {
        INT JED_ID PK "معرف تفاصيل القيد"
        INT JE_ID FK "معرف قيد اليومية"
        INT ACC_DETAIL_ID FK "معرف الحساب التفصيلي"
        INT CC_ID FK "معرف مركز التكلفة"
        DECIMAL DEBIT "مدين"
        DECIMAL CREDIT "دائن"
        VARCHAR NOTES "ملاحظات"
    }
    RECEIPT_VOUCHER ||--o{ JOURNAL_ENTRY : generates
    RECEIPT_VOUCHER {
        INT RV_ID PK "معرف سند القبض"
        VARCHAR RV_NUMBER "رقم السند"
        DATE RV_DATE "تاريخ السند"
        INT CUSTOMER_ID FK "معرف العميل"
        INT ACC_DETAIL_ID FK "الحساب النقدي/البنكي"
        DECIMAL AMOUNT "المبلغ"
        VARCHAR PAYMENT_METHOD "طريقة الدفع"
        VARCHAR NOTES "ملاحظات"
    }
    PAYMENT_VOUCHER ||--o{ JOURNAL_ENTRY : generates
    PAYMENT_VOUCHER {
        INT PV_ID PK "معرف سند الصرف"
        VARCHAR PV_NUMBER "رقم السند"
        DATE PV_DATE "تاريخ السند"
        INT VENDOR_ID FK "معرف المورد"
        INT ACC_DETAIL_ID FK "الحساب النقدي/البنكي"
        DECIMAL AMOUNT "المبلغ"
        VARCHAR PAYMENT_METHOD "طريقة الدفع"
        VARCHAR NOTES "ملاحظات"
    }

    ITEM ||--|{ ITEM_GROUP : belongs to
    ITEM ||--o{ STOCK_TRANSACTION_DETAIL : involves
    ITEM {
        INT ITEM_ID PK "معرف الصنف"
        VARCHAR ITEM_CODE "رمز الصنف"
        VARCHAR ITEM_NAME "اسم الصنف"
        VARCHAR ITEM_DESC "وصف الصنف"
        INT GROUP_ID FK "معرف المجموعة"
        INT UOM_ID FK "معرف وحدة القياس الأساسية"
        VARCHAR ITEM_TYPE "نوع الصنف (مخزني/خدمي)"
        DECIMAL COST_PRICE "سعر التكلفة"
        DECIMAL SALE_PRICE "سعر البيع"
        BOOLEAN IS_ACTIVE "نشط"
    }
    ITEM_GROUP {
        INT GROUP_ID PK "معرف المجموعة"
        VARCHAR GROUP_NAME "اسم المجموعة"
    }
    UNIT_OF_MEASURE {
        INT UOM_ID PK "معرف الوحدة"
        VARCHAR UOM_CODE "رمز الوحدة"
        VARCHAR UOM_NAME "اسم الوحدة"
    }
    WAREHOUSE ||--o{ LOCATION : contains
    WAREHOUSE ||--o{ STOCK_TRANSACTION : occurs in
    WAREHOUSE {
        INT WH_NO PK "معرف المستودع"
        VARCHAR WH_NAME "اسم المستودع"
        INT BRN_NO FK "معرف الفرع"
        VARCHAR WH_ADDRESS "العنوان"
        BOOLEAN IS_ACTIVE "نشط"
    }
    LOCATION {
        INT LOC_ID PK "معرف الموقع"
        INT WH_NO FK "معرف المستودع"
        VARCHAR LOC_CODE "رمز الموقع"
        VARCHAR LOC_NAME "اسم الموقع"
    }
    STOCK_TRANSACTION ||--o{ STOCK_TRANSACTION_DETAIL : contains
    STOCK_TRANSACTION {
        INT ST_ID PK "معرف حركة المخزون"
        VARCHAR ST_NUMBER "رقم الحركة"
        DATE ST_DATE "تاريخ الحركة"
        VARCHAR ST_TYPE "نوع الحركة (إضافة/صرف/تحويل/تعديل)"
        INT WH_NO FK "معرف المستودع"
        INT TO_WH_NO FK "المستودع المحول إليه (للتحويل)"
        INT USER_ID FK "معرف المستخدم"
        VARCHAR NOTES "ملاحظات"
        INT REF_DOC_ID FK "معرف المستند المرجعي (فاتورة/إذن)"
        VARCHAR REF_DOC_TYPE "نوع المستند المرجعي"
    }
    STOCK_TRANSACTION_DETAIL {
        INT STD_ID PK "معرف تفاصيل الحركة"
        INT ST_ID FK "معرف حركة المخزون"
        INT ITEM_ID FK "معرف الصنف"
        INT UOM_ID FK "معرف الوحدة"
        DECIMAL QUANTITY "الكمية"
        DECIMAL UNIT_COST "تكلفة الوحدة"
        INT LOC_ID FK "معرف الموقع"
        INT TO_LOC_ID FK "الموقع المحول إليه"
        VARCHAR BATCH_NO "رقم التشغيلة"
        DATE EXPIRY_DATE "تاريخ الانتهاء"
    }

    CUSTOMER ||--|{ CUSTOMER_GROUP : belongs to
    CUSTOMER ||--o{ SALES_ORDER : places
    CUSTOMER ||--o{ SALES_INVOICE : billed to
    CUSTOMER {
        INT CUST_ID PK "معرف العميل"
        VARCHAR CUST_CODE "رمز العميل"
        VARCHAR CUST_NAME "اسم العميل"
        INT GROUP_ID FK "معرف المجموعة"
        VARCHAR ADDRESS "العنوان"
        VARCHAR PHONE "الهاتف"
        VARCHAR EMAIL "البريد الإلكتروني"
        DECIMAL CREDIT_LIMIT "حد الائتمان"
        BOOLEAN IS_ACTIVE "نشط"
    }
    CUSTOMER_GROUP {
        INT GROUP_ID PK "معرف المجموعة"
        VARCHAR GROUP_NAME "اسم المجموعة"
    }
    SALES_QUOTATION ||--o{ SALES_QUOTATION_DETAIL : contains
    SALES_QUOTATION {
        INT SQ_ID PK "معرف عرض السعر"
        VARCHAR SQ_NUMBER "رقم العرض"
        DATE SQ_DATE "تاريخ العرض"
        INT CUST_ID FK "معرف العميل"
        DATE VALID_UNTIL "صالح حتى تاريخ"
        VARCHAR STATUS "الحالة (جديد/مرسل/مقبول/مرفوض)"
    }
    SALES_QUOTATION_DETAIL {
        INT SQD_ID PK "معرف تفاصيل العرض"
        INT SQ_ID FK "معرف عرض السعر"
        INT ITEM_ID FK "معرف الصنف"
        DECIMAL QUANTITY "الكمية"
        DECIMAL UNIT_PRICE "سعر الوحدة"
        DECIMAL DISCOUNT "الخصم"
    }
    SALES_ORDER ||--o{ SALES_ORDER_DETAIL : contains
    SALES_ORDER ||--o{ SALES_INVOICE : generates
    SALES_ORDER {
        INT SO_ID PK "معرف أمر البيع"
        VARCHAR SO_NUMBER "رقم الأمر"
        DATE SO_DATE "تاريخ الأمر"
        INT CUST_ID FK "معرف العميل"
        INT SQ_ID FK "معرف عرض السعر (مرجعي)"
        VARCHAR STATUS "الحالة (جديد/مؤكد/مشحون جزئيا/مشحون كليا/ملغي)"
    }
    SALES_ORDER_DETAIL {
        INT SOD_ID PK "معرف تفاصيل الأمر"
        INT SO_ID FK "معرف أمر البيع"
        INT ITEM_ID FK "معرف الصنف"
        DECIMAL QUANTITY "الكمية المطلوبة"
        DECIMAL SHIPPED_QTY "الكمية المشحونة"
        DECIMAL UNIT_PRICE "سعر الوحدة"
        DECIMAL DISCOUNT "الخصم"
    }
    SALES_INVOICE ||--o{ SALES_INVOICE_DETAIL : contains
    SALES_INVOICE ||--o{ JOURNAL_ENTRY : generates GL
    SALES_INVOICE ||--o{ STOCK_TRANSACTION : generates Stock Movement
    SALES_INVOICE {
        INT SI_ID PK "معرف فاتورة المبيعات"
        VARCHAR SI_NUMBER "رقم الفاتورة"
        DATE SI_DATE "تاريخ الفاتورة"
        INT CUST_ID FK "معرف العميل"
        INT SO_ID FK "معرف أمر البيع (مرجعي)"
        DECIMAL TOTAL_AMOUNT "المبلغ الإجمالي"
        DECIMAL PAID_AMOUNT "المبلغ المدفوع"
        VARCHAR STATUS "الحالة (مسودة/معتمدة/مدفوعة جزئيا/مدفوعة كليا/ملغاة)"
    }
    SALES_INVOICE_DETAIL {
        INT SID_ID PK "معرف تفاصيل الفاتورة"
        INT SI_ID FK "معرف فاتورة المبيعات"
        INT ITEM_ID FK "معرف الصنف"
        DECIMAL QUANTITY "الكمية"
        DECIMAL UNIT_PRICE "سعر الوحدة"
        DECIMAL DISCOUNT "الخصم"
        INT WH_NO FK "المستودع"
    }
    SALES_RETURN ||--o{ SALES_RETURN_DETAIL : contains
    SALES_RETURN ||--o{ JOURNAL_ENTRY : generates GL Reversal
    SALES_RETURN ||--o{ STOCK_TRANSACTION : generates Stock Reversal
    SALES_RETURN {
        INT SR_ID PK "معرف مرتجع المبيعات"
        VARCHAR SR_NUMBER "رقم المرتجع"
        DATE SR_DATE "تاريخ المرتجع"
        INT SI_ID FK "معرف الفاتورة الأصلية"
        INT CUST_ID FK "معرف العميل"
        VARCHAR REASON "سبب الإرجاع"
    }
    SALES_RETURN_DETAIL {
        INT SRD_ID PK "معرف تفاصيل المرتجع"
        INT SR_ID FK "معرف مرتجع المبيعات"
        INT SID_ID FK "معرف تفاصيل الفاتورة الأصلية"
        INT ITEM_ID FK "معرف الصنف"
        DECIMAL RETURN_QTY "الكمية المرتجعة"
        DECIMAL UNIT_PRICE "سعر الوحدة"
    }

    VENDOR ||--|{ VENDOR_GROUP : belongs to
    VENDOR ||--o{ PURCHASE_ORDER : receives
    VENDOR ||--o{ PURCHASE_INVOICE : issues
    VENDOR {
        INT VEND_ID PK "معرف المورد"
        VARCHAR VEND_CODE "رمز المورد"
        VARCHAR VEND_NAME "اسم المورد"
        INT GROUP_ID FK "معرف المجموعة"
        VARCHAR ADDRESS "العنوان"
        VARCHAR PHONE "الهاتف"
        VARCHAR EMAIL "البريد الإلكتروني"
        BOOLEAN IS_ACTIVE "نشط"
    }
    VENDOR_GROUP {
        INT GROUP_ID PK "معرف المجموعة"
        VARCHAR GROUP_NAME "اسم المجموعة"
    }
    PURCHASE_REQUEST ||--o{ PURCHASE_REQUEST_DETAIL : contains
    PURCHASE_REQUEST {
        INT PR_ID PK "معرف طلب الشراء"
        VARCHAR PR_NUMBER "رقم الطلب"
        DATE PR_DATE "تاريخ الطلب"
        INT USER_ID FK "معرف المستخدم الطالب"
        INT DEPT_ID FK "معرف القسم الطالب"
        VARCHAR STATUS "الحالة (جديد/معتمد/مرفوض)"
    }
    PURCHASE_REQUEST_DETAIL {
        INT PRD_ID PK "معرف تفاصيل الطلب"
        INT PR_ID FK "معرف طلب الشراء"
        INT ITEM_ID FK "معرف الصنف"
        DECIMAL QUANTITY "الكمية المطلوبة"
        VARCHAR NOTES "ملاحظات"
    }
    PURCHASE_ORDER ||--o{ PURCHASE_ORDER_DETAIL : contains
    PURCHASE_ORDER ||--o{ GOODS_RECEIPT_NOTE : generates
    PURCHASE_ORDER {
        INT PO_ID PK "معرف أمر الشراء"
        VARCHAR PO_NUMBER "رقم الأمر"
        DATE PO_DATE "تاريخ الأمر"
        INT VEND_ID FK "معرف المورد"
        INT PR_ID FK "معرف طلب الشراء (مرجعي)"
        VARCHAR STATUS "الحالة (جديد/مرسل/مستلم جزئيا/مستلم كليا/ملغي)"
    }
    PURCHASE_ORDER_DETAIL {
        INT POD_ID PK "معرف تفاصيل الأمر"
        INT PO_ID FK "معرف أمر الشراء"
        INT ITEM_ID FK "معرف الصنف"
        DECIMAL QUANTITY "الكمية المطلوبة"
        DECIMAL RECEIVED_QTY "الكمية المستلمة"
        DECIMAL UNIT_PRICE "سعر الوحدة"
    }
    GOODS_RECEIPT_NOTE ||--o{ GRN_DETAIL : contains
    GOODS_RECEIPT_NOTE ||--o{ STOCK_TRANSACTION : generates Stock Movement
    GOODS_RECEIPT_NOTE ||--o{ PURCHASE_INVOICE : linked to
    GOODS_RECEIPT_NOTE {
        INT GRN_ID PK "معرف إذن استلام بضاعة"
        VARCHAR GRN_NUMBER "رقم الإذن"
        DATE GRN_DATE "تاريخ الإذن"
        INT PO_ID FK "معرف أمر الشراء (مرجعي)"
        INT VEND_ID FK "معرف المورد"
        INT WH_NO FK "المستودع المستلم"
        VARCHAR STATUS "الحالة (جديد/مقابل/ملغي)"
    }
    GRN_DETAIL {
        INT GRND_ID PK "معرف تفاصيل الإذن"
        INT GRN_ID FK "معرف إذن الاستلام"
        INT POD_ID FK "معرف تفاصيل أمر الشراء"
        INT ITEM_ID FK "معرف الصنف"
        DECIMAL RECEIVED_QTY "الكمية المستلمة"
        INT LOC_ID FK "الموقع"
    }
    PURCHASE_INVOICE ||--o{ PURCHASE_INVOICE_DETAIL : contains
    PURCHASE_INVOICE ||--o{ JOURNAL_ENTRY : generates GL
    PURCHASE_INVOICE {
        INT PI_ID PK "معرف فاتورة المشتريات"
        VARCHAR PI_NUMBER "رقم الفاتورة"
        DATE PI_DATE "تاريخ الفاتورة"
        INT VEND_ID FK "معرف المورد"
        INT PO_ID FK "معرف أمر الشراء (مرجعي)"
        INT GRN_ID FK "معرف إذن الاستلام (مرجعي)"
        DECIMAL TOTAL_AMOUNT "المبلغ الإجمالي"
        DECIMAL PAID_AMOUNT "المبلغ المدفوع"
        VARCHAR STATUS "الحالة (مسودة/معتمدة/مدفوعة جزئيا/مدفوعة كليا/ملغاة)"
    }
    PURCHASE_INVOICE_DETAIL {
        INT PID_ID PK "معرف تفاصيل الفاتورة"
        INT PI_ID FK "معرف فاتورة المشتريات"
        INT ITEM_ID FK "معرف الصنف"
        DECIMAL QUANTITY "الكمية"
        DECIMAL UNIT_PRICE "سعر الوحدة"
    }
    PURCHASE_RETURN ||--o{ PURCHASE_RETURN_DETAIL : contains
    PURCHASE_RETURN ||--o{ JOURNAL_ENTRY : generates GL Reversal
    PURCHASE_RETURN ||--o{ STOCK_TRANSACTION : generates Stock Reversal
    PURCHASE_RETURN {
        INT PRT_ID PK "معرف مرتجع المشتريات"
        VARCHAR PRT_NUMBER "رقم المرتجع"
        DATE PRT_DATE "تاريخ المرتجع"
        INT PI_ID FK "معرف الفاتورة الأصلية"
        INT VEND_ID FK "معرف المورد"
        VARCHAR REASON "سبب الإرجاع"
    }
    PURCHASE_RETURN_DETAIL {
        INT PRTD_ID PK "معرف تفاصيل المرتجع"
        INT PRT_ID FK "معرف مرتجع المشتريات"
        INT PID_ID FK "معرف تفاصيل الفاتورة الأصلية"
        INT ITEM_ID FK "معرف الصنف"
        DECIMAL RETURN_QTY "الكمية المرتجعة"
        DECIMAL UNIT_PRICE "سعر الوحدة"
    }

    EMPLOYEE ||--|{ DEPARTMENT : belongs to
    EMPLOYEE ||--|{ JOB_TITLE : holds
    EMPLOYEE ||--o{ ATTENDANCE_RECORD : has
    EMPLOYEE ||--o{ LEAVE_REQUEST : submits
    EMPLOYEE ||--o{ PAYROLL_SHEET_DETAIL : included in
    EMPLOYEE {
        INT EMP_ID PK "معرف الموظف"
        VARCHAR EMP_CODE "رمز الموظف"
        VARCHAR EMP_NAME "اسم الموظف"
        INT DEPT_ID FK "معرف القسم"
        INT JOB_ID FK "معرف الوظيفة"
        DATE HIRE_DATE "تاريخ التعيين"
        VARCHAR STATUS "الحالة (نشط/غير نشط/إجازة)"
        VARCHAR NATIONAL_ID "الرقم الوطني"
        VARCHAR CONTACT_INFO "بيانات الاتصال"
    }
    DEPARTMENT {
        INT DEPT_ID PK "معرف القسم"
        VARCHAR DEPT_NAME "اسم القسم"
    }
    JOB_TITLE {
        INT JOB_ID PK "معرف الوظيفة"
        VARCHAR JOB_NAME "اسم الوظيفة"
    }
    ATTENDANCE_RECORD {
        INT ATT_ID PK "معرف سجل الحضور"
        INT EMP_ID FK "معرف الموظف"
        DATETIME CHECK_IN_TIME "وقت الدخول"
        DATETIME CHECK_OUT_TIME "وقت الخروج"
        DATE ATT_DATE "تاريخ الحضور"
        VARCHAR SOURCE "المصدر (جهاز بصمة/يدوي)"
    }
    LEAVE_REQUEST {
        INT LEAVE_ID PK "معرف طلب الإجازة"
        INT EMP_ID FK "معرف الموظف"
        DATE START_DATE "تاريخ البدء"
        DATE END_DATE "تاريخ الانتهاء"
        VARCHAR LEAVE_TYPE "نوع الإجازة"
        VARCHAR STATUS "الحالة (مقدم/معتمد/مرفوض)"
    }
    PAYROLL_ELEMENT {
        INT ELEMENT_ID PK "معرف عنصر الراتب"
        VARCHAR ELEMENT_NAME "اسم العنصر"
        VARCHAR ELEMENT_TYPE "نوع العنصر (استحقاق/استقطاع)"
        VARCHAR CALCULATION_TYPE "نوع الحساب (ثابت/متغير/معادلة)"
        BOOLEAN IS_ACTIVE "نشط"
    }
    PAYROLL_SHEET ||--o{ PAYROLL_SHEET_DETAIL : contains
    PAYROLL_SHEET {
        INT SHEET_ID PK "معرف كشف الراتب"
        VARCHAR SHEET_NUMBER "رقم الكشف"
        DATE PAY_DATE "تاريخ الدفع"
        INT MONTH "الشهر"
        INT YEAR "السنة"
        VARCHAR STATUS "الحالة (جديد/محسوب/معتمد/مدفوع)"
    }
    PAYROLL_SHEET_DETAIL ||--o{ PAYROLL_SHEET_ELEMENT : has elements
    PAYROLL_SHEET_DETAIL {
        INT DETAIL_ID PK "معرف تفاصيل الكشف"
        INT SHEET_ID FK "معرف كشف الراتب"
        INT EMP_ID FK "معرف الموظف"
        DECIMAL GROSS_SALARY "إجمالي الراتب"
        DECIMAL TOTAL_DEDUCTIONS "إجمالي الاستقطاعات"
        DECIMAL NET_SALARY "صافي الراتب"
    }
    PAYROLL_SHEET_ELEMENT {
        INT SHEET_ELEMENT_ID PK
        INT DETAIL_ID FK "معرف تفاصيل الكشف"
        INT ELEMENT_ID FK "معرف عنصر الراتب"
        DECIMAL AMOUNT "المبلغ"
    }

```

## 2. مخططات تدفق العمليات الرئيسية

### 2.1 تدفق عملية المبيعات (Sales Process Flow)

```mermaid
graph TD
    A[بدء: إنشاء عرض سعر] --> B{هل تم قبول العرض؟};
    B -- نعم --> C[إنشاء أمر بيع];
    B -- لا --> Z[إنهاء];
    C --> D{هل توجد بضاعة كافية؟};
    D -- نعم --> E[إنشاء فاتورة مبيعات];
    D -- لا --> F[إبلاغ المخزن/الإنتاج];
    F --> C;
    E --> G[تسليم البضاعة/تقديم الخدمة (قد يولد حركة مخزون)];
    G --> H[تسجيل قيد محاسبة المبيعات];
    H --> I{هل تم الدفع؟};
    I -- نعم --> J[إنشاء سند قبض];
    I -- لا --> K[متابعة التحصيل];
    J --> L[تسجيل قيد محاسبة القبض];
    K --> I;
    L --> Z;
    E --> M{هل يوجد مرتجع؟};
    M -- نعم --> N[إنشاء مرتجع مبيعات];
    N --> O[استلام البضاعة المرتجعة (حركة مخزون عكسية)];
    O --> P[تسجيل قيد محاسبة المرتجع];
    P --> Z;
    M -- لا --> I;
```

### 2.2 تدفق عملية المشتريات (Purchase Process Flow)

```mermaid
graph TD
    A[بدء: إنشاء طلب شراء (اختياري)] --> B[إنشاء أمر شراء];
    B --> C[إرسال أمر الشراء للمورد];
    C --> D{هل استلمت البضاعة؟};
    D -- نعم --> E[إنشاء إذن استلام بضاعة];
    D -- لا --> F[متابعة المورد];
    F --> C;
    E --> G[تسجيل حركة إضافة مخزون];
    G --> H{هل استلمت فاتورة المورد؟};
    H -- نعم --> I[إنشاء فاتورة مشتريات];
    H -- لا --> F;
    I --> J[مطابقة الفاتورة مع أمر الشراء وإذن الاستلام];
    J --> K{هل مطابقة؟};
    K -- نعم --> L[اعتماد الفاتورة];
    K -- لا --> M[حل الفروقات];
    M --> I;
    L --> N[تسجيل قيد محاسبة المشتريات];
    N --> O{هل تم الدفع؟};
    O -- نعم --> P[إنشاء سند صرف];
    O -- لا --> Q[جدولة الدفع];
    P --> R[تسجيل قيد محاسبة الصرف];
    Q --> O;
    R --> Z[إنهاء];
    I --> S{هل يوجد مرتجع؟};
    S -- نعم --> T[إنشاء مرتجع مشتريات];
    T --> U[إعادة البضاعة للمورد (حركة مخزون عكسية)];
    U --> V[تسجيل قيد محاسبة المرتجع];
    V --> Z;
    S -- لا --> N;

```

### 2.3 تدفق حركة المخزون (Inventory Movement Flow)

```mermaid
graph TD
    subgraph "إضافة للمخزون"
        A[إذن استلام بضاعة (مشتريات)] --> B(تسجيل حركة إضافة);
        C[مرتجع مبيعات] --> B;
        D[تسوية جرد بالزيادة] --> B;
        E[إنتاج منتج تام] --> B;
    end
    subgraph "صرف من المخزون"
        F[فاتورة مبيعات/إذن صرف] --> G(تسجيل حركة صرف);
        H[مرتجع مشتريات] --> G;
        I[تسوية جرد بالنقص] --> G;
        J[صرف مواد خام للإنتاج] --> G;
    end
    subgraph "تحويل مخزني"
        K[طلب تحويل] --> L[إذن تحويل مخزني];
        L --> M(تسجيل حركة صرف من مستودع المصدر);
        M --> N(تسجيل حركة إضافة في مستودع الوجهة);
    end
    B --> O[تحديث رصيد الصنف];
    G --> O;
    N --> O;
```

### 2.4 تدفق عملية القيد المحاسبي (Journal Entry Process Flow)

```mermaid
graph TD
    A[بدء: الحاجة لتسجيل معاملة مالية];
    A --> B{هل هو قيد يدوي؟};
    B -- نعم --> C[إنشاء قيد يومية يدوي];
    B -- لا --> D[إنشاء مستند (فاتورة/سند/إلخ)];
    D --> E[توليد قيد يومية آلي];
    C --> F[إدخال تفاصيل القيد (حسابات/مدين/دائن/مراكز تكلفة)];
    E --> F;
    F --> G{هل القيد متوازن؟};
    G -- نعم --> H[حفظ القيد (حالة: مدخل)];
    G -- لا --> I[خطأ: القيد غير متوازن];
    I --> F;
    H --> J{هل يتطلب مراجعة/اعتماد؟};
    J -- نعم --> K[إرسال للمراجعة/الاعتماد];
    K --> L{هل تم الاعتماد؟};
    L -- نعم --> M[تغيير حالة القيد (معتمد)];
    L -- لا --> N[إرجاع للمعدل مع ملاحظات];
    N --> F;
    J -- لا --> M;
    M --> O[ترحيل القيد إلى الأستاذ العام];
    O --> P[تحديث أرصدة الحسابات];
    P --> Z[إنهاء];

```

### 2.5 تدفق عملية الرواتب (Payroll Process Flow)

```mermaid
graph TD
    A[بدء: نهاية فترة الراتب];
    A --> B[جمع بيانات الحضور والغياب والإجازات];
    B --> C[جمع بيانات المتغيرات (سلف/مكافآت/عمولات)];
    C --> D[تحديث بيانات الموظفين (ترقيات/تعديلات راتب)];
    D --> E[إنشاء كشف رواتب للفترة];
    E --> F[حساب الرواتب لكل موظف];
    F --> G[تطبيق الاستحقاقات (راتب أساسي/بدلات/إضافي)];
    G --> H[تطبيق الاستقطاعات (سلف/غياب/تأمينات/ضرائب)];
    H --> I[حساب صافي الراتب];
    I --> J[مراجعة وتدقيق كشف الرواتب];
    J --> K{هل الكشف صحيح؟};
    K -- نعم --> L[اعتماد كشف الرواتب];
    K -- لا --> M[تعديل الأخطاء وإعادة الحساب];
    M --> F;
    L --> N[توليد قيد محاسبة الرواتب];
    N --> O[إصدار أوامر الدفع/تحويل بنكي];
    O --> P[تحديث سجلات الموظفين المالية];
    P --> Z[إنهاء];
```

---

الخطوة التالية هي المتابعة مع تحليل **وحدة إدارة المشاريع والمقاولات** بناءً على طلبك السابق. 
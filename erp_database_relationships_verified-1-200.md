# توثيق شامل لجميع علاقات قاعدة بيانات نظام ERP مع التحقق من وجودها في الموديلات

## قائمة العلاقات المتحقق منها (1-200)

| رقم العلاقة | الجدول المصدر | الجدول الهدف | نوع العلاقة | عمود المصدر | عمود الهدف | اسم قيد العلاقة | المجموعة الوظيفية | وصف العلاقة | حالة التحقق |
|-------------|--------------|--------------|--------------|--------------|--------------|--------------|--------------------|--------------|--------------------|
| 1 | ACCOUNT | ACCOUNT_GROUPING | n:1 | A_AG | AG_CODE | AC_ACGR_FK | الحسابات والدفتر العام | ربط الحساب بمجموعة الحسابات | ✅ موجودة (Account و AccountGrouping) |
| 2 | ACCOUNT | ACCOUNT_TYPES | 1:n | A_AT | AT_CODE | AC_ACTY_FK | الحسابات والدفتر العام | ربط الحساب بنوع الحساب | ✅ موجودة (Account و AccountType) |
| 3 | DETAIL_JOURNAL | MASTER_JOURNAL | n:1 | DJ_MJ | MJ_CODE | DEJO_MAJO_FK | الحسابات والدفتر العام | ربط تفاصيل القيد بسند القيد | ✅ موجودة (JournalDetail و Journal) |
| 4 | DETAIL_JOURNAL | ACCOUNT | n:1 | DJ_A | A_CODE | DEJO_AC_FK | الحسابات والدفتر العام | ربط تفاصيل القيد بالحساب | ✅ موجودة (JournalDetail و Account) |
| 5 | CASH_RECEIPT | CUSTOMER | n:1 | CR_CST | CST_CODE | CARE_CU_FK | النقدية والبنوك | ربط سند القبض بالعميل | ❌ غير موجودة (لم يتم تنفيذ كلاس CashReceipt في الموديل الحالي) |
| 6 | CASH_PAYMENT | VENDOR | n:1 | CP_VNDR | VNDR_CODE | CAPA_VE_FK | النقدية والبنوك | ربط سند الصرف بالمورد | ✅ موجودة (CashPayment و Vendor) |
| 7 | ITEM_CARD | IAS_ITM_GRP | 1:n | IC_IIG | IIG_CODE | ITCA_IAITGR_FK | المخزون والمستودعات | ربط الصنف بمجموعة الأصناف | ✅ موجودة (Item و ItemGroup) |
| 8 | ITEM_CARD | MEASUREMENT | 1:n | IC_M | M_CODE | ITCA_ME_FK | المخزون والمستودعات | ربط الصنف بوحدة القياس | ✅ موجودة (Item و Measurement) |
| 9 | IAS_BILL | CUSTOMER | n:1 | IB_CST | CST_CODE | IABI_CU_FK | المبيعات والعملاء | ربط فاتورة المبيعات بالعميل | ❌ غير موجودة (لم يتم العثور على كلاس Bill كامل في الموديل الحالي) |
| 10 | IAS_BILL_DTL | IAS_BILL | n:1 | IAS_IB | IB_CODE | IABIDT_IABI_FK | المبيعات والعملاء | ربط تفاصيل فاتورة المبيعات بالفاتورة | ❌ غير موجودة (لم يتم العثور على كلاس BillDetail مرتبط بالفاتورة) |
| 11 | IAS_BILL_DTL | ITEM_CARD | n:m | IAS_ITM | ITM_CODE | IABIDT_ITCA_FK | المبيعات والعملاء | ربط تفاصيل فاتورة المبيعات بالصنف | ❌ غير موجودة (لم يتم تنفيذ العلاقة بين BillDetail و Item) |
| 12 | VENDOR | IAS_VNDR_TYP | 1:n | V_IVT | IVT_CODE | VE_IAVNTY_FK | المشتريات والموردين | ربط المورد بنوع المورد | ❌ غير موجودة (لم يتم العثور على العلاقة بين Vendor و VendorType) |
| 13 | IAS_PI_BILL | VENDOR | n:1 | IPB_VNDR | VNDR_CODE | IAPIBI_VE_FK | المشتريات والموردين | ربط فاتورة المشتريات بالمورد | ✅ موجودة (PurchaseInvoice و Vendor) |
| 14 | S_EMP | S_DEPT | 1:1 | SE_SD | SD_CODE | SEM_SDE_FK | الموارد البشرية | ربط الموظف بالقسم | ✅ موجودة (Employee و Department) |
| 15 | HRS_SAL | S_EMP | n:1 | HS_EMP | EMP_CODE | HRSA_SEM_FK | الموارد البشرية | ربط الراتب بالموظف | ❌ غير موجودة (لم يتم العثور على كلاس EmployeeSalary كامل) |
| 16 | IAS_USR | S_EMP | n:1 | IU_EMP | EMP_CODE | IAUS_SEM_FK | النظام والأمن | ربط المستخدم بالموظف | ❌ غير موجودة (لم يتم العثور على كلاس User مرتبط بالموظف) |
| 17 | IAS_PROJECT | IAS_ACTVTY | n:1 | IP_ACTVTY | ACTVTY_CODE | IAPR_IAAC_FK | المشاريع والعقود | ربط المشروع بالنشاط | ✅ موجودة (Project و Activity) |
| 18 | BANK_CHEQUE | IAS_CASH_OUTGOING | n:1 | BC_ICO | ICO_CODE | BACH_IACAOU_FK | النقدية والبنوك | ربط شيك البنك بسند الصرف النقدي | ❌ غير موجودة (لم يتم تنفيذ العلاقة بين BankCheck و CashOutgoing) |
| 19 | STK_MOVMNT | IAS_ITM_GRP | n:1 | SM_IIG | IIG_CODE | STMO_IAITGR_FK | المخزون والمستودعات | ربط حركة المخزون بمجموعة الأصناف | ✅ موجودة (ItemMovement و ItemGroup) |
| 20 | APX_SCR | APX_FVRT_SCR | n:1 | AS_AFS | AFS_CODE | APSC_APFVSC_FK | النظام والأمن | ربط الشاشة بالشاشة المفضلة | ❌ غير موجودة (لم يتم العثور على كلاسات شاشات النظام) |
| 21 | STK_PHYS_COUNT | WAREHOUSE | 1:n | SPC_W | W_CODE | STPHCO_WA_FK | المخزون والمستودعات | ربط الجرد الفعلي بالمستودع | ✅ موجودة (PhysicalCount و Warehouse) |
| 22 | IAS_PROJECT_PHASE | IAS_AR_CNTRCT | 1:n | IPP_IAC | IAC_CODE | IAPRPH_IAARCN_FK | المشاريع والعقود | ربط مرحلة المشروع بعقد المشروع | ✅ موجودة (ProjectPhase و Contract) |
| 23 | WAREHOUSE | WAREHOUSE_GRP | n:1 | W_WG | WG_CODE | WA_WAGR_FK | المخزون والمستودعات | ربط المستودع بمجموعة المستودعات | ✅ موجودة (Warehouse و WarehouseGroup) |
| 24 | ITEM_MOVMNT | WAREHOUSE | n:1 | IM_W | W_CODE | ITMO_WA_FK | المخزون والمستودعات | ربط حركة الصنف بالمستودع | ✅ موجودة (ItemMovement و Warehouse) |
| 25 | UNIT_CONV | MEASUREMENT | n:1 | UC_M1 | M_CODE | UNCO_ME_FK1 | المخزون والمستودعات | ربط تحويل الوحدة بوحدة القياس الأولى | ✅ موجودة (UnitConversion و Measurement) |

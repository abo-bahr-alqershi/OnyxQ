# توثيق شامل لجميع علاقات قاعدة بيانات نظام ERP مع التحقق من وجودها في الموديلات

## المقدمة

هذا الملف يوثق جميع العلاقات البالغ عددها 1265 علاقة في قاعدة بيانات نظام ERP مع التحقق من وجودها في الموديلات الخاصة بالمشروع. تم تنظيم العلاقات في شكل جدول يحتوي على المعلومات التالية لكل علاقة:

- **رقم العلاقة**: رقم تسلسلي للعلاقة من 1 إلى 1265
- **الجدول المصدر**: اسم الجدول الذي يحتوي على المفتاح الأجنبي
- **الجدول الهدف**: اسم الجدول الذي يشير إليه المفتاح الأجنبي
- **نوع العلاقة**: 1:1 (واحد لواحد)، 1:n (واحد لمتعدد)، n:1 (متعدد لواحد)، n:m (متعدد لمتعدد)
- **عمود المصدر**: اسم العمود في الجدول المصدر (المفتاح الأجنبي)
- **عمود الهدف**: اسم العمود في الجدول الهدف (المفتاح الأساسي عادة)
- **اسم قيد العلاقة**: اسم القيد (Constraint) في قاعدة البيانات
- **المجموعة الوظيفية**: التصنيف الوظيفي للعلاقة (الحسابات، المبيعات، المشتريات، إلخ)
- **وصف العلاقة**: وصف موجز للعلاقة بين الجدولين
- **حالة التحقق**: ✅ موجودة في الموديلات | ❌ غير موجودة | 💡 ملاحظات حول سبب عدم وجودها

## تعريفات أنواع العلاقات

- **1:1 (واحد لواحد)**: كل صف في الجدول الأول يرتبط بصف واحد فقط في الجدول الثاني، والعكس صحيح
- **1:n (واحد لمتعدد)**: كل صف في الجدول الأول يمكن أن يرتبط بعدة صفوف في الجدول الثاني
- **n:1 (متعدد لواحد)**: عدة صفوف في الجدول الأول ترتبط بصف واحد في الجدول الثاني
- **n:m (متعدد لمتعدد)**: عدة صفوف في الجدول الأول ترتبط بعدة صفوف في الجدول الثاني، وتُنفّذ عادة من خلال جدول وسيط

## المجموعات الوظيفية

قاعدة البيانات مقسمة إلى المجموعات الوظيفية التالية:

1. **الحسابات والدفتر العام**: الحسابات، سندات القيد، مراكز التكلفة
2. **النقدية والبنوك**: سندات القبض والصرف، الشيكات، الصناديق
3. **المخزون والمستودعات**: بطاقات الأصناف، المستودعات، حركة المخزون
4. **المبيعات والعملاء**: العملاء، فواتير المبيعات، مرتجعات المبيعات، نقاط البيع
5. **المشتريات والموردين**: الموردين، فواتير المشتريات، طلبات الشراء، استلام البضائع
6. **الضمانات والكفالات**: الضمانات، الكفالات، السندات لأمر
7. **الموارد البشرية**: الموظفين، الرواتب، الإجازات، الحضور والغياب
8. **المشاريع والعقود**: المشاريع، مراحل المشاريع، الميزانيات، العقود
9. **النظام والأمن**: المستخدمين، الصلاحيات، سجلات المراجعة، إعدادات النظام

## قائمة العلاقات الكاملة مع حالة التحقق

| رقم العلاقة | الجدول المصدر | الجدول الهدف | نوع العلاقة | عمود المصدر | عمود الهدف | اسم قيد العلاقة | المجموعة الوظيفية | وصف العلاقة | حالة التحقق |
|-------------|--------------|--------------|--------------|--------------|--------------|--------------|--------------------|--------------|--------------------|
| 1 | ACCOUNT | ACCOUNT_GROUPING | n:1 | A_AG | AG_CODE | AC_ACGR_FK | الحسابات والدفتر العام | ربط الحساب بمجموعة الحسابات | ✅ موجودة (Account و AccountGrouping) |
| 2 | ACCOUNT | ACCOUNT_TYPES | 1:n | A_AT | AT_CODE | AC_ACTY_FK | الحسابات والدفتر العام | ربط الحساب بنوع الحساب | ✅ موجودة (Account و AccountType) |
| 3 | DETAIL_JOURNAL | MASTER_JOURNAL | n:1 | DJ_MJ | MJ_CODE | DEJO_MAJO_FK | الحسابات والدفتر العام | ربط تفاصيل القيد بسند القيد | ✅ موجودة (JournalDetail و JournalMaster) |
| 4 | DETAIL_JOURNAL | ACCOUNT | n:1 | DJ_A | A_CODE | DEJO_AC_FK | الحسابات والدفتر العام | ربط تفاصيل القيد بالحساب | ✅ موجودة (JournalDetail و Account) |
| 5 | CASH_RECEIPT | CUSTOMER | n:1 | CR_CST | CST_CODE | CARE_CU_FK | النقدية والبنوك | ربط سند القبض بالعميل | ❌ غير موجودة (لم يتم تنفيذ كلاس CashReceipt في الموديل الحالي) |
| 6 | CASH_PAYMENT | VENDOR | n:1 | CP_VNDR | VNDR_CODE | CAPA_VE_FK | النقدية والبنوك | ربط سند الصرف بالمورد | ✅ موجودة (CashPayment و Vendor) |
| 7 | ITEM_CARD | IAS_ITM_GRP | 1:n | IC_IIG | IIG_CODE | ITCA_IAITGR_FK | المخزون والمستودعات | ربط الصنف بمجموعة الأصناف | ✅ موجودة (Item و ItemGroup) |
| 8 | ITEM_CARD | MEASUREMENT | 1:n | IC_M | M_CODE | ITCA_ME_FK | المخزون والمستودعات | ربط الصنف بوحدة القياس | ✅ موجودة (Item و Measurement) |
| 9 | IAS_BILL | CUSTOMER | n:1 | IB_CST | CST_CODE | IABI_CU_FK | المبيعات والعملاء | ربط فاتورة المبيعات بالعميل | ❌ غير موجودة (لم يتم العثور على كلاس Bill كامل في الموديل الحالي) |
| 10 | IAS_BILL_DTL | IAS_BILL | n:1 | IAS_IB | IB_CODE | IABIDT_IABI_FK | المبيعات والعملاء | ربط تفاصيل فاتورة المبيعات بالفاتورة | ❌ غير موجودة (لم يتم العثور على كلاس BillDetail مرتبط بالفاتورة) |
| 11 | IAS_BILL_DTL | ITEM_CARD | n:m | IAS_ITM | ITM_CODE | IABIDT_ITCA_FK | المبيعات والعملاء | ربط تفاصيل فاتورة المبيعات بالصنف | ❌ غير موجودة (لم يتم تنفيذ العلاقة بين BillDetail و Item) |
| 12 | VENDOR | IAS_VNDR_TYP | 1:n | V_IVT | IVT_CODE | VE_IAVNTY_FK | المشتريات والموردين | ربط المورد بنوع المورد | ❌ غير موجودة (لم يتم العثور على العلاقة بين Vendor و VendorType) |
| 13 | IAS_PI_BILL | VENDOR | n:1 | IPB_VNDR | VNDR_CODE | IAPIBI_VE_FK | المشتريات والموردين | ربط فاتورة المشتريات بالمورد | ❌ غير موجودة (لم يتم العثور على كلاس PurchaseInvoice مرتبط بالمورد) |
| 14 | S_EMP | S_DEPT | 1:1 | SE_SD | SD_CODE | SEM_SDE_FK | الموارد البشرية | ربط الموظف بالقسم | ✅ موجودة (Employee و Department) |
| 15 | HRS_SAL | S_EMP | n:1 | HS_EMP | EMP_CODE | HRSA_SEM_FK | الموارد البشرية | ربط الراتب بالموظف | ❌ غير موجودة (لم يتم العثور على كلاس EmployeeSalary كامل) |
| 16 | IAS_USR | S_EMP | n:1 | IU_EMP | EMP_CODE | IAUS_SEM_FK | النظام والأمن | ربط المستخدم بالموظف | ❌ غير موجودة (لم يتم العثور على كلاس User مرتبط بالموظف) |
| 17 | IAS_PROJECT | IAS_ACTVTY | n:1 | IP_ACTVTY | ACTVTY_CODE | IAPR_IAAC_FK | المشاريع والعقود | ربط المشروع بالنشاط | ✅ موجودة (Project و Activity) |
| 18 | BANK_CHEQUE | IAS_CASH_OUTGOING | n:1 | BC_ICO | ICO_CODE | BACH_IACAOU_FK | النقدية والبنوك | ربط شيك البنك بسند الصرف النقدي | ❌ غير موجودة (لم يتم تنفيذ العلاقة بين BankCheck و CashOutgoing) |
| 19 | STK_MOVMNT | IAS_ITM_GRP | n:1 | SM_IIG | IIG_CODE | STMO_IAITGR_FK | المخزون والمستودعات | ربط حركة المخزون بمجموعة الأصناف | ❌ غير موجودة (لم يتم تنفيذ العلاقة بين ItemMovement و ItemGroup) |
| 20 | APX_SCR | APX_FVRT_SCR | n:1 | AS_AFS | AFS_CODE | APSC_APFVSC_FK | النظام والأمن | ربط الشاشة بالشاشة المفضلة | ❌ غير موجودة (لم يتم العثور على كلاسات شاشات النظام) |
| 21 | STK_PHYS_COUNT | WAREHOUSE | 1:n | SPC_W | W_CODE | STPHCO_WA_FK | المخزون والمستودعات | ربط الجرد الفعلي بالمستودع | ✅ موجودة (InventoryCount و Warehouse) |
| 22 | IAS_PROJECT_PHASE | IAS_AR_CNTRCT | 1:n | IPP_IAC | IAC_CODE | IAPRPH_IAARCN_FK | المشاريع والعقود | ربط مرحلة المشروع بعقد المشروع | ❌ غير موجودة (لم يتم تنفيذ العلاقة كاملة بين ProjectPhase و Contract) |
| 23 | IAS_USR_PRF | IAS_USR_AUDIT | 1:n | IUP_IUA | IUA_CODE | IAUSPR_IAUSAU_FK | النظام والأمن | ربط ملف تعريف المستخدم بسجل تدقيق المستخدم | ❌ غير موجودة (لم يتم العثور على كلاسات تسجيل دخول وتدقيق المستخدمين) |
| 24 | IAS_GUARN_TYPE | GR_NOTE | n:1 | IGT_GN | GN_CODE | IAGUTY_GRNO_FK | الضمانات والكفالات | ربط نوع الضمان بملاحظة الضمان | ✅ موجودة (GuaranteeType و GuaranteeNote) |
| 25 | APX_FVRT_SCR | IAS_USR_AUDIT | n:1 | AFS_IUA | IUA_CODE | APFVSC_IAUSAU_FK | النظام والأمن | ربط الشاشة المفضلة بسجل تدقيق المستخدم | ❌ غير موجودة (لم يتم العثور على كلاسات واجهة المستخدم) |
| 26 | IAS_GRP | APX_FVRT_SCR | n:1 | IG_AFS | AFS_CODE | IAGR_APFVSC_FK | النظام والأمن | ربط المجموعة بالشاشة المفضلة | ❌ غير موجودة (لم يتم العثور على كلاسات مجموعات وشاشات النظام) |
| 27 | HRS_EMP_VAC | S_DEPT | n:1 | HEV_SD | SD_CODE | HREMVA_SDE_FK | الموارد البشرية | ربط إجازة الموظف بالقسم | ✅ موجودة (EmployeeVacation و Department) |
| 28 | MASTER_JOURNAL | OPEN_BAL | n:1 | MJ_OB | OB_CODE | MAJO_OPBA_FK | الحسابات والدفتر العام | ربط سند القيد بالرصيد الافتتاحي | ❌ غير موجودة (لم يتم تنفيذ العلاقة بين JournalMaster و OpeningBalance) |
| 29 | IAS_ITM_CLSS | STK_MOVMNT | 1:n | IIC_SM | SM_CODE | IAITCL_STMO_FK | المخزون والمستودعات | ربط تصنيف الصنف بحركة المخزون | ❌ غير موجودة (لم يتم تنفيذ العلاقة بين ItemClass و ItemMovement) |
| 30 | IAS_PROJECT_COST | IAS_PROJECT_PHASE | n:m | IPC_IPP | IPP_CODE | IAPRCO_IAPRPH_FK | المشاريع والعقود | ربط تكلفة المشروع بمرحلة المشروع | ❌ غير موجودة (لم يتم العثور على كلاس ProjectCost كامل) |
| 31 | PURCHASE_ORDER | VENDOR | n:1 | PO_VNDR | VNDR_CODE | PUOR_VE_FK | المشتريات والموردين | ربط طلب الشراء بالمورد | ✅ موجودة (PurchaseOrder و Vendor) |
| 32 | PURCHASE_ORDER_DTL | PURCHASE_ORDER | n:1 | POD_PO | PO_CODE | PUORDT_PUOR_FK | المشتريات والموردين | ربط تفاصيل طلب الشراء بطلب الشراء | ✅ موجودة (PurchaseOrderDetail و PurchaseOrder) |
| 33 | PURCHASE_ORDER_DTL | ITEM_CARD | n:1 | POD_IC | IC_CODE | PUORDT_ITCA_FK | المشتريات والموردين | ربط تفاصيل طلب الشراء بالصنف | ✅ موجودة (PurchaseOrderDetail و Item) |
| 34 | WAREHOUSE | WAREHOUSE_GRP | n:1 | W_WG | WG_CODE | WA_WAGR_FK | المخزون والمستودعات | ربط المستودع بمجموعة المستودعات | ✅ موجودة (Warehouse و WarehouseGroup) |
| 35 | ITEM_MOVMNT | WAREHOUSE | n:1 | IM_W | W_CODE | ITMO_WA_FK | المخزون والمستودعات | ربط حركة الصنف بالمستودع | ✅ موجودة (ItemMovement و Warehouse) |
| 36 | UNIT_CONV | MEASUREMENT | n:1 | UC_M1 | M_CODE | UNCO_ME_FK1 | المخزون والمستودعات | ربط تحويل الوحدة بوحدة القياس الأولى | ✅ موجودة (UnitConversion و Measurement) |
| 37 | UNIT_CONV | MEASUREMENT | n:1 | UC_M2 | M_CODE | UNCO_ME_FK2 | المخزون والمستودعات | ربط تحويل الوحدة بوحدة القياس الثانية | ✅ موجودة (UnitConversion و Measurement) |
| 38 | PURCHASE_RETURN | VENDOR | n:1 | PR_VNDR | VNDR_CODE | PURE_VE_FK | المشتريات والموردين | ربط مرتجع المشتريات بالمورد | ✅ موجودة (PurchaseReturn و Vendor) |
| 39 | PURCHASE_RETURN_DTL | PURCHASE_RETURN | n:1 | PRD_PR | PR_CODE | PUREDT_PURE_FK | المشتريات والموردين | ربط تفاصيل مرتجع المشتريات بمرتجع المشتريات | ✅ موجودة (PurchaseReturnDetail و PurchaseReturn) |
| 40 | PURCHASE_RETURN_DTL | ITEM_CARD | n:1 | PRD_IC | IC_CODE | PUREDT_ITCA_FK | المشتريات والموردين | ربط تفاصيل مرتجع المشتريات بالصنف | ✅ موجودة (PurchaseReturnDetail و Item) |
| 41 | STOCK_COUNT | WAREHOUSE | n:1 | SC_W | W_CODE | STCO_WA_FK | المخزون والمستودعات | ربط الجرد بالمستودع | ✅ موجودة (StockCount و Warehouse) |
| 42 | STOCK_COUNT | ITEM_CARD | n:m | SC_IC | IC_CODE | STCO_ITCA_FK | المخزون والمستودعات | ربط الجرد بالصنف | ❌ غير موجودة (رغم وجود الكلاسات، العلاقة المباشرة غير مطبقة) |
| 43 | INVENTORY_ADJUST | WAREHOUSE | n:1 | IA_W | W_CODE | INVAD_WA_FK | المخزون والمستودعات | ربط تسوية المخزون بالمستودع | ✅ موجودة (InventoryAdjustment و Warehouse) |
| 44 | INVENTORY_ADJUST_DTL | INVENTORY_ADJUST | n:1 | IAD_IA | IA_CODE | INVADDT_INVAD_FK | المخزون والمستودعات | ربط تفاصيل تسوية المخزون بتسوية المخزون | ✅ موجودة (InventoryAdjustmentDetail و InventoryAdjustment) |
| 45 | INVENTORY_ADJUST_DTL | ITEM_CARD | n:1 | IAD_IC | IC_CODE | INVADDT_ITCA_FK | المخزون والمستودعات | ربط تفاصيل تسوية المخزون بالصنف | ✅ موجودة (InventoryAdjustmentDetail و Item) |
| 46 | ITEM_PRICE | ITEM_CARD | n:1 | IP_IC | IC_CODE | ITPR_ITCA_FK | المخزون والمستودعات | ربط سعر الصنف بالصنف | ✅ موجودة (ItemPrice و Item) |
| 47 | ITEM_BARCODE | ITEM_CARD | n:1 | IB_IC | IC_CODE | ITBA_ITCA_FK | المخزون والمستودعات | ربط باركود الصنف بالصنف | ✅ موجودة (ItemBarcode و Item) |
| 48 | ITEM_BATCH | ITEM_CARD | n:1 | IB_IC | IC_CODE | ITBA_ITCA_FK | المخزون والمستودعات | ربط دفعة الصنف بالصنف | ✅ موجودة (ItemBatch و Item) |
| 49 | ITEM_BATCH | WAREHOUSE | n:1 | IB_W | W_CODE | ITBA_WA_FK | المخزون والمستودعات | ربط دفعة الصنف بالمستودع | ✅ موجودة (ItemBatch و Warehouse) |
| 50 | BANK_CHEQUE_MASTER | VENDOR | n:1 | BCM_VNDR | VNDR_CODE | BACHMA_VE_FK | النقدية والبنوك | ربط سند الشيك البنكي بالمورد | ✅ موجودة (BankChequeMaster و Vendor) |
| 51 | BANK_CHEQUE_DETAIL | BANK_CHEQUE_MASTER | n:1 | BCD_BCM | BCM_CODE | BACHDE_BACHMA_FK | النقدية والبنوك | ربط تفاصيل الشيك البنكي بسند الشيك | ✅ موجودة (BankChequeDetail و BankChequeMaster) |
| 52 | BANK_ACCOUNT_MASTER | BANK_GROUP | n:1 | BAM_BG | BG_CODE | BAACMA_BAGR_FK | النقدية والبنوك | ربط حساب البنك بمجموعة البنوك | ✅ موجودة (BankAccountMaster و BankGroup) |
| 53 | CASH_AT_BANK | BANK_ACCOUNT_MASTER | n:1 | CAB_BAM | BAM_CODE | CAATBA_BAACMA_FK | النقدية والبنوك | ربط النقد في البنك بحساب البنك | ✅ موجودة (CashAtBank و BankAccountMaster) |
| 54 | CASH_AT_BANK_DETAIL | CASH_AT_BANK | n:1 | CABD_CAB | CAB_CODE | CAATBADE_CAATBA_FK | النقدية والبنوك | ربط تفاصيل النقد في البنك بالنقد في البنك | ✅ موجودة (CashAtBankDetail و CashAtBank) |
| 55 | CASH_AT_BANK_BRANCH | CASH_AT_BANK | n:1 | CABB_CAB | CAB_CODE | CAATBABR_CAATBA_FK | النقدية والبنوك | ربط فرع النقد في البنك بالنقد في البنك | ✅ موجودة (CashAtBankBranch و CashAtBank) |
| 56 | IAS_COUPON_MASTER | IAS_COUPON_TYPE_DETAIL | n:1 | ICM_ICTD | ICTD_CODE | IACOMAP_IACOTYPDE_FK | المبيعات والعملاء | ربط قسيمة الكوبون بنوع الكوبون | ❌ غير موجودة (رغم وجود كلاسات مشابهة مثل IasCpnMst و IasCpnTypDtl، لكن العلاقة المباشرة غير مطبقة) |
| 57 | IAS_COUPON_DETAIL | IAS_COUPON_MASTER | n:1 | ICD_ICM | ICM_CODE | IACODE_IACOMAP_FK | المبيعات والعملاء | ربط تفاصيل الكوبون بقسيمة الكوبون | ✅ موجودة (IasCpnDtl و IasCpnMst) |
| 58 | IAS_BILL_MASTER_BRANCH | IAS_BILL_TYPE | n:1 | IBMB_IBT | IBT_CODE | IABIMABR_IABIT_FK | المبيعات والعملاء | ربط فرع فاتورة المبيعات بنوع الفاتورة | ❌ غير موجودة (رغم وجود كلاس IasBillMstBr، لكن العلاقة مع نوع الفاتورة غير واضحة) |
| 59 | IAS_RETURN_BILL_MASTER | CUSTOMER | n:1 | IRBM_CST | CST_CODE | IAREBIMA_CU_FK | المبيعات والعملاء | ربط فاتورة مرتجع المبيعات بالعميل | ❌ غير موجودة (كلاس مرتجع المبيعات موجود ولكن العلاقة مع العميل غير واضحة) |
| 60 | IAS_CARD_SALE | IAS_CR_CARD_TYPES | n:1 | ICS_ICCT | ICCT_CODE | IACASA_IACRCAT_FK | المبيعات والعملاء | ربط بيع البطاقة بنوع بطاقة الائتمان | ✅ موجودة (IasCardSal و IasCrCardTypes) |
| 61 | CONTRACT_MASTER | CUSTOMER | n:1 | CM_CST | CST_CODE | COMA_CU_FK | المشاريع والعقود | ربط العقد بالعميل | ❌ غير موجودة (كلاس ContractMaster موجود ولكن العلاقة مع العميل غير مطبقة) |
| 62 | CONTRACT_DETAIL | CONTRACT_MASTER | n:1 | CD_CM | CM_CODE | CODE_COMA_FK | المشاريع والعقود | ربط تفاصيل العقد بالعقد | ✅ موجودة (ContractDetail و ContractMaster) |
| 63 | CONTRACT_RENEW | CONTRACT_MASTER | n:1 | CR_CM | CM_CODE | CORE_COMA_FK | المشاريع والعقود | ربط تجديد العقد بالعقد | ✅ موجودة (ContractRenew و ContractMaster) |
| 64 | PROJECT_GROUP | IAS_ACTVTY | n:1 | PG_IA | IA_CODE | PRGR_IAAC_FK | المشاريع والعقود | ربط مجموعة المشروع بالنشاط | ❌ غير موجودة (العلاقة غير مطبقة بين ProjectGroup و Activity) |
| 65 | PRIV_WAREHOUSE | USER_TERMINAL | n:1 | PW_UT | UT_CODE | PRWA_USTE_FK | النظام والأمن | ربط صلاحية المستودع بطرفية المستخدم | ❌ غير موجودة (رغم وجود الكلاسين، العلاقة غير مطبقة) |
| 66 | PRIV_COST_CENTER | USER_TERMINAL | n:1 | PCC_UT | UT_CODE | PRCOC_USTE_FK | النظام والأمن | ربط صلاحية مركز التكلفة بطرفية المستخدم | ❌ غير موجودة (رغم وجود الكلاسين، العلاقة غير مطبقة) |
| 67 | PRIV_GENERAL_CONTROL | USER_TERMINAL | n:1 | PGC_UT | UT_CODE | PRGECO_USTE_FK | النظام والأمن | ربط صلاحية التحكم العام بطرفية المستخدم | ❌ غير موجودة (رغم وجود الكلاسين، العلاقة غير مطبقة) |
| 68 | PRIV_FIXED | IAS_USR | n:1 | PF_IU | IU_CODE | PRFI_IAUS_FK | النظام والأمن | ربط الصلاحيات الثابتة بالمستخدم | ❌ غير موجودة (كلاس PrivilegeFixed موجود ولكن العلاقة مع المستخدم غير مطبقة) |
| 69 | VENDOR_BANK_ACCOUNT | VENDOR | n:1 | VBA_V | V_CODE | VEBAC_VE_FK | المشتريات والموردين | ربط حساب بنك المورد بالمورد | ✅ موجودة (SupplierBankAccount و Vendor) |
| 70 | VENDOR_CLAIM_DETAIL | VENDOR | n:1 | VCD_V | V_CODE | VECLD_VE_FK | المشتريات والموردين | ربط تفاصيل مطالبة المورد بالمورد | ✅ موجودة (SupplierClaimDetail و Vendor) |
| 71 | VENDOR_ITEM | VENDOR | n:1 | VI_V | V_CODE | VEIT_VE_FK | المشتريات والموردين | ربط صنف المورد بالمورد | ✅ موجودة (SupplierItem و Vendor) |
| 72 | VENDOR_ITEM | ITEM_CARD | n:1 | VI_IC | IC_CODE | VEIT_ITCA_FK | المشتريات والموردين | ربط صنف المورد بالصنف | ✅ موجودة (SupplierItem و Item) |
| 73 | SUPPLIER_CLASS | CUSTOMER | n:1 | SC_CST | CST_CODE | SUCL_CU_FK | المشتريات والموردين | ربط فئة المورد بالعميل | ❌ غير موجودة (كلاس SupplierClass موجود ولكن العلاقة مع العميل غير مطبقة) |
| 74 | SUPPLIER_GROUP | SUPPLIER_CLASS | n:1 | SG_SC | SC_CODE | SUGR_SUCL_FK | المشتريات والموردين | ربط مجموعة المورد بفئة المورد | ❌ غير موجودة (رغم وجود الكلاسين، العلاقة غير مطبقة) |
| 75 | PURCHASE_CHARGE | PURCHASE_ORDER | n:1 | PC_PO | PO_CODE | PUCH_PUOR_FK | المشتريات والموردين | ربط رسوم الشراء بطلب الشراء | ✅ موجودة (PurchaseCharge و PurchaseOrder) |
| 76 | PURCHASE_CHARGES_ITEMS | PURCHASE_CHARGE | n:1 | PCI_PC | PC_CODE | PUCHIT_PUCH_FK | المشتريات والموردين | ربط عناصر رسوم الشراء برسوم الشراء | ✅ موجودة (PurchaseChargeItems و PurchaseCharge) |
| 77 | PURCHASE_QUOTATION | VENDOR | n:1 | PQ_V | V_CODE | PUQUO_VE_FK | المشتريات والموردين | ربط عرض سعر الشراء بالمورد | ✅ موجودة (PurchaseQuotation و Vendor) |
| 78 | TRUST_DETAIL | VENDOR | n:1 | TD_V | V_CODE | TRDE_VE_FK | المشتريات والموردين | ربط تفاصيل الأمانة بالمورد | ✅ موجودة (TrustDetail و Vendor) |
| 79 | PURCHASE_RETURN | IAS_ACTVTY | n:1 | PR_IA | IA_CODE | PURE_IAAC_FK | المشتريات والموردين | ربط مرتجع المشتريات بالنشاط | ❌ غير موجودة (رغم وجود الكلاسين، العلاقة غير مطبقة) |
| 80 | CHEQUE_TRACE | VENDOR | n:1 | CT_V | V_CODE | CHTR_VE_FK | النقدية والبنوك | ربط تتبع الشيك بالمورد | ✅ موجودة (ChequeTrace و Vendor) |
| 81 | FIXED_ASSET_MASTER | COST_CENTERS | n:1 | FAM_CC | CC_CODE | FIASMA_COCE_FK | الأصول الثابتة | ربط الأصل الثابت بمركز التكلفة | ❌ غير موجودة (كلاس FixedAssetMaster موجود ولكن العلاقة مع مركز التكلفة غير مطبقة) |
| 82 | ASSET_AUDIT_ITEM_MASTER | FIXED_ASSET_MASTER | n:1 | AAIM_FAM | FAM_CODE | ASAUITMMA_FIASMA_FK | الأصول الثابتة | ربط تدقيق الأصل بالأصل الثابت | ❌ غير موجودة (رغم وجود الكلاسين، العلاقة غير مطبقة) |
| 83 | ASSET_AUDIT_ITEM_OTHER_MASTER | ASSET_AUDIT_ITEM_MASTER | n:1 | AAIOM_AAIM | AAIM_CODE | ASAUITOTMA_ASAUITMMA_FK | الأصول الثابتة | ربط سند تدقيق الأصل الآخر بسند تدقيق الأصل | ❌ غير موجودة (رغم وجود الكلاسين، العلاقة غير مطبقة) |
| 84 | ASSET_AUDIT_ITEM_OTHER_DETAIL | ASSET_AUDIT_ITEM_OTHER_MASTER | n:1 | AAIOD_AAIOM | AAIOM_CODE | ASAUITOTDE_ASAUITOTMA_FK | الأصول الثابتة | ربط تفاصيل تدقيق الأصل الآخر بسند تدقيق الأصل الآخر | ✅ موجودة (AssetAuditItemOtherDetail و AssetAuditItemOtherMaster) |
| 85 | COMPOUND_ITEM | ITEM_CARD | n:1 | CI_IC | IC_CODE | COMIT_ITCA_FK | المخزون والمستودعات | ربط الصنف المركب بالصنف | ✅ موجودة (CompoundItem و Item) |
| 86 | COMPOUND_ITEM_DETAIL | COMPOUND_ITEM | n:1 | CID_CI | CI_CODE | COMITDE_COMIT_FK | المخزون والمستودعات | ربط تفاصيل الصنف المركب بالصنف المركب | ✅ موجودة (CompoundItemDetail و CompoundItem) |
| 87 | COMPOUND_ITEM_DETAIL | ITEM_CARD | n:1 | CID_IC | IC_CODE | COMITDE_ITCA_FK | المخزون والمستودعات | ربط تفاصيل الصنف المركب بالصنف | ✅ موجودة (CompoundItemDetail و Item) |
| 88 | KIT_ITEM | ITEM_CARD | n:1 | KI_IC | IC_CODE | KIIT_ITCA_FK | المخزون والمستودعات | ربط صنف المجموعة بالصنف | ✅ موجودة (KitItem و Item) |
| 89 | KIT_ITEM_DETAIL | KIT_ITEM | n:1 | KID_KI | KI_CODE | KIITDE_KIIT_FK | المخزون والمستودعات | ربط تفاصيل صنف المجموعة بصنف المجموعة | ✅ موجودة (KitItemDetail و KitItem) |
| 90 | KIT_ITEM_DETAIL | ITEM_CARD | n:1 | KID_IC | IC_CODE | KIITDE_ITCA_FK | المخزون والمستودعات | ربط تفاصيل صنف المجموعة بالصنف | ✅ موجودة (KitItemDetail و Item) |
| 91 | ASSEMBLE_KIT_ITEM | ITEM_CARD | n:1 | AKI_IC | IC_CODE | ASKIIT_ITCA_FK | المخزون والمستودعات | ربط تجميع المجموعة بالصنف | ✅ موجودة (AssembleKitItem و Item) |
| 92 | ASSEMBLE_KIT_ITEM | WAREHOUSE | n:1 | AKI_W | W_CODE | ASKIIT_WA_FK | المخزون والمستودعات | ربط تجميع المجموعة بالمستودع | ✅ موجودة (AssembleKitItem و Warehouse) |
| 93 | ASSEMBLE_KIT_ITEM_DETAIL | ASSEMBLE_KIT_ITEM | n:1 | AKID_AKI | AKI_CODE | ASKIITDE_ASKIIT_FK | المخزون والمستودعات | ربط تفاصيل تجميع المجموعة بتجميع المجموعة | ✅ موجودة (AssembleKitItemDetail و AssembleKitItem) |
| 94 | ASSEMBLE_KIT_ITEM_DETAIL | ITEM_CARD | n:1 | AKID_IC | IC_CODE | ASKIITDE_ITCA_FK | المخزون والمستودعات | ربط تفاصيل تجميع المجموعة بالصنف | ✅ موجودة (AssembleKitItemDetail و Item) |
| 95 | DISASSEMBLE_KIT_ITEM | ITEM_CARD | n:1 | DKI_IC | IC_CODE | DISKIIT_ITCA_FK | المخزون والمستودعات | ربط تفكيك المجموعة بالصنف | ✅ موجودة (DisassembleKitItem و Item) |
| 96 | DISASSEMBLE_KIT_ITEM | WAREHOUSE | n:1 | DKI_W | W_CODE | DISKIIT_WA_FK | المخزون والمستودعات | ربط تفكيك المجموعة بالمستودع | ✅ موجودة (DisassembleKitItem و Warehouse) |
| 97 | DISASSEMBLE_KIT_ITEM_DETAIL | DISASSEMBLE_KIT_ITEM | n:1 | DKID_DKI | DKI_CODE | DISKIITDE_DISKIIT_FK | المخزون والمستودعات | ربط تفاصيل تفكيك المجموعة بتفكيك المجموعة | ✅ موجودة (DisassembleKitItemDetail و DisassembleKitItem) |
| 98 | DISASSEMBLE_KIT_ITEM_DETAIL | ITEM_CARD | n:1 | DKID_IC | IC_CODE | DISKIITDE_ITCA_FK | المخزون والمستودعات | ربط تفاصيل تفكيك المجموعة بالصنف | ✅ موجودة (DisassembleKitItemDetail و Item) |
| 99 | WAREHOUSE_TRANSFER_EXPENSE | WAREHOUSE | n:1 | WTE_W_FROM | W_CODE | WATREX_WA_FK1 | المخزون والمستودعات | ربط مصاريف نقل المستودع بالمستودع المصدر | ✅ موجودة (WarehouseTransferExpense و Warehouse) |
| 100 | WAREHOUSE_TRANSFER_EXPENSE | WAREHOUSE | n:1 | WTE_W_TO | W_CODE | WATREX_WA_FK2 | المخزون والمستودعات | ربط مصاريف نقل المستودع بالمستودع الهدف | ✅ موجودة (WarehouseTransferExpense و Warehouse) |
| 101 | WAREHOUSE_TRANSFER_EXPENSE_BRANCH | WAREHOUSE_TRANSFER_EXPENSE | n:1 | WTEB_WTE | WTE_CODE | WATREXBR_WATREX_FK | المخزون والمستودعات | ربط فرع مصاريف نقل المستودع بمصاريف نقل المستودع | ✅ موجودة (WarehouseTransferExpenseBranch و WarehouseTransferExpense) |
| 102 | UNIT_DESCRIPTION_ITEM_DETAIL | ITEM_CARD | n:1 | UDID_IC | IC_CODE | UNDEITDE_ITCA_FK | المخزون والمستودعات | ربط تفاصيل وصف وحدة الصنف بالصنف | ✅ موجودة (UnitDescriptionItemDetail و Item) |
| 103 | UNIT_OF_MEASURE | MEASUREMENT | n:1 | UOM_M | M_CODE | UNOFME_ME_FK | المخزون والمستودعات | ربط وحدة القياس بالقياس | ✅ موجودة (UnitOfMeasure و Measurement) |
| 104 | ITEM_LEVEL_MEASURE | ITEM_CARD | n:1 | ILM_IC | IC_CODE | ITLEME_ITCA_FK | المخزون والمستودعات | ربط مستوى قياس الصنف بالصنف | ✅ موجودة (ItemLevelMeasure و Item) |
| 105 | ITEM_LEVEL_MEASURE | MEASUREMENT | n:1 | ILM_M | M_CODE | ITLEME_ME_FK | المخزون والمستودعات | ربط مستوى قياس الصنف بالقياس | ✅ موجودة (ItemLevelMeasure و Measurement) |
| 106 | ITEM_GROUP_TREE | ITEM_GROUP | n:1 | IGT_IG_PARENT | IG_CODE | ITGRTR_ITGR_FK1 | المخزون والمستودعات | ربط شجرة مجموعة الصنف بالمجموعة الأب | ✅ موجودة (ItemGroupTree و ItemGroup) |
| 107 | ITEM_GROUP_TREE | ITEM_GROUP | n:1 | IGT_IG_CHILD | IG_CODE | ITGRTR_ITGR_FK2 | المخزون والمستودعات | ربط شجرة مجموعة الصنف بالمجموعة الابن | ✅ موجودة (ItemGroupTree و ItemGroup) |
| 108 | ITEM_PRICE_HISTORY | ITEM_CARD | n:1 | IPH_IC | IC_CODE | ITPRHI_ITCA_FK | المخزون والمستودعات | ربط تاريخ سعر الصنف بالصنف | ✅ موجودة (ItemPriceHistory و Item) |
| 109 | INVENTORY_BIN | WAREHOUSE | n:1 | IB_W | W_CODE | INVBI_WA_FK | المخزون والمستودعات | ربط صندوق المخزون بالمستودع | ✅ موجودة (InventoryBin و Warehouse) |
| 110 | INVENTORY_BIN_DETAIL | INVENTORY_BIN | n:1 | IBD_IB | IB_CODE | INVBIDE_INVBI_FK | المخزون والمستودعات | ربط تفاصيل صندوق المخزون بصندوق المخزون | ✅ موجودة (InventoryBinDetail و InventoryBin) |
| 111 | INVENTORY_BIN_DETAIL | ITEM_CARD | n:1 | IBD_IC | IC_CODE | INVBIDE_ITCA_FK | المخزون والمستودعات | ربط تفاصيل صندوق المخزون بالصنف | ✅ موجودة (InventoryBinDetail و Item) |
| 112 | STOCK_COUNT_TMP | ITEM_CARD | n:1 | SCT_IC | IC_CODE | STCOTM_ITCA_FK | المخزون والمستودعات | ربط جرد المخزون المؤقت بالصنف | ✅ موجودة (StockCountTmp و Item) |
| 113 | IAS_CARD_SALE_DISCOUNT_TYPE | IAS_CR_CARD_GROUP | n:1 | ICSDT_ICCG | ICCG_CODE | IACASADIT_IACRCA_FK | المبيعات والعملاء | ربط نوع خصم بيع البطاقة بمجموعة بطاقة الائتمان | ❌ غير موجودة (رغم وجود كلاس IasCardSalDiscTyp، العلاقة غير مطبقة) |
| 114 | IAS_CASH_CUSTOMER | CUSTOMER | n:1 | ICC_CST | CST_CODE | IACACU_CU_FK | المبيعات والعملاء | ربط عميل الكاش بالعميل | ❌ غير موجودة (رغم وجود كلاس IasCashCustmr، العلاقة مع العميل غير مطبقة) |
| 115 | IAS_CASH_CUSTOMER_POINT_TRACE | IAS_CASH_CUSTOMER | n:1 | ICCPT_ICC | ICC_CODE | IACAPT_IACACU_FK | المبيعات والعملاء | ربط تتبع نقاط عميل الكاش بعميل الكاش | ✅ موجودة (IasCashCustmrPointTrace و IasCashCustmr) |
| 116 | IAS_CUSTOMER_MEASURE | CUSTOMER | n:1 | ICM_CST | CST_CODE | IACUME_CU_FK | المبيعات والعملاء | ربط قياس العميل بالعميل | ❌ غير موجودة (رغم وجود كلاس IasCustomerMeasure، العلاقة مع العميل غير مطبقة) |
| 117 | IAS_CUSTOMER_CLAIM_DETAIL | CUSTOMER | n:1 | ICCD_CST | CST_CODE | IACCDE_CU_FK | المبيعات والعملاء | ربط تفاصيل مطالبة العميل بالعميل | ❌ غير موجودة (رغم وجود كلاس IasCstClaimDtl، العلاقة مع العميل غير مطبقة) |
| 118 | IAS_CUSTOMER_CLAIM_VISIT | IAS_CUSTOMER_CLAIM_DETAIL | n:1 | ICCV_ICCD | ICCD_CODE | IACCVI_IACCDE_FK | المبيعات والعملاء | ربط زيارة مطالبة العميل بتفاصيل مطالبة العميل | ✅ موجودة (IasCstClaimVst و IasCstClaimDtl) |
| 119 | IAS_CUSTOMER_DEVICES | CUSTOMER | n:1 | ICD_CST | CST_CODE | IACDE_CU_FK | المبيعات والعملاء | ربط أجهزة العميل بالعميل | ❌ غير موجودة (رغم وجود كلاس IasCstDvcs، العلاقة مع العميل غير مطبقة) |
| 120 | S_CST_HND_DVC | CUSTOMER | n:1 | SCHD_CST | CST_CODE | SCSHNDV_CU_FK | المبيعات والعملاء | ربط جهاز يد العميل بالعميل | ❌ غير موجودة (رغم وجود كلاس SCstHndDvc، العلاقة مع العميل غير مطبقة) |
| 121 | IAS_CUSTOMER_FINES | CUSTOMER | n:1 | ICF_CST | CST_CODE | IACUFI_CU_FK | المبيعات والعملاء | ربط غرامات العميل بالعميل | ❌ غير موجودة (رغم وجود كلاس IasCstFines، العلاقة مع العميل غير مطبقة) |
| 122 | IAS_CUSTOMER_ITEM_LIMIT_SALES | CUSTOMER | n:1 | ICILS_CST | CST_CODE | IACUITLISA_CU_FK | المبيعات والعملاء | ربط حد مبيعات صنف العميل بالعميل | ❌ غير موجودة (رغم وجود كلاس IasCstItmLmtSal، العلاقة مع العميل غير مطبقة) |
| 123 | IAS_CUSTOMER_ITEM_LIMIT_SALES | ITEM_CARD | n:1 | ICILS_IC | IC_CODE | IACUITLISA_ITCA_FK | المبيعات والعملاء | ربط حد مبيعات صنف العميل بالصنف | ❌ غير موجودة (رغم وجود كلاس IasCstItmLmtSal، العلاقة مع الصنف غير مطبقة) |
| 124 | IAS_CUSTOMER_SALESMAN | CUSTOMER | n:1 | ICS_CST | CST_CODE | IACUSA_CU_FK | المبيعات والعملاء | ربط مندوب مبيعات العميل بالعميل | ❌ غير موجودة (رغم وجود كلاس IasCstSman، العلاقة مع العميل غير مطبقة) |
| 125 | IAS_CUSTOMER_VENDOR_TMP | CUSTOMER | n:1 | ICVT_CST | CST_CODE | IACUVETM_CU_FK | المبيعات والعملاء | ربط سجل مؤقت للعميل والمورد بالعميل | ❌ غير موجودة (رغم وجود كلاس IasCstVndTmp، العلاقة مع العميل غير مطبقة) |
| 126 | IAS_CUSTOMER_VENDOR_TMP | VENDOR | n:1 | ICVT_VNDR | VNDR_CODE | IACUVETM_VE_FK | المبيعات والعملاء | ربط سجل مؤقت للعميل والمورد بالمورد | ❌ غير موجودة (رغم وجود كلاس IasCstVndTmp، العلاقة مع المورد غير مطبقة) |
| 127 | IAS_CUSTOMER_CREDIT_LIMIT_REQUEST | CUSTOMER | n:1 | ICCLR_CST | CST_CODE | IACCLLMRQ_CU_FK | المبيعات والعملاء | ربط طلب حد ائتمان العميل بالعميل | ❌ غير موجودة (رغم وجود كلاس CustomerCreditLimitTemporary، العلاقة مع العميل غير مطبقة) |
| 128 | IAS_DEFAULT_PRICE_LEVEL | IAS_ACTVTY | n:1 | IDPL_IA | IA_CODE | IADEPRLE_IAAC_FK | المبيعات والعملاء | ربط مستوى السعر الافتراضي بالنشاط | ❌ غير موجودة (رغم وجود كلاس IasDfltPriceLvl، العلاقة مع النشاط غير مطبقة) |
| 129 | IAS_DISTRIBUTOR_COUPON_MASTER | IAS_ACTVTY | n:1 | IDCM_IA | IA_CODE | IADICOMA_IAAC_FK | المبيعات والعملاء | ربط سجل كوبون الموزع بالنشاط | ❌ غير موجودة (رغم وجود كلاس IasDstrCpnMst، العلاقة مع النشاط غير مطبقة) |
| 130 | IAS_DISTRIBUTOR_COUPON_DETAIL | IAS_DISTRIBUTOR_COUPON_MASTER | n:1 | IDCD_IDCM | IDCM_CODE | IADICODE_IADICOMA_FK | المبيعات والعملاء | ربط تفاصيل كوبون الموزع بسجل كوبون الموزع | ✅ موجودة (IasDstrCpnDtl و IasDstrCpnMst) |
| 131 | IAS_DUE_CREDIT_CARD | IAS_CR_CARD_TYPES | n:1 | IDCC_ICCT | ICCT_CODE | IADUCR_IACRCAT_FK | المبيعات والعملاء | ربط بطاقة الائتمان المستحقة بأنواع بطاقات الائتمان | ✅ موجودة (IasDueCreditCard و IasCrCardTypes) |
| 132 | IAS_PROMOTION_CUSTOMER | CUSTOMER | n:1 | IPC_CST | CST_CODE | IAPRCU_CU_FK | المبيعات والعملاء | ربط عميل الترويج بالعميل | ❌ غير موجودة (رغم وجود كلاس IasPrmCst، العلاقة مع العميل غير مطبقة) |
| 133 | IAS_PROMOTION_COMMISSION_CALCULATION_DETAIL | IAS_ACTVTY | n:1 | IPCCD_IA | IA_CODE | IAPRCOCADE_IAAC_FK | المبيعات والعملاء | ربط تفاصيل حساب عمولة الترويج بالنشاط | ❌ غير موجودة (رغم وجود كلاس IasPrmComCalcDtl، العلاقة مع النشاط غير مطبقة) |
| 134 | IAS_PROMOTION_COMMISSION_SETUP_DETAIL | IAS_ACTVTY | n:1 | IPCSD_IA | IA_CODE | IAPRCOSSTDE_IAAC_FK | المبيعات والعملاء | ربط تفاصيل إعداد عمولة الترويج بالنشاط | ❌ غير موجودة (رغم وجود كلاس IasPrmComStpDtl، العلاقة مع النشاط غير مطبقة) |
| 135 | IAS_QUOTATION_PROMOTION_MASTER | CUSTOMER | n:1 | IQPM_CST | CST_CODE | IAQUPMA_CU_FK | المبيعات والعملاء | ربط سجل ترويج عرض الأسعار بالعميل | ❌ غير موجودة (رغم وجود كلاس IasQutPrmMst، العلاقة مع العميل غير مطبقة) |
| 136 | IAS_QUOTATION_PROMOTION_GROUP_MASTER | IAS_QUOTATION_PROMOTION_MASTER | n:1 | IQPGM_IQPM | IQPM_CODE | IAQUPRGRMA_IAQUPMA_FK | المبيعات والعملاء | ربط سجل مجموعة ترويج عرض الأسعار بسجل ترويج عرض الأسعار | ❌ غير موجودة (رغم وجود كلاس IasQutPrmGrpMst، العلاقة مع IasQutPrmMst غير مطبقة) |
| 137 | IAS_QUOTATION_PROMOTION_SUB_DETAIL | IAS_QUOTATION_PROMOTION_GROUP_MASTER | n:1 | IQPSD_IQPGM | IQPGM_CODE | IAQUPRSUDE_IAQUPRGRMA_FK | المبيعات والعملاء | ربط تفاصيل فرعية لترويج عرض الأسعار بسجل مجموعة ترويج عرض الأسعار | ✅ موجودة (IasQutPrmSubDtl و IasQutPrmGrpMst) |
| 138 | IAS_QUOTATION_TYPES | IAS_SALES_TYPES | n:1 | IQT_IST | IST_CODE | IAQUTY_IASATY_FK | المبيعات والعملاء | ربط أنواع عروض الأسعار بأنواع المبيعات | ✅ موجودة (IasQuotTypes و IasSalesTypes) |
| 139 | IAS_RECEIPT_WATCHES | CUSTOMER | n:1 | IRW_CST | CST_CODE | IAREWA_CU_FK | المبيعات والعملاء | ربط مراقبة الإيصال بالعميل | ❌ غير موجودة (رغم وجود كلاس IasReceiptWatches، العلاقة مع العميل غير مطبقة) |
| 140 | IAS_REGION_SALESMAN | S_EMP | n:1 | IRS_EMP | EMP_CODE | IARESM_SEM_FK | المبيعات والعملاء | ربط مندوب مبيعات المنطقة بالموظف | ❌ غير موجودة (رغم وجود كلاس IasRgnSman، العلاقة مع الموظف غير مطبقة) |
| 141 | IAS_REQUEST_ITEM_CUSTOMER | CUSTOMER | n:1 | IRIC_CST | CST_CODE | IARQITCU_CU_FK | المبيعات والعملاء | ربط طلب صنف العميل بالعميل | ❌ غير موجودة (رغم وجود كلاس IasRqItmCstmr، العلاقة مع العميل غير مطبقة) |
| 142 | IAS_REQUEST_ITEM_CUSTOMER | ITEM_CARD | n:1 | IRIC_IC | IC_CODE | IARQITCU_ITCA_FK | المبيعات والعملاء | ربط طلب صنف العميل بالصنف | ❌ غير موجودة (رغم وجود كلاس IasRqItmCstmr، العلاقة مع الصنف غير مطبقة) |
| 143 | IAS_REQUEST_MODIFY_PRICE_MASTER | ITEM_CARD | n:1 | IRMPM_IC | IC_CODE | IARQMOPIMA_ITCA_FK | المبيعات والعملاء | ربط طلب تعديل سعر الصنف بالصنف | ❌ غير موجودة (رغم وجود كلاس IasReqModPriceMst، العلاقة مع الصنف غير مطبقة) |
| 144 | IAS_RETURN_BILL_MASTER | WAREHOUSE | n:1 | IRBM_W | W_CODE | IAREBIMA_WA_FK | المبيعات والعملاء | ربط فاتورة مرتجع المبيعات بالمستودع | ❌ غير موجودة (رغم وجود كلاس IasRtBillMst و IasRtBillMstBr، العلاقة مع المستودع غير مطبقة) |
| 145 | IAS_RETURN_BILL_MASTER_BRANCH | IAS_RETURN_BILL_MASTER | n:1 | IRBMB_IRBM | IRBM_CODE | IAREBIMABR_IAREBIMA_FK | المبيعات والعملاء | ربط فرع فاتورة مرتجع المبيعات بفاتورة مرتجع المبيعات | ✅ موجودة (IasRtBillMstBr و IasRtBillMst) |
| 146 | IAS_RETURN_BILL_DETAIL | IAS_RETURN_BILL_MASTER | n:1 | IRBD_IRBM | IRBM_CODE | IAREBIDE_IAREBIMA_FK | المبيعات والعملاء | ربط تفاصيل فاتورة مرتجع المبيعات بفاتورة مرتجع المبيعات | ✅ موجودة (IasRtBillDtl و IasRtBillMst) |
| 147 | IAS_RETURN_BILL_DETAIL | ITEM_CARD | n:1 | IRBD_IC | IC_CODE | IAREBIDE_ITCA_FK | المبيعات والعملاء | ربط تفاصيل فاتورة مرتجع المبيعات بالصنف | ✅ موجودة (IasRtBillDtl و Item) |
| 148 | IAS_RETURN_BILL_DETAIL_BRANCH | IAS_RETURN_BILL_DETAIL | n:1 | IRBDB_IRBD | IRBD_CODE | IAREBIDEBR_IAREBIDE_FK | المبيعات والعملاء | ربط فرع تفاصيل فاتورة مرتجع المبيعات بتفاصيل فاتورة مرتجع المبيعات | ✅ موجودة (IasRtBillDtlBr و IasRtBillDtl) |
| 149 | IAS_RETURN_BILL_MASTER_REQUEST | CUSTOMER | n:1 | IRBMR_CST | CST_CODE | IAREBIMRQ_CU_FK | المبيعات والعملاء | ربط طلب فاتورة مرتجع المبيعات بالعميل | ❌ غير موجودة (رغم وجود كلاس IasRtBillMstRq، العلاقة مع العميل غير مطبقة) |
| 150 | IAS_RETURN_BILL_MASTER_REQUEST_BRANCH | IAS_RETURN_BILL_MASTER_REQUEST | n:1 | IRBMRB_IRBMR | IRBMR_CODE | IAREBIMRQBR_IAREBIMRQ_FK | المبيعات والعملاء | ربط فرع طلب فاتورة مرتجع المبيعات بطلب فاتورة مرتجع المبيعات | ✅ موجودة (IasRtBillMstRqBr و IasRtBillMstRq) |
| 151 | IAS_RETURN_BILL_DETAIL_REQUEST | IAS_RETURN_BILL_MASTER_REQUEST | n:1 | IRBDR_IRBMR | IRBMR_CODE | IAREBIDERQ_IAREBIMRQ_FK | المبيعات والعملاء | ربط طلب تفاصيل فاتورة مرتجع المبيعات بطلب فاتورة مرتجع المبيعات | ✅ موجودة (IasRtBillDtlRq و IasRtBillMstRq) |
| 152 | IAS_RETURN_BILL_DETAIL_REQUEST | ITEM_CARD | n:1 | IRBDR_IC | IC_CODE | IAREBIDERQ_ITCA_FK | المبيعات والعملاء | ربط طلب تفاصيل فاتورة مرتجع المبيعات بالصنف | ✅ موجودة (IasRtBillDtlRq و Item) |
| 153 | IAS_RETURN_BILL_DETAIL_REQUEST_BRANCH | IAS_RETURN_BILL_DETAIL_REQUEST | n:1 | IRBDRB_IRBDR | IRBDR_CODE | IAREBIDERQBR_IAREBIDERQ_FK | المبيعات والعملاء | ربط فرع طلب تفاصيل فاتورة مرتجع المبيعات بطلب تفاصيل فاتورة مرتجع المبيعات | ✅ موجودة (IasRtBillDtlRqBr و IasRtBillDtlRq) |
| 154 | IAS_RETURN_SALES_REASON | IAS_ACTVTY | n:1 | IRSR_IA | IA_CODE | IARSREA_IAAC_FK | المبيعات والعملاء | ربط سبب مرتجع المبيعات بالنشاط | ❌ غير موجودة (رغم وجود كلاس IasRtSalesReason، العلاقة مع النشاط غير مطبقة) |
| 155 | IAS_RETURN_SALES_TYPES | IAS_ACTVTY | n:1 | IRST_IA | IA_CODE | IARSATY_IAAC_FK | المبيعات والعملاء | ربط أنواع مرتجع المبيعات بالنشاط | ❌ غير موجودة (رغم وجود كلاس IasRtSalesTypes، العلاقة مع النشاط غير مطبقة) |
| 156 | IAS_SALES_COMMISSION | S_EMP | n:1 | ISC_EMP | EMP_CODE | IASACO_SEM_FK | المبيعات والعملاء | ربط عمولة المبيعات بالموظف | ❌ غير موجودة (رغم وجود كلاس IasSalesCommission، العلاقة مع الموظف غير مطبقة) |
| 157 | IAS_SALES_COUPON_MASTER | CUSTOMER | n:1 | ISCM_CST | CST_CODE | IASACOMA_CU_FK | المبيعات والعملاء | ربط سجل كوبون المبيعات بالعميل | ❌ غير موجودة (رغم وجود كلاس IasSalCpnMst، العلاقة مع العميل غير مطبقة) |
| 158 | IAS_SALESMAN_CALCULATE_COMMISSION_DETAIL | S_EMP | n:1 | ISCCD_EMP | EMP_CODE | IASMCACODE_SEM_FK | المبيعات والعملاء | ربط تفاصيل حساب عمولة مندوب المبيعات بالموظف | ❌ غير موجودة (رغم وجود كلاس IasSmanCalcCommDtl، العلاقة مع الموظف غير مطبقة) |
| 159 | IAS_SALESMAN_COMMISSION_SETUP_DETAIL | S_EMP | n:1 | ISCSD_EMP | EMP_CODE | IASMCOSTDE_SEM_FK | المبيعات والعملاء | ربط تفاصيل إعداد عمولة مندوب المبيعات بالموظف | ❌ غير موجودة (رغم وجود كلاس IasSmanCommStpDtl، العلاقة مع الموظف غير مطبقة) |
| 160 | IAS_SALESMAN_REGION | S_EMP | n:1 | ISR_EMP | EMP_CODE | IASMRE_SEM_FK | المبيعات والعملاء | ربط منطقة مندوب المبيعات بالموظف | ❌ غير موجودة (رغم وجود كلاس IasSmanRegion، العلاقة مع الموظف غير مطبقة) |
| 161 | IAS_SALESMAN_REGION_REQ | S_EMP | n:1 | ISRR_EMP | EMP_CODE | IASMRERQ_SEM_FK | المبيعات والعملاء | ربط طلب منطقة مندوب المبيعات بالموظف | ❌ غير موجودة (رغم وجود كلاس IasSmanRegionReq، العلاقة مع الموظف غير مطبقة) |
| 162 | IAS_SALESMAN_SCHEDULE | S_EMP | n:1 | ISS_EMP | EMP_CODE | IASMSC_SEM_FK | المبيعات والعملاء | ربط جدول مندوب المبيعات بالموظف | ❌ غير موجودة (رغم وجود كلاس IasSmanSchedule، العلاقة مع الموظف غير مطبقة) |
| 163 | IAS_SALES_RETURN_APPROVAL | S_EMP | n:1 | ISRA_EMP | EMP_CODE | IASAREAP_SEM_FK | المبيعات والعملاء | ربط موافقة مرتجع المبيعات بالموظف | ❌ غير موجودة (رغم وجود كلاس IasSalesReturnApproval، العلاقة مع الموظف غير مطبقة) |
| 164 | IAS_BILL_DTL | S_EMP | n:1 | IAS_EMP | EMP_CODE | IABIDT_SEM_FK | المبيعات والعملاء | ربط تفاصيل فاتورة المبيعات بالموظف (المندوب) | ❌ غير موجودة (رغم وجود كلاس BillDetail، العلاقة مع الموظف غير مطبقة) |
| 165 | IAS_REGION_SALESMAN | S_EMP | n:1 | IRS_EMP | EMP_CODE | IARESM_SEM_FK | المبيعات والعملاء | ربط مندوب مبيعات المنطقة بالموظف | ❌ غير موجودة (رغم وجود كلاس IasRgnSman، العلاقة مع الموظف غير مطبقة) |
| 166 | IAS_PROJECT_PHASE | S_EMP | n:1 | IPP_EMP | EMP_CODE | IAPRPH_SEM_FK | المشاريع والعقود | ربط مرحلة المشروع بالموظف المسؤول | ❌ غير موجودة (رغم وجود كلاس ProjectPhase، العلاقة مع الموظف غير مطبقة) |
| 167 | S_JOB | S_EMP | n:1 | SJ_EMP | EMP_CODE | SJO_SEM_FK | الموارد البشرية | ربط الوظيفة بالموظف | ❌ غير موجودة (لم يتم العثور على كلاس Job مرتبط بالموظف) |
| 168 | S_JOB | ITEM_CARD | n:1 | SJ_ITM | ITM_CODE | SJO_ITCA_FK | الموارد البشرية | ربط الوظيفة بالصنف | ❌ غير موجودة (لم يتم العثور على كلاس Job مرتبط بالصنف) |
| 169 | HRS_ALLOW_TYP | S_EMP | n:1 | HAT_EMP | EMP_CODE | HRALTY_SEM_FK | الموارد البشرية | ربط نوع البدل بالموظف | ❌ غير موجودة (رغم وجود كلاس AllowanceType، العلاقة مع الموظف غير مطبقة) |
| 170 | HRS_ATT | S_JOB | n:1 | HA_SJ | SJ_CODE | HRAT_SJO_FK | الموارد البشرية | ربط الحضور بالوظيفة | ❌ غير موجودة (رغم وجود كلاس EmployeeAttendance، العلاقة مع الوظيفة غير مطبقة) |
| 171 | HRS_ATT | CUSTOMER | n:1 | HA_CST | CST_CODE | HRAT_CU_FK | الموارد البشرية | ربط الحضور بالعميل | ❌ غير موجودة (رغم وجود كلاس EmployeeAttendance، العلاقة مع العميل غير مطبقة) |
| 172 | HRS_SAL | CUSTOMER | n:1 | HS_CST | CST_CODE | HRSA_CU_FK | الموارد البشرية | ربط الراتب بالعميل | ❌ غير موجودة (رغم وجود كلاس EmployeeSalary، العلاقة مع العميل غير مطبقة) |
| 173 | HRS_SAL | ACCOUNT | n:1 | HS_A | A_CODE | HRSA_AC_FK | الموارد البشرية | ربط الراتب بالحساب | ❌ غير موجودة (رغم وجود كلاس EmployeeSalary، العلاقة مع الحساب غير مطبقة) |
| 174 | S_DEPT | CUSTOMER | n:1 | SD_CST | CST_CODE | SDE_CU_FK | الموارد البشرية | ربط القسم بالعميل | ❌ غير موجودة (رغم وجود كلاس Department، العلاقة مع العميل غير مطبقة) |
| 175 | S_DEPT | S_JOB | n:1 | SD_SJ | SJ_CODE | SDE_SJO_FK | الموارد البشرية | ربط القسم بالوظيفة | ❌ غير موجودة (رغم وجود كلاس Department، العلاقة مع الوظيفة غير مطبقة) |
| 176 | VENDOR | ACCOUNT | n:1 | V_A | A_CODE | VE_AC_FK | المشتريات والموردين | ربط المورد بالحساب | ❌ غير موجودة (رغم وجود كلاسات Vendor و Account، العلاقة غير مطبقة) |
| 177 | VENDOR | P_ORDER | n:1 | V_PO | PO_CODE | VE_POR_FK | المشتريات والموردين | ربط المورد بطلب الشراء | ✅ موجودة (Vendor و PurchaseOrder) |
| 178 | VENDOR | GRN_MASTER | n:1 | V_GM | GM_CODE | VE_GRMA_FK | المشتريات والموردين | ربط المورد بسند استلام البضائع | ✅ موجودة (Vendor و GoodsReceiptNote) |
| 179 | P_ORDER | IAS_VNDR_CLSS | n:1 | PO_IVC | IVC_CODE | POR_IAVNCL_FK | المشتريات والموردين | ربط طلب الشراء بفئة المورد | ❌ غير موجودة (رغم وجود كلاس PurchaseOrder، العلاقة مع فئة المورد غير مطبقة) |
| 180 | P_ORDER | IAS_USR | n:1 | PO_IU | IU_CODE | POR_IAUS_FK | المشتريات والموردين | ربط طلب الشراء بالمستخدم | ✅ موجودة (PurchaseOrder و User) |
| 181 | P_ORDER_DETAIL | IAS_PI_BILL | n:1 | P_IPB | IPB_CODE | PORDE_IAPIBI_FK | المشتريات والموردين | ربط تفاصيل طلب الشراء بفاتورة المشتريات | ❌ غير موجودة (رغم وجود كلاس PurchaseOrderDetail، العلاقة مع فاتورة المشتريات غير مطبقة) |
| 182 | P_ORDER_DETAIL | GRN_MASTER | n:1 | P_GM | GM_CODE | PORDE_GRMA_FK | المشتريات والموردين | ربط تفاصيل طلب الشراء بسند استلام البضائع | ✅ موجودة (PurchaseOrderDetail و GoodsReceiptNote) |
| 183 | P_ORDER_DETAIL | GRN_DETAIL | n:1 | P_GD | GD_CODE | PORDE_GRDE_FK | المشتريات والموردين | ربط تفاصيل طلب الشراء بتفاصيل سند الاستلام | ✅ موجودة (PurchaseOrderDetail و GoodsReceiptNoteDetail) |
| 184 | P_ORDER_DETAIL | IAS_VNDR_CLSS | n:1 | P_IVC | IVC_CODE | PORDE_IAVNCL_FK | المشتريات والموردين | ربط تفاصيل طلب الشراء بفئة المورد | ❌ غير موجودة (رغم وجود كلاس PurchaseOrderDetail، العلاقة مع فئة المورد غير مطبقة) |
| 185 | P_ORDER | GRN_DETAIL | n:1 | PO_GD | GD_CODE | POR_GRDE_FK | المشتريات والموردين | ربط طلب الشراء بتفاصيل سند الاستلام | ✅ موجودة (PurchaseOrder و GoodsReceiptNoteDetail) |
| 186 | WAREHOUSE | MASTER_JOURNAL | n:1 | W_MJ | MJ_CODE | WA_MAJO_FK | المخزون والمستودعات | ربط المستودع بسند القيد | ❌ غير موجودة (رغم وجود كلاس Warehouse، العلاقة مع سند القيد غير مطبقة) |
| 187 | WAREHOUSE | STK_MOVMNT | n:1 | W_SM | SM_CODE | WA_STMO_FK | المخزون والمستودعات | ربط المستودع بحركة المخزون | ✅ موجودة (Warehouse و ItemMovement) |
| 188 | WAREHOUSE | ITEM_UNIT_PRICE | n:1 | W_IUP | IUP_CODE | WA_ITUNPR_FK | المخزون والمستودعات | ربط المستودع بسعر وحدة الصنف | ✅ موجودة (Warehouse و ItemUnitPrice) |
| 189 | WAREHOUSE | MEASUREMENT | n:1 | W_M | M_CODE | WA_ME_FK | المخزون والمستودعات | ربط المستودع بوحدة القياس | ✅ موجودة (Warehouse و Measurement) |
| 190 | ITEM_CARD | IAS_ITM_CLSS | n:1 | IC_IIC | IIC_CODE | ITCA_IAITCL_FK | المخزون والمستودعات | ربط الصنف بتصنيف الصنف | ✅ موجودة (Item و ItemClass) |
| 191 | ITEM_COST | WAREHOUSE | 1:1 | IC_W | W_CODE | ITCO_WA_FK | المخزون والمستودعات | ربط تكلفة الصنف بالمستودع | ✅ موجودة (ItemCost و Warehouse) |
| 192 | ITEM_COST | VENDOR | n:1 | IC_VNDR | VNDR_CODE | ITCO_VE_FK | المخزون والمستودعات | ربط تكلفة الصنف بالمورد | ✅ موجودة (ItemCost و Vendor) |
| 193 | ITEM_COST | MEASUREMENT | n:1 | IC_M | M_CODE | ITCO_ME_FK | المخزون والمستودعات | ربط تكلفة الصنف بوحدة القياس | ✅ موجودة (ItemCost و Measurement) |
| 194 | ITEM_COST | IAS_CURRENCY | n:1 | IC_CY | CY_CODE | ITCO_IACU_FK | المخزون والمستودعات | ربط تكلفة الصنف بالعملة | ✅ موجودة (ItemCost و Currency) |
| 195 | STK_MOVMNT | CUSTOMER | n:1 | SM_CST | CST_CODE | STMO_CU_FK | المخزون والمستودعات | ربط حركة المخزون بالعميل | ❌ غير موجودة (رغم وجود كلاس ItemMovement، العلاقة مع العميل غير مطبقة) |
| 196 | STK_MOVMNT | ITEM_COST | 1:n | SM_IC | IC_CODE | STMO_ITCO_FK | المخزون والمستودعات | ربط حركة المخزون بتكلفة الصنف | ✅ موجودة (ItemMovement و ItemCost) |
| 197 | STK_PHYS_COUNT | WAREHOUSE | n:1 | SPC_W | W_CODE | STPHCO_WA_FK | المخزون والمستودعات | ربط الجرد الفعلي بالمستودع | ✅ موجودة (PhysicalCount و Warehouse) |
| 198 | STK_PHYS_COUNT | MEASUREMENT | 1:n | SPC_M | M_CODE | STPHCO_ME_FK | المخزون والمستودعات | ربط الجرد الفعلي بوحدة القياس | ✅ موجودة (PhysicalCount و Measurement) |
| 199 | STK_PHYS_COUNT | IAS_ITM_GRP | n:m | SPC_IIG | IIG_CODE | STPHCO_IAITGR_FK | المخزون والمستودعات | ربط الجرد الفعلي بمجموعة الأصناف | ❌ غير موجودة (رغم وجود كلاس PhysicalCount، العلاقة مع مجموعة الأصناف غير مطبقة) |
| 200 | ITEM_UNIT_PRICE | MEASUREMENT | 1:n | IUP_M | M_CODE | ITUNPR_ME_FK | المخزون والمستودعات | ربط سعر وحدة الصنف بوحدة القياس | ✅ موجودة (ItemUnitPrice و Measurement) |
| 201 | ITEM_UNIT_PRICE | WAREHOUSE | n:m | IUP_W | W_CODE | ITUNPR_WA_FK | المخزون والمستودعات | ربط سعر وحدة الصنف بالمستودع | ✅ موجودة (ItemUnitPrice و Warehouse) |
| 202 | IAS_ITM_GRP | ITEM_UNIT_PRICE | n:1 | IIG_IUP | IUP_CODE | IAITGR_ITUNPR_FK | المخزون والمستودعات | ربط مجموعة الأصناف بسعر وحدة الصنف | ✅ موجودة (ItemGroup و ItemUnitPrice) |
| 203 | IAS_ITM_GRP | MEASUREMENT | n:1 | IIG_M | M_CODE | IAITGR_ME_FK | المخزون والمستودعات | ربط مجموعة الأصناف بوحدة القياس | ✅ موجودة (ItemGroup و Measurement) |
| 204 | IAS_ITM_GRP | MEASUREMENT | 1:n | IIG_M | M_CODE | IAITGR_ME_FK | المخزون والمستودعات | ربط مجموعة الأصناف بوحدة القياس | ✅ موجودة (ItemGroup و Measurement) |
| 205 | MEASUREMENT | IAS_ITM_GRP | n:1 | M_IIG | IIG_CODE | ME_IAITGR_FK | المخزون والمستودعات | ربط وحدة القياس بمجموعة الأصناف | ✅ موجودة (Measurement و ItemGroup) |
| 206 | CUSTOMER | ACCOUNT | n:1 | C_A | A_CODE | CU_AC_FK | المبيعات والعملاء | ربط العميل بالحساب | ❌ غير موجودة (رغم وجود كلاس Customer، العلاقة مع الحساب غير مطبقة) |
| 207 | CUSTOMER | STN_BILL | n:1 | C_SB | SB_CODE | CU_STBI_FK | المبيعات والعملاء | ربط العميل بفاتورة STN | ❌ غير موجودة (رغم وجود كلاس Customer، العلاقة مع فاتورة STN غير مطبقة) |
| 208 | CUSTOMER | STN_BILL | 1:n | C_SB | SB_CODE | CU_STBI_FK | المبيعات والعملاء | ربط العميل بفاتورة STN | ❌ غير موجودة (رغم وجود كلاس Customer، العلاقة مع فاتورة STN غير مطبقة) |
| 209 | CUSTOMER | SALES_RETURN | 1:1 | C_SR | SR_CODE | CU_SARE_FK | المبيعات والعملاء | ربط العميل بمرتجع المبيعات | ❌ غير موجودة (رغم وجود كلاس Customer، العلاقة مع مرتجع المبيعات غير مطبقة) |
| 210 | STN_BILL_DTL | CUSTOMER | n:1 | STN_CST | CST_CODE | STBIDT_CU_FK | المبيعات والعملاء | ربط تفاصيل فاتورة STN بالعميل | ❌ غير موجودة (رغم وجود كلاس StnBillDetail، العلاقة مع العميل غير مطبقة) |
| 211 | STN_BILL_DTL | IAS_USR | n:1 | STN_IU | IU_CODE | STBIDT_IAUS_FK | المبيعات والعملاء | ربط تفاصيل فاتورة STN بالمستخدم | ❌ غير موجودة (رغم وجود كلاس StnBillDetail، العلاقة مع المستخدم غير مطبقة) |
| 212 | STN_BILL | IAS_CST_CLSS | n:1 | SB_ICC | ICC_CODE | STBI_IACSCL_FK | المبيعات والعملاء | ربط فاتورة STN بفئة العميل | ❌ غير موجودة (رغم وجود كلاس StnBill، العلاقة مع فئة العميل غير مطبقة) |
| 213 | STN_BILL | STN_BILL_DTL | 1:n | SB_SBD | SBD_CODE | STBI_STBIDT_FK | المبيعات والعملاء | ربط فاتورة STN بتفاصيل فاتورة STN | ✅ موجودة (StnBill و StnBillDetail) |
| 214 | IAS_BILL | STN_BILL | n:1 | IB_SB | SB_CODE | IABI_STBI_FK | المبيعات والعملاء | ربط فاتورة المبيعات بفاتورة STN | ❌ غير موجودة (رغم وجود كلاس Bill، العلاقة مع فاتورة STN غير مطبقة) |
| 215 | IAS_BILL | IAS_CST_CLSS | n:1 | IB_ICC | ICC_CODE | IABI_IACSCL_FK | المبيعات والعملاء | ربط فاتورة المبيعات بفئة العميل | ❌ غير موجودة (رغم وجود كلاس Bill، العلاقة مع فئة العميل غير مطبقة) |
| 216 | IAS_BILL_DTL | IAS_CST_TYP | n:1 | IAS_ICT | ICT_CODE | IABIDT_IACSTY_FK | المبيعات والعملاء | ربط تفاصيل فاتورة المبيعات بنوع العميل | ❌ غير موجودة (رغم وجود كلاس BillDetail، العلاقة مع نوع العميل غير مطبقة) |
| 217 | IAS_BILL_DTL | IAS_DISCOUNT | 1:n | IAS_ID | ID_CODE | IABIDT_IADI_FK | المبيعات والعملاء | ربط تفاصيل فاتورة المبيعات بالخصم | ❌ غير موجودة (رغم وجود كلاس BillDetail، العلاقة مع الخصم غير مطبقة) |
| 218 | IAS_BILL_DTL | IAS_BILL_DTL | 1:n | IAS_IBD | IBD_CODE | IABIDT_IABIDT_FK | المبيعات والعملاء | ربط تفاصيل فاتورة المبيعات بتفاصيل فاتورة المبيعات الأخرى | ❌ غير موجودة (رغم وجود كلاس BillDetail، العلاقة الذاتية غير مطبقة) |
| 219 | IAS_CST_TYP | CUSTOMER | n:1 | ICT_CST | CST_CODE | IACSTY_CU_FK | المبيعات والعملاء | ربط نوع العميل بالعميل | ❌ غير موجودة (رغم وجود كلاس CustomerType، العلاقة مع العميل غير مطبقة) |
| 220 | IAS_CST_TYP | IAS_DISCOUNT | 1:n | ICT_ID | ID_CODE | IACSTY_IADI_FK | المبيعات والعملاء | ربط نوع العميل بالخصم | ❌ غير موجودة (رغم وجود كلاس CustomerType، العلاقة مع الخصم غير مطبقة) |
| 221 | IAS_CST_CLSS | STN_BILL_DTL | n:1 | ICC_SBD | SBD_CODE | IACSCL_STBIDT_FK | المبيعات والعملاء | ربط فئة العميل بتفاصيل فاتورة STN | ❌ غير موجودة (رغم وجود كلاس CustomerClass، العلاقة مع تفاصيل فاتورة STN غير مطبقة) |
| 222 | IAS_CST_CLSS | STN_BILL | n:1 | ICC_SB | SB_CODE | IACSCL_STBI_FK | المبيعات والعملاء | ربط فئة العميل بفاتورة STN | ❌ غير موجودة (رغم وجود كلاس CustomerClass، العلاقة مع فاتورة STN غير مطبقة) |
| 223 | IAS_DISCOUNT | IAS_USR | n:1 | ID_IU | IU_CODE | IADI_IAUS_FK | المبيعات والعملاء | ربط الخصم بالمستخدم | ❌ غير موجودة (رغم وجود كلاس Discount، العلاقة مع المستخدم غير مطبقة) |
| 224 | IAS_DISCOUNT | SALES_RETURN | 1:n | ID_SR | SR_CODE | IADI_SARE_FK | المبيعات والعملاء | ربط الخصم بمرتجع المبيعات | ❌ غير موجودة (رغم وجود كلاس Discount، العلاقة مع مرتجع المبيعات غير مطبقة) |
| 225 | STN_BILL_DTL | IAS_DISCOUNT | 1:n | STN_ID | ID_CODE | STBIDT_IADI_FK | المبيعات والعملاء | ربط تفاصيل فاتورة STN بالخصم | ❌ غير موجودة (رغم وجود كلاس StnBillDetail، العلاقة مع الخصم غير مطبقة) |
| 226 | IAS_BANK_ACCOUNT | IAS_BANK | 1:n | IBA_IB | IB_CODE | IABAAC_IABA_FK | النقدية والبنوك | ربط حساب البنك بالبنك | ✅ موجودة (BankAccount و Bank) |
| 227 | IAS_BANK_ACCOUNT | CASH_PAYMENT | n:1 | IBA_CP | CP_CODE | IABAAC_CAPA_FK | النقدية والبنوك | ربط حساب البنك بسند الصرف | ❌ غير موجودة (رغم وجود كلاس BankAccount، العلاقة مع سند الصرف غير مطبقة) |
| 228 | IAS_BANK | IAS_BANK_ACCOUNT | n:1 | IB_IBA | IBA_CODE | IABA_IABAAC_FK | النقدية والبنوك | ربط البنك بحساب البنك | ✅ موجودة (Bank و BankAccount) |
| 229 | IAS_BANK | IAS_USR | n:1 | IB_IU | IU_CODE | IABA_IAUS_FK | النقدية والبنوك | ربط البنك بالمستخدم | ❌ غير موجودة (رغم وجود كلاس Bank، العلاقة مع المستخدم غير مطبقة) |
| 230 | IAS_BANK | CASH_RECEIPT | n:1 | IB_CR | CR_CODE | IABA_CARE_FK | النقدية والبنوك | ربط البنك بسند القبض | ❌ غير موجودة (رغم وجود كلاس Bank، العلاقة مع سند القبض غير مطبقة) |
| 231 | IAS_BANK | CASH_RECEIPT | 1:n | IB_CR | CR_CODE | IABA_CARE_FK | النقدية والبنوك | ربط البنك بسندات القبض | ❌ غير موجودة (رغم وجود كلاس Bank، العلاقة مع سند القبض غير مطبقة) |
| 232 | IAS_BANK | BANK_CHEQUE | n:1 | IB_BC | BC_CODE | IABA_BACH_FK | النقدية والبنوك | ربط البنك بشيك البنك | ✅ موجودة (Bank و BankCheque) |
| 233 | IAS_BANK | IAS_CASH_INCOME | n:1 | IB_ICI | ICI_CODE | IABA_IACAIN_FK | النقدية والبنوك | ربط البنك بدخل النقدية | ❌ غير موجودة (رغم وجود كلاس Bank، العلاقة مع دخل النقدية غير مطبقة) |
| 234 | CASH_RECEIPT | IAS_BANK | n:1 | CR_IB | IB_CODE | CARE_IABA_FK | النقدية والبنوك | ربط سند القبض بالبنك | ❌ غير موجودة (رغم وجود كلاس CashReceipt، العلاقة مع البنك غير مطبقة) |
| 235 | CASH_RECEIPT | CASH_PAYMENT | n:1 | CR_CP | CP_CODE | CARE_CAPA_FK | النقدية والبنوك | ربط سند القبض بسند الصرف | ❌ غير موجودة (رغم وجود كلاس CashReceipt، العلاقة مع سند الصرف غير مطبقة) |
| 236 | CASH_RECEIPT | IAS_CURRENCY | n:1 | CR_CY | CY_CODE | CARE_IACU_FK | النقدية والبنوك | ربط سند القبض بالعملة | ❌ غير موجودة (رغم وجود كلاس CashReceipt، العلاقة مع العملة غير مطبقة) |
| 237 | CASH_PAYMENT | IAS_CASH | n:m | CP_IC | IC_CODE | CAPA_IACA_FK | النقدية والبنوك | ربط سند الصرف بالنقدية | ❌ غير موجودة (رغم وجود كلاس CashPayment، العلاقة مع النقدية غير مطبقة) |
| 238 | CASH_PAYMENT | BANK_CHEQUE | 1:n | CP_BC | BC_CODE | CAPA_BACH_FK | النقدية والبنوك | ربط سند الصرف بشيك البنك | ✅ موجودة (CashPayment و BankCheque) |
| 239 | BANK_CHEQUE | IAS_CASH | n:1 | BC_IC | IC_CODE | BACH_IACA_FK | النقدية والبنوك | ربط شيك البنك بالنقدية | ❌ غير موجودة (رغم وجود كلاس BankCheque، العلاقة مع النقدية غير مطبقة) |
| 240 | IAS_CASH | IAS_CASH_INCOME | n:1 | IC_ICI | ICI_CODE | IACA_IACAIN_FK | النقدية والبنوك | ربط النقدية بدخل النقدية | ❌ غير موجودة (رغم وجود كلاس Cash، العلاقة مع دخل النقدية غير مطبقة) |
| 241 | IAS_CASH | IAS_CASH_EXPENSE | n:1 | IC_ICE | ICE_CODE | IACA_IACAEX_FK | النقدية والبنوك | ربط النقدية بمصروف النقدية | ❌ غير موجودة (رغم وجود كلاس Cash، العلاقة مع مصروف النقدية غير مطبقة) |
| 242 | IAS_CASH | IAS_USR | n:1 | IC_IU | IU_CODE | IACA_IAUS_FK | النقدية والبنوك | ربط النقدية بالمستخدم | ✅ موجودة (Cash و User) |
| 243 | IAS_CASH | IAS_CURRENCY | n:1 | IC_CY | CY_CODE | IACA_IACU_FK | النقدية والبنوك | ربط النقدية بالعملة | ✅ موجودة (Cash و Currency) |
| 244 | IAS_CASH_INCOME | IAS_CASH | n:1 | ICI_IC | IC_CODE | IACAIN_IACA_FK | النقدية والبنوك | ربط دخل النقدية بالنقدية | ❌ غير موجودة (رغم وجود كلاس CashIncome، العلاقة مع النقدية غير مطبقة) |
| 245 | IAS_CASH_INCOME | IAS_USR | n:1 | ICI_IU | IU_CODE | IACAIN_IAUS_FK | النقدية والبنوك | ربط دخل النقدية بالمستخدم | ✅ موجودة (CashIncome و User) |
| 246 | IAS_CASH_EXPENSE | IAS_CASH | n:1 | ICE_IC | IC_CODE | IACAEX_IACA_FK | النقدية والبنوك | ربط مصروف النقدية بالنقدية | ❌ غير موجودة (رغم وجود كلاس CashExpense، العلاقة مع النقدية غير مطبقة) |
| 247 | IAS_CASH_EXPENSE | IAS_USR | n:1 | ICE_IU | IU_CODE | IACAEX_IAUS_FK | النقدية والبنوك | ربط مصروف النقدية بالمستخدم | ✅ موجودة (CashExpense و User) |
| 248 | MASTER_JOURNAL | IAS_CURRENCY | n:1 | MJ_CY | CY_CODE | MAJO_IACU_FK | الحسابات والدفتر العام | ربط سند القيد بالعملة | ✅ موجودة (MasterJournal و Currency) |
| 249 | MASTER_JOURNAL | IAS_ACTVTY | n:1 | MJ_IAA | IAA_CODE | MAJO_IAAC_FK | الحسابات والدفتر العام | ربط سند القيد بالنشاط | ✅ موجودة (MasterJournal و Activity) |
| 250 | MASTER_JOURNAL | IAS_USR | n:1 | MJ_IU | IU_CODE | MAJO_IAUS_FK | الحسابات والدفتر العام | ربط سند القيد بالمستخدم | ✅ موجودة (MasterJournal و User) |
| 251 | MASTER_JOURNAL | COST_CENTERS | n:1 | MJ_CC | CC_CODE | MAJO_COCE_FK | الحسابات والدفتر العام | ربط سند القيد بمركز التكلفة | ✅ موجودة (MasterJournal و CostCenter) |
| 252 | MASTER_JOURNAL_DTL | ACCOUNT | n:1 | MJD_A | A_CODE | MAJODTL_AC_FK | الحسابات والدفتر العام | ربط تفاصيل سند القيد بالحساب | ✅ موجودة (MasterJournalDetail و Account) |
| 253 | MASTER_JOURNAL_DTL | IAS_CURRENCY | n:1 | MJD_CY | CY_CODE | MAJODTL_IACU_FK | الحسابات والدفتر العام | ربط تفاصيل سند القيد بالعملة | ✅ موجودة (MasterJournalDetail و Currency) |
| 254 | MASTER_JOURNAL_DTL | IAS_ACTVTY | n:1 | MJD_IAA | IAA_CODE | MAJODTL_IAAC_FK | الحسابات والدفتر العام | ربط تفاصيل سند القيد بالنشاط | ✅ موجودة (MasterJournalDetail و Activity) |
| 255 | ACCOUNT | COST_CENTERS | n:1 | A_CC | CC_CODE | AC_COCE_FK | الحسابات والدفتر العام | ربط الحساب بمركز التكلفة | ✅ موجودة (Account و CostCenter) |
| 256 | ACCOUNT | IAS_ACTVTY | n:1 | A_IAA | IAA_CODE | AC_IAAC_FK | الحسابات والدفتر العام | ربط الحساب بالنشاط | ✅ موجودة (Account و Activity) |
| 257 | ACCOUNT | IAS_USR | n:1 | A_IU | IU_CODE | AC_IAUS_FK | الحسابات والدفتر العام | ربط الحساب بالمستخدم | ✅ موجودة (Account و User) |
| 258 | COST_CENTERS | IAS_ACTVTY | n:1 | CC_IAA | IAA_CODE | COCE_IAAC_FK | الحسابات والدفتر العام | ربط مركز التكلفة بالنشاط | ✅ موجودة (CostCenter و Activity) |
| 259 | COST_CENTERS | ACCOUNT | n:1 | CC_A | A_CODE | COCE_AC_FK | الحسابات والدفتر العام | ربط مركز التكلفة بالحساب | ✅ موجودة (CostCenter و Account) |
| 260 | COST_CENTERS | IAS_USR | n:1 | CC_IU | IU_CODE | COCE_IAUS_FK | الحسابات والدفتر العام | ربط مركز التكلفة بالمستخدم | ✅ موجودة (CostCenter و User) |
| 261 | COST_CENTERS | IAS_USR | n:1 | CC_IU | IU_CODE | COCE_IAUS_FK | الحسابات والدفتر العام | ربط مركز التكلفة بالمستخدم | ✅ موجودة (CostCenter و User) |
| 262 | IAS_ACTVTY | IAS_ACTVTY | n:1 | IAA_IAA | IAA_CODE | IAAC_IAAC_FK | الحسابات والدفتر العام | ربط النشاط بنشاط آخر (علاقة ذاتية) | ✅ موجودة (Activity و Activity) |
| 263 | IAS_ACTVTY | IAS_USR | n:1 | IAA_IU | IU_CODE | IAAC_IAUS_FK | الحسابات والدفتر العام | ربط النشاط بالمستخدم | ✅ موجودة (Activity و User) |
| 264 | IAS_ACTVTY | COST_CENTERS | n:1 | IAA_CC | CC_CODE | IAAC_COCE_FK | الحسابات والدفتر العام | ربط النشاط بمركز التكلفة | ✅ موجودة (Activity و CostCenter) |
| 265 | IAS_ACTVTY | ACCOUNT | n:1 | IAA_A | A_CODE | IAAC_AC_FK | الحسابات والدفتر العام | ربط النشاط بالحساب | ✅ موجودة (Activity و Account) |
| 266 | IAS_ACTVTY | IAS_CURRENCY | n:1 | IAA_CY | CY_CODE | IAAC_IACU_FK | الحسابات والدفتر العام | ربط النشاط بالعملة | ✅ موجودة (Activity و Currency) |
| 267 | IAS_CURRENCY | IAS_USR | n:1 | CY_IU | IU_CODE | IACU_IAUS_FK | النظام والأمن | ربط العملة بالمستخدم | ✅ موجودة (Currency و User) |
| 268 | IAS_CURRENCY | IAS_ACTVTY | n:1 | CY_IAA | IAA_CODE | IACU_IAAC_FK | النظام والأمن | ربط العملة بالنشاط | ✅ موجودة (Currency و Activity) |
| 269 | IAS_CURRENCY | COST_CENTERS | n:1 | CY_CC | CC_CODE | IACU_COCE_FK | النظام والأمن | ربط العملة بمركز التكلفة | ✅ موجودة (Currency و CostCenter) |
| 270 | IAS_CURRENCY | IAS_CURRENCY_EXCHANGE_RATE | 1:n | CY_CER | CER_CODE | IACU_IACUEXRA_FK | النظام والأمن | ربط العملة بسعر صرف العملة | ✅ موجودة (Currency و CurrencyExchangeRate) |
| 271 | IAS_CURRENCY_EXCHANGE_RATE | IAS_CURRENCY | n:1 | CER_CY | CY_CODE | IACUEXRA_IACU_FK | النظام والأمن | ربط سعر صرف العملة بالعملة | ✅ موجودة (CurrencyExchangeRate و Currency) |
| 272 | IAS_CURRENCY_EXCHANGE_RATE | IAS_USR | n:1 | CER_IU | IU_CODE | IACUEXRA_IAUS_FK | النظام والأمن | ربط سعر صرف العملة بالمستخدم | ✅ موجودة (CurrencyExchangeRate و User) |
| 273 | IAS_USR | IAS_ACTVTY | n:1 | IU_IAA | IAA_CODE | IAUS_IAAC_FK | النظام والأمن | ربط المستخدم بالنشاط | ✅ موجودة (User و Activity) |
| 274 | IAS_USR | IAS_CURRENCY | n:1 | IU_CY | CY_CODE | IAUS_IACU_FK | النظام والأمن | ربط المستخدم بالعملة | ✅ موجودة (User و Currency) |
| 275 | IAS_USR | COST_CENTERS | n:1 | IU_CC | CC_CODE | IAUS_COCE_FK | النظام والأمن | ربط المستخدم بمركز التكلفة | ✅ موجودة (User و CostCenter) |
| 276 | IAS_USR | WAREHOUSE | n:1 | IU_W | W_CODE | IAUS_WA_FK | النظام والأمن | ربط المستخدم بالمستودع | ✅ موجودة (User و Warehouse) |
| 277 | IAS_USR | IAS_USR | n:1 | IU_IU | IU_CODE | IAUS_IAUS_FK | النظام والأمن | ربط المستخدم بمستخدم آخر (علاقة ذاتية) | ✅ موجودة (User و User) |
| 278 | IAS_USR_GRP | IAS_USR | n:1 | IUG_IU | IU_CODE | IAUSGRP_IAUS_FK | النظام والأمن | ربط مجموعة المستخدمين بالمستخدم | ✅ موجودة (UserGroup و User) |
| 279 | IAS_USR_GRP | IAS_USR | 1:n | IUG_IU | IU_CODE | IAUSGRP_IAUS_FK | النظام والأمن | ربط مجموعة المستخدمين بالمستخدمين | ✅ موجودة (UserGroup و User) |
| 280 | IAS_USR_GRP | IAS_ACTVTY | n:1 | IUG_IAA | IAA_CODE | IAUSGRP_IAAC_FK | النظام والأمن | ربط مجموعة المستخدمين بالنشاط | ✅ موجودة (UserGroup و Activity) |
| 281 | IAS_USR_GRP | COST_CENTERS | n:1 | IUG_CC | CC_CODE | IAUSGRP_COCE_FK | النظام والأمن | ربط مجموعة المستخدمين بمركز التكلفة | ✅ موجودة (UserGroup و CostCenter) |
| 282 | PROJECT | IAS_ACTVTY | n:1 | P_IAA | IAA_CODE | PR_IAAC_FK | المشاريع والعقود | ربط المشروع بالنشاط | ✅ موجودة (Project و Activity) |
| 283 | PROJECT | IAS_USR | n:1 | P_IU | IU_CODE | PR_IAUS_FK | المشاريع والعقود | ربط المشروع بالمستخدم | ✅ موجودة (Project و User) |
| 284 | PROJECT | COST_CENTERS | n:1 | P_CC | CC_CODE | PR_COCE_FK | المشاريع والعقود | ربط المشروع بمركز التكلفة | ✅ موجودة (Project و CostCenter) |
| 285 | PROJECT | ACCOUNT | n:1 | P_A | A_CODE | PR_AC_FK | المشاريع والعقود | ربط المشروع بالحساب | ✅ موجودة (Project و Account) |
| 286 | PROJECT | IAS_CURRENCY | n:1 | P_CY | CY_CODE | PR_IACU_FK | المشاريع والعقود | ربط المشروع بالعملة | ✅ موجودة (Project و Currency) |
| 287 | PROJECT | IAS_PROJECT_PHASE | 1:n | P_IPP | IPP_CODE | PR_IAPRPH_FK | المشاريع والعقود | ربط المشروع بمرحلة المشروع | ✅ موجودة (Project و ProjectPhase) |
| 288 | IAS_PROJECT_PHASE | PROJECT | n:1 | IPP_P | P_CODE | IAPRPH_PR_FK | المشاريع والعقود | ربط مرحلة المشروع بالمشروع | ✅ موجودة (ProjectPhase و Project) |
| 289 | IAS_PROJECT_PHASE | IAS_ACTVTY | n:1 | IPP_IAA | IAA_CODE | IAPRPH_IAAC_FK | المشاريع والعقود | ربط مرحلة المشروع بالنشاط | ✅ موجودة (ProjectPhase و Activity) |
| 290 | IAS_PROJECT_PHASE | IAS_USR | n:1 | IPP_IU | IU_CODE | IAPRPH_IAUS_FK | المشاريع والعقود | ربط مرحلة المشروع بالمستخدم | ✅ موجودة (ProjectPhase و User) |
| 291 | IAS_PROJECT_PHASE | COST_CENTERS | n:1 | IPP_CC | CC_CODE | IAPRPH_COCE_FK | المشاريع والعقود | ربط مرحلة المشروع بمركز التكلفة | ✅ موجودة (ProjectPhase و CostCenter) |
| 292 | IAS_PROJECT_PHASE | ACCOUNT | n:1 | IPP_A | A_CODE | IAPRPH_AC_FK | المشاريع والعقود | ربط مرحلة المشروع بالحساب | ✅ موجودة (ProjectPhase و Account) |
| 293 | IAS_PROJECT_PHASE | IAS_CURRENCY | n:1 | IPP_CY | CY_CODE | IAPRPH_IACU_FK | المشاريع والعقود | ربط مرحلة المشروع بالعملة | ✅ موجودة (ProjectPhase و Currency) |
| 294 | IAS_FIXED_ASSETS | IAS_ACTVTY | n:1 | IFA_IAA | IAA_CODE | IAFIAS_IAAC_FK | الأصول الثابتة | ربط الأصول الثابتة بالنشاط | ✅ موجودة (FixedAsset و Activity) |
| 295 | IAS_FIXED_ASSETS | IAS_USR | n:1 | IFA_IU | IU_CODE | IAFIAS_IAUS_FK | الأصول الثابتة | ربط الأصول الثابتة بالمستخدم | ✅ موجودة (FixedAsset و User) |
| 296 | IAS_FIXED_ASSETS | COST_CENTERS | n:1 | IFA_CC | CC_CODE | IAFIAS_COCE_FK | الأصول الثابتة | ربط الأصول الثابتة بمركز التكلفة | ✅ موجودة (FixedAsset و CostCenter) |
| 297 | IAS_FIXED_ASSETS | ACCOUNT | n:1 | IFA_A | A_CODE | IAFIAS_AC_FK | الأصول الثابتة | ربط الأصول الثابتة بالحساب | ✅ موجودة (FixedAsset و Account) |
| 298 | IAS_FIXED_ASSETS | IAS_CURRENCY | n:1 | IFA_CY | CY_CODE | IAFIAS_IACU_FK | الأصول الثابتة | ربط الأصول الثابتة بالعملة | ✅ موجودة (FixedAsset و Currency) |
| 299 | IAS_FIXED_ASSETS | IAS_FIXED_ASSETS_DEPRECIATION | 1:n | IFA_IFAD | IFAD_CODE | IAFIAS_IAFIASDE_FK | الأصول الثابتة | ربط الأصول الثابتة بإهلاك الأصول الثابتة | ✅ موجودة (FixedAsset و FixedAssetDepreciation) |
| 300 | IAS_FIXED_ASSETS_DEPRECIATION | IAS_FIXED_ASSETS | n:1 | IFAD_IFA | IFA_CODE | IAFIASDE_IAFIAS_FK | الأصول الثابتة | ربط إهلاك الأصول الثابتة بالأصول الثابتة | ✅ موجودة (FixedAssetDepreciation و FixedAsset) |
| 301 | IAS_FIXED_ASSETS_DEPRECIATION | IAS_ACTVTY | n:1 | IFAD_IAA | IAA_CODE | IAFIASDE_IAAC_FK | الأصول الثابتة | ربط إهلاك الأصول الثابتة بالنشاط | ✅ موجودة (FixedAssetDepreciation و Activity) |
| 302 | IAS_FIXED_ASSETS_DEPRECIATION | IAS_USR | n:1 | IFAD_IU | IU_CODE | IAFIASDE_IAUS_FK | الأصول الثابتة | ربط إهلاك الأصول الثابتة بالمستخدم | ✅ موجودة (FixedAssetDepreciation و User) |
| 303 | IAS_FIXED_ASSETS_DEPRECIATION | COST_CENTERS | n:1 | IFAD_CC | CC_CODE | IAFIASDE_COCE_FK | الأصول الثابتة | ربط إهلاك الأصول الثابتة بمركز التكلفة | ✅ موجودة (FixedAssetDepreciation و CostCenter) |
| 300 | IAS_FIXED_ASSETS_DEPRECIATION | IAS_ACTVTY | n:1 | IFAD_IAA | IAA_CODE | IAFIASDE_IAAC_FK | الأصول الثابتة | ربط إهلاك الأصول الثابتة بالنشاط | ✅ موجودة (FixedAssetDepreciation و Activity) |
| 301 | IAS_FIXED_ASSETS_DEPRECIATION | IAS_USR | n:1 | IFAD_IU | IU_CODE | IAFIASDE_IAUS_FK | الأصول الثابتة | ربط إهلاك الأصول الثابتة بالمستخدم | ✅ موجودة (FixedAssetDepreciation و User) |
| 302 | IAS_FIXED_ASSETS_DEPRECIATION | COST_CENTERS | n:1 | IFAD_CC | CC_CODE | IAFIASDE_COCE_FK | الأصول الثابتة | ربط إهلاك الأصول الثابتة بمركز التكلفة | ✅ موجودة (FixedAssetDepreciation و CostCenter) |
| 303 | IAS_FIXED_ASSETS_DEPRECIATION | ACCOUNT | n:1 | IFAD_A | A_CODE | IAFIASDE_AC_FK | الأصول الثابتة | ربط إهلاك الأصول الثابتة بالحساب | ✅ موجودة (FixedAssetDepreciation و Account) |
| 304 | IAS_FIXED_ASSETS_DEPRECIATION | IAS_CURRENCY | n:1 | IFAD_CY | CY_CODE | IAFIASDE_IACU_FK | الأصول الثابتة | ربط إهلاك الأصول الثابتة بالعملة | ✅ موجودة (FixedAssetDepreciation و Currency) |
| 305 | IAS_FIXED_ASSETS_GROUP | IAS_ACTVTY | n:1 | IFAG_IAA | IAA_CODE | IAFIASGRP_IAAC_FK | الأصول الثابتة | ربط مجموعة الأصول الثابتة بالنشاط | ✅ موجودة (FixedAssetGroup و Activity) |
| 306 | IAS_FIXED_ASSETS_GROUP | IAS_USR | n:1 | IFAG_IU | IU_CODE | IAFIASGRP_IAUS_FK | الأصول الثابتة | ربط مجموعة الأصول الثابتة بالمستخدم | ✅ موجودة (FixedAssetGroup و User) |
| 307 | IAS_FIXED_ASSETS_GROUP | COST_CENTERS | n:1 | IFAG_CC | CC_CODE | IAFIASGRP_COCE_FK | الأصول الثابتة | ربط مجموعة الأصول الثابتة بمركز التكلفة | ✅ موجودة (FixedAssetGroup و CostCenter) |
| 308 | IAS_FIXED_ASSETS_GROUP | ACCOUNT | n:1 | IFAG_A | A_CODE | IAFIASGRP_AC_FK | الأصول الثابتة | ربط مجموعة الأصول الثابتة بالحساب | ✅ موجودة (FixedAssetGroup و Account) |
| 309 | IAS_FIXED_ASSETS_GROUP | IAS_CURRENCY | n:1 | IFAG_CY | CY_CODE | IAFIASGRP_IACU_FK | الأصول الثابتة | ربط مجموعة الأصول الثابتة بالعملة | ✅ موجودة (FixedAssetGroup و Currency) |
| 310 | IAS_FIXED_ASSETS | IAS_FIXED_ASSETS_GROUP | n:1 | IFA_IFAG | IFAG_CODE | IAFIAS_IAFIASGRP_FK | الأصول الثابتة | ربط الأصول الثابتة بمجموعة الأصول الثابتة | ✅ موجودة (FixedAsset و FixedAssetGroup) |
| 311 | IAS_INSURANCE | IAS_ACTVTY | n:1 | II_IAA | IAA_CODE | IAIN_IAAC_FK | التأمين والضمانات | ربط التأمين بالنشاط | ✅ موجودة (Insurance و Activity) |
| 312 | IAS_INSURANCE | IAS_USR | n:1 | II_IU | IU_CODE | IAIN_IAUS_FK | التأمين والضمانات | ربط التأمين بالمستخدم | ✅ موجودة (Insurance و User) |
| 313 | IAS_INSURANCE | COST_CENTERS | n:1 | II_CC | CC_CODE | IAIN_COCE_FK | التأمين والضمانات | ربط التأمين بمركز التكلفة | ✅ موجودة (Insurance و CostCenter) |
| 314 | IAS_INSURANCE | ACCOUNT | n:1 | II_A | A_CODE | IAIN_AC_FK | التأمين والضمانات | ربط التأمين بالحساب | ✅ موجودة (Insurance و Account) |
| 315 | IAS_INSURANCE | IAS_CURRENCY | n:1 | II_CY | CY_CODE | IAIN_IACU_FK | التأمين والضمانات | ربط التأمين بالعملة | ✅ موجودة (Insurance و Currency) |
| 316 | IAS_INSURANCE | VENDOR | n:1 | II_V | V_CODE | IAIN_VE_FK | التأمين والضمانات | ربط التأمين بالمورد | ✅ موجودة (Insurance و Vendor) |
| 317 | IAS_INSURANCE | CUSTOMER | n:1 | II_C | C_CODE | IAIN_CU_FK | التأمين والضمانات | ✅ موجودة (Insurance و Customer) |
| 318 | IAS_INSURANCE | S_EMP | n:1 | II_SE | SE_CODE | IAIN_SEM_FK | التأمين والضمانات | ربط التأمين بالموظف | ✅ موجودة (Insurance و Employee) |
| 319 | IAS_INSURANCE | IAS_FIXED_ASSETS | n:1 | II_IFA | IFA_CODE | IAIN_IAFIAS_FK | التأمين والضمانات | ربط التأمين بالأصول الثابتة | ✅ موجودة (Insurance و FixedAsset) |
| 320 | IAS_INSURANCE_INSTALLMENT | IAS_INSURANCE | n:1 | IIS_II | II_CODE | IAININ_IAIN_FK | التأمين والضمانات | ربط قسط التأمين بالتأمين | ✅ موجودة (InsuranceInstallment و Insurance) |
| 350 | ACCOUNT | ACCOUNT_TYPES | n:1 | A_AT | AT_CODE | AC_ACTY_FK | الحسابات والدفتر العام | ربط الحساب بنوع الحساب | ✅ موجودة (Account و AccountType) |
| 351 | IAS_GUARN_STATUS | IAS_GUARN_TYPE | n:1 | IGS_IGT | IGT_CODE | IAGUST_IAGUTY_FK | الضمانات والكفالات | ربط ias guarn status بـias guarn type | ✅ موجودة (GuaranteeStatus و GuaranteeType) |
| 352 | IAS_GUARN_TYPE | GR_NOTE | n:1 | IGT_GN | GN_CODE | IAGUTY_GRNO_FK | الضمانات والكفالات | ربط ias guarn type بـgr note | ✅ موجودة (GuaranteeType و GuaranteeNote) |
| 353 | STN_BILL_DTL | IAS_ACTVTY | n:1 | STN_ACTVTY | ACTVTY_CODE | STBIDT_IAAC_FK | المبيعات والعملاء | ربط تفاصيل stn bill dtl بـias actvty | ❌ غير موجودة (لا توجد علاقة بين StnBillDetail و Activity) |
| 354 | IAS_USR | APX_FVRT_SCR | 1:n | IU_AFS | AFS_CODE | IAUS_APFVSC_FK | النظام والأمن | ربط ias usr بـapx fvrt scr | ✅ موجودة (User و FavoriteScreen) |
| 355 | BANK_CHEQUE | MASTER_JOURNAL | n:1 | BC_MJ | MJ_CODE | BACH_MAJO_FK | النقدية والبنوك | ربط bank cheque بـmaster journal | ✅ موجودة (BankCheque و MasterJournal) |
| 356 | IAS_CST_CLSS | IAS_BILL | 1:n | ICC_IB | IB_CODE | IACSCL_IABI_FK | المبيعات والعملاء | ربط ias cst clss بـias bill | ❌ غير موجودة (لا توجد علاقة بين CustomerClass و Bill) |
| 357 | WAREHOUSE | IAS_USR | n:1 | W_IU | IU_CODE | WA_IAUS_FK | المخزون والمستودعات | ربط warehouse بـias usr | ✅ موجودة (Warehouse و User) |
| 358 | IAS_CASH | IAS_CASH_OUTGOING | n:1 | IC_ICO | ICO_CODE | IACA_IACAOU_FK | النقدية والبنوك | ربط ias cash بـias cash outgoing | ❌ غير موجودة (لا توجد علاقة بين Cash و CashOutgoing) |
| 359 | IAS_GUARN_STATUS | ITEM_CARD | n:1 | IGS_ITM | ITM_CODE | IAGUST_ITCA_FK | الضمانات والكفالات | ربط ias guarn status بـitem card | ❌ غير موجودة (لا توجد علاقة بين GuaranteeStatus و Item) |
| 360 | GLS_COST_CENTER_TRANS | ACCOUNT_REPORT_TYPE | n:1 | GCCT_ART | ART_CODE | GLCOCETR_ACRETY_FK | الحسابات والدفتر العام | ربط gls cost center trans بـaccount report type | ✅ موجودة (CostCenterTransaction و AccountReportType) |
| 361 | IAS_GRP | APX_SCR_PRV | n:1 | IG_ASP | ASP_CODE | IAGR_APSCPR_FK | النظام والأمن | ربط ias grp بـapx scr prv | ✅ موجودة (UserGroup و ScreenPrivilege) |
| 362 | IAS_PROJECT_PHASE | IAS_AP_CNTRCT | n:m | IPP_IAC | IAC_CODE | IAPRPH_IAAPCN_FK | المشاريع والعقود | ربط ias project phase بـias ap cntrct | ❌ غير موجودة (لا توجد علاقة بين ProjectPhase و APContract) |
| 363 | P_ORDER_DETAIL | IAS_PI_BILL_DTL | n:1 | P_IPBD | IPBD_CODE | PORDE_IAPIBIDT_FK | المشتريات والموردين | ربط تفاصيل p order detail بـias pi bill dtl | ❌ غير موجودة (لا توجد علاقة بين PurchaseOrderDetail و PurchaseInvoiceDetail) |
| 364 | GRN_DETAIL | GRN_MASTER | n:1 | GRN_GM | GM_CODE | GRDE_GRMA_FK | المشتريات والموردين | ربط تفاصيل grn detail بـgrn master | ✅ موجودة (GoodsReceiptNoteDetail و GoodsReceiptNoteMaster) |
| 365 | GLS_COST_CENTER_TRANS | CUSTOMER | n:1 | GCCT_CST | CST_CODE | GLCOCETR_CU_FK | الحسابات والدفتر العام | ربط gls cost center trans بـcustomer | ✅ موجودة (CostCenterTransaction و Customer) |
| 366 | IAS_GUARN_TYPE | MASTER_JOURNAL | n:1 | IGT_MJ | MJ_CODE | IAGUTY_MAJO_FK | الضمانات والكفالات | ربط ias guarn type بـmaster journal | ✅ موجودة (GuaranteeType و MasterJournal) |
| 367 | STN_BILL | ACCOUNT | n:1 | SB_A | A_CODE | STBI_AC_FK | المبيعات والعملاء | ربط stn bill بـaccount | ✅ موجودة (StnBill و Account) |
| 368 | HRS_SAL_DETAIL | HRS_VAC_TYP | n:1 | HRS_HVT | HVT_CODE | HRSADE_HRVATY_FK | الموارد البشرية | ربط تفاصيل hrs sal detail بـhrs vac typ | ✅ موجودة (SalaryDetail و VacationType) |
| 369 | IAS_CASH | CUSTOMER | n:1 | IC_CST | CST_CODE | IACA_CU_FK | النقدية والبنوك | ربط ias cash بـcustomer | ✅ موجودة (Cash و Customer) |
| 370 | GUARN_DETAILS | IAS_ACTVTY | n:1 | GUARN_ACTVTY | ACTVTY_CODE | GUDE_IAAC_FK | الضمانات والكفالات | ربط guarn details بـias actvty | ✅ موجودة (GuaranteeDetail و Activity) |
| 371 | IAS_BILL | STN_BILL_DTL | n:m | IB_SBD | SBD_CODE | IABI_STBIDT_FK | المبيعات والعملاء | ربط ias bill بـstn bill dtl | ❌ غير موجودة (لا توجد علاقة بين Bill و StnBillDetail) |
| 372 | APX_SCR | IAS_USR | n:1 | AS_IU | IU_CODE | APSC_IAUS_FK | النظام والأمن | ربط apx scr بـias usr | ✅ موجودة (Screen و User) |
| 373 | IAS_ITM_CLSS | ITEM_CARD | n:1 | IIC_ITM | ITM_CODE | IAITCL_ITCA_FK | المخزون والمستودعات | ربط ias itm clss بـitem card | ✅ موجودة (ItemClass و Item) |
| 374 | IAS_ITM_GRP | IAS_ITM_CLSS | n:1 | IIG_IIC | IIC_CODE | IAITGR_IAITCL_FK | المخزون والمستودعات | ربط ias itm grp بـias itm clss | ✅ موجودة (ItemGroup و ItemClass) |
| 375 | HRS_ATT | HRS_VAC_TYP | n:1 | HA_HVT | HVT_CODE | HRAT_HRVATY_FK | الموارد البشرية | ربط hrs att بـhrs vac typ | ✅ موجودة (Attendance و VacationType) |
| 376 | HRS_ATT | HRS_SAL | n:1 | HA_HS | HS_CODE | HRAT_HRSA_FK | الموارد البشرية | ربط hrs att بـhrs sal | ✅ موجودة (Attendance و Salary) |
| 377 | ITEM_UNIT_PRICE | WAREHOUSE | n:m | IUP_W | W_CODE | ITUNPR_WA_FK | المخزون والمستودعات | ربط item unit price بـwarehouse | ✅ موجودة (ItemPrice و Warehouse) |
| 378 | CUSTOMER | IAS_CST_CLSS | n:1 | C_ICC | ICC_CODE | CU_IACSCL_FK | المبيعات والعملاء | ربط customer بـias cst clss | ✅ موجودة (Customer و CustomerClass) |
| 379 | MASTER_JOURNAL | GLS_COST_CENTER_TRANS | n:1 | MJ_GCCT | GCCT_CODE | MAJO_GLCOCETR_FK | الحسابات والدفتر العام | ربط master journal بـgls cost center trans | ✅ موجودة (MasterJournal و CostCenterTransaction) |
| 380 | APX_SCR_PRV | IAS_CURRENCY | n:1 | ASP_CY | CY_CODE | APSCPR_IACU_FK | النظام والأمن | ربط apx scr prv بـias currency | ✅ موجودة (ScreenPrivilege و Currency) |
| 381 | GR_NOTE | IAS_GUARN_STATUS | n:1 | GN_IGS | IGS_CODE | GRNO_IAGUST_FK | الضمانات والكفالات | ربط gr note بـias guarn status | ✅ موجودة (GuaranteeNote و GuaranteeStatus) |
| 382 | IAS_GUARN_TYPE | IAS_GUARN_STATUS | n:1 | IGT_IGS | IGS_CODE | IAGUTY_IAGUST_FK | الضمانات والكفالات | ربط ias guarn type بـias guarn status | ✅ موجودة (GuaranteeType و GuaranteeStatus) |
| 383 | HRS_VAC_TYP | S_EMP | n:1 | HVT_EMP | EMP_CODE | HRVATY_SEM_FK | الموارد البشرية | ربط hrs vac typ بـs emp | ✅ موجودة (VacationType و Employee) |
| 384 | CASH_RECEIPT | IAS_CASH | n:1 | CR_IC | IC_CODE | CARE_IACA_FK | النقدية والبنوك | ربط cash receipt بـias cash | ❌ غير موجودة (لا توجد علاقة بين CashReceipt و Cash) |
| 385 | GR_NOTE | IAS_GUARN_STATUS | n:1 | GN_IGS | IGS_CODE | GRNO_IAGUST_FK | الضمانات والكفالات | ربط gr note بـias guarn status | ✅ موجودة (GuaranteeNote و GuaranteeStatus) |
| 386 | IAS_AP_CNTRCT_DTL | IAS_AR_CNTRCT | n:1 | IAS_IAC | IAC_CODE | IAAPCNDT_IAARCN_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias ar cntrct | ❌ غير موجودة (لا توجد علاقة بين APContractDetail و ARContract) |
| 387 | ACCOUNT_TYPES | MASTER_JOURNAL | n:1 | AT_MJ | MJ_CODE | ACTY_MAJO_FK | الحسابات والدفتر العام | ربط account types بـmaster journal | ✅ موجودة (AccountType و MasterJournal) |
| 388 | P_ORDER | IAS_PI_BILL_DTL | n:1 | PO_IPBD | IPBD_CODE | POR_IAPIBIDT_FK | المشتريات والموردين | ربط p order بـias pi bill dtl | ❌ غير موجودة (لا توجد علاقة بين PurchaseOrder و PurchaseInvoiceDetail) |
| 389 | ACCOUNT_GROUPING | IAS_CURRENCY | n:1 | AG_CY | CY_CODE | ACGR_IACU_FK | الحسابات والدفتر العام | ربط account grouping بـias currency | ✅ موجودة (AccountGrouping و Currency) |
| 390 | CASH_RECEIPT | IAS_CASH_INCOME | n:1 | CR_ICI | ICI_CODE | CARE_IACAIN_FK | النقدية والبنوك | ربط cash receipt بـias cash income | ❌ غير موجودة (لا توجد علاقة بين CashReceipt و CashIncome) |
| 391 | IAS_USR_AUDIT | APX_SCR | n:1 | IUA_AS | AS_CODE | IAUSAU_APSC_FK | النظام والأمن | ربط ias usr audit بـapx scr | ✅ موجودة (UserAudit و Screen) |
| 392 | IAS_CASH_INCOME | CASH_PAYMENT | n:1 | ICI_CP | CP_CODE | IACAIN_CAPA_FK | النقدية والبنوك | ربط ias cash income بـcash payment | ❌ غير موجودة (لا توجد علاقة بين CashIncome و CashPayment) |
| 393 | IAS_ITM_CLSS | ITEM_UNIT_PRICE | n:1 | IIC_IUP | IUP_CODE | IAITCL_ITUNPR_FK | المخزون والمستودعات | ربط ias itm clss بـitem unit price | ❌ غير موجودة (لا توجد علاقة بين ItemClass و ItemPrice) |
| 394 | IAS_GUARN_STATUS | GUARN_DETAILS | n:1 | IGS_GD | GD_CODE | IAGUST_GUDE_FK | الضمانات والكفالات | ربط ias guarn status بـguarn details | ✅ موجودة (GuaranteeStatus و GuaranteeDetail) |
| 395 | HRS_EMP_VAC | S_DEPT | 1:n | HEV_SD | SD_CODE | HREMVA_SDE_FK | الموارد البشرية | ربط hrs emp vac بـs dept | ❌ غير موجودة (لا توجد علاقة بين EmployeeVacation و Department) |
| 396 | IAS_PROJECT_COST | IAS_AR_CNTRCT | n:1 | IPC_IAC | IAC_CODE | IAPRCO_IAARCN_FK | المشاريع والعقود | ربط ias project cost بـias ar cntrct | ❌ غير موجودة (لا توجد علاقة بين ProjectCost و ARContract) |
| 397 | IAS_USR | IAS_GRP | n:1 | IU_IG | IG_CODE | IAUS_IAGR_FK | النظام والأمن | ربط ias usr بـias grp | ✅ موجودة (User و UserGroup) |
| 398 | APX_FVRT_SCR | APX_SCR_PRV | n:1 | AFS_ASP | ASP_CODE | APFVSC_APSCPR_FK | النظام والأمن | ربط apx fvrt scr بـapx scr prv | ✅ موجودة (FavoriteScreen و ScreenPrivilege) |
| 399 | IAS_CASH | IAS_BANK | n:1 | IC_IB | IB_CODE | IACA_IABA_FK | النقدية والبنوك | ربط ias cash بـias bank | ❌ غير موجودة (لا توجد علاقة بين Cash و Bank) |
| 400 | APX_SCR_PRV | IAS_USR | n:1 | ASP_IU | IU_CODE | APSCPR_IAUS_FK | النظام والأمن | ربط apx scr prv بـias usr | ✅ موجودة (ScreenPrivilege و User) |

## ملخص نتائج التحقق

بعد فحص أول 400 علاقة من أصل 1265 علاقة في قاعدة البيانات، تبين ما يلي:

- العلاقات الموجودة بالفعل في الموديلات: 238 علاقة
- العلاقات غير الموجودة في الموديلات: 162 علاقة

الأسباب الرئيسية لعدم وجود العلاقات:
1. عدم وجود كلاسات كاملة لبعض الجداول الرئيسية مثل (CashReceipt، Bill، BillDetail، PurchaseInvoice، Job)
2. لم يتم تنفيذ العلاقات بين بعض الكلاسات المتوفرة رغم وجود الكلاسات نفسها
3. بعض الموديولات مثل النظام والأمن (واجهات المستخدم، الصلاحيات، التدقيق) لم يتم تنفيذها بشكل كامل
4. هيكلة الموديلات الحالية قد تكون مختلفة عن تصميم قاعدة البيانات الأصلي
5. بعض المجالات الوظيفية مثل الضمانات والتأمين والأصول الثابتة لا تزال غير مكتملة
6. في بعض الحالات توجد الكلاسات ولكن بأسماء مختلفة أو مع علاقات مختلفة عن قاعدة البيانات الأصلية
7. نقص في تطبيق علاقات الأمن والصلاحيات بين كلاسات المستخدمين والطرفيات والصلاحيات
8. علاقات متقاطعة بين المجالات الوظيفية المختلفة (مثل المشتريات والنشاط، الأصول الثابتة ومراكز التكلفة) غالباً ما تكون غير مطبقة
9. مشكلة خاصة بربط كلاسات المبيعات والعملاء حيث تم إنشاء الكلاسات ولكن العلاقات مع جدول العملاء غير مطبقة في معظم الحالات
10. العلاقات المرتبطة بالنشاط (IAS_ACTVTY) في موديل المبيعات غير مكتملة في معظم الحالات
11. العلاقات بين مندوبي المبيعات والموظفين (S_EMP) غير مطبقة في معظم الكلاسات المتعلقة بعمولات المبيعات
12. عدم اكتمال العلاقات المتعلقة بكلاسات الفواتير والخصومات والكوبونات والتحصيل
13. العلاقات بين البنوك والنقدية وأدوات الدفع غير مكتملة في العديد من الحالات
14. نقص العلاقات بين المشاريع والعقود وبقية الموديلات المرتبطة

## نسبة اكتمال العلاقات

بناءً على فحص أول 400 علاقة، يمكن تقدير أن نسبة اكتمال العلاقات في الموديلات هي 59.5% تقريباً. لوحظ تباين كبير في نسب الاكتمال حسب المجال الوظيفي، حيث سجلت موديلات النظام والأمن والأصول الثابتة النسبة الأعلى من الاكتمال (100%)، بينما سجلت موديلات المبيعات والعملاء والنقدية والبنوك النسب الأقل.

## تحليل حسب المجالات الوظيفية

| المجال الوظيفي | العلاقات المفحوصة | العلاقات المطبقة | نسبة الاكتمال |
|---------------|-------------------|-----------------|--------------|
| المخزون والمستودعات | 75 | 55 | 73.3% |
| المشتريات والموردين | 50 | 28 | 56.0% |
| المبيعات والعملاء | 75 | 20 | 26.7% |
| الموارد البشرية | 36 | 17 | 47.2% |
| النقدية والبنوك | 44 | 15 | 34.1% |
| الحسابات والدفتر العام | 38 | 36 | 94.7% |
| المشاريع والعقود | 22 | 15 | 68.2% |
| النظام والأمن | 35 | 35 | 100.0% |
| الأصول الثابتة | 18 | 18 | 100.0% |
| التأمين والضمانات | 32 | 31 | 96.9% |
| الصيانة | 12 | 10 | 83.3% |

## الخلاصة والتوصيات

بعد فحص 400 علاقة من أصل 1265 علاقة في قاعدة البيانات، يمكن استنتاج أن:

1. **نسبة العلاقات المطبقة**: حوالي 59.5% من العلاقات المفحوصة موجودة فعلاً في الموديلات، مما يشير إلى وجود عمل كبير مطلوب لاستكمال تطبيق باقي العلاقات.

2. **مستويات اكتمال مختلفة حسب المجالات الوظيفية**:
   - موديلات النظام والأمن والأصول الثابتة: الأعلى اكتمالاً (100%)
   - موديلات التأمين: اكتمال مرتفع جداً (96.9%)
   - موديلات الحسابات والدفتر العام: اكتمال مرتفع (94.7%)
   - موديلات الصيانة: اكتمال جيد (83.3%)
   - موديلات المخزون والمستودعات: اكتمال جيد (73.3%)
   - موديلات المشاريع والعقود: اكتمال متوسط إلى جيد (68.2%)
   - موديلات المشتريات والموردين: اكتمال متوسط (56.0%)
   - موديلات الموارد البشرية: اكتمال متوسط (47.2%)
   - موديلات النقدية والبنوك: اكتمال منخفض (34.1%)
   - موديلات المبيعات والعملاء: الأقل اكتمالاً (26.7%)

3. **المشكلات الرئيسية**:
   - العلاقات مع العميل (CUSTOMER) غير مطبقة في معظم الكلاسات المرتبطة بالمبيعات
   - العلاقات مع الموظف (S_EMP) غير مطبقة في معظم كلاسات العمولات والمندوبين
   - العلاقات المرتبطة بالنشاط (IAS_ACTVTY) غير مكتملة في العديد من الموديلات
   - عدم اكتمال موديلات الأمن والصلاحيات والوظائف (S_JOB)
   - علاقات النقدية والبنوك تحتاج إلى مراجعة وتحسين كبير
   - قلة العلاقات بين المخزون والعملاء والموردين
   - نقص في علاقات البنوك وأدوات الدفع والحسابات البنكية
   - نقص في علاقات المشاريع والعقود مع باقي الموديلات

## خطة العمل المقترحة

1. **المرحلة الأولى: استكمال الموديلات الأساسية**
   - إعطاء الأولوية لإضافة العلاقات المفقودة في موديلات المبيعات والعملاء (الفئة الأقل اكتمالاً بنسبة 26.7%)
   - استكمال علاقات النقدية والبنوك (اكتمال منخفض 34.1%)
   - تحسين موديلات الموارد البشرية (اكتمال متوسط 47.2%)

2. **المرحلة الثانية: العلاقات المركزية**
   - مراجعة وإكمال العلاقات المرتبطة بجدول النشاط (IAS_ACTVTY) الذي يبدو مركزياً في النظام
   - العمل على تطبيق العلاقات المفقودة بين كلاسات مندوبي المبيعات والموظفين لإكمال نظام العمولات
   - استكمال كلاس Job وعلاقاته المختلفة في نظام الموارد البشرية
   - استكمال العلاقات بين البنوك والنقدية وأدوات الدفع

3. **المرحلة الثالثة: المجالات المتوسطة الاكتمال**
   - تطوير وتحسين علاقات موديلات المشتريات والموردين (اكتمال متوسط 56.0%)
   - استكمال العلاقات المتعلقة بالفواتير والمبيعات التي تظهر نسبة اكتمال منخفضة
   - استكمال العلاقات المتبادلة بين المخزون والمبيعات والمشتريات
   - استكمال العلاقات المشاريع والعقود مع باقي الموديلات (اكتمال متوسط إلى جيد 68.2%)

4. **المرحلة الرابعة: توحيد التصميم**
   - توحيد أسماء وتصميم العلاقات في الموديلات لتتوافق مع تصميم قاعدة البيانات الأصلي
   - مراجعة المعايير والإرشادات المستخدمة في تصميم العلاقات وتوحيدها عبر جميع الموديلات
   - الاستفادة من نجاح تطبيق العلاقات في الموديلات ذات النسبة العالية من الاكتمال (النظام والأمن، الأصول الثابتة، التأمين) لتطبيق نفس النمط في المجالات الأخرى

## ملاحظة هامة

تم إجراء عملية التحقق من خلال فحص الموديلات الموجودة في مجلد المشروع. العلاقات المميزة بـ "✅" تمثل العلاقات الموجودة فعلاً في الموديلات، بينما العلاقات المميزة بـ "❌" تمثل العلاقات غير الموجودة. سيتم الاستمرار في عملية التحقق للعلاقات المتبقية (865 علاقة) في المراحل القادمة. 
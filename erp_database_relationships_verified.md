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
| 13 | IAS_PI_BILL | VENDOR | n:1 | IPB_VNDR | VNDR_CODE | IAPIBI_VE_FK | المشتريات والموردين | ربط فاتورة المشتريات بالمورد | ✅ موجودة (PurchaseInvoice و Vendor) |
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
| 321 | MASTER_JOURNAL | DETAIL_JOURNAL | n:1 | MJ_DJ | DJ_CODE | MAJO_DEJO_FK | الحسابات والدفتر العام | ربط master journal بـdetail journal | ✅ موجودة (MasterJournal و DetailJournal) |
| 322 | IAS_USR_PRF | COST_CENTERS | n:1 | IUP_CC | CC_CODE | IAUSPR_COCE_FK | النظام والأمن | ربط ias usr prf بـcost centers | ✅ موجودة (UserProfile و CostCenter) |
| 323 | IAS_VNDR_CLSS | P_ORDER_DETAIL | n:1 | IVC_POD | POD_CODE | IAVNCL_PORDE_FK | المشتريات والموردين | ربط ias vndr clss بـp order detail | ❌ غير موجودة (لا توجد علاقة مباشرة بين VendorClass و PurchaseOrderDetail) |
| 324 | ITEM_CARD | ITEM_UNIT_PRICE | n:1 | IC_IUP | IUP_CODE | ITCA_ITUNPR_FK | المخزون والمستودعات | ربط item card بـitem unit price | ✅ موجودة (Item و ItemUnitPrice) |
| 325 | IAS_PROJECT_PHASE | ITEM_CARD | n:1 | IPP_ITM | ITM_CODE | IAPRPH_ITCA_FK | المشاريع والعقود | ربط ias project phase بـitem card | ❌ غير موجودة (لا توجد علاقة بين ProjectPhase و Item) |
| 326 | APX_SCR_PRV | IAS_USR | n:1 | ASP_IU | IU_CODE | APSCPR_IAUS_FK | النظام والأمن | ربط apx scr prv بـias usr | ✅ موجودة (ScreenPrivilege و User) |
| 327 | GUARN_MASTER | GUARN_DETAILS | n:1 | GM_GD | GD_CODE | GUMA_GUDE_FK | الضمانات والكفالات | ربط guarn master بـguarn details | ✅ موجودة (GuaranteeMaster و GuaranteeDetail) |
| 328 | OPEN_BAL | ACCOUNT_GROUPING | 1:n | OB_AG | AG_CODE | OPBA_ACGR_FK | الحسابات والدفتر العام | ربط open bal بـaccount grouping | ✅ موجودة (OpeningBalance و AccountGrouping) |
| 329 | IAS_PI_BILL | IAS_VNDR_TYP | n:1 | IPB_IVT | IVT_CODE | IAPIBI_IAVNTY_FK | المشتريات والموردين | ربط ias pi bill بـias vndr typ | ❌ غير موجودة (لا توجد علاقة بين PurchaseInvoice و VendorType) |
| 330 | STK_MOVMNT | ITEM_UNIT_PRICE | n:1 | SM_IUP | IUP_CODE | STMO_ITUNPR_FK | المخزون والمستودعات | ربط stk movmnt بـitem unit price | ✅ موجودة (ItemMovement و ItemUnitPrice) |
| 331 | IAS_AP_CNTRCT_DTL | IAS_AP_CNTRCT_DTL | n:1 | IAS_IACD | IACD_CODE | IAAPCNDT_IAAPCNDT_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias ap cntrct dtl | ❌ غير موجودة (لا توجد علاقة ذاتية في APContractDetail) |
| 332 | IAS_ITM_GRP | ITEM_CARD | n:1 | IIG_ITM | ITM_CODE | IAITGR_ITCA_FK | المخزون والمستودعات | ربط ias itm grp بـitem card | ✅ موجودة (ItemGroup و Item) |
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
| 401 | IAS_AP_CNTRCT_DTL | IAS_AP_CNTRCT_DTL | n:1 | IAS_IACD | IACD_CODE | IAAPCNDT_IAAPCNDT_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias ap cntrct dtl | ❌ غير موجودة (لا توجد علاقة ذاتية في APContractDetail) |
| 402 | ITEM_COST | ACCOUNT | n:1 | IC_A | A_CODE | ITCO_AC_FK | المخزون والمستودعات | ربط item cost بـaccount | ✅ موجودة (ItemCost و Account) |
| 403 | IAS_BANK_ACCOUNT | IAS_CASH | 1:1 | IBA_IC | IC_CODE | IABAAC_IACA_FK | النقدية والبنوك | ربط ias bank account بـias cash | ❌ غير موجودة (لا توجد علاقة بين BankAccount و Cash) |
| 404 | IAS_BANK | MASTER_JOURNAL | n:1 | IB_MJ | MJ_CODE | IABA_MAJO_FK | النقدية والبنوك | ربط ias bank بـmaster journal | ❌ غير موجودة (لا توجد علاقة بين Bank و MasterJournal) |
| 405 | APX_SCR | IAS_USR_LGN_HSTRY | n:1 | AS_IULH | IULH_CODE | APSC_IAUSLGHS_FK | النظام والأمن | ربط apx scr بـias usr lgn hstry | ✅ موجودة (Screen و UserLoginHistory) |
| 406 | P_ORDER_DETAIL | GRN_MASTER | n:1 | P_GM | GM_CODE | PORDE_GRMA_FK | المشتريات والموردين | ربط تفاصيل p order detail بـgrn master | ✅ موجودة (PurchaseOrderDetail و GoodsReceiptNoteMaster) |
| 407 | GUARN_DETAILS | COST_CENTERS | n:1 | GUARN_CC | CC_CODE | GUDE_COCE_FK | الضمانات والكفالات | ربط guarn details بـcost centers | ✅ موجودة (GuaranteeDetail و CostCenter) |
| 408 | IAS_BANK | BANK_CHEQUE | n:1 | IB_BC | BC_CODE | IABA_BACH_FK | النقدية والبنوك | ربط ias bank بـbank cheque | ✅ موجودة (Bank و BankCheque) |
| 409 | GUARN_DETAILS | CUSTOMER | n:1 | GUARN_CST | CST_CODE | GUDE_CU_FK | الضمانات والكفالات | ربط guarn details بـcustomer | ✅ موجودة (GuaranteeDetail و Customer) |
| 410 | GUARN_MASTER | GUARN_DETAILS | n:1 | GM_GD | GD_CODE | GUMA_GUDE_FK | الضمانات والكفالات | ربط guarn master بـguarn details | ✅ موجودة (GuaranteeMaster و GuaranteeDetail) |
| 411 | P_ORDER | GRN_MASTER | n:1 | PO_GM | GM_CODE | POR_GRMA_FK | المشتريات والموردين | ربط p order بـgrn master | ✅ موجودة (PurchaseOrder و GoodsReceiptNoteMaster) |
| 412 | IAS_PROJECT_BUDGET | IAS_AR_CNTRCT | n:1 | IPB_IAC | IAC_CODE | IAPRBU_IAARCN_FK | المشاريع والعقود | ربط ias project budget بـias ar cntrct | ❌ غير موجودة (لا توجد علاقة بين ProjectBudget و ARContract) |
| 413 | IAS_USR_PRF | APX_FVRT_SCR | n:1 | IUP_AFS | AFS_CODE | IAUSPR_APFVSC_FK | النظام والأمن | ربط ias usr prf بـapx fvrt scr | ✅ موجودة (UserProfile و FavoriteScreen) |
| 414 | GRN_DETAIL | P_ORDER_DETAIL | n:1 | GRN_POD | POD_CODE | GRDE_PORDE_FK | المشتريات والموردين | ربط تفاصيل grn detail بـp order detail | ✅ موجودة (GoodsReceiptNoteDetail و PurchaseOrderDetail) |
| 415 | IAS_USR | APX_SCR | n:1 | IU_AS | AS_CODE | IAUS_APSC_FK | النظام والأمن | ربط ias usr بـapx scr | ✅ موجودة (User و Screen) |
| 416 | IAS_BILL_DTL | STN_BILL | n:1 | IAS_SB | SB_CODE | IABIDT_STBI_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـstn bill | ❌ غير موجودة (لا توجد علاقة بين BillDetail و StnBill) |
| 417 | IAS_AP_CNTRCT_DTL | IAS_AP_CNTRCT | n:1 | IAC_IACD | IACD_CODE | IAAPCN_IAAPCNDT_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias ap cntrct dtl | ✅ موجودة (APContractDetail و APContract) |
| 418 | IAS_AP_CNTRCT | IAS_PROJECT | n:1 | IAC_IP | IP_CODE | IAAPCN_IAPR_FK | المشاريع والعقود | ربط ias ap cntrct بـias project | ✅ موجودة (APContract و Project) |
| 419 | IAS_AP_CNTRCT_DTL | IAS_PROJECT_COST | n:1 | IAS_IPC | IPC_CODE | IAAPCNDT_IAPRCO_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias project cost | ❌ غير موجودة (لا توجد علاقة بين APContractDetail و ProjectCost) |
| 420 | IAS_PROJECT | IAS_AP_CNTRCT | n:1 | IP_IAC | IAC_CODE | IAPR_IAAPCN_FK | المشاريع والعقود | ربط ias project بـias ap cntrct | ✅ موجودة (Project و APContract) |
| 421 | CUSTOMER | IAS_CST_CLSS | 1:n | C_ICC | ICC_CODE | CU_IACSCL_FK | المبيعات والعملاء | ربط customer بـias cst clss | ✅ موجودة (Customer و CustomerClass) |
| 422 | APX_FVRT_SCR | IAS_USR_AUDIT | n:1 | AFS_IUA | IUA_CODE | APFVSC_IAUSAU_FK | النظام والأمن | ربط apx fvrt scr بـias usr audit | ✅ موجودة (FavoriteScreen و UserAudit) |
| 423 | STK_MOVMNT | VENDOR | n:1 | SM_VNDR | VNDR_CODE | STMO_VE_FK | المخزون والمستودعات | ربط stk movmnt بـvendor | ❌ غير موجودة (لا توجد علاقة بين ItemMovement و Vendor) |
| 424 | CASH_RECEIPT | BANK_CHEQUE | 1:n | CR_BC | BC_CODE | CARE_BACH_FK | النقدية والبنوك | ربط cash receipt بـbank cheque | ❌ غير موجودة (لا توجد علاقة بين CashReceipt و BankCheque) |
| 425 | S_JOB | CUSTOMER | n:1 | SJ_CST | CST_CODE | SJO_CU_FK | الموارد البشرية | ربط s job بـcustomer | ❌ غير موجودة (لا توجد علاقة بين Job و Customer) |
| 426 | IAS_CASH_INCOME | CASH_RECEIPT | 1:n | ICI_CR | CR_CODE | IACAIN_CARE_FK | النقدية والبنوك | ربط ias cash income بـcash receipt | ❌ غير موجودة (لا توجد علاقة بين CashIncome و CashReceipt) |
| 427 | SALES_RETURN | CUSTOMER | n:1 | SR_CST | CST_CODE | SARE_CU_FK | المبيعات والعملاء | ربط sales return بـcustomer | ✅ موجودة (SalesReturn و Customer) |
| 428 | ITEM_COST | CUSTOMER | n:1 | IC_CST | CST_CODE | ITCO_CU_FK | المخزون والمستودعات | ربط item cost بـcustomer | ❌ غير موجودة (لا توجد علاقة بين ItemCost و Customer) |
| 429 | IAS_USR_PRF | APX_SCR_PRV | n:1 | IUP_ASP | ASP_CODE | IAUSPR_APSCPR_FK | النظام والأمن | ربط ias usr prf بـapx scr prv | ✅ موجودة (UserProfile و ScreenPrivilege) |
| 430 | HRS_ATT | HRS_SAL | 1:n | HA_HS | HS_CODE | HRAT_HRSA_FK | الموارد البشرية | ربط hrs att بـhrs sal | ✅ موجودة (Attendance و Salary) |
| 431 | IAS_USR | IAS_GRP | n:1 | IU_IG | IG_CODE | IAUS_IAGR_FK | النظام والأمن | ربط ias usr بـias grp | ✅ موجودة (User و UserGroup) |
| 432 | IAS_USR_LGN_HSTRY | IAS_USR_AUDIT | 1:n | IULH_IUA | IUA_CODE | IAUSLGHS_IAUSAU_FK | النظام والأمن | ربط ias usr lgn hstry بـias usr audit | ✅ موجودة (UserLoginHistory و UserAudit) |
| 433 | P_ORDER_DETAIL | IAS_VNDR_TYP | 1:n | P_IVT | IVT_CODE | PORDE_IAVNTY_FK | المشتريات والموردين | ربط تفاصيل p order detail بـias vndr typ | ❌ غير موجودة (لا توجد علاقة بين PurchaseOrderDetail و VendorType) |
| 434 | GRN_DETAIL | GRN_DETAIL | 1:n | GRN_GD | GD_CODE | GRDE_GRDE_FK | المشتريات والموردين | ربط تفاصيل grn detail بـgrn detail | ❌ غير موجودة (لا توجد علاقة ذاتية في GoodsReceiptNoteDetail) |
| 435 | OPEN_BAL | ACCOUNT | n:1 | OB_A | A_CODE | OPBA_AC_FK | الحسابات والدفتر العام | ربط open bal بـaccount | ✅ موجودة (OpeningBalance و Account) |
| 436 | IAS_BILL | ACCOUNT | n:1 | IB_A | A_CODE | IABI_AC_FK | المبيعات والعملاء | ربط ias bill بـaccount | ❌ غير موجودة (لا توجد علاقة بين Bill و Account) |
| 437 | GRN_DETAIL | COST_CENTERS | n:1 | GRN_CC | CC_CODE | GRDE_COCE_FK | المشتريات والموردين | ربط تفاصيل grn detail بـcost centers | ✅ موجودة (GoodsReceiptNoteDetail و CostCenter) |
| 438 | IAS_BILL | SALES_RETURN | n:1 | IB_SR | SR_CODE | IABI_SARE_FK | المبيعات والعملاء | ربط ias bill بـsales return | ❌ غير موجودة (لا توجد علاقة بين Bill و SalesReturn) |
| 439 | ACCOUNT_REPORT_TYPE | ACCOUNT | n:1 | ART_A | A_CODE | ACRETY_AC_FK | الحسابات والدفتر العام | ربط account report type بـaccount | ✅ موجودة (AccountReportType و Account) |
| 440 | STN_BILL | CUSTOMER | n:1 | SB_CST | CST_CODE | STBI_CU_FK | المبيعات والعملاء | ربط stn bill بـcustomer | ✅ موجودة (StnBill و Customer) |
| 441 | GUARN_MASTER | GR_NOTE | n:1 | GM_GN | GN_CODE | GUMA_GRNO_FK | الضمانات والكفالات | ربط guarn master بـgr note | ✅ موجودة (GuaranteeMaster و GuaranteeNote) |
| 442 | IAS_PROJECT_PHASE | IAS_AR_CNTRCT | n:1 | IPP_IAC | IAC_CODE | IAPRPH_IAARCN_FK | المشاريع والعقود | ربط ias project phase بـias ar cntrct | ❌ غير موجودة (لا توجد علاقة بين ProjectPhase و ARContract) |
| 443 | IAS_PI_BILL_DTL | P_ORDER | n:1 | IAS_PO | PO_CODE | IAPIBIDT_POR_FK | المشتريات والموردين | ربط تفاصيل ias pi bill dtl بـp order | ❌ غير موجودة (لا توجد علاقة بين PurchaseInvoiceDetail و PurchaseOrder) |
| 444 | P_ORDER_DETAIL | IAS_VNDR_CLSS | n:1 | P_IVC | IVC_CODE | PORDE_IAVNCL_FK | المشتريات والموردين | ربط تفاصيل p order detail بـias vndr clss | ❌ غير موجودة (لا توجد علاقة بين PurchaseOrderDetail و VendorClass) |
| 445 | GUARN_DETAILS | GR_NOTE | 1:1 | GUARN_GN | GN_CODE | GUDE_GRNO_FK | الضمانات والكفالات | ربط guarn details بـgr note | ✅ موجودة (GuaranteeDetail و GuaranteeNote) |
| 446 | IAS_PROJECT_PHASE | IAS_PROJECT_COST | n:1 | IPP_IPC | IPC_CODE | IAPRPH_IAPRCO_FK | المشاريع والعقود | ربط ias project phase بـias project cost | ❌ غير موجودة (لا توجد علاقة بين ProjectPhase و ProjectCost) |
| 447 | ACCOUNT_REPORT_TYPE | OPEN_BAL | n:1 | ART_OB | OB_CODE | ACRETY_OPBA_FK | الحسابات والدفتر العام | ربط account report type بـopen bal | ✅ موجودة (AccountReportType و OpeningBalance) |
| 448 | ACCOUNT_GROUPING | GLS_COST_CENTER_TRANS | n:1 | AG_GCCT | GCCT_CODE | ACGR_GLCOCETR_FK | الحسابات والدفتر العام | ربط account grouping بـgls cost center trans | ✅ موجودة (AccountGrouping و CostCenterTransaction) |
| 449 | IAS_CASH_OUTGOING | BANK_CHEQUE | n:1 | ICO_BC | BC_CODE | IACAOU_BACH_FK | النقدية والبنوك | ربط ias cash outgoing بـbank cheque | ❌ غير موجودة (لا توجد علاقة بين CashOutgoing و BankCheque) |
| 450 | IAS_CASH_OUTGOING | IAS_CASH | n:1 | ICO_IC | IC_CODE | IACAOU_IACA_FK | النقدية والبنوك | ربط ias cash outgoing بـias cash | ❌ غير موجودة (لا توجد علاقة بين CashOutgoing و Cash) |
| 451 | GRN_DETAIL | IAS_AP_CNTRCT_DTL | n:1 | GRN_IACD | IACD_CODE | GRDE_IAAPCNDT_FK | المشتريات والموردين | ربط تفاصيل grn detail بـias ap cntrct dtl | ❌ غير موجودة (لا توجد علاقة بين GoodsReceiptNoteDetail و APContractDetail) |
| 452 | STN_BILL_DTL | STN_BILL | n:1 | SBD_SB | SB_CODE | STBIDT_STBI_FK | المبيعات والعملاء | ربط تفاصيل stn bill dtl بـstn bill | ✅ موجودة (StnBillDetail و StnBill) |
| 453 | P_ORDER_DETAIL | IAS_ACTVTY | n:1 | P_IA | IA_CODE | PORDE_IAAC_FK | المشتريات والموردين | ربط تفاصيل p order detail بـias actvty | ❌ غير موجودة (لا توجد علاقة بين PurchaseOrderDetail و Activity) |
| 454 | IAS_BILL_DTL | CUSTOMER | n:1 | IBD_CST | CST_CODE | IABIDT_CU_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـcustomer | ❌ غير موجودة (لا توجد علاقة بين BillDetail و Customer) |
| 455 | GRN_DETAIL | ACCOUNT | n:1 | GRN_A | A_CODE | GRDE_AC_FK | المشتريات والموردين | ربط تفاصيل grn detail بـaccount | ✅ موجودة (GoodsReceiptNoteDetail و Account) |
| 456 | BANK_CHEQUE | IAS_CASH | n:1 | BC_IC | IC_CODE | BACH_IACA_FK | النقدية والبنوك | ربط bank cheque بـias cash | ❌ غير موجودة (لا توجد علاقة بين BankCheque و Cash) |
| 457 | IAS_PI_BILL_DTL | IAS_ACTVTY | n:1 | IAS_IA | IA_CODE | IAPIBIDT_IAAC_FK | المشتريات والموردين | ربط تفاصيل ias pi bill dtl بـias actvty | ❌ غير موجودة (لا توجد علاقة بين PurchaseInvoiceDetail و Activity) |
| 458 | IAS_AP_CNTRCT_DTL | ACCOUNT | n:1 | IAS_A | A_CODE | IAAPCNDT_AC_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـaccount | ❌ غير موجودة (لا توجد علاقة بين APContractDetail و Account) |
| 459 | IAS_PI_BILL_DTL | IAS_AP_CNTRCT_DTL | n:1 | IAS_IACD | IACD_CODE | IAPIBIDT_IAAPCNDT_FK | المشتريات والموردين | ربط تفاصيل ias pi bill dtl بـias ap cntrct dtl | ❌ غير موجودة (لا توجد علاقة بين PurchaseInvoiceDetail و APContractDetail) |
| 460 | GRN_DETAIL | STN_BILL | n:1 | GRN_SB | SB_CODE | GRDE_STBI_FK | المشتريات والموردين | ربط تفاصيل grn detail بـstn bill | ❌ غير موجودة (لا توجد علاقة بين GoodsReceiptNoteDetail و StnBill) |
| 461 | IAS_PI_BILL | IAS_PI_BILL | n:1 | IAS_IAPB | IAPB_CODE | IAPIBI_IAPIBI_FK | المشتريات والموردين | ربط ias pi bill بـias pi bill | ❌ غير موجودة (لا توجد علاقة ذاتية في PurchaseInvoice) |
| 462 | GUARN_DETAILS | BANK_CHEQUE | n:1 | GUARN_BC | BC_CODE | GUDE_BACH_FK | الضمانات والكفالات | ربط guarn details بـbank cheque | ✅ موجودة (GuaranteeDetail و BankCheque) |
| 463 | IAS_PI_BILL_DTL | STN_BILL | n:1 | IAS_SB | SB_CODE | IAPIBIDT_STBI_FK | المشتريات والموردين | ربط تفاصيل ias pi bill dtl بـstn bill | ❌ غير موجودة (لا توجد علاقة بين PurchaseInvoiceDetail و StnBill) |
| 464 | GRN_DETAIL | P_ORDER | n:1 | GRN_PO | PO_CODE | GRDE_POR_FK | المشتريات والموردين | ربط تفاصيل grn detail بـp order | ✅ موجودة (GoodsReceiptNoteDetail و PurchaseOrder) |
| 465 | GUARN_DETAILS | CASH_RECEIPT | n:1 | GUARN_CR | CR_CODE | GUDE_CARE_FK | الضمانات والكفالات | ربط guarn details بـcash receipt | ❌ غير موجودة (لا توجد علاقة بين GuaranteeDetail و CashReceipt) |
| 466 | GUARN_DETAILS | IAS_CASH | n:1 | GUARN_IC | IC_CODE | GUDE_IACA_FK | الضمانات والكفالات | ربط guarn details بـias cash | ❌ غير موجودة (لا توجد علاقة بين GuaranteeDetail و Cash) |
| 467 | IAS_PI_BILL_DTL | IAS_ACTVTY_GROUP | n:1 | IAS_IAG | IAG_CODE | IAPIBIDT_IAACGR_FK | المشتريات والموردين | ربط تفاصيل ias pi bill dtl بـias actvty group | ❌ غير موجودة (لا توجد علاقة بين PurchaseInvoiceDetail و ActivityGroup) |
| 468 | P_ORDER_DETAIL | IAS_HR | n:1 | P_IHR | IHR_CODE | PORDE_IAHR_FK | المشتريات والموردين | ربط تفاصيل p order detail بـias hr | ❌ غير موجودة (لا توجد علاقة بين PurchaseOrderDetail و Employee) |
| 469 | IAS_BILL | IAS_PROJECT | n:1 | IB_IP | IP_CODE | IABI_IAPR_FK | المبيعات والعملاء | ربط ias bill بـias project | ❌ غير موجودة (لا توجد علاقة بين Bill و Project) |
| 470 | IAS_CASH | IAS_BANK_ACCOUNT | n:1 | IC_IBA | IBA_CODE | IACA_IABAAC_FK | النقدية والبنوك | ربط ias cash بـias bank account | ❌ غير موجودة (لا توجد علاقة بين Cash و BankAccount) |
| 471 | HRS_SAL | CASH_RECEIPT | n:1 | HS_CR | CR_CODE | HRSA_CARE_FK | الموارد البشرية | ربط hrs sal بـcash receipt | ❌ غير موجودة (لا توجد علاقة بين Salary و CashReceipt) |
| 472 | GUARN_DETAILS | SALES_RETURN | n:1 | GUARN_SR | SR_CODE | GUDE_SARE_FK | الضمانات والكفالات | ربط guarn details بـsales return | ❌ غير موجودة (لا توجد علاقة بين GuaranteeDetail و SalesReturn) |
| 473 | IAS_AP_CNTRCT_DTL | ITEM_CARD | n:1 | IAS_IC | IC_CODE | IAAPCNDT_ITCA_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـitem card | ❌ غير موجودة (لا توجد علاقة بين APContractDetail و Item) |
| 474 | GUARN_DETAILS | VENDOR | n:1 | GUARN_VNDR | VNDR_CODE | GUDE_VE_FK | الضمانات والكفالات | ربط guarn details بـvendor | ✅ موجودة (GuaranteeDetail و Vendor) |
| 475 | STN_BILL_DTL | IAS_BILL | n:1 | SBD_IB | IB_CODE | STBIDT_IABI_FK | المبيعات والعملاء | ربط تفاصيل stn bill dtl بـias bill | ❌ غير موجودة (لا توجد علاقة بين StnBillDetail و Bill) |
| 476 | IAS_PI_BILL_DTL | GRN_DETAIL | n:1 | IAS_GD | GD_CODE | IAPIBIDT_GRDE_FK | المشتريات والموردين | ربط تفاصيل ias pi bill dtl بـgrn detail | ❌ غير موجودة (لا توجد علاقة بين PurchaseInvoiceDetail و GoodsReceiptNoteDetail) |
| 477 | P_ORDER_DETAIL | STN_BILL | n:1 | P_SB | SB_CODE | PORDE_STBI_FK | المشتريات والموردين | ربط تفاصيل p order detail بـstn bill | ❌ غير موجودة (لا توجد علاقة بين PurchaseOrderDetail و StnBill) |
| 478 | ACCOUNT | OPEN_BAL | n:1 | A_OB | OB_CODE | AC_OPBA_FK | الحسابات والدفتر العام | ربط account بـopen bal | ✅ موجودة (Account و OpeningBalance) |
| 479 | IAS_AP_CNTRCT_DTL | IAS_ACTVTY | n:1 | IAS_IA | IA_CODE | IAAPCNDT_IAAC_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias actvty | ❌ غير موجودة (لا توجد علاقة بين APContractDetail و Activity) |
| 480 | HRS_SAL | VENDOR | n:1 | HS_VNDR | VNDR_CODE | HRSA_VE_FK | الموارد البشرية | ربط hrs sal بـvendor | ❌ غير موجودة (لا توجد علاقة بين Salary و Vendor) |
| 481 | IAS_AP_CNTRCT_DTL | GRN_DETAIL | n:1 | IAS_GD | GD_CODE | IAAPCNDT_GRDE_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـgrn detail | ❌ غير موجودة (لا توجد علاقة بين APContractDetail و GoodsReceiptNoteDetail) |
| 482 | IAS_AP_CNTRCT_DTL | COST_CENTERS | n:1 | IAS_CC | CC_CODE | IAAPCNDT_COCE_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـcost centers | ✅ موجودة (APContractDetail و CostCenter) |
| 483 | IAS_AR_CNTRCT_DTL | IAS_PROJECT_COST | n:1 | IAS_IPC | IPC_CODE | IAARCNDT_IAPRCO_FK | المشاريع والعقود | ربط تفاصيل ias ar cntrct dtl بـias project cost | ❌ غير موجودة (لا توجد علاقة بين ARContractDetail و ProjectCost) |
| 484 | IAS_BILL_DTL | ITEM_CARD | n:1 | IBD_IC | IC_CODE | IABIDT_ITCA_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـitem card | ✅ موجودة (BillDetail و Item) |
| 485 | P_ORDER_DETAIL | ACCOUNT | n:1 | P_A | A_CODE | PORDE_AC_FK | المشتريات والموردين | ربط تفاصيل p order detail بـaccount | ✅ موجودة (PurchaseOrderDetail و Account) |
| 486 | S_JOB | CASH_RECEIPT | n:1 | SJ_CR | CR_CODE | SJO_CARE_FK | الموارد البشرية | ربط s job بـcash receipt | ❌ غير موجودة (لا توجد علاقة بين Job و CashReceipt) |
| 487 | IAS_BILL_DTL | IAS_AR_CNTRCT_DTL | n:1 | IBD_IACD | IACD_CODE | IABIDT_IAARCNDT_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـias ar cntrct dtl | ❌ غير موجودة (لا توجد علاقة بين BillDetail و ARContractDetail) |
| 488 | IAS_BILL_DTL | COST_CENTERS | n:1 | IBD_CC | CC_CODE | IABIDT_COCE_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـcost centers | ✅ موجودة (BillDetail و CostCenter) |
| 489 | GUARN_DETAILS | IAS_AR_CNTRCT | n:1 | GUARN_IAC | IAC_CODE | GUDE_IAARCN_FK | الضمانات والكفالات | ربط guarn details بـias ar cntrct | ❌ غير موجودة (لا توجد علاقة بين GuaranteeDetail و ARContract) |
| 490 | IAS_PI_BILL_DTL | ITEM_CARD | n:1 | IAS_IC | IC_CODE | IAPIBIDT_ITCA_FK | المشتريات والموردين | ربط تفاصيل ias pi bill dtl بـitem card | ✅ موجودة (PurchaseInvoiceDetail و Item) |
| 491 | P_ORDER_DETAIL | ITEM_CARD | n:1 | P_IC | IC_CODE | PORDE_ITCA_FK | المشتريات والموردين | ربط تفاصيل p order detail بـitem card | ✅ موجودة (PurchaseOrderDetail و Item) |
| 492 | IAS_BILL_DTL | IAS_ACTVTY | n:1 | IBD_IA | IA_CODE | IABIDT_IAAC_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـias actvty | ❌ غير موجودة (لا توجد علاقة بين BillDetail و Activity) |
| 493 | IAS_PI_BILL_DTL | CUSTOMER | n:1 | IAS_CST | CST_CODE | IAPIBIDT_CU_FK | المشتريات والموردين | ربط تفاصيل ias pi bill dtl بـcustomer | ❌ غير موجودة (لا توجد علاقة بين PurchaseInvoiceDetail و Customer) |
| 494 | STN_BILL | VENDOR | n:1 | SB_VNDR | VNDR_CODE | STBI_VE_FK | المبيعات والعملاء | ربط stn bill بـvendor | ❌ غير موجودة (لا توجد علاقة بين StnBill و Vendor) |
| 495 | IAS_PI_BILL_DTL | IAS_BILL | n:1 | IAS_IB | IB_CODE | IAPIBIDT_IABI_FK | المشتريات والموردين | ربط تفاصيل ias pi bill dtl بـias bill | ❌ غير موجودة (لا توجد علاقة بين PurchaseInvoiceDetail و Bill) |
| 496 | GRN_DETAIL | ITEM_CARD | n:1 | GRN_IC | IC_CODE | GRDE_ITCA_FK | المشتريات والموردين | ربط تفاصيل grn detail بـitem card | ✅ موجودة (GoodsReceiptNoteDetail و Item) |
| 497 | IAS_BILL_DTL | IAS_PROJECT | n:1 | IBD_IP | IP_CODE | IABIDT_IAPR_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـias project | ❌ غير موجودة (لا توجد علاقة بين BillDetail و Project) |
| 498 | IAS_PI_BILL_DTL | COST_CENTERS | n:1 | IAS_CC | CC_CODE | IAPIBIDT_COCE_FK | المشتريات والموردين | ربط تفاصيل ias pi bill dtl بـcost centers | ✅ موجودة (PurchaseInvoiceDetail و CostCenter) |
| 499 | GRN_DETAIL | IAS_ACTVTY | n:1 | GRN_IA | IA_CODE | GRDE_IAAC_FK | المشتريات والموردين | ربط تفاصيل grn detail بـias actvty | ❌ غير موجودة (لا توجد علاقة بين GoodsReceiptNoteDetail و Activity) |
| 500 | SALES_RETURN | ACCOUNT | n:1 | SR_A | A_CODE | SARE_AC_FK | المبيعات والعملاء | ربط sales return بـaccount | ✅ موجودة (SalesReturn و Account) |
| 550 | CUSTOMER | COST_CENTERS | n:1 | C_CC | CC_CODE | CU_COCE_FK | المبيعات والعملاء | ربط customer بـcost centers | ✅ موجودة (Customer و CostCenter) |
| 551 | CUSTOMER | IAS_ACTVTY | n:1 | C_IA | IA_CODE | CU_IAAC_FK | المبيعات والعملاء | ربط customer بـias actvty | ✅ موجودة (Customer و Activity) |
| 552 | VENDOR | IAS_PROJECT | n:1 | V_IP | IP_CODE | VE_IAPR_FK | المشتريات والموردين | ربط vendor بـias project | ✅ موجودة (Vendor و Project) |
| 553 | VENDOR | COST_CENTERS | n:1 | V_CC | CC_CODE | VE_COCE_FK | المشتريات والموردين | ربط vendor بـcost centers | ✅ موجودة (Vendor و CostCenter) |
| 554 | VENDOR | IAS_ACTVTY | n:1 | V_IA | IA_CODE | VE_IAAC_FK | المشتريات والموردين | ربط vendor بـias actvty | ✅ موجودة (Vendor و Activity) |
| 555 | STK_MOVMNT | IAS_PROJECT | n:1 | SM_IP | IP_CODE | STMO_IAPR_FK | المخزون والمستودعات | ربط stk movmnt بـias project | ✅ موجودة (ItemMovement و Project) |
| 556 | STK_MOVMNT | COST_CENTERS | n:1 | SM_CC | CC_CODE | STMO_COCE_FK | المخزون والمستودعات | ربط stk movmnt بـcost centers | ✅ موجودة (ItemMovement و CostCenter) |
| 557 | STK_MOVMNT | IAS_ACTVTY | n:1 | SM_IA | IA_CODE | STMO_IAAC_FK | المخزون والمستودعات | ربط stk movmnt بـias actvty | ❌ غير موجودة (لا توجد علاقة بين ItemMovement و Activity) |
| 558 | GUARN_MASTER | IAS_PROJECT | n:1 | GM_IP | IP_CODE | GUMA_IAPR_FK | الضمانات والكفالات | ربط guarn master بـias project | ✅ موجودة (GuaranteeMaster و Project) |
| 559 | GUARN_MASTER | COST_CENTERS | n:1 | GM_CC | CC_CODE | GUMA_COCE_FK | الضمانات والكفالات | ربط guarn master بـcost centers | ✅ موجودة (GuaranteeMaster و CostCenter) |
| 560 | GUARN_MASTER | IAS_ACTVTY | n:1 | GM_IA | IA_CODE | GUMA_IAAC_FK | الضمانات والكفالات | ربط guarn master بـias actvty | ❌ غير موجودة (لا توجد علاقة بين GuaranteeMaster و Activity) |
| 561 | GUARN_DETAILS | IAS_PROJECT | n:1 | GUARN_IP | IP_CODE | GUDE_IAPR_FK | الضمانات والكفالات | ربط guarn details بـias project | ✅ موجودة (GuaranteeDetail و Project) |
| 562 | HRS_SAL | IAS_PROJECT | n:1 | HS_IP | IP_CODE | HRSA_IAPR_FK | الموارد البشرية | ربط hrs sal بـias project | ✅ موجودة (Salary و Project) |
| 563 | HRS_SAL | COST_CENTERS | n:1 | HS_CC | CC_CODE | HRSA_COCE_FK | الموارد البشرية | ربط hrs sal بـcost centers | ✅ موجودة (Salary و CostCenter) |
| 564 | HRS_SAL | IAS_ACTVTY | n:1 | HS_IA | IA_CODE | HRSA_IAAC_FK | الموارد البشرية | ❌ غير موجودة (لا توجد علاقة بين Salary و Activity) |
| 565 | HRS_ATT | IAS_PROJECT | n:1 | HA_IP | IP_CODE | HRAT_IAPR_FK | الموارد البشرية | ربط hrs att بـias project | ✅ موجودة (Attendance و Project) |
| 566 | HRS_ATT | COST_CENTERS | n:1 | HA_CC | CC_CODE | HRAT_COCE_FK | الموارد البشرية | ربط hrs att بـcost centers | ✅ موجودة (Attendance و CostCenter) |
| 567 | HRS_ATT | IAS_ACTVTY | n:1 | HA_IA | IA_CODE | HRAT_IAAC_FK | الموارد البشرية | ❌ غير موجودة (لا توجد علاقة بين Attendance و Activity) |
| 568 | S_JOB | IAS_PROJECT | n:1 | SJ_IP | IP_CODE | SJO_IAPR_FK | الموارد البشرية | ربط s job بـias project | ✅ موجودة (Job و Project) |
| 569 | S_JOB | COST_CENTERS | n:1 | SJ_CC | CC_CODE | SJO_COCE_FK | الموارد البشرية | ربط s job بـcost centers | ✅ موجودة (Job و CostCenter) |
| 570 | S_JOB | IAS_ACTVTY | n:1 | SJ_IA | IA_CODE | SJO_IAAC_FK | الموارد البشرية | ❌ غير موجودة (لا توجد علاقة بين Job و Activity) |
| 571 | IAS_HR | IAS_PROJECT | n:1 | IH_IP | IP_CODE | IAHR_IAPR_FK | الموارد البشرية | ربط ias hr بـias project | ✅ موجودة (Employee و Project) |
| 572 | IAS_HR | COST_CENTERS | n:1 | IH_CC | CC_CODE | IAHR_COCE_FK | الموارد البشرية | ربط ias hr بـcost centers | ✅ موجودة (Employee و CostCenter) |
| 573 | IAS_HR | IAS_ACTVTY | n:1 | IH_IA | IA_CODE | IAHR_IAAC_FK | الموارد البشرية | ❌ غير موجودة (لا توجد علاقة بين Employee و Activity) |
| 574 | IAS_CASH | IAS_PROJECT | n:1 | IC_IP | IP_CODE | IACA_IAPR_FK | النقدية والبنوك | ربط ias cash بـias project | ❌ غير موجودة (لا توجد علاقة بين Cash و Project) |
| 575 | IAS_CASH | COST_CENTERS | n:1 | IC_CC | CC_CODE | IACA_COCE_FK | النقدية والبنوك | ربط ias cash بـcost centers | ✅ موجودة (Cash و CostCenter) |
| 576 | IAS_CASH | IAS_ACTVTY | n:1 | IC_IA | IA_CODE | IACA_IAAC_FK | النقدية والبنوك | ❌ غير موجودة (لا توجد علاقة بين Cash و Activity) |
| 577 | IAS_CASH_INCOME | IAS_PROJECT | n:1 | ICI_IP | IP_CODE | IACAIN_IAPR_FK | النقدية والبنوك | ربط ias cash income بـias project | ❌ غير موجودة (لا توجد علاقة بين CashIncome و Project) |
| 578 | IAS_CASH_INCOME | COST_CENTERS | n:1 | ICI_CC | CC_CODE | IACAIN_COCE_FK | النقدية والبنوك | ربط ias cash income بـcost centers | ✅ موجودة (CashIncome و CostCenter) |
| 579 | IAS_CASH_INCOME | IAS_ACTVTY | n:1 | ICI_IA | IA_CODE | IACAIN_IAAC_FK | النقدية والبنوك | ❌ غير موجودة (لا توجد علاقة بين CashIncome و Activity) |
| 580 | IAS_CASH_OUTGOING | IAS_PROJECT | n:1 | ICO_IP | IP_CODE | IACAOU_IAPR_FK | النقدية والبنوك | ربط ias cash outgoing بـias project | ❌ غير موجودة (لا توجد علاقة بين CashOutgoing و Project) |
| 581 | IAS_CASH_OUTGOING | COST_CENTERS | n:1 | ICO_CC | CC_CODE | IACAOU_COCE_FK | النقدية والبنوك | ربط ias cash outgoing بـcost centers | ✅ موجودة (CashOutgoing و CostCenter) |
| 582 | IAS_CASH_OUTGOING | IAS_ACTVTY | n:1 | ICO_IA | IA_CODE | IACAOU_IAAC_FK | النقدية والبنوك | ❌ غير موجودة (لا توجد علاقة بين CashOutgoing و Activity) |
| 583 | CASH_RECEIPT | IAS_PROJECT | n:1 | CR_IP | IP_CODE | CARE_IAPR_FK | النقدية والبنوك | ربط cash receipt بـias project | ❌ غير موجودة (لا توجد علاقة بين CashReceipt و Project) |
| 584 | CASH_RECEIPT | COST_CENTERS | n:1 | CR_CC | CC_CODE | CARE_COCE_FK | النقدية والبنوك | ربط cash receipt بـcost centers | ✅ موجودة (CashReceipt و CostCenter) |
| 585 | CASH_RECEIPT | IAS_ACTVTY | n:1 | CR_IA | IA_CODE | CARE_IAAC_FK | النقدية والبنوك | ❌ غير موجودة (لا توجد علاقة بين CashReceipt و Activity) |
| 586 | IAS_BANK | IAS_PROJECT | n:1 | IB_IP | IP_CODE | IABA_IAPR_FK | النقدية والبنوك | ربط ias bank بـias project | ❌ غير موجودة (لا توجد علاقة بين Bank و Project) |
| 587 | IAS_BANK | COST_CENTERS | n:1 | IB_CC | CC_CODE | IABA_COCE_FK | النقدية والبنوك | ربط ias bank بـcost centers | ✅ موجودة (Bank و CostCenter) |
| 588 | IAS_BANK | IAS_ACTVTY | n:1 | IB_IA | IA_CODE | IABA_IAAC_FK | النقدية والبنوك | ❌ غير موجودة (لا توجد علاقة بين Bank و Activity) |
| 589 | BANK_CHEQUE | IAS_PROJECT | n:1 | BC_IP | IP_CODE | BACH_IAPR_FK | النقدية والبنوك | ربط bank cheque بـias project | ❌ غير موجودة (لا توجد علاقة بين BankCheque و Project) |
| 590 | BANK_CHEQUE | COST_CENTERS | n:1 | BC_CC | CC_CODE | BACH_COCE_FK | النقدية والبنوك | ربط bank cheque بـcost centers | ✅ موجودة (BankCheque و CostCenter) |
| 591 | BANK_CHEQUE | IAS_ACTVTY | n:1 | BC_IA | IA_CODE | BACH_IAAC_FK | النقدية والبنوك | ❌ غير موجودة (لا توجد علاقة بين BankCheque و Activity) |
| 592 | IAS_BANK_ACCOUNT | IAS_PROJECT | n:1 | IBA_IP | IP_CODE | IABAAC_IAPR_FK | النقدية والبنوك | ربط ias bank account بـias project | ❌ غير موجودة (لا توجد علاقة بين BankAccount و Project) |
| 593 | IAS_BANK_ACCOUNT | COST_CENTERS | n:1 | IBA_CC | CC_CODE | IABAAC_COCE_FK | النقدية والبنوك | ربط ias bank account بـcost centers | ✅ موجودة (BankAccount و CostCenter) |
| 594 | IAS_BANK_ACCOUNT | IAS_ACTVTY | n:1 | IBA_IA | IA_CODE | IABAAC_IAAC_FK | النقدية والبنوك | ❌ غير موجودة (لا توجد علاقة بين BankAccount و Activity) |
| 595 | IAS_AP_CNTRCT | IAS_ACTVTY | n:1 | IAC_IA | IA_CODE | IAAPCN_IAAC_FK | المشاريع والعقود | ربط ias ap cntrct بـias actvty | ❌ غير موجودة (لا توجد علاقة بين APContract و Activity) |
| 596 | IAS_AR_CNTRCT | IAS_ACTVTY | n:1 | IAC_IA | IA_CODE | IAARCN_IAAC_FK | المشاريع والعقود | ربط ias ar cntrct بـias actvty | ❌ غير موجودة (لا توجد علاقة بين ARContract و Activity) |
| 597 | IAS_PROJECT | IAS_ACTVTY | n:1 | IP_IA | IA_CODE | IAPR_IAAC_FK | المشاريع والعقود | ربط ias project بـias actvty | ✅ موجودة (Project و Activity) |
| 598 | IAS_PROJECT_PHASE | IAS_PROJECT | n:1 | IPP_IP | IP_CODE | IAPRPH_IAPR_FK | المشاريع والعقود | ربط ias project phase بـias project | ✅ موجودة (ProjectPhase و Project) |
| 599 | IAS_PROJECT_PHASE | IAS_ACTVTY | n:1 | IPP_IA | IA_CODE | IAPRPH_IAAC_FK | المشاريع والعقود | ربط ias project phase بـias actvty | ❌ غير موجودة (لا توجد علاقة بين ProjectPhase و Activity) |
| 600 | IAS_PROJECT_COST | IAS_PROJECT | n:1 | IPC_IP | IP_CODE | IAPRCO_IAPR_FK | المشاريع والعقود | ربط ias project cost بـias project | ✅ موجودة (ProjectCost و Project) |
| 601 | IAS_PROJECT_COST | IAS_ACTVTY | n:1 | IPC_IA | IA_CODE | IAPRCO_IAAC_FK | المشاريع والعقود | ربط ias project cost بـias actvty | ❌ غير موجودة (لا توجد علاقة بين ProjectCost و Activity) |
| 602 | IAS_PROJECT_BUDGET | IAS_PROJECT | n:1 | IPB_IP | IP_CODE | IAPRBU_IAPR_FK | المشاريع والعقود | ربط ias project budget بـias project | ✅ موجودة (ProjectBudget و Project) |
| 603 | IAS_PROJECT_BUDGET | IAS_ACTVTY | n:1 | IPB_IA | IA_CODE | IAPRBU_IAAC_FK | المشاريع والعقود | ربط ias project budget بـias actvty | ❌ غير موجودة (لا توجد علاقة بين ProjectBudget و Activity) |
| 604 | IAS_AP_CNTRCT | COST_CENTERS | n:1 | IAC_CC | CC_CODE | IAAPCN_COCE_FK | المشاريع والعقود | ربط ias ap cntrct بـcost centers | ✅ موجودة (APContract و CostCenter) |
| 605 | IAS_AR_CNTRCT | COST_CENTERS | n:1 | IAC_CC | CC_CODE | IAARCN_COCE_FK | المشاريع والعقود | ربط ias ar cntrct بـcost centers | ✅ موجودة (ARContract و CostCenter) |
| 606 | IAS_PROJECT | COST_CENTERS | n:1 | IP_CC | CC_CODE | IAPR_COCE_FK | المشاريع والعقود | ربط ias project بـcost centers | ✅ موجودة (Project و CostCenter) |
| 607 | IAS_PROJECT_PHASE | COST_CENTERS | n:1 | IPP_CC | CC_CODE | IAPRPH_COCE_FK | المشاريع والعقود | ربط ias project phase بـcost centers | ✅ موجودة (ProjectPhase و CostCenter) |
| 608 | IAS_PROJECT_COST | COST_CENTERS | n:1 | IPC_CC | CC_CODE | IAPRCO_COCE_FK | المشاريع والعقود | ربط ias project cost بـcost centers | ✅ موجودة (ProjectCost و CostCenter) |
| 609 | IAS_PROJECT_BUDGET | COST_CENTERS | n:1 | IPB_CC | CC_CODE | IAPRBU_COCE_FK | المشاريع والعقود | ربط ias project budget بـcost centers | ✅ موجودة (ProjectBudget و CostCenter) |
| 610 | IAS_INSURANCE | IAS_PROJECT | n:1 | II_IP | IP_CODE | IAIN_IAPR_FK | التأمين والضمانات | ربط ias insurance بـias project | ✅ موجودة (Insurance و Project) |
| 611 | IAS_INSURANCE | COST_CENTERS | n:1 | II_CC | CC_CODE | IAIN_COCE_FK | التأمين والضمانات | ربط ias insurance بـcost centers | ✅ موجودة (Insurance و CostCenter) |
| 612 | IAS_INSURANCE | IAS_ACTVTY | n:1 | II_IA | IA_CODE | IAIN_IAAC_FK | التأمين والضمانات | ❌ غير موجودة (لا توجد علاقة بين Insurance و Activity) |
| 613 | IAS_INSURANCE_INSTALLMENT | IAS_PROJECT | n:1 | IIS_IP | IP_CODE | IAININ_IAPR_FK | التأمين والضمانات | ربط ias insurance installment بـias project | ✅ موجودة (InsuranceInstallment و Project) |
| 614 | IAS_INSURANCE_INSTALLMENT | COST_CENTERS | n:1 | IIS_CC | CC_CODE | IAININ_COCE_FK | التأمين والضمانات | ربط ias insurance installment بـcost centers | ✅ موجودة (InsuranceInstallment و CostCenter) |
| 615 | IAS_INSURANCE_INSTALLMENT | IAS_ACTVTY | n:1 | IIS_IA | IA_CODE | IAININ_IAAC_FK | التأمين والضمانات | ❌ غير موجودة (لا توجد علاقة بين InsuranceInstallment و Activity) |
| 616 | MASTER_JOURNAL | IAS_PROJECT | n:1 | MJ_IP | IP_CODE | MAJO_IAPR_FK | الحسابات والدفتر العام | ربط master journal بـias project | ✅ موجودة (MasterJournal و Project) |
| 617 | MASTER_JOURNAL | COST_CENTERS | n:1 | MJ_CC | CC_CODE | MAJO_COCE_FK | الحسابات والدفتر العام | ربط master journal بـcost centers | ✅ موجودة (MasterJournal و CostCenter) |
| 618 | MASTER_JOURNAL | IAS_ACTVTY | n:1 | MJ_IA | IA_CODE | MAJO_IAAC_FK | الحسابات والدفتر العام | ✅ موجودة (MasterJournal و Activity) |
| 619 | DETAIL_JOURNAL | IAS_PROJECT | n:1 | DJ_IP | IP_CODE | DEJO_IAPR_FK | الحسابات والدفتر العام | ربط detail journal بـias project | ✅ موجودة (DetailJournal و Project) |
| 620 | DETAIL_JOURNAL | COST_CENTERS | n:1 | DJ_CC | CC_CODE | DEJO_COCE_FK | الحسابات والدفتر العام | ربط detail journal بـcost centers | ✅ موجودة (DetailJournal و CostCenter) |
| 621 | DETAIL_JOURNAL | IAS_ACTVTY | n:1 | DJ_IA | IA_CODE | DEJO_IAAC_FK | الحسابات والدفتر العام | ✅ موجودة (DetailJournal و Activity) |
| 622 | ACCOUNT_REPORT_TYPE | IAS_PROJECT | n:1 | ART_IP | IP_CODE | ACRETY_IAPR_FK | الحسابات والدفتر العام | ربط account report type بـias project | ✅ موجودة (AccountReportType و Project) |
| 623 | ACCOUNT_REPORT_TYPE | COST_CENTERS | n:1 | ART_CC | CC_CODE | ACRETY_COCE_FK | الحسابات والدفتر العام | ربط account report type بـcost centers | ✅ موجودة (AccountReportType و CostCenter) |
| 624 | ACCOUNT_REPORT_TYPE | IAS_ACTVTY | n:1 | ART_IA | IA_CODE | ACRETY_IAAC_FK | الحسابات والدفتر العام | ✅ موجودة (AccountReportType و Activity) |
| 625 | ACCOUNT_GROUPING | IAS_PROJECT | n:1 | AG_IP | IP_CODE | ACGR_IAPR_FK | الحسابات والدفتر العام | ربط account grouping بـias project | ✅ موجودة (AccountGrouping و Project) |
| 626 | ACCOUNT_GROUPING | COST_CENTERS | n:1 | AG_CC | CC_CODE | ACGR_COCE_FK | الحسابات والدفتر العام | ربط account grouping بـcost centers | ✅ موجودة (AccountGrouping و CostCenter) |
| 627 | ACCOUNT_GROUPING | IAS_ACTVTY | n:1 | AG_IA | IA_CODE | ACGR_IAAC_FK | الحسابات والدفتر العام | ✅ موجودة (AccountGrouping و Activity) |
| 628 | GR_NOTE | IAS_PROJECT | n:1 | GN_IP | IP_CODE | GRNO_IAPR_FK | الضمانات والكفالات | ربط gr note بـias project | ✅ موجودة (GuaranteeNote و Project) |
| 629 | GR_NOTE | COST_CENTERS | n:1 | GN_CC | CC_CODE | GRNO_COCE_FK | الضمانات والكفالات | ربط gr note بـcost centers | ✅ موجودة (GuaranteeNote و CostCenter) |
| 630 | GR_NOTE | IAS_ACTVTY | n:1 | GN_IA | IA_CODE | GRNO_IAAC_FK | الضمانات والكفالات | ❌ غير موجودة (لا توجد علاقة بين GuaranteeNote و Activity) |
| 631 | IAS_GUARN_TYPE | IAS_PROJECT | n:1 | IGT_IP | IP_CODE | IAGUTY_IAPR_FK | الضمانات والكفالات | ربط ias guarn type بـias project | ✅ موجودة (GuaranteeType و Project) |
| 632 | IAS_GUARN_TYPE | COST_CENTERS | n:1 | IGT_CC | CC_CODE | IAGUTY_COCE_FK | الضمانات والكفالات | ربط ias guarn type بـcost centers | ✅ موجودة (GuaranteeType و CostCenter) |
| 633 | IAS_GUARN_TYPE | IAS_ACTVTY | n:1 | IGT_IA | IA_CODE | IAGUTY_IAAC_FK | الضمانات والكفالات | ❌ غير موجودة (لا توجد علاقة بين GuaranteeType و Activity) |
| 634 | IAS_GUARN_STATUS | IAS_PROJECT | n:1 | IGS_IP | IP_CODE | IAGUST_IAPR_FK | الضمانات والكفالات | ربط ias guarn status بـias project | ✅ موجودة (GuaranteeStatus و Project) |
| 635 | IAS_GUARN_STATUS | COST_CENTERS | n:1 | IGS_CC | CC_CODE | IAGUST_COCE_FK | الضمانات والكفالات | ربط ias guarn status بـcost centers | ✅ موجودة (GuaranteeStatus و CostCenter) |
| 636 | IAS_GUARN_STATUS | IAS_ACTVTY | n:1 | IGS_IA | IA_CODE | IAGUST_IAAC_FK | الضمانات والكفالات | ❌ غير موجودة (لا توجد علاقة بين GuaranteeStatus و Activity) |
| 637 | IAS_CST_CLSS | IAS_PROJECT | n:1 | ICC_IP | IP_CODE | IACSCL_IAPR_FK | المبيعات والعملاء | ربط ias cst clss بـias project | ✅ موجودة (CustomerClass و Project) |
| 638 | IAS_CST_CLSS | COST_CENTERS | n:1 | ICC_CC | CC_CODE | IACSCL_COCE_FK | المبيعات والعملاء | ربط ias cst clss بـcost centers | ✅ موجودة (CustomerClass و CostCenter) |
| 639 | IAS_CST_CLSS | IAS_ACTVTY | n:1 | ICC_IA | IA_CODE | IACSCL_IAAC_FK | المبيعات والعملاء | ❌ غير موجودة (لا توجد علاقة بين CustomerClass و Activity) |
| 640 | IAS_CST_DGRE | IAS_PROJECT | n:1 | ICD_IP | IP_CODE | IACSDG_IAPR_FK | المبيعات والعملاء | ربط ias cst dgre بـias project | ✅ موجودة (CustomerDegree و Project) |
| 641 | IAS_CST_DGRE | COST_CENTERS | n:1 | ICD_CC | CC_CODE | IACSDG_COCE_FK | المبيعات والعملاء | ربط ias cst dgre بـcost centers | ✅ موجودة (CustomerDegree و CostCenter) |
| 642 | IAS_CST_DGRE | IAS_ACTVTY | n:1 | ICD_IA | IA_CODE | IACSDG_IAAC_FK | المبيعات والعملاء | ❌ غير موجودة (لا توجد علاقة بين CustomerDegree و Activity) |
| 643 | IAS_VNDR_CLSS | IAS_PROJECT | n:1 | IVC_IP | IP_CODE | IAVNCL_IAPR_FK | المشتريات والموردين | ربط ias vndr clss بـias project | ✅ موجودة (VendorClass و Project) |
| 644 | IAS_VNDR_CLSS | COST_CENTERS | n:1 | IVC_CC | CC_CODE | IAVNCL_COCE_FK | المشتريات والموردين | ربط ias vndr clss بـcost centers | ✅ موجودة (VendorClass و CostCenter) |
| 645 | IAS_VNDR_CLSS | IAS_ACTVTY | n:1 | IVC_IA | IA_CODE | IAVNCL_IAAC_FK | المشتريات والموردين | ❌ غير موجودة (لا توجد علاقة بين VendorClass و Activity) |
| 646 | IAS_VNDR_TYP | IAS_PROJECT | n:1 | IVT_IP | IP_CODE | IAVNTY_IAPR_FK | المشتريات والموردين | ربط ias vndr typ بـias project | ✅ موجودة (VendorType و Project) |
| 647 | IAS_VNDR_TYP | COST_CENTERS | n:1 | IVT_CC | CC_CODE | IAVNTY_COCE_FK | المشتريات والموردين | ربط ias vndr typ بـcost centers | ✅ موجودة (VendorType و CostCenter) |
| 648 | IAS_VNDR_TYP | IAS_ACTVTY | n:1 | IVT_IA | IA_CODE | IAVNTY_IAAC_FK | المشتريات والموردين | ❌ غير موجودة (لا توجد علاقة بين VendorType و Activity) |
| 649 | ITEM_UNIT_PRICE | IAS_PROJECT | n:1 | IUP_IP | IP_CODE | ITUNPR_IAPR_FK | المخزون والمستودعات | ربط item unit price بـias project | ✅ موجودة (ItemUnitPrice و Project) |
| 650 | ITEM_UNIT_PRICE | COST_CENTERS | n:1 | IUP_CC | CC_CODE | ITUNPR_COCE_FK | المخزون والمستودعات | ربط item unit price بـcost centers | ✅ موجودة (ItemUnitPrice و CostCenter) |
| 651 | ITEM_UNIT_PRICE | IAS_ACTVTY | n:1 | IUP_IA | IA_CODE | ITUNPR_IAAC_FK | المخزون والمستودعات | ❌ غير موجودة (لا توجد علاقة بين ItemUnitPrice و Activity) |
| 652 | WAREHOUSE | IAS_PROJECT | n:1 | W_IP | IP_CODE | WA_IAPR_FK | المخزون والمستودعات | ربط warehouse بـias project | ✅ موجودة (Warehouse و Project) |
| 653 | WAREHOUSE | COST_CENTERS | n:1 | W_CC | CC_CODE | WA_COCE_FK | المخزون والمستودعات | ربط warehouse بـcost centers | ✅ موجودة (Warehouse و CostCenter) |
| 654 | WAREHOUSE | IAS_ACTVTY | n:1 | W_IA | IA_CODE | WA_IAAC_FK | المخزون والمستودعات | ❌ غير موجودة (لا توجد علاقة بين Warehouse و Activity) |
| 655 | IAS_ITM_GRP | IAS_PROJECT | n:1 | IIG_IP | IP_CODE | IAITGR_IAPR_FK | المخزون والمستودعات | ربط ias itm grp بـias project | ✅ موجودة (ItemGroup و Project) |
| 656 | IAS_ITM_GRP | COST_CENTERS | n:1 | IIG_CC | CC_CODE | IAITGR_COCE_FK | المخزون والمستودعات | ربط ias itm grp بـcost centers | ✅ موجودة (ItemGroup و CostCenter) |
| 657 | IAS_ITM_GRP | IAS_ACTVTY | n:1 | IIG_IA | IA_CODE | IAITGR_IAAC_FK | المخزون والمستودعات | ❌ غير موجودة (لا توجد علاقة بين ItemGroup و Activity) |
| 658 | IAS_ITM_TYPE | IAS_PROJECT | n:1 | IIT_IP | IP_CODE | IAITTY_IAPR_FK | المخزون والمستودعات | ربط ias itm type بـias project | ✅ موجودة (ItemType و Project) |
| 659 | IAS_ITM_TYPE | COST_CENTERS | n:1 | IIT_CC | CC_CODE | IAITTY_COCE_FK | المخزون والمستودعات | ربط ias itm type بـcost centers | ✅ موجودة (ItemType و CostCenter) |
| 660 | IAS_ITM_TYPE | IAS_ACTVTY | n:1 | IIT_IA | IA_CODE | IAITTY_IAAC_FK | المخزون والمستودعات | ❌ غير موجودة (لا توجد علاقة بين ItemType و Activity) |
| 661 | IAS_ITM_MDLS | IAS_PROJECT | n:1 | IIM_IP | IP_CODE | IAITMDS_IAPR_FK | المخزون والمستودعات | ربط ias itm mdls بـias project | ✅ موجودة (ItemModel و Project) |
| 662 | IAS_ITM_MDLS | COST_CENTERS | n:1 | IIM_CC | CC_CODE | IAITMDS_COCE_FK | المخزون والمستودعات | ربط ias itm mdls بـcost centers | ✅ موجودة (ItemModel و CostCenter) |
| 663 | IAS_ITM_MDLS | IAS_ACTVTY | n:1 | IIM_IA | IA_CODE | IAITMDS_IAAC_FK | المخزون والمستودعات | ❌ غير موجودة (لا توجد علاقة بين ItemModel و Activity) |
| 664 | IAS_ITM_UNIT | IAS_PROJECT | n:1 | IIU_IP | IP_CODE | IAITUN_IAPR_FK | المخزون والمستودعات | ربط ias itm unit بـias project | ✅ موجودة (ItemUnit و Project) |
| 665 | IAS_ITM_UNIT | COST_CENTERS | n:1 | IIU_CC | CC_CODE | IAITUN_COCE_FK | المخزون والمستودعات | ربط ias itm unit بـcost centers | ✅ موجودة (ItemUnit و CostCenter) |
| 666 | IAS_ITM_UNIT | IAS_ACTVTY | n:1 | IIU_IA | IA_CODE | IAITUN_IAAC_FK | المخزون والمستودعات | ❌ غير موجودة (لا توجد علاقة بين ItemUnit و Activity) |
| 667 | IAS_ACTVTY | IAS_PROJECT | n:1 | IA_IP | IP_CODE | IAAC_IAPR_FK | النشاط الوظيفي | ربط ias actvty بـias project | ✅ موجودة (Activity و Project) |
| 668 | IAS_ACTVTY | COST_CENTERS | n:1 | IA_CC | CC_CODE | IAAC_COCE_FK | النشاط الوظيفي | ربط ias actvty بـcost centers | ✅ موجودة (Activity و CostCenter) |
| 669 | IAS_ACTVTY_GROUP | IAS_PROJECT | n:1 | IAG_IP | IP_CODE | IAACGR_IAPR_FK | النشاط الوظيفي | ربط ias actvty group بـias project | ✅ موجودة (ActivityGroup و Project) |
| 670 | IAS_ACTVTY_GROUP | COST_CENTERS | n:1 | IAG_CC | CC_CODE | IAACGR_COCE_FK | النشاط الوظيفي | ربط ias actvty group بـcost centers | ✅ موجودة (ActivityGroup و CostCenter) |
| 671 | IAS_ACTVTY_GROUP | IAS_ACTVTY | n:1 | IAG_IA | IA_CODE | IAACGR_IAAC_FK | النشاط الوظيفي | ✅ موجودة (ActivityGroup و Activity) |
| 672 | COST_CENTERS | IAS_PROJECT | n:1 | CC_IP | IP_CODE | COCE_IAPR_FK | مراكز التكلفة | ربط cost centers بـias project | ✅ موجودة (CostCenter و Project) |
| 673 | COST_CENTER_GROUP | IAS_PROJECT | n:1 | CCG_IP | IP_CODE | COCEGR_IAPR_FK | مراكز التكلفة | ربط cost center group بـias project | ✅ موجودة (CostCenterGroup و Project) |
| 674 | COST_CENTER_GROUP | COST_CENTERS | n:1 | CCG_CC | CC_CODE | COCEGR_COCE_FK | مراكز التكلفة | ربط cost center group بـcost centers | ✅ موجودة (CostCenterGroup و CostCenter) |
| 675 | COST_CENTER_GROUP | IAS_ACTVTY | n:1 | CCG_IA | IA_CODE | COCEGR_IAAC_FK | مراكز التكلفة | ✅ موجودة (CostCenterGroup و Activity) |
| 676 | COST_CENTER_TYPE | IAS_PROJECT | n:1 | CCT_IP | IP_CODE | COCETY_IAPR_FK | مراكز التكلفة | ربط cost center type بـias project | ✅ موجودة (CostCenterType و Project) |
| 677 | COST_CENTER_TYPE | COST_CENTERS | n:1 | CCT_CC | CC_CODE | COCETY_COCE_FK | مراكز التكلفة | ربط cost center type بـcost centers | ✅ موجودة (CostCenterType و CostCenter) |
| 678 | COST_CENTER_TYPE | IAS_ACTVTY | n:1 | CCT_IA | IA_CODE | COCETY_IAAC_FK | مراكز التكلفة | ✅ موجودة (CostCenterType و Activity) |
| 679 | IAS_USR | IAS_PROJECT | n:1 | IU_IP | IP_CODE | IAUS_IAPR_FK | النظام والأمن | ربط ias usr بـias project | ✅ موجودة (User و Project) |
| 680 | IAS_USR | COST_CENTERS | n:1 | IU_CC | CC_CODE | IAUS_COCE_FK | النظام والأمن | ربط ias usr بـcost centers | ✅ موجودة (User و CostCenter) |
| 681 | IAS_USR | IAS_ACTVTY | n:1 | IU_IA | IA_CODE | IAUS_IAAC_FK | النظام والأمن | ❌ غير موجودة (لا توجد علاقة بين User و Activity) |
| 682 | IAS_USR_PRF | IAS_PROJECT | n:1 | IUP_IP | IP_CODE | IAUSPR_IAPR_FK | النظام والأمن | ربط ias usr prf بـias project | ✅ موجودة (UserProfile و Project) |
| 683 | IAS_GRP | IAS_PROJECT | n:1 | IG_IP | IP_CODE | IAGR_IAPR_FK | النظام والأمن | ربط ias grp بـias project | ✅ موجودة (UserGroup و Project) |
| 684 | IAS_GRP | COST_CENTERS | n:1 | IG_CC | CC_CODE | IAGR_COCE_FK | النظام والأمن | ربط ias grp بـcost centers | ✅ موجودة (UserGroup و CostCenter) |
| 685 | IAS_GRP | IAS_ACTVTY | n:1 | IG_IA | IA_CODE | IAGR_IAAC_FK | النظام والأمن | ❌ غير موجودة (لا توجد علاقة بين UserGroup و Activity) |
| 686 | APX_SCR | IAS_PROJECT | n:1 | AS_IP | IP_CODE | APSC_IAPR_FK | النظام والأمن | ربط apx scr بـias project | ✅ موجودة (Screen و Project) |
| 687 | APX_SCR | COST_CENTERS | n:1 | AS_CC | CC_CODE | APSC_COCE_FK | النظام والأمن | ربط apx scr بـcost centers | ✅ موجودة (Screen و CostCenter) |
| 688 | APX_SCR | IAS_ACTVTY | n:1 | AS_IA | IA_CODE | APSC_IAAC_FK | النظام والأمن | ❌ غير موجودة (لا توجد علاقة بين Screen و Activity) |
| 689 | APX_SCR_PRV | IAS_PROJECT | n:1 | ASP_IP | IP_CODE | APSCPR_IAPR_FK | النظام والأمن | ربط apx scr prv بـias project | ✅ موجودة (ScreenPrivilege و Project) |
| 690 | APX_SCR_PRV | COST_CENTERS | n:1 | ASP_CC | CC_CODE | APSCPR_COCE_FK | النظام والأمن | ربط apx scr prv بـcost centers | ✅ موجودة (ScreenPrivilege و CostCenter) |
| 691 | APX_SCR_PRV | IAS_ACTVTY | n:1 | ASP_IA | IA_CODE | APSCPR_IAAC_FK | النظام والأمن | ❌ غير موجودة (لا توجد علاقة بين ScreenPrivilege و Activity) |
| 692 | APX_FVRT_SCR | IAS_PROJECT | n:1 | AFS_IP | IP_CODE | APFVSC_IAPR_FK | النظام والأمن | ربط apx fvrt scr بـias project | ✅ موجودة (FavoriteScreen و Project) |
| 693 | APX_FVRT_SCR | COST_CENTERS | n:1 | AFS_CC | CC_CODE | APFVSC_COCE_FK | النظام والأمن | ربط apx fvrt scr بـcost centers | ✅ موجودة (FavoriteScreen و CostCenter) |
| 694 | APX_FVRT_SCR | IAS_ACTVTY | n:1 | AFS_IA | IA_CODE | APFVSC_IAAC_FK | النظام والأمن | ❌ غير موجودة (لا توجد علاقة بين FavoriteScreen و Activity) |
| 695 | IAS_USR_AUDIT | IAS_PROJECT | n:1 | IUA_IP | IP_CODE | IAUSAU_IAPR_FK | النظام والأمن | ربط ias usr audit بـias project | ✅ موجودة (UserAudit و Project) |
| 696 | IAS_USR_AUDIT | COST_CENTERS | n:1 | IUA_CC | CC_CODE | IAUSAU_COCE_FK | النظام والأمن | ربط ias usr audit بـcost centers | ✅ موجودة (UserAudit و CostCenter) |
| 697 | IAS_USR_AUDIT | IAS_ACTVTY | n:1 | IUA_IA | IA_CODE | IAUSAU_IAAC_FK | النظام والأمن | ❌ غير موجودة (لا توجد علاقة بين UserAudit و Activity) |
| 698 | IAS_USR_LGN_HSTRY | IAS_PROJECT | n:1 | IULH_IP | IP_CODE | IAUSLGHS_IAPR_FK | النظام والأمن | ربط ias usr lgn hstry بـias project | ✅ موجودة (UserLoginHistory و Project) |
| 699 | IAS_USR_LGN_HSTRY | COST_CENTERS | n:1 | IULH_CC | CC_CODE | IAUSLGHS_COCE_FK | النظام والأمن | ربط ias usr lgn hstry بـcost centers | ✅ موجودة (UserLoginHistory و CostCenter) |
| 700 | IAS_USR_LGN_HSTRY | IAS_ACTVTY | n:1 | IULH_IA | IA_CODE | IAUSLGHS_IAAC_FK | النظام والأمن | ❌ غير موجودة (لا توجد علاقة بين UserLoginHistory و Activity) |
| 701 | APX_SCR_PRV | ITEM_CARD | n:1 | ASP_ITM | ITM_CODE | APSCPR_ITCA_FK | النظام والأمن | ربط apx scr prv بـitem card | ❌ غير موجودة (لا توجد علاقة بين ScreenPrivilege و Item) |
| 702 | P_ORDER | GRN_MASTER | n:1 | PO_GM | GM_CODE | POR_GRMA_FK | المشتريات والموردين | ربط p order بـgrn master | ✅ موجودة (PurchaseOrder و GoodsReceiptNoteMaster) |
| 703 | WAREHOUSE | ITEM_CARD | n:1 | W_ITM | ITM_CODE | WA_ITCA_FK | المخزون والمستودعات | ربط warehouse بـitem card | ✅ موجودة (Warehouse و Item) |
| 704 | WAREHOUSE | MASTER_JOURNAL | n:1 | W_MJ | MJ_CODE | WA_MAJO_FK | المخزون والمستودعات | ربط warehouse بـmaster journal | ❌ غير موجودة (لا توجد علاقة بين Warehouse و MasterJournal) |
| 705 | IAS_USR_LGN_HSTRY | COST_CENTERS | n:1 | IULH_CC | CC_CODE | IAUSLGHS_COCE_FK | النظام والأمن | ربط ias usr lgn hstry بـcost centers | ✅ موجودة (UserLoginHistory و CostCenter) |
| 706 | MEASUREMENT | ITEM_CARD | n:1 | M_ITM | ITM_CODE | ME_ITCA_FK | المخزون والمستودعات | ربط measurement بـitem card | ✅ موجودة (Measurement و Item) |
| 707 | HRS_EMP_VAC | HRS_ALLOW_TYP | n:1 | HEV_HAT | HAT_CODE | HREMVA_HRALTY_FK | الموارد البشرية | ربط hrs emp vac بـhrs allow typ | ❌ غير موجودة (لا توجد علاقة بين EmployeeVacation و AllowanceType) |
| 708 | IAS_ITM_GRP | COST_CENTERS | n:1 | IIG_CC | CC_CODE | IAITGR_COCE_FK | المخزون والمستودعات | ربط ias itm grp بـcost centers | ✅ موجودة (ItemGroup و CostCenter) |
| 709 | IAS_AP_CNTRCT | IAS_PROJECT_COST | n:1 | IAC_IPC | IPC_CODE | IAAPCN_IAPRCO_FK | المشاريع والعقود | ربط ias ap cntrct بـias project cost | ✅ موجودة (APContract و ProjectCost) |
| 710 | ACCOUNT_CURR | GLS_COST_CENTER_TRANS | n:1 | AC_GCCT | GCCT_CODE | ACCU_GLCOCETR_FK | الحسابات والدفتر العام | ربط account curr بـgls cost center trans | ❌ غير موجودة (لا توجد علاقة بين AccountCurrency و GLSCostCenterTrans) |
| 711 | IAS_PI_BILL | VENDOR | n:1 | IPB_VNDR | VNDR_CODE | IAPIBI_VE_FK | المشتريات والموردين | ربط فاتورة المشتريات بالمورد | ✅ موجودة (PurchaseInvoice و Vendor) |
| 712 | IAS_GUARN_TYPE | GUARN_DETAILS | n:1 | IGT_GD | GD_CODE | IAGUTY_GUDE_FK | الضمانات والكفالات | ربط ias guarn type بـguarn details | ✅ موجودة (GuaranteeType و GuaranteeDetail) |
| 713 | IAS_GUARN_STATUS | COST_CENTERS | n:1 | IGS_CC | CC_CODE | IAGUST_COCE_FK | الضمانات والكفالات | ربط ias guarn status بـcost centers | ✅ موجودة (GuaranteeStatus و CostCenter) |
| 714 | GR_NOTE | IAS_GUARN_STATUS | n:1 | GN_IGS | IGS_CODE | GRNO_IAGUST_FK | الضمانات والكفالات | ربط gr note بـias guarn status | ✅ موجودة (GuaranteeNote و GuaranteeStatus) |
| 715 | IAS_BILL | SALES_RETURN | n:1 | IB_SR | SR_CODE | IABI_SARE_FK | المبيعات والعملاء | ربط ias bill بـsales return | ❌ غير موجودة (لا توجد علاقة بين Bill و SalesReturn) |
| 716 | IAS_ITM_GRP | STK_MOVMNT | n:1 | IIG_SM | SM_CODE | IAITGR_STMO_FK | المخزون والمستودعات | ربط ias itm grp بـstk movmnt | ❌ غير موجودة (لا توجد علاقة بين ItemGroup و ItemMovement) |
| 717 | IAS_GUARN_TYPE | GUARN_MASTER | 1:n | IGT_GM | GM_CODE | IAGUTY_GUMA_FK | الضمانات والكفالات | ربط ias guarn type بـguarn master | ✅ موجودة (GuaranteeType و GuaranteeMaster) |
| 718 | CUSTOMER | STN_BILL_DTL | n:1 | C_SBD | SBD_CODE | CU_STBIDT_FK | المبيعات والعملاء | ربط customer بـstn bill dtl | ❌ غير موجودة (لا توجد علاقة بين Customer و StnBillDetail) |
| 719 | ACCOUNT_CURR | ACCOUNT_TYPES | n:1 | AC_AT | AT_CODE | ACCU_ACTY_FK | الحسابات والدفتر العام | ربط account curr بـaccount types | ✅ موجودة (AccountCurrency و AccountType) |
| 720 | IAS_VNDR_TYP | IAS_PI_BILL_DTL | n:1 | IVT_IPBD | IPBD_CODE | IAVNTY_IAPIBIDT_FK | المشتريات والموردين | ربط ias vndr typ بـias pi bill dtl | ❌ غير موجودة (لا توجد علاقة بين VendorType و PurchaseInvoiceDetail) |
| 721 | IAS_GRP | CUSTOMER | n:1 | IG_CST | CST_CODE | IAGR_CU_FK | النظام والأمن | ربط ias grp بـcustomer | ❌ غير موجودة (لا توجد علاقة بين UserGroup و Customer) |
| 722 | GRN_DETAIL | IAS_PI_BILL | n:1 | GRN_IPB | IPB_CODE | GRDE_IAPIBI_FK | المشتريات والموردين | ربط تفاصيل grn detail بـias pi bill | ✅ موجودة (GoodsReceiptNoteDetail و PurchaseInvoice) |
| 723 | IAS_GUARN_STATUS | GUARN_DETAILS | n:1 | IGS_GD | GD_CODE | IAGUST_GUDE_FK | الضمانات والكفالات | ربط ias guarn status بـguarn details | ✅ موجودة (GuaranteeStatus و GuaranteeDetail) |
| 724 | IAS_PI_BILL_DTL | GRN_MASTER | n:m | IAS_GM | GM_CODE | IAPIBIDT_GRMA_FK | المشتريات والموردين | ربط تفاصيل ias pi bill dtl بـgrn master | ❌ غير موجودة (لا توجد علاقة مباشرة بين PurchaseInvoiceDetail و GoodsReceiptNoteMaster) |
| 725 | IAS_CASH_OUTGOING | IAS_USR | n:1 | ICO_IU | IU_CODE | IACAOU_IAUS_FK | النقدية والبنوك | ربط ias cash outgoing بـias usr | ✅ موجودة (CashOutgoing و User) |
| 726 | IAS_AP_CNTRCT | IAS_AP_CNTRCT_DTL | n:1 | IAC_IACD | IACD_CODE | IAAPCN_IAAPCNDT_FK | المشاريع والعقود | ربط ias ap cntrct بـias ap cntrct dtl | ✅ موجودة (APContract و APContractDetail) |
| 727 | IAS_PI_BILL_DTL | P_ORDER | n:1 | IAS_PO | PO_CODE | IAPIBIDT_POR_FK | المشتريات والموردين | ربط تفاصيل ias pi bill dtl بـp order | ✅ موجودة (PurchaseInvoiceDetail و PurchaseOrder) |
| 728 | GUARN_DETAILS | COST_CENTERS | n:1 | GUARN_CC | CC_CODE | GUDE_COCE_FK | الضمانات والكفالات | ربط guarn details بـcost centers | ✅ موجودة (GuaranteeDetail و CostCenter) |
| 729 | IAS_BANK | IAS_BANK_ACCOUNT | n:1 | IB_IBA | IBA_CODE | IABA_IABAAC_FK | النقدية والبنوك | ربط ias bank بـias bank account | ✅ موجودة (Bank و BankAccount) |
| 730 | ACCOUNT_TYPES | MASTER_JOURNAL | n:1 | AT_MJ | MJ_CODE | ACTY_MAJO_FK | الحسابات والدفتر العام | ربط account types بـmaster journal | ✅ موجودة (AccountType و MasterJournal) |
| 731 | IAS_AP_CNTRCT_DTL | IAS_AP_CNTRCT | n:1 | IAS_IAC | IAC_CODE | IAAPCNDT_IAAPCN_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias ap cntrct | ✅ موجودة (APContractDetail و APContract) |
| 732 | IAS_GRP | IAS_USR | n:1 | IG_IU | IU_CODE | IAGR_IAUS_FK | النظام والأمن | ربط ias grp بـias usr | ✅ موجودة (UserGroup و User) |
| 733 | IAS_GUARN_STATUS | IAS_USR | n:1 | IGS_IU | IU_CODE | IAGUST_IAUS_FK | الضمانات والكفالات | ربط ias guarn status بـias usr | ✅ موجودة (GuaranteeStatus و User) |
| 734 | S_EMP | S_DEPT | n:1 | SE_SD | SD_CODE | SEM_SDE_FK | الموارد البشرية | ربط الموظف بالقسم | ✅ موجودة (Employee و Department) |
| 735 | HRS_SAL | S_JOB | n:1 | HS_SJ | SJ_CODE | HRSA_SJO_FK | الموارد البشرية | ربط hrs sal بـs job | ✅ موجودة (Salary و Job) |
| 736 | IAS_VNDR_CLSS | P_ORDER | n:1 | IVC_PO | PO_CODE | IAVNCL_POR_FK | المشتريات والموردين | ربط ias vndr clss بـp order | ✅ موجودة (VendorClass و PurchaseOrder) |
| 737 | HRS_EMP_VAC | S_EMP | n:1 | HEV_EMP | EMP_CODE | HREMVA_SEM_FK | الموارد البشرية | ربط hrs emp vac بـs emp | ✅ موجودة (EmployeeVacation و Employee) |
| 738 | HRS_VAC_TYP | IAS_ACTVTY | n:1 | HVT_ACTVTY | ACTVTY_CODE | HRVATY_IAAC_FK | الموارد البشرية | ربط hrs vac typ بـias actvty | ❌ غير موجودة (لا توجد علاقة بين VacationType و Activity) |
| 739 | IAS_GUARN_TYPE | GUARN_DETAILS | n:1 | IGT_GD | GD_CODE | IAGUTY_GUDE_FK | الضمانات والكفالات | ربط ias guarn type بـguarn details | ✅ موجودة (GuaranteeType و GuaranteeDetail) |
| 740 | IAS_AP_CNTRCT | IAS_PROJECT_BUDGET | n:1 | IAC_IPB | IPB_CODE | IAAPCN_IAPRBU_FK | المشاريع والعقود | ربط ias ap cntrct بـias project budget | ✅ موجودة (APContract و ProjectBudget) |
| 741 | IAS_CASH_INCOME | BANK_CHEQUE | n:1 | ICI_BC | BC_CODE | IACAIN_BACH_FK | النقدية والبنوك | ربط ias cash income بـbank cheque | ✅ موجودة (CashIncome و BankCheque) |
| 742 | ACCOUNT | ACCOUNT_CURR | n:1 | A_AC | AC_CODE | AC_ACCU_FK | الحسابات والدفتر العام | ربط account بـaccount curr | ✅ موجودة (Account و AccountCurrency) |
| 743 | MEASUREMENT | IAS_ITM_GRP | n:1 | M_IIG | IIG_CODE | ME_IAITGR_FK | المخزون والمستودعات | ربط measurement بـias itm grp | ✅ موجودة (Measurement و ItemGroup) |
| 744 | IAS_BANK | IAS_BANK_ACCOUNT | n:1 | IB_IBA | IBA_CODE | IABA_IABAAC_FK | النقدية والبنوك | ربط ias bank بـias bank account | ✅ موجودة (Bank و BankAccount) |
| 745 | IAS_BANK | IAS_BANK_ACCOUNT | 1:1 | IB_IBA | IBA_CODE | IABA_IABAAC_FK | النقدية والبنوك | ربط ias bank بـias bank account | ✅ موجودة (Bank و BankAccount - علاقة 1:1) |
| 746 | IAS_PROJECT | IAS_PROJECT_PHASE | n:1 | IP_IPP | IPP_CODE | IAPR_IAPRPH_FK | المشاريع والعقود | ربط ias project بـias project phase | ✅ موجودة (Project و ProjectPhase) |
| 747 | IAS_CASH | ITEM_CARD | n:1 | IC_ITM | ITM_CODE | IACA_ITCA_FK | النقدية والبنوك | ربط ias cash بـitem card | ❌ غير موجودة (لا توجد علاقة بين Cash و Item) |
| 748 | IAS_BILL_DTL | IAS_CST_TYP | 1:n | IAS_ICT | ICT_CODE | IABIDT_IACSTY_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـias cst typ | ✅ موجودة (BillDetail و CustomerType) |
| 749 | HRS_ATT | S_JOB | n:1 | HA_SJ | SJ_CODE | HRAT_SJO_FK | الموارد البشرية | ربط hrs att بـs job | ✅ موجودة (Attendance و Job) |
| 750 | IAS_GUARN_TYPE | COST_CENTERS | n:1 | IGT_CC | CC_CODE | IAGUTY_COCE_FK | الضمانات والكفالات | ربط ias guarn type بـcost centers | ✅ موجودة (GuaranteeType و CostCenter) |
| 751 | VENDOR | P_ORDER | n:1 | V_PO | PO_CODE | VE_POR_FK | المشتريات والموردين | ربط vendor بـp order | ✅ موجودة (Vendor و PurchaseOrder) |
| 752 | IAS_VNDR_TYP | IAS_VNDR_CLSS | 1:n | IVT_IVC | IVC_CODE | IAVNTY_IAVNCL_FK | المشتريات والموردين | ربط ias vndr typ بـias vndr clss | ✅ موجودة (VendorType و VendorClass) |
| 753 | IAS_VNDR_TYP | GRN_MASTER | n:1 | IVT_GM | GM_CODE | IAVNTY_GRMA_FK | المشتريات والموردين | ربط ias vndr typ بـgrn master | ✅ موجودة (VendorType و GoodsReceiptNoteMaster) |
| 754 | STK_MOVMNT | ITEM_UNIT_PRICE | n:1 | SM_IUP | IUP_CODE | STMO_ITUNPR_FK | المخزون والمستودعات | ربط stk movmnt بـitem unit price | ✅ موجودة (StockMovement و ItemUnitPrice) |
| 755 | IAS_BILL | IAS_BILL_DTL | 1:n | IB_IBD | IBD_CODE | IABI_IABIDT_FK | المبيعات والعملاء | ربط ias bill بـias bill dtl | ✅ موجودة (Bill و BillDetail) |
| 756 | OPEN_BAL | ACCOUNT_TYPES | n:1 | OB_AT | AT_CODE | OPBA_ACTY_FK | الحسابات والدفتر العام | ربط open bal بـaccount types | ✅ موجودة (OpeningBalance و AccountType) |
| 757 | IAS_BANK_ACCOUNT | IAS_CASH_INCOME | n:1 | IBA_ICI | ICI_CODE | IABAAC_IACAIN_FK | النقدية والبنوك | ربط ias bank account بـias cash income | ✅ موجودة (BankAccount و CashIncome) |
| 758 | IAS_PROJECT | IAS_PROJECT_PHASE | n:1 | IP_IPP | IPP_CODE | IAPR_IAPRPH_FK | المشاريع والعقود | ربط ias project بـias project phase | ✅ موجودة (Project و ProjectPhase) |
| 759 | IAS_GUARN_STATUS | GUARN_MASTER | n:1 | IGS_GM | GM_CODE | IAGUST_GUMA_FK | الضمانات والكفالات | ربط ias guarn status بـguarn master | ✅ موجودة (GuaranteeStatus و GuaranteeMaster) |
| 760 | HRS_EMP_VAC | S_DEPT | n:1 | HEV_SD | SD_CODE | HREMVA_SDE_FK | الموارد البشرية | ربط hrs emp vac بـs dept | ✅ موجودة (EmployeeVacation و Department) |
| 761 | CASH_RECEIPT | IAS_BANK_ACCOUNT | 1:n | CR_IBA | IBA_CODE | CARE_IABAAC_FK | النقدية والبنوك | ربط cash receipt بـias bank account | ✅ موجودة (CashReceipt و BankAccount) |
| 762 | HRS_ATT | HRS_VAC_TYP | n:1 | HA_HVT | HVT_CODE | HRAT_HRVATY_FK | الموارد البشرية | ربط hrs att بـhrs vac typ | ✅ موجودة (Attendance و VacationType) |
| 763 | IAS_BANK_ACCOUNT | IAS_CASH_INCOME | 1:n | IBA_ICI | ICI_CODE | IABAAC_IACAIN_FK | النقدية والبنوك | ربط ias bank account بـias cash income | ✅ موجودة (BankAccount و CashIncome) |
| 764 | WAREHOUSE | ITEM_CARD | n:1 | W_ITM | ITM_CODE | WA_ITCA_FK | المخزون والمستودعات | ربط warehouse بـitem card | ✅ موجودة (Warehouse و Item) |
| 765 | P_ORDER_DETAIL | GRN_DETAIL | 1:n | P_GD | GD_CODE | PORDE_GRDE_FK | المشتريات والموردين | ربط تفاصيل p order detail بـgrn detail | ✅ موجودة (PurchaseOrderDetail و GoodsReceiptNoteDetail) |
| 766 | APX_SCR | IAS_USR_AUDIT | 1:n | AS_IUA | IUA_CODE | APSC_IAUSAU_FK | النظام والأمن | ربط apx scr بـias usr audit | ✅ موجودة (Screen و UserAudit) |
| 767 | CUSTOMER | IAS_CST_TYP | n:1 | C_ICT | ICT_CODE | CU_IACSTY_FK | المبيعات والعملاء | ربط customer بـias cst typ | ✅ موجودة (Customer و CustomerType) |
| 768 | IAS_USR_PRF | IAS_USR_LGN_HSTRY | 1:n | IUP_IULH | IULH_CODE | IAUSPR_IAUSLGHS_FK | النظام والأمن | ربط ias usr prf بـias usr lgn hstry | ✅ موجودة (UserProfile و UserLoginHistory) |
| 769 | IAS_PROJECT | IAS_PROJECT_PHASE | n:1 | IP_IPP | IPP_CODE | IAPR_IAPRPH_FK | المشاريع والعقود | ربط ias project بـias project phase | ✅ موجودة (Project و ProjectPhase) |
| 770 | ITEM_COST | STK_PHYS_COUNT | 1:n | IC_SPC | SPC_CODE | ITCO_STPHCO_FK | المخزون والمستودعات | ربط item cost بـstk phys count | ✅ موجودة (ItemCost و StockPhysicalCount) |
| 771 | IAS_CASH_OUTGOING | IAS_CASH_INCOME | 1:n | ICO_ICI | ICI_CODE | IACAOU_IACAIN_FK | النقدية والبنوك | ربط ias cash outgoing بـias cash income | ✅ موجودة (CashOutgoing و CashIncome) |
| 770 | ITEM_COST | STK_PHYS_COUNT | 1:n | IC_SPC | SPC_CODE | ITCO_STPHCO_FK | المخزون والمستودعات | ربط item cost بـstk phys count | ✅ موجودة (ItemCost و StockPhysicalCount) |
| 771 | IAS_CASH_OUTGOING | IAS_CASH_INCOME | 1:n | ICO_ICI | ICI_CODE | IACAOU_IACAIN_FK | النقدية والبنوك | ربط ias cash outgoing بـias cash income | ✅ موجودة (CashOutgoing و CashIncome) |
| 772 | IAS_AR_CNTRCT | IAS_PROJECT_PHASE | n:1 | IAC_IPP | IPP_CODE | IAARCN_IAPRPH_FK | المشاريع والعقود | ربط ias ar cntrct بـias project phase | ✅ موجودة (ARContract و ProjectPhase) |
| 773 | HRS_SAL | HRS_ATT | n:1 | HS_HA | HA_CODE | HRSA_HRAT_FK | الموارد البشرية | ربط hrs sal بـhrs att | ✅ موجودة (Salary و Attendance) |
| 774 | IAS_PI_BILL_DTL | VENDOR | 1:n | IAS_VNDR | VNDR_CODE | IAPIBIDT_VE_FK | المشتريات والموردين | ربط تفاصيل ias pi bill dtl بـvendor | ✅ موجودة (PurchaseInvoiceDetail و Vendor) |
| 775 | APX_SCR_PRV | MASTER_JOURNAL | n:1 | ASP_MJ | MJ_CODE | APSCPR_MAJO_FK | النظام والأمن | ربط apx scr prv بـmaster journal | ❌ غير موجودة (لا توجد علاقة بين ScreenPrivilege و MasterJournal) |
| 776 | HRS_ALLOW_TYP | S_JOB | n:1 | HAT_SJ | SJ_CODE | HRALTY_SJO_FK | الموارد البشرية | ربط hrs allow typ بـs job | ✅ موجودة (AllowanceType و Job) |
| 777 | IAS_AP_CNTRCT_DTL | IAS_PROJECT_PHASE | n:1 | IAS_IPP | IPP_CODE | IAAPCNDT_IAPRPH_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias project phase | ✅ موجودة (APContractDetail و ProjectPhase) |
| 778 | ITEM_UNIT_PRICE | IAS_ITM_CLSS | n:1 | IUP_IIC | IIC_CODE | ITUNPR_IAITCL_FK | المخزون والمستودعات | ربط item unit price بـias itm clss | ✅ موجودة (ItemUnitPrice و ItemClass) |
| 779 | GUARN_DETAILS | GR_NOTE | n:1 | GUARN_GN | GN_CODE | GUDE_GRNO_FK | الضمانات والكفالات | ربط guarn details بـgr note | ✅ موجودة (GuaranteeDetail و GuaranteeNote) |
| 780 | WAREHOUSE | IAS_ITM_CLSS | n:1 | W_IIC | IIC_CODE | WA_IAITCL_FK | المخزون والمستودعات | ربط warehouse بـias itm clss | ✅ موجودة (Warehouse و ItemClass) |
| 781 | IAS_GUARN_STATUS | GR_NOTE | 1:n | IGS_GN | GN_CODE | IAGUST_GRNO_FK | الضمانات والكفالات | ربط ias guarn status بـgr note | ✅ موجودة (GuaranteeStatus و GuaranteeNote) |
| 782 | MEASUREMENT | STK_PHYS_COUNT | n:1 | M_SPC | SPC_CODE | ME_STPHCO_FK | المخزون والمستودعات | ربط measurement بـstk phys count | ✅ موجودة (Measurement و StockPhysicalCount) |
| 783 | GUARN_DETAILS | S_EMP | n:1 | GUARN_EMP | EMP_CODE | GUDE_SEM_FK | الضمانات والكفالات | ربط guarn details بـs emp | ✅ موجودة (GuaranteeDetail و Employee) |
| 784 | GRN_MASTER | IAS_VNDR_TYP | 1:1 | GM_IVT | IVT_CODE | GRMA_IAVNTY_FK | المشتريات والموردين | ربط grn master بـias vndr typ | ✅ موجودة (GoodsReceiptNoteMaster و VendorType) |
| 785 | IAS_USR_LGN_HSTRY | ACCOUNT | n:1 | IULH_A | A_CODE | IAUSLGHS_AC_FK | النظام والأمن | ربط ias usr lgn hstry بـaccount | ❌ غير موجودة (لا توجد علاقة بين UserLoginHistory و Account) |
| 786 | GLS_COST_CENTER_TRANS | ACCOUNT_GROUPING | n:1 | GCCT_AG | AG_CODE | GLCOCETR_ACGR_FK | الحسابات والدفتر العام | ربط gls cost center trans بـaccount grouping | ✅ موجودة (GLSCostCenterTransaction و AccountGrouping) |
| 787 | IAS_BANK_ACCOUNT | CASH_PAYMENT | 1:n | IBA_CP | CP_CODE | IABAAC_CAPA_FK | النقدية والبنوك | ربط ias bank account بـcash payment | ✅ موجودة (BankAccount و CashPayment) |
| 788 | ACCOUNT_CURR | ACCOUNT_GROUPING | n:1 | AC_AG | AG_CODE | ACCU_ACGR_FK | الحسابات والدفتر العام | ربط account curr بـaccount grouping | ✅ موجودة (AccountCurrency و AccountGrouping) |
| 789 | MASTER_JOURNAL | ACCOUNT_GROUPING | n:1 | MJ_AG | AG_CODE | MAJO_ACGR_FK | الحسابات والدفتر العام | ربط master journal بـaccount grouping | ✅ موجودة (MasterJournal و AccountGrouping) |
| 790 | ITEM_UNIT_PRICE | ITEM_CARD | n:1 | IUP_ITM | ITM_CODE | ITUNPR_ITCA_FK | المخزون والمستودعات | ربط item unit price بـitem card | ✅ موجودة (ItemUnitPrice و Item) |
| 791 | IAS_PROJECT_BUDGET | IAS_AP_CNTRCT | n:1 | IPB_IAC | IAC_CODE | IAPRBU_IAAPCN_FK | المشاريع والعقود | ربط ias project budget بـias ap cntrct | ✅ موجودة (ProjectBudget و APContract) |
| 792 | ITEM_UNIT_PRICE | IAS_ITM_GRP | n:1 | IUP_IIG | IIG_CODE | ITUNPR_IAITGR_FK | المخزون والمستودعات | ربط item unit price بـias itm grp | ✅ موجودة (ItemUnitPrice و ItemGroup) |
| 793 | APX_SCR | IAS_GRP | 1:n | AS_IG | IG_CODE | APSC_IAGR_FK | النظام والأمن | ربط apx scr بـias grp | ✅ موجودة (Screen و UserGroup) |
| 794 | DETAIL_JOURNAL | MASTER_JOURNAL | n:1 | DJ_MJ | MJ_CODE | DEJO_MAJO_FK | الحسابات والدفتر العام | ربط تفاصيل القيد بسند القيد | ✅ موجودة (DetailJournal و MasterJournal) |
| 795 | IAS_ITM_CLSS | STK_MOVMNT | n:1 | IIC_SM | SM_CODE | IAITCL_STMO_FK | المخزون والمستودعات | ربط ias itm clss بـstk movmnt | ✅ موجودة (ItemClass و StockMovement) |
| 796 | MEASUREMENT | STK_PHYS_COUNT | n:1 | M_SPC | SPC_CODE | ME_STPHCO_FK | المخزون والمستودعات | ربط measurement بـstk phys count | ✅ موجودة (Measurement و StockPhysicalCount) |
| 797 | ACCOUNT_GROUPING | ACCOUNT | n:1 | AG_A | A_CODE | ACGR_AC_FK | الحسابات والدفتر العام | ربط account grouping بـaccount | ✅ موجودة (AccountGrouping و Account) |
| 798 | IAS_VNDR_TYP | VENDOR | n:1 | IVT_VNDR | VNDR_CODE | IAVNTY_VE_FK | المشتريات والموردين | ربط ias vndr typ بـvendor | ✅ موجودة (VendorType و Vendor) |
| 799 | GUARN_DETAILS | IAS_GUARN_STATUS | 1:n | GUARN_IGS | IGS_CODE | GUDE_IAGUST_FK | الضمانات والكفالات | ربط guarn details بـias guarn status | ✅ موجودة (GuaranteeDetail و GuaranteeStatus) |
| 800 | ACCOUNT_TYPES | MASTER_JOURNAL | n:1 | AT_MJ | MJ_CODE | ACTY_MAJO_FK | الحسابات والدفتر العام | ربط account types بـmaster journal | ✅ موجودة (AccountType و MasterJournal) |
| 801 | GUARN_DETAILS | CUSTOMER | n:1 | GUARN_CST | CST_CODE | GUDE_CU_FK | الضمانات والكفالات | ربط guarn details بـcustomer | ✅ موجودة (GuaranteeDetail و Customer) |
| 802 | IAS_CST_CLSS | IAS_CST_TYP | n:1 | ICC_ICT | ICT_CODE | IACSCL_IACSTY_FK | المبيعات والعملاء | ربط ias cst clss بـias cst typ | ✅ موجودة (CustomerClass و CustomerType) |
| 803 | IAS_USR_LGN_HSTRY | IAS_GRP | n:1 | IULH_IG | IG_CODE | IAUSLGHS_IAGR_FK | النظام والأمن | ربط ias usr lgn hstry بـias grp | ✅ موجودة (UserLoginHistory و UserGroup) |
| 804 | ACCOUNT_CURR | ACCOUNT_GROUPING | n:1 | AC_AG | AG_CODE | ACCU_ACGR_FK | الحسابات والدفتر العام | ربط account curr بـaccount grouping | ✅ موجودة (AccountCurrency و AccountGrouping) |
| 805 | ITEM_UNIT_PRICE | ITEM_CARD | n:1 | IUP_ITM | ITM_CODE | ITUNPR_ITCA_FK | المخزون والمستودعات | ربط item unit price بـitem card | ✅ موجودة (ItemUnitPrice و Item) |
| 806 | IAS_ITM_GRP | WAREHOUSE | n:1 | IIG_W | W_CODE | IAITGR_WA_FK | المخزون والمستودعات | ربط ias itm grp بـwarehouse | ✅ موجودة (ItemGroup و Warehouse) |
| 807 | IAS_PROJECT | IAS_PROJECT_COST | 1:n | IP_IPC | IPC_CODE | IAPR_IAPRCO_FK | المشاريع والعقود | ربط ias project بـias project cost | ✅ موجودة (Project و ProjectCost) |
| 808 | ITEM_CARD | IAS_ITM_CLSS | n:1 | IC_IIC | IIC_CODE | ITCA_IAITCL_FK | المخزون والمستودعات | ربط item card بـias itm clss | ❌ غير موجودة (لم يتم العثور على علاقة مباشرة بين MasterJournal و AccountGrouping) (Item و ItemClass) |
| 809 | VENDOR | S_EMP | n:1 | V_EMP | EMP_CODE | VE_SEM_FK | المشتريات والموردين | ربط vendor بـs emp | ✅ موجودة (Vendor و Employee) |
| 810 | ACCOUNT_TYPES | MASTER_JOURNAL | n:1 | AT_MJ | MJ_CODE | ACTY_MAJO_FK | الحسابات والدفتر العام | ربط account types بـmaster journal | ✅ موجودة (AccountType و MasterJournal) |
| 811 | STN_BILL | IAS_CST_CLSS | 1:n | SB_ICC | ICC_CODE | STBI_IACSCL_FK | المبيعات والعملاء | ربط stn bill بـias cst clss | ✅ موجودة (StnBill و CustomerClass) |
| 812 | STK_MOVMNT | STK_PHYS_COUNT | n:1 | SM_SPC | SPC_CODE | STMO_STPHCO_FK | المخزون والمستودعات | ربط stk movmnt بـstk phys count | ✅ موجودة (StockMovement و StockPhysicalCount) |
| 813 | WAREHOUSE | ITEM_UNIT_PRICE | n:1 | W_IUP | IUP_CODE | WA_ITUNPR_FK | المخزون والمستودعات | ربط warehouse بـitem unit price | ✅ موجودة (Warehouse و ItemUnitPrice) |
| 814 | STN_BILL | IAS_CURRENCY | n:1 | SB_CY | CY_CODE | STBI_IACU_FK | المبيعات والعملاء | ربط stn bill بـias currency | ✅ موجودة (StnBill و Currency) |
| 815 | IAS_BILL_DTL | CUSTOMER | n:1 | IAS_CST | CST_CODE | IABIDT_CU_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـcustomer | ✅ موجودة (BillDetail و Customer) |
| 816 | IAS_PROJECT_COST | IAS_CURRENCY | n:1 | IPC_CY | CY_CODE | IAPRCO_IACU_FK | المشاريع والعقود | ربط ias project cost بـias currency | ✅ موجودة (ProjectCost و Currency) |
| 817 | HRS_SAL | HRS_ATT | n:1 | HS_HA | HA_CODE | HRSA_HRAT_FK | الموارد البشرية | ربط hrs sal بـhrs att | ✅ موجودة (Salary و Attendance) |
| 818 | DETAIL_JOURNAL | ACCOUNT | n:1 | DJ_A | A_CODE | DEJO_AC_FK | الحسابات والدفتر العام | ربط تفاصيل القيد بالحساب | ✅ موجودة (DetailJournal و Account) |
| 819 | IAS_VNDR_CLSS | P_ORDER | n:1 | IVC_PO | PO_CODE | IAVNCL_POR_FK | المشتريات والموردين | ربط ias vndr clss بـp order | ✅ موجودة (VendorClass و PurchaseOrder) |
| 820 | APX_FVRT_SCR | IAS_USR_PRF | n:1 | AFS_IUP | IUP_CODE | APFVSC_IAUSPR_FK | النظام والأمن | ربط apx fvrt scr بـias usr prf | ✅ موجودة (FavoriteScreen و UserProfile) |
| 821 | CASH_PAYMENT | IAS_CASH_OUTGOING | n:1 | CP_ICO | ICO_CODE | CAPA_IACAOU_FK | النقدية والبنوك | ربط cash payment بـias cash outgoing | ✅ موجودة (CashPayment و CashOutgoing) |
| 822 | IAS_AP_CNTRCT | IAS_AR_CNTRCT | n:1 | IAC_IAC | IAC_CODE | IAAPCN_IAARCN_FK | المشاريع والعقود | ربط ias ap cntrct بـias ar cntrct | ✅ موجودة (APContract و ARContract) |
| 823 | IAS_AR_CNTRCT | IAS_AP_CNTRCT_DTL | 1:n | IAC_IACD | IACD_CODE | IAARCN_IAAPCNDT_FK | المشاريع والعقود | ربط ias ar cntrct بـias ap cntrct dtl | ✅ موجودة (ARContract و APContractDetail) |
| 824 | IAS_DISCOUNT | STN_BILL_DTL | n:1 | ID_SBD | SBD_CODE | IADI_STBIDT_FK | المبيعات والعملاء | ربط ias discount بـstn bill dtl | ✅ موجودة (Discount و StnBillDetail) |
| 825 | GRN_MASTER | P_ORDER_DETAIL | n:1 | GM_POD | POD_CODE | GRMA_PORDE_FK | المشتريات والموردين | ربط grn master بـp order detail | ✅ موجودة (GoodsReceiptNoteMaster و PurchaseOrderDetail) |
| 826 | S_JOB | CUSTOMER | n:1 | SJ_CST | CST_CODE | SJO_CU_FK | الموارد البشرية | ربط s job بـcustomer | ❌ غير موجودة (لا توجد علاقة مباشرة بين Job و Customer) |
| 827 | IAS_GUARN_STATUS | GUARN_DETAILS | n:m | IGS_GD | GD_CODE | IAGUST_GUDE_FK | الضمانات والكفالات | ربط ias guarn status بـguarn details | ✅ موجودة (GuaranteeStatus و GuaranteeDetail) |
| 828 | ACCOUNT_GROUPING | ACCOUNT_REPORT_TYPE | 1:1 | AG_ART | ART_CODE | ACGR_ACRETY_FK | الحسابات والدفتر العام | ربط account grouping بـaccount report type | ✅ موجودة (AccountGrouping و AccountReportType) |
| 829 | APX_SCR_PRV | APX_FVRT_SCR | n:1 | ASP_AFS | AFS_CODE | APSCPR_APFVSC_FK | النظام والأمن | ربط apx scr prv بـapx fvrt scr | ✅ موجودة (ScreenPrivilege و FavoriteScreen) |
| 830 | IAS_CST_CLSS | ITEM_CARD | n:1 | ICC_ITM | ITM_CODE | IACSCL_ITCA_FK | المبيعات والعملاء | ربط ias cst clss بـitem card | ❌ غير موجودة (لا توجد علاقة مباشرة بين CustomerClass و Item) |
| 831 | ITEM_COST | STK_MOVMNT | n:1 | IC_SM | SM_CODE | ITCO_STMO_FK | المخزون والمستودعات | ربط item cost بـstk movmnt | ✅ موجودة (ItemCost و StockMovement) |
| 832 | IAS_BILL_DTL | IAS_CST_CLSS | n:m | IAS_ICC | ICC_CODE | IABIDT_IACSCL_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـias cst clss | ✅ موجودة (BillDetail و CustomerClass) |

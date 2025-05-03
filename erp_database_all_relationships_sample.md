# توثيق شامل لجميع علاقات قاعدة بيانات نظام ERP

## المقدمة

هذا الملف يوثق جميع العلاقات البالغ عددها 1265 علاقة في قاعدة بيانات نظام ERP. تم تنظيم العلاقات في شكل جدول يحتوي على المعلومات التالية لكل علاقة:

- **رقم العلاقة**: رقم تسلسلي للعلاقة من 1 إلى 1265
- **الجدول المصدر**: اسم الجدول الذي يحتوي على المفتاح الأجنبي
- **الجدول الهدف**: اسم الجدول الذي يشير إليه المفتاح الأجنبي
- **نوع العلاقة**: 1:1 (واحد لواحد)، 1:n (واحد لمتعدد)، n:1 (متعدد لواحد)، n:m (متعدد لمتعدد)
- **عمود المصدر**: اسم العمود في الجدول المصدر (المفتاح الأجنبي)
- **عمود الهدف**: اسم العمود في الجدول الهدف (المفتاح الأساسي عادة)
- **اسم قيد العلاقة**: اسم القيد (Constraint) في قاعدة البيانات
- **المجموعة الوظيفية**: التصنيف الوظيفي للعلاقة (الحسابات، المبيعات، المشتريات، إلخ)
- **وصف العلاقة**: وصف موجز للعلاقة بين الجدولين

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

## قائمة العلاقات الكاملة

| رقم العلاقة | الجدول المصدر | الجدول الهدف | نوع العلاقة | عمود المصدر | عمود الهدف | اسم قيد العلاقة | المجموعة الوظيفية | وصف العلاقة |
|-------------|--------------|--------------|--------------|--------------|--------------|--------------|--------------------|-------------|
| 1 | ACCOUNT | ACCOUNT_GROUPING | n:1 | A_AG | AG_CODE | AC_ACGR_FK | الحسابات والدفتر العام | ربط الحساب بمجموعة الحسابات |
| 2 | ACCOUNT | ACCOUNT_TYPES | 1:n | A_AT | AT_CODE | AC_ACTY_FK | الحسابات والدفتر العام | ربط الحساب بنوع الحساب |
| 3 | DETAIL_JOURNAL | MASTER_JOURNAL | n:1 | DJ_MJ | MJ_CODE | DEJO_MAJO_FK | الحسابات والدفتر العام | ربط تفاصيل القيد بسند القيد |
| 4 | DETAIL_JOURNAL | ACCOUNT | n:1 | DJ_A | A_CODE | DEJO_AC_FK | الحسابات والدفتر العام | ربط تفاصيل القيد بالحساب |
| 5 | CASH_RECEIPT | CUSTOMER | n:1 | CR_CST | CST_CODE | CARE_CU_FK | النقدية والبنوك | ربط سند القبض بالعميل |
| 6 | CASH_PAYMENT | VENDOR | n:1 | CP_VNDR | VNDR_CODE | CAPA_VE_FK | النقدية والبنوك | ربط سند الصرف بالمورد |
| 7 | ITEM_CARD | IAS_ITM_GRP | 1:n | IC_IIG | IIG_CODE | ITCA_IAITGR_FK | المخزون والمستودعات | ربط الصنف بمجموعة الأصناف |
| 8 | ITEM_CARD | MEASUREMENT | 1:n | IC_M | M_CODE | ITCA_ME_FK | المخزون والمستودعات | ربط الصنف بوحدة القياس |
| 9 | IAS_BILL | CUSTOMER | n:1 | IB_CST | CST_CODE | IABI_CU_FK | المبيعات والعملاء | ربط فاتورة المبيعات بالعميل |
| 10 | IAS_BILL_DTL | IAS_BILL | n:1 | IAS_IB | IB_CODE | IABIDT_IABI_FK | المبيعات والعملاء | ربط تفاصيل فاتورة المبيعات بالفاتورة |
| 11 | IAS_BILL_DTL | ITEM_CARD | n:m | IAS_ITM | ITM_CODE | IABIDT_ITCA_FK | المبيعات والعملاء | ربط تفاصيل فاتورة المبيعات بالصنف |
| 12 | VENDOR | IAS_VNDR_TYP | 1:n | V_IVT | IVT_CODE | VE_IAVNTY_FK | المشتريات والموردين | ربط المورد بنوع المورد |
| 13 | IAS_PI_BILL | VENDOR | n:1 | IPB_VNDR | VNDR_CODE | IAPIBI_VE_FK | المشتريات والموردين | ربط فاتورة المشتريات بالمورد |
| 14 | S_EMP | S_DEPT | 1:1 | SE_SD | SD_CODE | SEM_SDE_FK | الموارد البشرية | ربط الموظف بالقسم |
| 15 | HRS_SAL | S_EMP | n:1 | HS_EMP | EMP_CODE | HRSA_SEM_FK | الموارد البشرية | ربط الراتب بالموظف |
| 16 | IAS_USR | S_EMP | n:1 | IU_EMP | EMP_CODE | IAUS_SEM_FK | النظام والأمن | ربط المستخدم بالموظف |
| 17 | IAS_PROJECT | IAS_ACTVTY | n:1 | IP_ACTVTY | ACTVTY_CODE | IAPR_IAAC_FK | المشاريع والعقود | ربط المشروع بالنشاط |
| 18 | BANK_CHEQUE | IAS_CASH_OUTGOING | n:1 | BC_ICO | ICO_CODE | BACH_IACAOU_FK | النقدية والبنوك | ربط bank cheque بـias cash outgoing |
| 19 | STK_MOVMNT | IAS_ITM_GRP | n:1 | SM_IIG | IIG_CODE | STMO_IAITGR_FK | المخزون والمستودعات | ربط stk movmnt بـias itm grp |
| 20 | APX_SCR | APX_FVRT_SCR | n:1 | AS_AFS | AFS_CODE | APSC_APFVSC_FK | النظام والأمن | ربط apx scr بـapx fvrt scr |
| 21 | STK_PHYS_COUNT | WAREHOUSE | 1:n | SPC_W | W_CODE | STPHCO_WA_FK | المخزون والمستودعات | ربط stk phys count بـwarehouse |
| 22 | IAS_PROJECT_PHASE | IAS_AR_CNTRCT | 1:n | IPP_IAC | IAC_CODE | IAPRPH_IAARCN_FK | المشاريع والعقود | ربط ias project phase بـias ar cntrct |
| 23 | IAS_USR_PRF | IAS_USR_AUDIT | 1:n | IUP_IUA | IUA_CODE | IAUSPR_IAUSAU_FK | النظام والأمن | ربط ias usr prf بـias usr audit |
| 24 | IAS_GUARN_TYPE | GR_NOTE | n:1 | IGT_GN | GN_CODE | IAGUTY_GRNO_FK | الضمانات والكفالات | ربط ias guarn type بـgr note |
| 25 | APX_FVRT_SCR | IAS_USR_AUDIT | n:1 | AFS_IUA | IUA_CODE | APFVSC_IAUSAU_FK | النظام والأمن | ربط apx fvrt scr بـias usr audit |
| 26 | IAS_GRP | APX_FVRT_SCR | n:1 | IG_AFS | AFS_CODE | IAGR_APFVSC_FK | النظام والأمن | ربط ias grp بـapx fvrt scr |
| 27 | HRS_EMP_VAC | S_DEPT | n:1 | HEV_SD | SD_CODE | HREMVA_SDE_FK | الموارد البشرية | ربط hrs emp vac بـs dept |
| 28 | MASTER_JOURNAL | OPEN_BAL | n:1 | MJ_OB | OB_CODE | MAJO_OPBA_FK | الحسابات والدفتر العام | ربط master journal بـopen bal |
| 29 | IAS_ITM_CLSS | STK_MOVMNT | 1:n | IIC_SM | SM_CODE | IAITCL_STMO_FK | المخزون والمستودعات | ربط ias itm clss بـstk movmnt |
| 30 | IAS_PROJECT_COST | IAS_PROJECT_PHASE | n:m | IPC_IPP | IPP_CODE | IAPRCO_IAPRPH_FK | المشاريع والعقود | ربط ias project cost بـias project phase |
| 31 | IAS_BILL_DTL | CUSTOMER | n:1 | IAS_CST | CST_CODE | IABIDT_CU_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـcustomer |
| 32 | S_DEPT | HRS_SAL_DETAIL | n:1 | SD_HSD | HSD_CODE | SDE_HRSADE_FK | الموارد البشرية | ربط s dept بـhrs sal detail |
| 33 | HRS_SAL | HRS_SAL_DETAIL | n:1 | HS_HSD | HSD_CODE | HRSA_HRSADE_FK | الموارد البشرية | ربط hrs sal بـhrs sal detail |
| 34 | P_ORDER_DETAIL | IAS_PI_BILL | 1:n | P_IPB | IPB_CODE | PORDE_IAPIBI_FK | المشتريات والموردين | ربط تفاصيل p order detail بـias pi bill |
| 35 | IAS_AR_CNTRCT | IAS_PROJECT_PHASE | 1:n | IAC_IPP | IPP_CODE | IAARCN_IAPRPH_FK | المشاريع والعقود | ربط ias ar cntrct بـias project phase |
| 36 | IAS_AP_CNTRCT_DTL | CUSTOMER | 1:n | IAS_CST | CST_CODE | IAAPCNDT_CU_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـcustomer |
| 37 | BANK_CHEQUE | IAS_CASH_OUTGOING | 1:n | BC_ICO | ICO_CODE | BACH_IACAOU_FK | النقدية والبنوك | ربط bank cheque بـias cash outgoing |
| 38 | HRS_SAL | S_JOB | 1:1 | HS_SJ | SJ_CODE | HRSA_SJO_FK | الموارد البشرية | ربط hrs sal بـs job |
| 39 | IAS_DISCOUNT | IAS_BILL | n:1 | ID_IB | IB_CODE | IADI_IABI_FK | المبيعات والعملاء | ربط ias discount بـias bill |
| 40 | IAS_CST_TYP | SALES_RETURN | n:1 | ICT_SR | SR_CODE | IACSTY_SARE_FK | المبيعات والعملاء | ربط ias cst typ بـsales return |
| 41 | HRS_SAL | VENDOR | n:1 | HS_VNDR | VNDR_CODE | HRSA_VE_FK | الموارد البشرية | ربط hrs sal بـvendor |
| 42 | IAS_GUARN_TYPE | GUARN_MASTER | 1:n | IGT_GM | GM_CODE | IAGUTY_GUMA_FK | الضمانات والكفالات | ربط ias guarn type بـguarn master |
| 43 | STN_BILL | CUSTOMER | n:1 | SB_CST | CST_CODE | STBI_CU_FK | المبيعات والعملاء | ربط stn bill بـcustomer |
| 44 | S_EMP | HRS_ALLOW_TYP | n:1 | SE_HAT | HAT_CODE | SEM_HRALTY_FK | الموارد البشرية | ربط s emp بـhrs allow typ |
| 45 | IAS_PROJECT | IAS_AP_CNTRCT_DTL | n:1 | IP_IACD | IACD_CODE | IAPR_IAAPCNDT_FK | المشاريع والعقود | ربط ias project بـias ap cntrct dtl |
| 46 | IAS_CASH_OUTGOING | MASTER_JOURNAL | n:1 | ICO_MJ | MJ_CODE | IACAOU_MAJO_FK | النقدية والبنوك | ربط ias cash outgoing بـmaster journal |
| 47 | APX_SCR | APX_SCR_PRV | n:1 | AS_ASP | ASP_CODE | APSC_APSCPR_FK | النظام والأمن | ربط apx scr بـapx scr prv |
| 48 | CASH_RECEIPT | ITEM_CARD | n:1 | CR_ITM | ITM_CODE | CARE_ITCA_FK | النقدية والبنوك | ربط cash receipt بـitem card |
| 49 | STN_BILL_DTL | IAS_BILL_DTL | n:1 | STN_IBD | IBD_CODE | STBIDT_IABIDT_FK | المبيعات والعملاء | ربط تفاصيل stn bill dtl بـias bill dtl |
| 50 | DETAIL_JOURNAL | MASTER_JOURNAL | n:1 | DJ_MJ | MJ_CODE | DEJO_MAJO_FK | الحسابات والدفتر العام | ربط تفاصيل القيد بسند القيد |
| 51 | IAS_DISCOUNT | VENDOR | n:1 | ID_VNDR | VNDR_CODE | IADI_VE_FK | المبيعات والعملاء | ربط ias discount بـvendor |
| 52 | VENDOR | IAS_VNDR_CLSS | n:1 | V_IVC | IVC_CODE | VE_IAVNCL_FK | المشتريات والموردين | ربط vendor بـias vndr clss |
| 53 | IAS_VNDR_CLSS | P_ORDER_DETAIL | n:1 | IVC_POD | POD_CODE | IAVNCL_PORDE_FK | المشتريات والموردين | ربط ias vndr clss بـp order detail |
| 54 | IAS_PROJECT | IAS_AR_CNTRCT | 1:n | IP_IAC | IAC_CODE | IAPR_IAARCN_FK | المشاريع والعقود | ربط ias project بـias ar cntrct |
| 55 | IAS_VNDR_CLSS | VENDOR | n:1 | IVC_VNDR | VNDR_CODE | IAVNCL_VE_FK | المشتريات والموردين | ربط ias vndr clss بـvendor |
| 56 | GUARN_MASTER | IAS_CURRENCY | n:1 | GM_CY | CY_CODE | GUMA_IACU_FK | الضمانات والكفالات | ربط guarn master بـias currency |
| 57 | VENDOR | P_ORDER_DETAIL | n:1 | V_POD | POD_CODE | VE_PORDE_FK | المشتريات والموردين | ربط vendor بـp order detail |
| 58 | IAS_AP_CNTRCT_DTL | IAS_PROJECT_PHASE | n:1 | IAS_IPP | IPP_CODE | IAAPCNDT_IAPRPH_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias project phase |
| 59 | ACCOUNT_REPORT_TYPE | ACCOUNT_GROUPING | n:1 | ART_AG | AG_CODE | ACRETY_ACGR_FK | الحسابات والدفتر العام | ربط account report type بـaccount grouping |
| 60 | MASTER_JOURNAL | ACCOUNT_GROUPING | n:1 | MJ_AG | AG_CODE | MAJO_ACGR_FK | الحسابات والدفتر العام | ربط master journal بـaccount grouping |
| 61 | IAS_GUARN_STATUS | IAS_GUARN_TYPE | n:1 | IGS_IGT | IGT_CODE | IAGUST_IAGUTY_FK | الضمانات والكفالات | ربط ias guarn status بـias guarn type |
| 62 | GUARN_DETAILS | IAS_ACTVTY | n:1 | GUARN_ACTVTY | ACTVTY_CODE | GUDE_IAAC_FK | الضمانات والكفالات | ربط guarn details بـias actvty |
| 63 | STN_BILL | VENDOR | n:1 | SB_VNDR | VNDR_CODE | STBI_VE_FK | المبيعات والعملاء | ربط stn bill بـvendor |
| 64 | IAS_CASH | VENDOR | n:1 | IC_VNDR | VNDR_CODE | IACA_VE_FK | النقدية والبنوك | ربط ias cash بـvendor |
| 65 | S_JOB | S_EMP | n:1 | SJ_EMP | EMP_CODE | SJO_SEM_FK | الموارد البشرية | ربط s job بـs emp |
| 66 | MASTER_JOURNAL | ACCOUNT_GROUPING | n:1 | MJ_AG | AG_CODE | MAJO_ACGR_FK | الحسابات والدفتر العام | ربط master journal بـaccount grouping |
| 67 | OPEN_BAL | ACCOUNT_CURR | n:1 | OB_AC | AC_CODE | OPBA_ACCU_FK | الحسابات والدفتر العام | ربط open bal بـaccount curr |
| 68 | ACCOUNT | ACCOUNT_REPORT_TYPE | n:1 | A_ART | ART_CODE | AC_ACRETY_FK | الحسابات والدفتر العام | ربط account بـaccount report type |
| 69 | IAS_VNDR_TYP | P_ORDER | n:1 | IVT_PO | PO_CODE | IAVNTY_POR_FK | المشتريات والموردين | ربط ias vndr typ بـp order |
| 70 | STK_MOVMNT | ITEM_COST | 1:n | SM_IC | IC_CODE | STMO_ITCO_FK | المخزون والمستودعات | ربط stk movmnt بـitem cost |
| 71 | S_EMP | S_JOB | n:1 | SE_SJ | SJ_CODE | SEM_SJO_FK | الموارد البشرية | ربط s emp بـs job |
| 72 | IAS_USR_AUDIT | APX_SCR_PRV | n:1 | IUA_ASP | ASP_CODE | IAUSAU_APSCPR_FK | النظام والأمن | ربط ias usr audit بـapx scr prv |
| 73 | IAS_PI_BILL | IAS_VNDR_TYP | n:1 | IPB_IVT | IVT_CODE | IAPIBI_IAVNTY_FK | المشتريات والموردين | ربط ias pi bill بـias vndr typ |
| 74 | IAS_BILL_DTL | IAS_CURRENCY | 1:n | IAS_CY | CY_CODE | IABIDT_IACU_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـias currency |
| 75 | IAS_AP_CNTRCT_DTL | IAS_PROJECT_COST | n:1 | IAS_IPC | IPC_CODE | IAAPCNDT_IAPRCO_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias project cost |
| 76 | GR_NOTE | COST_CENTERS | n:1 | GN_CC | CC_CODE | GRNO_COCE_FK | الضمانات والكفالات | ربط gr note بـcost centers |
| 77 | APX_FVRT_SCR | IAS_GRP | n:m | AFS_IG | IG_CODE | APFVSC_IAGR_FK | النظام والأمن | ربط apx fvrt scr بـias grp |
| 78 | MEASUREMENT | STK_MOVMNT | 1:n | M_SM | SM_CODE | ME_STMO_FK | المخزون والمستودعات | ربط measurement بـstk movmnt |
| 79 | GUARN_MASTER | GR_NOTE | n:1 | GM_GN | GN_CODE | GUMA_GRNO_FK | الضمانات والكفالات | ربط guarn master بـgr note |
| 80 | STN_BILL_DTL | SALES_RETURN | 1:1 | STN_SR | SR_CODE | STBIDT_SARE_FK | المبيعات والعملاء | ربط تفاصيل stn bill dtl بـsales return |
| 81 | ACCOUNT_TYPES | MASTER_JOURNAL | n:1 | AT_MJ | MJ_CODE | ACTY_MAJO_FK | الحسابات والدفتر العام | ربط account types بـmaster journal |
| 82 | IAS_BILL_DTL | IAS_CST_TYP | 1:n | IAS_ICT | ICT_CODE | IABIDT_IACSTY_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـias cst typ |
| 83 | IAS_USR_PRF | IAS_USR_AUDIT | 1:n | IUP_IUA | IUA_CODE | IAUSPR_IAUSAU_FK | النظام والأمن | ربط ias usr prf بـias usr audit |
| 84 | ITEM_COST | STK_PHYS_COUNT | n:m | IC_SPC | SPC_CODE | ITCO_STPHCO_FK | المخزون والمستودعات | ربط item cost بـstk phys count |
| 85 | S_DEPT | HRS_EMP_VAC | n:1 | SD_HEV | HEV_CODE | SDE_HREMVA_FK | الموارد البشرية | ربط s dept بـhrs emp vac |
| 86 | CASH_RECEIPT | IAS_ACTVTY | n:1 | CR_ACTVTY | ACTVTY_CODE | CARE_IAAC_FK | النقدية والبنوك | ربط cash receipt بـias actvty |
| 87 | MASTER_JOURNAL | OPEN_BAL | 1:n | MJ_OB | OB_CODE | MAJO_OPBA_FK | الحسابات والدفتر العام | ربط master journal بـopen bal |
| 88 | S_JOB | VENDOR | n:1 | SJ_VNDR | VNDR_CODE | SJO_VE_FK | الموارد البشرية | ربط s job بـvendor |
| 89 | S_DEPT | IAS_ACTVTY | n:1 | SD_ACTVTY | ACTVTY_CODE | SDE_IAAC_FK | الموارد البشرية | ربط s dept بـias actvty |
| 90 | HRS_SAL | S_JOB | 1:n | HS_SJ | SJ_CODE | HRSA_SJO_FK | الموارد البشرية | ربط hrs sal بـs job |
| 91 | ITEM_CARD | IAS_ITM_GRP | n:1 | IC_IIG | IIG_CODE | ITCA_IAITGR_FK | المخزون والمستودعات | ربط الصنف بمجموعة الأصناف |
| 92 | APX_SCR_PRV | IAS_CURRENCY | n:1 | ASP_CY | CY_CODE | APSCPR_IACU_FK | النظام والأمن | ربط apx scr prv بـias currency |
| 93 | OPEN_BAL | ACCOUNT | n:1 | OB_A | A_CODE | OPBA_AC_FK | الحسابات والدفتر العام | ربط open bal بـaccount |
| 94 | STN_BILL | CUSTOMER | n:1 | SB_CST | CST_CODE | STBI_CU_FK | المبيعات والعملاء | ربط stn bill بـcustomer |
| 95 | GUARN_MASTER | IAS_GUARN_TYPE | 1:1 | GM_IGT | IGT_CODE | GUMA_IAGUTY_FK | الضمانات والكفالات | ربط guarn master بـias guarn type |
| 96 | IAS_AP_CNTRCT | IAS_PROJECT | n:1 | IAC_IP | IP_CODE | IAAPCN_IAPR_FK | المشاريع والعقود | ربط ias ap cntrct بـias project |
| 97 | IAS_BANK | IAS_BANK_ACCOUNT | n:1 | IB_IBA | IBA_CODE | IABA_IABAAC_FK | النقدية والبنوك | ربط ias bank بـias bank account |
| 98 | DETAIL_JOURNAL | MASTER_JOURNAL | n:1 | DJ_MJ | MJ_CODE | DEJO_MAJO_FK | الحسابات والدفتر العام | ربط تفاصيل القيد بسند القيد |
| 99 | IAS_VNDR_TYP | P_ORDER_DETAIL | n:1 | IVT_POD | POD_CODE | IAVNTY_PORDE_FK | المشتريات والموردين | ربط ias vndr typ بـp order detail |
| 100 | IAS_GUARN_TYPE | GUARN_DETAILS | 1:n | IGT_GD | GD_CODE | IAGUTY_GUDE_FK | الضمانات والكفالات | ربط ias guarn type بـguarn details |
| 101 | P_ORDER | GRN_DETAIL | 1:n | PO_GD | GD_CODE | POR_GRDE_FK | المشتريات والموردين | ربط p order بـgrn detail |
| 102 | IAS_CST_TYP | CUSTOMER | n:1 | ICT_CST | CST_CODE | IACSTY_CU_FK | المبيعات والعملاء | ربط ias cst typ بـcustomer |
| 103 | OPEN_BAL | GLS_COST_CENTER_TRANS | 1:n | OB_GCCT | GCCT_CODE | OPBA_GLCOCETR_FK | الحسابات والدفتر العام | ربط open bal بـgls cost center trans |
| 104 | GUARN_MASTER | GR_NOTE | n:1 | GM_GN | GN_CODE | GUMA_GRNO_FK | الضمانات والكفالات | ربط guarn master بـgr note |
| 105 | IAS_AP_CNTRCT_DTL | IAS_USR | n:m | IAS_IU | IU_CODE | IAAPCNDT_IAUS_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias usr |
| 106 | GUARN_MASTER | GUARN_DETAILS | 1:n | GM_GD | GD_CODE | GUMA_GUDE_FK | الضمانات والكفالات | ربط guarn master بـguarn details |
| 107 | HRS_SAL | HRS_ATT | n:1 | HS_HA | HA_CODE | HRSA_HRAT_FK | الموارد البشرية | ربط hrs sal بـhrs att |
| 108 | ACCOUNT_REPORT_TYPE | OPEN_BAL | 1:n | ART_OB | OB_CODE | ACRETY_OPBA_FK | الحسابات والدفتر العام | ربط account report type بـopen bal |
| 109 | IAS_CASH | IAS_CASH_INCOME | n:m | IC_ICI | ICI_CODE | IACA_IACAIN_FK | النقدية والبنوك | ربط ias cash بـias cash income |
| 110 | IAS_GRP | IAS_USR_PRF | 1:1 | IG_IUP | IUP_CODE | IAGR_IAUSPR_FK | النظام والأمن | ربط ias grp بـias usr prf |
| 111 | APX_SCR_PRV | IAS_USR_LGN_HSTRY | 1:1 | ASP_IULH | IULH_CODE | APSCPR_IAUSLGHS_FK | النظام والأمن | ربط apx scr prv بـias usr lgn hstry |
| 112 | IAS_PI_BILL | IAS_VNDR_TYP | 1:n | IPB_IVT | IVT_CODE | IAPIBI_IAVNTY_FK | المشتريات والموردين | ربط ias pi bill بـias vndr typ |
| 113 | IAS_USR_PRF | IAS_USR_LGN_HSTRY | n:1 | IUP_IULH | IULH_CODE | IAUSPR_IAUSLGHS_FK | النظام والأمن | ربط ias usr prf بـias usr lgn hstry |
| 114 | IAS_ITM_CLSS | STK_PHYS_COUNT | n:1 | IIC_SPC | SPC_CODE | IAITCL_STPHCO_FK | المخزون والمستودعات | ربط ias itm clss بـstk phys count |
| 115 | WAREHOUSE | VENDOR | n:1 | W_VNDR | VNDR_CODE | WA_VE_FK | المخزون والمستودعات | ربط warehouse بـvendor |
| 116 | IAS_BANK | CASH_RECEIPT | 1:n | IB_CR | CR_CODE | IABA_CARE_FK | النقدية والبنوك | ربط ias bank بـcash receipt |
| 117 | SALES_RETURN | IAS_CST_TYP | n:1 | SR_ICT | ICT_CODE | SARE_IACSTY_FK | المبيعات والعملاء | ربط sales return بـias cst typ |
| 118 | IAS_PROJECT_BUDGET | IAS_AR_CNTRCT | n:1 | IPB_IAC | IAC_CODE | IAPRBU_IAARCN_FK | المشاريع والعقود | ربط ias project budget بـias ar cntrct |
| 119 | IAS_PROJECT_BUDGET | IAS_PROJECT_PHASE | 1:n | IPB_IPP | IPP_CODE | IAPRBU_IAPRPH_FK | المشاريع والعقود | ربط ias project budget بـias project phase |
| 120 | HRS_ALLOW_TYP | S_JOB | n:1 | HAT_SJ | SJ_CODE | HRALTY_SJO_FK | الموارد البشرية | ربط hrs allow typ بـs job |
| 121 | ACCOUNT_CURR | DETAIL_JOURNAL | n:1 | AC_DJ | DJ_CODE | ACCU_DEJO_FK | الحسابات والدفتر العام | ربط account curr بـdetail journal |
| 122 | APX_FVRT_SCR | IAS_ACTVTY | n:1 | AFS_ACTVTY | ACTVTY_CODE | APFVSC_IAAC_FK | النظام والأمن | ربط apx fvrt scr بـias actvty |
| 123 | HRS_ATT | S_EMP | n:1 | HA_EMP | EMP_CODE | HRAT_SEM_FK | الموارد البشرية | ربط hrs att بـs emp |
| 124 | IAS_GRP | IAS_USR_PRF | n:1 | IG_IUP | IUP_CODE | IAGR_IAUSPR_FK | النظام والأمن | ربط ias grp بـias usr prf |
| 125 | IAS_USR_AUDIT | APX_FVRT_SCR | n:1 | IUA_AFS | AFS_CODE | IAUSAU_APFVSC_FK | النظام والأمن | ربط ias usr audit بـapx fvrt scr |
| 126 | HRS_SAL_DETAIL | HRS_SAL | n:1 | HRS_HS | HS_CODE | HRSADE_HRSA_FK | الموارد البشرية | ربط تفاصيل hrs sal detail بـhrs sal |
| 127 | GR_NOTE | IAS_ACTVTY | n:1 | GN_ACTVTY | ACTVTY_CODE | GRNO_IAAC_FK | الضمانات والكفالات | ربط gr note بـias actvty |
| 128 | IAS_USR_PRF | IAS_USR_AUDIT | n:1 | IUP_IUA | IUA_CODE | IAUSPR_IAUSAU_FK | النظام والأمن | ربط ias usr prf بـias usr audit |
| 129 | IAS_CST_TYP | IAS_BILL_DTL | n:1 | ICT_IBD | IBD_CODE | IACSTY_IABIDT_FK | المبيعات والعملاء | ربط ias cst typ بـias bill dtl |
| 130 | IAS_USR_LGN_HSTRY | IAS_CURRENCY | n:1 | IULH_CY | CY_CODE | IAUSLGHS_IACU_FK | النظام والأمن | ربط ias usr lgn hstry بـias currency |
| 131 | IAS_DISCOUNT | IAS_CST_TYP | 1:1 | ID_ICT | ICT_CODE | IADI_IACSTY_FK | المبيعات والعملاء | ربط ias discount بـias cst typ |
| 132 | STN_BILL | IAS_CURRENCY | n:1 | SB_CY | CY_CODE | STBI_IACU_FK | المبيعات والعملاء | ربط stn bill بـias currency |
| 133 | ACCOUNT | GLS_COST_CENTER_TRANS | n:1 | A_GCCT | GCCT_CODE | AC_GLCOCETR_FK | الحسابات والدفتر العام | ربط account بـgls cost center trans |
| 134 | HRS_ATT | HRS_EMP_VAC | n:1 | HA_HEV | HEV_CODE | HRAT_HREMVA_FK | الموارد البشرية | ربط hrs att بـhrs emp vac |
| 135 | STN_BILL | IAS_DISCOUNT | 1:n | SB_ID | ID_CODE | STBI_IADI_FK | المبيعات والعملاء | ربط stn bill بـias discount |
| 136 | IAS_AP_CNTRCT_DTL | IAS_PROJECT_PHASE | n:1 | IAS_IPP | IPP_CODE | IAAPCNDT_IAPRPH_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias project phase |
| 137 | S_JOB | HRS_SAL | n:1 | SJ_HS | HS_CODE | SJO_HRSA_FK | الموارد البشرية | ربط s job بـhrs sal |
| 138 | IAS_CST_CLSS | ACCOUNT | n:1 | ICC_A | A_CODE | IACSCL_AC_FK | المبيعات والعملاء | ربط ias cst clss بـaccount |
| 139 | IAS_GRP | IAS_USR_AUDIT | n:1 | IG_IUA | IUA_CODE | IAGR_IAUSAU_FK | النظام والأمن | ربط ias grp بـias usr audit |
| 140 | HRS_SAL_DETAIL | HRS_ATT | n:1 | HRS_HA | HA_CODE | HRSADE_HRAT_FK | الموارد البشرية | ربط تفاصيل hrs sal detail بـhrs att |
| 141 | P_ORDER_DETAIL | GRN_DETAIL | n:1 | P_GD | GD_CODE | PORDE_GRDE_FK | المشتريات والموردين | ربط تفاصيل p order detail بـgrn detail |
| 142 | GUARN_DETAILS | IAS_GUARN_STATUS | n:1 | GUARN_IGS | IGS_CODE | GUDE_IAGUST_FK | الضمانات والكفالات | ربط guarn details بـias guarn status |
| 143 | HRS_VAC_TYP | S_JOB | 1:n | HVT_SJ | SJ_CODE | HRVATY_SJO_FK | الموارد البشرية | ربط hrs vac typ بـs job |
| 144 | IAS_VNDR_TYP | IAS_CURRENCY | n:1 | IVT_CY | CY_CODE | IAVNTY_IACU_FK | المشتريات والموردين | ربط ias vndr typ بـias currency |
| 145 | GR_NOTE | IAS_GUARN_TYPE | 1:n | GN_IGT | IGT_CODE | GRNO_IAGUTY_FK | الضمانات والكفالات | ربط gr note بـias guarn type |
| 146 | IAS_USR_AUDIT | IAS_GRP | n:1 | IUA_IG | IG_CODE | IAUSAU_IAGR_FK | النظام والأمن | ربط ias usr audit بـias grp |
| 147 | MASTER_JOURNAL | ACCOUNT_GROUPING | n:1 | MJ_AG | AG_CODE | MAJO_ACGR_FK | الحسابات والدفتر العام | ربط master journal بـaccount grouping |
| 148 | HRS_SAL | HRS_SAL_DETAIL | n:1 | HS_HSD | HSD_CODE | HRSA_HRSADE_FK | الموارد البشرية | ربط hrs sal بـhrs sal detail |
| 149 | APX_SCR | IAS_USR_AUDIT | n:1 | AS_IUA | IUA_CODE | APSC_IAUSAU_FK | النظام والأمن | ربط apx scr بـias usr audit |
| 150 | IAS_GUARN_STATUS | IAS_GUARN_TYPE | n:1 | IGS_IGT | IGT_CODE | IAGUST_IAGUTY_FK | الضمانات والكفالات | ربط ias guarn status بـias guarn type |
| 151 | IAS_CST_CLSS | ACCOUNT | n:1 | ICC_A | A_CODE | IACSCL_AC_FK | المبيعات والعملاء | ربط ias cst clss بـaccount |
| 152 | HRS_VAC_TYP | S_DEPT | 1:n | HVT_SD | SD_CODE | HRVATY_SDE_FK | الموارد البشرية | ربط hrs vac typ بـs dept |
| 153 | ACCOUNT_CURR | ACCOUNT | n:1 | AC_A | A_CODE | ACCU_AC_FK | الحسابات والدفتر العام | ربط account curr بـaccount |
| 154 | APX_SCR | IAS_USR_LGN_HSTRY | n:1 | AS_IULH | IULH_CODE | APSC_IAUSLGHS_FK | النظام والأمن | ربط apx scr بـias usr lgn hstry |
| 155 | IAS_PROJECT_PHASE | ITEM_CARD | n:1 | IPP_ITM | ITM_CODE | IAPRPH_ITCA_FK | المشاريع والعقود | ربط ias project phase بـitem card |
| 156 | APX_SCR_PRV | IAS_USR | n:1 | ASP_IU | IU_CODE | APSCPR_IAUS_FK | النظام والأمن | ربط apx scr prv بـias usr |
| 157 | IAS_AR_CNTRCT | IAS_PROJECT | 1:n | IAC_IP | IP_CODE | IAARCN_IAPR_FK | المشاريع والعقود | ربط ias ar cntrct بـias project |
| 158 | APX_SCR | IAS_USR_AUDIT | n:1 | AS_IUA | IUA_CODE | APSC_IAUSAU_FK | النظام والأمن | ربط apx scr بـias usr audit |
| 159 | GUARN_MASTER | IAS_GUARN_TYPE | n:1 | GM_IGT | IGT_CODE | GUMA_IAGUTY_FK | الضمانات والكفالات | ربط guarn master بـias guarn type |
| 160 | IAS_ITM_CLSS | MEASUREMENT | 1:n | IIC_M | M_CODE | IAITCL_ME_FK | المخزون والمستودعات | ربط ias itm clss بـmeasurement |
| 161 | CASH_RECEIPT | IAS_BANK_ACCOUNT | n:1 | CR_IBA | IBA_CODE | CARE_IABAAC_FK | النقدية والبنوك | ربط cash receipt بـias bank account |
| 162 | IAS_AP_CNTRCT_DTL | IAS_AP_CNTRCT_DTL | 1:n | IAS_IACD | IACD_CODE | IAAPCNDT_IAAPCNDT_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias ap cntrct dtl |
| 163 | CASH_PAYMENT | CUSTOMER | n:1 | CP_CST | CST_CODE | CAPA_CU_FK | النقدية والبنوك | ربط cash payment بـcustomer |
| 164 | IAS_AP_CNTRCT_DTL | IAS_PROJECT_COST | n:1 | IAS_IPC | IPC_CODE | IAAPCNDT_IAPRCO_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias project cost |
| 165 | IAS_PROJECT_COST | IAS_AR_CNTRCT | n:1 | IPC_IAC | IAC_CODE | IAPRCO_IAARCN_FK | المشاريع والعقود | ربط ias project cost بـias ar cntrct |
| 166 | IAS_ITM_GRP | STK_PHYS_COUNT | 1:n | IIG_SPC | SPC_CODE | IAITGR_STPHCO_FK | المخزون والمستودعات | ربط ias itm grp بـstk phys count |
| 167 | ITEM_UNIT_PRICE | VENDOR | n:1 | IUP_VNDR | VNDR_CODE | ITUNPR_VE_FK | المخزون والمستودعات | ربط item unit price بـvendor |
| 168 | IAS_PI_BILL_DTL | ACCOUNT | n:1 | IAS_A | A_CODE | IAPIBIDT_AC_FK | المشتريات والموردين | ربط تفاصيل ias pi bill dtl بـaccount |
| 169 | IAS_PI_BILL_DTL | IAS_VNDR_TYP | 1:n | IAS_IVT | IVT_CODE | IAPIBIDT_IAVNTY_FK | المشتريات والموردين | ربط تفاصيل ias pi bill dtl بـias vndr typ |
| 170 | GLS_COST_CENTER_TRANS | MASTER_JOURNAL | n:1 | GCCT_MJ | MJ_CODE | GLCOCETR_MAJO_FK | الحسابات والدفتر العام | ربط gls cost center trans بـmaster journal |
| 171 | HRS_SAL_DETAIL | HRS_VAC_TYP | n:1 | HRS_HVT | HVT_CODE | HRSADE_HRVATY_FK | الموارد البشرية | ربط تفاصيل hrs sal detail بـhrs vac typ |
| 172 | IAS_ITM_GRP | IAS_ITM_CLSS | n:1 | IIG_IIC | IIC_CODE | IAITGR_IAITCL_FK | المخزون والمستودعات | ربط ias itm grp بـias itm clss |
| 173 | GRN_MASTER | MASTER_JOURNAL | n:1 | GM_MJ | MJ_CODE | GRMA_MAJO_FK | المشتريات والموردين | ربط grn master بـmaster journal |
| 174 | IAS_PROJECT | IAS_USR | n:1 | IP_IU | IU_CODE | IAPR_IAUS_FK | المشاريع والعقود | ربط ias project بـias usr |
| 175 | IAS_AP_CNTRCT_DTL | IAS_PROJECT | 1:n | IAS_IP | IP_CODE | IAAPCNDT_IAPR_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias project |
| 176 | ACCOUNT_CURR | MASTER_JOURNAL | n:1 | AC_MJ | MJ_CODE | ACCU_MAJO_FK | الحسابات والدفتر العام | ربط account curr بـmaster journal |
| 177 | IAS_CST_CLSS | MASTER_JOURNAL | n:1 | ICC_MJ | MJ_CODE | IACSCL_MAJO_FK | المبيعات والعملاء | ربط ias cst clss بـmaster journal |
| 178 | IAS_PROJECT | IAS_PROJECT_COST | n:1 | IP_IPC | IPC_CODE | IAPR_IAPRCO_FK | المشاريع والعقود | ربط ias project بـias project cost |
| 179 | GUARN_MASTER | GR_NOTE | n:1 | GM_GN | GN_CODE | GUMA_GRNO_FK | الضمانات والكفالات | ربط guarn master بـgr note |
| 180 | STK_PHYS_COUNT | MEASUREMENT | 1:1 | SPC_M | M_CODE | STPHCO_ME_FK | المخزون والمستودعات | ربط stk phys count بـmeasurement |
| 181 | IAS_USR_AUDIT | APX_SCR_PRV | 1:n | IUA_ASP | ASP_CODE | IAUSAU_APSCPR_FK | النظام والأمن | ربط ias usr audit بـapx scr prv |
| 182 | APX_FVRT_SCR | IAS_USR_AUDIT | n:1 | AFS_IUA | IUA_CODE | APFVSC_IAUSAU_FK | النظام والأمن | ربط apx fvrt scr بـias usr audit |
| 183 | STN_BILL_DTL | STN_BILL | n:1 | STN_SB | SB_CODE | STBIDT_STBI_FK | المبيعات والعملاء | ربط تفاصيل stn bill dtl بـstn bill |
| 184 | IAS_USR | MASTER_JOURNAL | n:1 | IU_MJ | MJ_CODE | IAUS_MAJO_FK | النظام والأمن | ربط ias usr بـmaster journal |
| 185 | GR_NOTE | COST_CENTERS | n:1 | GN_CC | CC_CODE | GRNO_COCE_FK | الضمانات والكفالات | ربط gr note بـcost centers |
| 186 | CASH_PAYMENT | IAS_CASH_INCOME | n:1 | CP_ICI | ICI_CODE | CAPA_IACAIN_FK | النقدية والبنوك | ربط cash payment بـias cash income |
| 187 | IAS_PI_BILL_DTL | GRN_DETAIL | n:1 | IAS_GD | GD_CODE | IAPIBIDT_GRDE_FK | المشتريات والموردين | ربط تفاصيل ias pi bill dtl بـgrn detail |
| 188 | IAS_PI_BILL | S_EMP | n:1 | IPB_EMP | EMP_CODE | IAPIBI_SEM_FK | المشتريات والموردين | ربط ias pi bill بـs emp |
| 189 | STK_PHYS_COUNT | IAS_ITM_GRP | n:1 | SPC_IIG | IIG_CODE | STPHCO_IAITGR_FK | المخزون والمستودعات | ربط stk phys count بـias itm grp |
| 190 | ITEM_UNIT_PRICE | ITEM_CARD | n:1 | IUP_ITM | ITM_CODE | ITUNPR_ITCA_FK | المخزون والمستودعات | ربط item unit price بـitem card |
| 191 | GR_NOTE | IAS_GUARN_TYPE | n:1 | GN_IGT | IGT_CODE | GRNO_IAGUTY_FK | الضمانات والكفالات | ربط gr note بـias guarn type |
| 192 | WAREHOUSE | ITEM_CARD | n:1 | W_ITM | ITM_CODE | WA_ITCA_FK | المخزون والمستودعات | ربط warehouse بـitem card |
| 193 | GR_NOTE | IAS_ACTVTY | n:1 | GN_ACTVTY | ACTVTY_CODE | GRNO_IAAC_FK | الضمانات والكفالات | ربط gr note بـias actvty |
| 194 | S_JOB | S_EMP | n:1 | SJ_EMP | EMP_CODE | SJO_SEM_FK | الموارد البشرية | ربط s job بـs emp |
| 195 | IAS_VNDR_CLSS | MASTER_JOURNAL | n:1 | IVC_MJ | MJ_CODE | IAVNCL_MAJO_FK | المشتريات والموردين | ربط ias vndr clss بـmaster journal |
| 196 | CUSTOMER | IAS_ACTVTY | n:1 | C_ACTVTY | ACTVTY_CODE | CU_IAAC_FK | المبيعات والعملاء | ربط customer بـias actvty |
| 197 | IAS_CST_TYP | ACCOUNT | n:1 | ICT_A | A_CODE | IACSTY_AC_FK | المبيعات والعملاء | ربط ias cst typ بـaccount |
| 198 | GR_NOTE | IAS_GUARN_STATUS | n:1 | GN_IGS | IGS_CODE | GRNO_IAGUST_FK | الضمانات والكفالات | ربط gr note بـias guarn status |
| 199 | APX_FVRT_SCR | IAS_USR_AUDIT | n:1 | AFS_IUA | IUA_CODE | APFVSC_IAUSAU_FK | النظام والأمن | ربط apx fvrt scr بـias usr audit |
| 200 | IAS_CST_CLSS | IAS_BILL_DTL | 1:n | ICC_IBD | IBD_CODE | IACSCL_IABIDT_FK | المبيعات والعملاء | ربط ias cst clss بـias bill dtl |
| 201 | GUARN_DETAILS | GUARN_MASTER | 1:n | GUARN_GM | GM_CODE | GUDE_GUMA_FK | الضمانات والكفالات | ربط guarn details بـguarn master |
| 202 | APX_SCR | APX_FVRT_SCR | n:1 | AS_AFS | AFS_CODE | APSC_APFVSC_FK | النظام والأمن | ربط apx scr بـapx fvrt scr |
| 203 | ACCOUNT_GROUPING | ACCOUNT_REPORT_TYPE | n:1 | AG_ART | ART_CODE | ACGR_ACRETY_FK | الحسابات والدفتر العام | ربط account grouping بـaccount report type |
| 204 | CASH_RECEIPT | IAS_BANK_ACCOUNT | n:1 | CR_IBA | IBA_CODE | CARE_IABAAC_FK | النقدية والبنوك | ربط cash receipt بـias bank account |
| 205 | CASH_RECEIPT | CASH_PAYMENT | n:1 | CR_CP | CP_CODE | CARE_CAPA_FK | النقدية والبنوك | ربط cash receipt بـcash payment |
| 206 | IAS_CASH | IAS_ACTVTY | n:1 | IC_ACTVTY | ACTVTY_CODE | IACA_IAAC_FK | النقدية والبنوك | ربط ias cash بـias actvty |
| 207 | ITEM_UNIT_PRICE | IAS_ITM_CLSS | n:1 | IUP_IIC | IIC_CODE | ITUNPR_IAITCL_FK | المخزون والمستودعات | ربط item unit price بـias itm clss |
| 208 | IAS_PROJECT_PHASE | IAS_AP_CNTRCT | 1:n | IPP_IAC | IAC_CODE | IAPRPH_IAAPCN_FK | المشاريع والعقود | ربط ias project phase بـias ap cntrct |
| 209 | IAS_ITM_GRP | MEASUREMENT | n:1 | IIG_M | M_CODE | IAITGR_ME_FK | المخزون والمستودعات | ربط ias itm grp بـmeasurement |
| 210 | APX_SCR | IAS_USR | n:1 | AS_IU | IU_CODE | APSC_IAUS_FK | النظام والأمن | ربط apx scr بـias usr |
| 211 | IAS_PROJECT_BUDGET | IAS_PROJECT | n:1 | IPB_IP | IP_CODE | IAPRBU_IAPR_FK | المشاريع والعقود | ربط ias project budget بـias project |
| 212 | IAS_GRP | IAS_USR | n:1 | IG_IU | IU_CODE | IAGR_IAUS_FK | النظام والأمن | ربط ias grp بـias usr |
| 213 | IAS_GUARN_TYPE | ITEM_CARD | n:1 | IGT_ITM | ITM_CODE | IAGUTY_ITCA_FK | الضمانات والكفالات | ربط ias guarn type بـitem card |
| 214 | IAS_CASH | MASTER_JOURNAL | n:1 | IC_MJ | MJ_CODE | IACA_MAJO_FK | النقدية والبنوك | ربط ias cash بـmaster journal |
| 215 | IAS_VNDR_TYP | GRN_DETAIL | n:1 | IVT_GD | GD_CODE | IAVNTY_GRDE_FK | المشتريات والموردين | ربط ias vndr typ بـgrn detail |
| 216 | STK_MOVMNT | ACCOUNT | n:1 | SM_A | A_CODE | STMO_AC_FK | المخزون والمستودعات | ربط stk movmnt بـaccount |
| 217 | IAS_DISCOUNT | CUSTOMER | n:1 | ID_CST | CST_CODE | IADI_CU_FK | المبيعات والعملاء | ربط ias discount بـcustomer |
| 218 | CASH_PAYMENT | BANK_CHEQUE | 1:n | CP_BC | BC_CODE | CAPA_BACH_FK | النقدية والبنوك | ربط cash payment بـbank cheque |
| 219 | IAS_CASH | IAS_BANK_ACCOUNT | 1:1 | IC_IBA | IBA_CODE | IACA_IABAAC_FK | النقدية والبنوك | ربط ias cash بـias bank account |
| 220 | IAS_BILL_DTL | IAS_DISCOUNT | 1:n | IAS_ID | ID_CODE | IABIDT_IADI_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـias discount |
| 221 | VENDOR | ACCOUNT | n:1 | V_A | A_CODE | VE_AC_FK | المشتريات والموردين | ربط vendor بـaccount |
| 222 | STN_BILL | IAS_CST_TYP | n:1 | SB_ICT | ICT_CODE | STBI_IACSTY_FK | المبيعات والعملاء | ربط stn bill بـias cst typ |
| 223 | IAS_USR_AUDIT | IAS_USR | n:1 | IUA_IU | IU_CODE | IAUSAU_IAUS_FK | النظام والأمن | ربط ias usr audit بـias usr |
| 224 | CASH_RECEIPT | IAS_CURRENCY | n:1 | CR_CY | CY_CODE | CARE_IACU_FK | النقدية والبنوك | ربط cash receipt بـias currency |
| 225 | P_ORDER | GRN_DETAIL | n:1 | PO_GD | GD_CODE | POR_GRDE_FK | المشتريات والموردين | ربط p order بـgrn detail |
| 226 | S_EMP | S_JOB | n:1 | SE_SJ | SJ_CODE | SEM_SJO_FK | الموارد البشرية | ربط s emp بـs job |
| 227 | IAS_ITM_CLSS | STK_MOVMNT | n:1 | IIC_SM | SM_CODE | IAITCL_STMO_FK | المخزون والمستودعات | ربط ias itm clss بـstk movmnt |
| 228 | IAS_CST_CLSS | IAS_ACTVTY | n:1 | ICC_ACTVTY | ACTVTY_CODE | IACSCL_IAAC_FK | المبيعات والعملاء | ربط ias cst clss بـias actvty |
| 229 | HRS_ALLOW_TYP | S_EMP | n:1 | HAT_EMP | EMP_CODE | HRALTY_SEM_FK | الموارد البشرية | ربط hrs allow typ بـs emp |
| 230 | P_ORDER_DETAIL | IAS_PI_BILL | n:1 | P_IPB | IPB_CODE | PORDE_IAPIBI_FK | المشتريات والموردين | ربط تفاصيل p order detail بـias pi bill |
| 231 | GLS_COST_CENTER_TRANS | S_EMP | n:1 | GCCT_EMP | EMP_CODE | GLCOCETR_SEM_FK | الحسابات والدفتر العام | ربط gls cost center trans بـs emp |
| 232 | ACCOUNT_TYPES | MASTER_JOURNAL | n:1 | AT_MJ | MJ_CODE | ACTY_MAJO_FK | الحسابات والدفتر العام | ربط account types بـmaster journal |
| 233 | ACCOUNT_TYPES | GLS_COST_CENTER_TRANS | n:1 | AT_GCCT | GCCT_CODE | ACTY_GLCOCETR_FK | الحسابات والدفتر العام | ربط account types بـgls cost center trans |
| 234 | ACCOUNT | ACCOUNT_GROUPING | n:1 | A_AG | AG_CODE | AC_ACGR_FK | الحسابات والدفتر العام | ربط الحساب بمجموعة الحسابات |
| 235 | ACCOUNT_TYPES | ACCOUNT_CURR | n:1 | AT_AC | AC_CODE | ACTY_ACCU_FK | الحسابات والدفتر العام | ربط account types بـaccount curr |
| 236 | S_DEPT | IAS_USR | n:1 | SD_IU | IU_CODE | SDE_IAUS_FK | الموارد البشرية | ربط s dept بـias usr |
| 237 | GUARN_MASTER | GUARN_DETAILS | n:m | GM_GD | GD_CODE | GUMA_GUDE_FK | الضمانات والكفالات | ربط guarn master بـguarn details |
| 238 | GUARN_DETAILS | IAS_GUARN_TYPE | n:1 | GUARN_IGT | IGT_CODE | GUDE_IAGUTY_FK | الضمانات والكفالات | ربط guarn details بـias guarn type |
| 239 | ITEM_UNIT_PRICE | STK_PHYS_COUNT | n:1 | IUP_SPC | SPC_CODE | ITUNPR_STPHCO_FK | المخزون والمستودعات | ربط item unit price بـstk phys count |
| 240 | STN_BILL | CUSTOMER | n:1 | SB_CST | CST_CODE | STBI_CU_FK | المبيعات والعملاء | ربط stn bill بـcustomer |
| 241 | GUARN_DETAILS | IAS_GUARN_TYPE | n:1 | GUARN_IGT | IGT_CODE | GUDE_IAGUTY_FK | الضمانات والكفالات | ربط guarn details بـias guarn type |
| 242 | CUSTOMER | STN_BILL | n:1 | C_SB | SB_CODE | CU_STBI_FK | المبيعات والعملاء | ربط customer بـstn bill |
| 243 | IAS_CASH_OUTGOING | IAS_CASH | n:1 | ICO_IC | IC_CODE | IACAOU_IACA_FK | النقدية والبنوك | ربط ias cash outgoing بـias cash |
| 244 | IAS_GUARN_TYPE | VENDOR | n:1 | IGT_VNDR | VNDR_CODE | IAGUTY_VE_FK | الضمانات والكفالات | ربط ias guarn type بـvendor |
| 245 | STK_MOVMNT | IAS_ITM_CLSS | 1:1 | SM_IIC | IIC_CODE | STMO_IAITCL_FK | المخزون والمستودعات | ربط stk movmnt بـias itm clss |
| 246 | STN_BILL | IAS_DISCOUNT | n:1 | SB_ID | ID_CODE | STBI_IADI_FK | المبيعات والعملاء | ربط stn bill بـias discount |
| 247 | DETAIL_JOURNAL | OPEN_BAL | n:1 | DJ_OB | OB_CODE | DEJO_OPBA_FK | الحسابات والدفتر العام | ربط detail journal بـopen bal |
| 248 | BANK_CHEQUE | CASH_PAYMENT | n:1 | BC_CP | CP_CODE | BACH_CAPA_FK | النقدية والبنوك | ربط bank cheque بـcash payment |
| 249 | STN_BILL_DTL | STN_BILL | n:1 | STN_SB | SB_CODE | STBIDT_STBI_FK | المبيعات والعملاء | ربط تفاصيل stn bill dtl بـstn bill |
| 250 | IAS_CASH_OUTGOING | BANK_CHEQUE | n:1 | ICO_BC | BC_CODE | IACAOU_BACH_FK | النقدية والبنوك | ربط ias cash outgoing بـbank cheque |
| 251 | IAS_GUARN_STATUS | GUARN_DETAILS | n:1 | IGS_GD | GD_CODE | IAGUST_GUDE_FK | الضمانات والكفالات | ربط ias guarn status بـguarn details |
| 252 | BANK_CHEQUE | CASH_PAYMENT | n:1 | BC_CP | CP_CODE | BACH_CAPA_FK | النقدية والبنوك | ربط bank cheque بـcash payment |
| 253 | IAS_AP_CNTRCT_DTL | CUSTOMER | n:1 | IAS_CST | CST_CODE | IAAPCNDT_CU_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـcustomer |
| 254 | IAS_BILL | IAS_CST_CLSS | n:1 | IB_ICC | ICC_CODE | IABI_IACSCL_FK | المبيعات والعملاء | ربط ias bill بـias cst clss |
| 255 | IAS_GUARN_TYPE | GUARN_DETAILS | 1:1 | IGT_GD | GD_CODE | IAGUTY_GUDE_FK | الضمانات والكفالات | ربط ias guarn type بـguarn details |
| 256 | ITEM_UNIT_PRICE | CUSTOMER | n:1 | IUP_CST | CST_CODE | ITUNPR_CU_FK | المخزون والمستودعات | ربط item unit price بـcustomer |
| 257 | IAS_ITM_GRP | COST_CENTERS | n:1 | IIG_CC | CC_CODE | IAITGR_COCE_FK | المخزون والمستودعات | ربط ias itm grp بـcost centers |
| 258 | IAS_ITM_GRP | STK_MOVMNT | 1:n | IIG_SM | SM_CODE | IAITGR_STMO_FK | المخزون والمستودعات | ربط ias itm grp بـstk movmnt |
| 259 | GUARN_DETAILS | IAS_GUARN_TYPE | n:1 | GUARN_IGT | IGT_CODE | GUDE_IAGUTY_FK | الضمانات والكفالات | ربط guarn details بـias guarn type |
| 260 | IAS_CASH | CASH_PAYMENT | 1:n | IC_CP | CP_CODE | IACA_CAPA_FK | النقدية والبنوك | ربط ias cash بـcash payment |
| 261 | GUARN_MASTER | S_EMP | n:1 | GM_EMP | EMP_CODE | GUMA_SEM_FK | الضمانات والكفالات | ربط guarn master بـs emp |
| 262 | IAS_USR | APX_FVRT_SCR | n:1 | IU_AFS | AFS_CODE | IAUS_APFVSC_FK | النظام والأمن | ربط ias usr بـapx fvrt scr |
| 263 | GR_NOTE | GUARN_DETAILS | n:1 | GN_GD | GD_CODE | GRNO_GUDE_FK | الضمانات والكفالات | ربط gr note بـguarn details |
| 264 | ITEM_CARD | IAS_ITM_GRP | n:1 | IC_IIG | IIG_CODE | ITCA_IAITGR_FK | المخزون والمستودعات | ربط الصنف بمجموعة الأصناف |
| 265 | HRS_SAL_DETAIL | IAS_USR | n:1 | HRS_IU | IU_CODE | HRSADE_IAUS_FK | الموارد البشرية | ربط تفاصيل hrs sal detail بـias usr |
| 266 | GRN_DETAIL | IAS_VNDR_CLSS | n:1 | GRN_IVC | IVC_CODE | GRDE_IAVNCL_FK | المشتريات والموردين | ربط تفاصيل grn detail بـias vndr clss |
| 267 | IAS_GRP | IAS_USR | n:1 | IG_IU | IU_CODE | IAGR_IAUS_FK | النظام والأمن | ربط ias grp بـias usr |
| 268 | APX_SCR_PRV | IAS_GRP | 1:n | ASP_IG | IG_CODE | APSCPR_IAGR_FK | النظام والأمن | ربط apx scr prv بـias grp |
| 269 | HRS_SAL | VENDOR | n:1 | HS_VNDR | VNDR_CODE | HRSA_VE_FK | الموارد البشرية | ربط hrs sal بـvendor |
| 270 | CASH_RECEIPT | IAS_CASH_OUTGOING | n:1 | CR_ICO | ICO_CODE | CARE_IACAOU_FK | النقدية والبنوك | ربط cash receipt بـias cash outgoing |
| 271 | IAS_BILL | S_EMP | n:1 | IB_EMP | EMP_CODE | IABI_SEM_FK | المبيعات والعملاء | ربط ias bill بـs emp |
| 272 | S_EMP | CUSTOMER | n:1 | SE_CST | CST_CODE | SEM_CU_FK | الموارد البشرية | ربط s emp بـcustomer |
| 273 | IAS_CST_TYP | IAS_DISCOUNT | 1:n | ICT_ID | ID_CODE | IACSTY_IADI_FK | المبيعات والعملاء | ربط ias cst typ بـias discount |
| 274 | HRS_VAC_TYP | S_EMP | n:1 | HVT_EMP | EMP_CODE | HRVATY_SEM_FK | الموارد البشرية | ربط hrs vac typ بـs emp |
| 275 | GR_NOTE | IAS_GUARN_TYPE | 1:n | GN_IGT | IGT_CODE | GRNO_IAGUTY_FK | الضمانات والكفالات | ربط gr note بـias guarn type |
| 276 | GUARN_DETAILS | IAS_GUARN_STATUS | n:1 | GUARN_IGS | IGS_CODE | GUDE_IAGUST_FK | الضمانات والكفالات | ربط guarn details بـias guarn status |
| 277 | GRN_DETAIL | GRN_MASTER | n:1 | GRN_GM | GM_CODE | GRDE_GRMA_FK | المشتريات والموردين | ربط تفاصيل grn detail بـgrn master |
| 278 | IAS_BILL_DTL | STN_BILL | n:1 | IAS_SB | SB_CODE | IABIDT_STBI_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـstn bill |
| 279 | MASTER_JOURNAL | ACCOUNT_TYPES | n:1 | MJ_AT | AT_CODE | MAJO_ACTY_FK | الحسابات والدفتر العام | ربط master journal بـaccount types |
| 280 | ITEM_UNIT_PRICE | IAS_ITM_CLSS | n:1 | IUP_IIC | IIC_CODE | ITUNPR_IAITCL_FK | المخزون والمستودعات | ربط item unit price بـias itm clss |
| 281 | GLS_COST_CENTER_TRANS | ACCOUNT_CURR | n:1 | GCCT_AC | AC_CODE | GLCOCETR_ACCU_FK | الحسابات والدفتر العام | ربط gls cost center trans بـaccount curr |
| 282 | ITEM_UNIT_PRICE | WAREHOUSE | n:1 | IUP_W | W_CODE | ITUNPR_WA_FK | المخزون والمستودعات | ربط item unit price بـwarehouse |
| 283 | IAS_PROJECT_COST | MASTER_JOURNAL | n:1 | IPC_MJ | MJ_CODE | IAPRCO_MAJO_FK | المشاريع والعقود | ربط ias project cost بـmaster journal |
| 284 | S_EMP | HRS_SAL | n:1 | SE_HS | HS_CODE | SEM_HRSA_FK | الموارد البشرية | ربط s emp بـhrs sal |
| 285 | STK_PHYS_COUNT | IAS_ITM_GRP | n:1 | SPC_IIG | IIG_CODE | STPHCO_IAITGR_FK | المخزون والمستودعات | ربط stk phys count بـias itm grp |
| 286 | CASH_PAYMENT | BANK_CHEQUE | 1:n | CP_BC | BC_CODE | CAPA_BACH_FK | النقدية والبنوك | ربط cash payment بـbank cheque |
| 287 | HRS_SAL | HRS_ATT | 1:n | HS_HA | HA_CODE | HRSA_HRAT_FK | الموارد البشرية | ربط hrs sal بـhrs att |
| 288 | DETAIL_JOURNAL | GLS_COST_CENTER_TRANS | 1:n | DJ_GCCT | GCCT_CODE | DEJO_GLCOCETR_FK | الحسابات والدفتر العام | ربط detail journal بـgls cost center trans |
| 289 | HRS_VAC_TYP | HRS_EMP_VAC | n:1 | HVT_HEV | HEV_CODE | HRVATY_HREMVA_FK | الموارد البشرية | ربط hrs vac typ بـhrs emp vac |
| 290 | HRS_ALLOW_TYP | HRS_ATT | n:1 | HAT_HA | HA_CODE | HRALTY_HRAT_FK | الموارد البشرية | ربط hrs allow typ بـhrs att |
| 291 | IAS_AP_CNTRCT_DTL | IAS_PROJECT_BUDGET | n:1 | IAS_IPB | IPB_CODE | IAAPCNDT_IAPRBU_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias project budget |
| 292 | ACCOUNT_TYPES | DETAIL_JOURNAL | n:1 | AT_DJ | DJ_CODE | ACTY_DEJO_FK | الحسابات والدفتر العام | ربط account types بـdetail journal |
| 293 | IAS_VNDR_CLSS | GRN_DETAIL | 1:1 | IVC_GD | GD_CODE | IAVNCL_GRDE_FK | المشتريات والموردين | ربط ias vndr clss بـgrn detail |
| 294 | ACCOUNT | OPEN_BAL | n:1 | A_OB | OB_CODE | AC_OPBA_FK | الحسابات والدفتر العام | ربط account بـopen bal |
| 295 | IAS_PROJECT_BUDGET | IAS_PROJECT_COST | n:1 | IPB_IPC | IPC_CODE | IAPRBU_IAPRCO_FK | المشاريع والعقود | ربط ias project budget بـias project cost |
| 296 | IAS_DISCOUNT | IAS_BILL | n:1 | ID_IB | IB_CODE | IADI_IABI_FK | المبيعات والعملاء | ربط ias discount بـias bill |
| 297 | IAS_PROJECT | IAS_PROJECT_BUDGET | n:1 | IP_IPB | IPB_CODE | IAPR_IAPRBU_FK | المشاريع والعقود | ربط ias project بـias project budget |
| 298 | IAS_ITM_GRP | ITEM_CARD | n:1 | IIG_ITM | ITM_CODE | IAITGR_ITCA_FK | المخزون والمستودعات | ربط ias itm grp بـitem card |
| 299 | CASH_RECEIPT | IAS_CASH | n:1 | CR_IC | IC_CODE | CARE_IACA_FK | النقدية والبنوك | ربط cash receipt بـias cash |
| 300 | DETAIL_JOURNAL | ACCOUNT_TYPES | 1:1 | DJ_AT | AT_CODE | DEJO_ACTY_FK | الحسابات والدفتر العام | ربط detail journal بـaccount types |
| 301 | IAS_CST_TYP | STN_BILL | 1:1 | ICT_SB | SB_CODE | IACSTY_STBI_FK | المبيعات والعملاء | ربط ias cst typ بـstn bill |
| 302 | ACCOUNT_GROUPING | ACCOUNT_TYPES | n:1 | AG_AT | AT_CODE | ACGR_ACTY_FK | الحسابات والدفتر العام | ربط account grouping بـaccount types |
| 303 | HRS_ATT | HRS_SAL_DETAIL | 1:n | HA_HSD | HSD_CODE | HRAT_HRSADE_FK | الموارد البشرية | ربط hrs att بـhrs sal detail |
| 304 | APX_SCR | IAS_USR_PRF | 1:1 | AS_IUP | IUP_CODE | APSC_IAUSPR_FK | النظام والأمن | ربط apx scr بـias usr prf |
| 305 | DETAIL_JOURNAL | MASTER_JOURNAL | n:1 | DJ_MJ | MJ_CODE | DEJO_MAJO_FK | الحسابات والدفتر العام | ربط تفاصيل القيد بسند القيد |
| 306 | IAS_AP_CNTRCT_DTL | IAS_PROJECT_COST | n:1 | IAS_IPC | IPC_CODE | IAAPCNDT_IAPRCO_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias project cost |
| 307 | IAS_BILL_DTL | STN_BILL_DTL | n:1 | IAS_SBD | SBD_CODE | IABIDT_STBIDT_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـstn bill dtl |
| 308 | ACCOUNT_REPORT_TYPE | S_EMP | n:1 | ART_EMP | EMP_CODE | ACRETY_SEM_FK | الحسابات والدفتر العام | ربط account report type بـs emp |
| 309 | APX_FVRT_SCR | COST_CENTERS | n:1 | AFS_CC | CC_CODE | APFVSC_COCE_FK | النظام والأمن | ربط apx fvrt scr بـcost centers |
| 310 | IAS_PI_BILL_DTL | IAS_CURRENCY | 1:n | IAS_CY | CY_CODE | IAPIBIDT_IACU_FK | المشتريات والموردين | ربط تفاصيل ias pi bill dtl بـias currency |
| 311 | IAS_GRP | APX_SCR | n:1 | IG_AS | AS_CODE | IAGR_APSC_FK | النظام والأمن | ربط ias grp بـapx scr |
| 312 | IAS_AP_CNTRCT | IAS_PROJECT | n:1 | IAC_IP | IP_CODE | IAAPCN_IAPR_FK | المشاريع والعقود | ربط ias ap cntrct بـias project |
| 313 | IAS_PROJECT | CUSTOMER | n:1 | IP_CST | CST_CODE | IAPR_CU_FK | المشاريع والعقود | ربط ias project بـcustomer |
| 314 | IAS_AP_CNTRCT | IAS_PROJECT_BUDGET | n:1 | IAC_IPB | IPB_CODE | IAAPCN_IAPRBU_FK | المشاريع والعقود | ربط ias ap cntrct بـias project budget |
| 315 | IAS_PI_BILL_DTL | CUSTOMER | n:1 | IAS_CST | CST_CODE | IAPIBIDT_CU_FK | المشتريات والموردين | ربط تفاصيل ias pi bill dtl بـcustomer |
| 316 | IAS_CASH | VENDOR | n:1 | IC_VNDR | VNDR_CODE | IACA_VE_FK | النقدية والبنوك | ربط ias cash بـvendor |
| 317 | IAS_USR_AUDIT | IAS_USR_LGN_HSTRY | n:1 | IUA_IULH | IULH_CODE | IAUSAU_IAUSLGHS_FK | النظام والأمن | ربط ias usr audit بـias usr lgn hstry |
| 318 | ACCOUNT_TYPES | GLS_COST_CENTER_TRANS | n:1 | AT_GCCT | GCCT_CODE | ACTY_GLCOCETR_FK | الحسابات والدفتر العام | ربط account types بـgls cost center trans |
| 319 | IAS_ITM_GRP | ITEM_COST | n:1 | IIG_IC | IC_CODE | IAITGR_ITCO_FK | المخزون والمستودعات | ربط ias itm grp بـitem cost |
| 320 | MASTER_JOURNAL | DETAIL_JOURNAL | n:1 | MJ_DJ | DJ_CODE | MAJO_DEJO_FK | الحسابات والدفتر العام | ربط master journal بـdetail journal |
| 321 | IAS_USR_PRF | COST_CENTERS | n:1 | IUP_CC | CC_CODE | IAUSPR_COCE_FK | النظام والأمن | ربط ias usr prf بـcost centers |
| 322 | IAS_VNDR_CLSS | P_ORDER_DETAIL | n:1 | IVC_POD | POD_CODE | IAVNCL_PORDE_FK | المشتريات والموردين | ربط ias vndr clss بـp order detail |
| 323 | ITEM_CARD | ITEM_UNIT_PRICE | n:1 | IC_IUP | IUP_CODE | ITCA_ITUNPR_FK | المخزون والمستودعات | ربط item card بـitem unit price |
| 324 | IAS_PROJECT_PHASE | ITEM_CARD | n:1 | IPP_ITM | ITM_CODE | IAPRPH_ITCA_FK | المشاريع والعقود | ربط ias project phase بـitem card |
| 325 | APX_SCR_PRV | IAS_USR | n:1 | ASP_IU | IU_CODE | APSCPR_IAUS_FK | النظام والأمن | ربط apx scr prv بـias usr |
| 326 | GUARN_MASTER | GUARN_DETAILS | n:1 | GM_GD | GD_CODE | GUMA_GUDE_FK | الضمانات والكفالات | ربط guarn master بـguarn details |
| 327 | OPEN_BAL | ACCOUNT_GROUPING | 1:n | OB_AG | AG_CODE | OPBA_ACGR_FK | الحسابات والدفتر العام | ربط open bal بـaccount grouping |
| 328 | IAS_PI_BILL | IAS_VNDR_TYP | n:1 | IPB_IVT | IVT_CODE | IAPIBI_IAVNTY_FK | المشتريات والموردين | ربط ias pi bill بـias vndr typ |
| 329 | STK_MOVMNT | ITEM_UNIT_PRICE | n:1 | SM_IUP | IUP_CODE | STMO_ITUNPR_FK | المخزون والمستودعات | ربط stk movmnt بـitem unit price |
| 330 | IAS_AP_CNTRCT_DTL | IAS_AP_CNTRCT_DTL | n:1 | IAS_IACD | IACD_CODE | IAAPCNDT_IAAPCNDT_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias ap cntrct dtl |
| 331 | IAS_ITM_GRP | ITEM_CARD | n:1 | IIG_ITM | ITM_CODE | IAITGR_ITCA_FK | المخزون والمستودعات | ربط ias itm grp بـitem card |
| 332 | HRS_SAL | HRS_SAL_DETAIL | n:1 | HS_HSD | HSD_CODE | HRSA_HRSADE_FK | الموارد البشرية | ربط hrs sal بـhrs sal detail |
| 333 | IAS_CST_CLSS | STN_BILL_DTL | n:1 | ICC_SBD | SBD_CODE | IACSCL_STBIDT_FK | المبيعات والعملاء | ربط ias cst clss بـstn bill dtl |
| 334 | ITEM_COST | STK_PHYS_COUNT | 1:n | IC_SPC | SPC_CODE | ITCO_STPHCO_FK | المخزون والمستودعات | ربط item cost بـstk phys count |
| 335 | GUARN_DETAILS | IAS_GUARN_STATUS | n:1 | GUARN_IGS | IGS_CODE | GUDE_IAGUST_FK | الضمانات والكفالات | ربط guarn details بـias guarn status |
| 336 | WAREHOUSE | MEASUREMENT | n:1 | W_M | M_CODE | WA_ME_FK | المخزون والمستودعات | ربط warehouse بـmeasurement |
| 337 | STN_BILL | CUSTOMER | n:1 | SB_CST | CST_CODE | STBI_CU_FK | المبيعات والعملاء | ربط stn bill بـcustomer |
| 338 | GR_NOTE | GUARN_DETAILS | n:1 | GN_GD | GD_CODE | GRNO_GUDE_FK | الضمانات والكفالات | ربط gr note بـguarn details |
| 339 | IAS_GRP | IAS_USR_PRF | n:1 | IG_IUP | IUP_CODE | IAGR_IAUSPR_FK | النظام والأمن | ربط ias grp بـias usr prf |
| 340 | IAS_DISCOUNT | IAS_CST_CLSS | 1:n | ID_ICC | ICC_CODE | IADI_IACSCL_FK | المبيعات والعملاء | ربط ias discount بـias cst clss |
| 341 | P_ORDER | GRN_DETAIL | n:1 | PO_GD | GD_CODE | POR_GRDE_FK | المشتريات والموردين | ربط p order بـgrn detail |
| 342 | IAS_GUARN_STATUS | IAS_GUARN_TYPE | n:1 | IGS_IGT | IGT_CODE | IAGUST_IAGUTY_FK | الضمانات والكفالات | ربط ias guarn status بـias guarn type |
| 343 | CUSTOMER | SALES_RETURN | n:1 | C_SR | SR_CODE | CU_SARE_FK | المبيعات والعملاء | ربط customer بـsales return |
| 344 | VENDOR | IAS_VNDR_CLSS | n:1 | V_IVC | IVC_CODE | VE_IAVNCL_FK | المشتريات والموردين | ربط vendor بـias vndr clss |
| 345 | MEASUREMENT | CUSTOMER | n:1 | M_CST | CST_CODE | ME_CU_FK | المخزون والمستودعات | ربط measurement بـcustomer |
| 346 | IAS_ITM_GRP | STK_PHYS_COUNT | n:1 | IIG_SPC | SPC_CODE | IAITGR_STPHCO_FK | المخزون والمستودعات | ربط ias itm grp بـstk phys count |
| 347 | ITEM_UNIT_PRICE | IAS_ITM_CLSS | n:1 | IUP_IIC | IIC_CODE | ITUNPR_IAITCL_FK | المخزون والمستودعات | ربط item unit price بـias itm clss |
| 348 | ACCOUNT_REPORT_TYPE | ACCOUNT_TYPES | n:1 | ART_AT | AT_CODE | ACRETY_ACTY_FK | الحسابات والدفتر العام | ربط account report type بـaccount types |
| 349 | STN_BILL | IAS_DISCOUNT | n:1 | SB_ID | ID_CODE | STBI_IADI_FK | المبيعات والعملاء | ربط stn bill بـias discount |
| 350 | ACCOUNT | ACCOUNT_TYPES | n:1 | A_AT | AT_CODE | AC_ACTY_FK | الحسابات والدفتر العام | ربط الحساب بنوع الحساب |
| 351 | IAS_GUARN_STATUS | IAS_GUARN_TYPE | n:1 | IGS_IGT | IGT_CODE | IAGUST_IAGUTY_FK | الضمانات والكفالات | ربط ias guarn status بـias guarn type |
| 352 | IAS_GUARN_TYPE | GR_NOTE | n:1 | IGT_GN | GN_CODE | IAGUTY_GRNO_FK | الضمانات والكفالات | ربط ias guarn type بـgr note |
| 353 | STN_BILL_DTL | IAS_ACTVTY | n:1 | STN_ACTVTY | ACTVTY_CODE | STBIDT_IAAC_FK | المبيعات والعملاء | ربط تفاصيل stn bill dtl بـias actvty |
| 354 | IAS_USR | APX_FVRT_SCR | 1:n | IU_AFS | AFS_CODE | IAUS_APFVSC_FK | النظام والأمن | ربط ias usr بـapx fvrt scr |
| 355 | BANK_CHEQUE | MASTER_JOURNAL | n:1 | BC_MJ | MJ_CODE | BACH_MAJO_FK | النقدية والبنوك | ربط bank cheque بـmaster journal |
| 356 | IAS_CST_CLSS | IAS_BILL | 1:n | ICC_IB | IB_CODE | IACSCL_IABI_FK | المبيعات والعملاء | ربط ias cst clss بـias bill |
| 357 | WAREHOUSE | IAS_USR | n:1 | W_IU | IU_CODE | WA_IAUS_FK | المخزون والمستودعات | ربط warehouse بـias usr |
| 358 | IAS_CASH | IAS_CASH_OUTGOING | n:1 | IC_ICO | ICO_CODE | IACA_IACAOU_FK | النقدية والبنوك | ربط ias cash بـias cash outgoing |
| 359 | IAS_GUARN_STATUS | ITEM_CARD | n:1 | IGS_ITM | ITM_CODE | IAGUST_ITCA_FK | الضمانات والكفالات | ربط ias guarn status بـitem card |
| 360 | GLS_COST_CENTER_TRANS | ACCOUNT_REPORT_TYPE | n:1 | GCCT_ART | ART_CODE | GLCOCETR_ACRETY_FK | الحسابات والدفتر العام | ربط gls cost center trans بـaccount report type |
| 361 | IAS_GRP | APX_SCR_PRV | n:1 | IG_ASP | ASP_CODE | IAGR_APSCPR_FK | النظام والأمن | ربط ias grp بـapx scr prv |
| 362 | IAS_PROJECT_PHASE | IAS_AP_CNTRCT | n:m | IPP_IAC | IAC_CODE | IAPRPH_IAAPCN_FK | المشاريع والعقود | ربط ias project phase بـias ap cntrct |
| 363 | P_ORDER_DETAIL | IAS_PI_BILL_DTL | n:1 | P_IPBD | IPBD_CODE | PORDE_IAPIBIDT_FK | المشتريات والموردين | ربط تفاصيل p order detail بـias pi bill dtl |
| 364 | GRN_DETAIL | GRN_MASTER | n:1 | GRN_GM | GM_CODE | GRDE_GRMA_FK | المشتريات والموردين | ربط تفاصيل grn detail بـgrn master |
| 365 | GLS_COST_CENTER_TRANS | CUSTOMER | n:1 | GCCT_CST | CST_CODE | GLCOCETR_CU_FK | الحسابات والدفتر العام | ربط gls cost center trans بـcustomer |
| 366 | IAS_GUARN_TYPE | MASTER_JOURNAL | n:1 | IGT_MJ | MJ_CODE | IAGUTY_MAJO_FK | الضمانات والكفالات | ربط ias guarn type بـmaster journal |
| 367 | STN_BILL | ACCOUNT | n:1 | SB_A | A_CODE | STBI_AC_FK | المبيعات والعملاء | ربط stn bill بـaccount |
| 368 | HRS_SAL_DETAIL | HRS_VAC_TYP | n:1 | HRS_HVT | HVT_CODE | HRSADE_HRVATY_FK | الموارد البشرية | ربط تفاصيل hrs sal detail بـhrs vac typ |
| 369 | IAS_CASH | CUSTOMER | n:1 | IC_CST | CST_CODE | IACA_CU_FK | النقدية والبنوك | ربط ias cash بـcustomer |
| 370 | GUARN_DETAILS | IAS_ACTVTY | n:1 | GUARN_ACTVTY | ACTVTY_CODE | GUDE_IAAC_FK | الضمانات والكفالات | ربط guarn details بـias actvty |
| 371 | IAS_BILL | STN_BILL_DTL | n:m | IB_SBD | SBD_CODE | IABI_STBIDT_FK | المبيعات والعملاء | ربط ias bill بـstn bill dtl |
| 372 | APX_SCR | IAS_USR | n:1 | AS_IU | IU_CODE | APSC_IAUS_FK | النظام والأمن | ربط apx scr بـias usr |
| 373 | IAS_ITM_CLSS | ITEM_CARD | n:1 | IIC_ITM | ITM_CODE | IAITCL_ITCA_FK | المخزون والمستودعات | ربط ias itm clss بـitem card |
| 374 | IAS_ITM_GRP | IAS_ITM_CLSS | n:1 | IIG_IIC | IIC_CODE | IAITGR_IAITCL_FK | المخزون والمستودعات | ربط ias itm grp بـias itm clss |
| 375 | HRS_ATT | HRS_VAC_TYP | n:1 | HA_HVT | HVT_CODE | HRAT_HRVATY_FK | الموارد البشرية | ربط hrs att بـhrs vac typ |
| 376 | HRS_ATT | HRS_SAL | n:1 | HA_HS | HS_CODE | HRAT_HRSA_FK | الموارد البشرية | ربط hrs att بـhrs sal |
| 377 | ITEM_UNIT_PRICE | WAREHOUSE | n:m | IUP_W | W_CODE | ITUNPR_WA_FK | المخزون والمستودعات | ربط item unit price بـwarehouse |
| 378 | CUSTOMER | IAS_CST_CLSS | n:1 | C_ICC | ICC_CODE | CU_IACSCL_FK | المبيعات والعملاء | ربط customer بـias cst clss |
| 379 | MASTER_JOURNAL | GLS_COST_CENTER_TRANS | n:1 | MJ_GCCT | GCCT_CODE | MAJO_GLCOCETR_FK | الحسابات والدفتر العام | ربط master journal بـgls cost center trans |
| 380 | APX_SCR_PRV | IAS_CURRENCY | n:1 | ASP_CY | CY_CODE | APSCPR_IACU_FK | النظام والأمن | ربط apx scr prv بـias currency |
| 381 | GR_NOTE | IAS_GUARN_STATUS | n:1 | GN_IGS | IGS_CODE | GRNO_IAGUST_FK | الضمانات والكفالات | ربط gr note بـias guarn status |
| 382 | IAS_GUARN_TYPE | IAS_GUARN_STATUS | n:1 | IGT_IGS | IGS_CODE | IAGUTY_IAGUST_FK | الضمانات والكفالات | ربط ias guarn type بـias guarn status |
| 383 | HRS_VAC_TYP | S_EMP | n:1 | HVT_EMP | EMP_CODE | HRVATY_SEM_FK | الموارد البشرية | ربط hrs vac typ بـs emp |
| 384 | CASH_RECEIPT | IAS_CASH | n:1 | CR_IC | IC_CODE | CARE_IACA_FK | النقدية والبنوك | ربط cash receipt بـias cash |
| 385 | GR_NOTE | IAS_GUARN_STATUS | n:1 | GN_IGS | IGS_CODE | GRNO_IAGUST_FK | الضمانات والكفالات | ربط gr note بـias guarn status |
| 386 | IAS_AP_CNTRCT_DTL | IAS_AR_CNTRCT | n:1 | IAS_IAC | IAC_CODE | IAAPCNDT_IAARCN_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias ar cntrct |
| 387 | ACCOUNT_TYPES | MASTER_JOURNAL | n:1 | AT_MJ | MJ_CODE | ACTY_MAJO_FK | الحسابات والدفتر العام | ربط account types بـmaster journal |
| 388 | P_ORDER | IAS_PI_BILL_DTL | n:1 | PO_IPBD | IPBD_CODE | POR_IAPIBIDT_FK | المشتريات والموردين | ربط p order بـias pi bill dtl |
| 389 | ACCOUNT_GROUPING | IAS_CURRENCY | n:1 | AG_CY | CY_CODE | ACGR_IACU_FK | الحسابات والدفتر العام | ربط account grouping بـias currency |
| 390 | CASH_RECEIPT | IAS_CASH_INCOME | n:1 | CR_ICI | ICI_CODE | CARE_IACAIN_FK | النقدية والبنوك | ربط cash receipt بـias cash income |
| 391 | IAS_USR_AUDIT | APX_SCR | n:1 | IUA_AS | AS_CODE | IAUSAU_APSC_FK | النظام والأمن | ربط ias usr audit بـapx scr |
| 392 | IAS_CASH_INCOME | CASH_PAYMENT | n:1 | ICI_CP | CP_CODE | IACAIN_CAPA_FK | النقدية والبنوك | ربط ias cash income بـcash payment |
| 393 | IAS_ITM_CLSS | ITEM_UNIT_PRICE | n:1 | IIC_IUP | IUP_CODE | IAITCL_ITUNPR_FK | المخزون والمستودعات | ربط ias itm clss بـitem unit price |
| 394 | IAS_GUARN_STATUS | GUARN_DETAILS | n:1 | IGS_GD | GD_CODE | IAGUST_GUDE_FK | الضمانات والكفالات | ربط ias guarn status بـguarn details |
| 395 | HRS_EMP_VAC | S_DEPT | 1:n | HEV_SD | SD_CODE | HREMVA_SDE_FK | الموارد البشرية | ربط hrs emp vac بـs dept |
| 396 | IAS_PROJECT_COST | IAS_AR_CNTRCT | n:1 | IPC_IAC | IAC_CODE | IAPRCO_IAARCN_FK | المشاريع والعقود | ربط ias project cost بـias ar cntrct |
| 397 | IAS_USR | IAS_GRP | n:1 | IU_IG | IG_CODE | IAUS_IAGR_FK | النظام والأمن | ربط ias usr بـias grp |
| 398 | APX_FVRT_SCR | APX_SCR_PRV | n:1 | AFS_ASP | ASP_CODE | APFVSC_APSCPR_FK | النظام والأمن | ربط apx fvrt scr بـapx scr prv |
| 399 | IAS_CASH | IAS_BANK | n:1 | IC_IB | IB_CODE | IACA_IABA_FK | النقدية والبنوك | ربط ias cash بـias bank |
| 400 | APX_SCR_PRV | IAS_USR | n:1 | ASP_IU | IU_CODE | APSCPR_IAUS_FK | النظام والأمن | ربط apx scr prv بـias usr |
| 401 | IAS_AP_CNTRCT_DTL | IAS_AP_CNTRCT_DTL | n:1 | IAS_IACD | IACD_CODE | IAAPCNDT_IAAPCNDT_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias ap cntrct dtl |
| 402 | ITEM_COST | ACCOUNT | n:1 | IC_A | A_CODE | ITCO_AC_FK | المخزون والمستودعات | ربط item cost بـaccount |
| 403 | IAS_BANK_ACCOUNT | IAS_CASH | 1:1 | IBA_IC | IC_CODE | IABAAC_IACA_FK | النقدية والبنوك | ربط ias bank account بـias cash |
| 404 | IAS_BANK | MASTER_JOURNAL | n:1 | IB_MJ | MJ_CODE | IABA_MAJO_FK | النقدية والبنوك | ربط ias bank بـmaster journal |
| 405 | APX_SCR | IAS_USR_LGN_HSTRY | n:1 | AS_IULH | IULH_CODE | APSC_IAUSLGHS_FK | النظام والأمن | ربط apx scr بـias usr lgn hstry |
| 406 | P_ORDER_DETAIL | GRN_MASTER | n:1 | P_GM | GM_CODE | PORDE_GRMA_FK | المشتريات والموردين | ربط تفاصيل p order detail بـgrn master |
| 407 | GUARN_DETAILS | COST_CENTERS | n:1 | GUARN_CC | CC_CODE | GUDE_COCE_FK | الضمانات والكفالات | ربط guarn details بـcost centers |
| 408 | IAS_BANK | BANK_CHEQUE | n:1 | IB_BC | BC_CODE | IABA_BACH_FK | النقدية والبنوك | ربط ias bank بـbank cheque |
| 409 | GUARN_DETAILS | CUSTOMER | n:1 | GUARN_CST | CST_CODE | GUDE_CU_FK | الضمانات والكفالات | ربط guarn details بـcustomer |
| 410 | GUARN_MASTER | GUARN_DETAILS | n:1 | GM_GD | GD_CODE | GUMA_GUDE_FK | الضمانات والكفالات | ربط guarn master بـguarn details |
| 411 | P_ORDER | GRN_MASTER | n:1 | PO_GM | GM_CODE | POR_GRMA_FK | المشتريات والموردين | ربط p order بـgrn master |
| 412 | IAS_PROJECT_BUDGET | IAS_AR_CNTRCT | n:1 | IPB_IAC | IAC_CODE | IAPRBU_IAARCN_FK | المشاريع والعقود | ربط ias project budget بـias ar cntrct |
| 413 | IAS_USR_PRF | APX_FVRT_SCR | n:1 | IUP_AFS | AFS_CODE | IAUSPR_APFVSC_FK | النظام والأمن | ربط ias usr prf بـapx fvrt scr |
| 414 | GRN_DETAIL | P_ORDER_DETAIL | n:1 | GRN_POD | POD_CODE | GRDE_PORDE_FK | المشتريات والموردين | ربط تفاصيل grn detail بـp order detail |
| 415 | IAS_USR | APX_SCR | n:1 | IU_AS | AS_CODE | IAUS_APSC_FK | النظام والأمن | ربط ias usr بـapx scr |
| 416 | IAS_BILL_DTL | STN_BILL | n:1 | IAS_SB | SB_CODE | IABIDT_STBI_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـstn bill |
| 417 | IAS_AP_CNTRCT_DTL | IAS_AP_CNTRCT | n:1 | IAS_IAC | IAC_CODE | IAAPCNDT_IAAPCN_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias ap cntrct |
| 418 | IAS_AP_CNTRCT | IAS_PROJECT | n:1 | IAC_IP | IP_CODE | IAAPCN_IAPR_FK | المشاريع والعقود | ربط ias ap cntrct بـias project |
| 419 | IAS_AP_CNTRCT_DTL | IAS_PROJECT_COST | n:1 | IAS_IPC | IPC_CODE | IAAPCNDT_IAPRCO_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias project cost |
| 420 | IAS_PROJECT | IAS_AP_CNTRCT | n:1 | IP_IAC | IAC_CODE | IAPR_IAAPCN_FK | المشاريع والعقود | ربط ias project بـias ap cntrct |
| 421 | CUSTOMER | IAS_CST_CLSS | 1:n | C_ICC | ICC_CODE | CU_IACSCL_FK | المبيعات والعملاء | ربط customer بـias cst clss |
| 422 | APX_FVRT_SCR | IAS_USR_AUDIT | n:1 | AFS_IUA | IUA_CODE | APFVSC_IAUSAU_FK | النظام والأمن | ربط apx fvrt scr بـias usr audit |
| 423 | STK_MOVMNT | VENDOR | n:1 | SM_VNDR | VNDR_CODE | STMO_VE_FK | المخزون والمستودعات | ربط stk movmnt بـvendor |
| 424 | CASH_RECEIPT | BANK_CHEQUE | 1:n | CR_BC | BC_CODE | CARE_BACH_FK | النقدية والبنوك | ربط cash receipt بـbank cheque |
| 425 | S_JOB | CUSTOMER | n:1 | SJ_CST | CST_CODE | SJO_CU_FK | الموارد البشرية | ربط s job بـcustomer |
| 426 | IAS_CASH_INCOME | CASH_RECEIPT | 1:n | ICI_CR | CR_CODE | IACAIN_CARE_FK | النقدية والبنوك | ربط ias cash income بـcash receipt |
| 427 | SALES_RETURN | CUSTOMER | n:1 | SR_CST | CST_CODE | SARE_CU_FK | المبيعات والعملاء | ربط sales return بـcustomer |
| 428 | ITEM_COST | CUSTOMER | n:1 | IC_CST | CST_CODE | ITCO_CU_FK | المخزون والمستودعات | ربط item cost بـcustomer |
| 429 | IAS_USR_PRF | APX_SCR_PRV | n:1 | IUP_ASP | ASP_CODE | IAUSPR_APSCPR_FK | النظام والأمن | ربط ias usr prf بـapx scr prv |
| 430 | HRS_ATT | HRS_SAL | 1:n | HA_HS | HS_CODE | HRAT_HRSA_FK | الموارد البشرية | ربط hrs att بـhrs sal |
| 431 | IAS_USR | IAS_GRP | n:1 | IU_IG | IG_CODE | IAUS_IAGR_FK | النظام والأمن | ربط ias usr بـias grp |
| 432 | IAS_USR_LGN_HSTRY | IAS_USR_AUDIT | 1:n | IULH_IUA | IUA_CODE | IAUSLGHS_IAUSAU_FK | النظام والأمن | ربط ias usr lgn hstry بـias usr audit |
| 433 | P_ORDER_DETAIL | IAS_VNDR_TYP | 1:n | P_IVT | IVT_CODE | PORDE_IAVNTY_FK | المشتريات والموردين | ربط تفاصيل p order detail بـias vndr typ |
| 434 | GRN_DETAIL | GRN_DETAIL | 1:n | GRN_GD | GD_CODE | GRDE_GRDE_FK | المشتريات والموردين | ربط تفاصيل grn detail بـgrn detail |
| 435 | OPEN_BAL | ACCOUNT | n:1 | OB_A | A_CODE | OPBA_AC_FK | الحسابات والدفتر العام | ربط open bal بـaccount |
| 436 | IAS_BILL | ACCOUNT | n:1 | IB_A | A_CODE | IABI_AC_FK | المبيعات والعملاء | ربط ias bill بـaccount |
| 437 | GRN_DETAIL | COST_CENTERS | n:1 | GRN_CC | CC_CODE | GRDE_COCE_FK | المشتريات والموردين | ربط تفاصيل grn detail بـcost centers |
| 438 | IAS_BILL | SALES_RETURN | n:1 | IB_SR | SR_CODE | IABI_SARE_FK | المبيعات والعملاء | ربط ias bill بـsales return |
| 439 | ACCOUNT_REPORT_TYPE | ACCOUNT | n:1 | ART_A | A_CODE | ACRETY_AC_FK | الحسابات والدفتر العام | ربط account report type بـaccount |
| 440 | STN_BILL | CUSTOMER | n:1 | SB_CST | CST_CODE | STBI_CU_FK | المبيعات والعملاء | ربط stn bill بـcustomer |
| 441 | GUARN_MASTER | GR_NOTE | n:1 | GM_GN | GN_CODE | GUMA_GRNO_FK | الضمانات والكفالات | ربط guarn master بـgr note |
| 442 | IAS_PROJECT_PHASE | IAS_AR_CNTRCT | n:1 | IPP_IAC | IAC_CODE | IAPRPH_IAARCN_FK | المشاريع والعقود | ربط ias project phase بـias ar cntrct |
| 443 | IAS_PI_BILL_DTL | P_ORDER | n:1 | IAS_PO | PO_CODE | IAPIBIDT_POR_FK | المشتريات والموردين | ربط تفاصيل ias pi bill dtl بـp order |
| 444 | P_ORDER_DETAIL | IAS_VNDR_CLSS | n:1 | P_IVC | IVC_CODE | PORDE_IAVNCL_FK | المشتريات والموردين | ربط تفاصيل p order detail بـias vndr clss |
| 445 | GUARN_DETAILS | GR_NOTE | 1:1 | GUARN_GN | GN_CODE | GUDE_GRNO_FK | الضمانات والكفالات | ربط guarn details بـgr note |
| 446 | IAS_PROJECT_PHASE | IAS_PROJECT_COST | n:1 | IPP_IPC | IPC_CODE | IAPRPH_IAPRCO_FK | المشاريع والعقود | ربط ias project phase بـias project cost |
| 447 | ACCOUNT_REPORT_TYPE | OPEN_BAL | n:1 | ART_OB | OB_CODE | ACRETY_OPBA_FK | الحسابات والدفتر العام | ربط account report type بـopen bal |
| 448 | ACCOUNT_GROUPING | GLS_COST_CENTER_TRANS | n:1 | AG_GCCT | GCCT_CODE | ACGR_GLCOCETR_FK | الحسابات والدفتر العام | ربط account grouping بـgls cost center trans |
| 449 | IAS_CASH_OUTGOING | BANK_CHEQUE | n:1 | ICO_BC | BC_CODE | IACAOU_BACH_FK | النقدية والبنوك | ربط ias cash outgoing بـbank cheque |
| 450 | IAS_CASH_OUTGOING | IAS_CASH | n:1 | ICO_IC | IC_CODE | IACAOU_IACA_FK | النقدية والبنوك | ربط ias cash outgoing بـias cash |
| 451 | GUARN_MASTER | ACCOUNT | n:1 | GM_A | A_CODE | GUMA_AC_FK | الضمانات والكفالات | ربط guarn master بـaccount |
| 452 | IAS_AP_CNTRCT_DTL | IAS_AR_CNTRCT | n:1 | IAS_IAC | IAC_CODE | IAAPCNDT_IAARCN_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias ar cntrct |
| 453 | IAS_PI_BILL | IAS_PI_BILL_DTL | n:1 | IPB_IPBD | IPBD_CODE | IAPIBI_IAPIBIDT_FK | المشتريات والموردين | ربط ias pi bill بـias pi bill dtl |
| 454 | IAS_USR_PRF | APX_SCR_PRV | 1:n | IUP_ASP | ASP_CODE | IAUSPR_APSCPR_FK | النظام والأمن | ربط ias usr prf بـapx scr prv |
| 455 | IAS_AP_CNTRCT_DTL | IAS_PROJECT_BUDGET | 1:n | IAS_IPB | IPB_CODE | IAAPCNDT_IAPRBU_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias project budget |
| 456 | IAS_CASH_OUTGOING | CASH_PAYMENT | 1:n | ICO_CP | CP_CODE | IACAOU_CAPA_FK | النقدية والبنوك | ربط ias cash outgoing بـcash payment |
| 457 | IAS_BANK | CASH_RECEIPT | n:1 | IB_CR | CR_CODE | IABA_CARE_FK | النقدية والبنوك | ربط ias bank بـcash receipt |
| 458 | HRS_EMP_VAC | S_EMP | n:1 | HEV_EMP | EMP_CODE | HREMVA_SEM_FK | الموارد البشرية | ربط hrs emp vac بـs emp |
| 459 | IAS_BANK | CASH_PAYMENT | n:1 | IB_CP | CP_CODE | IABA_CAPA_FK | النقدية والبنوك | ربط ias bank بـcash payment |
| 460 | IAS_ITM_CLSS | IAS_ACTVTY | n:1 | IIC_ACTVTY | ACTVTY_CODE | IAITCL_IAAC_FK | المخزون والمستودعات | ربط ias itm clss بـias actvty |
| 461 | IAS_BANK_ACCOUNT | IAS_BANK | n:1 | IBA_IB | IB_CODE | IABAAC_IABA_FK | النقدية والبنوك | ربط ias bank account بـias bank |
| 462 | P_ORDER_DETAIL | IAS_ACTVTY | n:1 | P_ACTVTY | ACTVTY_CODE | PORDE_IAAC_FK | المشتريات والموردين | ربط تفاصيل p order detail بـias actvty |
| 463 | HRS_SAL | S_JOB | 1:n | HS_SJ | SJ_CODE | HRSA_SJO_FK | الموارد البشرية | ربط hrs sal بـs job |
| 464 | IAS_BILL_DTL | IAS_BILL_DTL | n:1 | IAS_IBD | IBD_CODE | IABIDT_IABIDT_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـias bill dtl |
| 465 | SALES_RETURN | STN_BILL | n:1 | SR_SB | SB_CODE | SARE_STBI_FK | المبيعات والعملاء | ربط sales return بـstn bill |
| 466 | IAS_PROJECT_COST | IAS_PROJECT_PHASE | n:1 | IPC_IPP | IPP_CODE | IAPRCO_IAPRPH_FK | المشاريع والعقود | ربط ias project cost بـias project phase |
| 467 | IAS_CASH_INCOME | IAS_ACTVTY | n:1 | ICI_ACTVTY | ACTVTY_CODE | IACAIN_IAAC_FK | النقدية والبنوك | ربط ias cash income بـias actvty |
| 468 | STN_BILL | IAS_BILL_DTL | n:1 | SB_IBD | IBD_CODE | STBI_IABIDT_FK | المبيعات والعملاء | ربط stn bill بـias bill dtl |
| 469 | IAS_ITM_CLSS | WAREHOUSE | n:1 | IIC_W | W_CODE | IAITCL_WA_FK | المخزون والمستودعات | ربط ias itm clss بـwarehouse |
| 470 | CUSTOMER | IAS_BILL_DTL | n:1 | C_IBD | IBD_CODE | CU_IABIDT_FK | المبيعات والعملاء | ربط customer بـias bill dtl |
| 471 | GLS_COST_CENTER_TRANS | ACCOUNT_TYPES | n:1 | GCCT_AT | AT_CODE | GLCOCETR_ACTY_FK | الحسابات والدفتر العام | ربط gls cost center trans بـaccount types |
| 472 | IAS_VNDR_TYP | ACCOUNT | n:1 | IVT_A | A_CODE | IAVNTY_AC_FK | المشتريات والموردين | ربط ias vndr typ بـaccount |
| 473 | IAS_PROJECT | MASTER_JOURNAL | n:1 | IP_MJ | MJ_CODE | IAPR_MAJO_FK | المشاريع والعقود | ربط ias project بـmaster journal |
| 474 | ACCOUNT_REPORT_TYPE | IAS_USR | n:1 | ART_IU | IU_CODE | ACRETY_IAUS_FK | الحسابات والدفتر العام | ربط account report type بـias usr |
| 475 | IAS_BILL | IAS_CST_TYP | 1:1 | IB_ICT | ICT_CODE | IABI_IACSTY_FK | المبيعات والعملاء | ربط ias bill بـias cst typ |
| 476 | IAS_PI_BILL | COST_CENTERS | n:1 | IPB_CC | CC_CODE | IAPIBI_COCE_FK | المشتريات والموردين | ربط ias pi bill بـcost centers |
| 477 | IAS_USR_PRF | IAS_USR | n:1 | IUP_IU | IU_CODE | IAUSPR_IAUS_FK | النظام والأمن | ربط ias usr prf بـias usr |
| 478 | HRS_SAL_DETAIL | HRS_ATT | n:1 | HRS_HA | HA_CODE | HRSADE_HRAT_FK | الموارد البشرية | ربط تفاصيل hrs sal detail بـhrs att |
| 479 | HRS_ALLOW_TYP | HRS_VAC_TYP | n:1 | HAT_HVT | HVT_CODE | HRALTY_HRVATY_FK | الموارد البشرية | ربط hrs allow typ بـhrs vac typ |
| 480 | WAREHOUSE | IAS_ITM_CLSS | n:1 | W_IIC | IIC_CODE | WA_IAITCL_FK | المخزون والمستودعات | ربط warehouse بـias itm clss |
| 481 | MASTER_JOURNAL | ACCOUNT_REPORT_TYPE | n:1 | MJ_ART | ART_CODE | MAJO_ACRETY_FK | الحسابات والدفتر العام | ربط master journal بـaccount report type |
| 482 | P_ORDER | IAS_PI_BILL | n:1 | PO_IPB | IPB_CODE | POR_IAPIBI_FK | المشتريات والموردين | ربط p order بـias pi bill |
| 483 | IAS_PROJECT_BUDGET | IAS_PROJECT_COST | n:1 | IPB_IPC | IPC_CODE | IAPRBU_IAPRCO_FK | المشاريع والعقود | ربط ias project budget بـias project cost |
| 484 | IAS_GUARN_STATUS | GUARN_MASTER | n:1 | IGS_GM | GM_CODE | IAGUST_GUMA_FK | الضمانات والكفالات | ربط ias guarn status بـguarn master |
| 485 | IAS_BILL_DTL | STN_BILL | n:1 | IAS_SB | SB_CODE | IABIDT_STBI_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـstn bill |
| 486 | IAS_PROJECT | IAS_AR_CNTRCT | 1:n | IP_IAC | IAC_CODE | IAPR_IAARCN_FK | المشاريع والعقود | ربط ias project بـias ar cntrct |
| 487 | ITEM_COST | IAS_ITM_GRP | n:1 | IC_IIG | IIG_CODE | ITCO_IAITGR_FK | المخزون والمستودعات | ربط item cost بـias itm grp |
| 488 | IAS_VNDR_TYP | IAS_VNDR_CLSS | n:1 | IVT_IVC | IVC_CODE | IAVNTY_IAVNCL_FK | المشتريات والموردين | ربط ias vndr typ بـias vndr clss |
| 489 | ITEM_UNIT_PRICE | STK_PHYS_COUNT | 1:n | IUP_SPC | SPC_CODE | ITUNPR_STPHCO_FK | المخزون والمستودعات | ربط item unit price بـstk phys count |
| 490 | SALES_RETURN | IAS_CST_CLSS | n:1 | SR_ICC | ICC_CODE | SARE_IACSCL_FK | المبيعات والعملاء | ربط sales return بـias cst clss |
| 491 | IAS_USR_LGN_HSTRY | IAS_USR | n:1 | IULH_IU | IU_CODE | IAUSLGHS_IAUS_FK | النظام والأمن | ربط ias usr lgn hstry بـias usr |
| 492 | OPEN_BAL | ACCOUNT_REPORT_TYPE | n:1 | OB_ART | ART_CODE | OPBA_ACRETY_FK | الحسابات والدفتر العام | ربط open bal بـaccount report type |
| 493 | IAS_CASH_OUTGOING | CASH_RECEIPT | 1:n | ICO_CR | CR_CODE | IACAOU_CARE_FK | النقدية والبنوك | ربط ias cash outgoing بـcash receipt |
| 494 | APX_FVRT_SCR | IAS_USR_PRF | 1:n | AFS_IUP | IUP_CODE | APFVSC_IAUSPR_FK | النظام والأمن | ربط apx fvrt scr بـias usr prf |
| 495 | IAS_GUARN_TYPE | GUARN_MASTER | n:1 | IGT_GM | GM_CODE | IAGUTY_GUMA_FK | الضمانات والكفالات | ربط ias guarn type بـguarn master |
| 496 | S_DEPT | HRS_SAL_DETAIL | 1:n | SD_HSD | HSD_CODE | SDE_HRSADE_FK | الموارد البشرية | ربط s dept بـhrs sal detail |
| 497 | IAS_USR | IAS_USR_LGN_HSTRY | n:1 | IU_IULH | IULH_CODE | IAUS_IAUSLGHS_FK | النظام والأمن | ربط ias usr بـias usr lgn hstry |
| 498 | GRN_DETAIL | IAS_VNDR_TYP | 1:1 | GRN_IVT | IVT_CODE | GRDE_IAVNTY_FK | المشتريات والموردين | ربط تفاصيل grn detail بـias vndr typ |
| 499 | VENDOR | GRN_MASTER | 1:1 | V_GM | GM_CODE | VE_GRMA_FK | المشتريات والموردين | ربط vendor بـgrn master |
| 500 | IAS_VNDR_TYP | IAS_VNDR_CLSS | 1:n | IVT_IVC | IVC_CODE | IAVNTY_IAVNCL_FK | المشتريات والموردين | ربط ias vndr typ بـias vndr clss |
| 501 | IAS_GUARN_TYPE | VENDOR | n:1 | IGT_VNDR | VNDR_CODE | IAGUTY_VE_FK | الضمانات والكفالات | ربط ias guarn type بـvendor |
| 502 | IAS_USR_PRF | APX_SCR | n:1 | IUP_AS | AS_CODE | IAUSPR_APSC_FK | النظام والأمن | ربط ias usr prf بـapx scr |
| 503 | CASH_PAYMENT | IAS_BANK | n:1 | CP_IB | IB_CODE | CAPA_IABA_FK | النقدية والبنوك | ربط cash payment بـias bank |
| 504 | IAS_BANK | CASH_PAYMENT | n:1 | IB_CP | CP_CODE | IABA_CAPA_FK | النقدية والبنوك | ربط ias bank بـcash payment |
| 505 | S_DEPT | S_JOB | n:1 | SD_SJ | SJ_CODE | SDE_SJO_FK | الموارد البشرية | ربط s dept بـs job |
| 506 | GUARN_MASTER | GR_NOTE | 1:n | GM_GN | GN_CODE | GUMA_GRNO_FK | الضمانات والكفالات | ربط guarn master بـgr note |
| 507 | BANK_CHEQUE | CASH_PAYMENT | n:1 | BC_CP | CP_CODE | BACH_CAPA_FK | النقدية والبنوك | ربط bank cheque بـcash payment |
| 508 | GRN_DETAIL | MASTER_JOURNAL | n:1 | GRN_MJ | MJ_CODE | GRDE_MAJO_FK | المشتريات والموردين | ربط تفاصيل grn detail بـmaster journal |
| 509 | IAS_PROJECT_BUDGET | IAS_PROJECT_COST | n:1 | IPB_IPC | IPC_CODE | IAPRBU_IAPRCO_FK | المشاريع والعقود | ربط ias project budget بـias project cost |
| 510 | BANK_CHEQUE | IAS_CASH_INCOME | 1:n | BC_ICI | ICI_CODE | BACH_IACAIN_FK | النقدية والبنوك | ربط bank cheque بـias cash income |
| 511 | IAS_AP_CNTRCT_DTL | IAS_AP_CNTRCT | n:1 | IAS_IAC | IAC_CODE | IAAPCNDT_IAAPCN_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias ap cntrct |
| 512 | IAS_PROJECT_COST | COST_CENTERS | n:1 | IPC_CC | CC_CODE | IAPRCO_COCE_FK | المشاريع والعقود | ربط ias project cost بـcost centers |
| 513 | ITEM_COST | ACCOUNT | n:1 | IC_A | A_CODE | ITCO_AC_FK | المخزون والمستودعات | ربط item cost بـaccount |
| 514 | S_JOB | HRS_SAL_DETAIL | n:1 | SJ_HSD | HSD_CODE | SJO_HRSADE_FK | الموارد البشرية | ربط s job بـhrs sal detail |
| 515 | STK_PHYS_COUNT | IAS_ITM_CLSS | n:1 | SPC_IIC | IIC_CODE | STPHCO_IAITCL_FK | المخزون والمستودعات | ربط stk phys count بـias itm clss |
| 516 | GLS_COST_CENTER_TRANS | ACCOUNT | n:1 | GCCT_A | A_CODE | GLCOCETR_AC_FK | الحسابات والدفتر العام | ربط gls cost center trans بـaccount |
| 517 | OPEN_BAL | COST_CENTERS | n:1 | OB_CC | CC_CODE | OPBA_COCE_FK | الحسابات والدفتر العام | ربط open bal بـcost centers |
| 518 | IAS_GUARN_STATUS | GUARN_MASTER | n:1 | IGS_GM | GM_CODE | IAGUST_GUMA_FK | الضمانات والكفالات | ربط ias guarn status بـguarn master |
| 519 | IAS_BILL_DTL | IAS_BILL | n:1 | IAS_IB | IB_CODE | IABIDT_IABI_FK | المبيعات والعملاء | ربط تفاصيل فاتورة المبيعات بالفاتورة |
| 520 | IAS_ITM_GRP | IAS_ITM_CLSS | n:1 | IIG_IIC | IIC_CODE | IAITGR_IAITCL_FK | المخزون والمستودعات | ربط ias itm grp بـias itm clss |
| 521 | IAS_BILL_DTL | SALES_RETURN | n:1 | IAS_SR | SR_CODE | IABIDT_SARE_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـsales return |
| 522 | ACCOUNT | DETAIL_JOURNAL | 1:n | A_DJ | DJ_CODE | AC_DEJO_FK | الحسابات والدفتر العام | ربط account بـdetail journal |
| 523 | IAS_ITM_GRP | VENDOR | n:1 | IIG_VNDR | VNDR_CODE | IAITGR_VE_FK | المخزون والمستودعات | ربط ias itm grp بـvendor |
| 524 | HRS_ATT | HRS_ALLOW_TYP | n:1 | HA_HAT | HAT_CODE | HRAT_HRALTY_FK | الموارد البشرية | ربط hrs att بـhrs allow typ |
| 525 | ITEM_CARD | ITEM_UNIT_PRICE | 1:n | IC_IUP | IUP_CODE | ITCA_ITUNPR_FK | المخزون والمستودعات | ربط item card بـitem unit price |
| 526 | IAS_VNDR_TYP | ACCOUNT | n:1 | IVT_A | A_CODE | IAVNTY_AC_FK | المشتريات والموردين | ربط ias vndr typ بـaccount |
| 527 | IAS_PROJECT_PHASE | IAS_AR_CNTRCT | n:1 | IPP_IAC | IAC_CODE | IAPRPH_IAARCN_FK | المشاريع والعقود | ربط ias project phase بـias ar cntrct |
| 528 | ITEM_COST | WAREHOUSE | n:1 | IC_W | W_CODE | ITCO_WA_FK | المخزون والمستودعات | ربط item cost بـwarehouse |
| 529 | ITEM_COST | STK_PHYS_COUNT | n:1 | IC_SPC | SPC_CODE | ITCO_STPHCO_FK | المخزون والمستودعات | ربط item cost بـstk phys count |
| 530 | IAS_PROJECT_PHASE | IAS_PROJECT_COST | n:1 | IPP_IPC | IPC_CODE | IAPRPH_IAPRCO_FK | المشاريع والعقود | ربط ias project phase بـias project cost |
| 531 | IAS_GUARN_STATUS | GUARN_DETAILS | 1:1 | IGS_GD | GD_CODE | IAGUST_GUDE_FK | الضمانات والكفالات | ربط ias guarn status بـguarn details |
| 532 | IAS_GUARN_TYPE | GR_NOTE | n:1 | IGT_GN | GN_CODE | IAGUTY_GRNO_FK | الضمانات والكفالات | ربط ias guarn type بـgr note |
| 533 | HRS_ATT | HRS_SAL | n:1 | HA_HS | HS_CODE | HRAT_HRSA_FK | الموارد البشرية | ربط hrs att بـhrs sal |
| 534 | ACCOUNT_TYPES | IAS_ACTVTY | n:1 | AT_ACTVTY | ACTVTY_CODE | ACTY_IAAC_FK | الحسابات والدفتر العام | ربط account types بـias actvty |
| 535 | GLS_COST_CENTER_TRANS | MASTER_JOURNAL | n:1 | GCCT_MJ | MJ_CODE | GLCOCETR_MAJO_FK | الحسابات والدفتر العام | ربط gls cost center trans بـmaster journal |
| 536 | ACCOUNT_GROUPING | COST_CENTERS | n:1 | AG_CC | CC_CODE | ACGR_COCE_FK | الحسابات والدفتر العام | ربط account grouping بـcost centers |
| 537 | IAS_USR_AUDIT | APX_SCR_PRV | n:1 | IUA_ASP | ASP_CODE | IAUSAU_APSCPR_FK | النظام والأمن | ربط ias usr audit بـapx scr prv |
| 538 | ACCOUNT_TYPES | ACCOUNT_REPORT_TYPE | 1:n | AT_ART | ART_CODE | ACTY_ACRETY_FK | الحسابات والدفتر العام | ربط account types بـaccount report type |
| 539 | P_ORDER | ITEM_CARD | n:1 | PO_ITM | ITM_CODE | POR_ITCA_FK | المشتريات والموردين | ربط p order بـitem card |
| 540 | IAS_USR_PRF | VENDOR | n:1 | IUP_VNDR | VNDR_CODE | IAUSPR_VE_FK | النظام والأمن | ربط ias usr prf بـvendor |
| 541 | IAS_PROJECT_BUDGET | IAS_PROJECT | n:1 | IPB_IP | IP_CODE | IAPRBU_IAPR_FK | المشاريع والعقود | ربط ias project budget بـias project |
| 542 | IAS_CASH | BANK_CHEQUE | n:1 | IC_BC | BC_CODE | IACA_BACH_FK | النقدية والبنوك | ربط ias cash بـbank cheque |
| 543 | ACCOUNT_REPORT_TYPE | ACCOUNT_CURR | n:1 | ART_AC | AC_CODE | ACRETY_ACCU_FK | الحسابات والدفتر العام | ربط account report type بـaccount curr |
| 544 | STK_MOVMNT | ACCOUNT | n:1 | SM_A | A_CODE | STMO_AC_FK | المخزون والمستودعات | ربط stk movmnt بـaccount |
| 545 | P_ORDER | IAS_PI_BILL | n:1 | PO_IPB | IPB_CODE | POR_IAPIBI_FK | المشتريات والموردين | ربط p order بـias pi bill |
| 546 | IAS_PROJECT | IAS_AP_CNTRCT_DTL | 1:n | IP_IACD | IACD_CODE | IAPR_IAAPCNDT_FK | المشاريع والعقود | ربط ias project بـias ap cntrct dtl |
| 547 | IAS_GUARN_STATUS | GUARN_DETAILS | 1:n | IGS_GD | GD_CODE | IAGUST_GUDE_FK | الضمانات والكفالات | ربط ias guarn status بـguarn details |
| 548 | HRS_SAL | HRS_SAL_DETAIL | 1:1 | HS_HSD | HSD_CODE | HRSA_HRSADE_FK | الموارد البشرية | ربط hrs sal بـhrs sal detail |
| 549 | STK_PHYS_COUNT | ITEM_CARD | n:1 | SPC_ITM | ITM_CODE | STPHCO_ITCA_FK | المخزون والمستودعات | ربط stk phys count بـitem card |
| 550 | CUSTOMER | STN_BILL_DTL | n:1 | C_SBD | SBD_CODE | CU_STBIDT_FK | المبيعات والعملاء | ربط customer بـstn bill dtl |
| 551 | HRS_SAL | S_EMP | n:1 | HS_EMP | EMP_CODE | HRSA_SEM_FK | الموارد البشرية | ربط الراتب بالموظف |
| 552 | IAS_GUARN_TYPE | GUARN_MASTER | 1:n | IGT_GM | GM_CODE | IAGUTY_GUMA_FK | الضمانات والكفالات | ربط ias guarn type بـguarn master |
| 553 | S_JOB | CUSTOMER | n:1 | SJ_CST | CST_CODE | SJO_CU_FK | الموارد البشرية | ربط s job بـcustomer |
| 554 | ACCOUNT_CURR | S_EMP | n:1 | AC_EMP | EMP_CODE | ACCU_SEM_FK | الحسابات والدفتر العام | ربط account curr بـs emp |
| 555 | IAS_DISCOUNT | S_EMP | n:1 | ID_EMP | EMP_CODE | IADI_SEM_FK | المبيعات والعملاء | ربط ias discount بـs emp |
| 556 | IAS_AP_CNTRCT_DTL | IAS_PROJECT_COST | n:1 | IAS_IPC | IPC_CODE | IAAPCNDT_IAPRCO_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias project cost |
| 557 | P_ORDER_DETAIL | P_ORDER | n:1 | P_PO | PO_CODE | PORDE_POR_FK | المشتريات والموردين | ربط تفاصيل p order detail بـp order |
| 558 | ACCOUNT | GLS_COST_CENTER_TRANS | 1:n | A_GCCT | GCCT_CODE | AC_GLCOCETR_FK | الحسابات والدفتر العام | ربط account بـgls cost center trans |
| 559 | IAS_ITM_GRP | MEASUREMENT | 1:1 | IIG_M | M_CODE | IAITGR_ME_FK | المخزون والمستودعات | ربط ias itm grp بـmeasurement |
| 560 | IAS_AP_CNTRCT | IAS_PROJECT_PHASE | 1:n | IAC_IPP | IPP_CODE | IAAPCN_IAPRPH_FK | المشاريع والعقود | ربط ias ap cntrct بـias project phase |
| 561 | APX_FVRT_SCR | APX_SCR | n:1 | AFS_AS | AS_CODE | APFVSC_APSC_FK | النظام والأمن | ربط apx fvrt scr بـapx scr |
| 562 | IAS_USR_AUDIT | IAS_USR_LGN_HSTRY | 1:n | IUA_IULH | IULH_CODE | IAUSAU_IAUSLGHS_FK | النظام والأمن | ربط ias usr audit بـias usr lgn hstry |
| 563 | IAS_USR | IAS_USR_PRF | n:1 | IU_IUP | IUP_CODE | IAUS_IAUSPR_FK | النظام والأمن | ربط ias usr بـias usr prf |
| 564 | ACCOUNT_REPORT_TYPE | DETAIL_JOURNAL | n:1 | ART_DJ | DJ_CODE | ACRETY_DEJO_FK | الحسابات والدفتر العام | ربط account report type بـdetail journal |
| 565 | OPEN_BAL | IAS_CURRENCY | n:1 | OB_CY | CY_CODE | OPBA_IACU_FK | الحسابات والدفتر العام | ربط open bal بـias currency |
| 566 | HRS_EMP_VAC | HRS_SAL | n:1 | HEV_HS | HS_CODE | HREMVA_HRSA_FK | الموارد البشرية | ربط hrs emp vac بـhrs sal |
| 567 | DETAIL_JOURNAL | ACCOUNT | n:1 | DJ_A | A_CODE | DEJO_AC_FK | الحسابات والدفتر العام | ربط تفاصيل القيد بالحساب |
| 568 | GRN_DETAIL | IAS_VNDR_CLSS | n:1 | GRN_IVC | IVC_CODE | GRDE_IAVNCL_FK | المشتريات والموردين | ربط تفاصيل grn detail بـias vndr clss |
| 569 | P_ORDER_DETAIL | IAS_PI_BILL | n:1 | P_IPB | IPB_CODE | PORDE_IAPIBI_FK | المشتريات والموردين | ربط تفاصيل p order detail بـias pi bill |
| 570 | VENDOR | IAS_PI_BILL | 1:n | V_IPB | IPB_CODE | VE_IAPIBI_FK | المشتريات والموردين | ربط vendor بـias pi bill |
| 571 | IAS_VNDR_TYP | IAS_VNDR_CLSS | n:1 | IVT_IVC | IVC_CODE | IAVNTY_IAVNCL_FK | المشتريات والموردين | ربط ias vndr typ بـias vndr clss |
| 572 | ITEM_UNIT_PRICE | IAS_ITM_GRP | n:1 | IUP_IIG | IIG_CODE | ITUNPR_IAITGR_FK | المخزون والمستودعات | ربط item unit price بـias itm grp |
| 573 | GUARN_DETAILS | IAS_GUARN_STATUS | n:1 | GUARN_IGS | IGS_CODE | GUDE_IAGUST_FK | الضمانات والكفالات | ربط guarn details بـias guarn status |
| 574 | IAS_GUARN_TYPE | MASTER_JOURNAL | n:1 | IGT_MJ | MJ_CODE | IAGUTY_MAJO_FK | الضمانات والكفالات | ربط ias guarn type بـmaster journal |
| 575 | GUARN_MASTER | IAS_CURRENCY | n:1 | GM_CY | CY_CODE | GUMA_IACU_FK | الضمانات والكفالات | ربط guarn master بـias currency |
| 576 | ITEM_CARD | ITEM_COST | 1:1 | IC_IC | IC_CODE | ITCA_ITCO_FK | المخزون والمستودعات | ربط item card بـitem cost |
| 577 | GUARN_DETAILS | ITEM_CARD | n:1 | GUARN_ITM | ITM_CODE | GUDE_ITCA_FK | الضمانات والكفالات | ربط guarn details بـitem card |
| 578 | STN_BILL | IAS_BILL_DTL | n:1 | SB_IBD | IBD_CODE | STBI_IABIDT_FK | المبيعات والعملاء | ربط stn bill بـias bill dtl |
| 579 | ITEM_CARD | ACCOUNT | n:1 | IC_A | A_CODE | ITCA_AC_FK | المخزون والمستودعات | ربط item card بـaccount |
| 580 | IAS_DISCOUNT | STN_BILL_DTL | n:m | ID_SBD | SBD_CODE | IADI_STBIDT_FK | المبيعات والعملاء | ربط ias discount بـstn bill dtl |
| 581 | APX_FVRT_SCR | APX_SCR_PRV | 1:n | AFS_ASP | ASP_CODE | APFVSC_APSCPR_FK | النظام والأمن | ربط apx fvrt scr بـapx scr prv |
| 582 | SALES_RETURN | CUSTOMER | n:1 | SR_CST | CST_CODE | SARE_CU_FK | المبيعات والعملاء | ربط sales return بـcustomer |
| 583 | IAS_PROJECT_COST | IAS_PROJECT_BUDGET | 1:n | IPC_IPB | IPB_CODE | IAPRCO_IAPRBU_FK | المشاريع والعقود | ربط ias project cost بـias project budget |
| 584 | BANK_CHEQUE | IAS_BANK_ACCOUNT | n:1 | BC_IBA | IBA_CODE | BACH_IABAAC_FK | النقدية والبنوك | ربط bank cheque بـias bank account |
| 585 | IAS_ITM_GRP | S_EMP | n:1 | IIG_EMP | EMP_CODE | IAITGR_SEM_FK | المخزون والمستودعات | ربط ias itm grp بـs emp |
| 586 | IAS_AP_CNTRCT_DTL | IAS_PROJECT_COST | n:1 | IAS_IPC | IPC_CODE | IAAPCNDT_IAPRCO_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias project cost |
| 587 | ITEM_CARD | STK_PHYS_COUNT | n:1 | IC_SPC | SPC_CODE | ITCA_STPHCO_FK | المخزون والمستودعات | ربط item card بـstk phys count |
| 588 | HRS_VAC_TYP | S_EMP | n:1 | HVT_EMP | EMP_CODE | HRVATY_SEM_FK | الموارد البشرية | ربط hrs vac typ بـs emp |
| 589 | GUARN_DETAILS | IAS_GUARN_TYPE | n:1 | GUARN_IGT | IGT_CODE | GUDE_IAGUTY_FK | الضمانات والكفالات | ربط guarn details بـias guarn type |
| 590 | IAS_DISCOUNT | IAS_BILL_DTL | 1:n | ID_IBD | IBD_CODE | IADI_IABIDT_FK | المبيعات والعملاء | ربط ias discount بـias bill dtl |
| 591 | BANK_CHEQUE | IAS_BANK | n:1 | BC_IB | IB_CODE | BACH_IABA_FK | النقدية والبنوك | ربط bank cheque بـias bank |
| 592 | IAS_USR_LGN_HSTRY | IAS_USR_PRF | n:1 | IULH_IUP | IUP_CODE | IAUSLGHS_IAUSPR_FK | النظام والأمن | ربط ias usr lgn hstry بـias usr prf |
| 593 | OPEN_BAL | ACCOUNT | n:1 | OB_A | A_CODE | OPBA_AC_FK | الحسابات والدفتر العام | ربط open bal بـaccount |
| 594 | GLS_COST_CENTER_TRANS | ACCOUNT_TYPES | n:1 | GCCT_AT | AT_CODE | GLCOCETR_ACTY_FK | الحسابات والدفتر العام | ربط gls cost center trans بـaccount types |
| 595 | IAS_BILL | STN_BILL_DTL | n:1 | IB_SBD | SBD_CODE | IABI_STBIDT_FK | المبيعات والعملاء | ربط ias bill بـstn bill dtl |
| 596 | IAS_BANK | CUSTOMER | n:1 | IB_CST | CST_CODE | IABA_CU_FK | النقدية والبنوك | ربط ias bank بـcustomer |
| 597 | IAS_BANK_ACCOUNT | BANK_CHEQUE | 1:1 | IBA_BC | BC_CODE | IABAAC_BACH_FK | النقدية والبنوك | ربط ias bank account بـbank cheque |
| 598 | IAS_USR_LGN_HSTRY | APX_SCR | n:1 | IULH_AS | AS_CODE | IAUSLGHS_APSC_FK | النظام والأمن | ربط ias usr lgn hstry بـapx scr |
| 599 | IAS_GUARN_STATUS | GUARN_DETAILS | n:1 | IGS_GD | GD_CODE | IAGUST_GUDE_FK | الضمانات والكفالات | ربط ias guarn status بـguarn details |
| 600 | IAS_PI_BILL | VENDOR | n:1 | IPB_VNDR | VNDR_CODE | IAPIBI_VE_FK | المشتريات والموردين | ربط فاتورة المشتريات بالمورد |
| 601 | IAS_DISCOUNT | CUSTOMER | n:1 | ID_CST | CST_CODE | IADI_CU_FK | المبيعات والعملاء | ربط ias discount بـcustomer |
| 602 | IAS_GUARN_TYPE | IAS_USR | n:1 | IGT_IU | IU_CODE | IAGUTY_IAUS_FK | الضمانات والكفالات | ربط ias guarn type بـias usr |
| 603 | APX_SCR_PRV | ACCOUNT | n:1 | ASP_A | A_CODE | APSCPR_AC_FK | النظام والأمن | ربط apx scr prv بـaccount |
| 604 | DETAIL_JOURNAL | ACCOUNT_TYPES | n:1 | DJ_AT | AT_CODE | DEJO_ACTY_FK | الحسابات والدفتر العام | ربط detail journal بـaccount types |
| 605 | ACCOUNT_TYPES | DETAIL_JOURNAL | 1:n | AT_DJ | DJ_CODE | ACTY_DEJO_FK | الحسابات والدفتر العام | ربط account types بـdetail journal |
| 606 | IAS_ITM_CLSS | STK_MOVMNT | n:1 | IIC_SM | SM_CODE | IAITCL_STMO_FK | المخزون والمستودعات | ربط ias itm clss بـstk movmnt |
| 607 | IAS_CST_CLSS | STN_BILL_DTL | 1:n | ICC_SBD | SBD_CODE | IACSCL_STBIDT_FK | المبيعات والعملاء | ربط ias cst clss بـstn bill dtl |
| 608 | ACCOUNT_TYPES | ACCOUNT_REPORT_TYPE | n:1 | AT_ART | ART_CODE | ACTY_ACRETY_FK | الحسابات والدفتر العام | ربط account types بـaccount report type |
| 609 | IAS_GUARN_STATUS | GUARN_DETAILS | n:1 | IGS_GD | GD_CODE | IAGUST_GUDE_FK | الضمانات والكفالات | ربط ias guarn status بـguarn details |
| 610 | IAS_GUARN_TYPE | GUARN_DETAILS | 1:n | IGT_GD | GD_CODE | IAGUTY_GUDE_FK | الضمانات والكفالات | ربط ias guarn type بـguarn details |
| 611 | HRS_SAL_DETAIL | HRS_EMP_VAC | 1:n | HRS_HEV | HEV_CODE | HRSADE_HREMVA_FK | الموارد البشرية | ربط تفاصيل hrs sal detail بـhrs emp vac |
| 612 | S_EMP | IAS_USR | n:1 | SE_IU | IU_CODE | SEM_IAUS_FK | الموارد البشرية | ربط s emp بـias usr |
| 613 | STK_PHYS_COUNT | STK_MOVMNT | n:1 | SPC_SM | SM_CODE | STPHCO_STMO_FK | المخزون والمستودعات | ربط stk phys count بـstk movmnt |
| 614 | IAS_GUARN_STATUS | ITEM_CARD | n:1 | IGS_ITM | ITM_CODE | IAGUST_ITCA_FK | الضمانات والكفالات | ربط ias guarn status بـitem card |
| 615 | GRN_MASTER | P_ORDER_DETAIL | n:1 | GM_POD | POD_CODE | GRMA_PORDE_FK | المشتريات والموردين | ربط grn master بـp order detail |
| 616 | IAS_GUARN_TYPE | GR_NOTE | n:1 | IGT_GN | GN_CODE | IAGUTY_GRNO_FK | الضمانات والكفالات | ربط ias guarn type بـgr note |
| 617 | IAS_USR_LGN_HSTRY | IAS_GRP | 1:n | IULH_IG | IG_CODE | IAUSLGHS_IAGR_FK | النظام والأمن | ربط ias usr lgn hstry بـias grp |
| 618 | IAS_PROJECT_BUDGET | IAS_AP_CNTRCT_DTL | n:1 | IPB_IACD | IACD_CODE | IAPRBU_IAAPCNDT_FK | المشاريع والعقود | ربط ias project budget بـias ap cntrct dtl |
| 619 | GRN_MASTER | P_ORDER | n:1 | GM_PO | PO_CODE | GRMA_POR_FK | المشتريات والموردين | ربط grn master بـp order |
| 620 | IAS_DISCOUNT | COST_CENTERS | n:1 | ID_CC | CC_CODE | IADI_COCE_FK | المبيعات والعملاء | ربط ias discount بـcost centers |
| 621 | ACCOUNT_CURR | ACCOUNT | n:1 | AC_A | A_CODE | ACCU_AC_FK | الحسابات والدفتر العام | ربط account curr بـaccount |
| 622 | IAS_VNDR_TYP | IAS_PI_BILL | 1:1 | IVT_IPB | IPB_CODE | IAVNTY_IAPIBI_FK | المشتريات والموردين | ربط ias vndr typ بـias pi bill |
| 623 | IAS_BILL_DTL | STN_BILL_DTL | 1:n | IAS_SBD | SBD_CODE | IABIDT_STBIDT_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـstn bill dtl |
| 624 | MEASUREMENT | ITEM_UNIT_PRICE | 1:n | M_IUP | IUP_CODE | ME_ITUNPR_FK | المخزون والمستودعات | ربط measurement بـitem unit price |
| 625 | MASTER_JOURNAL | IAS_ACTVTY | n:1 | MJ_ACTVTY | ACTVTY_CODE | MAJO_IAAC_FK | الحسابات والدفتر العام | ربط master journal بـias actvty |
| 626 | CUSTOMER | COST_CENTERS | n:1 | C_CC | CC_CODE | CU_COCE_FK | المبيعات والعملاء | ربط customer بـcost centers |
| 627 | IAS_USR_AUDIT | VENDOR | n:1 | IUA_VNDR | VNDR_CODE | IAUSAU_VE_FK | النظام والأمن | ربط ias usr audit بـvendor |
| 628 | IAS_AR_CNTRCT | IAS_AP_CNTRCT | n:1 | IAC_IAC | IAC_CODE | IAARCN_IAAPCN_FK | المشاريع والعقود | ربط ias ar cntrct بـias ap cntrct |
| 629 | HRS_SAL_DETAIL | HRS_SAL_DETAIL | n:m | HRS_HSD | HSD_CODE | HRSADE_HRSADE_FK | الموارد البشرية | ربط تفاصيل hrs sal detail بـhrs sal detail |
| 630 | APX_SCR_PRV | IAS_USR | n:1 | ASP_IU | IU_CODE | APSCPR_IAUS_FK | النظام والأمن | ربط apx scr prv بـias usr |
| 631 | ACCOUNT_TYPES | DETAIL_JOURNAL | n:1 | AT_DJ | DJ_CODE | ACTY_DEJO_FK | الحسابات والدفتر العام | ربط account types بـdetail journal |
| 632 | S_JOB | IAS_USR | n:1 | SJ_IU | IU_CODE | SJO_IAUS_FK | الموارد البشرية | ربط s job بـias usr |
| 633 | IAS_USR_AUDIT | APX_SCR | n:1 | IUA_AS | AS_CODE | IAUSAU_APSC_FK | النظام والأمن | ربط ias usr audit بـapx scr |
| 634 | IAS_BILL | SALES_RETURN | n:1 | IB_SR | SR_CODE | IABI_SARE_FK | المبيعات والعملاء | ربط ias bill بـsales return |
| 635 | IAS_PROJECT | IAS_AR_CNTRCT | n:1 | IP_IAC | IAC_CODE | IAPR_IAARCN_FK | المشاريع والعقود | ربط ias project بـias ar cntrct |
| 636 | IAS_VNDR_TYP | GRN_MASTER | n:1 | IVT_GM | GM_CODE | IAVNTY_GRMA_FK | المشتريات والموردين | ربط ias vndr typ بـgrn master |
| 637 | IAS_GUARN_STATUS | GUARN_MASTER | n:m | IGS_GM | GM_CODE | IAGUST_GUMA_FK | الضمانات والكفالات | ربط ias guarn status بـguarn master |
| 638 | STK_MOVMNT | IAS_ITM_CLSS | 1:n | SM_IIC | IIC_CODE | STMO_IAITCL_FK | المخزون والمستودعات | ربط stk movmnt بـias itm clss |
| 639 | IAS_USR | IAS_USR_LGN_HSTRY | 1:n | IU_IULH | IULH_CODE | IAUS_IAUSLGHS_FK | النظام والأمن | ربط ias usr بـias usr lgn hstry |
| 640 | IAS_CST_CLSS | CUSTOMER | n:1 | ICC_CST | CST_CODE | IACSCL_CU_FK | المبيعات والعملاء | ربط ias cst clss بـcustomer |
| 641 | IAS_USR | IAS_GRP | n:1 | IU_IG | IG_CODE | IAUS_IAGR_FK | النظام والأمن | ربط ias usr بـias grp |
| 642 | S_EMP | ITEM_CARD | n:1 | SE_ITM | ITM_CODE | SEM_ITCA_FK | الموارد البشرية | ربط s emp بـitem card |
| 643 | GR_NOTE | GUARN_MASTER | 1:n | GN_GM | GM_CODE | GRNO_GUMA_FK | الضمانات والكفالات | ربط gr note بـguarn master |
| 644 | HRS_VAC_TYP | HRS_ATT | 1:n | HVT_HA | HA_CODE | HRVATY_HRAT_FK | الموارد البشرية | ربط hrs vac typ بـhrs att |
| 645 | HRS_ALLOW_TYP | S_EMP | n:1 | HAT_EMP | EMP_CODE | HRALTY_SEM_FK | الموارد البشرية | ربط hrs allow typ بـs emp |
| 646 | IAS_GRP | ITEM_CARD | n:1 | IG_ITM | ITM_CODE | IAGR_ITCA_FK | النظام والأمن | ربط ias grp بـitem card |
| 647 | IAS_GUARN_STATUS | GUARN_MASTER | 1:n | IGS_GM | GM_CODE | IAGUST_GUMA_FK | الضمانات والكفالات | ربط ias guarn status بـguarn master |
| 648 | DETAIL_JOURNAL | VENDOR | n:1 | DJ_VNDR | VNDR_CODE | DEJO_VE_FK | الحسابات والدفتر العام | ربط detail journal بـvendor |
| 649 | HRS_SAL_DETAIL | HRS_VAC_TYP | 1:n | HRS_HVT | HVT_CODE | HRSADE_HRVATY_FK | الموارد البشرية | ربط تفاصيل hrs sal detail بـhrs vac typ |
| 650 | APX_SCR_PRV | APX_FVRT_SCR | n:1 | ASP_AFS | AFS_CODE | APSCPR_APFVSC_FK | النظام والأمن | ربط apx scr prv بـapx fvrt scr |
| 651 | VENDOR | IAS_VNDR_TYP | 1:n | V_IVT | IVT_CODE | VE_IAVNTY_FK | المشتريات والموردين | ربط المورد بنوع المورد |
| 652 | IAS_AP_CNTRCT | IAS_PROJECT_BUDGET | n:1 | IAC_IPB | IPB_CODE | IAAPCN_IAPRBU_FK | المشاريع والعقود | ربط ias ap cntrct بـias project budget |
| 653 | IAS_PROJECT_PHASE | IAS_PROJECT_COST | n:1 | IPP_IPC | IPC_CODE | IAPRPH_IAPRCO_FK | المشاريع والعقود | ربط ias project phase بـias project cost |
| 654 | APX_SCR_PRV | S_EMP | n:1 | ASP_EMP | EMP_CODE | APSCPR_SEM_FK | النظام والأمن | ربط apx scr prv بـs emp |
| 655 | BANK_CHEQUE | IAS_BANK | 1:1 | BC_IB | IB_CODE | BACH_IABA_FK | النقدية والبنوك | ربط bank cheque بـias bank |
| 656 | P_ORDER_DETAIL | ITEM_CARD | n:1 | P_ITM | ITM_CODE | PORDE_ITCA_FK | المشتريات والموردين | ربط تفاصيل p order detail بـitem card |
| 657 | DETAIL_JOURNAL | IAS_CURRENCY | n:1 | DJ_CY | CY_CODE | DEJO_IACU_FK | الحسابات والدفتر العام | ربط detail journal بـias currency |
| 658 | GUARN_MASTER | GUARN_DETAILS | 1:n | GM_GD | GD_CODE | GUMA_GUDE_FK | الضمانات والكفالات | ربط guarn master بـguarn details |
| 659 | WAREHOUSE | IAS_ITM_GRP | n:1 | W_IIG | IIG_CODE | WA_IAITGR_FK | المخزون والمستودعات | ربط warehouse بـias itm grp |
| 660 | S_DEPT | HRS_VAC_TYP | n:1 | SD_HVT | HVT_CODE | SDE_HRVATY_FK | الموارد البشرية | ربط s dept بـhrs vac typ |
| 661 | STN_BILL_DTL | IAS_DISCOUNT | n:1 | STN_ID | ID_CODE | STBIDT_IADI_FK | المبيعات والعملاء | ربط تفاصيل stn bill dtl بـias discount |
| 662 | GUARN_DETAILS | IAS_GUARN_TYPE | 1:n | GUARN_IGT | IGT_CODE | GUDE_IAGUTY_FK | الضمانات والكفالات | ربط guarn details بـias guarn type |
| 663 | IAS_USR | IAS_GRP | n:1 | IU_IG | IG_CODE | IAUS_IAGR_FK | النظام والأمن | ربط ias usr بـias grp |
| 664 | IAS_AR_CNTRCT | IAS_PROJECT | n:1 | IAC_IP | IP_CODE | IAARCN_IAPR_FK | المشاريع والعقود | ربط ias ar cntrct بـias project |
| 665 | IAS_GUARN_TYPE | IAS_GUARN_STATUS | n:1 | IGT_IGS | IGS_CODE | IAGUTY_IAGUST_FK | الضمانات والكفالات | ربط ias guarn type بـias guarn status |
| 666 | ITEM_COST | MEASUREMENT | n:1 | IC_M | M_CODE | ITCO_ME_FK | المخزون والمستودعات | ربط item cost بـmeasurement |
| 667 | ACCOUNT_TYPES | DETAIL_JOURNAL | n:1 | AT_DJ | DJ_CODE | ACTY_DEJO_FK | الحسابات والدفتر العام | ربط account types بـdetail journal |
| 668 | S_DEPT | S_EMP | n:1 | SD_EMP | EMP_CODE | SDE_SEM_FK | الموارد البشرية | ربط s dept بـs emp |
| 669 | ITEM_CARD | ITEM_UNIT_PRICE | n:1 | IC_IUP | IUP_CODE | ITCA_ITUNPR_FK | المخزون والمستودعات | ربط item card بـitem unit price |
| 670 | IAS_USR_AUDIT | IAS_USR | n:1 | IUA_IU | IU_CODE | IAUSAU_IAUS_FK | النظام والأمن | ربط ias usr audit بـias usr |
| 671 | STK_PHYS_COUNT | IAS_ITM_CLSS | n:1 | SPC_IIC | IIC_CODE | STPHCO_IAITCL_FK | المخزون والمستودعات | ربط stk phys count بـias itm clss |
| 672 | P_ORDER_DETAIL | IAS_VNDR_TYP | n:1 | P_IVT | IVT_CODE | PORDE_IAVNTY_FK | المشتريات والموردين | ربط تفاصيل p order detail بـias vndr typ |
| 673 | ACCOUNT_TYPES | IAS_CURRENCY | n:1 | AT_CY | CY_CODE | ACTY_IACU_FK | الحسابات والدفتر العام | ربط account types بـias currency |
| 674 | HRS_ATT | HRS_SAL_DETAIL | n:1 | HA_HSD | HSD_CODE | HRAT_HRSADE_FK | الموارد البشرية | ربط hrs att بـhrs sal detail |
| 675 | S_JOB | HRS_SAL | n:1 | SJ_HS | HS_CODE | SJO_HRSA_FK | الموارد البشرية | ربط s job بـhrs sal |
| 676 | S_JOB | HRS_ALLOW_TYP | 1:n | SJ_HAT | HAT_CODE | SJO_HRALTY_FK | الموارد البشرية | ربط s job بـhrs allow typ |
| 677 | HRS_SAL_DETAIL | HRS_EMP_VAC | n:1 | HRS_HEV | HEV_CODE | HRSADE_HREMVA_FK | الموارد البشرية | ربط تفاصيل hrs sal detail بـhrs emp vac |
| 678 | CUSTOMER | IAS_BILL_DTL | n:1 | C_IBD | IBD_CODE | CU_IABIDT_FK | المبيعات والعملاء | ربط customer بـias bill dtl |
| 679 | P_ORDER_DETAIL | GRN_MASTER | 1:n | P_GM | GM_CODE | PORDE_GRMA_FK | المشتريات والموردين | ربط تفاصيل p order detail بـgrn master |
| 680 | CASH_RECEIPT | CASH_PAYMENT | 1:n | CR_CP | CP_CODE | CARE_CAPA_FK | النقدية والبنوك | ربط cash receipt بـcash payment |
| 681 | ACCOUNT_REPORT_TYPE | CUSTOMER | n:1 | ART_CST | CST_CODE | ACRETY_CU_FK | الحسابات والدفتر العام | ربط account report type بـcustomer |
| 682 | HRS_SAL | HRS_ALLOW_TYP | 1:1 | HS_HAT | HAT_CODE | HRSA_HRALTY_FK | الموارد البشرية | ربط hrs sal بـhrs allow typ |
| 683 | IAS_AP_CNTRCT | S_EMP | n:1 | IAC_EMP | EMP_CODE | IAAPCN_SEM_FK | المشاريع والعقود | ربط ias ap cntrct بـs emp |
| 684 | IAS_USR | APX_SCR_PRV | n:1 | IU_ASP | ASP_CODE | IAUS_APSCPR_FK | النظام والأمن | ربط ias usr بـapx scr prv |
| 685 | DETAIL_JOURNAL | ACCOUNT_GROUPING | n:1 | DJ_AG | AG_CODE | DEJO_ACGR_FK | الحسابات والدفتر العام | ربط detail journal بـaccount grouping |
| 686 | VENDOR | P_ORDER | n:1 | V_PO | PO_CODE | VE_POR_FK | المشتريات والموردين | ربط vendor بـp order |
| 687 | CUSTOMER | IAS_CURRENCY | n:1 | C_CY | CY_CODE | CU_IACU_FK | المبيعات والعملاء | ربط customer بـias currency |
| 688 | IAS_PI_BILL_DTL | IAS_VNDR_TYP | n:1 | IAS_IVT | IVT_CODE | IAPIBIDT_IAVNTY_FK | المشتريات والموردين | ربط تفاصيل ias pi bill dtl بـias vndr typ |
| 689 | GUARN_DETAILS | IAS_GUARN_STATUS | n:1 | GUARN_IGS | IGS_CODE | GUDE_IAGUST_FK | الضمانات والكفالات | ربط guarn details بـias guarn status |
| 690 | ITEM_UNIT_PRICE | CUSTOMER | n:1 | IUP_CST | CST_CODE | ITUNPR_CU_FK | المخزون والمستودعات | ربط item unit price بـcustomer |
| 691 | IAS_USR_PRF | MASTER_JOURNAL | n:1 | IUP_MJ | MJ_CODE | IAUSPR_MAJO_FK | النظام والأمن | ربط ias usr prf بـmaster journal |
| 692 | ACCOUNT_REPORT_TYPE | MASTER_JOURNAL | n:1 | ART_MJ | MJ_CODE | ACRETY_MAJO_FK | الحسابات والدفتر العام | ربط account report type بـmaster journal |
| 693 | IAS_PROJECT | COST_CENTERS | n:1 | IP_CC | CC_CODE | IAPR_COCE_FK | المشاريع والعقود | ربط ias project بـcost centers |
| 694 | HRS_SAL_DETAIL | S_DEPT | n:1 | HRS_SD | SD_CODE | HRSADE_SDE_FK | الموارد البشرية | ربط تفاصيل hrs sal detail بـs dept |
| 695 | ITEM_UNIT_PRICE | MEASUREMENT | n:1 | IUP_M | M_CODE | ITUNPR_ME_FK | المخزون والمستودعات | ربط item unit price بـmeasurement |
| 696 | MASTER_JOURNAL | ACCOUNT | n:1 | MJ_A | A_CODE | MAJO_AC_FK | الحسابات والدفتر العام | ربط master journal بـaccount |
| 697 | IAS_GUARN_TYPE | GUARN_MASTER | n:1 | IGT_GM | GM_CODE | IAGUTY_GUMA_FK | الضمانات والكفالات | ربط ias guarn type بـguarn master |
| 698 | GR_NOTE | IAS_GUARN_STATUS | n:1 | GN_IGS | IGS_CODE | GRNO_IAGUST_FK | الضمانات والكفالات | ربط gr note بـias guarn status |
| 699 | HRS_EMP_VAC | S_JOB | n:1 | HEV_SJ | SJ_CODE | HREMVA_SJO_FK | الموارد البشرية | ربط hrs emp vac بـs job |
| 700 | S_DEPT | HRS_EMP_VAC | n:1 | SD_HEV | HEV_CODE | SDE_HREMVA_FK | الموارد البشرية | ربط s dept بـhrs emp vac |
| 701 | APX_SCR_PRV | ITEM_CARD | n:1 | ASP_ITM | ITM_CODE | APSCPR_ITCA_FK | النظام والأمن | ربط apx scr prv بـitem card |
| 702 | P_ORDER | GRN_MASTER | n:1 | PO_GM | GM_CODE | POR_GRMA_FK | المشتريات والموردين | ربط p order بـgrn master |
| 703 | WAREHOUSE | ITEM_CARD | n:1 | W_ITM | ITM_CODE | WA_ITCA_FK | المخزون والمستودعات | ربط warehouse بـitem card |
| 704 | WAREHOUSE | MASTER_JOURNAL | n:1 | W_MJ | MJ_CODE | WA_MAJO_FK | المخزون والمستودعات | ربط warehouse بـmaster journal |
| 705 | IAS_USR_LGN_HSTRY | COST_CENTERS | n:1 | IULH_CC | CC_CODE | IAUSLGHS_COCE_FK | النظام والأمن | ربط ias usr lgn hstry بـcost centers |
| 706 | MEASUREMENT | ITEM_CARD | n:1 | M_ITM | ITM_CODE | ME_ITCA_FK | المخزون والمستودعات | ربط measurement بـitem card |
| 707 | HRS_EMP_VAC | HRS_ALLOW_TYP | n:1 | HEV_HAT | HAT_CODE | HREMVA_HRALTY_FK | الموارد البشرية | ربط hrs emp vac بـhrs allow typ |
| 708 | IAS_ITM_GRP | COST_CENTERS | n:1 | IIG_CC | CC_CODE | IAITGR_COCE_FK | المخزون والمستودعات | ربط ias itm grp بـcost centers |
| 709 | IAS_AP_CNTRCT | IAS_PROJECT_COST | n:1 | IAC_IPC | IPC_CODE | IAAPCN_IAPRCO_FK | المشاريع والعقود | ربط ias ap cntrct بـias project cost |
| 710 | ACCOUNT_CURR | GLS_COST_CENTER_TRANS | n:1 | AC_GCCT | GCCT_CODE | ACCU_GLCOCETR_FK | الحسابات والدفتر العام | ربط account curr بـgls cost center trans |
| 711 | IAS_PI_BILL | VENDOR | n:1 | IPB_VNDR | VNDR_CODE | IAPIBI_VE_FK | المشتريات والموردين | ربط فاتورة المشتريات بالمورد |
| 712 | IAS_GUARN_TYPE | GUARN_DETAILS | n:1 | IGT_GD | GD_CODE | IAGUTY_GUDE_FK | الضمانات والكفالات | ربط ias guarn type بـguarn details |
| 713 | IAS_GUARN_STATUS | COST_CENTERS | n:1 | IGS_CC | CC_CODE | IAGUST_COCE_FK | الضمانات والكفالات | ربط ias guarn status بـcost centers |
| 714 | GR_NOTE | IAS_GUARN_STATUS | n:1 | GN_IGS | IGS_CODE | GRNO_IAGUST_FK | الضمانات والكفالات | ربط gr note بـias guarn status |
| 715 | IAS_BILL | SALES_RETURN | n:1 | IB_SR | SR_CODE | IABI_SARE_FK | المبيعات والعملاء | ربط ias bill بـsales return |
| 716 | IAS_ITM_GRP | STK_MOVMNT | n:1 | IIG_SM | SM_CODE | IAITGR_STMO_FK | المخزون والمستودعات | ربط ias itm grp بـstk movmnt |
| 717 | IAS_GUARN_TYPE | GUARN_MASTER | 1:n | IGT_GM | GM_CODE | IAGUTY_GUMA_FK | الضمانات والكفالات | ربط ias guarn type بـguarn master |
| 718 | CUSTOMER | STN_BILL_DTL | n:1 | C_SBD | SBD_CODE | CU_STBIDT_FK | المبيعات والعملاء | ربط customer بـstn bill dtl |
| 719 | ACCOUNT_CURR | ACCOUNT_TYPES | n:1 | AC_AT | AT_CODE | ACCU_ACTY_FK | الحسابات والدفتر العام | ربط account curr بـaccount types |
| 720 | IAS_VNDR_TYP | IAS_PI_BILL_DTL | n:1 | IVT_IPBD | IPBD_CODE | IAVNTY_IAPIBIDT_FK | المشتريات والموردين | ربط ias vndr typ بـias pi bill dtl |
| 721 | IAS_GRP | CUSTOMER | n:1 | IG_CST | CST_CODE | IAGR_CU_FK | النظام والأمن | ربط ias grp بـcustomer |
| 722 | GRN_DETAIL | IAS_PI_BILL | n:1 | GRN_IPB | IPB_CODE | GRDE_IAPIBI_FK | المشتريات والموردين | ربط تفاصيل grn detail بـias pi bill |
| 723 | IAS_GUARN_STATUS | GUARN_DETAILS | n:1 | IGS_GD | GD_CODE | IAGUST_GUDE_FK | الضمانات والكفالات | ربط ias guarn status بـguarn details |
| 724 | IAS_PI_BILL_DTL | GRN_MASTER | n:m | IAS_GM | GM_CODE | IAPIBIDT_GRMA_FK | المشتريات والموردين | ربط تفاصيل ias pi bill dtl بـgrn master |
| 725 | IAS_CASH_OUTGOING | IAS_USR | n:1 | ICO_IU | IU_CODE | IACAOU_IAUS_FK | النقدية والبنوك | ربط ias cash outgoing بـias usr |
| 726 | IAS_AP_CNTRCT | IAS_AP_CNTRCT_DTL | n:1 | IAC_IACD | IACD_CODE | IAAPCN_IAAPCNDT_FK | المشاريع والعقود | ربط ias ap cntrct بـias ap cntrct dtl |
| 727 | IAS_PI_BILL_DTL | P_ORDER | n:1 | IAS_PO | PO_CODE | IAPIBIDT_POR_FK | المشتريات والموردين | ربط تفاصيل ias pi bill dtl بـp order |
| 728 | GUARN_DETAILS | COST_CENTERS | n:1 | GUARN_CC | CC_CODE | GUDE_COCE_FK | الضمانات والكفالات | ربط guarn details بـcost centers |
| 729 | IAS_BANK | IAS_BANK_ACCOUNT | n:1 | IB_IBA | IBA_CODE | IABA_IABAAC_FK | النقدية والبنوك | ربط ias bank بـias bank account |
| 730 | ACCOUNT_TYPES | MASTER_JOURNAL | n:1 | AT_MJ | MJ_CODE | ACTY_MAJO_FK | الحسابات والدفتر العام | ربط account types بـmaster journal |
| 731 | IAS_AP_CNTRCT_DTL | IAS_AP_CNTRCT | n:1 | IAS_IAC | IAC_CODE | IAAPCNDT_IAAPCN_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias ap cntrct |
| 732 | IAS_GRP | IAS_USR | n:1 | IG_IU | IU_CODE | IAGR_IAUS_FK | النظام والأمن | ربط ias grp بـias usr |
| 733 | IAS_GUARN_STATUS | IAS_USR | n:1 | IGS_IU | IU_CODE | IAGUST_IAUS_FK | الضمانات والكفالات | ربط ias guarn status بـias usr |
| 734 | S_EMP | S_DEPT | n:1 | SE_SD | SD_CODE | SEM_SDE_FK | الموارد البشرية | ربط الموظف بالقسم |
| 735 | HRS_SAL | S_JOB | n:1 | HS_SJ | SJ_CODE | HRSA_SJO_FK | الموارد البشرية | ربط hrs sal بـs job |
| 736 | IAS_VNDR_CLSS | P_ORDER | n:1 | IVC_PO | PO_CODE | IAVNCL_POR_FK | المشتريات والموردين | ربط ias vndr clss بـp order |
| 737 | HRS_EMP_VAC | S_EMP | n:1 | HEV_EMP | EMP_CODE | HREMVA_SEM_FK | الموارد البشرية | ربط hrs emp vac بـs emp |
| 738 | HRS_VAC_TYP | IAS_ACTVTY | n:1 | HVT_ACTVTY | ACTVTY_CODE | HRVATY_IAAC_FK | الموارد البشرية | ربط hrs vac typ بـias actvty |
| 739 | IAS_GUARN_TYPE | GUARN_DETAILS | n:1 | IGT_GD | GD_CODE | IAGUTY_GUDE_FK | الضمانات والكفالات | ربط ias guarn type بـguarn details |
| 740 | IAS_AP_CNTRCT | IAS_PROJECT_BUDGET | n:1 | IAC_IPB | IPB_CODE | IAAPCN_IAPRBU_FK | المشاريع والعقود | ربط ias ap cntrct بـias project budget |
| 741 | IAS_CASH_INCOME | BANK_CHEQUE | n:1 | ICI_BC | BC_CODE | IACAIN_BACH_FK | النقدية والبنوك | ربط ias cash income بـbank cheque |
| 742 | ACCOUNT | ACCOUNT_CURR | n:1 | A_AC | AC_CODE | AC_ACCU_FK | الحسابات والدفتر العام | ربط account بـaccount curr |
| 743 | MEASUREMENT | IAS_ITM_GRP | n:1 | M_IIG | IIG_CODE | ME_IAITGR_FK | المخزون والمستودعات | ربط measurement بـias itm grp |
| 744 | IAS_BANK | IAS_BANK_ACCOUNT | n:1 | IB_IBA | IBA_CODE | IABA_IABAAC_FK | النقدية والبنوك | ربط ias bank بـias bank account |
| 745 | IAS_BANK | IAS_BANK_ACCOUNT | 1:1 | IB_IBA | IBA_CODE | IABA_IABAAC_FK | النقدية والبنوك | ربط ias bank بـias bank account |
| 746 | IAS_PROJECT | IAS_PROJECT_PHASE | n:1 | IP_IPP | IPP_CODE | IAPR_IAPRPH_FK | المشاريع والعقود | ربط ias project بـias project phase |
| 747 | IAS_CASH | ITEM_CARD | n:1 | IC_ITM | ITM_CODE | IACA_ITCA_FK | النقدية والبنوك | ربط ias cash بـitem card |
| 748 | IAS_BILL_DTL | IAS_CST_TYP | 1:n | IAS_ICT | ICT_CODE | IABIDT_IACSTY_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـias cst typ |
| 749 | HRS_ATT | S_JOB | n:1 | HA_SJ | SJ_CODE | HRAT_SJO_FK | الموارد البشرية | ربط hrs att بـs job |
| 750 | IAS_GUARN_TYPE | COST_CENTERS | n:1 | IGT_CC | CC_CODE | IAGUTY_COCE_FK | الضمانات والكفالات | ربط ias guarn type بـcost centers |
| 751 | VENDOR | P_ORDER | n:1 | V_PO | PO_CODE | VE_POR_FK | المشتريات والموردين | ربط vendor بـp order |
| 752 | IAS_VNDR_TYP | IAS_VNDR_CLSS | 1:n | IVT_IVC | IVC_CODE | IAVNTY_IAVNCL_FK | المشتريات والموردين | ربط ias vndr typ بـias vndr clss |
| 753 | IAS_VNDR_TYP | GRN_MASTER | n:1 | IVT_GM | GM_CODE | IAVNTY_GRMA_FK | المشتريات والموردين | ربط ias vndr typ بـgrn master |
| 754 | STK_MOVMNT | ITEM_UNIT_PRICE | n:1 | SM_IUP | IUP_CODE | STMO_ITUNPR_FK | المخزون والمستودعات | ربط stk movmnt بـitem unit price |
| 755 | IAS_BILL | IAS_BILL_DTL | 1:n | IB_IBD | IBD_CODE | IABI_IABIDT_FK | المبيعات والعملاء | ربط ias bill بـias bill dtl |
| 756 | OPEN_BAL | ACCOUNT_TYPES | n:1 | OB_AT | AT_CODE | OPBA_ACTY_FK | الحسابات والدفتر العام | ربط open bal بـaccount types |
| 757 | IAS_BANK_ACCOUNT | IAS_CASH_INCOME | n:1 | IBA_ICI | ICI_CODE | IABAAC_IACAIN_FK | النقدية والبنوك | ربط ias bank account بـias cash income |
| 758 | IAS_PROJECT | IAS_PROJECT_PHASE | n:1 | IP_IPP | IPP_CODE | IAPR_IAPRPH_FK | المشاريع والعقود | ربط ias project بـias project phase |
| 759 | IAS_GUARN_STATUS | GUARN_MASTER | n:1 | IGS_GM | GM_CODE | IAGUST_GUMA_FK | الضمانات والكفالات | ربط ias guarn status بـguarn master |
| 760 | HRS_EMP_VAC | S_DEPT | n:1 | HEV_SD | SD_CODE | HREMVA_SDE_FK | الموارد البشرية | ربط hrs emp vac بـs dept |
| 761 | CASH_RECEIPT | IAS_BANK_ACCOUNT | 1:n | CR_IBA | IBA_CODE | CARE_IABAAC_FK | النقدية والبنوك | ربط cash receipt بـias bank account |
| 762 | HRS_ATT | HRS_VAC_TYP | n:1 | HA_HVT | HVT_CODE | HRAT_HRVATY_FK | الموارد البشرية | ربط hrs att بـhrs vac typ |
| 763 | IAS_BANK_ACCOUNT | IAS_CASH_INCOME | 1:n | IBA_ICI | ICI_CODE | IABAAC_IACAIN_FK | النقدية والبنوك | ربط ias bank account بـias cash income |
| 764 | WAREHOUSE | ITEM_CARD | n:1 | W_ITM | ITM_CODE | WA_ITCA_FK | المخزون والمستودعات | ربط warehouse بـitem card |
| 765 | P_ORDER_DETAIL | GRN_DETAIL | 1:n | P_GD | GD_CODE | PORDE_GRDE_FK | المشتريات والموردين | ربط تفاصيل p order detail بـgrn detail |
| 766 | APX_SCR | IAS_USR_AUDIT | 1:n | AS_IUA | IUA_CODE | APSC_IAUSAU_FK | النظام والأمن | ربط apx scr بـias usr audit |
| 767 | CUSTOMER | IAS_CST_TYP | n:1 | C_ICT | ICT_CODE | CU_IACSTY_FK | المبيعات والعملاء | ربط customer بـias cst typ |
| 768 | IAS_USR_PRF | IAS_USR_LGN_HSTRY | 1:n | IUP_IULH | IULH_CODE | IAUSPR_IAUSLGHS_FK | النظام والأمن | ربط ias usr prf بـias usr lgn hstry |
| 769 | IAS_PROJECT | IAS_PROJECT_PHASE | n:1 | IP_IPP | IPP_CODE | IAPR_IAPRPH_FK | المشاريع والعقود | ربط ias project بـias project phase |
| 770 | ITEM_COST | STK_PHYS_COUNT | 1:n | IC_SPC | SPC_CODE | ITCO_STPHCO_FK | المخزون والمستودعات | ربط item cost بـstk phys count |
| 771 | IAS_CASH_OUTGOING | IAS_CASH_INCOME | 1:n | ICO_ICI | ICI_CODE | IACAOU_IACAIN_FK | النقدية والبنوك | ربط ias cash outgoing بـias cash income |
| 772 | IAS_AR_CNTRCT | IAS_PROJECT_PHASE | n:1 | IAC_IPP | IPP_CODE | IAARCN_IAPRPH_FK | المشاريع والعقود | ربط ias ar cntrct بـias project phase |
| 773 | HRS_SAL | HRS_ATT | n:1 | HS_HA | HA_CODE | HRSA_HRAT_FK | الموارد البشرية | ربط hrs sal بـhrs att |
| 774 | IAS_PI_BILL_DTL | VENDOR | 1:n | IAS_VNDR | VNDR_CODE | IAPIBIDT_VE_FK | المشتريات والموردين | ربط تفاصيل ias pi bill dtl بـvendor |
| 775 | APX_SCR_PRV | MASTER_JOURNAL | n:1 | ASP_MJ | MJ_CODE | APSCPR_MAJO_FK | النظام والأمن | ربط apx scr prv بـmaster journal |
| 776 | HRS_ALLOW_TYP | S_JOB | n:1 | HAT_SJ | SJ_CODE | HRALTY_SJO_FK | الموارد البشرية | ربط hrs allow typ بـs job |
| 777 | IAS_AP_CNTRCT_DTL | IAS_PROJECT_PHASE | n:1 | IAS_IPP | IPP_CODE | IAAPCNDT_IAPRPH_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias project phase |
| 778 | ITEM_UNIT_PRICE | IAS_ITM_CLSS | n:1 | IUP_IIC | IIC_CODE | ITUNPR_IAITCL_FK | المخزون والمستودعات | ربط item unit price بـias itm clss |
| 779 | GUARN_DETAILS | GR_NOTE | n:1 | GUARN_GN | GN_CODE | GUDE_GRNO_FK | الضمانات والكفالات | ربط guarn details بـgr note |
| 780 | WAREHOUSE | IAS_ITM_CLSS | n:1 | W_IIC | IIC_CODE | WA_IAITCL_FK | المخزون والمستودعات | ربط warehouse بـias itm clss |
| 781 | IAS_GUARN_STATUS | GR_NOTE | 1:n | IGS_GN | GN_CODE | IAGUST_GRNO_FK | الضمانات والكفالات | ربط ias guarn status بـgr note |
| 782 | MEASUREMENT | STK_PHYS_COUNT | n:1 | M_SPC | SPC_CODE | ME_STPHCO_FK | المخزون والمستودعات | ربط measurement بـstk phys count |
| 783 | GUARN_DETAILS | S_EMP | n:1 | GUARN_EMP | EMP_CODE | GUDE_SEM_FK | الضمانات والكفالات | ربط guarn details بـs emp |
| 784 | GRN_MASTER | IAS_VNDR_TYP | 1:1 | GM_IVT | IVT_CODE | GRMA_IAVNTY_FK | المشتريات والموردين | ربط grn master بـias vndr typ |
| 785 | IAS_USR_LGN_HSTRY | ACCOUNT | n:1 | IULH_A | A_CODE | IAUSLGHS_AC_FK | النظام والأمن | ربط ias usr lgn hstry بـaccount |
| 786 | GLS_COST_CENTER_TRANS | ACCOUNT_GROUPING | n:1 | GCCT_AG | AG_CODE | GLCOCETR_ACGR_FK | الحسابات والدفتر العام | ربط gls cost center trans بـaccount grouping |
| 787 | IAS_BANK_ACCOUNT | CASH_PAYMENT | 1:n | IBA_CP | CP_CODE | IABAAC_CAPA_FK | النقدية والبنوك | ربط ias bank account بـcash payment |
| 788 | ACCOUNT_CURR | ACCOUNT_GROUPING | n:1 | AC_AG | AG_CODE | ACCU_ACGR_FK | الحسابات والدفتر العام | ربط account curr بـaccount grouping |
| 789 | MASTER_JOURNAL | ACCOUNT_GROUPING | n:1 | MJ_AG | AG_CODE | MAJO_ACGR_FK | الحسابات والدفتر العام | ربط master journal بـaccount grouping |
| 790 | ITEM_UNIT_PRICE | ITEM_CARD | n:1 | IUP_ITM | ITM_CODE | ITUNPR_ITCA_FK | المخزون والمستودعات | ربط item unit price بـitem card |
| 791 | IAS_PROJECT_BUDGET | IAS_AP_CNTRCT | n:1 | IPB_IAC | IAC_CODE | IAPRBU_IAAPCN_FK | المشاريع والعقود | ربط ias project budget بـias ap cntrct |
| 792 | ITEM_UNIT_PRICE | IAS_ITM_GRP | n:1 | IUP_IIG | IIG_CODE | ITUNPR_IAITGR_FK | المخزون والمستودعات | ربط item unit price بـias itm grp |
| 793 | APX_SCR | IAS_GRP | 1:n | AS_IG | IG_CODE | APSC_IAGR_FK | النظام والأمن | ربط apx scr بـias grp |
| 794 | DETAIL_JOURNAL | MASTER_JOURNAL | n:1 | DJ_MJ | MJ_CODE | DEJO_MAJO_FK | الحسابات والدفتر العام | ربط تفاصيل القيد بسند القيد |
| 795 | IAS_ITM_CLSS | STK_MOVMNT | n:1 | IIC_SM | SM_CODE | IAITCL_STMO_FK | المخزون والمستودعات | ربط ias itm clss بـstk movmnt |
| 796 | MEASUREMENT | STK_PHYS_COUNT | n:1 | M_SPC | SPC_CODE | ME_STPHCO_FK | المخزون والمستودعات | ربط measurement بـstk phys count |
| 797 | ACCOUNT_GROUPING | ACCOUNT | n:1 | AG_A | A_CODE | ACGR_AC_FK | الحسابات والدفتر العام | ربط account grouping بـaccount |
| 798 | IAS_VNDR_TYP | VENDOR | n:1 | IVT_VNDR | VNDR_CODE | IAVNTY_VE_FK | المشتريات والموردين | ربط ias vndr typ بـvendor |
| 799 | GUARN_DETAILS | IAS_GUARN_STATUS | 1:n | GUARN_IGS | IGS_CODE | GUDE_IAGUST_FK | الضمانات والكفالات | ربط guarn details بـias guarn status |
| 800 | ACCOUNT_TYPES | MASTER_JOURNAL | n:1 | AT_MJ | MJ_CODE | ACTY_MAJO_FK | الحسابات والدفتر العام | ربط account types بـmaster journal |
| 801 | GUARN_DETAILS | CUSTOMER | n:1 | GUARN_CST | CST_CODE | GUDE_CU_FK | الضمانات والكفالات | ربط guarn details بـcustomer |
| 802 | IAS_CST_CLSS | IAS_CST_TYP | n:1 | ICC_ICT | ICT_CODE | IACSCL_IACSTY_FK | المبيعات والعملاء | ربط ias cst clss بـias cst typ |
| 803 | IAS_USR_LGN_HSTRY | IAS_GRP | n:1 | IULH_IG | IG_CODE | IAUSLGHS_IAGR_FK | النظام والأمن | ربط ias usr lgn hstry بـias grp |
| 804 | ACCOUNT_CURR | ACCOUNT_GROUPING | n:1 | AC_AG | AG_CODE | ACCU_ACGR_FK | الحسابات والدفتر العام | ربط account curr بـaccount grouping |
| 805 | ITEM_UNIT_PRICE | ITEM_CARD | n:1 | IUP_ITM | ITM_CODE | ITUNPR_ITCA_FK | المخزون والمستودعات | ربط item unit price بـitem card |
| 806 | IAS_ITM_GRP | WAREHOUSE | n:1 | IIG_W | W_CODE | IAITGR_WA_FK | المخزون والمستودعات | ربط ias itm grp بـwarehouse |
| 807 | IAS_PROJECT | IAS_PROJECT_COST | 1:n | IP_IPC | IPC_CODE | IAPR_IAPRCO_FK | المشاريع والعقود | ربط ias project بـias project cost |
| 808 | ITEM_CARD | IAS_ITM_CLSS | n:1 | IC_IIC | IIC_CODE | ITCA_IAITCL_FK | المخزون والمستودعات | ربط item card بـias itm clss |
| 809 | VENDOR | S_EMP | n:1 | V_EMP | EMP_CODE | VE_SEM_FK | المشتريات والموردين | ربط vendor بـs emp |
| 810 | ACCOUNT_TYPES | MASTER_JOURNAL | n:1 | AT_MJ | MJ_CODE | ACTY_MAJO_FK | الحسابات والدفتر العام | ربط account types بـmaster journal |
| 811 | STN_BILL | IAS_CST_CLSS | 1:n | SB_ICC | ICC_CODE | STBI_IACSCL_FK | المبيعات والعملاء | ربط stn bill بـias cst clss |
| 812 | STK_MOVMNT | STK_PHYS_COUNT | n:1 | SM_SPC | SPC_CODE | STMO_STPHCO_FK | المخزون والمستودعات | ربط stk movmnt بـstk phys count |
| 813 | WAREHOUSE | ITEM_UNIT_PRICE | n:1 | W_IUP | IUP_CODE | WA_ITUNPR_FK | المخزون والمستودعات | ربط warehouse بـitem unit price |
| 814 | STN_BILL | IAS_CURRENCY | n:1 | SB_CY | CY_CODE | STBI_IACU_FK | المبيعات والعملاء | ربط stn bill بـias currency |
| 815 | IAS_BILL_DTL | CUSTOMER | n:1 | IAS_CST | CST_CODE | IABIDT_CU_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـcustomer |
| 816 | IAS_PROJECT_COST | IAS_CURRENCY | n:1 | IPC_CY | CY_CODE | IAPRCO_IACU_FK | المشاريع والعقود | ربط ias project cost بـias currency |
| 817 | HRS_SAL | HRS_ATT | n:1 | HS_HA | HA_CODE | HRSA_HRAT_FK | الموارد البشرية | ربط hrs sal بـhrs att |
| 818 | DETAIL_JOURNAL | ACCOUNT | n:1 | DJ_A | A_CODE | DEJO_AC_FK | الحسابات والدفتر العام | ربط تفاصيل القيد بالحساب |
| 819 | IAS_VNDR_CLSS | P_ORDER | n:1 | IVC_PO | PO_CODE | IAVNCL_POR_FK | المشتريات والموردين | ربط ias vndr clss بـp order |
| 820 | APX_FVRT_SCR | IAS_USR_PRF | n:1 | AFS_IUP | IUP_CODE | APFVSC_IAUSPR_FK | النظام والأمن | ربط apx fvrt scr بـias usr prf |
| 821 | CASH_PAYMENT | IAS_CASH_OUTGOING | n:1 | CP_ICO | ICO_CODE | CAPA_IACAOU_FK | النقدية والبنوك | ربط cash payment بـias cash outgoing |
| 822 | IAS_AP_CNTRCT | IAS_AR_CNTRCT | n:1 | IAC_IAC | IAC_CODE | IAAPCN_IAARCN_FK | المشاريع والعقود | ربط ias ap cntrct بـias ar cntrct |
| 823 | IAS_AR_CNTRCT | IAS_AP_CNTRCT_DTL | 1:n | IAC_IACD | IACD_CODE | IAARCN_IAAPCNDT_FK | المشاريع والعقود | ربط ias ar cntrct بـias ap cntrct dtl |
| 824 | IAS_DISCOUNT | STN_BILL_DTL | n:1 | ID_SBD | SBD_CODE | IADI_STBIDT_FK | المبيعات والعملاء | ربط ias discount بـstn bill dtl |
| 825 | GRN_MASTER | P_ORDER_DETAIL | n:1 | GM_POD | POD_CODE | GRMA_PORDE_FK | المشتريات والموردين | ربط grn master بـp order detail |
| 826 | S_JOB | CUSTOMER | n:1 | SJ_CST | CST_CODE | SJO_CU_FK | الموارد البشرية | ربط s job بـcustomer |
| 827 | IAS_GUARN_STATUS | GUARN_DETAILS | n:m | IGS_GD | GD_CODE | IAGUST_GUDE_FK | الضمانات والكفالات | ربط ias guarn status بـguarn details |
| 828 | ACCOUNT_GROUPING | ACCOUNT_REPORT_TYPE | 1:1 | AG_ART | ART_CODE | ACGR_ACRETY_FK | الحسابات والدفتر العام | ربط account grouping بـaccount report type |
| 829 | APX_SCR_PRV | APX_FVRT_SCR | n:1 | ASP_AFS | AFS_CODE | APSCPR_APFVSC_FK | النظام والأمن | ربط apx scr prv بـapx fvrt scr |
| 830 | IAS_CST_CLSS | ITEM_CARD | n:1 | ICC_ITM | ITM_CODE | IACSCL_ITCA_FK | المبيعات والعملاء | ربط ias cst clss بـitem card |
| 831 | ITEM_COST | STK_MOVMNT | n:1 | IC_SM | SM_CODE | ITCO_STMO_FK | المخزون والمستودعات | ربط item cost بـstk movmnt |
| 832 | IAS_BILL_DTL | IAS_CST_CLSS | n:m | IAS_ICC | ICC_CODE | IABIDT_IACSCL_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـias cst clss |
| 833 | IAS_AP_CNTRCT | ITEM_CARD | n:1 | IAC_ITM | ITM_CODE | IAAPCN_ITCA_FK | المشاريع والعقود | ربط ias ap cntrct بـitem card |
| 834 | P_ORDER_DETAIL | GRN_DETAIL | 1:n | P_GD | GD_CODE | PORDE_GRDE_FK | المشتريات والموردين | ربط تفاصيل p order detail بـgrn detail |
| 835 | IAS_VNDR_CLSS | VENDOR | n:1 | IVC_VNDR | VNDR_CODE | IAVNCL_VE_FK | المشتريات والموردين | ربط ias vndr clss بـvendor |
| 836 | ITEM_CARD | CUSTOMER | n:1 | IC_CST | CST_CODE | ITCA_CU_FK | المخزون والمستودعات | ربط item card بـcustomer |
| 837 | GUARN_MASTER | GR_NOTE | n:1 | GM_GN | GN_CODE | GUMA_GRNO_FK | الضمانات والكفالات | ربط guarn master بـgr note |
| 838 | SALES_RETURN | STN_BILL | n:1 | SR_SB | SB_CODE | SARE_STBI_FK | المبيعات والعملاء | ربط sales return بـstn bill |
| 839 | GRN_DETAIL | P_ORDER_DETAIL | n:1 | GRN_POD | POD_CODE | GRDE_PORDE_FK | المشتريات والموردين | ربط تفاصيل grn detail بـp order detail |
| 840 | IAS_PROJECT_BUDGET | IAS_PROJECT | n:1 | IPB_IP | IP_CODE | IAPRBU_IAPR_FK | المشاريع والعقود | ربط ias project budget بـias project |
| 841 | STN_BILL_DTL | IAS_CST_TYP | 1:n | STN_ICT | ICT_CODE | STBIDT_IACSTY_FK | المبيعات والعملاء | ربط تفاصيل stn bill dtl بـias cst typ |
| 842 | IAS_CASH_OUTGOING | CASH_PAYMENT | n:1 | ICO_CP | CP_CODE | IACAOU_CAPA_FK | النقدية والبنوك | ربط ias cash outgoing بـcash payment |
| 843 | IAS_CASH_OUTGOING | CASH_PAYMENT | n:1 | ICO_CP | CP_CODE | IACAOU_CAPA_FK | النقدية والبنوك | ربط ias cash outgoing بـcash payment |
| 844 | ACCOUNT_TYPES | ACCOUNT_CURR | 1:n | AT_AC | AC_CODE | ACTY_ACCU_FK | الحسابات والدفتر العام | ربط account types بـaccount curr |
| 845 | IAS_CST_TYP | STN_BILL | n:1 | ICT_SB | SB_CODE | IACSTY_STBI_FK | المبيعات والعملاء | ربط ias cst typ بـstn bill |
| 846 | ITEM_UNIT_PRICE | VENDOR | n:1 | IUP_VNDR | VNDR_CODE | ITUNPR_VE_FK | المخزون والمستودعات | ربط item unit price بـvendor |
| 847 | CUSTOMER | STN_BILL | 1:n | C_SB | SB_CODE | CU_STBI_FK | المبيعات والعملاء | ربط customer بـstn bill |
| 848 | IAS_BILL | SALES_RETURN | n:m | IB_SR | SR_CODE | IABI_SARE_FK | المبيعات والعملاء | ربط ias bill بـsales return |
| 849 | STN_BILL | STN_BILL_DTL | n:1 | SB_SBD | SBD_CODE | STBI_STBIDT_FK | المبيعات والعملاء | ربط stn bill بـstn bill dtl |
| 850 | ITEM_COST | MEASUREMENT | 1:n | IC_M | M_CODE | ITCO_ME_FK | المخزون والمستودعات | ربط item cost بـmeasurement |
| 851 | IAS_USR_LGN_HSTRY | APX_SCR | n:1 | IULH_AS | AS_CODE | IAUSLGHS_APSC_FK | النظام والأمن | ربط ias usr lgn hstry بـapx scr |
| 852 | IAS_VNDR_CLSS | IAS_PI_BILL | n:1 | IVC_IPB | IPB_CODE | IAVNCL_IAPIBI_FK | المشتريات والموردين | ربط ias vndr clss بـias pi bill |
| 853 | ITEM_COST | MASTER_JOURNAL | n:1 | IC_MJ | MJ_CODE | ITCO_MAJO_FK | المخزون والمستودعات | ربط item cost بـmaster journal |
| 854 | IAS_PI_BILL_DTL | VENDOR | n:1 | IAS_VNDR | VNDR_CODE | IAPIBIDT_VE_FK | المشتريات والموردين | ربط تفاصيل ias pi bill dtl بـvendor |
| 855 | IAS_PROJECT_BUDGET | IAS_PROJECT_COST | n:1 | IPB_IPC | IPC_CODE | IAPRBU_IAPRCO_FK | المشاريع والعقود | ربط ias project budget بـias project cost |
| 856 | APX_SCR_PRV | IAS_USR_LGN_HSTRY | n:1 | ASP_IULH | IULH_CODE | APSCPR_IAUSLGHS_FK | النظام والأمن | ربط apx scr prv بـias usr lgn hstry |
| 857 | IAS_GUARN_TYPE | IAS_GUARN_STATUS | n:1 | IGT_IGS | IGS_CODE | IAGUTY_IAGUST_FK | الضمانات والكفالات | ربط ias guarn type بـias guarn status |
| 858 | IAS_AP_CNTRCT_DTL | IAS_PROJECT_COST | 1:n | IAS_IPC | IPC_CODE | IAAPCNDT_IAPRCO_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias project cost |
| 859 | APX_SCR_PRV | ACCOUNT | n:1 | ASP_A | A_CODE | APSCPR_AC_FK | النظام والأمن | ربط apx scr prv بـaccount |
| 860 | IAS_CASH_INCOME | COST_CENTERS | n:1 | ICI_CC | CC_CODE | IACAIN_COCE_FK | النقدية والبنوك | ربط ias cash income بـcost centers |
| 861 | IAS_VNDR_CLSS | GRN_DETAIL | 1:n | IVC_GD | GD_CODE | IAVNCL_GRDE_FK | المشتريات والموردين | ربط ias vndr clss بـgrn detail |
| 862 | IAS_USR_PRF | IAS_ACTVTY | n:1 | IUP_ACTVTY | ACTVTY_CODE | IAUSPR_IAAC_FK | النظام والأمن | ربط ias usr prf بـias actvty |
| 863 | IAS_PROJECT | IAS_AP_CNTRCT | n:1 | IP_IAC | IAC_CODE | IAPR_IAAPCN_FK | المشاريع والعقود | ربط ias project بـias ap cntrct |
| 864 | MASTER_JOURNAL | ACCOUNT_REPORT_TYPE | n:1 | MJ_ART | ART_CODE | MAJO_ACRETY_FK | الحسابات والدفتر العام | ربط master journal بـaccount report type |
| 865 | IAS_ITM_GRP | IAS_USR | n:1 | IIG_IU | IU_CODE | IAITGR_IAUS_FK | المخزون والمستودعات | ربط ias itm grp بـias usr |
| 866 | IAS_ITM_GRP | STK_MOVMNT | 1:n | IIG_SM | SM_CODE | IAITGR_STMO_FK | المخزون والمستودعات | ربط ias itm grp بـstk movmnt |
| 867 | CASH_RECEIPT | CASH_PAYMENT | n:1 | CR_CP | CP_CODE | CARE_CAPA_FK | النقدية والبنوك | ربط cash receipt بـcash payment |
| 868 | IAS_PI_BILL | IAS_VNDR_CLSS | n:1 | IPB_IVC | IVC_CODE | IAPIBI_IAVNCL_FK | المشتريات والموردين | ربط ias pi bill بـias vndr clss |
| 869 | GR_NOTE | GUARN_MASTER | n:1 | GN_GM | GM_CODE | GRNO_GUMA_FK | الضمانات والكفالات | ربط gr note بـguarn master |
| 870 | IAS_PROJECT_COST | IAS_PROJECT_PHASE | n:1 | IPC_IPP | IPP_CODE | IAPRCO_IAPRPH_FK | المشاريع والعقود | ربط ias project cost بـias project phase |
| 871 | IAS_BILL | CUSTOMER | n:1 | IB_CST | CST_CODE | IABI_CU_FK | المبيعات والعملاء | ربط فاتورة المبيعات بالعميل |
| 872 | IAS_PI_BILL | IAS_PI_BILL_DTL | n:1 | IPB_IPBD | IPBD_CODE | IAPIBI_IAPIBIDT_FK | المشتريات والموردين | ربط ias pi bill بـias pi bill dtl |
| 873 | HRS_SAL_DETAIL | S_JOB | n:1 | HRS_SJ | SJ_CODE | HRSADE_SJO_FK | الموارد البشرية | ربط تفاصيل hrs sal detail بـs job |
| 874 | IAS_GUARN_STATUS | GUARN_MASTER | n:1 | IGS_GM | GM_CODE | IAGUST_GUMA_FK | الضمانات والكفالات | ربط ias guarn status بـguarn master |
| 875 | APX_SCR | IAS_USR_AUDIT | n:1 | AS_IUA | IUA_CODE | APSC_IAUSAU_FK | النظام والأمن | ربط apx scr بـias usr audit |
| 876 | ACCOUNT_TYPES | OPEN_BAL | 1:n | AT_OB | OB_CODE | ACTY_OPBA_FK | الحسابات والدفتر العام | ربط account types بـopen bal |
| 877 | IAS_PROJECT_PHASE | IAS_AR_CNTRCT | n:1 | IPP_IAC | IAC_CODE | IAPRPH_IAARCN_FK | المشاريع والعقود | ربط ias project phase بـias ar cntrct |
| 878 | IAS_PI_BILL_DTL | VENDOR | 1:n | IAS_VNDR | VNDR_CODE | IAPIBIDT_VE_FK | المشتريات والموردين | ربط تفاصيل ias pi bill dtl بـvendor |
| 879 | GR_NOTE | GUARN_MASTER | n:1 | GN_GM | GM_CODE | GRNO_GUMA_FK | الضمانات والكفالات | ربط gr note بـguarn master |
| 880 | MEASUREMENT | IAS_USR | n:1 | M_IU | IU_CODE | ME_IAUS_FK | المخزون والمستودعات | ربط measurement بـias usr |
| 881 | IAS_PROJECT_BUDGET | IAS_PROJECT | 1:n | IPB_IP | IP_CODE | IAPRBU_IAPR_FK | المشاريع والعقود | ربط ias project budget بـias project |
| 882 | P_ORDER_DETAIL | GRN_DETAIL | n:1 | P_GD | GD_CODE | PORDE_GRDE_FK | المشتريات والموردين | ربط تفاصيل p order detail بـgrn detail |
| 883 | IAS_VNDR_CLSS | GRN_MASTER | n:1 | IVC_GM | GM_CODE | IAVNCL_GRMA_FK | المشتريات والموردين | ربط ias vndr clss بـgrn master |
| 884 | ACCOUNT_TYPES | MASTER_JOURNAL | n:1 | AT_MJ | MJ_CODE | ACTY_MAJO_FK | الحسابات والدفتر العام | ربط account types بـmaster journal |
| 885 | ITEM_COST | ITEM_UNIT_PRICE | 1:n | IC_IUP | IUP_CODE | ITCO_ITUNPR_FK | المخزون والمستودعات | ربط item cost بـitem unit price |
| 886 | IAS_DISCOUNT | CUSTOMER | n:1 | ID_CST | CST_CODE | IADI_CU_FK | المبيعات والعملاء | ربط ias discount بـcustomer |
| 887 | MEASUREMENT | ITEM_UNIT_PRICE | n:1 | M_IUP | IUP_CODE | ME_ITUNPR_FK | المخزون والمستودعات | ربط measurement بـitem unit price |
| 888 | IAS_BILL_DTL | IAS_CURRENCY | n:1 | IAS_CY | CY_CODE | IABIDT_IACU_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـias currency |
| 889 | MASTER_JOURNAL | ACCOUNT | n:1 | MJ_A | A_CODE | MAJO_AC_FK | الحسابات والدفتر العام | ربط master journal بـaccount |
| 890 | IAS_BANK_ACCOUNT | CASH_RECEIPT | n:1 | IBA_CR | CR_CODE | IABAAC_CARE_FK | النقدية والبنوك | ربط ias bank account بـcash receipt |
| 891 | GRN_MASTER | IAS_PI_BILL_DTL | 1:n | GM_IPBD | IPBD_CODE | GRMA_IAPIBIDT_FK | المشتريات والموردين | ربط grn master بـias pi bill dtl |
| 892 | IAS_CST_TYP | CUSTOMER | n:1 | ICT_CST | CST_CODE | IACSTY_CU_FK | المبيعات والعملاء | ربط ias cst typ بـcustomer |
| 893 | ACCOUNT | GLS_COST_CENTER_TRANS | 1:n | A_GCCT | GCCT_CODE | AC_GLCOCETR_FK | الحسابات والدفتر العام | ربط account بـgls cost center trans |
| 894 | IAS_ITM_GRP | WAREHOUSE | n:1 | IIG_W | W_CODE | IAITGR_WA_FK | المخزون والمستودعات | ربط ias itm grp بـwarehouse |
| 895 | STK_MOVMNT | ITEM_COST | n:m | SM_IC | IC_CODE | STMO_ITCO_FK | المخزون والمستودعات | ربط stk movmnt بـitem cost |
| 896 | ACCOUNT_CURR | GLS_COST_CENTER_TRANS | n:1 | AC_GCCT | GCCT_CODE | ACCU_GLCOCETR_FK | الحسابات والدفتر العام | ربط account curr بـgls cost center trans |
| 897 | ACCOUNT_TYPES | ACCOUNT | n:1 | AT_A | A_CODE | ACTY_AC_FK | الحسابات والدفتر العام | ربط account types بـaccount |
| 898 | CASH_PAYMENT | CASH_RECEIPT | n:1 | CP_CR | CR_CODE | CAPA_CARE_FK | النقدية والبنوك | ربط cash payment بـcash receipt |
| 899 | IAS_ITM_GRP | ITEM_UNIT_PRICE | n:1 | IIG_IUP | IUP_CODE | IAITGR_ITUNPR_FK | المخزون والمستودعات | ربط ias itm grp بـitem unit price |
| 900 | STK_MOVMNT | IAS_USR | n:1 | SM_IU | IU_CODE | STMO_IAUS_FK | المخزون والمستودعات | ربط stk movmnt بـias usr |
| 901 | CASH_RECEIPT | IAS_CURRENCY | n:1 | CR_CY | CY_CODE | CARE_IACU_FK | النقدية والبنوك | ربط cash receipt بـias currency |
| 902 | IAS_PI_BILL | P_ORDER | n:1 | IPB_PO | PO_CODE | IAPIBI_POR_FK | المشتريات والموردين | ربط ias pi bill بـp order |
| 903 | ACCOUNT | ACCOUNT_REPORT_TYPE | n:1 | A_ART | ART_CODE | AC_ACRETY_FK | الحسابات والدفتر العام | ربط account بـaccount report type |
| 904 | HRS_ALLOW_TYP | S_DEPT | n:m | HAT_SD | SD_CODE | HRALTY_SDE_FK | الموارد البشرية | ربط hrs allow typ بـs dept |
| 905 | GUARN_MASTER | COST_CENTERS | n:1 | GM_CC | CC_CODE | GUMA_COCE_FK | الضمانات والكفالات | ربط guarn master بـcost centers |
| 906 | MASTER_JOURNAL | GLS_COST_CENTER_TRANS | 1:1 | MJ_GCCT | GCCT_CODE | MAJO_GLCOCETR_FK | الحسابات والدفتر العام | ربط master journal بـgls cost center trans |
| 907 | APX_SCR | IAS_USR_PRF | n:1 | AS_IUP | IUP_CODE | APSC_IAUSPR_FK | النظام والأمن | ربط apx scr بـias usr prf |
| 908 | CASH_PAYMENT | IAS_BANK_ACCOUNT | n:1 | CP_IBA | IBA_CODE | CAPA_IABAAC_FK | النقدية والبنوك | ربط cash payment بـias bank account |
| 909 | IAS_CASH_OUTGOING | BANK_CHEQUE | 1:n | ICO_BC | BC_CODE | IACAOU_BACH_FK | النقدية والبنوك | ربط ias cash outgoing بـbank cheque |
| 910 | BANK_CHEQUE | IAS_BANK | n:1 | BC_IB | IB_CODE | BACH_IABA_FK | النقدية والبنوك | ربط bank cheque بـias bank |
| 911 | IAS_BILL | IAS_CST_CLSS | n:1 | IB_ICC | ICC_CODE | IABI_IACSCL_FK | المبيعات والعملاء | ربط ias bill بـias cst clss |
| 912 | GR_NOTE | IAS_GUARN_STATUS | n:1 | GN_IGS | IGS_CODE | GRNO_IAGUST_FK | الضمانات والكفالات | ربط gr note بـias guarn status |
| 913 | IAS_BILL_DTL | STN_BILL | n:1 | IAS_SB | SB_CODE | IABIDT_STBI_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـstn bill |
| 914 | STK_PHYS_COUNT | ITEM_COST | 1:n | SPC_IC | IC_CODE | STPHCO_ITCO_FK | المخزون والمستودعات | ربط stk phys count بـitem cost |
| 915 | APX_FVRT_SCR | IAS_GRP | 1:n | AFS_IG | IG_CODE | APFVSC_IAGR_FK | النظام والأمن | ربط apx fvrt scr بـias grp |
| 916 | ITEM_UNIT_PRICE | MEASUREMENT | n:1 | IUP_M | M_CODE | ITUNPR_ME_FK | المخزون والمستودعات | ربط item unit price بـmeasurement |
| 917 | GUARN_DETAILS | VENDOR | n:1 | GUARN_VNDR | VNDR_CODE | GUDE_VE_FK | الضمانات والكفالات | ربط guarn details بـvendor |
| 918 | IAS_USR | IAS_ACTVTY | n:1 | IU_ACTVTY | ACTVTY_CODE | IAUS_IAAC_FK | النظام والأمن | ربط ias usr بـias actvty |
| 919 | CASH_PAYMENT | IAS_BANK | n:1 | CP_IB | IB_CODE | CAPA_IABA_FK | النقدية والبنوك | ربط cash payment بـias bank |
| 920 | IAS_GUARN_TYPE | GR_NOTE | 1:n | IGT_GN | GN_CODE | IAGUTY_GRNO_FK | الضمانات والكفالات | ربط ias guarn type بـgr note |
| 921 | APX_SCR_PRV | IAS_USR_AUDIT | n:1 | ASP_IUA | IUA_CODE | APSCPR_IAUSAU_FK | النظام والأمن | ربط apx scr prv بـias usr audit |
| 922 | IAS_PI_BILL | IAS_PI_BILL_DTL | n:1 | IPB_IPBD | IPBD_CODE | IAPIBI_IAPIBIDT_FK | المشتريات والموردين | ربط ias pi bill بـias pi bill dtl |
| 923 | IAS_GRP | APX_SCR | n:1 | IG_AS | AS_CODE | IAGR_APSC_FK | النظام والأمن | ربط ias grp بـapx scr |
| 924 | IAS_AR_CNTRCT | IAS_PROJECT_BUDGET | n:1 | IAC_IPB | IPB_CODE | IAARCN_IAPRBU_FK | المشاريع والعقود | ربط ias ar cntrct بـias project budget |
| 925 | P_ORDER | VENDOR | n:1 | PO_VNDR | VNDR_CODE | POR_VE_FK | المشتريات والموردين | ربط p order بـvendor |
| 926 | IAS_PROJECT_PHASE | COST_CENTERS | n:1 | IPP_CC | CC_CODE | IAPRPH_COCE_FK | المشاريع والعقود | ربط ias project phase بـcost centers |
| 927 | S_DEPT | HRS_SAL | n:1 | SD_HS | HS_CODE | SDE_HRSA_FK | الموارد البشرية | ربط s dept بـhrs sal |
| 928 | IAS_PROJECT_PHASE | IAS_AP_CNTRCT | n:m | IPP_IAC | IAC_CODE | IAPRPH_IAAPCN_FK | المشاريع والعقود | ربط ias project phase بـias ap cntrct |
| 929 | GUARN_DETAILS | GUARN_MASTER | n:m | GUARN_GM | GM_CODE | GUDE_GUMA_FK | الضمانات والكفالات | ربط guarn details بـguarn master |
| 930 | IAS_ITM_CLSS | IAS_ITM_GRP | 1:n | IIC_IIG | IIG_CODE | IAITCL_IAITGR_FK | المخزون والمستودعات | ربط ias itm clss بـias itm grp |
| 931 | GLS_COST_CENTER_TRANS | ACCOUNT_CURR | n:1 | GCCT_AC | AC_CODE | GLCOCETR_ACCU_FK | الحسابات والدفتر العام | ربط gls cost center trans بـaccount curr |
| 932 | DETAIL_JOURNAL | ACCOUNT_TYPES | 1:1 | DJ_AT | AT_CODE | DEJO_ACTY_FK | الحسابات والدفتر العام | ربط detail journal بـaccount types |
| 933 | CASH_PAYMENT | ITEM_CARD | n:1 | CP_ITM | ITM_CODE | CAPA_ITCA_FK | النقدية والبنوك | ربط cash payment بـitem card |
| 934 | IAS_CASH_OUTGOING | IAS_CASH | n:1 | ICO_IC | IC_CODE | IACAOU_IACA_FK | النقدية والبنوك | ربط ias cash outgoing بـias cash |
| 935 | ITEM_CARD | MASTER_JOURNAL | n:1 | IC_MJ | MJ_CODE | ITCA_MAJO_FK | المخزون والمستودعات | ربط item card بـmaster journal |
| 936 | P_ORDER | P_ORDER_DETAIL | 1:n | PO_POD | POD_CODE | POR_PORDE_FK | المشتريات والموردين | ربط p order بـp order detail |
| 937 | SALES_RETURN | IAS_BILL_DTL | n:1 | SR_IBD | IBD_CODE | SARE_IABIDT_FK | المبيعات والعملاء | ربط sales return بـias bill dtl |
| 938 | IAS_USR_LGN_HSTRY | APX_SCR_PRV | n:1 | IULH_ASP | ASP_CODE | IAUSLGHS_APSCPR_FK | النظام والأمن | ربط ias usr lgn hstry بـapx scr prv |
| 939 | IAS_CST_TYP | IAS_DISCOUNT | n:1 | ICT_ID | ID_CODE | IACSTY_IADI_FK | المبيعات والعملاء | ربط ias cst typ بـias discount |
| 940 | APX_FVRT_SCR | IAS_USR_AUDIT | n:1 | AFS_IUA | IUA_CODE | APFVSC_IAUSAU_FK | النظام والأمن | ربط apx fvrt scr بـias usr audit |
| 941 | GR_NOTE | GUARN_MASTER | n:1 | GN_GM | GM_CODE | GRNO_GUMA_FK | الضمانات والكفالات | ربط gr note بـguarn master |
| 942 | IAS_USR_AUDIT | IAS_USR_PRF | n:m | IUA_IUP | IUP_CODE | IAUSAU_IAUSPR_FK | النظام والأمن | ربط ias usr audit بـias usr prf |
| 943 | IAS_AP_CNTRCT_DTL | VENDOR | 1:n | IAS_VNDR | VNDR_CODE | IAAPCNDT_VE_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـvendor |
| 944 | GUARN_MASTER | IAS_GUARN_STATUS | n:1 | GM_IGS | IGS_CODE | GUMA_IAGUST_FK | الضمانات والكفالات | ربط guarn master بـias guarn status |
| 945 | ITEM_CARD | IAS_CURRENCY | n:1 | IC_CY | CY_CODE | ITCA_IACU_FK | المخزون والمستودعات | ربط item card بـias currency |
| 946 | IAS_BILL | STN_BILL_DTL | 1:1 | IB_SBD | SBD_CODE | IABI_STBIDT_FK | المبيعات والعملاء | ربط ias bill بـstn bill dtl |
| 947 | IAS_CASH | BANK_CHEQUE | 1:n | IC_BC | BC_CODE | IACA_BACH_FK | النقدية والبنوك | ربط ias cash بـbank cheque |
| 948 | HRS_SAL | S_DEPT | 1:n | HS_SD | SD_CODE | HRSA_SDE_FK | الموارد البشرية | ربط hrs sal بـs dept |
| 949 | CUSTOMER | STN_BILL_DTL | n:1 | C_SBD | SBD_CODE | CU_STBIDT_FK | المبيعات والعملاء | ربط customer بـstn bill dtl |
| 950 | IAS_CST_CLSS | IAS_BILL_DTL | 1:n | ICC_IBD | IBD_CODE | IACSCL_IABIDT_FK | المبيعات والعملاء | ربط ias cst clss بـias bill dtl |
| 951 | IAS_USR_AUDIT | APX_SCR | 1:n | IUA_AS | AS_CODE | IAUSAU_APSC_FK | النظام والأمن | ربط ias usr audit بـapx scr |
| 952 | SALES_RETURN | IAS_DISCOUNT | n:1 | SR_ID | ID_CODE | SARE_IADI_FK | المبيعات والعملاء | ربط sales return بـias discount |
| 953 | IAS_PROJECT_BUDGET | IAS_AR_CNTRCT | 1:1 | IPB_IAC | IAC_CODE | IAPRBU_IAARCN_FK | المشاريع والعقود | ربط ias project budget بـias ar cntrct |
| 954 | IAS_AP_CNTRCT | IAS_PROJECT_BUDGET | 1:n | IAC_IPB | IPB_CODE | IAAPCN_IAPRBU_FK | المشاريع والعقود | ربط ias ap cntrct بـias project budget |
| 955 | ACCOUNT_CURR | ACCOUNT_REPORT_TYPE | 1:n | AC_ART | ART_CODE | ACCU_ACRETY_FK | الحسابات والدفتر العام | ربط account curr بـaccount report type |
| 956 | ACCOUNT_REPORT_TYPE | ACCOUNT_GROUPING | n:1 | ART_AG | AG_CODE | ACRETY_ACGR_FK | الحسابات والدفتر العام | ربط account report type بـaccount grouping |
| 957 | IAS_USR_LGN_HSTRY | COST_CENTERS | n:1 | IULH_CC | CC_CODE | IAUSLGHS_COCE_FK | النظام والأمن | ربط ias usr lgn hstry بـcost centers |
| 958 | IAS_BILL_DTL | IAS_BILL_DTL | n:1 | IAS_IBD | IBD_CODE | IABIDT_IABIDT_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـias bill dtl |
| 959 | P_ORDER | GRN_MASTER | n:1 | PO_GM | GM_CODE | POR_GRMA_FK | المشتريات والموردين | ربط p order بـgrn master |
| 960 | ITEM_CARD | IAS_USR | n:1 | IC_IU | IU_CODE | ITCA_IAUS_FK | المخزون والمستودعات | ربط item card بـias usr |
| 961 | ACCOUNT_TYPES | OPEN_BAL | n:1 | AT_OB | OB_CODE | ACTY_OPBA_FK | الحسابات والدفتر العام | ربط account types بـopen bal |
| 962 | HRS_ATT | ITEM_CARD | n:1 | HA_ITM | ITM_CODE | HRAT_ITCA_FK | الموارد البشرية | ربط hrs att بـitem card |
| 963 | GUARN_MASTER | IAS_GUARN_TYPE | n:1 | GM_IGT | IGT_CODE | GUMA_IAGUTY_FK | الضمانات والكفالات | ربط guarn master بـias guarn type |
| 964 | IAS_USR_LGN_HSTRY | IAS_GRP | n:1 | IULH_IG | IG_CODE | IAUSLGHS_IAGR_FK | النظام والأمن | ربط ias usr lgn hstry بـias grp |
| 965 | IAS_CASH | IAS_BANK | n:1 | IC_IB | IB_CODE | IACA_IABA_FK | النقدية والبنوك | ربط ias cash بـias bank |
| 966 | MEASUREMENT | IAS_ITM_GRP | n:1 | M_IIG | IIG_CODE | ME_IAITGR_FK | المخزون والمستودعات | ربط measurement بـias itm grp |
| 967 | HRS_SAL_DETAIL | HRS_EMP_VAC | n:1 | HRS_HEV | HEV_CODE | HRSADE_HREMVA_FK | الموارد البشرية | ربط تفاصيل hrs sal detail بـhrs emp vac |
| 968 | ACCOUNT_REPORT_TYPE | GLS_COST_CENTER_TRANS | n:m | ART_GCCT | GCCT_CODE | ACRETY_GLCOCETR_FK | الحسابات والدفتر العام | ربط account report type بـgls cost center trans |
| 969 | STK_PHYS_COUNT | VENDOR | n:1 | SPC_VNDR | VNDR_CODE | STPHCO_VE_FK | المخزون والمستودعات | ربط stk phys count بـvendor |
| 970 | IAS_AP_CNTRCT_DTL | IAS_PROJECT | n:1 | IAS_IP | IP_CODE | IAAPCNDT_IAPR_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias project |
| 971 | SALES_RETURN | IAS_BILL | 1:1 | SR_IB | IB_CODE | SARE_IABI_FK | المبيعات والعملاء | ربط sales return بـias bill |
| 972 | HRS_VAC_TYP | HRS_ATT | n:1 | HVT_HA | HA_CODE | HRVATY_HRAT_FK | الموارد البشرية | ربط hrs vac typ بـhrs att |
| 973 | STN_BILL | IAS_DISCOUNT | 1:n | SB_ID | ID_CODE | STBI_IADI_FK | المبيعات والعملاء | ربط stn bill بـias discount |
| 974 | IAS_DISCOUNT | STN_BILL | n:1 | ID_SB | SB_CODE | IADI_STBI_FK | المبيعات والعملاء | ربط ias discount بـstn bill |
| 975 | IAS_USR_AUDIT | IAS_USR_LGN_HSTRY | 1:n | IUA_IULH | IULH_CODE | IAUSAU_IAUSLGHS_FK | النظام والأمن | ربط ias usr audit بـias usr lgn hstry |
| 976 | ACCOUNT_CURR | IAS_ACTVTY | n:1 | AC_ACTVTY | ACTVTY_CODE | ACCU_IAAC_FK | الحسابات والدفتر العام | ربط account curr بـias actvty |
| 977 | IAS_BANK | CASH_RECEIPT | n:1 | IB_CR | CR_CODE | IABA_CARE_FK | النقدية والبنوك | ربط ias bank بـcash receipt |
| 978 | IAS_USR_AUDIT | APX_SCR_PRV | n:1 | IUA_ASP | ASP_CODE | IAUSAU_APSCPR_FK | النظام والأمن | ربط ias usr audit بـapx scr prv |
| 979 | S_DEPT | HRS_SAL_DETAIL | 1:n | SD_HSD | HSD_CODE | SDE_HRSADE_FK | الموارد البشرية | ربط s dept بـhrs sal detail |
| 980 | IAS_PI_BILL | ACCOUNT | n:1 | IPB_A | A_CODE | IAPIBI_AC_FK | المشتريات والموردين | ربط ias pi bill بـaccount |
| 981 | IAS_USR_PRF | VENDOR | n:1 | IUP_VNDR | VNDR_CODE | IAUSPR_VE_FK | النظام والأمن | ربط ias usr prf بـvendor |
| 982 | IAS_CASH_INCOME | BANK_CHEQUE | n:1 | ICI_BC | BC_CODE | IACAIN_BACH_FK | النقدية والبنوك | ربط ias cash income بـbank cheque |
| 983 | P_ORDER | VENDOR | n:1 | PO_VNDR | VNDR_CODE | POR_VE_FK | المشتريات والموردين | ربط p order بـvendor |
| 984 | IAS_PROJECT_BUDGET | COST_CENTERS | n:1 | IPB_CC | CC_CODE | IAPRBU_COCE_FK | المشاريع والعقود | ربط ias project budget بـcost centers |
| 985 | GUARN_DETAILS | IAS_GUARN_TYPE | n:1 | GUARN_IGT | IGT_CODE | GUDE_IAGUTY_FK | الضمانات والكفالات | ربط guarn details بـias guarn type |
| 986 | IAS_AP_CNTRCT_DTL | IAS_PROJECT_PHASE | 1:n | IAS_IPP | IPP_CODE | IAAPCNDT_IAPRPH_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias project phase |
| 987 | P_ORDER | GRN_MASTER | 1:n | PO_GM | GM_CODE | POR_GRMA_FK | المشتريات والموردين | ربط p order بـgrn master |
| 988 | GRN_DETAIL | ACCOUNT | n:m | GRN_A | A_CODE | GRDE_AC_FK | المشتريات والموردين | ربط تفاصيل grn detail بـaccount |
| 989 | ACCOUNT_CURR | DETAIL_JOURNAL | n:1 | AC_DJ | DJ_CODE | ACCU_DEJO_FK | الحسابات والدفتر العام | ربط account curr بـdetail journal |
| 990 | IAS_CASH_INCOME | IAS_CASH | n:1 | ICI_IC | IC_CODE | IACAIN_IACA_FK | النقدية والبنوك | ربط ias cash income بـias cash |
| 991 | IAS_BANK | IAS_CASH_OUTGOING | n:1 | IB_ICO | ICO_CODE | IABA_IACAOU_FK | النقدية والبنوك | ربط ias bank بـias cash outgoing |
| 992 | ACCOUNT | OPEN_BAL | n:1 | A_OB | OB_CODE | AC_OPBA_FK | الحسابات والدفتر العام | ربط account بـopen bal |
| 993 | MEASUREMENT | ITEM_COST | n:1 | M_IC | IC_CODE | ME_ITCO_FK | المخزون والمستودعات | ربط measurement بـitem cost |
| 994 | BANK_CHEQUE | CASH_RECEIPT | n:1 | BC_CR | CR_CODE | BACH_CARE_FK | النقدية والبنوك | ربط bank cheque بـcash receipt |
| 995 | APX_SCR_PRV | IAS_CURRENCY | n:1 | ASP_CY | CY_CODE | APSCPR_IACU_FK | النظام والأمن | ربط apx scr prv بـias currency |
| 996 | GUARN_MASTER | GUARN_DETAILS | n:1 | GM_GD | GD_CODE | GUMA_GUDE_FK | الضمانات والكفالات | ربط guarn master بـguarn details |
| 997 | IAS_CST_TYP | IAS_CST_CLSS | 1:n | ICT_ICC | ICC_CODE | IACSTY_IACSCL_FK | المبيعات والعملاء | ربط ias cst typ بـias cst clss |
| 998 | P_ORDER_DETAIL | IAS_VNDR_CLSS | n:1 | P_IVC | IVC_CODE | PORDE_IAVNCL_FK | المشتريات والموردين | ربط تفاصيل p order detail بـias vndr clss |
| 999 | IAS_USR_PRF | MASTER_JOURNAL | n:1 | IUP_MJ | MJ_CODE | IAUSPR_MAJO_FK | النظام والأمن | ربط ias usr prf بـmaster journal |
| 1000 | GLS_COST_CENTER_TRANS | MASTER_JOURNAL | n:1 | GCCT_MJ | MJ_CODE | GLCOCETR_MAJO_FK | الحسابات والدفتر العام | ربط gls cost center trans بـmaster journal |
| 1001 | STN_BILL | IAS_DISCOUNT | 1:n | SB_ID | ID_CODE | STBI_IADI_FK | المبيعات والعملاء | ربط stn bill بـias discount |
| 1002 | GR_NOTE | GUARN_DETAILS | 1:1 | GN_GD | GD_CODE | GRNO_GUDE_FK | الضمانات والكفالات | ربط gr note بـguarn details |
| 1003 | IAS_PROJECT_PHASE | IAS_PROJECT | 1:n | IPP_IP | IP_CODE | IAPRPH_IAPR_FK | المشاريع والعقود | ربط ias project phase بـias project |
| 1004 | MASTER_JOURNAL | ACCOUNT_REPORT_TYPE | n:1 | MJ_ART | ART_CODE | MAJO_ACRETY_FK | الحسابات والدفتر العام | ربط master journal بـaccount report type |
| 1005 | STN_BILL_DTL | IAS_CURRENCY | 1:n | STN_CY | CY_CODE | STBIDT_IACU_FK | المبيعات والعملاء | ربط تفاصيل stn bill dtl بـias currency |
| 1006 | IAS_CASH_OUTGOING | IAS_BANK_ACCOUNT | n:1 | ICO_IBA | IBA_CODE | IACAOU_IABAAC_FK | النقدية والبنوك | ربط ias cash outgoing بـias bank account |
| 1007 | HRS_SAL_DETAIL | HRS_SAL_DETAIL | n:1 | HRS_HSD | HSD_CODE | HRSADE_HRSADE_FK | الموارد البشرية | ربط تفاصيل hrs sal detail بـhrs sal detail |
| 1008 | S_EMP | HRS_ATT | n:1 | SE_HA | HA_CODE | SEM_HRAT_FK | الموارد البشرية | ربط s emp بـhrs att |
| 1009 | GUARN_MASTER | GR_NOTE | n:1 | GM_GN | GN_CODE | GUMA_GRNO_FK | الضمانات والكفالات | ربط guarn master بـgr note |
| 1010 | S_JOB | HRS_SAL | 1:n | SJ_HS | HS_CODE | SJO_HRSA_FK | الموارد البشرية | ربط s job بـhrs sal |
| 1011 | IAS_USR_AUDIT | IAS_GRP | n:1 | IUA_IG | IG_CODE | IAUSAU_IAGR_FK | النظام والأمن | ربط ias usr audit بـias grp |
| 1012 | STK_MOVMNT | ITEM_CARD | n:1 | SM_ITM | ITM_CODE | STMO_ITCA_FK | المخزون والمستودعات | ربط stk movmnt بـitem card |
| 1013 | APX_FVRT_SCR | IAS_USR_PRF | n:1 | AFS_IUP | IUP_CODE | APFVSC_IAUSPR_FK | النظام والأمن | ربط apx fvrt scr بـias usr prf |
| 1014 | STK_PHYS_COUNT | ITEM_CARD | n:1 | SPC_ITM | ITM_CODE | STPHCO_ITCA_FK | المخزون والمستودعات | ربط stk phys count بـitem card |
| 1015 | APX_SCR_PRV | APX_FVRT_SCR | n:m | ASP_AFS | AFS_CODE | APSCPR_APFVSC_FK | النظام والأمن | ربط apx scr prv بـapx fvrt scr |
| 1016 | IAS_GRP | IAS_USR_PRF | n:1 | IG_IUP | IUP_CODE | IAGR_IAUSPR_FK | النظام والأمن | ربط ias grp بـias usr prf |
| 1017 | APX_SCR | IAS_GRP | n:m | AS_IG | IG_CODE | APSC_IAGR_FK | النظام والأمن | ربط apx scr بـias grp |
| 1018 | ITEM_CARD | STK_MOVMNT | 1:n | IC_SM | SM_CODE | ITCA_STMO_FK | المخزون والمستودعات | ربط item card بـstk movmnt |
| 1019 | S_EMP | IAS_USR | n:1 | SE_IU | IU_CODE | SEM_IAUS_FK | الموارد البشرية | ربط s emp بـias usr |
| 1020 | IAS_PI_BILL | IAS_VNDR_CLSS | n:1 | IPB_IVC | IVC_CODE | IAPIBI_IAVNCL_FK | المشتريات والموردين | ربط ias pi bill بـias vndr clss |
| 1021 | IAS_PI_BILL_DTL | IAS_VNDR_TYP | n:1 | IAS_IVT | IVT_CODE | IAPIBIDT_IAVNTY_FK | المشتريات والموردين | ربط تفاصيل ias pi bill dtl بـias vndr typ |
| 1022 | IAS_USR | IAS_USR_PRF | 1:n | IU_IUP | IUP_CODE | IAUS_IAUSPR_FK | النظام والأمن | ربط ias usr بـias usr prf |
| 1023 | IAS_AR_CNTRCT | IAS_PROJECT | 1:1 | IAC_IP | IP_CODE | IAARCN_IAPR_FK | المشاريع والعقود | ربط ias ar cntrct بـias project |
| 1024 | OPEN_BAL | ACCOUNT_REPORT_TYPE | n:1 | OB_ART | ART_CODE | OPBA_ACRETY_FK | الحسابات والدفتر العام | ربط open bal بـaccount report type |
| 1025 | GUARN_DETAILS | ACCOUNT | n:1 | GUARN_A | A_CODE | GUDE_AC_FK | الضمانات والكفالات | ربط guarn details بـaccount |
| 1026 | HRS_SAL | S_EMP | n:1 | HS_EMP | EMP_CODE | HRSA_SEM_FK | الموارد البشرية | ربط الراتب بالموظف |
| 1027 | S_JOB | HRS_ATT | n:1 | SJ_HA | HA_CODE | SJO_HRAT_FK | الموارد البشرية | ربط s job بـhrs att |
| 1028 | ACCOUNT_REPORT_TYPE | GLS_COST_CENTER_TRANS | n:m | ART_GCCT | GCCT_CODE | ACRETY_GLCOCETR_FK | الحسابات والدفتر العام | ربط account report type بـgls cost center trans |
| 1029 | ACCOUNT_REPORT_TYPE | ACCOUNT | n:1 | ART_A | A_CODE | ACRETY_AC_FK | الحسابات والدفتر العام | ربط account report type بـaccount |
| 1030 | IAS_BILL_DTL | IAS_BILL | n:1 | IAS_IB | IB_CODE | IABIDT_IABI_FK | المبيعات والعملاء | ربط تفاصيل فاتورة المبيعات بالفاتورة |
| 1031 | STK_PHYS_COUNT | WAREHOUSE | n:1 | SPC_W | W_CODE | STPHCO_WA_FK | المخزون والمستودعات | ربط stk phys count بـwarehouse |
| 1032 | IAS_PROJECT_COST | IAS_PROJECT_BUDGET | n:1 | IPC_IPB | IPB_CODE | IAPRCO_IAPRBU_FK | المشاريع والعقود | ربط ias project cost بـias project budget |
| 1033 | IAS_CST_CLSS | CUSTOMER | n:1 | ICC_CST | CST_CODE | IACSCL_CU_FK | المبيعات والعملاء | ربط ias cst clss بـcustomer |
| 1034 | IAS_CST_CLSS | IAS_BILL_DTL | 1:1 | ICC_IBD | IBD_CODE | IACSCL_IABIDT_FK | المبيعات والعملاء | ربط ias cst clss بـias bill dtl |
| 1035 | IAS_BILL | CUSTOMER | n:1 | IB_CST | CST_CODE | IABI_CU_FK | المبيعات والعملاء | ربط فاتورة المبيعات بالعميل |
| 1036 | IAS_BILL | STN_BILL | n:1 | IB_SB | SB_CODE | IABI_STBI_FK | المبيعات والعملاء | ربط ias bill بـstn bill |
| 1037 | STN_BILL | VENDOR | n:1 | SB_VNDR | VNDR_CODE | STBI_VE_FK | المبيعات والعملاء | ربط stn bill بـvendor |
| 1038 | IAS_GUARN_STATUS | GUARN_MASTER | n:1 | IGS_GM | GM_CODE | IAGUST_GUMA_FK | الضمانات والكفالات | ربط ias guarn status بـguarn master |
| 1039 | IAS_USR_LGN_HSTRY | APX_FVRT_SCR | n:1 | IULH_AFS | AFS_CODE | IAUSLGHS_APFVSC_FK | النظام والأمن | ربط ias usr lgn hstry بـapx fvrt scr |
| 1040 | ITEM_CARD | STK_MOVMNT | n:1 | IC_SM | SM_CODE | ITCA_STMO_FK | المخزون والمستودعات | ربط item card بـstk movmnt |
| 1041 | IAS_GUARN_TYPE | ITEM_CARD | n:1 | IGT_ITM | ITM_CODE | IAGUTY_ITCA_FK | الضمانات والكفالات | ربط ias guarn type بـitem card |
| 1042 | S_JOB | HRS_ALLOW_TYP | n:1 | SJ_HAT | HAT_CODE | SJO_HRALTY_FK | الموارد البشرية | ربط s job بـhrs allow typ |
| 1043 | S_DEPT | S_EMP | n:1 | SD_EMP | EMP_CODE | SDE_SEM_FK | الموارد البشرية | ربط s dept بـs emp |
| 1044 | STN_BILL_DTL | IAS_BILL | n:1 | STN_IB | IB_CODE | STBIDT_IABI_FK | المبيعات والعملاء | ربط تفاصيل stn bill dtl بـias bill |
| 1045 | IAS_CST_TYP | CUSTOMER | n:1 | ICT_CST | CST_CODE | IACSTY_CU_FK | المبيعات والعملاء | ربط ias cst typ بـcustomer |
| 1046 | STN_BILL_DTL | COST_CENTERS | n:m | STN_CC | CC_CODE | STBIDT_COCE_FK | المبيعات والعملاء | ربط تفاصيل stn bill dtl بـcost centers |
| 1047 | ITEM_COST | IAS_ITM_CLSS | n:1 | IC_IIC | IIC_CODE | ITCO_IAITCL_FK | المخزون والمستودعات | ربط item cost بـias itm clss |
| 1048 | IAS_USR_PRF | IAS_USR | n:1 | IUP_IU | IU_CODE | IAUSPR_IAUS_FK | النظام والأمن | ربط ias usr prf بـias usr |
| 1049 | HRS_ALLOW_TYP | S_DEPT | 1:n | HAT_SD | SD_CODE | HRALTY_SDE_FK | الموارد البشرية | ربط hrs allow typ بـs dept |
| 1050 | IAS_ITM_CLSS | STK_PHYS_COUNT | 1:n | IIC_SPC | SPC_CODE | IAITCL_STPHCO_FK | المخزون والمستودعات | ربط ias itm clss بـstk phys count |
| 1051 | ITEM_COST | ITEM_CARD | n:1 | IC_ITM | ITM_CODE | ITCO_ITCA_FK | المخزون والمستودعات | ربط item cost بـitem card |
| 1052 | CASH_RECEIPT | IAS_CASH_OUTGOING | n:1 | CR_ICO | ICO_CODE | CARE_IACAOU_FK | النقدية والبنوك | ربط cash receipt بـias cash outgoing |
| 1053 | BANK_CHEQUE | IAS_BANK_ACCOUNT | n:1 | BC_IBA | IBA_CODE | BACH_IABAAC_FK | النقدية والبنوك | ربط bank cheque بـias bank account |
| 1054 | IAS_USR | IAS_CURRENCY | n:1 | IU_CY | CY_CODE | IAUS_IACU_FK | النظام والأمن | ربط ias usr بـias currency |
| 1055 | IAS_GRP | IAS_CURRENCY | n:1 | IG_CY | CY_CODE | IAGR_IACU_FK | النظام والأمن | ربط ias grp بـias currency |
| 1056 | GR_NOTE | GUARN_DETAILS | n:1 | GN_GD | GD_CODE | GRNO_GUDE_FK | الضمانات والكفالات | ربط gr note بـguarn details |
| 1057 | IAS_GUARN_TYPE | GUARN_DETAILS | 1:n | IGT_GD | GD_CODE | IAGUTY_GUDE_FK | الضمانات والكفالات | ربط ias guarn type بـguarn details |
| 1058 | ACCOUNT_TYPES | ACCOUNT_REPORT_TYPE | 1:n | AT_ART | ART_CODE | ACTY_ACRETY_FK | الحسابات والدفتر العام | ربط account types بـaccount report type |
| 1059 | HRS_ALLOW_TYP | S_EMP | n:1 | HAT_EMP | EMP_CODE | HRALTY_SEM_FK | الموارد البشرية | ربط hrs allow typ بـs emp |
| 1060 | P_ORDER_DETAIL | IAS_PI_BILL | n:1 | P_IPB | IPB_CODE | PORDE_IAPIBI_FK | المشتريات والموردين | ربط تفاصيل p order detail بـias pi bill |
| 1061 | WAREHOUSE | MASTER_JOURNAL | n:1 | W_MJ | MJ_CODE | WA_MAJO_FK | المخزون والمستودعات | ربط warehouse بـmaster journal |
| 1062 | IAS_BANK_ACCOUNT | CASH_PAYMENT | n:1 | IBA_CP | CP_CODE | IABAAC_CAPA_FK | النقدية والبنوك | ربط ias bank account بـcash payment |
| 1063 | IAS_GUARN_TYPE | GUARN_DETAILS | n:1 | IGT_GD | GD_CODE | IAGUTY_GUDE_FK | الضمانات والكفالات | ربط ias guarn type بـguarn details |
| 1064 | HRS_VAC_TYP | HRS_ALLOW_TYP | 1:n | HVT_HAT | HAT_CODE | HRVATY_HRALTY_FK | الموارد البشرية | ربط hrs vac typ بـhrs allow typ |
| 1065 | IAS_PROJECT | IAS_PROJECT_COST | n:1 | IP_IPC | IPC_CODE | IAPR_IAPRCO_FK | المشاريع والعقود | ربط ias project بـias project cost |
| 1066 | P_ORDER | IAS_VNDR_CLSS | n:1 | PO_IVC | IVC_CODE | POR_IAVNCL_FK | المشتريات والموردين | ربط p order بـias vndr clss |
| 1067 | S_JOB | ITEM_CARD | n:1 | SJ_ITM | ITM_CODE | SJO_ITCA_FK | الموارد البشرية | ربط s job بـitem card |
| 1068 | HRS_EMP_VAC | S_JOB | 1:n | HEV_SJ | SJ_CODE | HREMVA_SJO_FK | الموارد البشرية | ربط hrs emp vac بـs job |
| 1069 | IAS_USR_PRF | APX_SCR | n:1 | IUP_AS | AS_CODE | IAUSPR_APSC_FK | النظام والأمن | ربط ias usr prf بـapx scr |
| 1070 | GLS_COST_CENTER_TRANS | DETAIL_JOURNAL | n:1 | GCCT_DJ | DJ_CODE | GLCOCETR_DEJO_FK | الحسابات والدفتر العام | ربط gls cost center trans بـdetail journal |
| 1071 | HRS_SAL_DETAIL | HRS_SAL_DETAIL | n:m | HRS_HSD | HSD_CODE | HRSADE_HRSADE_FK | الموارد البشرية | ربط تفاصيل hrs sal detail بـhrs sal detail |
| 1072 | P_ORDER_DETAIL | GRN_MASTER | n:1 | P_GM | GM_CODE | PORDE_GRMA_FK | المشتريات والموردين | ربط تفاصيل p order detail بـgrn master |
| 1073 | CASH_RECEIPT | IAS_BANK | n:1 | CR_IB | IB_CODE | CARE_IABA_FK | النقدية والبنوك | ربط cash receipt بـias bank |
| 1074 | GR_NOTE | IAS_GUARN_STATUS | n:1 | GN_IGS | IGS_CODE | GRNO_IAGUST_FK | الضمانات والكفالات | ربط gr note بـias guarn status |
| 1075 | IAS_VNDR_TYP | COST_CENTERS | n:1 | IVT_CC | CC_CODE | IAVNTY_COCE_FK | المشتريات والموردين | ربط ias vndr typ بـcost centers |
| 1076 | ACCOUNT | IAS_ACTVTY | n:1 | A_ACTVTY | ACTVTY_CODE | AC_IAAC_FK | الحسابات والدفتر العام | ربط account بـias actvty |
| 1077 | CUSTOMER | STN_BILL | n:1 | C_SB | SB_CODE | CU_STBI_FK | المبيعات والعملاء | ربط customer بـstn bill |
| 1078 | IAS_PROJECT_BUDGET | IAS_PROJECT_PHASE | n:m | IPB_IPP | IPP_CODE | IAPRBU_IAPRPH_FK | المشاريع والعقود | ربط ias project budget بـias project phase |
| 1079 | GUARN_MASTER | GR_NOTE | n:1 | GM_GN | GN_CODE | GUMA_GRNO_FK | الضمانات والكفالات | ربط guarn master بـgr note |
| 1080 | IAS_AP_CNTRCT_DTL | IAS_PROJECT_PHASE | n:1 | IAS_IPP | IPP_CODE | IAAPCNDT_IAPRPH_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias project phase |
| 1081 | IAS_BANK | CASH_RECEIPT | 1:n | IB_CR | CR_CODE | IABA_CARE_FK | النقدية والبنوك | ربط ias bank بـcash receipt |
| 1082 | VENDOR | P_ORDER_DETAIL | n:1 | V_POD | POD_CODE | VE_PORDE_FK | المشتريات والموردين | ربط vendor بـp order detail |
| 1083 | IAS_BILL_DTL | IAS_CST_TYP | n:1 | IAS_ICT | ICT_CODE | IABIDT_IACSTY_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـias cst typ |
| 1084 | IAS_DISCOUNT | SALES_RETURN | 1:n | ID_SR | SR_CODE | IADI_SARE_FK | المبيعات والعملاء | ربط ias discount بـsales return |
| 1085 | ITEM_UNIT_PRICE | MEASUREMENT | 1:n | IUP_M | M_CODE | ITUNPR_ME_FK | المخزون والمستودعات | ربط item unit price بـmeasurement |
| 1086 | STN_BILL | IAS_CST_CLSS | n:1 | SB_ICC | ICC_CODE | STBI_IACSCL_FK | المبيعات والعملاء | ربط stn bill بـias cst clss |
| 1087 | HRS_SAL | HRS_ALLOW_TYP | n:1 | HS_HAT | HAT_CODE | HRSA_HRALTY_FK | الموارد البشرية | ربط hrs sal بـhrs allow typ |
| 1088 | IAS_CASH_OUTGOING | IAS_CASH | n:1 | ICO_IC | IC_CODE | IACAOU_IACA_FK | النقدية والبنوك | ربط ias cash outgoing بـias cash |
| 1089 | IAS_PROJECT_COST | IAS_AP_CNTRCT_DTL | 1:n | IPC_IACD | IACD_CODE | IAPRCO_IAAPCNDT_FK | المشاريع والعقود | ربط ias project cost بـias ap cntrct dtl |
| 1090 | IAS_AP_CNTRCT | IAS_PROJECT_BUDGET | n:1 | IAC_IPB | IPB_CODE | IAAPCN_IAPRBU_FK | المشاريع والعقود | ربط ias ap cntrct بـias project budget |
| 1091 | GUARN_MASTER | IAS_GUARN_TYPE | 1:n | GM_IGT | IGT_CODE | GUMA_IAGUTY_FK | الضمانات والكفالات | ربط guarn master بـias guarn type |
| 1092 | IAS_BANK | IAS_USR | n:1 | IB_IU | IU_CODE | IABA_IAUS_FK | النقدية والبنوك | ربط ias bank بـias usr |
| 1093 | HRS_ATT | IAS_CURRENCY | n:1 | HA_CY | CY_CODE | HRAT_IACU_FK | الموارد البشرية | ربط hrs att بـias currency |
| 1094 | VENDOR | GRN_MASTER | n:1 | V_GM | GM_CODE | VE_GRMA_FK | المشتريات والموردين | ربط vendor بـgrn master |
| 1095 | IAS_CASH_INCOME | BANK_CHEQUE | n:1 | ICI_BC | BC_CODE | IACAIN_BACH_FK | النقدية والبنوك | ربط ias cash income بـbank cheque |
| 1096 | IAS_CASH_INCOME | BANK_CHEQUE | 1:n | ICI_BC | BC_CODE | IACAIN_BACH_FK | النقدية والبنوك | ربط ias cash income بـbank cheque |
| 1097 | IAS_CST_TYP | CUSTOMER | n:1 | ICT_CST | CST_CODE | IACSTY_CU_FK | المبيعات والعملاء | ربط ias cst typ بـcustomer |
| 1098 | HRS_SAL_DETAIL | HRS_ALLOW_TYP | n:1 | HRS_HAT | HAT_CODE | HRSADE_HRALTY_FK | الموارد البشرية | ربط تفاصيل hrs sal detail بـhrs allow typ |
| 1099 | IAS_GUARN_STATUS | GUARN_MASTER | n:1 | IGS_GM | GM_CODE | IAGUST_GUMA_FK | الضمانات والكفالات | ربط ias guarn status بـguarn master |
| 1100 | ITEM_UNIT_PRICE | WAREHOUSE | n:m | IUP_W | W_CODE | ITUNPR_WA_FK | المخزون والمستودعات | ربط item unit price بـwarehouse |
| 1101 | IAS_PI_BILL_DTL | IAS_CURRENCY | n:1 | IAS_CY | CY_CODE | IAPIBIDT_IACU_FK | المشتريات والموردين | ربط تفاصيل ias pi bill dtl بـias currency |
| 1102 | IAS_BILL | STN_BILL | n:1 | IB_SB | SB_CODE | IABI_STBI_FK | المبيعات والعملاء | ربط ias bill بـstn bill |
| 1103 | DETAIL_JOURNAL | OPEN_BAL | n:1 | DJ_OB | OB_CODE | DEJO_OPBA_FK | الحسابات والدفتر العام | ربط detail journal بـopen bal |
| 1104 | IAS_ITM_GRP | ITEM_UNIT_PRICE | n:1 | IIG_IUP | IUP_CODE | IAITGR_ITUNPR_FK | المخزون والمستودعات | ربط ias itm grp بـitem unit price |
| 1105 | CASH_RECEIPT | CASH_PAYMENT | n:1 | CR_CP | CP_CODE | CARE_CAPA_FK | النقدية والبنوك | ربط cash receipt بـcash payment |
| 1106 | GUARN_MASTER | IAS_USR | n:1 | GM_IU | IU_CODE | GUMA_IAUS_FK | الضمانات والكفالات | ربط guarn master بـias usr |
| 1107 | HRS_ALLOW_TYP | HRS_SAL | 1:n | HAT_HS | HS_CODE | HRALTY_HRSA_FK | الموارد البشرية | ربط hrs allow typ بـhrs sal |
| 1108 | GLS_COST_CENTER_TRANS | ACCOUNT_REPORT_TYPE | n:1 | GCCT_ART | ART_CODE | GLCOCETR_ACRETY_FK | الحسابات والدفتر العام | ربط gls cost center trans بـaccount report type |
| 1109 | MASTER_JOURNAL | IAS_CURRENCY | n:1 | MJ_CY | CY_CODE | MAJO_IACU_FK | الحسابات والدفتر العام | ربط master journal بـias currency |
| 1110 | IAS_CASH_OUTGOING | CASH_PAYMENT | n:1 | ICO_CP | CP_CODE | IACAOU_CAPA_FK | النقدية والبنوك | ربط ias cash outgoing بـcash payment |
| 1111 | IAS_BILL_DTL | S_EMP | n:1 | IAS_EMP | EMP_CODE | IABIDT_SEM_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـs emp |
| 1112 | IAS_CASH | IAS_BANK | 1:n | IC_IB | IB_CODE | IACA_IABA_FK | النقدية والبنوك | ربط ias cash بـias bank |
| 1113 | IAS_BANK | IAS_CASH_INCOME | n:1 | IB_ICI | ICI_CODE | IABA_IACAIN_FK | النقدية والبنوك | ربط ias bank بـias cash income |
| 1114 | IAS_PROJECT | IAS_AP_CNTRCT_DTL | 1:n | IP_IACD | IACD_CODE | IAPR_IAAPCNDT_FK | المشاريع والعقود | ربط ias project بـias ap cntrct dtl |
| 1115 | MASTER_JOURNAL | ACCOUNT_TYPES | 1:1 | MJ_AT | AT_CODE | MAJO_ACTY_FK | الحسابات والدفتر العام | ربط master journal بـaccount types |
| 1116 | IAS_CST_CLSS | STN_BILL_DTL | n:1 | ICC_SBD | SBD_CODE | IACSCL_STBIDT_FK | المبيعات والعملاء | ربط ias cst clss بـstn bill dtl |
| 1117 | APX_SCR_PRV | IAS_USR_LGN_HSTRY | 1:n | ASP_IULH | IULH_CODE | APSCPR_IAUSLGHS_FK | النظام والأمن | ربط apx scr prv بـias usr lgn hstry |
| 1118 | OPEN_BAL | CUSTOMER | n:1 | OB_CST | CST_CODE | OPBA_CU_FK | الحسابات والدفتر العام | ربط open bal بـcustomer |
| 1119 | MASTER_JOURNAL | ACCOUNT | n:1 | MJ_A | A_CODE | MAJO_AC_FK | الحسابات والدفتر العام | ربط master journal بـaccount |
| 1120 | GUARN_MASTER | CUSTOMER | n:1 | GM_CST | CST_CODE | GUMA_CU_FK | الضمانات والكفالات | ربط guarn master بـcustomer |
| 1121 | IAS_GUARN_TYPE | GR_NOTE | 1:n | IGT_GN | GN_CODE | IAGUTY_GRNO_FK | الضمانات والكفالات | ربط ias guarn type بـgr note |
| 1122 | IAS_GUARN_TYPE | IAS_GUARN_STATUS | n:1 | IGT_IGS | IGS_CODE | IAGUTY_IAGUST_FK | الضمانات والكفالات | ربط ias guarn type بـias guarn status |
| 1123 | ACCOUNT_GROUPING | DETAIL_JOURNAL | n:1 | AG_DJ | DJ_CODE | ACGR_DEJO_FK | الحسابات والدفتر العام | ربط account grouping بـdetail journal |
| 1124 | IAS_PROJECT | IAS_AR_CNTRCT | n:1 | IP_IAC | IAC_CODE | IAPR_IAARCN_FK | المشاريع والعقود | ربط ias project بـias ar cntrct |
| 1125 | ACCOUNT_GROUPING | GLS_COST_CENTER_TRANS | n:1 | AG_GCCT | GCCT_CODE | ACGR_GLCOCETR_FK | الحسابات والدفتر العام | ربط account grouping بـgls cost center trans |
| 1126 | IAS_AP_CNTRCT_DTL | IAS_PROJECT | n:1 | IAS_IP | IP_CODE | IAAPCNDT_IAPR_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias project |
| 1127 | STK_MOVMNT | ITEM_COST | 1:n | SM_IC | IC_CODE | STMO_ITCO_FK | المخزون والمستودعات | ربط stk movmnt بـitem cost |
| 1128 | IAS_USR_LGN_HSTRY | IAS_USR_AUDIT | n:1 | IULH_IUA | IUA_CODE | IAUSLGHS_IAUSAU_FK | النظام والأمن | ربط ias usr lgn hstry بـias usr audit |
| 1129 | IAS_AP_CNTRCT | IAS_PROJECT_COST | 1:n | IAC_IPC | IPC_CODE | IAAPCN_IAPRCO_FK | المشاريع والعقود | ربط ias ap cntrct بـias project cost |
| 1130 | ACCOUNT_GROUPING | OPEN_BAL | 1:n | AG_OB | OB_CODE | ACGR_OPBA_FK | الحسابات والدفتر العام | ربط account grouping بـopen bal |
| 1131 | ACCOUNT_TYPES | GLS_COST_CENTER_TRANS | n:1 | AT_GCCT | GCCT_CODE | ACTY_GLCOCETR_FK | الحسابات والدفتر العام | ربط account types بـgls cost center trans |
| 1132 | IAS_CST_CLSS | STN_BILL | n:1 | ICC_SB | SB_CODE | IACSCL_STBI_FK | المبيعات والعملاء | ربط ias cst clss بـstn bill |
| 1133 | HRS_SAL | HRS_ATT | n:1 | HS_HA | HA_CODE | HRSA_HRAT_FK | الموارد البشرية | ربط hrs sal بـhrs att |
| 1134 | ITEM_COST | WAREHOUSE | 1:1 | IC_W | W_CODE | ITCO_WA_FK | المخزون والمستودعات | ربط item cost بـwarehouse |
| 1135 | IAS_AR_CNTRCT | ACCOUNT | n:1 | IAC_A | A_CODE | IAARCN_AC_FK | المشاريع والعقود | ربط ias ar cntrct بـaccount |
| 1136 | IAS_BILL | IAS_CST_CLSS | n:1 | IB_ICC | ICC_CODE | IABI_IACSCL_FK | المبيعات والعملاء | ربط ias bill بـias cst clss |
| 1137 | WAREHOUSE | STK_MOVMNT | n:1 | W_SM | SM_CODE | WA_STMO_FK | المخزون والمستودعات | ربط warehouse بـstk movmnt |
| 1138 | CUSTOMER | STN_BILL | n:1 | C_SB | SB_CODE | CU_STBI_FK | المبيعات والعملاء | ربط customer بـstn bill |
| 1139 | IAS_GRP | APX_SCR_PRV | n:1 | IG_ASP | ASP_CODE | IAGR_APSCPR_FK | النظام والأمن | ربط ias grp بـapx scr prv |
| 1140 | IAS_USR_LGN_HSTRY | IAS_GRP | n:1 | IULH_IG | IG_CODE | IAUSLGHS_IAGR_FK | النظام والأمن | ربط ias usr lgn hstry بـias grp |
| 1141 | IAS_PROJECT_PHASE | IAS_AP_CNTRCT | n:1 | IPP_IAC | IAC_CODE | IAPRPH_IAAPCN_FK | المشاريع والعقود | ربط ias project phase بـias ap cntrct |
| 1142 | P_ORDER | GRN_DETAIL | n:1 | PO_GD | GD_CODE | POR_GRDE_FK | المشتريات والموردين | ربط p order بـgrn detail |
| 1143 | IAS_ITM_GRP | MEASUREMENT | n:1 | IIG_M | M_CODE | IAITGR_ME_FK | المخزون والمستودعات | ربط ias itm grp بـmeasurement |
| 1144 | HRS_ATT | HRS_SAL | n:1 | HA_HS | HS_CODE | HRAT_HRSA_FK | الموارد البشرية | ربط hrs att بـhrs sal |
| 1145 | IAS_USR | APX_FVRT_SCR | n:1 | IU_AFS | AFS_CODE | IAUS_APFVSC_FK | النظام والأمن | ربط ias usr بـapx fvrt scr |
| 1146 | ACCOUNT_GROUPING | ACCOUNT | n:1 | AG_A | A_CODE | ACGR_AC_FK | الحسابات والدفتر العام | ربط account grouping بـaccount |
| 1147 | VENDOR | P_ORDER | n:1 | V_PO | PO_CODE | VE_POR_FK | المشتريات والموردين | ربط vendor بـp order |
| 1148 | IAS_AP_CNTRCT | IAS_USR | n:1 | IAC_IU | IU_CODE | IAAPCN_IAUS_FK | المشاريع والعقود | ربط ias ap cntrct بـias usr |
| 1149 | ACCOUNT_CURR | GLS_COST_CENTER_TRANS | n:1 | AC_GCCT | GCCT_CODE | ACCU_GLCOCETR_FK | الحسابات والدفتر العام | ربط account curr بـgls cost center trans |
| 1150 | STK_PHYS_COUNT | MEASUREMENT | 1:n | SPC_M | M_CODE | STPHCO_ME_FK | المخزون والمستودعات | ربط stk phys count بـmeasurement |
| 1151 | ITEM_COST | VENDOR | n:1 | IC_VNDR | VNDR_CODE | ITCO_VE_FK | المخزون والمستودعات | ربط item cost بـvendor |
| 1152 | APX_FVRT_SCR | IAS_USR_AUDIT | 1:n | AFS_IUA | IUA_CODE | APFVSC_IAUSAU_FK | النظام والأمن | ربط apx fvrt scr بـias usr audit |
| 1153 | IAS_GUARN_TYPE | IAS_GUARN_STATUS | 1:n | IGT_IGS | IGS_CODE | IAGUTY_IAGUST_FK | الضمانات والكفالات | ربط ias guarn type بـias guarn status |
| 1154 | GLS_COST_CENTER_TRANS | ACCOUNT | n:1 | GCCT_A | A_CODE | GLCOCETR_AC_FK | الحسابات والدفتر العام | ربط gls cost center trans بـaccount |
| 1155 | IAS_PROJECT_PHASE | S_EMP | n:1 | IPP_EMP | EMP_CODE | IAPRPH_SEM_FK | المشاريع والعقود | ربط ias project phase بـs emp |
| 1156 | IAS_CST_TYP | IAS_DISCOUNT | 1:n | ICT_ID | ID_CODE | IACSTY_IADI_FK | المبيعات والعملاء | ربط ias cst typ بـias discount |
| 1157 | ACCOUNT_REPORT_TYPE | ACCOUNT_GROUPING | n:1 | ART_AG | AG_CODE | ACRETY_ACGR_FK | الحسابات والدفتر العام | ربط account report type بـaccount grouping |
| 1158 | STN_BILL_DTL | IAS_DISCOUNT | 1:n | STN_ID | ID_CODE | STBIDT_IADI_FK | المبيعات والعملاء | ربط تفاصيل stn bill dtl بـias discount |
| 1159 | IAS_AP_CNTRCT | IAS_PROJECT_PHASE | n:1 | IAC_IPP | IPP_CODE | IAAPCN_IAPRPH_FK | المشاريع والعقود | ربط ias ap cntrct بـias project phase |
| 1160 | IAS_PROJECT | IAS_AP_CNTRCT_DTL | n:m | IP_IACD | IACD_CODE | IAPR_IAAPCNDT_FK | المشاريع والعقود | ربط ias project بـias ap cntrct dtl |
| 1161 | ACCOUNT_REPORT_TYPE | ACCOUNT_TYPES | 1:n | ART_AT | AT_CODE | ACRETY_ACTY_FK | الحسابات والدفتر العام | ربط account report type بـaccount types |
| 1162 | STK_PHYS_COUNT | WAREHOUSE | n:1 | SPC_W | W_CODE | STPHCO_WA_FK | المخزون والمستودعات | ربط stk phys count بـwarehouse |
| 1163 | IAS_GUARN_TYPE | IAS_GUARN_STATUS | n:1 | IGT_IGS | IGS_CODE | IAGUTY_IAGUST_FK | الضمانات والكفالات | ربط ias guarn type بـias guarn status |
| 1164 | BANK_CHEQUE | IAS_CASH | n:1 | BC_IC | IC_CODE | BACH_IACA_FK | النقدية والبنوك | ربط bank cheque بـias cash |
| 1165 | IAS_CASH | IAS_CASH_INCOME | n:1 | IC_ICI | ICI_CODE | IACA_IACAIN_FK | النقدية والبنوك | ربط ias cash بـias cash income |
| 1166 | HRS_EMP_VAC | S_DEPT | n:1 | HEV_SD | SD_CODE | HREMVA_SDE_FK | الموارد البشرية | ربط hrs emp vac بـs dept |
| 1167 | IAS_CST_TYP | CUSTOMER | n:1 | ICT_CST | CST_CODE | IACSTY_CU_FK | المبيعات والعملاء | ربط ias cst typ بـcustomer |
| 1168 | MASTER_JOURNAL | ACCOUNT_TYPES | 1:n | MJ_AT | AT_CODE | MAJO_ACTY_FK | الحسابات والدفتر العام | ربط master journal بـaccount types |
| 1169 | IAS_CASH_INCOME | CASH_PAYMENT | n:1 | ICI_CP | CP_CODE | IACAIN_CAPA_FK | النقدية والبنوك | ربط ias cash income بـcash payment |
| 1170 | GRN_MASTER | IAS_VNDR_TYP | n:1 | GM_IVT | IVT_CODE | GRMA_IAVNTY_FK | المشتريات والموردين | ربط grn master بـias vndr typ |
| 1171 | IAS_GUARN_TYPE | ITEM_CARD | n:1 | IGT_ITM | ITM_CODE | IAGUTY_ITCA_FK | الضمانات والكفالات | ربط ias guarn type بـitem card |
| 1172 | GUARN_MASTER | GUARN_DETAILS | n:1 | GM_GD | GD_CODE | GUMA_GUDE_FK | الضمانات والكفالات | ربط guarn master بـguarn details |
| 1173 | CASH_PAYMENT | BANK_CHEQUE | 1:n | CP_BC | BC_CODE | CAPA_BACH_FK | النقدية والبنوك | ربط cash payment بـbank cheque |
| 1174 | ITEM_COST | MEASUREMENT | n:1 | IC_M | M_CODE | ITCO_ME_FK | المخزون والمستودعات | ربط item cost بـmeasurement |
| 1175 | MEASUREMENT | IAS_ITM_GRP | n:1 | M_IIG | IIG_CODE | ME_IAITGR_FK | المخزون والمستودعات | ربط measurement بـias itm grp |
| 1176 | GUARN_DETAILS | IAS_GUARN_STATUS | n:1 | GUARN_IGS | IGS_CODE | GUDE_IAGUST_FK | الضمانات والكفالات | ربط guarn details بـias guarn status |
| 1177 | STN_BILL | STN_BILL_DTL | 1:n | SB_SBD | SBD_CODE | STBI_STBIDT_FK | المبيعات والعملاء | ربط stn bill بـstn bill dtl |
| 1178 | MASTER_JOURNAL | ACCOUNT_REPORT_TYPE | n:m | MJ_ART | ART_CODE | MAJO_ACRETY_FK | الحسابات والدفتر العام | ربط master journal بـaccount report type |
| 1179 | CUSTOMER | STN_BILL | 1:n | C_SB | SB_CODE | CU_STBI_FK | المبيعات والعملاء | ربط customer بـstn bill |
| 1180 | HRS_ATT | CUSTOMER | n:1 | HA_CST | CST_CODE | HRAT_CU_FK | الموارد البشرية | ربط hrs att بـcustomer |
| 1181 | IAS_BILL_DTL | IAS_DISCOUNT | 1:n | IAS_ID | ID_CODE | IABIDT_IADI_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـias discount |
| 1182 | HRS_VAC_TYP | HRS_SAL_DETAIL | n:1 | HVT_HSD | HSD_CODE | HRVATY_HRSADE_FK | الموارد البشرية | ربط hrs vac typ بـhrs sal detail |
| 1183 | STK_PHYS_COUNT | IAS_ITM_GRP | n:m | SPC_IIG | IIG_CODE | STPHCO_IAITGR_FK | المخزون والمستودعات | ربط stk phys count بـias itm grp |
| 1184 | IAS_PROJECT_BUDGET | IAS_AP_CNTRCT_DTL | 1:n | IPB_IACD | IACD_CODE | IAPRBU_IAAPCNDT_FK | المشاريع والعقود | ربط ias project budget بـias ap cntrct dtl |
| 1185 | CUSTOMER | ACCOUNT | n:1 | C_A | A_CODE | CU_AC_FK | المبيعات والعملاء | ربط customer بـaccount |
| 1186 | IAS_BANK | BANK_CHEQUE | n:1 | IB_BC | BC_CODE | IABA_BACH_FK | النقدية والبنوك | ربط ias bank بـbank cheque |
| 1187 | ACCOUNT_REPORT_TYPE | ACCOUNT | n:1 | ART_A | A_CODE | ACRETY_AC_FK | الحسابات والدفتر العام | ربط account report type بـaccount |
| 1188 | OPEN_BAL | GLS_COST_CENTER_TRANS | n:1 | OB_GCCT | GCCT_CODE | OPBA_GLCOCETR_FK | الحسابات والدفتر العام | ربط open bal بـgls cost center trans |
| 1189 | ACCOUNT_TYPES | VENDOR | n:1 | AT_VNDR | VNDR_CODE | ACTY_VE_FK | الحسابات والدفتر العام | ربط account types بـvendor |
| 1190 | DETAIL_JOURNAL | ACCOUNT_GROUPING | n:1 | DJ_AG | AG_CODE | DEJO_ACGR_FK | الحسابات والدفتر العام | ربط detail journal بـaccount grouping |
| 1191 | HRS_SAL | ACCOUNT | n:1 | HS_A | A_CODE | HRSA_AC_FK | الموارد البشرية | ربط hrs sal بـaccount |
| 1192 | VENDOR | GRN_MASTER | n:1 | V_GM | GM_CODE | VE_GRMA_FK | المشتريات والموردين | ربط vendor بـgrn master |
| 1193 | WAREHOUSE | ITEM_UNIT_PRICE | n:1 | W_IUP | IUP_CODE | WA_ITUNPR_FK | المخزون والمستودعات | ربط warehouse بـitem unit price |
| 1194 | STN_BILL | IAS_CST_CLSS | n:1 | SB_ICC | ICC_CODE | STBI_IACSCL_FK | المبيعات والعملاء | ربط stn bill بـias cst clss |
| 1195 | IAS_AP_CNTRCT | IAS_PROJECT_BUDGET | n:1 | IAC_IPB | IPB_CODE | IAAPCN_IAPRBU_FK | المشاريع والعقود | ربط ias ap cntrct بـias project budget |
| 1196 | IAS_BANK | CASH_RECEIPT | n:1 | IB_CR | CR_CODE | IABA_CARE_FK | النقدية والبنوك | ربط ias bank بـcash receipt |
| 1197 | APX_FVRT_SCR | IAS_USR_AUDIT | n:1 | AFS_IUA | IUA_CODE | APFVSC_IAUSAU_FK | النظام والأمن | ربط apx fvrt scr بـias usr audit |
| 1198 | IAS_AP_CNTRCT_DTL | IAS_PROJECT_PHASE | n:1 | IAS_IPP | IPP_CODE | IAAPCNDT_IAPRPH_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias project phase |
| 1199 | IAS_USR_PRF | APX_SCR | 1:n | IUP_AS | AS_CODE | IAUSPR_APSC_FK | النظام والأمن | ربط ias usr prf بـapx scr |
| 1200 | IAS_BANK | IAS_BANK_ACCOUNT | n:1 | IB_IBA | IBA_CODE | IABA_IABAAC_FK | النقدية والبنوك | ربط ias bank بـias bank account |
| 1201 | IAS_AP_CNTRCT | ITEM_CARD | n:1 | IAC_ITM | ITM_CODE | IAAPCN_ITCA_FK | المشاريع والعقود | ربط ias ap cntrct بـitem card |
| 1202 | S_EMP | S_JOB | n:1 | SE_SJ | SJ_CODE | SEM_SJO_FK | الموارد البشرية | ربط s emp بـs job |
| 1203 | CASH_RECEIPT | IAS_BANK | n:1 | CR_IB | IB_CODE | CARE_IABA_FK | النقدية والبنوك | ربط cash receipt بـias bank |
| 1204 | IAS_CASH_OUTGOING | IAS_CASH_INCOME | n:1 | ICO_ICI | ICI_CODE | IACAOU_IACAIN_FK | النقدية والبنوك | ربط ias cash outgoing بـias cash income |
| 1205 | CUSTOMER | SALES_RETURN | 1:1 | C_SR | SR_CODE | CU_SARE_FK | المبيعات والعملاء | ربط customer بـsales return |
| 1206 | P_ORDER | IAS_USR | n:1 | PO_IU | IU_CODE | POR_IAUS_FK | المشتريات والموردين | ربط p order بـias usr |
| 1207 | CASH_RECEIPT | IAS_CURRENCY | n:1 | CR_CY | CY_CODE | CARE_IACU_FK | النقدية والبنوك | ربط cash receipt بـias currency |
| 1208 | ITEM_COST | IAS_CURRENCY | n:1 | IC_CY | CY_CODE | ITCO_IACU_FK | المخزون والمستودعات | ربط item cost بـias currency |
| 1209 | IAS_AR_CNTRCT | IAS_PROJECT | n:m | IAC_IP | IP_CODE | IAARCN_IAPR_FK | المشاريع والعقود | ربط ias ar cntrct بـias project |
| 1210 | GR_NOTE | GUARN_DETAILS | n:1 | GN_GD | GD_CODE | GRNO_GUDE_FK | الضمانات والكفالات | ربط gr note بـguarn details |
| 1211 | GLS_COST_CENTER_TRANS | VENDOR | n:1 | GCCT_VNDR | VNDR_CODE | GLCOCETR_VE_FK | الحسابات والدفتر العام | ربط gls cost center trans بـvendor |
| 1212 | MASTER_JOURNAL | ACCOUNT_CURR | n:1 | MJ_AC | AC_CODE | MAJO_ACCU_FK | الحسابات والدفتر العام | ربط master journal بـaccount curr |
| 1213 | HRS_EMP_VAC | S_DEPT | n:1 | HEV_SD | SD_CODE | HREMVA_SDE_FK | الموارد البشرية | ربط hrs emp vac بـs dept |
| 1214 | IAS_VNDR_CLSS | P_ORDER_DETAIL | n:1 | IVC_POD | POD_CODE | IAVNCL_PORDE_FK | المشتريات والموردين | ربط ias vndr clss بـp order detail |
| 1215 | IAS_VNDR_TYP | P_ORDER | n:1 | IVT_PO | PO_CODE | IAVNTY_POR_FK | المشتريات والموردين | ربط ias vndr typ بـp order |
| 1216 | IAS_PROJECT_BUDGET | COST_CENTERS | n:1 | IPB_CC | CC_CODE | IAPRBU_COCE_FK | المشاريع والعقود | ربط ias project budget بـcost centers |
| 1217 | HRS_SAL | CUSTOMER | n:1 | HS_CST | CST_CODE | HRSA_CU_FK | الموارد البشرية | ربط hrs sal بـcustomer |
| 1218 | GUARN_DETAILS | GR_NOTE | 1:n | GUARN_GN | GN_CODE | GUDE_GRNO_FK | الضمانات والكفالات | ربط guarn details بـgr note |
| 1219 | HRS_EMP_VAC | HRS_VAC_TYP | n:1 | HEV_HVT | HVT_CODE | HREMVA_HRVATY_FK | الموارد البشرية | ربط hrs emp vac بـhrs vac typ |
| 1220 | IAS_PROJECT | IAS_AP_CNTRCT_DTL | 1:n | IP_IACD | IACD_CODE | IAPR_IAAPCNDT_FK | المشاريع والعقود | ربط ias project بـias ap cntrct dtl |
| 1221 | GLS_COST_CENTER_TRANS | ACCOUNT_GROUPING | 1:n | GCCT_AG | AG_CODE | GLCOCETR_ACGR_FK | الحسابات والدفتر العام | ربط gls cost center trans بـaccount grouping |
| 1222 | IAS_BANK | CASH_RECEIPT | n:1 | IB_CR | CR_CODE | IABA_CARE_FK | النقدية والبنوك | ربط ias bank بـcash receipt |
| 1223 | STN_BILL_DTL | CUSTOMER | n:1 | STN_CST | CST_CODE | STBIDT_CU_FK | المبيعات والعملاء | ربط تفاصيل stn bill dtl بـcustomer |
| 1224 | IAS_CASH_OUTGOING | IAS_BANK_ACCOUNT | n:1 | ICO_IBA | IBA_CODE | IACAOU_IABAAC_FK | النقدية والبنوك | ربط ias cash outgoing بـias bank account |
| 1225 | IAS_USR_LGN_HSTRY | APX_SCR | n:1 | IULH_AS | AS_CODE | IAUSLGHS_APSC_FK | النظام والأمن | ربط ias usr lgn hstry بـapx scr |
| 1226 | IAS_ITM_GRP | MEASUREMENT | 1:n | IIG_M | M_CODE | IAITGR_ME_FK | المخزون والمستودعات | ربط ias itm grp بـmeasurement |
| 1227 | GUARN_MASTER | GR_NOTE | n:1 | GM_GN | GN_CODE | GUMA_GRNO_FK | الضمانات والكفالات | ربط guarn master بـgr note |
| 1228 | STK_MOVMNT | CUSTOMER | n:1 | SM_CST | CST_CODE | STMO_CU_FK | المخزون والمستودعات | ربط stk movmnt بـcustomer |
| 1229 | S_JOB | S_EMP | n:1 | SJ_EMP | EMP_CODE | SJO_SEM_FK | الموارد البشرية | ربط s job بـs emp |
| 1230 | IAS_BANK | IAS_USR | n:1 | IB_IU | IU_CODE | IABA_IAUS_FK | النقدية والبنوك | ربط ias bank بـias usr |
| 1231 | ITEM_CARD | IAS_ITM_CLSS | n:1 | IC_IIC | IIC_CODE | ITCA_IAITCL_FK | المخزون والمستودعات | ربط item card بـias itm clss |
| 1232 | HRS_ALLOW_TYP | HRS_SAL | n:1 | HAT_HS | HS_CODE | HRALTY_HRSA_FK | الموارد البشرية | ربط hrs allow typ بـhrs sal |
| 1233 | APX_FVRT_SCR | APX_SCR_PRV | 1:n | AFS_ASP | ASP_CODE | APFVSC_APSCPR_FK | النظام والأمن | ربط apx fvrt scr بـapx scr prv |
| 1234 | S_DEPT | CUSTOMER | n:1 | SD_CST | CST_CODE | SDE_CU_FK | الموارد البشرية | ربط s dept بـcustomer |
| 1235 | IAS_BILL_DTL | IAS_BILL_DTL | 1:n | IAS_IBD | IBD_CODE | IABIDT_IABIDT_FK | المبيعات والعملاء | ربط تفاصيل ias bill dtl بـias bill dtl |
| 1236 | IAS_USR | APX_FVRT_SCR | 1:n | IU_AFS | AFS_CODE | IAUS_APFVSC_FK | النظام والأمن | ربط ias usr بـapx fvrt scr |
| 1237 | P_ORDER_DETAIL | GRN_DETAIL | n:1 | P_GD | GD_CODE | PORDE_GRDE_FK | المشتريات والموردين | ربط تفاصيل p order detail بـgrn detail |
| 1238 | HRS_EMP_VAC | HRS_SAL_DETAIL | n:1 | HEV_HSD | HSD_CODE | HREMVA_HRSADE_FK | الموارد البشرية | ربط hrs emp vac بـhrs sal detail |
| 1239 | GUARN_DETAILS | IAS_GUARN_TYPE | 1:n | GUARN_IGT | IGT_CODE | GUDE_IAGUTY_FK | الضمانات والكفالات | ربط guarn details بـias guarn type |
| 1240 | CASH_PAYMENT | IAS_CASH | n:m | CP_IC | IC_CODE | CAPA_IACA_FK | النقدية والبنوك | ربط cash payment بـias cash |
| 1241 | CASH_RECEIPT | IAS_BANK | n:1 | CR_IB | IB_CODE | CARE_IABA_FK | النقدية والبنوك | ربط cash receipt بـias bank |
| 1242 | STN_BILL_DTL | IAS_USR | n:1 | STN_IU | IU_CODE | STBIDT_IAUS_FK | المبيعات والعملاء | ربط تفاصيل stn bill dtl بـias usr |
| 1243 | IAS_VNDR_TYP | GRN_DETAIL | 1:n | IVT_GD | GD_CODE | IAVNTY_GRDE_FK | المشتريات والموردين | ربط ias vndr typ بـgrn detail |
| 1244 | IAS_BANK_ACCOUNT | IAS_BANK | 1:n | IBA_IB | IB_CODE | IABAAC_IABA_FK | النقدية والبنوك | ربط ias bank account بـias bank |
| 1245 | IAS_AP_CNTRCT_DTL | IAS_PROJECT | n:1 | IAS_IP | IP_CODE | IAAPCNDT_IAPR_FK | المشاريع والعقود | ربط تفاصيل ias ap cntrct dtl بـias project |
| 1246 | IAS_USR_LGN_HSTRY | APX_SCR_PRV | n:1 | IULH_ASP | ASP_CODE | IAUSLGHS_APSCPR_FK | النظام والأمن | ربط ias usr lgn hstry بـapx scr prv |
| 1247 | WAREHOUSE | MEASUREMENT | n:1 | W_M | M_CODE | WA_ME_FK | المخزون والمستودعات | ربط warehouse بـmeasurement |
| 1248 | APX_SCR_PRV | APX_SCR | n:1 | ASP_AS | AS_CODE | APSCPR_APSC_FK | النظام والأمن | ربط apx scr prv بـapx scr |
| 1249 | P_ORDER_DETAIL | IAS_VNDR_CLSS | n:1 | P_IVC | IVC_CODE | PORDE_IAVNCL_FK | المشتريات والموردين | ربط تفاصيل p order detail بـias vndr clss |
| 1250 | DETAIL_JOURNAL | ACCOUNT_CURR | n:m | DJ_AC | AC_CODE | DEJO_ACCU_FK | الحسابات والدفتر العام | ربط detail journal بـaccount curr |
| 1251 | IAS_VNDR_CLSS | ITEM_CARD | n:1 | IVC_ITM | ITM_CODE | IAVNCL_ITCA_FK | المشتريات والموردين | ربط ias vndr clss بـitem card |
| 1252 | IAS_DISCOUNT | IAS_USR | n:1 | ID_IU | IU_CODE | IADI_IAUS_FK | المبيعات والعملاء | ربط ias discount بـias usr |
| 1253 | GUARN_MASTER | IAS_GUARN_TYPE | n:1 | GM_IGT | IGT_CODE | GUMA_IAGUTY_FK | الضمانات والكفالات | ربط guarn master بـias guarn type |
| 1254 | IAS_GUARN_TYPE | IAS_GUARN_STATUS | 1:n | IGT_IGS | IGS_CODE | IAGUTY_IAGUST_FK | الضمانات والكفالات | ربط ias guarn type بـias guarn status |
| 1255 | IAS_PROJECT_COST | IAS_PROJECT_BUDGET | n:1 | IPC_IPB | IPB_CODE | IAPRCO_IAPRBU_FK | المشاريع والعقود | ربط ias project cost بـias project budget |
| 1256 | OPEN_BAL | ACCOUNT_REPORT_TYPE | 1:n | OB_ART | ART_CODE | OPBA_ACRETY_FK | الحسابات والدفتر العام | ربط open bal بـaccount report type |
| 1257 | IAS_USR | APX_FVRT_SCR | n:1 | IU_AFS | AFS_CODE | IAUS_APFVSC_FK | النظام والأمن | ربط ias usr بـapx fvrt scr |
| 1258 | IAS_AP_CNTRCT | IAS_PROJECT_BUDGET | n:1 | IAC_IPB | IPB_CODE | IAAPCN_IAPRBU_FK | المشاريع والعقود | ربط ias ap cntrct بـias project budget |
| 1259 | ITEM_CARD | MASTER_JOURNAL | n:1 | IC_MJ | MJ_CODE | ITCA_MAJO_FK | المخزون والمستودعات | ربط item card بـmaster journal |
| 1260 | IAS_USR | IAS_GRP | n:1 | IU_IG | IG_CODE | IAUS_IAGR_FK | النظام والأمن | ربط ias usr بـias grp |
| 1261 | STN_BILL | STN_BILL_DTL | 1:n | SB_SBD | SBD_CODE | STBI_STBIDT_FK | المبيعات والعملاء | ربط stn bill بـstn bill dtl |
| 1262 | GUARN_DETAILS | GUARN_MASTER | n:1 | GUARN_GM | GM_CODE | GUDE_GUMA_FK | الضمانات والكفالات | ربط guarn details بـguarn master |
| 1263 | IAS_CASH | IAS_CASH_OUTGOING | n:1 | IC_ICO | ICO_CODE | IACA_IACAOU_FK | النقدية والبنوك | ربط ias cash بـias cash outgoing |
| 1264 | MEASUREMENT | STK_MOVMNT | n:m | M_SM | SM_CODE | ME_STMO_FK | المخزون والمستودعات | ربط measurement بـstk movmnt |
| 1265 | IAS_BILL | IAS_CST_TYP | 1:1 | IB_ICT | ICT_CODE | IABI_IACSTY_FK | المبيعات والعملاء | ربط ias bill بـias cst typ |

## الجداول المركزية في النظام

الجداول التالية هي الأكثر استخدامًا في العلاقات (كجداول هدف):

| الجدول | عدد العلاقات | المجموعة الوظيفية |
|--------|--------------|-----------------|
| 1. **IAS_ACTVTY** | 114 | المشاريع والعقود |
| 2. **COST_CENTERS** | 98 | المشتريات والموردين |
| 3. **IAS_CURRENCY** | 93 | الموارد البشرية |
| 4. **ITEM_CARD** | 91 | المخزون والمستودعات |
| 5. **S_EMP** | 85 | الموارد البشرية |
| 6. **ACCOUNT** | 76 | الحسابات والدفتر العام |
| 7. **CUSTOMER** | 65 | المبيعات والعملاء |
| 8. **VENDOR** | 58 | المشتريات والموردين |
| 9. **MASTER_JOURNAL** | 52 | الحسابات والدفتر العام |
| 10. **IAS_USR** | 49 | النظام والأمن |

## استخدام وتحديث هذا التوثيق

يمكن استخدام هذا التوثيق للأغراض التالية:

1. فهم بنية قاعدة البيانات وعلاقاتها
2. تحليل تأثير التغييرات على العلاقات المترابطة
3. تصميم استعلامات SQL معقدة تتضمن عدة جداول مترابطة
4. تطوير واجهات برمجة التطبيقات (APIs) التي تتعامل مع البيانات المترابطة
5. تخطيط تطوير وتحسين البنية المستقبلية لقاعدة البيانات

يجب تحديث هذا التوثيق بانتظام كلما تم إجراء تغييرات على بنية قاعدة البيانات، مثل إضافة جداول جديدة أو تعديل العلاقات القائمة.

## ملاحظة هامة

هذا الملف يحتوي على بيانات نموذجية تم إنشاؤها للتوضيح. في بيئة الإنتاج، يجب استخدام سكريبت `extract_erp_relationships.py` لاستخراج العلاقات الفعلية من قاعدة البيانات عن طريق تنفيذ الأمر التالي:

```bash
python3 extract_erp_relationships.py --host <host_server> --dbname <database_name> --user <username> --password <password> --output erp_database_all_relationships.md
```

# علاقات موديول المخزون والمستودعات (Inventory & Warehouses)

هذا الملف يوثق جميع العلاقات بين الجداول المختلفة في موديول المخزون والمستودعات (Inventory & Warehouses) في نظام OnyxQ Pro ERP، سواء العلاقات الداخلية بين جداول الموديول نفسه أو العلاقات الخارجية مع الموديولات الأخرى.

## دليل استخدام التوثيق

توضح الجداول التالية علاقات قاعدة البيانات بين مختلف كيانات موديول المخزون والمستودعات:
- **جدول المصدر**: يمثل الكيان الذي ينشئ العلاقة
- **جدول الهدف**: يمثل الكيان المرتبط به
- **نوع العلاقة**: يوضح نوع العلاقة (1:1 = واحد لواحد، 1:n = واحد لعديد، n:1 = عديد لواحد، n:m = عديد لعديد)
- **اختصار العلاقة**: اختصار رمزي للعلاقة مكون من أسماء الجداول المشاركة
- **رمز الهدف**: الرمز المستخدم في جدول الهدف
- **اسم المفتاح الأجنبي**: اسم المفتاح الأجنبي (Foreign Key) في قاعدة البيانات
- **المجموعة الوظيفية**: الوحدة أو المجموعة التي تنتمي إليها العلاقة
- **وصف العلاقة**: وصف مختصر للعلاقة باللغة العربية

## جدول العلاقات

> هذا القسم يوضح العلاقات الأساسية في موديول المخزون والمستودعات كما وردت في المستند المرجعي. تمثل هذه العلاقات الارتباطات الرئيسية بين جداول المخزون والتي تشكل البنية الأساسية لوظائف الموديول.

| # | جدول المصدر | جدول الهدف | نوع العلاقة | اختصار العلاقة | رمز الهدف | اسم المفتاح الأجنبي | المجموعة الوظيفية | وصف العلاقة |
|---|-------------|------------|------------|-----------------|-----------|-------------------|-----------------|--------------|
| 993 | MEASUREMENT | ITEM_COST | n:1 | M_IC | IC_CODE | ME_ITCO_FK | المخزون والمستودعات | ربط measurement بـitem cost |
| 1012 | STK_MOVMNT | ITEM_CARD | n:1 | SM_ITM | ITM_CODE | STMO_ITCA_FK | المخزون والمستودعات | ربط stk movmnt بـitem card |
| 1014 | STK_PHYS_COUNT | ITEM_CARD | n:1 | SPC_ITM | ITM_CODE | STPHCO_ITCA_FK | المخزون والمستودعات | ربط stk phys count بـitem card |
| 1018 | ITEM_CARD | STK_MOVMNT | 1:n | IC_SM | SM_CODE | ITCA_STMO_FK | المخزون والمستودعات | ربط item card بـstk movmnt |
| 1031 | STK_PHYS_COUNT | WAREHOUSE | n:1 | SPC_W | W_CODE | STPHCO_WA_FK | المخزون والمستودعات | ربط stk phys count بـwarehouse |
| 1040 | ITEM_CARD | STK_MOVMNT | n:1 | IC_SM | SM_CODE | ITCA_STMO_FK | المخزون والمستودعات | ربط item card بـstk movmnt |
| 1047 | ITEM_COST | IAS_ITM_CLSS | n:1 | IC_IIC | IIC_CODE | ITCO_IAITCL_FK | المخزون والمستودعات | ربط item cost بـias itm clss |
| 1050 | IAS_ITM_CLSS | STK_PHYS_COUNT | 1:n | IIC_SPC | SPC_CODE | IAITCL_STPHCO_FK | المخزون والمستودعات | ربط ias itm clss بـstk phys count |
| 1051 | ITEM_COST | ITEM_CARD | n:1 | IC_ITM | ITM_CODE | ITCO_ITCA_FK | المخزون والمستودعات | ربط item cost بـitem card |
| 1061 | WAREHOUSE | MASTER_JOURNAL | n:1 | W_MJ | MJ_CODE | WA_MAJO_FK | المخزون والمستودعات | ربط warehouse بـmaster journal |
| 1085 | ITEM_UNIT_PRICE | MEASUREMENT | 1:n | IUP_M | M_CODE | ITUNPR_ME_FK | المخزون والمستودعات | ربط item unit price بـmeasurement |
| 1100 | ITEM_UNIT_PRICE | WAREHOUSE | n:m | IUP_W | W_CODE | ITUNPR_WA_FK | المخزون والمستودعات | ربط item unit price بـwarehouse |
| 1104 | IAS_ITM_GRP | ITEM_UNIT_PRICE | n:1 | IIG_IUP | IUP_CODE | IAITGR_ITUNPR_FK | المخزون والمستودعات | ربط ias itm grp بـitem unit price |
| 1127 | STK_MOVMNT | ITEM_COST | 1:n | SM_IC | IC_CODE | STMO_ITCO_FK | المخزون والمستودعات | ربط stk movmnt بـitem cost |
| 1134 | ITEM_COST | WAREHOUSE | 1:1 | IC_W | W_CODE | ITCO_WA_FK | المخزون والمستودعات | ربط item cost بـwarehouse |
| 1137 | WAREHOUSE | STK_MOVMNT | n:1 | W_SM | SM_CODE | WA_STMO_FK | المخزون والمستودعات | ربط warehouse بـstk movmnt |
| 1143 | IAS_ITM_GRP | MEASUREMENT | n:1 | IIG_M | M_CODE | IAITGR_ME_FK | المخزون والمستودعات | ربط ias itm grp بـmeasurement |
| 1150 | STK_PHYS_COUNT | MEASUREMENT | 1:n | SPC_M | M_CODE | STPHCO_ME_FK | المخزون والمستودعات | ربط stk phys count بـmeasurement |
| 1151 | ITEM_COST | VENDOR | n:1 | IC_VNDR | VNDR_CODE | ITCO_VE_FK | المخزون والمستودعات | ربط item cost بـvendor |
| 1162 | STK_PHYS_COUNT | WAREHOUSE | n:1 | SPC_W | W_CODE | STPHCO_WA_FK | المخزون والمستودعات | ربط stk phys count بـwarehouse |
| 1174 | ITEM_COST | MEASUREMENT | n:1 | IC_M | M_CODE | ITCO_ME_FK | المخزون والمستودعات | ربط item cost بـmeasurement |
| 1175 | MEASUREMENT | IAS_ITM_GRP | n:1 | M_IIG | IIG_CODE | ME_IAITGR_FK | المخزون والمستودعات | ربط measurement بـias itm grp |
| 1183 | STK_PHYS_COUNT | IAS_ITM_GRP | n:m | SPC_IIG | IIG_CODE | STPHCO_IAITGR_FK | المخزون والمستودعات | ربط stk phys count بـias itm grp |
| 1193 | WAREHOUSE | ITEM_UNIT_PRICE | n:1 | W_IUP | IUP_CODE | WA_ITUNPR_FK | المخزون والمستودعات | ربط warehouse بـitem unit price |
| 1208 | ITEM_COST | IAS_CURRENCY | n:1 | IC_CY | CY_CODE | ITCO_IACU_FK | المخزون والمستودعات | ربط item cost بـias currency |
| 1226 | IAS_ITM_GRP | MEASUREMENT | 1:n | IIG_M | M_CODE | IAITGR_ME_FK | المخزون والمستودعات | ربط ias itm grp بـmeasurement |
| 1228 | STK_MOVMNT | CUSTOMER | n:1 | SM_CST | CST_CODE | STMO_CU_FK | المخزون والمستودعات | ربط stk movmnt بـcustomer |
| 1231 | ITEM_CARD | IAS_ITM_CLSS | n:1 | IC_IIC | IIC_CODE | ITCA_IAITCL_FK | المخزون والمستودعات | ربط item card بـias itm clss |
| 1247 | WAREHOUSE | MEASUREMENT | n:1 | W_M | M_CODE | WA_ME_FK | المخزون والمستودعات | ربط warehouse بـmeasurement |
| 1259 | ITEM_CARD | MASTER_JOURNAL | n:1 | IC_MJ | MJ_CODE | ITCA_MAJO_FK | المخزون والمستودعات | ربط item card بـmaster journal |
| 1264 | MEASUREMENT | STK_MOVMNT | n:m | M_SM | SM_CODE | ME_STMO_FK | المخزون والمستودعات | ربط measurement بـstk movmnt |

## علاقات إضافية في المخزون والمستودعات

> هذا القسم يوضح العلاقات الإضافية في موديول المخزون والمستودعات والتي تكمل الصورة الكاملة للترابط بين جداول الموديول. تغطي هذه العلاقات الارتباطات التي لم ترد في القسم الأساسي، وتشمل علاقات مع جداول الحسابات، مراكز التكلفة، والمزيد من العلاقات الداخلية التي تدعم وظائف المخزون المتقدمة.

| # | جدول المصدر | جدول الهدف | نوع العلاقة | اختصار العلاقة | رمز الهدف | اسم المفتاح الأجنبي | المجموعة الوظيفية | وصف العلاقة |
|---|-------------|------------|------------|-----------------|-----------|-------------------|-----------------|--------------|
| 1 | ITEM_CARD | IAS_ITM_GRP | 1:n | IC_IIG | IIG_CODE | ITCA_IAITGR_FK | المخزون والمستودعات | ربط الصنف بمجموعة الأصناف |
| 2 | WAREHOUSE | ITEM_CARD | n:1 | W_ITM | ITM_CODE | WA_ITCA_FK | المخزون والمستودعات | ربط المستودع بالصنف |
| 3 | ITEM_CARD | ITEM_UNIT_PRICE | n:1 | IC_IUP | IUP_CODE | ITCA_ITUNPR_FK | المخزون والمستودعات | ربط الصنف بسعر وحدة الصنف |
| 4 | STK_MOVMNT | ITEM_UNIT_PRICE | n:1 | SM_IUP | IUP_CODE | STMO_ITUNPR_FK | المخزون والمستودعات | ربط حركة المخزون بسعر وحدة الصنف |
| 5 | ITEM_UNIT_PRICE | ITEM_CARD | n:1 | IUP_ITM | ITM_CODE | ITUNPR_ITCA_FK | المخزون والمستودعات | ربط سعر وحدة الصنف بالصنف |
| 6 | ITEM_UNIT_PRICE | IAS_ITM_GRP | n:1 | IUP_IIG | IIG_CODE | ITUNPR_IAITGR_FK | المخزون والمستودعات | ربط سعر وحدة الصنف بمجموعة الأصناف |
| 7 | ITEM_UNIT_PRICE | IAS_ITM_CLSS | n:1 | IUP_IIC | IIC_CODE | ITUNPR_IAITCL_FK | المخزون والمستودعات | ربط سعر وحدة الصنف بتصنيف الصنف |
| 8 | WAREHOUSE | IAS_ITM_CLSS | n:1 | W_IIC | IIC_CODE | WA_IAITCL_FK | المخزون والمستودعات | ربط المستودع بتصنيف الصنف |
| 9 | WAREHOUSE | IAS_ITM_GRP | n:1 | W_IIG | IIG_CODE | WA_IAITGR_FK | المخزون والمستودعات | ربط المستودع بمجموعة الأصناف |
| 10 | STK_MOVMNT | IAS_ITM_CLSS | 1:1 | SM_IIC | IIC_CODE | STMO_IAITCL_FK | المخزون والمستودعات | ربط حركة المخزون بتصنيف الصنف |
| 11 | IAS_ITM_CLSS | STK_MOVMNT | 1:n | IIC_SM | SM_CODE | IAITCL_STMO_FK | المخزون والمستودعات | ربط تصنيف الصنف بحركة المخزون |
| 12 | STK_MOVMNT | IAS_ITM_GRP | n:1 | SM_IIG | IIG_CODE | STMO_IAITGR_FK | المخزون والمستودعات | ربط حركة المخزون بمجموعة الأصناف |
| 13 | IAS_ITM_GRP | STK_MOVMNT | 1:n | IIG_SM | SM_CODE | IAITGR_STMO_FK | المخزون والمستودعات | ربط مجموعة الأصناف بحركة المخزون |
| 14 | MEASUREMENT | ITEM_CARD | n:1 | M_ITM | ITM_CODE | ME_ITCA_FK | المخزون والمستودعات | ربط وحدة القياس بالصنف |
| 15 | STK_PHYS_COUNT | STK_MOVMNT | n:1 | SPC_SM | SM_CODE | STPHCO_STMO_FK | المخزون والمستودعات | ربط الجرد الفعلي بحركة المخزون |
| 16 | ITEM_COST | ACCOUNT | n:1 | IC_A | A_CODE | ITCO_AC_FK | المخزون والمستودعات | ربط تكلفة الصنف بالحساب |
| 17 | STK_MOVMNT | ACCOUNT | n:1 | SM_A | A_CODE | STMO_AC_FK | المخزون والمستودعات | ربط حركة المخزون بالحساب |
| 18 | ITEM_CARD | ACCOUNT | n:1 | IC_A | A_CODE | ITCA_AC_FK | المخزون والمستودعات | ربط الصنف بالحساب |
| 19 | WAREHOUSE | IAS_USR | n:1 | W_IU | IU_CODE | WA_IAUS_FK | المخزون والمستودعات | ربط المستودع بالمستخدم |
| 20 | ITEM_UNIT_PRICE | VENDOR | n:1 | IUP_VNDR | VNDR_CODE | ITUNPR_VE_FK | المخزون والمستودعات | ربط سعر وحدة الصنف بالمورد |
| 21 | ITEM_UNIT_PRICE | CUSTOMER | n:1 | IUP_CST | CST_CODE | ITUNPR_CU_FK | المخزون والمستودعات | ربط سعر وحدة الصنف بالعميل |
| 22 | STK_MOVMNT | VENDOR | n:1 | SM_VNDR | VNDR_CODE | STMO_VE_FK | المخزون والمستودعات | ربط حركة المخزون بالمورد |
| 23 | IAS_ITM_GRP | VENDOR | n:1 | IIG_VNDR | VNDR_CODE | IAITGR_VE_FK | المخزون والمستودعات | ربط مجموعة الأصناف بالمورد |
| 24 | WAREHOUSE | VENDOR | n:1 | W_VNDR | VNDR_CODE | WA_VE_FK | المخزون والمستودعات | ربط المستودع بالمورد |
| 25 | IAS_ITM_GRP | IAS_ITM_CLSS | n:1 | IIG_IIC | IIC_CODE | IAITGR_IAITCL_FK | المخزون والمستودعات | ربط مجموعة الأصناف بتصنيف الصنف |
| 26 | IAS_ITM_CLSS | ITEM_CARD | n:1 | IIC_ITM | ITM_CODE | IAITCL_ITCA_FK | المخزون والمستودعات | ربط تصنيف الصنف بالصنف |
| 27 | IAS_ITM_GRP | COST_CENTERS | n:1 | IIG_CC | CC_CODE | IAITGR_COCE_FK | المخزون والمستودعات | ربط مجموعة الأصناف بمراكز التكلفة |
| 28 | STK_MOVMNT | COST_CENTERS | n:1 | SM_CC | CC_CODE | STMO_COCE_FK | المخزون والمستودعات | ربط حركة المخزون بمراكز التكلفة |
| 29 | STK_MOVMNT | IAS_PROJECT | n:1 | SM_IP | IP_CODE | STMO_IAPR_FK | المخزون والمستودعات | ربط حركة المخزون بالمشروع |
| 30 | WAREHOUSE | IAS_PROJECT | n:1 | W_IP | IP_CODE | WA_IAPR_FK | المخزون والمستودعات | ربط المستودع بالمشروع |
| 31 | WAREHOUSE | COST_CENTERS | n:1 | W_CC | CC_CODE | WA_COCE_FK | المخزون والمستودعات | ربط المستودع بمراكز التكلفة |
| 32 | IAS_ITM_GRP | IAS_PROJECT | n:1 | IIG_IP | IP_CODE | IAITGR_IAPR_FK | المخزون والمستودعات | ربط مجموعة الأصناف بالمشروع |
| 33 | ITEM_UNIT_PRICE | IAS_PROJECT | n:1 | IUP_IP | IP_CODE | ITUNPR_IAPR_FK | المخزون والمستودعات | ربط سعر وحدة الصنف بالمشروع |
| 34 | ITEM_UNIT_PRICE | COST_CENTERS | n:1 | IUP_CC | CC_CODE | ITUNPR_COCE_FK | المخزون والمستودعات | ربط سعر وحدة الصنف بمراكز التكلفة |

## علاقات موديول المخزون والمستودعات مع الموديولات الأخرى

> هذا القسم يوضح العلاقات التي تربط موديول المخزون والمستودعات بالموديولات الأخرى في النظام. تعكس هذه العلاقات التكامل بين الموديولات المختلفة وتوضح كيفية تفاعل بيانات المخزون مع باقي أجزاء النظام مثل موديول الضمانات والكفالات، الموارد البشرية، المشاريع والعقود، والمشتريات والموردين.

| # | جدول المصدر | جدول الهدف | نوع العلاقة | اختصار العلاقة | رمز الهدف | اسم المفتاح الأجنبي | المجموعة الوظيفية | وصف العلاقة |
|---|-------------|------------|------------|-----------------|-----------|-------------------|-----------------|--------------|
| 1041 | IAS_GUARN_TYPE | ITEM_CARD | n:1 | IGT_ITM | ITM_CODE | IAGUTY_ITCA_FK | الضمانات والكفالات | ربط ias guarn type بـitem card |
| 1067 | S_JOB | ITEM_CARD | n:1 | SJ_ITM | ITM_CODE | SJO_ITCA_FK | الموارد البشرية | ربط s job بـitem card |
| 1171 | IAS_GUARN_TYPE | ITEM_CARD | n:1 | IGT_ITM | ITM_CODE | IAGUTY_ITCA_FK | الضمانات والكفالات | ربط ias guarn type بـitem card |
| 1201 | IAS_AP_CNTRCT | ITEM_CARD | n:1 | IAC_ITM | ITM_CODE | IAAPCN_ITCA_FK | المشاريع والعقود | ربط ias ap cntrct بـitem card |
| 1251 | IAS_VNDR_CLSS | ITEM_CARD | n:1 | IVC_ITM | ITM_CODE | IAVNCL_ITCA_FK | المشتريات والموردين | ربط ias vndr clss بـitem card |

## الجداول الرئيسية في موديول المخزون والمستودعات

> هذا القسم يعرف الجداول الرئيسية (الكيانات) في موديول المخزون والمستودعات ووظائفها الأساسية. تمثل هذه الجداول العمود الفقري لوظائف إدارة المخزون وتتفاعل معًا لتوفير جميع عمليات المخزون من إضافة وصرف وتحويل وجرد وتقييم.

الجداول التالية تعتبر من الجداول المركزية في موديول المخزون والمستودعات:

1. **ITEM_CARD** - بطاقة الصنف: يحتوي على البيانات الأساسية للأصناف المخزنية مثل الاسم، الوصف، الباركود، الصورة، وغيرها من البيانات التعريفية
2. **WAREHOUSE** - المستودع: يحتوي على بيانات المستودعات مثل الاسم، الموقع، المسؤول، الطاقة الاستيعابية، وبيانات الاتصال
3. **STK_MOVMNT** - حركة المخزون: يسجل جميع حركات الأصناف من وإلى المستودعات، سواء كانت إضافة، صرف، تحويل، أو تسوية
4. **ITEM_COST** - تكلفة الصنف: يحتفظ بمعلومات تكلفة الأصناف بمختلف الطرق (المتوسط، FIFO، LIFO، إلخ) لاستخدامها في التقييم المالي
5. **MEASUREMENT** - وحدة القياس: يحتوي على وحدات القياس المختلفة للأصناف مثل قطعة، كرتون، صندوق، كيلوجرام، لتر، إلخ
6. **IAS_ITM_CLSS** - تصنيف الصنف: يصنف الأصناف إلى مجموعات كبيرة مثل مواد خام، منتجات تامة، مواد استهلاكية، قطع غيار، إلخ
7. **IAS_ITM_GRP** - مجموعة الصنف: يجمع الأصناف في مجموعات منطقية حسب النوع، الاستخدام، المورد، أو أي تصنيف آخر يناسب احتياجات المنشأة
8. **ITEM_UNIT_PRICE** - سعر وحدة الصنف: يحدد أسعار وحدات الأصناف المختلفة حسب قوائم الأسعار المتعددة، الخصومات، العروض، والعملاء
9. **STK_PHYS_COUNT** - الجرد الفعلي: يسجل عمليات الجرد الفعلي للمخزون ويحتفظ بالكميات الفعلية الموجودة في المستودعات 
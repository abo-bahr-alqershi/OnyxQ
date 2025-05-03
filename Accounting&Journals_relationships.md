# علاقات موديول الحسابات والدفتر العام (Accounting & Journals)

هذا الملف يوثق جميع العلاقات بين الجداول المختلفة في موديول الحسابات والدفتر العام (Accounting & Journals) في نظام OnyxQ Pro ERP، سواء العلاقات الداخلية بين جداول الموديول نفسه أو العلاقات الخارجية مع الموديولات الأخرى.

## دليل استخدام التوثيق

توضح الجداول التالية علاقات قاعدة البيانات بين مختلف كيانات موديول الحسابات والدفتر العام:
- **جدول المصدر**: يمثل الكيان الذي ينشئ العلاقة
- **جدول الهدف**: يمثل الكيان المرتبط به
- **نوع العلاقة**: يوضح نوع العلاقة (1:1 = واحد لواحد، 1:n = واحد لعديد، n:1 = عديد لواحد، n:m = عديد لعديد)
- **اختصار العلاقة**: اختصار رمزي للعلاقة مكون من أسماء الجداول المشاركة
- **رمز الهدف**: الرمز المستخدم في جدول الهدف
- **اسم المفتاح الأجنبي**: اسم المفتاح الأجنبي (Foreign Key) في قاعدة البيانات
- **المجموعة الوظيفية**: الوحدة أو المجموعة الوظيفية التي تنتمي إليها العلاقة
- **وصف العلاقة**: شرح مبسط للعلاقة بين الجداول

## العلاقات الداخلية للموديول

هذا القسم يوضح العلاقات بين الجداول داخل موديول الحسابات والدفتر العام.

| # | جدول المصدر | جدول الهدف | نوع العلاقة | اختصار العلاقة | رمز الهدف | اسم المفتاح الأجنبي | المجموعة الوظيفية | وصف العلاقة |
|---|-------------|------------|------------|-----------------|-----------|-------------------|-----------------|--------------| 
| 710 | ACCOUNT_CURR | GLS_COST_CENTER_TRANS | n:1 | AC_GCCT | GCCT_CODE | ACCU_GLCOCETR_FK | الحسابات والدفتر العام | ربط account curr بـgls cost center trans |
| 719 | ACCOUNT_CURR | ACCOUNT_TYPES | n:1 | AC_AT | AT_CODE | ACCU_ACTY_FK | الحسابات والدفتر العام | ربط account curr بـaccount types |
| 730 | ACCOUNT_TYPES | MASTER_JOURNAL | n:1 | AT_MJ | MJ_CODE | ACTY_MAJO_FK | الحسابات والدفتر العام | ربط account types بـmaster journal |
| 742 | ACCOUNT | ACCOUNT_CURR | n:1 | A_AC | AC_CODE | AC_ACCU_FK | الحسابات والدفتر العام | ربط account بـaccount curr |
| 756 | OPEN_BAL | ACCOUNT_TYPES | n:1 | OB_AT | AT_CODE | OPBA_ACTY_FK | الحسابات والدفتر العام | ربط open bal بـaccount types |
| 786 | GLS_COST_CENTER_TRANS | ACCOUNT_GROUPING | n:1 | GCCT_AG | AG_CODE | GLCOCETR_ACGR_FK | الحسابات والدفتر العام | ربط gls cost center trans بـaccount grouping |
| 788 | ACCOUNT_CURR | ACCOUNT_GROUPING | n:1 | AC_AG | AG_CODE | ACCU_ACGR_FK | الحسابات والدفتر العام | ربط account curr بـaccount grouping |
| 789 | MASTER_JOURNAL | ACCOUNT_GROUPING | n:1 | MJ_AG | AG_CODE | MAJO_ACGR_FK | الحسابات والدفتر العام | ربط master journal بـaccount grouping |
| 794 | DETAIL_JOURNAL | MASTER_JOURNAL | n:1 | DJ_MJ | MJ_CODE | DEJO_MAJO_FK | الحسابات والدفتر العام | ربط تفاصيل القيد بسند القيد |
| 797 | ACCOUNT_GROUPING | ACCOUNT | n:1 | AG_A | A_CODE | ACGR_AC_FK | الحسابات والدفتر العام | ربط account grouping بـaccount |
| 800 | ACCOUNT_TYPES | MASTER_JOURNAL | n:1 | AT_MJ | MJ_CODE | ACTY_MAJO_FK | الحسابات والدفتر العام | ربط account types بـmaster journal |
| 804 | ACCOUNT_CURR | ACCOUNT_GROUPING | n:1 | AC_AG | AG_CODE | ACCU_ACGR_FK | الحسابات والدفتر العام | ربط account curr بـaccount grouping |
| 810 | ACCOUNT_TYPES | MASTER_JOURNAL | n:1 | AT_MJ | MJ_CODE | ACTY_MAJO_FK | الحسابات والدفتر العام | ربط account types بـmaster journal |
| 818 | DETAIL_JOURNAL | ACCOUNT | n:1 | DJ_A | A_CODE | DEJO_AC_FK | الحسابات والدفتر العام | ربط تفاصيل القيد بالحساب |
| 828 | ACCOUNT_GROUPING | ACCOUNT_REPORT_TYPE | 1:1 | AG_ART | ART_CODE | ACGR_ACRETY_FK | الحسابات والدفتر العام | ربط account grouping بـaccount report type |
| 844 | ACCOUNT_TYPES | ACCOUNT_CURR | 1:n | AT_AC | AC_CODE | ACTY_ACCU_FK | الحسابات والدفتر العام | ربط account types بـaccount curr |
| 864 | MASTER_JOURNAL | ACCOUNT_REPORT_TYPE | n:1 | MJ_ART | ART_CODE | MAJO_ACRETY_FK | الحسابات والدفتر العام | ربط master journal بـaccount report type |
| 876 | ACCOUNT_TYPES | OPEN_BAL | 1:n | AT_OB | OB_CODE | ACTY_OPBA_FK | الحسابات والدفتر العام | ربط account types بـopen bal |
| 884 | ACCOUNT_TYPES | MASTER_JOURNAL | n:1 | AT_MJ | MJ_CODE | ACTY_MAJO_FK | الحسابات والدفتر العام | ربط account types بـmaster journal |
| 889 | MASTER_JOURNAL | ACCOUNT | n:1 | MJ_A | A_CODE | MAJO_AC_FK | الحسابات والدفتر العام | ربط master journal بـaccount |
| 893 | ACCOUNT | GLS_COST_CENTER_TRANS | 1:n | A_GCCT | GCCT_CODE | AC_GLCOCETR_FK | الحسابات والدفتر العام | ربط account بـgls cost center trans |
| 896 | ACCOUNT_CURR | GLS_COST_CENTER_TRANS | n:1 | AC_GCCT | GCCT_CODE | ACCU_GLCOCETR_FK | الحسابات والدفتر العام | ربط account curr بـgls cost center trans |
| 897 | ACCOUNT_TYPES | ACCOUNT | n:1 | AT_A | A_CODE | ACTY_AC_FK | الحسابات والدفتر العام | ربط account types بـaccount |
| 903 | ACCOUNT | ACCOUNT_REPORT_TYPE | n:1 | A_ART | ART_CODE | AC_ACRETY_FK | الحسابات والدفتر العام | ربط account بـaccount report type |
| 906 | MASTER_JOURNAL | GLS_COST_CENTER_TRANS | 1:1 | MJ_GCCT | GCCT_CODE | MAJO_GLCOCETR_FK | الحسابات والدفتر العام | ربط master journal بـgls cost center trans |
| 931 | GLS_COST_CENTER_TRANS | ACCOUNT_CURR | n:1 | GCCT_AC | AC_CODE | GLCOCETR_ACCU_FK | الحسابات والدفتر العام | ربط gls cost center trans بـaccount curr |
| 932 | DETAIL_JOURNAL | ACCOUNT_TYPES | 1:1 | DJ_AT | AT_CODE | DEJO_ACTY_FK | الحسابات والدفتر العام | ربط detail journal بـaccount types |
| 955 | ACCOUNT_CURR | ACCOUNT_REPORT_TYPE | 1:n | AC_ART | ART_CODE | ACCU_ACRETY_FK | الحسابات والدفتر العام | ربط account curr بـaccount report type |
| 956 | ACCOUNT_REPORT_TYPE | ACCOUNT_GROUPING | n:1 | ART_AG | AG_CODE | ACRETY_ACGR_FK | الحسابات والدفتر العام | ربط account report type بـaccount grouping |
| 961 | ACCOUNT_TYPES | OPEN_BAL | n:1 | AT_OB | OB_CODE | ACTY_OPBA_FK | الحسابات والدفتر العام | ربط account types بـopen bal |
| 968 | ACCOUNT_REPORT_TYPE | GLS_COST_CENTER_TRANS | n:m | ART_GCCT | GCCT_CODE | ACRETY_GLCOCETR_FK | الحسابات والدفتر العام | ربط account report type بـgls cost center trans |
| 976 | ACCOUNT_CURR | IAS_ACTVTY | n:1 | AC_ACTVTY | ACTVTY_CODE | ACCU_IAAC_FK | الحسابات والدفتر العام | ربط account curr بـias actvty |
| 989 | ACCOUNT_CURR | DETAIL_JOURNAL | n:1 | AC_DJ | DJ_CODE | ACCU_DEJO_FK | الحسابات والدفتر العام | ربط account curr بـdetail journal |
| 992 | ACCOUNT | OPEN_BAL | n:1 | A_OB | OB_CODE | AC_OPBA_FK | الحسابات والدفتر العام | ربط account بـopen bal |
| 1000 | GLS_COST_CENTER_TRANS | MASTER_JOURNAL | n:1 | GCCT_MJ | MJ_CODE | GLCOCETR_MAJO_FK | الحسابات والدفتر العام | ربط gls cost center trans بـmaster journal |
| 1004 | MASTER_JOURNAL | ACCOUNT_REPORT_TYPE | n:1 | MJ_ART | ART_CODE | MAJO_ACRETY_FK | الحسابات والدفتر العام | ربط master journal بـaccount report type |
| 1024 | OPEN_BAL | ACCOUNT_REPORT_TYPE | n:1 | OB_ART | ART_CODE | OPBA_ACRETY_FK | الحسابات والدفتر العام | ربط open bal بـaccount report type |
| 1028 | ACCOUNT_REPORT_TYPE | GLS_COST_CENTER_TRANS | n:m | ART_GCCT | GCCT_CODE | ACRETY_GLCOCETR_FK | الحسابات والدفتر العام | ربط account report type بـgls cost center trans |
| 1029 | ACCOUNT_REPORT_TYPE | ACCOUNT | n:1 | ART_A | A_CODE | ACRETY_AC_FK | الحسابات والدفتر العام | ربط account report type بـaccount |
| 1058 | ACCOUNT_TYPES | ACCOUNT_REPORT_TYPE | 1:n | AT_ART | ART_CODE | ACTY_ACRETY_FK | الحسابات والدفتر العام | ربط account types بـaccount report type |
| 1070 | GLS_COST_CENTER_TRANS | DETAIL_JOURNAL | n:1 | GCCT_DJ | DJ_CODE | GLCOCETR_DEJO_FK | الحسابات والدفتر العام | ربط gls cost center trans بـdetail journal |
| 1076 | ACCOUNT | IAS_ACTVTY | n:1 | A_ACTVTY | ACTVTY_CODE | AC_IAAC_FK | الحسابات والدفتر العام | ربط account بـias actvty |
| 1103 | DETAIL_JOURNAL | OPEN_BAL | n:1 | DJ_OB | OB_CODE | DEJO_OPBA_FK | الحسابات والدفتر العام | ربط detail journal بـopen bal |
| 1108 | GLS_COST_CENTER_TRANS | ACCOUNT_REPORT_TYPE | n:1 | GCCT_ART | ART_CODE | GLCOCETR_ACRETY_FK | الحسابات والدفتر العام | ربط gls cost center trans بـaccount report type |
| 1109 | MASTER_JOURNAL | IAS_CURRENCY | n:1 | MJ_CY | CY_CODE | MAJO_IACU_FK | الحسابات والدفتر العام | ربط master journal بـias currency |
| 1115 | MASTER_JOURNAL | ACCOUNT_TYPES | 1:1 | MJ_AT | AT_CODE | MAJO_ACTY_FK | الحسابات والدفتر العام | ربط master journal بـaccount types |
| 1118 | OPEN_BAL | CUSTOMER | n:1 | OB_CST | CST_CODE | OPBA_CU_FK | الحسابات والدفتر العام | ربط open bal بـcustomer |
| 1119 | MASTER_JOURNAL | ACCOUNT | n:1 | MJ_A | A_CODE | MAJO_AC_FK | الحسابات والدفتر العام | ربط master journal بـaccount |
| 1123 | ACCOUNT_GROUPING | DETAIL_JOURNAL | n:1 | AG_DJ | DJ_CODE | ACGR_DEJO_FK | الحسابات والدفتر العام | ربط account grouping بـdetail journal |
| 1125 | ACCOUNT_GROUPING | GLS_COST_CENTER_TRANS | n:1 | AG_GCCT | GCCT_CODE | ACGR_GLCOCETR_FK | الحسابات والدفتر العام | ربط account grouping بـgls cost center trans |
| 1130 | ACCOUNT_GROUPING | OPEN_BAL | 1:n | AG_OB | OB_CODE | ACGR_OPBA_FK | الحسابات والدفتر العام | ربط account grouping بـopen bal |
| 1131 | ACCOUNT_TYPES | GLS_COST_CENTER_TRANS | n:1 | AT_GCCT | GCCT_CODE | ACTY_GLCOCETR_FK | الحسابات والدفتر العام | ربط account types بـgls cost center trans |
| 1146 | ACCOUNT_GROUPING | ACCOUNT | n:1 | AG_A | A_CODE | ACGR_AC_FK | الحسابات والدفتر العام | ربط account grouping بـaccount |
| 1149 | ACCOUNT_CURR | GLS_COST_CENTER_TRANS | n:1 | AC_GCCT | GCCT_CODE | ACCU_GLCOCETR_FK | الحسابات والدفتر العام | ربط account curr بـgls cost center trans |
| 1154 | GLS_COST_CENTER_TRANS | ACCOUNT | n:1 | GCCT_A | A_CODE | GLCOCETR_AC_FK | الحسابات والدفتر العام | ربط gls cost center trans بـaccount |
| 1157 | ACCOUNT_REPORT_TYPE | ACCOUNT_GROUPING | n:1 | ART_AG | AG_CODE | ACRETY_ACGR_FK | الحسابات والدفتر العام | ربط account report type بـaccount grouping |
| 1161 | ACCOUNT_REPORT_TYPE | ACCOUNT_TYPES | 1:n | ART_AT | AT_CODE | ACRETY_ACTY_FK | الحسابات والدفتر العام | ربط account report type بـaccount types |
| 1168 | MASTER_JOURNAL | ACCOUNT_TYPES | 1:n | MJ_AT | AT_CODE | MAJO_ACTY_FK | الحسابات والدفتر العام | ربط master journal بـaccount types |
| 1178 | MASTER_JOURNAL | ACCOUNT_REPORT_TYPE | n:m | MJ_ART | ART_CODE | MAJO_ACRETY_FK | الحسابات والدفتر العام | ربط master journal بـaccount report type |
| 1187 | ACCOUNT_REPORT_TYPE | ACCOUNT | n:1 | ART_A | A_CODE | ACRETY_AC_FK | الحسابات والدفتر العام | ربط account report type بـaccount |
| 1188 | OPEN_BAL | GLS_COST_CENTER_TRANS | n:1 | OB_GCCT | GCCT_CODE | OPBA_GLCOCETR_FK | الحسابات والدفتر العام | ربط open bal بـgls cost center trans |
| 1189 | ACCOUNT_TYPES | VENDOR | n:1 | AT_VNDR | VNDR_CODE | ACTY_VE_FK | الحسابات والدفتر العام | ربط account types بـvendor |
| 1190 | DETAIL_JOURNAL | ACCOUNT_GROUPING | n:1 | DJ_AG | AG_CODE | DEJO_ACGR_FK | الحسابات والدفتر العام | ربط detail journal بـaccount grouping |
| 1212 | MASTER_JOURNAL | ACCOUNT_CURR | n:1 | MJ_AC | AC_CODE | MAJO_ACCU_FK | الحسابات والدفتر العام | ربط master journal بـaccount curr |
| 1221 | GLS_COST_CENTER_TRANS | ACCOUNT_GROUPING | 1:n | GCCT_AG | AG_CODE | GLCOCETR_ACGR_FK | الحسابات والدفتر العام | ربط gls cost center trans بـaccount grouping |
| 1250 | DETAIL_JOURNAL | ACCOUNT_CURR | n:m | DJ_AC | AC_CODE | DEJO_ACCU_FK | الحسابات والدفتر العام | ربط detail journal بـaccount curr |
| 1256 | OPEN_BAL | ACCOUNT_REPORT_TYPE | 1:n | OB_ART | ART_CODE | OPBA_ACRETY_FK | الحسابات والدفتر العام | ربط open bal بـaccount report type |

## العلاقات الخارجية للموديول

هذا القسم يوضح العلاقات بين جداول موديول الحسابات والدفتر العام والموديولات الأخرى.

| # | جدول المصدر | جدول الهدف | نوع العلاقة | اختصار العلاقة | رمز الهدف | اسم المفتاح الأجنبي | المجموعة الوظيفية | وصف العلاقة |
|---|-------------|------------|------------|-----------------|-----------|-------------------|-----------------|--------------| 
| 785 | IAS_USR_LGN_HSTRY | ACCOUNT | n:1 | IULH_A | A_CODE | IAUSLGHS_AC_FK | النظام والأمن | ربط ias usr lgn hstry بـaccount |
| 853 | ITEM_COST | MASTER_JOURNAL | n:1 | IC_MJ | MJ_CODE | ITCO_MAJO_FK | المخزون والمستودعات | ربط item cost بـmaster journal |
| 859 | APX_SCR_PRV | ACCOUNT | n:1 | ASP_A | A_CODE | APSCPR_AC_FK | النظام والأمن | ربط apx scr prv بـaccount |
| 775 | APX_SCR_PRV | MASTER_JOURNAL | n:1 | ASP_MJ | MJ_CODE | APSCPR_MAJO_FK | النظام والأمن | ربط apx scr prv بـmaster journal |
| 935 | ITEM_CARD | MASTER_JOURNAL | n:1 | IC_MJ | MJ_CODE | ITCA_MAJO_FK | المخزون والمستودعات | ربط item card بـmaster journal |
| 980 | IAS_PI_BILL | ACCOUNT | n:1 | IPB_A | A_CODE | IAPIBI_AC_FK | المشتريات والموردين | ربط ias pi bill بـaccount |
| 988 | GRN_DETAIL | ACCOUNT | n:m | GRN_A | A_CODE | GRDE_AC_FK | المشتريات والموردين | ربط تفاصيل grn detail بـaccount |
| 999 | IAS_USR_PRF | MASTER_JOURNAL | n:1 | IUP_MJ | MJ_CODE | IAUSPR_MAJO_FK | النظام والأمن | ربط ias usr prf بـmaster journal |
| 1025 | GUARN_DETAILS | ACCOUNT | n:1 | GUARN_A | A_CODE | GUDE_AC_FK | الضمانات والكفالات | ربط guarn details بـaccount |
| 1061 | WAREHOUSE | MASTER_JOURNAL | n:1 | W_MJ | MJ_CODE | WA_MAJO_FK | المخزون والمستودعات | ربط warehouse بـmaster journal |
| 1135 | IAS_AR_CNTRCT | ACCOUNT | n:1 | IAC_A | A_CODE | IAARCN_AC_FK | المشاريع والعقود | ربط ias ar cntrct بـaccount |
| 1185 | CUSTOMER | ACCOUNT | n:1 | C_A | A_CODE | CU_AC_FK | المبيعات والعملاء | ربط customer بـaccount |
| 1191 | HRS_SAL | ACCOUNT | n:1 | HS_A | A_CODE | HRSA_AC_FK | الموارد البشرية | ربط hrs sal بـaccount |
| 1211 | GLS_COST_CENTER_TRANS | VENDOR | n:1 | GCCT_VNDR | VNDR_CODE | GLCOCETR_VE_FK | الحسابات والدفتر العام | ربط gls cost center trans بـvendor |
| 1259 | ITEM_CARD | MASTER_JOURNAL | n:1 | IC_MJ | MJ_CODE | ITCA_MAJO_FK | المخزون والمستودعات | ربط item card بـmaster journal |

## معلومات إضافية

تستخدم وحدة الحسابات والدفتر العام (Accounting & Journals) الجداول الرئيسية التالية:

1. **ACCOUNT** - جدول الحسابات الرئيسي
2. **ACCOUNT_TYPES** - أنواع الحسابات
3. **ACCOUNT_CURR** - عملات الحسابات
4. **ACCOUNT_GROUPING** - تجميعات الحسابات
5. **ACCOUNT_REPORT_TYPE** - أنواع تقارير الحسابات
6. **MASTER_JOURNAL** - سندات القيد الرئيسية
7. **DETAIL_JOURNAL** - تفاصيل سندات القيد
8. **GLS_COST_CENTER_TRANS** - تحركات مراكز التكلفة
9. **OPEN_BAL** - الأرصدة الافتتاحية

يمكن استخدام هذا التوثيق للأغراض التالية:
1. فهم بنية قاعدة البيانات وعلاقاتها المتعلقة بالحسابات والدفتر العام
2. تحليل تأثير التغييرات على العلاقات المترابطة
3. تصميم استعلامات SQL معقدة تتضمن عدة جداول مترابطة
4. تطوير واجهات برمجة التطبيقات (APIs) التي تتعامل مع البيانات المحاسبية
5. تخطيط تطوير وتحسين البنية المستقبلية لقاعدة البيانات

## ملاحظة هامة

هذا الملف يحتوي على بيانات نموذجية تم استخراجها من ملف العلاقات الرئيسي. في بيئة الإنتاج، يجب تحديث هذا الملف دورياً عند إجراء أي تغييرات على هيكل قاعدة البيانات.

# علاقات موديول النقدية والبنوك والخزائن (Cash & Banks & Safes)

هذا الملف يوثق جميع العلاقات بين الجداول المختلفة في موديول النقدية والبنوك والخزائن (Cash & Banks & Safes) في نظام OnyxQ Pro ERP، سواء العلاقات الداخلية بين جداول الموديول نفسه أو العلاقات الخارجية مع الموديولات الأخرى.

## دليل استخدام التوثيق

توضح الجداول التالية علاقات قاعدة البيانات بين مختلف كيانات موديول النقدية والبنوك والخزائن:
- **جدول المصدر**: يمثل الكيان الذي ينشئ العلاقة
- **جدول الهدف**: يمثل الكيان المرتبط به
- **نوع العلاقة**: يوضح نوع العلاقة (1:1 = واحد لواحد، 1:n = واحد لعديد، n:1 = عديد لواحد، n:m = عديد لعديد)
- **اختصار العلاقة**: اختصار رمزي للعلاقة مكون من أسماء الجداول المشاركة
- **رمز الهدف**: الرمز المستخدم في جدول الهدف
- **اسم المفتاح الأجنبي**: اسم المفتاح الأجنبي (Foreign Key) في قاعدة البيانات
- **المجموعة الوظيفية**: الوحدة أو المجموعة الوظيفية التي تنتمي إليها العلاقة
- **وصف العلاقة**: شرح مبسط للعلاقة بين الجداول

## العلاقات الداخلية للموديول

هذا القسم يوضح العلاقات بين الجداول داخل موديول النقدية والبنوك والخزائن.

| # | جدول المصدر | جدول الهدف | نوع العلاقة | اختصار العلاقة | رمز الهدف | اسم المفتاح الأجنبي | المجموعة الوظيفية | وصف العلاقة |
|---|-------------|------------|------------|-----------------|-----------|-------------------|-----------------|--------------| 
| 725 | IAS_CASH_OUTGOING | IAS_USR | n:1 | ICO_IU | IU_CODE | IACAOU_IAUS_FK | النقدية والبنوك | ربط ias cash outgoing بـias usr |
| 729 | IAS_BANK | IAS_BANK_ACCOUNT | n:1 | IB_IBA | IBA_CODE | IABA_IABAAC_FK | النقدية والبنوك | ربط ias bank بـias bank account |
| 741 | IAS_CASH_INCOME | BANK_CHEQUE | n:1 | ICI_BC | BC_CODE | IACAIN_BACH_FK | النقدية والبنوك | ربط ias cash income بـbank cheque |
| 744 | IAS_BANK | IAS_BANK_ACCOUNT | n:1 | IB_IBA | IBA_CODE | IABA_IABAAC_FK | النقدية والبنوك | ربط ias bank بـias bank account |
| 745 | IAS_BANK | IAS_BANK_ACCOUNT | 1:1 | IB_IBA | IBA_CODE | IABA_IABAAC_FK | النقدية والبنوك | ربط ias bank بـias bank account |
| 747 | IAS_CASH | ITEM_CARD | n:1 | IC_ITM | ITM_CODE | IACA_ITCA_FK | النقدية والبنوك | ربط ias cash بـitem card |
| 757 | IAS_BANK_ACCOUNT | IAS_CASH_INCOME | n:1 | IBA_ICI | ICI_CODE | IABAAC_IACAIN_FK | النقدية والبنوك | ربط ias bank account بـias cash income |
| 761 | CASH_RECEIPT | IAS_BANK_ACCOUNT | 1:n | CR_IBA | IBA_CODE | CARE_IABAAC_FK | النقدية والبنوك | ربط cash receipt بـias bank account |
| 763 | IAS_BANK_ACCOUNT | IAS_CASH_INCOME | 1:n | IBA_ICI | ICI_CODE | IABAAC_IACAIN_FK | النقدية والبنوك | ربط ias bank account بـias cash income |
| 771 | IAS_CASH_OUTGOING | IAS_CASH_INCOME | 1:n | ICO_ICI | ICI_CODE | IACAOU_IACAIN_FK | النقدية والبنوك | ربط ias cash outgoing بـias cash income |
| 787 | IAS_BANK_ACCOUNT | CASH_PAYMENT | 1:n | IBA_CP | CP_CODE | IABAAC_CAPA_FK | النقدية والبنوك | ربط ias bank account بـcash payment |
| 821 | CASH_PAYMENT | IAS_CASH_OUTGOING | n:1 | CP_ICO | ICO_CODE | CAPA_IACAOU_FK | النقدية والبنوك | ربط cash payment بـias cash outgoing |
| 842 | IAS_CASH_OUTGOING | CASH_PAYMENT | n:1 | ICO_CP | CP_CODE | IACAOU_CAPA_FK | النقدية والبنوك | ربط ias cash outgoing بـcash payment |
| 843 | IAS_CASH_OUTGOING | CASH_PAYMENT | n:1 | ICO_CP | CP_CODE | IACAOU_CAPA_FK | النقدية والبنوك | ربط ias cash outgoing بـcash payment |
| 860 | IAS_CASH_INCOME | COST_CENTERS | n:1 | ICI_CC | CC_CODE | IACAIN_COCE_FK | النقدية والبنوك | ربط ias cash income بـcost centers |
| 867 | CASH_RECEIPT | CASH_PAYMENT | n:1 | CR_CP | CP_CODE | CARE_CAPA_FK | النقدية والبنوك | ربط cash receipt بـcash payment |
| 890 | IAS_BANK_ACCOUNT | CASH_RECEIPT | n:1 | IBA_CR | CR_CODE | IABAAC_CARE_FK | النقدية والبنوك | ربط ias bank account بـcash receipt |
| 898 | CASH_PAYMENT | CASH_RECEIPT | n:1 | CP_CR | CR_CODE | CAPA_CARE_FK | النقدية والبنوك | ربط cash payment بـcash receipt |
| 901 | CASH_RECEIPT | IAS_CURRENCY | n:1 | CR_CY | CY_CODE | CARE_IACU_FK | النقدية والبنوك | ربط cash receipt بـias currency |
| 908 | CASH_PAYMENT | IAS_BANK_ACCOUNT | n:1 | CP_IBA | IBA_CODE | CAPA_IABAAC_FK | النقدية والبنوك | ربط cash payment بـias bank account |
| 909 | IAS_CASH_OUTGOING | BANK_CHEQUE | 1:n | ICO_BC | BC_CODE | IACAOU_BACH_FK | النقدية والبنوك | ربط ias cash outgoing بـbank cheque |
| 910 | BANK_CHEQUE | IAS_BANK | n:1 | BC_IB | IB_CODE | BACH_IABA_FK | النقدية والبنوك | ربط bank cheque بـias bank |
| 919 | CASH_PAYMENT | IAS_BANK | n:1 | CP_IB | IB_CODE | CAPA_IABA_FK | النقدية والبنوك | ربط cash payment بـias bank |
| 933 | CASH_PAYMENT | ITEM_CARD | n:1 | CP_ITM | ITM_CODE | CAPA_ITCA_FK | النقدية والبنوك | ربط cash payment بـitem card |
| 934 | IAS_CASH_OUTGOING | IAS_CASH | n:1 | ICO_IC | IC_CODE | IACAOU_IACA_FK | النقدية والبنوك | ربط ias cash outgoing بـias cash |
| 947 | IAS_CASH | BANK_CHEQUE | 1:n | IC_BC | BC_CODE | IACA_BACH_FK | النقدية والبنوك | ربط ias cash بـbank cheque |
| 965 | IAS_CASH | IAS_BANK | n:1 | IC_IB | IB_CODE | IACA_IABA_FK | النقدية والبنوك | ربط ias cash بـias bank |
| 977 | IAS_BANK | CASH_RECEIPT | n:1 | IB_CR | CR_CODE | IABA_CARE_FK | النقدية والبنوك | ربط ias bank بـcash receipt |
| 982 | IAS_CASH_INCOME | BANK_CHEQUE | n:1 | ICI_BC | BC_CODE | IACAIN_BACH_FK | النقدية والبنوك | ربط ias cash income بـbank cheque |
| 990 | IAS_CASH_INCOME | IAS_CASH | n:1 | ICI_IC | IC_CODE | IACAIN_IACA_FK | النقدية والبنوك | ربط ias cash income بـias cash |
| 991 | IAS_BANK | IAS_CASH_OUTGOING | n:1 | IB_ICO | ICO_CODE | IABA_IACAOU_FK | النقدية والبنوك | ربط ias bank بـias cash outgoing |
| 994 | BANK_CHEQUE | CASH_RECEIPT | n:1 | BC_CR | CR_CODE | BACH_CARE_FK | النقدية والبنوك | ربط bank cheque بـcash receipt |
| 1006 | IAS_CASH_OUTGOING | IAS_BANK_ACCOUNT | n:1 | ICO_IBA | IBA_CODE | IACAOU_IABAAC_FK | النقدية والبنوك | ربط ias cash outgoing بـias bank account |
| 1052 | CASH_RECEIPT | IAS_CASH_OUTGOING | n:1 | CR_ICO | ICO_CODE | CARE_IACAOU_FK | النقدية والبنوك | ربط cash receipt بـias cash outgoing |
| 1053 | BANK_CHEQUE | IAS_BANK_ACCOUNT | n:1 | BC_IBA | IBA_CODE | BACH_IABAAC_FK | النقدية والبنوك | ربط bank cheque بـias bank account |
| 1062 | IAS_BANK_ACCOUNT | CASH_PAYMENT | n:1 | IBA_CP | CP_CODE | IABAAC_CAPA_FK | النقدية والبنوك | ربط ias bank account بـcash payment |
| 1073 | CASH_RECEIPT | IAS_BANK | n:1 | CR_IB | IB_CODE | CARE_IABA_FK | النقدية والبنوك | ربط cash receipt بـias bank |
| 1081 | IAS_BANK | CASH_RECEIPT | 1:n | IB_CR | CR_CODE | IABA_CARE_FK | النقدية والبنوك | ربط ias bank بـcash receipt |
| 1088 | IAS_CASH_OUTGOING | IAS_CASH | n:1 | ICO_IC | IC_CODE | IACAOU_IACA_FK | النقدية والبنوك | ربط ias cash outgoing بـias cash |
| 1092 | IAS_BANK | IAS_USR | n:1 | IB_IU | IU_CODE | IABA_IAUS_FK | النقدية والبنوك | ربط ias bank بـias usr |
| 1095 | IAS_CASH_INCOME | BANK_CHEQUE | n:1 | ICI_BC | BC_CODE | IACAIN_BACH_FK | النقدية والبنوك | ربط ias cash income بـbank cheque |
| 1096 | IAS_CASH_INCOME | BANK_CHEQUE | 1:n | ICI_BC | BC_CODE | IACAIN_BACH_FK | النقدية والبنوك | ربط ias cash income بـbank cheque |
| 1105 | CASH_RECEIPT | CASH_PAYMENT | n:1 | CR_CP | CP_CODE | CARE_CAPA_FK | النقدية والبنوك | ربط cash receipt بـcash payment |
| 1110 | IAS_CASH_OUTGOING | CASH_PAYMENT | n:1 | ICO_CP | CP_CODE | IACAOU_CAPA_FK | النقدية والبنوك | ربط ias cash outgoing بـcash payment |
| 1112 | IAS_CASH | IAS_BANK | 1:n | IC_IB | IB_CODE | IACA_IABA_FK | النقدية والبنوك | ربط ias cash بـias bank |
| 1113 | IAS_BANK | IAS_CASH_INCOME | n:1 | IB_ICI | ICI_CODE | IABA_IACAIN_FK | النقدية والبنوك | ربط ias bank بـias cash income |
| 1164 | BANK_CHEQUE | IAS_CASH | n:1 | BC_IC | IC_CODE | BACH_IACA_FK | النقدية والبنوك | ربط bank cheque بـias cash |
| 1165 | IAS_CASH | IAS_CASH_INCOME | n:1 | IC_ICI | ICI_CODE | IACA_IACAIN_FK | النقدية والبنوك | ربط ias cash بـias cash income |
| 1169 | IAS_CASH_INCOME | CASH_PAYMENT | n:1 | ICI_CP | CP_CODE | IACAIN_CAPA_FK | النقدية والبنوك | ربط ias cash income بـcash payment |
| 1173 | CASH_PAYMENT | BANK_CHEQUE | 1:n | CP_BC | BC_CODE | CAPA_BACH_FK | النقدية والبنوك | ربط cash payment بـbank cheque |
| 1186 | IAS_BANK | BANK_CHEQUE | n:1 | IB_BC | BC_CODE | IABA_BACH_FK | النقدية والبنوك | ربط ias bank بـbank cheque |
| 1196 | IAS_BANK | CASH_RECEIPT | n:1 | IB_CR | CR_CODE | IABA_CARE_FK | النقدية والبنوك | ربط ias bank بـcash receipt |
| 1200 | IAS_BANK | IAS_BANK_ACCOUNT | n:1 | IB_IBA | IBA_CODE | IABA_IABAAC_FK | النقدية والبنوك | ربط ias bank بـias bank account |
| 1203 | CASH_RECEIPT | IAS_BANK | n:1 | CR_IB | IB_CODE | CARE_IABA_FK | النقدية والبنوك | ربط cash receipt بـias bank |
| 1204 | IAS_CASH_OUTGOING | IAS_CASH_INCOME | n:1 | ICO_ICI | ICI_CODE | IACAOU_IACAIN_FK | النقدية والبنوك | ربط ias cash outgoing بـias cash income |
| 1207 | CASH_RECEIPT | IAS_CURRENCY | n:1 | CR_CY | CY_CODE | CARE_IACU_FK | النقدية والبنوك | ربط cash receipt بـias currency |
| 1222 | IAS_BANK | CASH_RECEIPT | n:1 | IB_CR | CR_CODE | IABA_CARE_FK | النقدية والبنوك | ربط ias bank بـcash receipt |
| 1224 | IAS_CASH_OUTGOING | IAS_BANK_ACCOUNT | n:1 | ICO_IBA | IBA_CODE | IACAOU_IABAAC_FK | النقدية والبنوك | ربط ias cash outgoing بـias bank account |
| 1230 | IAS_BANK | IAS_USR | n:1 | IB_IU | IU_CODE | IABA_IAUS_FK | النقدية والبنوك | ربط ias bank بـias usr |
| 1240 | CASH_PAYMENT | IAS_CASH | n:m | CP_IC | IC_CODE | CAPA_IACA_FK | النقدية والبنوك | ربط cash payment بـias cash |
| 1241 | CASH_RECEIPT | IAS_BANK | n:1 | CR_IB | IB_CODE | CARE_IABA_FK | النقدية والبنوك | ربط cash receipt بـias bank |
| 1244 | IAS_BANK_ACCOUNT | IAS_BANK | 1:n | IBA_IB | IB_CODE | IABAAC_IABA_FK | النقدية والبنوك | ربط ias bank account بـias bank |
| 1263 | IAS_CASH | IAS_CASH_OUTGOING | n:1 | IC_ICO | ICO_CODE | IACA_IACAOU_FK | النقدية والبنوك | ربط ias cash بـias cash outgoing |

## العلاقات الخارجية للموديول

هذا القسم يوضح العلاقات بين جداول موديول النقدية والبنوك والخزائن والموديولات الأخرى.

| # | جدول المصدر | جدول الهدف | نوع العلاقة | اختصار العلاقة | رمز الهدف | اسم المفتاح الأجنبي | المجموعة الوظيفية | وصف العلاقة |
|---|-------------|------------|------------|-----------------|-----------|-------------------|-----------------|--------------| 
| 747 | IAS_CASH | ITEM_CARD | n:1 | IC_ITM | ITM_CODE | IACA_ITCA_FK | النقدية والبنوك | ربط ias cash بـitem card |
| 860 | IAS_CASH_INCOME | COST_CENTERS | n:1 | ICI_CC | CC_CODE | IACAIN_COCE_FK | النقدية والبنوك | ربط ias cash income بـcost centers |
| 901 | CASH_RECEIPT | IAS_CURRENCY | n:1 | CR_CY | CY_CODE | CARE_IACU_FK | النقدية والبنوك | ربط cash receipt بـias currency |
| 933 | CASH_PAYMENT | ITEM_CARD | n:1 | CP_ITM | ITM_CODE | CAPA_ITCA_FK | النقدية والبنوك | ربط cash payment بـitem card |
| 1054 | IAS_USR | IAS_CURRENCY | n:1 | IU_CY | CY_CODE | IAUS_IACU_FK | النظام والأمن | ربط ias usr بـias currency |
| 1109 | MASTER_JOURNAL | IAS_CURRENCY | n:1 | MJ_CY | CY_CODE | MAJO_IACU_FK | الحسابات والدفتر العام | ربط master journal بـias currency |
| 1207 | CASH_RECEIPT | IAS_CURRENCY | n:1 | CR_CY | CY_CODE | CARE_IACU_FK | النقدية والبنوك | ربط cash receipt بـias currency |
| 1208 | ITEM_COST | IAS_CURRENCY | n:1 | IC_CY | CY_CODE | ITCO_IACU_FK | المخزون والمستودعات | ربط item cost بـias currency |

## معلومات إضافية

تستخدم وحدة النقدية والبنوك والخزائن (Cash & Banks & Safes) الجداول الرئيسية التالية:

1. **IAS_BANK** - جدول البنوك
2. **IAS_BANK_ACCOUNT** - الحسابات البنكية
3. **IAS_CASH** - النقدية والخزائن
4. **IAS_CASH_INCOME** - إيرادات النقدية
5. **IAS_CASH_OUTGOING** - مصروفات النقدية
6. **BANK_CHEQUE** - الشيكات البنكية
7. **CASH_RECEIPT** - سندات القبض
8. **CASH_PAYMENT** - سندات الصرف

يمكن استخدام هذا التوثيق للأغراض التالية:
1. فهم بنية قاعدة البيانات وعلاقاتها المتعلقة بالنقدية والبنوك والخزائن
2. تحليل تأثير التغييرات على العلاقات المترابطة
3. تصميم استعلامات SQL معقدة تتضمن عدة جداول مترابطة
4. تطوير واجهات برمجة التطبيقات (APIs) التي تتعامل مع البيانات المالية والنقدية
5. تخطيط تطوير وتحسين البنية المستقبلية لقاعدة البيانات

## ملاحظة هامة

هذا الملف يحتوي على بيانات نموذجية تم استخراجها من ملف العلاقات الرئيسي. في بيئة الإنتاج، يجب تحديث هذا الملف دورياً عند إجراء أي تغييرات على هيكل قاعدة البيانات.

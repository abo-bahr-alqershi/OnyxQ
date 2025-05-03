# علاقات موديول الحسابات والدفتر العام (Accounting & Journals)

| رقم العلاقة | الجدول المصدر | الجدول الهدف | نوع العلاقة | عمود المصدر | عمود الهدف | اسم قيد العلاقة | المجموعة الوظيفية | وصف العلاقة |
|-------------|--------------|--------------|-------------|-------------|------------|----------------|-------------------|--------------|
| 1 | ACCOUNT | ACCOUNT_GROUPING | n:1 | A_AG | AG_CODE | AC_ACGR_FK | الحسابات والدفتر العام | ربط الحساب بمجموعة الحسابات |
| 2 | ACCOUNT | ACCOUNT_TYPES | 1:n | A_AT | AT_CODE | AC_ACTY_FK | الحسابات والدفتر العام | ربط الحساب بنوع الحساب |
| 3 | DETAIL_JOURNAL | MASTER_JOURNAL | n:1 | DJ_MJ | MJ_CODE | DEJO_MAJO_FK | الحسابات والدفتر العام | ربط تفاصيل القيد بسند القيد |
| 4 | DETAIL_JOURNAL | ACCOUNT | n:1 | DJ_A | A_CODE | DEJO_AC_FK | الحسابات والدفتر العام | ربط تفاصيل القيد بالحساب |
| 28 | MASTER_JOURNAL | OPEN_BAL | n:1 | MJ_OB | OB_CODE | MAJO_OPBA_FK | الحسابات والدفتر العام | ربط master journal بـopen bal |
| 46 | IAS_CASH_OUTGOING | MASTER_JOURNAL | n:1 | ICO_MJ | MJ_CODE | IACAOU_MAJO_FK | النقدية والبنوك | ربط ias cash outgoing بـmaster journal |
| 50 | DETAIL_JOURNAL | MASTER_JOURNAL | n:1 | DJ_MJ | MJ_CODE | DEJO_MAJO_FK | الحسابات والدفتر العام | ربط تفاصيل القيد بسند القيد |
| 59 | ACCOUNT_REPORT_TYPE | ACCOUNT_GROUPING | n:1 | ART_AG | AG_CODE | ACRETY_ACGR_FK | الحسابات والدفتر العام | ربط account report type بـaccount grouping |
| 60 | MASTER_JOURNAL | ACCOUNT_GROUPING | n:1 | MJ_AG | AG_CODE | MAJO_ACGR_FK | الحسابات والدفتر العام | ربط master journal بـaccount grouping |
| 66 | MASTER_JOURNAL | ACCOUNT_GROUPING | n:1 | MJ_AG | AG_CODE | MAJO_ACGR_FK | الحسابات والدفتر العام | ربط master journal بـaccount grouping |
| 67 | OPEN_BAL | ACCOUNT_CURR | n:1 | OB_AC | AC_CODE | OPBA_ACCU_FK | الحسابات والدفتر العام | ربط open bal بـaccount curr |
| 68 | ACCOUNT | ACCOUNT_REPORT_TYPE | n:1 | A_ART | ART_CODE | AC_ACRETY_FK | الحسابات والدفتر العام | ربط account بـaccount report type |
| 81 | ACCOUNT_TYPES | MASTER_JOURNAL | n:1 | AT_MJ | MJ_CODE | ACTY_MAJO_FK | الحسابات والدفتر العام | ربط account types بـmaster journal |
| 87 | MASTER_JOURNAL | OPEN_BAL | 1:n | MJ_OB | OB_CODE | MAJO_OPBA_FK | الحسابات والدفتر العام | ربط master journal بـopen bal |
| 93 | OPEN_BAL | ACCOUNT | n:1 | OB_A | A_CODE | OPBA_AC_FK | الحسابات والدفتر العام | ربط open bal بـaccount |
| 98 | DETAIL_JOURNAL | MASTER_JOURNAL | n:1 | DJ_MJ | MJ_CODE | DEJO_MAJO_FK | الحسابات والدفتر العام | ربط تفاصيل القيد بسند القيد |
| 103 | OPEN_BAL | GLS_COST_CENTER_TRANS | 1:n | OB_GCCT | GCCT_CODE | OPBA_GLCOCETR_FK | الحسابات والدفتر العام | ربط open bal بـgls cost center trans |
| 108 | ACCOUNT_REPORT_TYPE | OPEN_BAL | 1:n | ART_OB | OB_CODE | ACRETY_OPBA_FK | الحسابات والدفتر العام | ربط account report type بـopen bal |
| 121 | ACCOUNT_CURR | DETAIL_JOURNAL | n:1 | AC_DJ | DJ_CODE | ACCU_DEJO_FK | الحسابات والدفتر العام | ربط account curr بـdetail journal |
| 133 | ACCOUNT | GLS_COST_CENTER_TRANS | n:1 | A_GCCT | GCCT_CODE | AC_GLCOCETR_FK | الحسابات والدفتر العام | ربط account بـgls cost center trans |
| 138 | IAS_CST_CLSS | ACCOUNT | n:1 | ICC_A | A_CODE | IACSCL_AC_FK | المبيعات والعملاء | ربط ias cst clss بـaccount |
| 147 | MASTER_JOURNAL | ACCOUNT_GROUPING | n:1 | MJ_AG | AG_CODE | MAJO_ACGR_FK | الحسابات والدفتر العام | ربط master journal بـaccount grouping |
| 151 | IAS_CST_CLSS | ACCOUNT | n:1 | ICC_A | A_CODE | IACSCL_AC_FK | المبيعات والعملاء | ربط ias cst clss بـaccount |
| 153 | ACCOUNT_CURR | ACCOUNT | n:1 | AC_A | A_CODE | ACCU_AC_FK | الحسابات والدفتر العام | ربط account curr بـaccount |
| 170 | GLS_COST_CENTER_TRANS | MASTER_JOURNAL | n:1 | GCCT_MJ | MJ_CODE | GLCOCETR_MAJO_FK | الحسابات والدفتر العام | ربط gls cost center trans بـmaster journal |
| 176 | ACCOUNT_CURR | MASTER_JOURNAL | n:1 | AC_MJ | MJ_CODE | ACCU_MAJO_FK | الحسابات والدفتر العام | ربط account curr بـmaster journal |
| 203 | ACCOUNT_GROUPING | ACCOUNT_REPORT_TYPE | n:1 | AG_ART | ART_CODE | ACGR_ACRETY_FK | الحسابات والدفتر العام | ربط account grouping بـaccount report type |
| 214 | IAS_CASH | MASTER_JOURNAL | n:1 | IC_MJ | MJ_CODE | IACA_MAJO_FK | النقدية والبنوك | ربط ias cash بـmaster journal |
| 231 | GLS_COST_CENTER_TRANS | S_EMP | n:1 | GCCT_EMP | EMP_CODE | GLCOCETR_SEM_FK | الحسابات والدفتر العام | ربط gls cost center trans بـs emp |

## علاقات الربط بين موديول الحسابات والدفتر العام وموديولات أخرى

| رقم العلاقة | الجدول المصدر | الجدول الهدف | نوع العلاقة | عمود المصدر | عمود الهدف | اسم قيد العلاقة | المجموعة الوظيفية | وصف العلاقة |
|-------------|--------------|--------------|-------------|-------------|------------|----------------|-------------------|--------------|
| 46 | IAS_CASH_OUTGOING | MASTER_JOURNAL | n:1 | ICO_MJ | MJ_CODE | IACAOU_MAJO_FK | النقدية والبنوك | ربط ias cash outgoing بـmaster journal |
| 214 | IAS_CASH | MASTER_JOURNAL | n:1 | IC_MJ | MJ_CODE | IACA_MAJO_FK | النقدية والبنوك | ربط ias cash بـmaster journal |
| 355 | BANK_CHEQUE | MASTER_JOURNAL | n:1 | BC_MJ | MJ_CODE | BACH_MAJO_FK | النقدية والبنوك | ربط bank cheque بـmaster journal |
| 404 | IAS_BANK | MASTER_JOURNAL | n:1 | IB_MJ | MJ_CODE | IABA_MAJO_FK | النقدية والبنوك | ربط ias bank بـmaster journal |
| 648 | DETAIL_JOURNAL | VENDOR | n:1 | DJ_VNDR | VNDR_CODE | DEJO_VE_FK | الحسابات والدفتر العام | ربط detail journal بـvendor |
| 657 | DETAIL_JOURNAL | IAS_CURRENCY | n:1 | DJ_CY | CY_CODE | DEJO_IACU_FK | الحسابات والدفتر العام | ربط detail journal بـias currency |
| 860 | IAS_CASH_INCOME | COST_CENTERS | n:1 | ICI_CC | CC_CODE | IACAIN_COCE_FK | النقدية والبنوك | ربط ias cash income بـcost centers |

# علاقات موديول النقدية والبنوك والخزائن (Cash & Banks & Safes)

| رقم العلاقة | الجدول المصدر | الجدول الهدف | نوع العلاقة | عمود المصدر | عمود الهدف | اسم قيد العلاقة | المجموعة الوظيفية | وصف العلاقة |
|-------------|--------------|--------------|-------------|-------------|------------|----------------|-------------------|--------------|
| 5 | CASH_RECEIPT | CUSTOMER | n:1 | CR_CST | CST_CODE | CARE_CU_FK | النقدية والبنوك | ربط سند القبض بالعميل |
| 6 | CASH_PAYMENT | VENDOR | n:1 | CP_VNDR | VNDR_CODE | CAPA_VE_FK | النقدية والبنوك | ربط سند الصرف بالمورد |
| 18 | BANK_CHEQUE | IAS_CASH_OUTGOING | n:1 | BC_ICO | ICO_CODE | BACH_IACAOU_FK | النقدية والبنوك | ربط شيك البنك بسند الصرف النقدي |
| 37 | BANK_CHEQUE | IAS_CASH_OUTGOING | 1:n | BC_ICO | ICO_CODE | BACH_IACAOU_FK | النقدية والبنوك | ربط bank cheque بـias cash outgoing |
| 46 | IAS_CASH_OUTGOING | MASTER_JOURNAL | n:1 | ICO_MJ | MJ_CODE | IACAOU_MAJO_FK | النقدية والبنوك | ربط ias cash outgoing بـmaster journal |
| 48 | CASH_RECEIPT | ITEM_CARD | n:1 | CR_ITM | ITM_CODE | CARE_ITCA_FK | النقدية والبنوك | ربط cash receipt بـitem card |
| 64 | IAS_CASH | VENDOR | n:1 | IC_VNDR | VNDR_CODE | IACA_VE_FK | النقدية والبنوك | ربط ias cash بـvendor |
| 86 | CASH_RECEIPT | IAS_ACTVTY | n:1 | CR_ACTVTY | ACTVTY_CODE | CARE_IAAC_FK | النقدية والبنوك | ربط cash receipt بـias actvty |
| 97 | IAS_BANK | IAS_BANK_ACCOUNT | n:1 | IB_IBA | IBA_CODE | IABA_IABAAC_FK | النقدية والبنوك | ربط ias bank بـias bank account |
| 109 | IAS_CASH | IAS_CASH_INCOME | n:m | IC_ICI | ICI_CODE | IACA_IACAIN_FK | النقدية والبنوك | ربط ias cash بـias cash income |
| 116 | IAS_BANK | CASH_RECEIPT | 1:n | IB_CR | CR_CODE | IABA_CARE_FK | النقدية والبنوك | ربط ias bank بـcash receipt |
| 161 | CASH_RECEIPT | IAS_BANK_ACCOUNT | n:1 | CR_IBA | IBA_CODE | CARE_IABAAC_FK | النقدية والبنوك | ربط cash receipt بـias bank account |
| 163 | CASH_PAYMENT | CUSTOMER | n:1 | CP_CST | CST_CODE | CAPA_CU_FK | النقدية والبنوك | ربط cash payment بـcustomer |
| 186 | CASH_PAYMENT | IAS_CASH_INCOME | n:1 | CP_ICI | ICI_CODE | CAPA_IACAIN_FK | النقدية والبنوك | ربط cash payment بـias cash income |
| 204 | CASH_RECEIPT | IAS_BANK_ACCOUNT | n:1 | CR_IBA | IBA_CODE | CARE_IABAAC_FK | النقدية والبنوك | ربط cash receipt بـias bank account |
| 205 | CASH_RECEIPT | CASH_PAYMENT | n:1 | CR_CP | CP_CODE | CARE_CAPA_FK | النقدية والبنوك | ربط cash receipt بـcash payment |
| 206 | IAS_CASH | IAS_ACTVTY | n:1 | IC_ACTVTY | ACTVTY_CODE | IACA_IAAC_FK | النقدية والبنوك | ربط ias cash بـias actvty |
| 680 | CASH_RECEIPT | CASH_PAYMENT | 1:n | CR_CP | CP_CODE | CARE_CAPA_FK | النقدية والبنوك | ربط cash receipt بـcash payment |
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

## علاقات الربط بين موديول النقدية والبنوك والخزائن وموديولات أخرى

| رقم العلاقة | الجدول المصدر | الجدول الهدف | نوع العلاقة | عمود المصدر | عمود الهدف | اسم قيد العلاقة | المجموعة الوظيفية | وصف العلاقة |
|-------------|--------------|--------------|-------------|-------------|------------|----------------|-------------------|--------------|
| 46 | IAS_CASH_OUTGOING | MASTER_JOURNAL | n:1 | ICO_MJ | MJ_CODE | IACAOU_MAJO_FK | النقدية والبنوك | ربط ias cash outgoing بـmaster journal |
| 214 | IAS_CASH | MASTER_JOURNAL | n:1 | IC_MJ | MJ_CODE | IACA_MAJO_FK | النقدية والبنوك | ربط ias cash بـmaster journal |
| 355 | BANK_CHEQUE | MASTER_JOURNAL | n:1 | BC_MJ | MJ_CODE | BACH_MAJO_FK | النقدية والبنوك | ربط bank cheque بـmaster journal |
| 404 | IAS_BANK | MASTER_JOURNAL | n:1 | IB_MJ | MJ_CODE | IABA_MAJO_FK | النقدية والبنوك | ربط ias bank بـmaster journal |
| 5 | CASH_RECEIPT | CUSTOMER | n:1 | CR_CST | CST_CODE | CARE_CU_FK | النقدية والبنوك | ربط سند القبض بالعميل |
| 6 | CASH_PAYMENT | VENDOR | n:1 | CP_VNDR | VNDR_CODE | CAPA_VE_FK | النقدية والبنوك | ربط سند الصرف بالمورد |
| 48 | CASH_RECEIPT | ITEM_CARD | n:1 | CR_ITM | ITM_CODE | CARE_ITCA_FK | النقدية والبنوك | ربط cash receipt بـitem card |
| 64 | IAS_CASH | VENDOR | n:1 | IC_VNDR | VNDR_CODE | IACA_VE_FK | النقدية والبنوك | ربط ias cash بـvendor |
| 86 | CASH_RECEIPT | IAS_ACTVTY | n:1 | CR_ACTVTY | ACTVTY_CODE | CARE_IAAC_FK | النقدية والبنوك | ربط cash receipt بـias actvty |
| 163 | CASH_PAYMENT | CUSTOMER | n:1 | CP_CST | CST_CODE | CAPA_CU_FK | النقدية والبنوك | ربط cash payment بـcustomer |
| 206 | IAS_CASH | IAS_ACTVTY | n:1 | IC_ACTVTY | ACTVTY_CODE | IACA_IAAC_FK | النقدية والبنوك | ربط ias cash بـias actvty |
| 369 | IAS_CASH | CUSTOMER | n:1 | IC_CST | CST_CODE | IACA_CU_FK | النقدية والبنوك | ربط ias cash بـcustomer |
| 467 | IAS_CASH_INCOME | IAS_ACTVTY | n:1 | ICI_ACTVTY | ACTVTY_CODE | IACAIN_IAAC_FK | النقدية والبنوك | ربط ias cash income بـias actvty |
| 596 | IAS_BANK | CUSTOMER | n:1 | IB_CST | CST_CODE | IABA_CU_FK | النقدية والبنوك | ربط ias bank بـcustomer |
| 725 | IAS_CASH_OUTGOING | IAS_USR | n:1 | ICO_IU | IU_CODE | IACAOU_IAUS_FK | النقدية والبنوك | ربط ias cash outgoing بـias usr |
| 747 | IAS_CASH | ITEM_CARD | n:1 | IC_ITM | ITM_CODE | IACA_ITCA_FK | النقدية والبنوك | ربط ias cash بـitem card |
| 860 | IAS_CASH_INCOME | COST_CENTERS | n:1 | ICI_CC | CC_CODE | IACAIN_COCE_FK | النقدية والبنوك | ربط ias cash income بـcost centers |
| 901 | CASH_RECEIPT | IAS_CURRENCY | n:1 | CR_CY | CY_CODE | CARE_IACU_FK | النقدية والبنوك | ربط cash receipt بـias currency |
| 933 | CASH_PAYMENT | ITEM_CARD | n:1 | CP_ITM | ITM_CODE | CAPA_ITCA_FK | النقدية والبنوك | ربط cash payment بـitem card |
| 1092 | IAS_BANK | IAS_USR | n:1 | IB_IU | IU_CODE | IABA_IAUS_FK | النقدية والبنوك | ربط ias bank بـias usr |

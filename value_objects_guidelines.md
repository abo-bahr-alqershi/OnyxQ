# قواعد التنفيذ الآلي لاستخراج Value Objects في موديلات النطاق (Domain Models)

## أنماط Value Objects الرئيسية وخصائصها

### ContactInfo
**الكلمات المفتاحية:** PHONE, MOBILE, EMAIL, E_MAIL, FAX, WEB_SITE, WEBSITE, CONTACT, HOTLINE, TEL
**الحد الأدنى للتطابق:** 2 خصائص

**أمثلة من الكيانات:**
- **Branch**: BranchFaxArabic, BranchTelephoneArabic, BranchFaxEnglish, BranchTelephoneEnglish, BranchFaxFull, BranchTelephoneFull, BranchFaxLast, BranchTelephoneLast, BranchTelephoneNumber

### Address
**الكلمات المفتاحية:** ADDRESS, CITY, COUNTRY, PROVINCE, REGION, BOX, POSTAL, BUILDING, STREET, ZIP
**الحد الأدنى للتطابق:** 2 خصائص

**أمثلة من الكيانات:**
- **Branch**: BranchBoxArabic, BranchBoxEnglish, BranchBoxFull, BranchBoxLast

### PersonInfo
**الكلمات المفتاحية:** F_NM, L_NM, FIRST_NAME, LAST_NAME, BIRTH, NATIONALITY, PERSON, NAME, SEX, GENDER
**الحد الأدنى للتطابق:** 2 خصائص

**أمثلة من الكيانات:**
- **Branch**: BranchFirstName, BranchLastName
- **User**: UserArabicName, UserEnglishName
- **Account**: AccountNameEnglish, AccountName, AccountDetailFullName, AccountDetailLastName

### IdentityInfo
**الكلمات المفتاحية:** ID, PASSPORT, NATIONAL, IDENT, CARD, LICENSE, ISSUE_DATE, EXPIRE, SERIAL
**الحد الأدنى للتطابق:** 2 خصائص

**أمثلة من الكيانات:**
- **User**: UserFingerId, UserId

### Money
**الكلمات المفتاحية:** AMT, AMOUNT, CURRENCY, RATE, PRICE, COST, DISCOUNT, VAT, TAX
**الحد الأدنى للتطابق:** 2 خصائص

**أمثلة من الكيانات:**
- **Account**: AccountAmount, AccountAmountForeign, AccountRate
- **Note**: NoteAmount, NoteAmountForeign, NoteRate

### DateRange
**الكلمات المفتاحية:** FROM_DATE, TO_DATE, START_DATE, END_DATE, PERIOD, DURATION, STRT_DATE, END_DATE
**الحد الأدنى للتطابق:** 2 خصائص

### Dimension
**الكلمات المفتاحية:** WIDTH, HEIGHT, LENGTH, SIZE, WEIGHT, VOLUME, METER, DIMENSION
**الحد الأدنى للتطابق:** 2 خصائص

### BankInfo
**الكلمات المفتاحية:** BANK, ACCOUNT, IBAN, SWIFT, BRANCH, BNK, ACCNT
**الحد الأدنى للتطابق:** 2 خصائص

**أمثلة من الكيانات:**
- **Account**: AccountSub, AccountType, AccountBankCode

### Location
**الكلمات المفتاحية:** LAT, LONG, LATITUDE, LONGITUDE, COORDINATES, GPS, LOCATION, MAP
**الحد الأدنى للتطابق:** 2 خصائص

### AuditInfo
**الكلمات المفتاحية:** CREATED, MODIFIED, UPDATED, USER_ID, TERMINAL, ACTIVE_DATE, AUDIT
**الحد الأدنى للتطابق:** 2 خصائص
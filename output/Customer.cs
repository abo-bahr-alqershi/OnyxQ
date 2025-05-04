using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Sales & Customers.Events;
using ERP_Pro.Domain.ERP.Sales & Customers.ValueObjects;

namespace ERP_Pro.Domain.ERP.Sales & Customers.Entities
{
    /// <summary>
    /// Customer Entity
    /// </summary>
    public class Customer : Entity<CustomerId>
    {
        #region Properties
        
        // Original properties and their value objects
    // Original property (keeps for backward compatibility)
    public int UseBankDepositAccountIntermediate { get; private set; } /*! UseBankDepositAccountIntermediate */
    // Original property (keeps for backward compatibility)
    public int AccountBankCode { get; private set; } /*! AccountBankCode */
    // Original property (keeps for backward compatibility)
    public int BankAccountCode { get; private set; } /*! BankAccountCode */
    // Original property (keeps for backward compatibility)
    public int BankAccountType { get; private set; } /*! BankAccountType */
    // Value object
    public BankInfo BankInfo =>
        BankInfo.Create(UseBankDepositAccountIntermediate , AccountBankCode , BankAccountCode , BankAccountType );
    // Original property (keeps for backward compatibility)
    public decimal UseCalculateColumnAmount { get; private set; } /*! UseCalculateColumnAmount */
    // Original property (keeps for backward compatibility)
    public decimal UseCalculateCommissionLevelPriceFlag { get; private set; } /*! UseCalculateCommissionLevelPriceFlag */
    // Original property (keeps for backward compatibility)
    public int UseCalculateTaxFreeQuantity { get; private set; } /*! UseCalculateTaxFreeQuantity */
    // Original property (keeps for backward compatibility)
    public int UsePurchaseInvoiceCalculateTaxFreeQuantity { get; private set; } /*! UsePurchaseInvoiceCalculateTaxFreeQuantity */
    // Original property (keeps for backward compatibility)
    public decimal UsePriceWarehouseTransferReceiveCost { get; private set; } /*! UsePriceWarehouseTransferReceiveCost */
    // Original property (keeps for backward compatibility)
    public int VatAmountDiscountMaster { get; private set; } /*! VatAmountDiscountMaster */
    // Original property (keeps for backward compatibility)
    public int WeightCalculateQuantityByIncludePrice { get; private set; } /*! WeightCalculateQuantityByIncludePrice */
    // Original property (keeps for backward compatibility)
    public decimal WeightPriceForceLength { get; private set; } /*! WeightPriceForceLength */
    // Original property (keeps for backward compatibility)
    public decimal SaleRateForeignIncomeDegree { get; private set; } /*! SaleRateForeignIncomeDegree */
    // Original property (keeps for backward compatibility)
    public decimal SocialClassNoPanAmount { get; private set; } /*! SocialClassNoPanAmount */
    // Original property (keeps for backward compatibility)
    public decimal SocialClassPanAmount { get; private set; } /*! SocialClassPanAmount */
    // Original property (keeps for backward compatibility)
    public int ServiceAccountRate { get; private set; } /*! ServiceAccountRate */
    // Original property (keeps for backward compatibility)
    public decimal ServiceAmount { get; private set; } /*! ServiceAmount */
    // Original property (keeps for backward compatibility)
    public int ShowStockCostInQuantityDiscountFreeQuantity { get; private set; } /*! ShowStockCostInQuantityDiscountFreeQuantity */
    // Original property (keeps for backward compatibility)
    public int ShowAmountQuantityStaticArabicReport { get; private set; } /*! ShowAmountQuantityStaticArabicReport */
    // Original property (keeps for backward compatibility)
    public decimal LoadAmountLocalLimit { get; private set; } /*! LoadAmountLocalLimit */
    // Original property (keeps for backward compatibility)
    public string MethodVatCalculationItemUsed { get; private set; } /*! MethodVatCalculationItemUsed */
    // Original property (keeps for backward compatibility)
    public decimal NetIncomeAmount { get; private set; } /*! NetIncomeAmount */
    // Original property (keeps for backward compatibility)
    public int AccountCurrencyAmount { get; private set; } /*! AccountCurrencyAmount */
    // Original property (keeps for backward compatibility)
    public int AccountInvoiceCurrencyAmount { get; private set; } /*! AccountInvoiceCurrencyAmount */
    // Original property (keeps for backward compatibility)
    public int AccountAmount { get; private set; } /*! AccountAmount */
    // Original property (keeps for backward compatibility)
    public int AccountAmountForeign { get; private set; } /*! AccountAmountForeign */
    // Original property (keeps for backward compatibility)
    public int AccountRate { get; private set; } /*! AccountRate */
    // Original property (keeps for backward compatibility)
    public int AdditionalDiscountAmountDetail { get; private set; } /*! AdditionalDiscountAmountDetail */
    // Original property (keeps for backward compatibility)
    public int AdditionalDiscountAmountMaster { get; private set; } /*! AdditionalDiscountAmountMaster */
    // Original property (keeps for backward compatibility)
    public int AdditionalDiscountAmountMasterPrevious { get; private set; } /*! AdditionalDiscountAmountMasterPrevious */
    // Original property (keeps for backward compatibility)
    public decimal AllowChangeDeliveryServiceAmount { get; private set; } /*! AllowChangeDeliveryServiceAmount */
    // Original property (keeps for backward compatibility)
    public int AmountForeignDiscountMovement { get; private set; } /*! AmountForeignDiscountMovement */
    // Original property (keeps for backward compatibility)
    public int AmountLocalDiscountMovement { get; private set; } /*! AmountLocalDiscountMovement */
    // Original property (keeps for backward compatibility)
    public int AccountsPayableItemChargeCalculationAmountType { get; private set; } /*! AccountsPayableItemChargeCalculationAmountType */
    // Original property (keeps for backward compatibility)
    public decimal CalcInsuranceLoadAmountMethod { get; private set; } /*! CalcInsuranceLoadAmountMethod */
    // Original property (keeps for backward compatibility)
    public string CalcTaxAdvancePayment { get; private set; } /*! CalcTaxAdvancePayment */
    // Original property (keeps for backward compatibility)
    public int CalcTaxDiscount2 { get; private set; } /*! CalcTaxDiscount2 */
    // Original property (keeps for backward compatibility)
    public int CalcTaxDiscount3 { get; private set; } /*! CalcTaxDiscount3 */
    // Original property (keeps for backward compatibility)
    public int CalcTaxFreeQuantityFlag { get; private set; } /*! CalcTaxFreeQuantityFlag */
    // Original property (keeps for backward compatibility)
    public bool CalcTaxInsuranceCompanyFlag { get; private set; } /*! CalcTaxInsuranceCompanyFlag */
    // Original property (keeps for backward compatibility)
    public string CalcTaxType { get; private set; } /*! CalcTaxType */
    // Original property (keeps for backward compatibility)
    public int CalcTypeNumberTax { get; private set; } /*! CalcTypeNumberTax */
    // Original property (keeps for backward compatibility)
    public decimal CalcVatPriceType { get; private set; } /*! CalcVatPriceType */
    // Original property (keeps for backward compatibility)
    public decimal IncomeAmount { get; private set; } /*! IncomeAmount */
    // Original property (keeps for backward compatibility)
    public decimal IncomeCost { get; private set; } /*! IncomeCost */
    // Original property (keeps for backward compatibility)
    public decimal IncomeNetAmount { get; private set; } /*! IncomeNetAmount */
    // Original property (keeps for backward compatibility)
    public decimal InsuranceLimitAmountLocalDocument { get; private set; } /*! InsuranceLimitAmountLocalDocument */
    // Original property (keeps for backward compatibility)
    public int ItemDiscountAmount { get; private set; } /*! ItemDiscountAmount */
    // Original property (keeps for backward compatibility)
    public decimal ItemLastIncomePrice { get; private set; } /*! ItemLastIncomePrice */
    // Original property (keeps for backward compatibility)
    public decimal LetterCreditAmount { get; private set; } /*! LetterCreditAmount */
    // Original property (keeps for backward compatibility)
    public int LetterCreditCostTypeNumber { get; private set; } /*! LetterCreditCostTypeNumber */
    // Original property (keeps for backward compatibility)
    public decimal LetterCreditCreditAmount { get; private set; } /*! LetterCreditCreditAmount */
    // Original property (keeps for backward compatibility)
    public decimal LetterCreditExpenseAmount { get; private set; } /*! LetterCreditExpenseAmount */
    // Original property (keeps for backward compatibility)
    public decimal LetterCreditExpenseAmountForeign { get; private set; } /*! LetterCreditExpenseAmountForeign */
    // Original property (keeps for backward compatibility)
    public decimal LetterCreditExpenseRate { get; private set; } /*! LetterCreditExpenseRate */
    // Original property (keeps for backward compatibility)
    public decimal LetterCreditOpenAmount { get; private set; } /*! LetterCreditOpenAmount */
    // Original property (keeps for backward compatibility)
    public decimal LetterCreditRate { get; private set; } /*! LetterCreditRate */
    // Original property (keeps for backward compatibility)
    public decimal LetterCreditRotateAmount { get; private set; } /*! LetterCreditRotateAmount */
    // Original property (keeps for backward compatibility)
    public decimal LimitAmountLocalChronicDocument { get; private set; } /*! LimitAmountLocalChronicDocument */
    // Original property (keeps for backward compatibility)
    public decimal LimitAmountLocalNetDocument { get; private set; } /*! LimitAmountLocalNetDocument */
    // Original property (keeps for backward compatibility)
    public decimal LimitAmountLocalOutNetDocument { get; private set; } /*! LimitAmountLocalOutNetDocument */
    // Original property (keeps for backward compatibility)
    public decimal LimitAmountNetLocalYear { get; private set; } /*! LimitAmountNetLocalYear */
    // Original property (keeps for backward compatibility)
    public int BillAccountAmount { get; private set; } /*! BillAccountAmount */
    // Original property (keeps for backward compatibility)
    public decimal BalanceAmount { get; private set; } /*! BalanceAmount */
    // Original property (keeps for backward compatibility)
    public decimal BalanceAmountManual { get; private set; } /*! BalanceAmountManual */
    // Original property (keeps for backward compatibility)
    public decimal CalculateMeasurePrice { get; private set; } /*! CalculateMeasurePrice */
    // Original property (keeps for backward compatibility)
    public decimal CalculateVatAmountType { get; private set; } /*! CalculateVatAmountType */
    // Original property (keeps for backward compatibility)
    public int CalculateVatAmountTypeAccountsPayable { get; private set; } /*! CalculateVatAmountTypeAccountsPayable */
    // Original property (keeps for backward compatibility)
    public int CheckLimitPriceMinusDiscountSalesInvoice { get; private set; } /*! CheckLimitPriceMinusDiscountSalesInvoice */
    // Original property (keeps for backward compatibility)
    public decimal PointAmountCalculationType { get; private set; } /*! PointAmountCalculationType */
    // Original property (keeps for backward compatibility)
    public decimal PointReplaceAmount { get; private set; } /*! PointReplaceAmount */
    // Original property (keeps for backward compatibility)
    public int PostTaxDueAccountCode { get; private set; } /*! PostTaxDueAccountCode */
    // Original property (keeps for backward compatibility)
    public decimal PriceIncludeVatServiceItem { get; private set; } /*! PriceIncludeVatServiceItem */
    // Original property (keeps for backward compatibility)
    public int ForceDifferenceDiscountAfterVatAccount { get; private set; } /*! ForceDifferenceDiscountAfterVatAccount */
    // Original property (keeps for backward compatibility)
    public decimal SourceIncomeRate { get; private set; } /*! SourceIncomeRate */
    // Original property (keeps for backward compatibility)
    public int StockAccountRate { get; private set; } /*! StockAccountRate */
    // Original property (keeps for backward compatibility)
    public decimal TotalNetIncomeAmount { get; private set; } /*! TotalNetIncomeAmount */
    // Original property (keeps for backward compatibility)
    public decimal TransactionNotReceivedAmount { get; private set; } /*! TransactionNotReceivedAmount */
    // Value object
    public Money Money =>
        Money.Create(UseCalculateColumnAmount , UseCalculateCommissionLevelPriceFlag , UseCalculateTaxFreeQuantity , UsePurchaseInvoiceCalculateTaxFreeQuantity , UsePriceWarehouseTransferReceiveCost , VatAmountDiscountMaster , WeightCalculateQuantityByIncludePrice , WeightPriceForceLength , SaleRateForeignIncomeDegree , SocialClassNoPanAmount , SocialClassPanAmount , ServiceAccountRate , ServiceAmount , ShowStockCostInQuantityDiscountFreeQuantity , ShowAmountQuantityStaticArabicReport , LoadAmountLocalLimit , MethodVatCalculationItemUsed , NetIncomeAmount , AccountCurrencyAmount , AccountInvoiceCurrencyAmount , AccountAmount , AccountAmountForeign , AccountRate , AdditionalDiscountAmountDetail , AdditionalDiscountAmountMaster , AdditionalDiscountAmountMasterPrevious , AllowChangeDeliveryServiceAmount , AmountForeignDiscountMovement , AmountLocalDiscountMovement , AccountsPayableItemChargeCalculationAmountType , CalcInsuranceLoadAmountMethod , CalcTaxAdvancePayment , CalcTaxDiscount2 , CalcTaxDiscount3 , CalcTaxFreeQuantityFlag , CalcTaxInsuranceCompanyFlag , CalcTaxType , CalcTypeNumberTax , CalcVatPriceType , IncomeAmount , IncomeCost , IncomeNetAmount , InsuranceLimitAmountLocalDocument , ItemDiscountAmount , ItemLastIncomePrice , LetterCreditAmount , LetterCreditCostTypeNumber , LetterCreditCreditAmount , LetterCreditExpenseAmount , LetterCreditExpenseAmountForeign , LetterCreditExpenseRate , LetterCreditOpenAmount , LetterCreditRate , LetterCreditRotateAmount , LimitAmountLocalChronicDocument , LimitAmountLocalNetDocument , LimitAmountLocalOutNetDocument , LimitAmountNetLocalYear , BillAccountAmount , BalanceAmount , BalanceAmountManual , CalculateMeasurePrice , CalculateVatAmountType , CalculateVatAmountTypeAccountsPayable , CheckLimitPriceMinusDiscountSalesInvoice , PointAmountCalculationType , PointReplaceAmount , PostTaxDueAccountCode , PriceIncludeVatServiceItem , ForceDifferenceDiscountAfterVatAccount , SourceIncomeRate , StockAccountRate , TotalNetIncomeAmount , TransactionNotReceivedAmount );
    // Original property (keeps for backward compatibility)
    public int UseDiscountCardSale { get; private set; } /*! UseDiscountCardSale */
    // Original property (keeps for backward compatibility)
    public int WebServiceUuid { get; private set; } /*! WebServiceUuid */
    // Original property (keeps for backward compatibility)
    public int ReceiveInvoiceUserId { get; private set; } /*! ReceiveInvoiceUserId */
    // Original property (keeps for backward compatibility)
    public int NotAllowDeleteDocumentConnectedSerialNumber { get; private set; } /*! NotAllowDeleteDocumentConnectedSerialNumber */
    // Original property (keeps for backward compatibility)
    public int PaidDocumentNumber { get; private set; } /*! PaidDocumentNumber */
    // Original property (keeps for backward compatibility)
    public int PaidDocumentSerial { get; private set; } /*! PaidDocumentSerial */
    // Original property (keeps for backward compatibility)
    public int PaidDocumentType { get; private set; } /*! PaidDocumentType */
    // Original property (keeps for backward compatibility)
    public int ApprovalReceivedUserId { get; private set; } /*! ApprovalReceivedUserId */
    // Original property (keeps for backward compatibility)
    public int AccountsReceivableAdditionalDiscountSerial { get; private set; } /*! AccountsReceivableAdditionalDiscountSerial */
    // Original property (keeps for backward compatibility)
    public string ArReceiptDocumentSerial { get; private set; } /*! ArReceiptDocumentSerial */
    // Original property (keeps for backward compatibility)
    public int ArRequestAdditionalDiscountSerial { get; private set; } /*! ArRequestAdditionalDiscountSerial */
    // Original property (keeps for backward compatibility)
    public int CalcPaidMethod { get; private set; } /*! CalcPaidMethod */
    // Original property (keeps for backward compatibility)
    public int CreditCardDocumentNumberReference { get; private set; } /*! CreditCardDocumentNumberReference */
    // Original property (keeps for backward compatibility)
    public int CreditCardDocumentNumberReferenceSecond { get; private set; } /*! CreditCardDocumentNumberReferenceSecond */
    // Original property (keeps for backward compatibility)
    public int CreditCardDocumentNumberReferenceThird { get; private set; } /*! CreditCardDocumentNumberReferenceThird */
    // Original property (keeps for backward compatibility)
    public string CreditCardDescriptionSecond { get; private set; } /*! CreditCardDescriptionSecond */
    // Original property (keeps for backward compatibility)
    public string CreditCardDescriptionThird { get; private set; } /*! CreditCardDescriptionThird */
    // Original property (keeps for backward compatibility)
    public int CalculateAllSlides { get; private set; } /*! CalculateAllSlides */
    // Original property (keeps for backward compatibility)
    public string CardSecondAddress { get; private set; } /*! CardSecondAddress */
    // Original property (keeps for backward compatibility)
    public int SalesInvoiceHideDiscountPercent { get; private set; } /*! SalesInvoiceHideDiscountPercent */
    // Value object
    public IdentityInfo IdentityInfo =>
        IdentityInfo.Create(UseDiscountCardSale , WebServiceUuid , ReceiveInvoiceUserId , NotAllowDeleteDocumentConnectedSerialNumber , PaidDocumentNumber , PaidDocumentSerial , PaidDocumentType , ApprovalReceivedUserId , AccountsReceivableAdditionalDiscountSerial , ArReceiptDocumentSerial , ArRequestAdditionalDiscountSerial , CalcPaidMethod , CreditCardDocumentNumberReference , CreditCardDocumentNumberReferenceSecond , CreditCardDocumentNumberReferenceThird , CreditCardDescriptionSecond , CreditCardDescriptionThird , CalculateAllSlides , CardSecondAddress , SalesInvoiceHideDiscountPercent );
    // Original property (keeps for backward compatibility)
    public string ReceiverName { get; private set; } /*! ReceiverName */
    // Original property (keeps for backward compatibility)
    public string ServiceName { get; private set; } /*! ServiceName */
    // Original property (keeps for backward compatibility)
    public string LocationFirstName { get; private set; } /*! LocationFirstName */
    // Original property (keeps for backward compatibility)
    public string LocationLastName { get; private set; } /*! LocationLastName */
    // Original property (keeps for backward compatibility)
    public int AccountDetailFullName { get; private set; } /*! AccountDetailFullName */
    // Original property (keeps for backward compatibility)
    public int AccountDetailLastName { get; private set; } /*! AccountDetailLastName */
    // Original property (keeps for backward compatibility)
    public string CalcTypeFirstName { get; private set; } /*! CalcTypeFirstName */
    // Original property (keeps for backward compatibility)
    public string CalcTypeLastName { get; private set; } /*! CalcTypeLastName */
    // Original property (keeps for backward compatibility)
    public string AttachmentDescriptionNameArabic { get; private set; } /*! AttachmentDescriptionNameArabic */
    // Original property (keeps for backward compatibility)
    public bool AttachmentDescriptionNameEnglish { get; private set; } /*! AttachmentDescriptionNameEnglish */
    // Original property (keeps for backward compatibility)
    public string BatchDescriptionNameArabic { get; private set; } /*! BatchDescriptionNameArabic */
    // Original property (keeps for backward compatibility)
    public bool BatchDescriptionNameEnglish { get; private set; } /*! BatchDescriptionNameEnglish */
    // Original property (keeps for backward compatibility)
    public decimal CostCenterNameArabic { get; private set; } /*! CostCenterNameArabic */
    // Original property (keeps for backward compatibility)
    public decimal CostCenterNameEnglish { get; private set; } /*! CostCenterNameEnglish */
    // Original property (keeps for backward compatibility)
    public decimal CostCenterName { get; private set; } /*! CostCenterName */
    // Original property (keeps for backward compatibility)
    public string SubFirstName { get; private set; } /*! SubCustomerFirstName */
    // Original property (keeps for backward compatibility)
    public string SubLastName { get; private set; } /*! SubCustomerLastName */
    // Value object
    public PersonInfo PersonInfo =>
        PersonInfo.Create(ReceiverName , ServiceName , LocationFirstName , LocationLastName , AccountDetailFullName , AccountDetailLastName , CalcTypeFirstName , CalcTypeLastName , AttachmentDescriptionNameArabic , AttachmentDescriptionNameEnglish , BatchDescriptionNameArabic , BatchDescriptionNameEnglish , CostCenterNameArabic , CostCenterNameEnglish , CostCenterName , SubCustomerFirstName , SubCustomerLastName );
    // Original property (keeps for backward compatibility)
    public int SalesDiscountPeriodic { get; private set; } /*! SalesDiscountPeriodic */
    // Original property (keeps for backward compatibility)
    public int HolidayCalculationStartDate { get; private set; } /*! HolidayCalculationStartDate */
    // Value object
    public DateRange DateRange =>
        DateRange.Create(SalesDiscountPeriodic , HolidayCalculationStartDate );
    // Original property (keeps for backward compatibility)
    public string MobileAttendanceSync { get; private set; } /*! MobileAttendanceSync */
    // Original property (keeps for backward compatibility)
    public string AttendanceMobileSerial { get; private set; } /*! AttendanceMobileSerial */
    // Original property (keeps for backward compatibility)
    public string AttendanceMobileType { get; private set; } /*! AttendanceMobileType */
    // Original property (keeps for backward compatibility)
    public string CardSecondEmail { get; private set; } /*! CardSecondEmail */
    // Original property (keeps for backward compatibility)
    public string CardSecondTelephone { get; private set; } /*! CardSecondTelephone */
    // Value object
    public ContactInfo ContactInfo =>
        ContactInfo.Create(MobileAttendanceSync , AttendanceMobileSerial , AttendanceMobileType , CardSecondEmail , CardSecondTelephone );

        #endregion

        #region Constructors
        
        private Customer()
        {
            // Required by EF Core
        }
        
        public Customer(
            CustomerId id
            // Add required parameters
        )
        {
            Id = id;
            // Initialize properties
        }
        
        #endregion

        #region Domain Methods
        
        // Event methods
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إنشاء كيان جديد
    /// </summary>
    public void Create()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerCreatedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند تحديث بيانات الكيان
    /// </summary>
    public void Updat()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerUpdatedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند حذف الكيان (منطقي أو فعلي)
    /// </summary>
    public void Delet()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerDeletedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند أرشفة الكيان
    /// </summary>
    public void Archiv()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerArchivedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند تغيير حالة الكيان الرئيسية
    /// </summary>
    public void StatusChang(string newStatus)
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerStatusChangedEvent(Id, Status, newStatus));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند تفعيل الكيان
    /// </summary>
    public void Activat(string newStatus)
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerActivatedEvent(Id, Status, newStatus));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إلغاء تفعيل الكيان
    /// </summary>
    public void Deactivat(string newStatus)
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerDeactivatedEvent(Id, Status, newStatus));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند قفل الكيان
    /// </summary>
    public void Lock()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerLockedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إلغاء قفل الكيان
    /// </summary>
    public void Unlock()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerUnlockedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند استلام دفعة
    /// </summary>
    public void PaymentReceiv()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerPaymentReceivedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إصدار دفعة
    /// </summary>
    public void PaymentIssu()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerPaymentIssuedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إصدار فاتورة
    /// </summary>
    public void InvoiceIssu()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerInvoiceIssuedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند تغير الرصيد
    /// </summary>
    public void BalanceChang(decimal newValue, string reason = null)
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerBalanceChangedEvent(Id, newValue, reason ?? "System update"));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند تغيير حد الائتمان
    /// </summary>
    public void CreditLimitChang(decimal newValue, string reason = null)
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerCreditLimitChangedEvent(Id, newValue, reason ?? "System update"));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند احتساب الضريبة
    /// </summary>
    public void TaxCalculat()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerTaxCalculatedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إنشاء طلب
    /// </summary>
    public void OrderPlac()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerOrderPlacedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند تأكيد طلب
    /// </summary>
    public void OrderConfirm()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerOrderConfirmedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند شحن طلب
    /// </summary>
    public void OrderShipp()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerOrderShippedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند توصيل طلب
    /// </summary>
    public void OrderDeliver()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerOrderDeliveredEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إرجاع طلب
    /// </summary>
    public void OrderReturn()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerOrderReturnedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إصدار عرض سعر
    /// </summary>
    public void QuotationIssu()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerQuotationIssuedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند قبول عرض سعر
    /// </summary>
    public void QuotationAccept()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerQuotationAcceptedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند تطبيق خصم
    /// </summary>
    public void DiscountAppli()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerDiscountAppliedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند الموافقة على الكيان
    /// </summary>
    public void Approv()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerApprovedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند رفض الكيان
    /// </summary>
    public void Reject()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerRejectedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند تقديم الكيان للموافقة
    /// </summary>
    public void Submitt()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerSubmittedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إرجاع الكيان بعد المراجعة
    /// </summary>
    public void Return()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerReturnedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند اكتمال عملية التحقق من الكيان
    /// </summary>
    public void Validat()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerValidatedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند فشل التحقق من الكيان
    /// </summary>
    public void ValidationFail()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new CustomerValidationFailedEvent(Id));
    }
        
        #endregion
    }
}
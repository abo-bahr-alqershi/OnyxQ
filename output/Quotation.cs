using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Purchasing & Vendors.Events;
using ERP_Pro.Domain.ERP.Purchasing & Vendors.ValueObjects;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.Entities
{
    /// <summary>
    /// Quotation Entity
    /// </summary>
    public class Quotation : Entity<QuotationId>
    {
        #region Properties
        
        // Original properties and their value objects
    // Original property (keeps for backward compatibility)
    public decimal UseRequestModifyPrice { get; private set; } /*! UseRequestModifyPrice */
    // Original property (keeps for backward compatibility)
    public decimal RequestAmount { get; private set; } /*! RequestAmount */
    // Original property (keeps for backward compatibility)
    public string ReturnRequestCurrency { get; private set; } /*! ReturnRequestCurrency */
    // Original property (keeps for backward compatibility)
    public decimal ReturnRequestRate { get; private set; } /*! ReturnRequestRate */
    // Original property (keeps for backward compatibility)
    public decimal Amount { get; private set; } /*! QuotationAmount */
    // Value object
    public Money Money =>
        Money.Create(UseRequestModifyPrice , RequestAmount , ReturnRequestCurrency , ReturnRequestRate , QuotationAmount );
    // Original property (keeps for backward compatibility)
    public bool RequestNameEnglish { get; private set; } /*! RequestNameEnglish */
    // Original property (keeps for backward compatibility)
    public string RequestName { get; private set; } /*! RequestName */
    // Original property (keeps for backward compatibility)
    public bool RequestNameEnglishShort { get; private set; } /*! RequestNameEnglishShort */
    // Original property (keeps for backward compatibility)
    public string RequestNameShort { get; private set; } /*! RequestNameShort */
    // Original property (keeps for backward compatibility)
    public string EquipmentFirstName { get; private set; } /*! EquipmentFirstName */
    // Original property (keeps for backward compatibility)
    public string EquipmentLastName { get; private set; } /*! EquipmentLastName */
    // Value object
    public PersonInfo PersonInfo =>
        PersonInfo.Create(RequestNameEnglish , RequestName , RequestNameEnglishShort , RequestNameShort , EquipmentFirstName , EquipmentLastName );
    // Original property (keeps for backward compatibility)
    public int RequestSide { get; private set; } /*! RequestSide */
    // Original property (keeps for backward compatibility)
    public int AccountsPayablePurchaseRequestSerial { get; private set; } /*! AccountsPayablePurchaseRequestSerial */
    // Original property (keeps for backward compatibility)
    public string ArSerial { get; private set; } /*! ArQuotationSerial */
    // Original property (keeps for backward compatibility)
    public int ArRequestAdditionalDiscountSerial { get; private set; } /*! ArRequestAdditionalDiscountSerial */
    // Original property (keeps for backward compatibility)
    public int IdentifyChequeNumber { get; private set; } /*! IdentifyChequeNumber */
    // Original property (keeps for backward compatibility)
    public DateTime ExpireDate { get; private set; } /*! QuotationExpireDate */
    // Value object
    public IdentityInfo IdentityInfo =>
        IdentityInfo.Create(RequestSide , AccountsPayablePurchaseRequestSerial , ArQuotationSerial , ArRequestAdditionalDiscountSerial , IdentifyChequeNumber , QuotationExpireDate );

        #endregion

        #region Constructors
        
        private Quotation()
        {
            // Required by EF Core
        }
        
        public Quotation(
            QuotationId id
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
        AddDomainEvent(new QuotationCreatedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند تحديث بيانات الكيان
    /// </summary>
    public void Updat()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new QuotationUpdatedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند حذف الكيان (منطقي أو فعلي)
    /// </summary>
    public void Delet()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new QuotationDeletedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند أرشفة الكيان
    /// </summary>
    public void Archiv()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new QuotationArchivedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند تغيير حالة الكيان الرئيسية
    /// </summary>
    public void StatusChang(string newStatus)
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new QuotationStatusChangedEvent(Id, Status, newStatus));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند تفعيل الكيان
    /// </summary>
    public void Activat(string newStatus)
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new QuotationActivatedEvent(Id, Status, newStatus));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إلغاء تفعيل الكيان
    /// </summary>
    public void Deactivat(string newStatus)
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new QuotationDeactivatedEvent(Id, Status, newStatus));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند قفل الكيان
    /// </summary>
    public void Lock()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new QuotationLockedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إلغاء قفل الكيان
    /// </summary>
    public void Unlock()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new QuotationUnlockedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند استلام دفعة
    /// </summary>
    public void PaymentReceiv()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new QuotationPaymentReceivedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إصدار دفعة
    /// </summary>
    public void PaymentIssu()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new QuotationPaymentIssuedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إصدار فاتورة
    /// </summary>
    public void InvoiceIssu()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new QuotationInvoiceIssuedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند تغير الرصيد
    /// </summary>
    public void BalanceChang(decimal newValue, string reason = null)
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new QuotationBalanceChangedEvent(Id, newValue, reason ?? "System update"));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند تغيير حد الائتمان
    /// </summary>
    public void CreditLimitChang(decimal newValue, string reason = null)
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new QuotationCreditLimitChangedEvent(Id, newValue, reason ?? "System update"));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند احتساب الضريبة
    /// </summary>
    public void TaxCalculat()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new QuotationTaxCalculatedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند الموافقة على الكيان
    /// </summary>
    public void Approv()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new QuotationApprovedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند رفض الكيان
    /// </summary>
    public void Reject()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new QuotationRejectedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند تقديم الكيان للموافقة
    /// </summary>
    public void Submitt()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new QuotationSubmittedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند إرجاع الكيان بعد المراجعة
    /// </summary>
    public void Return()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new QuotationReturnedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند اكتمال عملية التحقق من الكيان
    /// </summary>
    public void Validat()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new QuotationValidatedEvent(Id));
    }
    /// <summary>
    /// يتم إطلاق هذا الحدث عند فشل التحقق من الكيان
    /// </summary>
    public void ValidationFail()
    {
        // Implement domain logic here
        
        // Raise the domain event
        AddDomainEvent(new QuotationValidationFailedEvent(Id));
    }
        
        #endregion
    }
}
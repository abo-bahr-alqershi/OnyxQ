using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.Enums;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a branch document in the ERP system
/// يمثل وثيقة الفرع في نظام تخطيط موارد المؤسسات
/// اسم الجدول: S_BRN_DOCS
/// Table name: S_BRN_DOCS
/// </summary>
public class BranchDocument : AuditableEntity
{
    #region Properties

    /// <summary>
    /// رقم الكود - المفتاح الرئيسي
    /// Code number - Primary Key
    /// </summary>
    public int CodeNumber { get; private set; } // CODE_NO

    /// <summary>
    /// رقم الفرع - المفتاح الرئيسي
    /// Branch number - Primary Key
    /// </summary>
    public int BranchNumber { get; private set; } // BRN_NO

    /// <summary>
    /// رقم الوثيقة
    /// Document number
    /// </summary>
    public string DocumentNumber { get; private set; } // DOC_NO

    /// <summary>
    /// تاريخ الإصدار
    /// Issue date
    /// </summary>
    public DateTime IssueDate { get; private set; } // ISSUE_DATE

    /// <summary>
    /// تاريخ الانتهاء
    /// End date
    /// </summary>
    public DateTime? EndDate { get; private set; } // END_DATE

    /// <summary>
    /// مدة التنبيه
    /// Duration alarm
    /// </summary>
    public int? DurationAlarm { get; private set; } // DUR_ALRM

    /// <summary>
    /// تاريخ التجديد
    /// Renewal date
    /// </summary>
    public DateTime? RenewalDate { get; private set; } // RNWL_DATE

    /// <summary>
    /// مكان الإصدار
    /// Issue place
    /// </summary>
    public string IssuePlace { get; private set; } // ISSUE_PLACE

    /// <summary>
    /// حقول إضافية
    /// Additional fields
    /// </summary>
    public string Field1 { get; private set; }
    public string Field2 { get; private set; }
    public string Field3 { get; private set; }
    public string Field4 { get; private set; }
    public string Field5 { get; private set; }
    public string Field6 { get; private set; }
    public string Field7 { get; private set; }
    public string Field8 { get; private set; }
    public string Field9 { get; private set; }
    public string Field10 { get; private set; }

    /// <summary>
    /// حالة النشاط
    /// Activity status
    /// </summary>
    public bool IsInactive { get; private set; } // INACTIVE

    /// <summary>
    /// تاريخ عدم النشاط
    /// Inactivity date
    /// </summary>
    public DateTime? InactiveDate { get; private set; } // INACTIVE_DATE

    /// <summary>
    /// سبب عدم النشاط
    /// Inactivity reason
    /// </summary>
    public string InactiveReason { get; private set; } // INACTIVE_RES

    /// <summary>
    /// معرف المستخدم الذي قام بإلغاء النشاط
    /// User ID who made the document inactive
    /// </summary>
    public int? InactiveUserId { get; private set; } // INACTIVE_U_ID

    /// <summary>
    /// نوع المستند
    /// Document type
    /// </summary>
    public DocumentType DocumentType { get; private set; }

    /// <summary>
    /// رقم المستند الخارجي
    /// External document number
    /// </summary>
    public string ExternalDocumentNo { get; private set; }

    /// <summary>
    /// الجهة المصدرة للمستند
    /// Document issuing authority
    /// </summary>
    public string IssuingAuthority { get; private set; }

    /// <summary>
    /// وصف المستند
    /// Document description
    /// </summary>
    public string Description { get; private set; }

    /// <summary>
    /// مسار الملف
    /// File path
    /// </summary>
    public string FilePath { get; private set; }

    /// <summary>
    /// حالة المستند
    /// Document status
    /// </summary>
    public DocumentStatus Status { get; private set; }

    #endregion

    #region Navigation Properties

    /// <summary>
    /// الفرع المرتبط بالوثيقة
    /// Branch associated with the document
    /// </summary>
    public virtual Branch Branch { get; private set; }

    #endregion

    #region Constructors

    private BranchDocument() { } // Required by EF Core

    public BranchDocument(
        int codeNumber,
        int branchNumber,
        string documentNumber,
        DateTime issueDate,
        DateTime? endDate,
        int? durationAlarm,
        string issuePlace)
    {
        CodeNumber = codeNumber;
        BranchNumber = branchNumber;
        DocumentNumber = documentNumber;
        IssueDate = issueDate;
        EndDate = endDate;
        DurationAlarm = durationAlarm;
        IssuePlace = issuePlace;
        IsInactive = false;

        AddDomainEvent(new BranchDocumentCreatedEvent(this));
    }

    #endregion

    #region Methods

    /// <summary>
    /// تحديث معلومات الوثيقة
    /// Update document information
    /// </summary>
    public void UpdateInformation(
        string documentNumber,
        DateTime issueDate,
        DateTime? endDate,
        int? durationAlarm,
        string issuePlace)
    {
        DocumentNumber = documentNumber;
        IssueDate = issueDate;
        EndDate = endDate;
        DurationAlarm = durationAlarm;
        IssuePlace = issuePlace;

        AddDomainEvent(new BranchDocumentUpdatedEvent(this));
    }

    /// <summary>
    /// تحديث تاريخ التجديد
    /// Update renewal date
    /// </summary>
    public void UpdateRenewalDate(DateTime renewalDate)
    {
        var oldRenewalDate = RenewalDate;
        RenewalDate = renewalDate;

        AddDomainEvent(new BranchDocumentRenewalDateUpdatedEvent(this, oldRenewalDate, renewalDate));
    }

    /// <summary>
    /// تحديث الحقول الإضافية
    /// Update additional fields
    /// </summary>
    public void UpdateAdditionalFields(
        string field1 = null,
        string field2 = null,
        string field3 = null,
        string field4 = null,
        string field5 = null,
        string field6 = null,
        string field7 = null,
        string field8 = null,
        string field9 = null,
        string field10 = null)
    {
        Field1 = field1;
        Field2 = field2;
        Field3 = field3;
        Field4 = field4;
        Field5 = field5;
        Field6 = field6;
        Field7 = field7;
        Field8 = field8;
        Field9 = field9;
        Field10 = field10;

        AddDomainEvent(new BranchDocumentAdditionalFieldsUpdatedEvent(this));
    }

    /// <summary>
    /// تغيير حالة النشاط
    /// Change activity status
    /// </summary>
    public void ChangeActivityStatus(bool isInactive, int userId, string reason = null)
    {
        var oldStatus = IsInactive;
        IsInactive = isInactive;
        InactiveUserId = isInactive ? userId : null;
        InactiveReason = isInactive ? reason : null;
        InactiveDate = isInactive ? DateTime.Now : null;

        AddDomainEvent(new BranchDocumentActivityStatusChangedEvent(this, oldStatus, isInactive, reason));
    }

    /// <summary>
    /// تحديث معلومات المستند
    /// Update document information
    /// </summary>
    public void UpdateDocumentInfo(
        string externalDocumentNo,
        DateTime issueDate,
        DateTime? expiryDate,
        string issuingAuthority,
        string description)
    {
        ExternalDocumentNo = externalDocumentNo;
        IssueDate = issueDate;
        ExpiryDate = expiryDate;
        IssuingAuthority = issuingAuthority;
        Description = description;

        AddDomainEvent(new BranchDocumentUpdatedEvent(this));
    }

    /// <summary>
    /// تحديث مسار الملف
    /// Update file path
    /// </summary>
    public void UpdateFilePath(string newFilePath)
    {
        var oldFilePath = FilePath;
        FilePath = newFilePath;

        AddDomainEvent(new BranchDocumentFilePathChangedEvent(this, oldFilePath, newFilePath));
    }

    /// <summary>
    /// تغيير حالة المستند
    /// Change document status
    /// </summary>
    public void ChangeStatus(DocumentStatus newStatus)
    {
        var oldStatus = Status;
        Status = newStatus;

        AddDomainEvent(new BranchDocumentStatusChangedEvent(this, oldStatus, newStatus));
    }

    #endregion
}
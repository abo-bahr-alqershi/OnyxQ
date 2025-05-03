using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a SelectField entity
/// يمثل كيان حقل الاختيار
/// </summary>
public class SelectField : AuditableEntity
{
    /// <summary>
    /// Gets the unique identifier for the SelectField
    /// المعرف الفريد لحقل الاختيار
    /// !# FORM_NO, FLD_ID, BRN_NO
    /// </summary>
    public SelectFieldId Id { get; private set; }

    /// <summary>
    /// Gets the field name
    /// اسم الحقل
    /// !# FLD_NAME
    /// </summary>
    public string FieldName { get; private set; }

    /// <summary>
    /// Gets the company number
    /// رقم الشركة
    /// !# CMP_NO
    /// </summary>
    public int CompanyNumber { get; private set; }

    /// <summary>
    /// Gets the branch year
    /// سنة الفرع
    /// !# BRN_YEAR
    /// </summary>
    public int BranchYear { get; private set; }

    /// <summary>
    /// Gets the branch user
    /// مستخدم الفرع
    /// !# BRN_USR
    /// </summary>
    public int BranchUser { get; private set; }

    /// <summary>
    /// Gets the user ID who added
    /// معرف المستخدم الذي أضاف
    /// !# AD_U_ID
    /// </summary>
    public int? AddedByUserId { get; private set; }

    /// <summary>
    /// Gets the add date
    /// تاريخ الإضافة
    /// !# AD_DATE
    /// </summary>
    public DateTime? AddDate { get; private set; }

    /// <summary>
    /// Gets the terminal name for add
    /// اسم الجهاز عند الإضافة
    /// !# AD_TRMNL_NM
    /// </summary>
    public string AddTerminalName { get; private set; }

    /// <summary>
    /// Gets the user ID who last updated
    /// معرف المستخدم الذي قام بآخر تحديث
    /// !# UP_U_ID
    /// </summary>
    public int? UpdatedByUserId { get; private set; }

    /// <summary>
    /// Gets the last update date
    /// تاريخ آخر تحديث
    /// !# UP_DATE
    /// </summary>
    public DateTime? UpdatedDate { get; private set; }

    /// <summary>
    /// Gets the terminal name for last update
    /// اسم الجهاز لآخر تحديث
    /// !# UP_TRMNL_NM
    /// </summary>
    public string UpdatedTerminalName { get; private set; }

    private SelectField() { }

    public SelectField(
        int formNumber,
        long fieldId,
        int branchNumber,
        string fieldName,
        int companyNumber,
        int branchYear,
        int branchUser,
        int? addedByUserId,
        DateTime? addDate,
        string addTerminalName,
        int? updatedByUserId,
        DateTime? updatedDate,
        string updatedTerminalName)
    {
        Id = new SelectFieldId(formNumber, fieldId, branchNumber);
        FieldName = fieldName;
        CompanyNumber = companyNumber;
        BranchYear = branchYear;
        BranchUser = branchUser;
        AddedByUserId = addedByUserId;
        AddDate = addDate;
        AddTerminalName = addTerminalName;
        UpdatedByUserId = updatedByUserId;
        UpdatedDate = updatedDate;
        UpdatedTerminalName = updatedTerminalName;
        AddDomainEvent(new SelectFieldCreated(this));
    }

    public void Update(
        string fieldName,
        int companyNumber,
        int branchYear,
        int branchUser,
        int? updatedByUserId,
        DateTime? updatedDate,
        string updatedTerminalName)
    {
        FieldName = fieldName;
        CompanyNumber = companyNumber;
        BranchYear = branchYear;
        BranchUser = branchUser;
        UpdatedByUserId = updatedByUserId;
        UpdatedDate = updatedDate;
        UpdatedTerminalName = updatedTerminalName;
        AddDomainEvent(new SelectFieldUpdated(this));
    }

    public void Delete()
    {
        AddDomainEvent(new SelectFieldDeleted(this));
    }
} 
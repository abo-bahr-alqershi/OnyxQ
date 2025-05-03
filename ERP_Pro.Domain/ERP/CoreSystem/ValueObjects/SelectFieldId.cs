using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// Represents the unique identifier for a SelectField entity
/// يمثل المعرف الفريد لكيان حقل الاختيار
/// !# FORM_NO, FLD_ID, BRN_NO
/// </summary>
public sealed class SelectFieldId : ValueObject
{
    /// <summary>
    /// Gets the form number
    /// رقم النموذج
    /// !# FORM_NO
    /// </summary>
    public int FormNumber { get; }

    /// <summary>
    /// Gets the field ID
    /// معرف الحقل
    /// !# FLD_ID
    /// </summary>
    public long FieldId { get; }

    /// <summary>
    /// Gets the branch number
    /// رقم الفرع
    /// !# BRN_NO
    /// </summary>
    public int BranchNumber { get; }

    /// <summary>
    /// Initializes a new instance of the SelectFieldId class
    /// تهيئة نسخة جديدة من صنف معرف حقل الاختيار
    /// </summary>
    /// <param name="formNumber">The form number رقم النموذج</param>
    /// <param name="fieldId">The field ID معرف الحقل</param>
    /// <param name="branchNumber">The branch number رقم الفرع</param>
    public SelectFieldId(int formNumber, long fieldId, int branchNumber)
    {
        if (formNumber <= 0)
            throw new ArgumentException("Form number must be greater than zero", nameof(formNumber));
        if (fieldId <= 0)
            throw new ArgumentException("Field ID must be greater than zero", nameof(fieldId));
        if (branchNumber <= 0)
            throw new ArgumentException("Branch number must be greater than zero", nameof(branchNumber));

        FormNumber = formNumber;
        FieldId = fieldId;
        BranchNumber = branchNumber;
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return FormNumber;
        yield return FieldId;
        yield return BranchNumber;
    }
} 
using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects;
namespace ERP_Pro.Domain.ERP.InsuranceClaims.Entities
{
/// <summary>
/// InsuranceClassLimitDocument Entity
/// </summary>
public class InsuranceClassLimitDocument : Entity<InsuranceClassLimitDocumentId>
{

    private InsuranceClassLimitDocument() { }

    public InsuranceClassLimitDocument(InsuranceClassLimitDocumentId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the InsuranceClassLimitDocument
    /// المعرف الفريد لـ InsuranceClassLimitDocument
    /// </summary>
    public InsuranceClassLimitDocumentId Id { get; private set; }

    /// <summary>
    /// RelationType of the InsuranceClassLimitDocument
    /// RelationType الخاص بـ InsuranceClassLimitDocument
    /// </summary>
    public decimal? RelationType { get; private set; }

    /// <summary>
    /// LoadPercent of the InsuranceClassLimitDocument
    /// LoadPercent الخاص بـ InsuranceClassLimitDocument
    /// </summary>
    public decimal? LoadPercent { get; private set; }

    /// <summary>
    /// LimitAmountNetLocal of the InsuranceClassLimitDocument
    /// LimitAmountNetLocal الخاص بـ InsuranceClassLimitDocument
    /// </summary>
    public decimal? LimitAmountNetLocal { get; private set; }

    /// <summary>
    /// LimitAmountOutNetLocal of the InsuranceClassLimitDocument
    /// LimitAmountOutNetLocal الخاص بـ InsuranceClassLimitDocument
    /// </summary>
    public decimal? LimitAmountOutNetLocal { get; private set; }

    /// <summary>
    /// LoadPercentOutNet of the InsuranceClassLimitDocument
    /// LoadPercentOutNet الخاص بـ InsuranceClassLimitDocument
    /// </summary>
    public decimal? LoadPercentOutNet { get; private set; }

    /// <summary>
    /// LoadAmountLocalLimit of the InsuranceClassLimitDocument
    /// LoadAmountLocalLimit الخاص بـ InsuranceClassLimitDocument
    /// </summary>
    public decimal? LoadAmountLocalLimit { get; private set; }

    /// <summary>
    /// LoadPercentChronic of the InsuranceClassLimitDocument
    /// LoadPercentChronic الخاص بـ InsuranceClassLimitDocument
    /// </summary>
    public decimal? LoadPercentChronic { get; private set; }

    /// <summary>
    /// LimitAmountLocalChronicDocument of the InsuranceClassLimitDocument
    /// LimitAmountLocalChronicDocument الخاص بـ InsuranceClassLimitDocument
    /// </summary>
    public decimal? LimitAmountLocalChronicDocument { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public InsuranceCompanyClass InsuranceCompanyClass { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}


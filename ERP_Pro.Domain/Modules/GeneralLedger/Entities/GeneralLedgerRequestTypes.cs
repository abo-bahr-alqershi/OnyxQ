using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;
using ERP_Pro.Domain.ERP.FormsSurveys.Entities;

using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;
namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerRequestTypes Entity
/// </summary>
public class GeneralLedgerRequestTypes : Entity<GeneralLedgerRequestTypesId>
{

    private GeneralLedgerRequestTypes() { }

    public GeneralLedgerRequestTypes(GeneralLedgerRequestTypesId id, decimal? requestDocumentType, decimal? requestTypeShort)
    {
        Id = id;
        RequestDocumentType = requestDocumentType;
        RequestTypeShort = requestTypeShort;
    }

    /// <summary>
    /// The unique identifier for the GeneralLedgerRequestTypes
    /// المعرف الفريد لـ GeneralLedgerRequestTypes
    /// </summary>
    public GeneralLedgerRequestTypesId Id { get; private set; }

    /// <summary>
    /// RequestDocumentType of the GeneralLedgerRequestTypes
    /// RequestDocumentType الخاص بـ GeneralLedgerRequestTypes
    /// </summary>
    public decimal? RequestDocumentType { get; private set; }

    /// <summary>
    /// RequestTypeShort of the GeneralLedgerRequestTypes
    /// RequestTypeShort الخاص بـ GeneralLedgerRequestTypes
    /// </summary>
    public decimal? RequestTypeShort { get; private set; }

    /// <summary>
    /// RequestNameShort of the GeneralLedgerRequestTypes
    /// RequestNameShort الخاص بـ GeneralLedgerRequestTypes
    /// </summary>
    public string RequestNameShort { get; private set; }

    /// <summary>
    /// RequestNameEnglishShort of the GeneralLedgerRequestTypes
    /// RequestNameEnglishShort الخاص بـ GeneralLedgerRequestTypes
    /// </summary>
    public string RequestNameEnglishShort { get; private set; }

    /// <summary>
    /// SequencedFlag of the GeneralLedgerRequestTypes
    /// SequencedFlag الخاص بـ GeneralLedgerRequestTypes
    /// </summary>
    public decimal? SequencedFlag { get; private set; }

    /// <summary>
    /// PaymentReceipt of the GeneralLedgerRequestTypes
    /// PaymentReceipt الخاص بـ GeneralLedgerRequestTypes
    /// </summary>
    public decimal? PaymentReceipt { get; private set; }

    /// <summary>
    /// RepSample of the GeneralLedgerRequestTypes
    /// RepSample الخاص بـ GeneralLedgerRequestTypes
    /// </summary>
    public decimal? RepSample { get; private set; }

    /// <summary>
    /// AllowUpdateInstallmentAmount of the GeneralLedgerRequestTypes
    /// AllowUpdateInstallmentAmount الخاص بـ GeneralLedgerRequestTypes
    /// </summary>
    public decimal? AllowUpdateInstallmentAmount { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}


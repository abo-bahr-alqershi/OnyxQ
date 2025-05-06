using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects;
namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Entities
{
/// <summary>
/// MissingDocumentTemp Entity
/// </summary>
public class MissingDocumentTemp : Entity<MissingDocumentTempId>
{

    private MissingDocumentTemp() { }

    public MissingDocumentTemp(MissingDocumentTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the MissingDocumentTemp
    /// المعرف الفريد لـ MissingDocumentTemp
    /// </summary>
    public MissingDocumentTempId Id { get; private set; }

    /// <summary>
    /// DocType of the MissingDocumentTemp
    /// DocType الخاص بـ MissingDocumentTemp
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// JournalVoucherTypeFull of the MissingDocumentTemp
    /// JournalVoucherTypeFull الخاص بـ MissingDocumentTemp
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// CashNumber of the MissingDocumentTemp
    /// CashNumber الخاص بـ MissingDocumentTemp
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// WarehouseCode of the MissingDocumentTemp
    /// WarehouseCode الخاص بـ MissingDocumentTemp
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the MissingDocumentTemp
    /// CostCenterCode الخاص بـ MissingDocumentTemp
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// DocNo of the MissingDocumentTemp
    /// DocNo الخاص بـ MissingDocumentTemp
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocNoV of the MissingDocumentTemp
    /// DocNoV الخاص بـ MissingDocumentTemp
    /// </summary>
    public string DocNoV { get; private set; }

    /// <summary>
    /// DocSeq of the MissingDocumentTemp
    /// DocSeq الخاص بـ MissingDocumentTemp
    /// </summary>
    public decimal? DocSeq { get; private set; }

    /// <summary>
    /// AccountCurrency of the MissingDocumentTemp
    /// AccountCurrency الخاص بـ MissingDocumentTemp
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the MissingDocumentTemp
    /// CompanyNumberShort الخاص بـ MissingDocumentTemp
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the MissingDocumentTemp
    /// BranchNumber الخاص بـ MissingDocumentTemp
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the MissingDocumentTemp
    /// BranchYear الخاص بـ MissingDocumentTemp
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the MissingDocumentTemp
    /// BranchUser الخاص بـ MissingDocumentTemp
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}


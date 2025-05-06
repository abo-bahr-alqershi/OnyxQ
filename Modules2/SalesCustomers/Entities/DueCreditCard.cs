using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// DueCreditCard Entity
/// </summary>
public class DueCreditCard : Entity<DueCreditCardId>
{

    private DueCreditCard() { }

    public DueCreditCard(DueCreditCardId id, decimal? docNo)
    {
        Id = id;
        DocNo = docNo;
    }

    /// <summary>
    /// The unique identifier for the DueCreditCard
    /// المعرف الفريد لـ DueCreditCard
    /// </summary>
    public DueCreditCardId Id { get; private set; }

    /// <summary>
    /// DocNo of the DueCreditCard
    /// DocNo الخاص بـ DueCreditCard
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the DueCreditCard
    /// DocSer الخاص بـ DueCreditCard
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocAmt of the DueCreditCard
    /// DocAmt الخاص بـ DueCreditCard
    /// </summary>
    public decimal? DocAmt { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the DueCreditCard
    /// BillDocumentTypeFull الخاص بـ DueCreditCard
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillNumber of the DueCreditCard
    /// BillNumber الخاص بـ DueCreditCard
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the DueCreditCard
    /// BillSerial الخاص بـ DueCreditCard
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// BillDate of the DueCreditCard
    /// BillDate الخاص بـ DueCreditCard
    /// </summary>
    public DateTime? BillDate { get; private set; }

    /// <summary>
    /// ValueDate of the DueCreditCard
    /// ValueDate الخاص بـ DueCreditCard
    /// </summary>
    public DateTime? ValueDate { get; private set; }

    /// <summary>
    /// AccountCurrency of the DueCreditCard
    /// AccountCurrency الخاص بـ DueCreditCard
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// DocRate of the DueCreditCard
    /// DocRate الخاص بـ DueCreditCard
    /// </summary>
    public decimal? DocRate { get; private set; }

    /// <summary>
    /// ProjectNumber of the DueCreditCard
    /// ProjectNumber الخاص بـ DueCreditCard
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// CreditCardNumberFull of the DueCreditCard
    /// CreditCardNumberFull الخاص بـ DueCreditCard
    /// </summary>
    public decimal? CreditCardNumberFull { get; private set; }

    /// <summary>
    /// CreditCardAmount of the DueCreditCard
    /// CreditCardAmount الخاص بـ DueCreditCard
    /// </summary>
    public decimal? CreditCardAmount { get; private set; }

    /// <summary>
    /// AccountCode of the DueCreditCard
    /// AccountCode الخاص بـ DueCreditCard
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// CreditCardCommissionPercent of the DueCreditCard
    /// CreditCardCommissionPercent الخاص بـ DueCreditCard
    /// </summary>
    public decimal? CreditCardCommissionPercent { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the DueCreditCard
    /// ExternalPostFlag الخاص بـ DueCreditCard
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// DocPost of the DueCreditCard
    /// DocPost الخاص بـ DueCreditCard
    /// </summary>
    public decimal? DocPost { get; private set; }

    /// <summary>
    /// PostUserId of the DueCreditCard
    /// PostUserId الخاص بـ DueCreditCard
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the DueCreditCard
    /// PostDate الخاص بـ DueCreditCard
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the DueCreditCard
    /// UnpostUserId الخاص بـ DueCreditCard
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the DueCreditCard
    /// UnpostDate الخاص بـ DueCreditCard
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the DueCreditCard
    /// CompanyNumberShort الخاص بـ DueCreditCard
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the DueCreditCard
    /// BranchNumber الخاص بـ DueCreditCard
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the DueCreditCard
    /// BranchYear الخاص بـ DueCreditCard
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the DueCreditCard
    /// BranchUser الخاص بـ DueCreditCard
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}


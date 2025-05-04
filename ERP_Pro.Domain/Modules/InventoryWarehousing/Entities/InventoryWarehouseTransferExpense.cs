using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// InventoryWarehouseTransferExpense Entity
/// </summary>
public class InventoryWarehouseTransferExpense : Entity<InventoryWarehouseTransferExpenseId>
{

    private InventoryWarehouseTransferExpense() { }

    public InventoryWarehouseTransferExpense(InventoryWarehouseTransferExpenseId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the InventoryWarehouseTransferExpense
    /// المعرف الفريد لـ InventoryWarehouseTransferExpense
    /// </summary>
    public InventoryWarehouseTransferExpenseId Id { get; private set; }

    /// <summary>
    /// DocNo of the InventoryWarehouseTransferExpense
    /// DocNo الخاص بـ InventoryWarehouseTransferExpense
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// TransactionInOutType of the InventoryWarehouseTransferExpense
    /// TransactionInOutType الخاص بـ InventoryWarehouseTransferExpense
    /// </summary>
    public decimal? TransactionInOutType { get; private set; }

    /// <summary>
    /// DocDesc of the InventoryWarehouseTransferExpense
    /// DocDesc الخاص بـ InventoryWarehouseTransferExpense
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// ReferenceNumber of the InventoryWarehouseTransferExpense
    /// ReferenceNumber الخاص بـ InventoryWarehouseTransferExpense
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// AccountCode of the InventoryWarehouseTransferExpense
    /// AccountCode الخاص بـ InventoryWarehouseTransferExpense
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the InventoryWarehouseTransferExpense
    /// AccountDetailCode الخاص بـ InventoryWarehouseTransferExpense
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the InventoryWarehouseTransferExpense
    /// AccountDetailType الخاص بـ InventoryWarehouseTransferExpense
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountCurrency of the InventoryWarehouseTransferExpense
    /// AccountCurrency الخاص بـ InventoryWarehouseTransferExpense
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the InventoryWarehouseTransferExpense
    /// AccountRate الخاص بـ InventoryWarehouseTransferExpense
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// CostCenterCode of the InventoryWarehouseTransferExpense
    /// CostCenterCode الخاص بـ InventoryWarehouseTransferExpense
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the InventoryWarehouseTransferExpense
    /// ProjectNumber الخاص بـ InventoryWarehouseTransferExpense
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the InventoryWarehouseTransferExpense
    /// ActivityNumber الخاص بـ InventoryWarehouseTransferExpense
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// Amount of the InventoryWarehouseTransferExpense
    /// Amount الخاص بـ InventoryWarehouseTransferExpense
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// InvoiceAmount of the InventoryWarehouseTransferExpense
    /// InvoiceAmount الخاص بـ InventoryWarehouseTransferExpense
    /// </summary>
    public decimal? InvoiceAmount { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the InventoryWarehouseTransferExpense
    /// ExternalPostFlag الخاص بـ InventoryWarehouseTransferExpense
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// RecordNumber of the InventoryWarehouseTransferExpense
    /// RecordNumber الخاص بـ InventoryWarehouseTransferExpense
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// BranchNumber of the InventoryWarehouseTransferExpense
    /// BranchNumber الخاص بـ InventoryWarehouseTransferExpense
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the InventoryWarehouseTransferExpense
    /// BranchYear الخاص بـ InventoryWarehouseTransferExpense
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the InventoryWarehouseTransferExpense
    /// BranchUser الخاص بـ InventoryWarehouseTransferExpense
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the InventoryWarehouseTransferExpense
    /// CompanyNumberShort الخاص بـ InventoryWarehouseTransferExpense
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// DocBrnNo of the InventoryWarehouseTransferExpense
    /// DocBrnNo الخاص بـ InventoryWarehouseTransferExpense
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public WarehouseTransferMaster WarehouseTransferMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

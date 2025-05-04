using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// BranchInventoryWarehouseTransferExpense Entity
/// </summary>
public class BranchInventoryWarehouseTransferExpense : Entity<BranchInventoryWarehouseTransferExpenseId>
{

    private BranchInventoryWarehouseTransferExpense() { }

    public BranchInventoryWarehouseTransferExpense(BranchInventoryWarehouseTransferExpenseId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the BranchInventoryWarehouseTransferExpense
    /// المعرف الفريد لـ BranchInventoryWarehouseTransferExpense
    /// </summary>
    public BranchInventoryWarehouseTransferExpenseId Id { get; private set; }

    /// <summary>
    /// DocNo of the BranchInventoryWarehouseTransferExpense
    /// DocNo الخاص بـ BranchInventoryWarehouseTransferExpense
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// TransactionInOutType of the BranchInventoryWarehouseTransferExpense
    /// TransactionInOutType الخاص بـ BranchInventoryWarehouseTransferExpense
    /// </summary>
    public decimal? TransactionInOutType { get; private set; }

    /// <summary>
    /// DocDesc of the BranchInventoryWarehouseTransferExpense
    /// DocDesc الخاص بـ BranchInventoryWarehouseTransferExpense
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// ReferenceNumber of the BranchInventoryWarehouseTransferExpense
    /// ReferenceNumber الخاص بـ BranchInventoryWarehouseTransferExpense
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// AccountCode of the BranchInventoryWarehouseTransferExpense
    /// AccountCode الخاص بـ BranchInventoryWarehouseTransferExpense
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the BranchInventoryWarehouseTransferExpense
    /// AccountDetailCode الخاص بـ BranchInventoryWarehouseTransferExpense
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the BranchInventoryWarehouseTransferExpense
    /// AccountDetailType الخاص بـ BranchInventoryWarehouseTransferExpense
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountCurrency of the BranchInventoryWarehouseTransferExpense
    /// AccountCurrency الخاص بـ BranchInventoryWarehouseTransferExpense
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the BranchInventoryWarehouseTransferExpense
    /// AccountRate الخاص بـ BranchInventoryWarehouseTransferExpense
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// CostCenterCode of the BranchInventoryWarehouseTransferExpense
    /// CostCenterCode الخاص بـ BranchInventoryWarehouseTransferExpense
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the BranchInventoryWarehouseTransferExpense
    /// ProjectNumber الخاص بـ BranchInventoryWarehouseTransferExpense
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the BranchInventoryWarehouseTransferExpense
    /// ActivityNumber الخاص بـ BranchInventoryWarehouseTransferExpense
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// Amount of the BranchInventoryWarehouseTransferExpense
    /// Amount الخاص بـ BranchInventoryWarehouseTransferExpense
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// InvoiceAmount of the BranchInventoryWarehouseTransferExpense
    /// InvoiceAmount الخاص بـ BranchInventoryWarehouseTransferExpense
    /// </summary>
    public decimal? InvoiceAmount { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchInventoryWarehouseTransferExpense
    /// ExternalPostFlag الخاص بـ BranchInventoryWarehouseTransferExpense
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// RecordNumber of the BranchInventoryWarehouseTransferExpense
    /// RecordNumber الخاص بـ BranchInventoryWarehouseTransferExpense
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocBrnNo of the BranchInventoryWarehouseTransferExpense
    /// DocBrnNo الخاص بـ BranchInventoryWarehouseTransferExpense
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchInventoryWarehouseTransferExpense
    /// BranchNumber الخاص بـ BranchInventoryWarehouseTransferExpense
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchInventoryWarehouseTransferExpense
    /// BranchYear الخاص بـ BranchInventoryWarehouseTransferExpense
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchInventoryWarehouseTransferExpense
    /// BranchUser الخاص بـ BranchInventoryWarehouseTransferExpense
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchInventoryWarehouseTransferExpense
    /// CompanyNumberShort الخاص بـ BranchInventoryWarehouseTransferExpense
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public BranchWarehouseTransferMaster BranchWarehouseTransferMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

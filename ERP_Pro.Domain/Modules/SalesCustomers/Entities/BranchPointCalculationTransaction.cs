using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// BranchPointCalculationTransaction Entity
/// </summary>
public class BranchPointCalculationTransaction : Entity<BranchPointCalculationTransactionId>
{

    private BranchPointCalculationTransaction() { }

    public BranchPointCalculationTransaction(BranchPointCalculationTransactionId id, decimal? transactionNumber)
    {
        Id = id;
        TransactionNumber = transactionNumber;
    }

    /// <summary>
    /// The unique identifier for the BranchPointCalculationTransaction
    /// المعرف الفريد لـ BranchPointCalculationTransaction
    /// </summary>
    public BranchPointCalculationTransactionId Id { get; private set; }

    /// <summary>
    /// TransactionNumber of the BranchPointCalculationTransaction
    /// TransactionNumber الخاص بـ BranchPointCalculationTransaction
    /// </summary>
    public decimal? TransactionNumber { get; private set; }

    /// <summary>
    /// TransferDateShort of the BranchPointCalculationTransaction
    /// TransferDateShort الخاص بـ BranchPointCalculationTransaction
    /// </summary>
    public DateTime? TransferDateShort { get; private set; }

    /// <summary>
    /// CustCode of the BranchPointCalculationTransaction
    /// CustCode الخاص بـ BranchPointCalculationTransaction
    /// </summary>
    public string CustCode { get; private set; }

    /// <summary>
    /// MobileNumber of the BranchPointCalculationTransaction
    /// MobileNumber الخاص بـ BranchPointCalculationTransaction
    /// </summary>
    public string MobileNumber { get; private set; }

    /// <summary>
    /// PointTypeNumber of the BranchPointCalculationTransaction
    /// PointTypeNumber الخاص بـ BranchPointCalculationTransaction
    /// </summary>
    public decimal? PointTypeNumber { get; private set; }

    /// <summary>
    /// BillNumber of the BranchPointCalculationTransaction
    /// BillNumber الخاص بـ BranchPointCalculationTransaction
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// ReturnBillNumberAlt of the BranchPointCalculationTransaction
    /// ReturnBillNumberAlt الخاص بـ BranchPointCalculationTransaction
    /// </summary>
    public decimal? ReturnBillNumberAlt { get; private set; }

    /// <summary>
    /// DocAmt of the BranchPointCalculationTransaction
    /// DocAmt الخاص بـ BranchPointCalculationTransaction
    /// </summary>
    public decimal? DocAmt { get; private set; }

    /// <summary>
    /// AccountCurrency of the BranchPointCalculationTransaction
    /// AccountCurrency الخاص بـ BranchPointCalculationTransaction
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// PointCount of the BranchPointCalculationTransaction
    /// PointCount الخاص بـ BranchPointCalculationTransaction
    /// </summary>
    public decimal? PointCount { get; private set; }

    /// <summary>
    /// TransactionType of the BranchPointCalculationTransaction
    /// TransactionType الخاص بـ BranchPointCalculationTransaction
    /// </summary>
    public decimal? TransactionType { get; private set; }

    /// <summary>
    /// MachineNumber of the BranchPointCalculationTransaction
    /// MachineNumber الخاص بـ BranchPointCalculationTransaction
    /// </summary>
    public decimal? MachineNumber { get; private set; }

    /// <summary>
    /// DocTyp of the BranchPointCalculationTransaction
    /// DocTyp الخاص بـ BranchPointCalculationTransaction
    /// </summary>
    public decimal? DocTyp { get; private set; }

    /// <summary>
    /// DocNo of the BranchPointCalculationTransaction
    /// DocNo الخاص بـ BranchPointCalculationTransaction
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSrl of the BranchPointCalculationTransaction
    /// DocSrl الخاص بـ BranchPointCalculationTransaction
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// AccountRate of the BranchPointCalculationTransaction
    /// AccountRate الخاص بـ BranchPointCalculationTransaction
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// PointAmount of the BranchPointCalculationTransaction
    /// PointAmount الخاص بـ BranchPointCalculationTransaction
    /// </summary>
    public decimal? PointAmount { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchPointCalculationTransaction
    /// ExternalPostFlag الخاص بـ BranchPointCalculationTransaction
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchPointCalculationTransaction
    /// CompanyNumberShort الخاص بـ BranchPointCalculationTransaction
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchPointCalculationTransaction
    /// BranchNumber الخاص بـ BranchPointCalculationTransaction
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchPointCalculationTransaction
    /// BranchYear الخاص بـ BranchPointCalculationTransaction
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchPointCalculationTransaction
    /// BranchUser الخاص بـ BranchPointCalculationTransaction
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ExpireDate of the BranchPointCalculationTransaction
    /// ExpireDate الخاص بـ BranchPointCalculationTransaction
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BillAmount of the BranchPointCalculationTransaction
    /// BillAmount الخاص بـ BranchPointCalculationTransaction
    /// </summary>
    public decimal? BillAmount { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

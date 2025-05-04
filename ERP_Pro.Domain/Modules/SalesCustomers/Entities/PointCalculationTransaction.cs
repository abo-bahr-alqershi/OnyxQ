using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// PointCalculationTransaction Entity
/// </summary>
public class PointCalculationTransaction : Entity<PointCalculationTransactionId>
{

    private PointCalculationTransaction() { }

    public PointCalculationTransaction(PointCalculationTransactionId id, decimal? transactionNumber)
    {
        Id = id;
        TransactionNumber = transactionNumber;
    }

    /// <summary>
    /// The unique identifier for the PointCalculationTransaction
    /// المعرف الفريد لـ PointCalculationTransaction
    /// </summary>
    public PointCalculationTransactionId Id { get; private set; }

    /// <summary>
    /// TransactionNumber of the PointCalculationTransaction
    /// TransactionNumber الخاص بـ PointCalculationTransaction
    /// </summary>
    public decimal? TransactionNumber { get; private set; }

    /// <summary>
    /// TransferDateShort of the PointCalculationTransaction
    /// TransferDateShort الخاص بـ PointCalculationTransaction
    /// </summary>
    public DateTime? TransferDateShort { get; private set; }

    /// <summary>
    /// CustCode of the PointCalculationTransaction
    /// CustCode الخاص بـ PointCalculationTransaction
    /// </summary>
    public string CustCode { get; private set; }

    /// <summary>
    /// MobileNumber of the PointCalculationTransaction
    /// MobileNumber الخاص بـ PointCalculationTransaction
    /// </summary>
    public string MobileNumber { get; private set; }

    /// <summary>
    /// PointTypeNumber of the PointCalculationTransaction
    /// PointTypeNumber الخاص بـ PointCalculationTransaction
    /// </summary>
    public decimal? PointTypeNumber { get; private set; }

    /// <summary>
    /// BillNumber of the PointCalculationTransaction
    /// BillNumber الخاص بـ PointCalculationTransaction
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// ReturnBillNumberAlt of the PointCalculationTransaction
    /// ReturnBillNumberAlt الخاص بـ PointCalculationTransaction
    /// </summary>
    public decimal? ReturnBillNumberAlt { get; private set; }

    /// <summary>
    /// DocAmt of the PointCalculationTransaction
    /// DocAmt الخاص بـ PointCalculationTransaction
    /// </summary>
    public decimal? DocAmt { get; private set; }

    /// <summary>
    /// AccountCurrency of the PointCalculationTransaction
    /// AccountCurrency الخاص بـ PointCalculationTransaction
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// PointCount of the PointCalculationTransaction
    /// PointCount الخاص بـ PointCalculationTransaction
    /// </summary>
    public decimal? PointCount { get; private set; }

    /// <summary>
    /// TransactionType of the PointCalculationTransaction
    /// TransactionType الخاص بـ PointCalculationTransaction
    /// </summary>
    public decimal? TransactionType { get; private set; }

    /// <summary>
    /// MachineNumber of the PointCalculationTransaction
    /// MachineNumber الخاص بـ PointCalculationTransaction
    /// </summary>
    public decimal? MachineNumber { get; private set; }

    /// <summary>
    /// DocTyp of the PointCalculationTransaction
    /// DocTyp الخاص بـ PointCalculationTransaction
    /// </summary>
    public decimal? DocTyp { get; private set; }

    /// <summary>
    /// DocNo of the PointCalculationTransaction
    /// DocNo الخاص بـ PointCalculationTransaction
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSrl of the PointCalculationTransaction
    /// DocSrl الخاص بـ PointCalculationTransaction
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// AccountRate of the PointCalculationTransaction
    /// AccountRate الخاص بـ PointCalculationTransaction
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// PointAmount of the PointCalculationTransaction
    /// PointAmount الخاص بـ PointCalculationTransaction
    /// </summary>
    public decimal? PointAmount { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the PointCalculationTransaction
    /// ExternalPostFlag الخاص بـ PointCalculationTransaction
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PointCalculationTransaction
    /// CompanyNumberShort الخاص بـ PointCalculationTransaction
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the PointCalculationTransaction
    /// BranchNumber الخاص بـ PointCalculationTransaction
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the PointCalculationTransaction
    /// BranchYear الخاص بـ PointCalculationTransaction
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the PointCalculationTransaction
    /// BranchUser الخاص بـ PointCalculationTransaction
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ExpireDate of the PointCalculationTransaction
    /// ExpireDate الخاص بـ PointCalculationTransaction
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BillAmount of the PointCalculationTransaction
    /// BillAmount الخاص بـ PointCalculationTransaction
    /// </summary>
    public decimal? BillAmount { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

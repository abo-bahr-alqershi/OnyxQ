using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// VoucherChequeDetail Entity
/// </summary>
public class VoucherChequeDetail : Entity<VoucherChequeDetailId>
{

    private VoucherChequeDetail() { }

    public VoucherChequeDetail(VoucherChequeDetailId id, decimal? recordNumber)
    {
        Id = id;
        RecordNumber = recordNumber;
    }

    /// <summary>
    /// The unique identifier for the VoucherChequeDetail
    /// المعرف الفريد لـ VoucherChequeDetail
    /// </summary>
    public VoucherChequeDetailId Id { get; private set; }

    /// <summary>
    /// VoucherTypeFull of the VoucherChequeDetail
    /// VoucherTypeFull الخاص بـ VoucherChequeDetail
    /// </summary>
    public decimal? VoucherTypeFull { get; private set; }

    /// <summary>
    /// VoucherNumber of the VoucherChequeDetail
    /// VoucherNumber الخاص بـ VoucherChequeDetail
    /// </summary>
    public decimal? VoucherNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the VoucherChequeDetail
    /// RecordNumber الخاص بـ VoucherChequeDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the VoucherChequeDetail
    /// DocSequence الخاص بـ VoucherChequeDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// CashNumber of the VoucherChequeDetail
    /// CashNumber الخاص بـ VoucherChequeDetail
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// BankNumber of the VoucherChequeDetail
    /// BankNumber الخاص بـ VoucherChequeDetail
    /// </summary>
    public decimal? BankNumber { get; private set; }

    /// <summary>
    /// AccountCode of the VoucherChequeDetail
    /// AccountCode الخاص بـ VoucherChequeDetail
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the VoucherChequeDetail
    /// AccountDetailCode الخاص بـ VoucherChequeDetail
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the VoucherChequeDetail
    /// AccountDetailType الخاص بـ VoucherChequeDetail
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountCurrency of the VoucherChequeDetail
    /// AccountCurrency الخاص بـ VoucherChequeDetail
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// CashBankNumber of the VoucherChequeDetail
    /// CashBankNumber الخاص بـ VoucherChequeDetail
    /// </summary>
    public decimal? CashBankNumber { get; private set; }

    /// <summary>
    /// AccountDescriptionShort of the VoucherChequeDetail
    /// AccountDescriptionShort الخاص بـ VoucherChequeDetail
    /// </summary>
    public string AccountDescriptionShort { get; private set; }

    /// <summary>
    /// AccountAmount of the VoucherChequeDetail
    /// AccountAmount الخاص بـ VoucherChequeDetail
    /// </summary>
    public decimal? AccountAmount { get; private set; }

    /// <summary>
    /// AccountAmountForeign of the VoucherChequeDetail
    /// AccountAmountForeign الخاص بـ VoucherChequeDetail
    /// </summary>
    public decimal? AccountAmountForeign { get; private set; }

    /// <summary>
    /// ExchangeRate of the VoucherChequeDetail
    /// ExchangeRate الخاص بـ VoucherChequeDetail
    /// </summary>
    public decimal? ExchangeRate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the VoucherChequeDetail
    /// CompanyNumberShort الخاص بـ VoucherChequeDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the VoucherChequeDetail
    /// BranchNumber الخاص بـ VoucherChequeDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the VoucherChequeDetail
    /// BranchYear الخاص بـ VoucherChequeDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the VoucherChequeDetail
    /// BranchUser الخاص بـ VoucherChequeDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// DocBrnNo of the VoucherChequeDetail
    /// DocBrnNo الخاص بـ VoucherChequeDetail
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Customer Customer { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public VoucherDetail VoucherDetail { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public VoucherDetails VoucherDetails { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

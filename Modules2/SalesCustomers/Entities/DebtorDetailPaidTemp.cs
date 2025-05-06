using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// DebtorDetailPaidTemp Entity
/// </summary>
public class DebtorDetailPaidTemp : Entity<DebtorDetailPaidTempId>
{

    private DebtorDetailPaidTemp() { }

    public DebtorDetailPaidTemp(DebtorDetailPaidTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the DebtorDetailPaidTemp
    /// المعرف الفريد لـ DebtorDetailPaidTemp
    /// </summary>
    public DebtorDetailPaidTempId Id { get; private set; }

    /// <summary>
    /// ItemNumber of the DebtorDetailPaidTemp
    /// ItemNumber الخاص بـ DebtorDetailPaidTemp
    /// </summary>
    public decimal? ItemNumber { get; private set; }

    /// <summary>
    /// ItemDocumentSerial of the DebtorDetailPaidTemp
    /// ItemDocumentSerial الخاص بـ DebtorDetailPaidTemp
    /// </summary>
    public decimal? ItemDocumentSerial { get; private set; }

    /// <summary>
    /// ItemDocumentDate of the DebtorDetailPaidTemp
    /// ItemDocumentDate الخاص بـ DebtorDetailPaidTemp
    /// </summary>
    public DateTime? ItemDocumentDate { get; private set; }

    /// <summary>
    /// DocType of the DebtorDetailPaidTemp
    /// DocType الخاص بـ DebtorDetailPaidTemp
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// DocNo of the DebtorDetailPaidTemp
    /// DocNo الخاص بـ DebtorDetailPaidTemp
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the DebtorDetailPaidTemp
    /// DocSer الخاص بـ DebtorDetailPaidTemp
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// AccountCurrency of the DebtorDetailPaidTemp
    /// AccountCurrency الخاص بـ DebtorDetailPaidTemp
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// Amount of the DebtorDetailPaidTemp
    /// Amount الخاص بـ DebtorDetailPaidTemp
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// AmountForeign of the DebtorDetailPaidTemp
    /// AmountForeign الخاص بـ DebtorDetailPaidTemp
    /// </summary>
    public decimal? AmountForeign { get; private set; }

    /// <summary>
    /// DocDate of the DebtorDetailPaidTemp
    /// DocDate الخاص بـ DebtorDetailPaidTemp
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// CCode of the DebtorDetailPaidTemp
    /// CCode الخاص بـ DebtorDetailPaidTemp
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// ItemDocumentNumber of the DebtorDetailPaidTemp
    /// ItemDocumentNumber الخاص بـ DebtorDetailPaidTemp
    /// </summary>
    public decimal? ItemDocumentNumber { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}


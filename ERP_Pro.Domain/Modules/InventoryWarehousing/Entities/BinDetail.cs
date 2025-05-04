using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// BinDetail Entity
/// </summary>
public class BinDetail : Entity<BinDetailId>
{

    private BinDetail() { }

    public BinDetail(BinDetailId id, string bankCode)
    {
        Id = id;
        BankCode = bankCode;
    }

    /// <summary>
    /// The unique identifier for the BinDetail
    /// المعرف الفريد لـ BinDetail
    /// </summary>
    public BinDetailId Id { get; private set; }

    /// <summary>
    /// BankCode of the BinDetail
    /// BankCode الخاص بـ BinDetail
    /// </summary>
    public string BankCode { get; private set; }

    /// <summary>
    /// BankNameArabic of the BinDetail
    /// BankNameArabic الخاص بـ BinDetail
    /// </summary>
    public string BankNameArabic { get; private set; }

    /// <summary>
    /// BankNameEnglish of the BinDetail
    /// BankNameEnglish الخاص بـ BinDetail
    /// </summary>
    public string BankNameEnglish { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BinDetail
    /// ExternalPostFlag الخاص بـ BinDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// Cpm of the BinDetail
    /// Cpm الخاص بـ BinDetail
    /// </summary>
    public decimal? Cpm { get; private set; }

    /// <summary>
    /// WeightShort of the BinDetail
    /// WeightShort الخاص بـ BinDetail
    /// </summary>
    public decimal? WeightShort { get; private set; }

    /// <summary>
    /// DefltFlg of the BinDetail
    /// DefltFlg الخاص بـ BinDetail
    /// </summary>
    public decimal? DefltFlg { get; private set; }

    #region Navigation Properties
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

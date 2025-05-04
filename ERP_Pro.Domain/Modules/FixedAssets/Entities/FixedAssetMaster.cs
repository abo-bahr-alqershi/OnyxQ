using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FixedAssets.Entities
{
/// <summary>
/// FixedAssetMaster Entity
/// </summary>
public class FixedAssetMaster : Entity<FixedAssetMasterId>
{

    private FixedAssetMaster() { }

    public FixedAssetMaster(FixedAssetMasterId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the FixedAssetMaster
    /// المعرف الفريد لـ FixedAssetMaster
    /// </summary>
    public FixedAssetMasterId Id { get; private set; }

    /// <summary>
    /// AssetCode of the FixedAssetMaster
    /// AssetCode الخاص بـ FixedAssetMaster
    /// </summary>
    public string AssetCode { get; private set; }

    /// <summary>
    /// EmpNo of the FixedAssetMaster
    /// EmpNo الخاص بـ FixedAssetMaster
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// AssetNameArabic of the FixedAssetMaster
    /// AssetNameArabic الخاص بـ FixedAssetMaster
    /// </summary>
    public string AssetNameArabic { get; private set; }

    /// <summary>
    /// AssetNameEnglish of the FixedAssetMaster
    /// AssetNameEnglish الخاص بـ FixedAssetMaster
    /// </summary>
    public string AssetNameEnglish { get; private set; }

    /// <summary>
    /// EndBlncQty of the FixedAssetMaster
    /// EndBlncQty الخاص بـ FixedAssetMaster
    /// </summary>
    public decimal? EndBlncQty { get; private set; }

    /// <summary>
    /// AssetStatus of the FixedAssetMaster
    /// AssetStatus الخاص بـ FixedAssetMaster
    /// </summary>
    public decimal? AssetStatus { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.SettingsParameters.Entities
{
/// <summary>
/// GroupDetail Entity
/// </summary>
public class GroupDetail : Entity<GroupDetailId>
{

    private GroupDetail() { }

    public GroupDetail(GroupDetailId id, string guarantorCode)
    {
        Id = id;
        GuarantorCode = guarantorCode;
    }

    /// <summary>
    /// The unique identifier for the GroupDetail
    /// المعرف الفريد لـ GroupDetail
    /// </summary>
    public GroupDetailId Id { get; private set; }

    /// <summary>
    /// GuarantorCode of the GroupDetail
    /// GuarantorCode الخاص بـ GroupDetail
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// GuarantorNameArabic of the GroupDetail
    /// GuarantorNameArabic الخاص بـ GroupDetail
    /// </summary>
    public string GuarantorNameArabic { get; private set; }

    /// <summary>
    /// GuarantorNameEnglish of the GroupDetail
    /// GuarantorNameEnglish الخاص بـ GroupDetail
    /// </summary>
    public string GuarantorNameEnglish { get; private set; }

    /// <summary>
    /// GuarantorItemCode of the GroupDetail
    /// GuarantorItemCode الخاص بـ GroupDetail
    /// </summary>
    public string GuarantorItemCode { get; private set; }

    /// <summary>
    /// BranchYear of the GroupDetail
    /// BranchYear الخاص بـ GroupDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GroupDetail
    /// BranchUser الخاص بـ GroupDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// TaxPercentDefault of the GroupDetail
    /// TaxPercentDefault الخاص بـ GroupDetail
    /// </summary>
    public decimal? TaxPercentDefault { get; private set; }

    /// <summary>
    /// SynchronizeToWebFlag of the GroupDetail
    /// SynchronizeToWebFlag الخاص بـ GroupDetail
    /// </summary>
    public decimal? SynchronizeToWebFlag { get; private set; }

    /// <summary>
    /// UseSalePriceAsPurchasePrice of the GroupDetail
    /// UseSalePriceAsPurchasePrice الخاص بـ GroupDetail
    /// </summary>
    public decimal? UseSalePriceAsPurchasePrice { get; private set; }

    /// <summary>
    /// RollLimitQuantity of the GroupDetail
    /// RollLimitQuantity الخاص بـ GroupDetail
    /// </summary>
    public decimal? RollLimitQuantity { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

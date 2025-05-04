using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// SubGroupDetail Entity
/// </summary>
public class SubGroupDetail : Entity<SubGroupDetailId>
{

    private SubGroupDetail() { }

    public SubGroupDetail(SubGroupDetailId id, string subGroupCode)
    {
        Id = id;
        SubGroupCode = subGroupCode;
    }

    /// <summary>
    /// The unique identifier for the SubGroupDetail
    /// المعرف الفريد لـ SubGroupDetail
    /// </summary>
    public SubGroupDetailId Id { get; private set; }

    /// <summary>
    /// GuarantorCode of the SubGroupDetail
    /// GuarantorCode الخاص بـ SubGroupDetail
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// ManagerCode of the SubGroupDetail
    /// ManagerCode الخاص بـ SubGroupDetail
    /// </summary>
    public string ManagerCode { get; private set; }

    /// <summary>
    /// SubGroupCode of the SubGroupDetail
    /// SubGroupCode الخاص بـ SubGroupDetail
    /// </summary>
    public string SubGroupCode { get; private set; }

    /// <summary>
    /// SubGroupNameArabic of the SubGroupDetail
    /// SubGroupNameArabic الخاص بـ SubGroupDetail
    /// </summary>
    public string SubGroupNameArabic { get; private set; }

    /// <summary>
    /// SubGroupNameEnglish of the SubGroupDetail
    /// SubGroupNameEnglish الخاص بـ SubGroupDetail
    /// </summary>
    public string SubGroupNameEnglish { get; private set; }

    /// <summary>
    /// SubGroupItemCode of the SubGroupDetail
    /// SubGroupItemCode الخاص بـ SubGroupDetail
    /// </summary>
    public string SubGroupItemCode { get; private set; }

    /// <summary>
    /// SynchronizeToWebFlag of the SubGroupDetail
    /// SynchronizeToWebFlag الخاص بـ SubGroupDetail
    /// </summary>
    public decimal? SynchronizeToWebFlag { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

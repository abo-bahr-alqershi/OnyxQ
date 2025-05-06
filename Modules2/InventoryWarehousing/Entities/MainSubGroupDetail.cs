using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SettingsParameters.Entities;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// MainSubGroupDetail Entity
/// </summary>
public class MainSubGroupDetail : Entity<MainSubGroupDetailId>
{

    private MainSubGroupDetail() { }

    public MainSubGroupDetail(MainSubGroupDetailId id, string managerCode)
    {
        Id = id;
        ManagerCode = managerCode;
    }

    /// <summary>
    /// The unique identifier for the MainSubGroupDetail
    /// المعرف الفريد لـ MainSubGroupDetail
    /// </summary>
    public MainSubGroupDetailId Id { get; private set; }

    /// <summary>
    /// ManagerCode of the MainSubGroupDetail
    /// ManagerCode الخاص بـ MainSubGroupDetail
    /// </summary>
    public string ManagerCode { get; private set; }

    /// <summary>
    /// ManagerNameArabic of the MainSubGroupDetail
    /// ManagerNameArabic الخاص بـ MainSubGroupDetail
    /// </summary>
    public string ManagerNameArabic { get; private set; }

    /// <summary>
    /// ManagerNameEnglish of the MainSubGroupDetail
    /// ManagerNameEnglish الخاص بـ MainSubGroupDetail
    /// </summary>
    public string ManagerNameEnglish { get; private set; }

    /// <summary>
    /// ManagerItemCode of the MainSubGroupDetail
    /// ManagerItemCode الخاص بـ MainSubGroupDetail
    /// </summary>
    public string ManagerItemCode { get; private set; }

    /// <summary>
    /// SynchronizeToWebFlag of the MainSubGroupDetail
    /// SynchronizeToWebFlag الخاص بـ MainSubGroupDetail
    /// </summary>
    public decimal? SynchronizeToWebFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public GroupDetail GroupDetail { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}


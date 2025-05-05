using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;
namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// UserLoginHistory Entity
/// </summary>
public class UserLoginHistory : Entity<UserLoginHistoryId>
{

    private UserLoginHistory() { }

    public UserLoginHistory(UserLoginHistoryId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the UserLoginHistory
    /// المعرف الفريد لـ UserLoginHistory
    /// </summary>
    public UserLoginHistoryId Id { get; private set; }

    /// <summary>
    /// UserId of the UserLoginHistory
    /// UserId الخاص بـ UserLoginHistory
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// TerminalNameShort of the UserLoginHistory
    /// TerminalNameShort الخاص بـ UserLoginHistory
    /// </summary>
    public string TerminalNameShort { get; private set; }

    /// <summary>
    /// LoginType of the UserLoginHistory
    /// LoginType الخاص بـ UserLoginHistory
    /// </summary>
    public decimal? LoginType { get; private set; }

    /// <summary>
    /// LoginOutDate of the UserLoginHistory
    /// LoginOutDate الخاص بـ UserLoginHistory
    /// </summary>
    public DateTime? LoginOutDate { get; private set; }

    /// <summary>
    /// LanguageNumber of the UserLoginHistory
    /// LanguageNumber الخاص بـ UserLoginHistory
    /// </summary>
    public decimal? LanguageNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the UserLoginHistory
    /// CompanyNumberShort الخاص بـ UserLoginHistory
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the UserLoginHistory
    /// BranchNumber الخاص بـ UserLoginHistory
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the UserLoginHistory
    /// BranchYear الخاص بـ UserLoginHistory
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the UserLoginHistory
    /// BranchUser الخاص بـ UserLoginHistory
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ApplicationNumber of the UserLoginHistory
    /// ApplicationNumber الخاص بـ UserLoginHistory
    /// </summary>
    public decimal? ApplicationNumber { get; private set; }

    /// <summary>
    /// HistoryNumber of the UserLoginHistory
    /// HistoryNumber الخاص بـ UserLoginHistory
    /// </summary>
    public decimal? HistoryNumber { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}


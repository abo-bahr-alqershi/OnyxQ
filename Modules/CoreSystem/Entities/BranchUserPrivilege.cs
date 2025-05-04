using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// BranchUserPrivilege Entity
/// </summary>
public class BranchUserPrivilege : Entity<BranchUserPrivilegeId>
{
    private BranchUserPrivilege() { }

    /// <summary>
    /// The unique identifier for the BranchUserPrivilege
    /// المعرف الفريد لـ BranchUserPrivilege
    /// </summary>
    public BranchUserPrivilegeId Id { get; private set; }

    /// <summary>
    /// UserId of the BranchUserPrivilege
    /// UserId الخاص بـ BranchUserPrivilege
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchUserPrivilege
    /// BranchNumber الخاص بـ BranchUserPrivilege
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// AdditionalFlag of the BranchUserPrivilege
    /// AdditionalFlag الخاص بـ BranchUserPrivilege
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the BranchUserPrivilege
    /// ViewFlag الخاص بـ BranchUserPrivilege
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    /// <summary>
    /// FillFlag of the BranchUserPrivilege
    /// FillFlag الخاص بـ BranchUserPrivilege
    /// </summary>
    public decimal? FillFlag { get; private set; }

    /// <summary>
    /// AdditionalBenefitFlag of the BranchUserPrivilege
    /// AdditionalBenefitFlag الخاص بـ BranchUserPrivilege
    /// </summary>
    public decimal? AdditionalBenefitFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Branch
    /// </summary>
    public Branch Branch { get; private set; }
    /// <summary>
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    #endregion
}
}

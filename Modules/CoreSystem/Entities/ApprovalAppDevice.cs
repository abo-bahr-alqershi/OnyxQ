using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.HumanResources.Entities;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// ApprovalAppDevice Entity
/// </summary>
public class ApprovalAppDevice : Entity<ApprovalAppDeviceId>
{
    private ApprovalAppDevice() { }

    /// <summary>
    /// The unique identifier for the ApprovalAppDevice
    /// المعرف الفريد لـ ApprovalAppDevice
    /// </summary>
    public ApprovalAppDeviceId Id { get; private set; }

    /// <summary>
    /// DocNo of the ApprovalAppDevice
    /// DocNo الخاص بـ ApprovalAppDevice
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocDate of the ApprovalAppDevice
    /// DocDate الخاص بـ ApprovalAppDevice
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// UserTypeShort of the ApprovalAppDevice
    /// UserTypeShort الخاص بـ ApprovalAppDevice
    /// </summary>
    public decimal? UserTypeShort { get; private set; }

    /// <summary>
    /// SystemNumber of the ApprovalAppDevice
    /// SystemNumber الخاص بـ ApprovalAppDevice
    /// </summary>
    public decimal? SystemNumber { get; private set; }

    /// <summary>
    /// ModifyId of the ApprovalAppDevice
    /// ModifyId الخاص بـ ApprovalAppDevice
    /// </summary>
    public string ModifyId { get; private set; }

    /// <summary>
    /// EmpNo of the ApprovalAppDevice
    /// EmpNo الخاص بـ ApprovalAppDevice
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// UserId of the ApprovalAppDevice
    /// UserId الخاص بـ ApprovalAppDevice
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// CCode of the ApprovalAppDevice
    /// CCode الخاص بـ ApprovalAppDevice
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// MobileOs of the ApprovalAppDevice
    /// MobileOs الخاص بـ ApprovalAppDevice
    /// </summary>
    public string MobileOs { get; private set; }

    /// <summary>
    /// MobileSerial of the ApprovalAppDevice
    /// MobileSerial الخاص بـ ApprovalAppDevice
    /// </summary>
    public string MobileSerial { get; private set; }

    /// <summary>
    /// ApprovedFlag of the ApprovalAppDevice
    /// ApprovedFlag الخاص بـ ApprovalAppDevice
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the ApprovalAppDevice
    /// ApprovalUserId الخاص بـ ApprovalAppDevice
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the ApprovalAppDevice
    /// ApprovalDate الخاص بـ ApprovalAppDevice
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the ApprovalAppDevice
    /// ApprovalDescription الخاص بـ ApprovalAppDevice
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// BranchYear of the ApprovalAppDevice
    /// BranchYear الخاص بـ ApprovalAppDevice
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ApprovalAppDevice
    /// BranchUser الخاص بـ ApprovalAppDevice
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Employee
    /// </summary>
    public Employee Employee { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Customer
    /// </summary>
    public Customer Customer { get; private set; }
    /// <summary>
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    #endregion
}
}

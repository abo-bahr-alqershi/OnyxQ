using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// BillFollowupMovement Entity
/// </summary>
public class BillFollowupMovement : Entity<BillFollowupMovementId>
{
    private BillFollowupMovement() { }

    /// <summary>
    /// The unique identifier for the BillFollowupMovement
    /// المعرف الفريد لـ BillFollowupMovement
    /// </summary>
    public BillFollowupMovementId Id { get; private set; }

    /// <summary>
    /// TransactionTypeShort of the BillFollowupMovement
    /// TransactionTypeShort الخاص بـ BillFollowupMovement
    /// </summary>
    public decimal? TransactionTypeShort { get; private set; }

    /// <summary>
    /// TransactionNumber of the BillFollowupMovement
    /// TransactionNumber الخاص بـ BillFollowupMovement
    /// </summary>
    public decimal? TransactionNumber { get; private set; }

    /// <summary>
    /// DocNo of the BillFollowupMovement
    /// DocNo الخاص بـ BillFollowupMovement
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the BillFollowupMovement
    /// DocSer الخاص بـ BillFollowupMovement
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// ConfirmType of the BillFollowupMovement
    /// ConfirmType الخاص بـ BillFollowupMovement
    /// </summary>
    public decimal? ConfirmType { get; private set; }

    /// <summary>
    /// ConfirmUserId of the BillFollowupMovement
    /// ConfirmUserId الخاص بـ BillFollowupMovement
    /// </summary>
    public decimal? ConfirmUserId { get; private set; }

    /// <summary>
    /// ConfirmDate of the BillFollowupMovement
    /// ConfirmDate الخاص بـ BillFollowupMovement
    /// </summary>
    public DateTime? ConfirmDate { get; private set; }

    /// <summary>
    /// ConfirmDescriptionShort of the BillFollowupMovement
    /// ConfirmDescriptionShort الخاص بـ BillFollowupMovement
    /// </summary>
    public string ConfirmDescriptionShort { get; private set; }

    /// <summary>
    /// OrderNumberShort of the BillFollowupMovement
    /// OrderNumberShort الخاص بـ BillFollowupMovement
    /// </summary>
    public decimal? OrderNumberShort { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BillFollowupMovement
    /// CompanyNumberShort الخاص بـ BillFollowupMovement
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BillFollowupMovement
    /// BranchNumber الخاص بـ BillFollowupMovement
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BillFollowupMovement
    /// BranchYear الخاص بـ BillFollowupMovement
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BillFollowupMovement
    /// BranchUser الخاص بـ BillFollowupMovement
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// DriverNo of the BillFollowupMovement
    /// DriverNo الخاص بـ BillFollowupMovement
    /// </summary>
    public decimal? DriverNo { get; private set; }

    /// <summary>
    /// ReceiveInvoiceDate of the BillFollowupMovement
    /// ReceiveInvoiceDate الخاص بـ BillFollowupMovement
    /// </summary>
    public DateTime? ReceiveInvoiceDate { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    #endregion
}
}

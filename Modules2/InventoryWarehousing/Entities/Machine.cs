using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// Machine Entity
/// </summary>
public class Machine : Entity<MachineId>
{

    private Machine() { }

    public Machine(MachineId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the Machine
    /// المعرف الفريد لـ Machine
    /// </summary>
    public MachineId Id { get; private set; }

    /// <summary>
    /// MachineNumber of the Machine
    /// MachineNumber الخاص بـ Machine
    /// </summary>
    public decimal? MachineNumber { get; private set; }

    /// <summary>
    /// BankAccount of the Machine
    /// BankAccount الخاص بـ Machine
    /// </summary>
    public string BankAccount { get; private set; }

    /// <summary>
    /// CommissionAccount of the Machine
    /// CommissionAccount الخاص بـ Machine
    /// </summary>
    public string CommissionAccount { get; private set; }

    /// <summary>
    /// InactiveFlag of the Machine
    /// InactiveFlag الخاص بـ Machine
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the Machine
    /// InactiveReason الخاص بـ Machine
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the Machine
    /// InactiveDate الخاص بـ Machine
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the Machine
    /// InactivatedByUserId الخاص بـ Machine
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// AccountReceiptLetter of the Machine
    /// AccountReceiptLetter الخاص بـ Machine
    /// </summary>
    public string AccountReceiptLetter { get; private set; }

    /// <summary>
    /// BankNumber of the Machine
    /// BankNumber الخاص بـ Machine
    /// </summary>
    public decimal? BankNumber { get; private set; }

    /// <summary>
    /// ConnectionBranchNumber of the Machine
    /// ConnectionBranchNumber الخاص بـ Machine
    /// </summary>
    public decimal? ConnectionBranchNumber { get; private set; }

    /// <summary>
    /// ConnectionTerminalName of the Machine
    /// ConnectionTerminalName الخاص بـ Machine
    /// </summary>
    public string ConnectionTerminalName { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: OneToOne
    /// </summary>
    public Machine Machine { get; private set; }
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


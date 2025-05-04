using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.HumanResources.Entities
{
/// <summary>
/// EmployeeRelativeTickets Entity
/// </summary>
public class EmployeeRelativeTickets : Entity<EmployeeRelativeTicketsId>
{
    private EmployeeRelativeTickets() { }

    /// <summary>
    /// The unique identifier for the EmployeeRelativeTickets
    /// المعرف الفريد لـ EmployeeRelativeTickets
    /// </summary>
    public EmployeeRelativeTicketsId Id { get; private set; }

    /// <summary>
    /// EmpNo of the EmployeeRelativeTickets
    /// EmpNo الخاص بـ EmployeeRelativeTickets
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// RelationshipNumber of the EmployeeRelativeTickets
    /// RelationshipNumber الخاص بـ EmployeeRelativeTickets
    /// </summary>
    public decimal? RelationshipNumber { get; private set; }

    /// <summary>
    /// TicketType of the EmployeeRelativeTickets
    /// TicketType الخاص بـ EmployeeRelativeTickets
    /// </summary>
    public decimal? TicketType { get; private set; }

    /// <summary>
    /// TicketCount of the EmployeeRelativeTickets
    /// TicketCount الخاص بـ EmployeeRelativeTickets
    /// </summary>
    public decimal? TicketCount { get; private set; }

    /// <summary>
    /// TicketPrice of the EmployeeRelativeTickets
    /// TicketPrice الخاص بـ EmployeeRelativeTickets
    /// </summary>
    public decimal? TicketPrice { get; private set; }

    /// <summary>
    /// TicketEmployeeRatio of the EmployeeRelativeTickets
    /// TicketEmployeeRatio الخاص بـ EmployeeRelativeTickets
    /// </summary>
    public decimal? TicketEmployeeRatio { get; private set; }

    /// <summary>
    /// CurCode of the EmployeeRelativeTickets
    /// CurCode الخاص بـ EmployeeRelativeTickets
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// TicketDescription of the EmployeeRelativeTickets
    /// TicketDescription الخاص بـ EmployeeRelativeTickets
    /// </summary>
    public string TicketDescription { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Employee
    /// </summary>
    public Employee Employee { get; private set; }
    #endregion
}
}

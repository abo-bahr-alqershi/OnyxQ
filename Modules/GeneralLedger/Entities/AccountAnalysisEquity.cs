using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// AccountAnalysisEquity Entity
/// </summary>
public class AccountAnalysisEquity : Entity<AccountAnalysisEquityId>
{
    private AccountAnalysisEquity() { }

    /// <summary>
    /// The unique identifier for the AccountAnalysisEquity
    /// المعرف الفريد لـ AccountAnalysisEquity
    /// </summary>
    public AccountAnalysisEquityId Id { get; private set; }

    /// <summary>
    /// EquipmentNumber of the AccountAnalysisEquity
    /// EquipmentNumber الخاص بـ AccountAnalysisEquity
    /// </summary>
    public decimal? EquipmentNumber { get; private set; }

    /// <summary>
    /// EquipmentLastName of the AccountAnalysisEquity
    /// EquipmentLastName الخاص بـ AccountAnalysisEquity
    /// </summary>
    public string EquipmentLastName { get; private set; }

    /// <summary>
    /// EquipmentFirstName of the AccountAnalysisEquity
    /// EquipmentFirstName الخاص بـ AccountAnalysisEquity
    /// </summary>
    public string EquipmentFirstName { get; private set; }

    /// <summary>
    /// EquipmentSyntax of the AccountAnalysisEquity
    /// EquipmentSyntax الخاص بـ AccountAnalysisEquity
    /// </summary>
    public string EquipmentSyntax { get; private set; }

    /// <summary>
    /// EquipmentDescription of the AccountAnalysisEquity
    /// EquipmentDescription الخاص بـ AccountAnalysisEquity
    /// </summary>
    public string EquipmentDescription { get; private set; }

    /// <summary>
    /// EquipmentFullDescription of the AccountAnalysisEquity
    /// EquipmentFullDescription الخاص بـ AccountAnalysisEquity
    /// </summary>
    public string EquipmentFullDescription { get; private set; }

    /// <summary>
    /// EquipmentOrder of the AccountAnalysisEquity
    /// EquipmentOrder الخاص بـ AccountAnalysisEquity
    /// </summary>
    public decimal? EquipmentOrder { get; private set; }
}
}

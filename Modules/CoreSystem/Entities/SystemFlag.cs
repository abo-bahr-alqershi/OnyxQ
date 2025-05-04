using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// SystemFlag Entity
/// </summary>
public class SystemFlag : Entity<SystemFlagId>
{
    private SystemFlag() { }

    /// <summary>
    /// The unique identifier for the SystemFlag
    /// المعرف الفريد لـ SystemFlag
    /// </summary>
    public SystemFlagId Id { get; private set; }

    /// <summary>
    /// LanguageNumber of the SystemFlag
    /// LanguageNumber الخاص بـ SystemFlag
    /// </summary>
    public decimal? LanguageNumber { get; private set; }

    /// <summary>
    /// FlagSerial of the SystemFlag
    /// FlagSerial الخاص بـ SystemFlag
    /// </summary>
    public decimal? FlagSerial { get; private set; }

    /// <summary>
    /// FlagValue of the SystemFlag
    /// FlagValue الخاص بـ SystemFlag
    /// </summary>
    public decimal? FlagValue { get; private set; }

    /// <summary>
    /// FlagCode of the SystemFlag
    /// FlagCode الخاص بـ SystemFlag
    /// </summary>
    public string FlagCode { get; private set; }

    /// <summary>
    /// FlagDescription of the SystemFlag
    /// FlagDescription الخاص بـ SystemFlag
    /// </summary>
    public string FlagDescription { get; private set; }

    /// <summary>
    /// FlagStatus of the SystemFlag
    /// FlagStatus الخاص بـ SystemFlag
    /// </summary>
    public decimal? FlagStatus { get; private set; }

    /// <summary>
    /// FlagPrivilege of the SystemFlag
    /// FlagPrivilege الخاص بـ SystemFlag
    /// </summary>
    public decimal? FlagPrivilege { get; private set; }

    /// <summary>
    /// LabelNumberShort of the SystemFlag
    /// LabelNumberShort الخاص بـ SystemFlag
    /// </summary>
    public decimal? LabelNumberShort { get; private set; }
}
}

using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// SequenceControl Entity
/// </summary>
public class SequenceControl : Entity<SequenceControlId>
{
    private SequenceControl() { }

    /// <summary>
    /// The unique identifier for the SequenceControl
    /// المعرف الفريد لـ SequenceControl
    /// </summary>
    public SequenceControlId Id { get; private set; }

    /// <summary>
    /// STableName of the SequenceControl
    /// STableName الخاص بـ SequenceControl
    /// </summary>
    public string STableName { get; private set; }

    /// <summary>
    /// SColumnName of the SequenceControl
    /// SColumnName الخاص بـ SequenceControl
    /// </summary>
    public string SColumnName { get; private set; }

    /// <summary>
    /// SSequenceType of the SequenceControl
    /// SSequenceType الخاص بـ SequenceControl
    /// </summary>
    public decimal? SSequenceType { get; private set; }

    /// <summary>
    /// SColumn1 of the SequenceControl
    /// SColumn1 الخاص بـ SequenceControl
    /// </summary>
    public string SColumn1 { get; private set; }

    /// <summary>
    /// SColumn2 of the SequenceControl
    /// SColumn2 الخاص بـ SequenceControl
    /// </summary>
    public string SColumn2 { get; private set; }

    /// <summary>
    /// SColumn3 of the SequenceControl
    /// SColumn3 الخاص بـ SequenceControl
    /// </summary>
    public string SColumn3 { get; private set; }

    /// <summary>
    /// SColumn4 of the SequenceControl
    /// SColumn4 الخاص بـ SequenceControl
    /// </summary>
    public string SColumn4 { get; private set; }

    /// <summary>
    /// SColumn5 of the SequenceControl
    /// SColumn5 الخاص بـ SequenceControl
    /// </summary>
    public string SColumn5 { get; private set; }

    /// <summary>
    /// SColumn6 of the SequenceControl
    /// SColumn6 الخاص بـ SequenceControl
    /// </summary>
    public string SColumn6 { get; private set; }

    /// <summary>
    /// SIncreaseByValue of the SequenceControl
    /// SIncreaseByValue الخاص بـ SequenceControl
    /// </summary>
    public decimal? SIncreaseByValue { get; private set; }

    /// <summary>
    /// SInitialValue of the SequenceControl
    /// SInitialValue الخاص بـ SequenceControl
    /// </summary>
    public decimal? SInitialValue { get; private set; }

    /// <summary>
    /// SSequenceConcat of the SequenceControl
    /// SSequenceConcat الخاص بـ SequenceControl
    /// </summary>
    public string SSequenceConcat { get; private set; }

    /// <summary>
    /// TriggerName of the SequenceControl
    /// TriggerName الخاص بـ SequenceControl
    /// </summary>
    public string TriggerName { get; private set; }

    /// <summary>
    /// OnlyIfNullFlag of the SequenceControl
    /// OnlyIfNullFlag الخاص بـ SequenceControl
    /// </summary>
    public decimal? OnlyIfNullFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the SequenceControl
    /// CompanyNumberShort الخاص بـ SequenceControl
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the SequenceControl
    /// BranchNumber الخاص بـ SequenceControl
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the SequenceControl
    /// BranchYear الخاص بـ SequenceControl
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the SequenceControl
    /// BranchUser الخاص بـ SequenceControl
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}

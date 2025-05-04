using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// SequenceValue Entity
/// </summary>
public class SequenceValue : Entity<SequenceValueId>
{
    private SequenceValue() { }

    /// <summary>
    /// The unique identifier for the SequenceValue
    /// المعرف الفريد لـ SequenceValue
    /// </summary>
    public SequenceValueId Id { get; private set; }

    /// <summary>
    /// STableName of the SequenceValue
    /// STableName الخاص بـ SequenceValue
    /// </summary>
    public string STableName { get; private set; }

    /// <summary>
    /// SColumnName of the SequenceValue
    /// SColumnName الخاص بـ SequenceValue
    /// </summary>
    public string SColumnName { get; private set; }

    /// <summary>
    /// SValue1 of the SequenceValue
    /// SValue1 الخاص بـ SequenceValue
    /// </summary>
    public decimal? SValue1 { get; private set; }

    /// <summary>
    /// SValue2 of the SequenceValue
    /// SValue2 الخاص بـ SequenceValue
    /// </summary>
    public decimal? SValue2 { get; private set; }

    /// <summary>
    /// SValue3 of the SequenceValue
    /// SValue3 الخاص بـ SequenceValue
    /// </summary>
    public decimal? SValue3 { get; private set; }

    /// <summary>
    /// SValue4 of the SequenceValue
    /// SValue4 الخاص بـ SequenceValue
    /// </summary>
    public decimal? SValue4 { get; private set; }

    /// <summary>
    /// SValue5 of the SequenceValue
    /// SValue5 الخاص بـ SequenceValue
    /// </summary>
    public decimal? SValue5 { get; private set; }

    /// <summary>
    /// SValue6 of the SequenceValue
    /// SValue6 الخاص بـ SequenceValue
    /// </summary>
    public decimal? SValue6 { get; private set; }

    /// <summary>
    /// SIncreaseByValue of the SequenceValue
    /// SIncreaseByValue الخاص بـ SequenceValue
    /// </summary>
    public decimal? SIncreaseByValue { get; private set; }

    /// <summary>
    /// SInitialValue of the SequenceValue
    /// SInitialValue الخاص بـ SequenceValue
    /// </summary>
    public decimal? SInitialValue { get; private set; }

    /// <summary>
    /// SSequenceValue of the SequenceValue
    /// SSequenceValue الخاص بـ SequenceValue
    /// </summary>
    public decimal? SSequenceValue { get; private set; }

    /// <summary>
    /// SSequenceType of the SequenceValue
    /// SSequenceType الخاص بـ SequenceValue
    /// </summary>
    public decimal? SSequenceType { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the SequenceValue
    /// CompanyNumberShort الخاص بـ SequenceValue
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the SequenceValue
    /// BranchNumber الخاص بـ SequenceValue
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the SequenceValue
    /// BranchYear الخاص بـ SequenceValue
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the SequenceValue
    /// BranchUser الخاص بـ SequenceValue
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}

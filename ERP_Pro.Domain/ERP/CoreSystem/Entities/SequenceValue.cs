using System;
using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a sequence value entity in the system.
/// يمثل كيان قيمة التسلسل في النظام
/// </summary>
public sealed class SequenceValue : AggregateRoot<SequenceValueId>
{
    /// <summary>
    /// Gets the table name.
    /// اسم الجدول
    /// </summary>
    public string TableName { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the column name.
    /// اسم العمود
    /// </summary>
    public string ColumnName { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the first value.
    /// القيمة الأولى
    /// </summary>
    public long Value1 { get; private set; }

    /// <summary>
    /// Gets the second value.
    /// القيمة الثانية
    /// </summary>
    public long Value2 { get; private set; }

    /// <summary>
    /// Gets the third value.
    /// القيمة الثالثة
    /// </summary>
    public long Value3 { get; private set; }

    /// <summary>
    /// Gets the fourth value.
    /// القيمة الرابعة
    /// </summary>
    public long Value4 { get; private set; }

    /// <summary>
    /// Gets the fifth value.
    /// القيمة الخامسة
    /// </summary>
    public long Value5 { get; private set; }

    /// <summary>
    /// Gets the sixth value.
    /// القيمة السادسة
    /// </summary>
    public long Value6 { get; private set; }

    /// <summary>
    /// Gets the increment by value.
    /// قيمة الزيادة
    /// </summary>
    public int IncrementByValue { get; private set; }

    /// <summary>
    /// Gets the initial value.
    /// القيمة الأولية
    /// </summary>
    public int InitialValue { get; private set; }

    /// <summary>
    /// Gets the sequence value.
    /// قيمة التسلسل
    /// </summary>
    public long SequenceValue { get; private set; }

    /// <summary>
    /// Gets the sequence type.
    /// نوع التسلسل
    /// </summary>
    public int SequenceType { get; private set; }

    /// <summary>
    /// Gets the company number.
    /// رقم الشركة
    /// </summary>
    public int CompanyNumber { get; private set; }

    /// <summary>
    /// Gets the branch number.
    /// رقم الفرع
    /// </summary>
    public int BranchNumber { get; private set; }

    /// <summary>
    /// Gets the branch year.
    /// سنة الفرع
    /// </summary>
    public int BranchYear { get; private set; }

    /// <summary>
    /// Gets the branch user number.
    /// رقم مستخدم الفرع
    /// </summary>
    public int BranchUserNumber { get; private set; }

    /// <summary>
    /// Gets the terminal name where the record was added.
    /// اسم الطرفية التي تمت إضافة السجل منها
    /// </summary>
    public string AddedTerminalName { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the terminal name where the record was last updated.
    /// اسم الطرفية التي تم تحديث السجل منها
    /// </summary>
    public string UpdatedTerminalName { get; private set; } = string.Empty;

    private SequenceValue() { }

    private SequenceValue(
        SequenceValueId id,
        string tableName,
        string columnName,
        long value1,
        long value2,
        long value3,
        long value4,
        long value5,
        long value6,
        int incrementByValue,
        int initialValue,
        long sequenceValue,
        int sequenceType,
        int companyNumber,
        int branchNumber,
        int branchYear,
        int branchUserNumber,
        string addedTerminalName,
        string updatedTerminalName)
        : base(id)
    {
        TableName = tableName;
        ColumnName = columnName;
        Value1 = value1;
        Value2 = value2;
        Value3 = value3;
        Value4 = value4;
        Value5 = value5;
        Value6 = value6;
        IncrementByValue = incrementByValue;
        InitialValue = initialValue;
        SequenceValue = sequenceValue;
        SequenceType = sequenceType;
        CompanyNumber = companyNumber;
        BranchNumber = branchNumber;
        BranchYear = branchYear;
        BranchUserNumber = branchUserNumber;
        AddedTerminalName = addedTerminalName;
        UpdatedTerminalName = updatedTerminalName;
    }

    public static SequenceValue Create(
        string tableName,
        string columnName,
        long value1,
        long value2,
        long value3,
        long value4,
        long value5,
        long value6,
        int incrementByValue,
        int initialValue,
        long sequenceValue,
        int sequenceType,
        int companyNumber,
        int branchNumber,
        int branchYear,
        int branchUserNumber,
        string addedTerminalName)
    {
        var sequence = new SequenceValue(
            SequenceValueId.CreateUnique(),
            tableName,
            columnName,
            value1,
            value2,
            value3,
            value4,
            value5,
            value6,
            incrementByValue,
            initialValue,
            sequenceValue,
            sequenceType,
            companyNumber,
            branchNumber,
            branchYear,
            branchUserNumber,
            addedTerminalName,
            addedTerminalName);

        sequence.RaiseDomainEvent(new SequenceValueCreatedEvent(sequence));

        return sequence;
    }

    public void Update(
        long value1,
        long value2,
        long value3,
        long value4,
        long value5,
        long value6,
        int incrementByValue,
        int initialValue,
        long sequenceValue,
        int sequenceType,
        string updatedTerminalName)
    {
        Value1 = value1;
        Value2 = value2;
        Value3 = value3;
        Value4 = value4;
        Value5 = value5;
        Value6 = value6;
        IncrementByValue = incrementByValue;
        InitialValue = initialValue;
        SequenceValue = sequenceValue;
        SequenceType = sequenceType;
        UpdatedTerminalName = updatedTerminalName;

        RaiseDomainEvent(new SequenceValueUpdatedEvent(this));
    }
} 
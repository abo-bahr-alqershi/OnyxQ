using System;
using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a sequence control entity in the system.
/// يمثل كيان التحكم في التسلسل في النظام
/// </summary>
public sealed class SequenceControl : AggregateRoot<SequenceControlId>
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
    /// Gets the sequence type.
    /// نوع التسلسل
    /// </summary>
    public int SequenceType { get; private set; }

    /// <summary>
    /// Gets the first column name.
    /// اسم العمود الأول
    /// </summary>
    public string Column1 { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the second column name.
    /// اسم العمود الثاني
    /// </summary>
    public string Column2 { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the third column name.
    /// اسم العمود الثالث
    /// </summary>
    public string Column3 { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the fourth column name.
    /// اسم العمود الرابع
    /// </summary>
    public string Column4 { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the fifth column name.
    /// اسم العمود الخامس
    /// </summary>
    public string Column5 { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the sixth column name.
    /// اسم العمود السادس
    /// </summary>
    public string Column6 { get; private set; } = string.Empty;

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
    /// Gets the sequence concatenation.
    /// تسلسل الربط
    /// </summary>
    public string SequenceConcatenation { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the trigger name.
    /// اسم المشغل
    /// </summary>
    public string TriggerName { get; private set; } = string.Empty;

    /// <summary>
    /// Gets a value indicating whether to only update if null.
    /// يحدد ما إذا كان يجب التحديث فقط إذا كانت القيمة فارغة
    /// </summary>
    public bool OnlyIfNull { get; private set; }

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

    private SequenceControl() { }

    private SequenceControl(
        SequenceControlId id,
        string tableName,
        string columnName,
        int sequenceType,
        string column1,
        string column2,
        string column3,
        string column4,
        string column5,
        string column6,
        int incrementByValue,
        int initialValue,
        string sequenceConcatenation,
        string triggerName,
        bool onlyIfNull,
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
        SequenceType = sequenceType;
        Column1 = column1;
        Column2 = column2;
        Column3 = column3;
        Column4 = column4;
        Column5 = column5;
        Column6 = column6;
        IncrementByValue = incrementByValue;
        InitialValue = initialValue;
        SequenceConcatenation = sequenceConcatenation;
        TriggerName = triggerName;
        OnlyIfNull = onlyIfNull;
        CompanyNumber = companyNumber;
        BranchNumber = branchNumber;
        BranchYear = branchYear;
        BranchUserNumber = branchUserNumber;
        AddedTerminalName = addedTerminalName;
        UpdatedTerminalName = updatedTerminalName;
    }

    public static SequenceControl Create(
        string tableName,
        string columnName,
        int sequenceType,
        string column1,
        string column2,
        string column3,
        string column4,
        string column5,
        string column6,
        int incrementByValue,
        int initialValue,
        string sequenceConcatenation,
        string triggerName,
        bool onlyIfNull,
        int companyNumber,
        int branchNumber,
        int branchYear,
        int branchUserNumber,
        string addedTerminalName)
    {
        var sequenceControl = new SequenceControl(
            SequenceControlId.CreateUnique(),
            tableName,
            columnName,
            sequenceType,
            column1,
            column2,
            column3,
            column4,
            column5,
            column6,
            incrementByValue,
            initialValue,
            sequenceConcatenation,
            triggerName,
            onlyIfNull,
            companyNumber,
            branchNumber,
            branchYear,
            branchUserNumber,
            addedTerminalName,
            addedTerminalName);

        sequenceControl.RaiseDomainEvent(new SequenceControlCreatedEvent(sequenceControl));

        return sequenceControl;
    }

    public void Update(
        int sequenceType,
        int incrementByValue,
        int initialValue,
        string sequenceConcatenation,
        string triggerName,
        bool onlyIfNull,
        string updatedTerminalName)
    {
        SequenceType = sequenceType;
        IncrementByValue = incrementByValue;
        InitialValue = initialValue;
        SequenceConcatenation = sequenceConcatenation;
        TriggerName = triggerName;
        OnlyIfNull = onlyIfNull;
        UpdatedTerminalName = updatedTerminalName;

        RaiseDomainEvent(new SequenceControlUpdatedEvent(this));
    }
} 
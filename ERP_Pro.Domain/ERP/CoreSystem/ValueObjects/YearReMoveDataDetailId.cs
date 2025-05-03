using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// Represents the unique identifier for a YearReMoveDataDetail entity
/// يمثل المعرف الفريد لكيان تفاصيل نقل بيانات السنة
/// !# TABLE_NM, TABLE_NM_MST
/// </summary>
public sealed class YearReMoveDataDetailId : ValueObject
{
    /// <summary>
    /// Gets the table name
    /// اسم الجدول
    /// !# TABLE_NM
    /// </summary>
    public string TableName { get; }

    /// <summary>
    /// Gets the master table name
    /// اسم الجدول الرئيسي
    /// !# TABLE_NM_MST
    /// </summary>
    public string MasterTableName { get; }

    /// <summary>
    /// Initializes a new instance of the YearReMoveDataDetailId class
    /// تهيئة نسخة جديدة من صنف معرف تفاصيل نقل بيانات السنة
    /// </summary>
    /// <param name="tableName">The table name اسم الجدول</param>
    /// <param name="masterTableName">The master table name اسم الجدول الرئيسي</param>
    public YearReMoveDataDetailId(string tableName, string masterTableName)
    {
        if (string.IsNullOrWhiteSpace(tableName))
            throw new ArgumentException("Table name cannot be empty", nameof(tableName));

        if (string.IsNullOrWhiteSpace(masterTableName))
            throw new ArgumentException("Master table name cannot be empty", nameof(masterTableName));

        TableName = tableName;
        MasterTableName = masterTableName;
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return TableName;
        yield return MasterTableName;
    }
} 
using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a YearReMoveDataDetail entity
/// يمثل كيان تفاصيل نقل بيانات السنة
/// </summary>
public class YearReMoveDataDetail : AuditableEntity
{
    /// <summary>
    /// Gets the unique identifier for the YearReMoveDataDetail
    /// المعرف الفريد لتفاصيل نقل بيانات السنة
    /// !# TABLE_NM, TABLE_NM_MST
    /// </summary>
    public YearReMoveDataDetailId Id { get; private set; }

    /// <summary>
    /// Gets the order number
    /// رقم الترتيب
    /// !# ORDER_NO
    /// </summary>
    public int OrderNumber { get; private set; }

    /// <summary>
    /// Gets the IAS user
    /// مستخدم النظام
    /// !# IAS_USER
    /// </summary>
    public string IasUser { get; private set; }

    /// <summary>
    /// Gets the basic where clause
    /// شرط WHERE الأساسي
    /// !# BSC_WHR
    /// </summary>
    public string BasicWhereClause { get; private set; }

    /// <summary>
    /// Gets the remove flag
    /// علم الإزالة
    /// !# RE_MOV_FLG
    /// </summary>
    public bool RemoveFlag { get; private set; }

    /// <summary>
    /// Gets the remove user ID
    /// معرف مستخدم الإزالة
    /// !# RE_MOV_U_ID
    /// </summary>
    public int? RemoveUserId { get; private set; }

    /// <summary>
    /// Gets the remove date
    /// تاريخ الإزالة
    /// !# RE_MOV_DATE
    /// </summary>
    public DateTime? RemoveDate { get; private set; }

    /// <summary>
    /// Gets the remove count
    /// عدد مرات الإزالة
    /// !# RE_MOV_CNT
    /// </summary>
    public long? RemoveCount { get; private set; }

    /// <summary>
    /// Gets the user ID who added
    /// معرف المستخدم الذي أضاف
    /// !# AD_U_ID
    /// </summary>
    public int? AddedByUserId { get; private set; }

    /// <summary>
    /// Gets the add date
    /// تاريخ الإضافة
    /// !# AD_DATE
    /// </summary>
    public DateTime? AddDate { get; private set; }

    /// <summary>
    /// Gets the terminal name for add
    /// اسم الجهاز عند الإضافة
    /// !# AD_TRMNL_NM
    /// </summary>
    public string AddTerminalName { get; private set; }

    /// <summary>
    /// Gets the terminal name for last update
    /// اسم الجهاز لآخر تحديث
    /// !# UP_TRMNL_NM
    /// </summary>
    public string UpdatedTerminalName { get; private set; }

    /// <summary>
    /// Navigation property for the master
    /// خاصية التنقل للرئيسي
    /// @# S_YR_RE_MOV_DATA_MST
    /// </summary>
    public YearReMoveDataMaster Master { get; private set; }

    private YearReMoveDataDetail() { }

    public YearReMoveDataDetail(
        string tableName,
        string masterTableName,
        int orderNumber,
        string iasUser,
        string basicWhereClause,
        bool removeFlag,
        int? removeUserId,
        DateTime? removeDate,
        long? removeCount,
        int? addedByUserId,
        DateTime? addDate,
        string addTerminalName,
        string updatedTerminalName)
    {
        Id = new YearReMoveDataDetailId(tableName, masterTableName);
        OrderNumber = orderNumber;
        IasUser = iasUser;
        BasicWhereClause = basicWhereClause;
        RemoveFlag = removeFlag;
        RemoveUserId = removeUserId;
        RemoveDate = removeDate;
        RemoveCount = removeCount;
        AddedByUserId = addedByUserId;
        AddDate = addDate;
        AddTerminalName = addTerminalName;
        UpdatedTerminalName = updatedTerminalName;
        AddDomainEvent(new YearReMoveDataDetailCreated(this));
    }

    public void Update(
        int orderNumber,
        string iasUser,
        string basicWhereClause,
        bool removeFlag,
        int? removeUserId,
        DateTime? removeDate,
        long? removeCount,
        string updatedTerminalName)
    {
        OrderNumber = orderNumber;
        IasUser = iasUser;
        BasicWhereClause = basicWhereClause;
        RemoveFlag = removeFlag;
        RemoveUserId = removeUserId;
        RemoveDate = removeDate;
        RemoveCount = removeCount;
        UpdatedTerminalName = updatedTerminalName;
        AddDomainEvent(new YearReMoveDataDetailUpdated(this));
    }

    public void Delete()
    {
        AddDomainEvent(new YearReMoveDataDetailDeleted(this));
    }
} 
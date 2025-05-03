using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a YearReMoveDataMaster entity
/// يمثل كيان رئيسي نقل بيانات السنة
/// </summary>
public class YearReMoveDataMaster : AuditableEntity
{
    /// <summary>
    /// Gets the unique identifier for the YearReMoveDataMaster
    /// المعرف الفريد لرئيسي نقل بيانات السنة
    /// !# TABLE_NM
    /// </summary>
    public YearReMoveDataMasterId Id { get; private set; }

    /// <summary>
    /// Gets the order number
    /// رقم الترتيب
    /// !# ORDER_NO
    /// </summary>
    public int OrderNumber { get; private set; }

    /// <summary>
    /// Gets the form number
    /// رقم النموذج
    /// !# FORM_NO
    /// </summary>
    public int FormNumber { get; private set; }

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
    /// Gets the row count
    /// عدد الصفوف
    /// !# ROW_CNT
    /// </summary>
    public long? RowCount { get; private set; }

    /// <summary>
    /// Gets the inactive flag
    /// علم عدم النشاط
    /// !# INACTIVE_FLG
    /// </summary>
    public bool InactiveFlag { get; private set; }

    /// <summary>
    /// Gets the inactive column name
    /// اسم عمود عدم النشاط
    /// !# INACTIVE_CLMN_NM
    /// </summary>
    public string InactiveColumnName { get; private set; }

    /// <summary>
    /// Gets the inactive list name
    /// اسم قائمة عدم النشاط
    /// !# INACTIVE_LST_NM
    /// </summary>
    public string InactiveListName { get; private set; }

    /// <summary>
    /// Gets the inactive list select
    /// اختيار قائمة عدم النشاط
    /// !# INACTIVE_LST_SLCT
    /// </summary>
    public string InactiveListSelect { get; private set; }

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
    /// Navigation property for the details
    /// خاصية التنقل للتفاصيل
    /// @# S_YR_RE_MOV_DATA_DTL
    /// </summary>
    public ICollection<YearReMoveDataDetail> Details { get; private set; }

    private YearReMoveDataMaster() { }

    public YearReMoveDataMaster(
        string tableName,
        int orderNumber,
        int formNumber,
        string iasUser,
        string basicWhereClause,
        long? rowCount,
        bool inactiveFlag,
        string inactiveColumnName,
        string inactiveListName,
        string inactiveListSelect,
        bool removeFlag,
        int? removeUserId,
        DateTime? removeDate,
        long? removeCount,
        int? addedByUserId,
        DateTime? addDate,
        string addTerminalName,
        string updatedTerminalName)
    {
        Id = new YearReMoveDataMasterId(tableName);
        OrderNumber = orderNumber;
        FormNumber = formNumber;
        IasUser = iasUser;
        BasicWhereClause = basicWhereClause;
        RowCount = rowCount;
        InactiveFlag = inactiveFlag;
        InactiveColumnName = inactiveColumnName;
        InactiveListName = inactiveListName;
        InactiveListSelect = inactiveListSelect;
        RemoveFlag = removeFlag;
        RemoveUserId = removeUserId;
        RemoveDate = removeDate;
        RemoveCount = removeCount;
        AddedByUserId = addedByUserId;
        AddDate = addDate;
        AddTerminalName = addTerminalName;
        UpdatedTerminalName = updatedTerminalName;
        Details = new List<YearReMoveDataDetail>();
        AddDomainEvent(new YearReMoveDataMasterCreated(this));
    }

    public void Update(
        int orderNumber,
        int formNumber,
        string iasUser,
        string basicWhereClause,
        long? rowCount,
        bool inactiveFlag,
        string inactiveColumnName,
        string inactiveListName,
        string inactiveListSelect,
        bool removeFlag,
        int? removeUserId,
        DateTime? removeDate,
        long? removeCount,
        string updatedTerminalName)
    {
        OrderNumber = orderNumber;
        FormNumber = formNumber;
        IasUser = iasUser;
        BasicWhereClause = basicWhereClause;
        RowCount = rowCount;
        InactiveFlag = inactiveFlag;
        InactiveColumnName = inactiveColumnName;
        InactiveListName = inactiveListName;
        InactiveListSelect = inactiveListSelect;
        RemoveFlag = removeFlag;
        RemoveUserId = removeUserId;
        RemoveDate = removeDate;
        RemoveCount = removeCount;
        UpdatedTerminalName = updatedTerminalName;
        AddDomainEvent(new YearReMoveDataMasterUpdated(this));
    }

    public void Delete()
    {
        AddDomainEvent(new YearReMoveDataMasterDeleted(this));
    }
} 
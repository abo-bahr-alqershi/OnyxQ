using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Event raised when a YearReMoveDataMaster is created
/// حدث يتم رفعه عند إنشاء رئيسي نقل بيانات السنة
/// </summary>
public class YearReMoveDataMasterCreated : DomainEvent
{
    /// <summary>
    /// Gets the YearReMoveDataMaster entity
    /// كيان رئيسي نقل بيانات السنة
    /// </summary>
    public YearReMoveDataMaster YearReMoveDataMaster { get; }

    public YearReMoveDataMasterCreated(YearReMoveDataMaster yearReMoveDataMaster)
    {
        YearReMoveDataMaster = yearReMoveDataMaster;
    }
}

/// <summary>
/// Event raised when a YearReMoveDataMaster is updated
/// حدث يتم رفعه عند تحديث رئيسي نقل بيانات السنة
/// </summary>
public class YearReMoveDataMasterUpdated : DomainEvent
{
    /// <summary>
    /// Gets the YearReMoveDataMaster entity
    /// كيان رئيسي نقل بيانات السنة
    /// </summary>
    public YearReMoveDataMaster YearReMoveDataMaster { get; }

    public YearReMoveDataMasterUpdated(YearReMoveDataMaster yearReMoveDataMaster)
    {
        YearReMoveDataMaster = yearReMoveDataMaster;
    }
}

/// <summary>
/// Event raised when a YearReMoveDataMaster is deleted
/// حدث يتم رفعه عند حذف رئيسي نقل بيانات السنة
/// </summary>
public class YearReMoveDataMasterDeleted : DomainEvent
{
    /// <summary>
    /// Gets the YearReMoveDataMaster entity
    /// كيان رئيسي نقل بيانات السنة
    /// </summary>
    public YearReMoveDataMaster YearReMoveDataMaster { get; }

    public YearReMoveDataMasterDeleted(YearReMoveDataMaster yearReMoveDataMaster)
    {
        YearReMoveDataMaster = yearReMoveDataMaster;
    }
} 
using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل جهاز المستخدم المحمول ويحتوي على خصائص الجهاز المرتبط بالمستخدم.
public class UserHandheldDevice : Entity<UserHandheldDeviceId>
{

    private UserHandheldDevice() { }

    public UserHandheldDevice(UserHandheldDeviceId id, string handheldDeviceSerial)
    {
        Id = id;
        HandheldDeviceSerial = handheldDeviceSerial;
    }

    // المعرف الفريد لجهاز المستخدم المحمول (مفتاح رئيسي).
    public UserHandheldDeviceId Id { get; private set; }

    // اسم جهاز المستخدم المحمول.
    public string HandheldDeviceName { get; private set; }

    // الرقم التسلسلي لجهاز المستخدم المحمول.
    public string HandheldDeviceSerial { get; private set; }

    // علم التعطيل للجهاز.
    public decimal? InactiveFlag { get; private set; }

    // تاريخ التعطيل للجهاز.
    public DateTime? InactiveDate { get; private set; }

    // معرف المستخدم الذي قام بالتعطيل.
    public decimal? InactivatedByUserId { get; private set; }

    // سبب التعطيل للجهاز.
    public string InactiveReason { get; private set; }

    #region Navigation Properties
    // المستخدم المرتبط بالجهاز المحمول.
    public User User { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

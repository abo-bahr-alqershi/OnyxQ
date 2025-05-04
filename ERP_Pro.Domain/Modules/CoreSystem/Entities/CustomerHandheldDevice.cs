using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل جهاز العميل المحمول ويحتوي على خصائص الجهاز المرتبط بالعميل.
public class CustomerHandheldDevice : Entity<CustomerHandheldDeviceId>
{
    private CustomerHandheldDevice() { }

    public CustomerHandheldDevice(CustomerHandheldDeviceId id, string handheldDeviceSerial)
    {
        Id = id;
        HandheldDeviceSerial = handheldDeviceSerial;
    }

    // المعرف الفريد لجهاز العميل المحمول (مفتاح رئيسي).
    public CustomerHandheldDeviceId Id { get; private set; }

    // اسم جهاز العميل المحمول.
    public string HandheldDeviceName { get; private set; }

    // الرقم التسلسلي لجهاز العميل المحمول.
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
    // العميل المرتبط بالجهاز المحمول.
    public Customer Customer { get; private set; }
    #endregion

    #region Methods
    // أضف هنا منطق الدومين الخاص بجهاز العميل المحمول
    #endregion
}
}

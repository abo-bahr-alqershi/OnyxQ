using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل جهة الاتصال المرتبطة بالاتصال ويحتوي على تفاصيل الاتصال.
public class ConnectContact : Entity<ConnectContactId>
{
    private ConnectContact() { }

    public ConnectContact(ConnectContactId id, decimal? connectionContactNumber, decimal? contactCode, decimal? contactType, decimal? contactNumber)
    {
        Id = id;
        ConnectionContactNumber = connectionContactNumber;
        ContactCode = contactCode;
        ContactType = contactType;
        ContactNumber = contactNumber;
    }

    // المعرف الفريد لجهة الاتصال (مفتاح رئيسي).
    public ConnectContactId Id { get; private set; }
    // رقم جهة الاتصال المرتبطة.
    public decimal? ConnectionContactNumber { get; private set; }
    // كود جهة الاتصال.
    public decimal? ContactCode { get; private set; }
    // نوع جهة الاتصال.
    public decimal? ContactType { get; private set; }
    // رقم جهة الاتصال.
    public decimal? ContactNumber { get; private set; }
    // وصف جهة الاتصال.
    public string ContactDescription { get; private set; }
    // رقم ترتيب الجهة.
    public decimal? OrderNumberShort { get; private set; }
    // ملاحظات إضافية.
    public string Notes { get; private set; }
    // علم المفضلة لجهة الاتصال.
    public decimal? ContactFavorite { get; private set; }
    // علم التعطيل البديل.
    public decimal? InactiveFlagAlt { get; private set; }
    // سبب التعطيل البديل.
    public string InactiveReasonAlt { get; private set; }
    // رقم المستخدم الذي قام بالتعطيل.
    public decimal? InactiveUser { get; private set; }
    // تاريخ التعطيل البديل.
    public DateTime? InactiveDateAlt { get; private set; }

    #region Methods
    // أضف هنا منطق الدومين الخاص بجهة الاتصال
    #endregion
}
}

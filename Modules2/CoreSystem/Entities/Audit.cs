using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;
using ERP_Pro.Domain.ERP.ArchivingDocuments.Entities;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل عملية التدقيق (المراجعة) في النظام ويحتوي على معلومات التعديلات والحذف على السجلات.
public class Audit : Entity<AuditId>
{
    private Audit() { }

    public Audit(AuditId id)
    {
        Id = id;
    }

    // المعرف الفريد لعملية التدقيق (مفتاح رئيسي).
    public AuditId Id { get; private set; }

    // علم تعديل السجل في عملية التدقيق.
    public decimal? AuditModifyFlag { get; private set; }

    // علم حذف السجل في عملية التدقيق.
    public decimal? AuditDeleteFlag { get; private set; }

    #region Navigation Properties
    // تفاصيل النموذج المرتبطة بعملية التدقيق.
    public FormDetail FormDetail { get; private set; }
    // المستخدم الذي قام بعملية التدقيق.
    public User User { get; private set; }
    #endregion

    #region Methods
    // أضف هنا منطق الدومين الخاص بعملية التدقيق
    #endregion
}
}

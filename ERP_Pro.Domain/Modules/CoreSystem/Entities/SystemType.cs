using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ArchivingDocuments.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل نوع النظام ويحتوي على خصائص النظام المرتبط بالنماذج.
public class SystemType : Entity<SystemTypeId>
{

    private SystemType() { }

    public SystemType(SystemTypeId id, string objectNameShort, string tpName)
    {
        Id = id;
        ObjectNameShort = objectNameShort;
        TpName = tpName;
    }

    // المعرف الفريد لنوع النظام (مفتاح رئيسي).
    public SystemTypeId Id { get; private set; }

    // اسم الكائن المختصر للنظام.
    public string ObjectNameShort { get; private set; }

    // اسم نوع النظام.
    public string TpName { get; private set; }

    // رقم التسمية المختصر للنظام.
    public decimal? LabelNumberShort { get; private set; }

    #region Navigation Properties
    // تفاصيل النموذج المرتبطة بالنظام.
    public FormDetail FormDetail { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

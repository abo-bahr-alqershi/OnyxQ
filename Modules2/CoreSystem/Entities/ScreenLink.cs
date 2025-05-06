using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;
using ERP_Pro.Domain.ERP.ArchivingDocuments.Entities;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل رابط الشاشة ويحتوي على جميع خصائص الربط بين الشاشات والنماذج والمستخدمين.
    public class ScreenLink : Entity<ScreenLinkId>
    {
        private ScreenLink() { }

        public ScreenLink(ScreenLinkId id)
        {
            Id = id;
        }

        // المعرف الفريد لرابط الشاشة (مفتاح رئيسي).
        public ScreenLinkId Id { get; private set; }

        // رقم ترتيب الرابط.
        public decimal? OrderNumberShort { get; private set; }

        // رقم النظام المرتبط بالرابط.
        public decimal? SystemNumber { get; private set; }

        #region Navigation Properties
        // تفاصيل النموذج المرتبطة بالرابط.
        public FormDetail FormDetail { get; private set; }

        // تفاصيل النموذج المرتبطة برقم النموذج المرتبط بالرابط.
        public FormDetail FormDetailFormNoLnkd { get; private set; }

        // المستخدم المرتبط بالرابط.
        public User User { get; private set; }
        #endregion

        #region Methods
        // Add domain logic methods here
        #endregion
    }
}

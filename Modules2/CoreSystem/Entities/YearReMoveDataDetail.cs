using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل تفاصيل حذف بيانات السنة ويحتوي على معلومات الجداول والعمليات المرتبطة بالحذف.
    public class YearReMoveDataDetail : Entity<YearReMoveDataDetailId>
    {

        private YearReMoveDataDetail() { }

        public YearReMoveDataDetail(YearReMoveDataDetailId id, string tableNameShort)
        {
            Id = id;
            TableNameShort = tableNameShort;
        }

        // المعرف الفريد لتفاصيل حذف بيانات السنة (مفتاح رئيسي).
        public YearReMoveDataDetailId Id { get; private set; }

        // رقم الترتيب للتفاصيل.
        public decimal? OrderNumber { get; private set; }

        // اسم المستخدم المنفذ للعملية.
        public string IasUser { get; private set; }

        // اسم الجدول المختصر.
        public string TableNameShort { get; private set; }

        // شرط where الأساسي.
        public string BasicWhere { get; private set; }

        // علم الحذف.
        public decimal? RemoveFlag { get; private set; }

        // رقم المستخدم الذي قام بالحذف.
        public decimal? RemoveUserId { get; private set; }

        // تاريخ الحذف.
        public DateTime? RemoveDate { get; private set; }

        // عدد مرات الحذف.
        public decimal? RemoveCount { get; private set; }

        #region Navigation Properties
        // سجل حذف بيانات السنة الرئيسي المرتبط.
        public YearReMoveDataMaster YearReMoveDataMaster { get; private set; }
        #endregion

        #region Methods
        // Add domain logic methods here
        #endregion
    }
}

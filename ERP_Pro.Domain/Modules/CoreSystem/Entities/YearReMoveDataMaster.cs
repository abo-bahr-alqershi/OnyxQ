using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل سجل حذف بيانات السنة الرئيسي ويحتوي على معلومات الجداول والعمليات المرتبطة بالحذف.
    public class YearReMoveDataMaster : Entity<YearReMoveDataMasterId>
    {
        private YearReMoveDataMaster() { }

        public YearReMoveDataMaster(YearReMoveDataMasterId id, string tableNameShort)
        {
            Id = id;
            TableNameShort = tableNameShort;
        }

        // المعرف الفريد لسجل حذف بيانات السنة الرئيسي (مفتاح رئيسي).
        public YearReMoveDataMasterId Id { get; private set; }

        // رقم الترتيب للسجل.
        public decimal? OrderNumber { get; private set; }

        // رقم النموذج المرتبط.
        public decimal? FormNumber { get; private set; }

        // اسم المستخدم المنفذ للعملية.
        public string IasUser { get; private set; }

        // اسم الجدول المختصر.
        public string TableNameShort { get; private set; }

        // شرط where الأساسي.
        public string BasicWhere { get; private set; }

        // عدد الصفوف.
        public decimal? RowCount { get; private set; }

        // علم التعطيل المختصر.
        public decimal? InactiveFlagShort { get; private set; }

        // اسم عمود التعطيل.
        public string InactiveColumnName { get; private set; }

        // اسم قائمة التعطيل.
        public string InactiveListName { get; private set; }

        // استعلام قائمة التعطيل.
        public string InactiveListSelect { get; private set; }

        // علم الحذف.
        public decimal? RemoveFlag { get; private set; }

        // رقم المستخدم الذي قام بالحذف.
        public decimal? RemoveUserId { get; private set; }

        // تاريخ الحذف.
        public DateTime? RemoveDate { get; private set; }

        // عدد مرات الحذف.
        public decimal? RemoveCount { get; private set; }

        #region Methods
        // Add domain logic methods here
        #endregion
    }
}

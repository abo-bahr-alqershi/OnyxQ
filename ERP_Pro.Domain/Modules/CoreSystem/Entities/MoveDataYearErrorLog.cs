using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل سجل أخطاء نقل بيانات السنة ويحتوي على تفاصيل الجداول والأعمدة والاستعلامات التي حدثت بها أخطاء أثناء النقل.
public class MoveDataYearErrorLog : Entity<MoveDataYearErrorLogId>
{
    private MoveDataYearErrorLog() { }

    public MoveDataYearErrorLog(MoveDataYearErrorLogId id)
    {
        Id = id;
    }

    // المعرف الفريد لسجل أخطاء نقل بيانات السنة (مفتاح رئيسي).
    public MoveDataYearErrorLogId Id { get; private set; }

    // اسم الجدول الذي حدث به الخطأ.
    public string TableNameLabel { get; private set; }

    // أسماء الأعمدة التي حدث بها الخطأ.
    public string ColumnsName { get; private set; }

    // نص الاستعلام SELECT الذي حدث به الخطأ.
    public string SqlSelect { get; private set; }

    // شرط WHERE الخاص بالاستعلام الذي حدث به الخطأ.
    public string SqlWhere { get; private set; }

    // رسالة الخطأ الناتجة من قاعدة البيانات.
    public string SqlError { get; private set; }

    #region Methods
    // أضف هنا منطق الدومين الخاص بسجل أخطاء نقل بيانات السنة
    #endregion
}
}

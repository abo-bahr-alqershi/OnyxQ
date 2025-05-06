using System;

namespace ERP_Pro.Domain.Common.Base
{
    /// <summary>
    /// الفئة الأساسية للكيانات الجذرية في النظام
    /// </summary>
    public abstract class AggregateRoot : Entity
    {
        // هذه الفئة هي امتداد للكيان الأساسي وتُستخدم لتمييز الكيانات الجذرية التي تمثل حدود السياق
    }
} 
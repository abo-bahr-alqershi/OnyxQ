namespace ERP_Pro.Domain.SettingsParameters.Entities
{
    /// <summary>
    /// يمثل مكون من مكونات نمط الترميز (ثابت، متغير، دالة).
    /// </summary>
    public class PatternComponent
    {
        /// <summary>
        /// معرف المكون (مفتاح أساسي)
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// رمز النمط المرتبط (مفتاح أجنبي)
        /// </summary>
        public string PatternCode { get; set; }

        /// <summary>
        /// نوع المكون (ثابت، متغير، دالة)
        /// </summary>
        public ComponentType ComponentType { get; set; }

        /// <summary>
        /// ترتيب المكون في النمط
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// قيمة المكون (نص ثابت أو اسم متغير أو دالة)
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// هل المكون إلزامي؟
        /// </summary>
        public bool IsRequired { get; set; }

        /// <summary>
        /// خصائص إضافية (JSON)
        /// </summary>
        public string Properties { get; set; }
    }

    /// <summary>
    /// أنواع مكونات النمط
    /// </summary>
    public enum ComponentType
    {
        Constant = 1,
        Variable = 2,
        Function = 3
    }
} 
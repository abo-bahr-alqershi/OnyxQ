namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل نوع العلاقة ويحتوي على معلومات تصنيف العلاقات بين الكيانات.
    public class ConnectionType : Entity<ConnectionTypeId>
    {
        // المعرف الفريد لنوع العلاقة (مفتاح رئيسي).
        public ConnectionTypeId Id { get; private set; }
        // اسم نوع العلاقة.
        public string ConnectionTypeName { get; private set; }
        // وصف نوع العلاقة.
        public string ConnectionTypeDescription { get; private set; }
        // علم التعطيل البديل.
        public decimal? InactiveFlagAlt { get; private set; }
        // سبب التعطيل البديل.
        public string InactiveReasonAlt { get; private set; }
        // رقم المستخدم الذي قام بالتعطيل.
        public decimal? InactiveUser { get; private set; }
        // تاريخ التعطيل البديل.
        public DateTime? InactiveDateAlt { get; private set; }
        #region Methods
        // أضف هنا منطق الدومين الخاص بنوع العلاقة
        #endregion
    }
}
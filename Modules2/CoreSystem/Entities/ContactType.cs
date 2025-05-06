using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;
namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل نوع الاتصال ويحتوي على معلومات التصنيفات المختلفة للاتصال.
    public class ContactType : Entity<ContactTypeId>
    {
        // المعرف الفريد لنوع الاتصال (مفتاح رئيسي).
        public ContactTypeId Id { get; private set; }
        // اسم نوع الاتصال.
        public string ContactTypeName { get; private set; }
        // وصف نوع الاتصال.
        public string ContactTypeDescription { get; private set; }
        // علم التعطيل البديل.
        public decimal? InactiveFlagAlt { get; private set; }
        // سبب التعطيل البديل.
        public string InactiveReasonAlt { get; private set; }
        // رقم المستخدم الذي قام بالتعطيل.
        public decimal? InactiveUser { get; private set; }
        // تاريخ التعطيل البديل.
        public DateTime? InactiveDateAlt { get; private set; }
        #region Methods
        // أضف هنا منطق الدومين الخاص بنوع الاتصال
        #endregion
    }
}

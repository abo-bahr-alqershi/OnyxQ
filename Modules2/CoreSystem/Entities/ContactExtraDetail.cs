using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;
namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل تفاصيل الاتصال الإضافية ويحتوي على معلومات إضافية حول الاتصال.
    public class ContactExtraDetail : Entity<ContactExtraDetailId>
    {
        // المعرف الفريد لتفاصيل الاتصال الإضافية (مفتاح رئيسي).
        public ContactExtraDetailId Id { get; private set; }
        // رقم الجهة المرتبطة بتفاصيل الاتصال الإضافية.
        public decimal? ContactNumber { get; private set; }
        // نوع تفاصيل الاتصال الإضافية.
        public decimal? ContactExtraDetailType { get; private set; }
        // قيمة تفاصيل الاتصال الإضافية.
        public string ContactExtraDetailValue { get; private set; }
        // وصف تفاصيل الاتصال الإضافية.
        public string ContactExtraDetailDescription { get; private set; }
        // علم التعطيل البديل.
        public decimal? InactiveFlagAlt { get; private set; }
        // سبب التعطيل البديل.
        public string InactiveReasonAlt { get; private set; }
        // رقم المستخدم الذي قام بالتعطيل.
        public decimal? InactiveUser { get; private set; }
        // تاريخ التعطيل البديل.
        public DateTime? InactiveDateAlt { get; private set; }
        #region Methods
        // أضف هنا منطق الدومين الخاص بتفاصيل الاتصال الإضافية
        #endregion
    }
}

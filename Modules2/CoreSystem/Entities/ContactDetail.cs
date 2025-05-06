using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;
namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل تفاصيل الاتصال ويحتوي على معلومات الاتصال الخاصة بالجهة.
    public class ContactDetail : Entity<ContactDetailId>
    {
        // المعرف الفريد لتفاصيل الاتصال (مفتاح رئيسي).
        public ContactDetailId Id { get; private set; }
        // رقم الجهة المرتبطة بتفاصيل الاتصال.
        public decimal? ContactNumber { get; private set; }
        // نوع تفاصيل الاتصال.
        public decimal? ContactDetailType { get; private set; }
        // قيمة تفاصيل الاتصال (مثل رقم الهاتف أو البريد الإلكتروني).
        public string ContactDetailValue { get; private set; }
        // وصف تفاصيل الاتصال.
        public string ContactDetailDescription { get; private set; }
        // علم التعطيل البديل.
        public decimal? InactiveFlagAlt { get; private set; }
        // سبب التعطيل البديل.
        public string InactiveReasonAlt { get; private set; }
        // رقم المستخدم الذي قام بالتعطيل.
        public decimal? InactiveUser { get; private set; }
        // تاريخ التعطيل البديل.
        public DateTime? InactiveDateAlt { get; private set; }
        #region Methods
        // أضف هنا منطق الدومين الخاص بتفاصيل الاتصال
        #endregion
    }
}

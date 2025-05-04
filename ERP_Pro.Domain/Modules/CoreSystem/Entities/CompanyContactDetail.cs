namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل تفاصيل الاتصال الخاصة بالشركة ويحتوي على معلومات الاتصال الخاصة بكل شركة.
    public class CompanyContactDetail : Entity<CompanyContactDetailId>
    {
        // المعرف الفريد لتفاصيل الاتصال الخاصة بالشركة (مفتاح رئيسي).
        public CompanyContactDetailId Id { get; private set; }
        // رقم الشركة المرتبط بتفاصيل الاتصال.
        public decimal? CompanyNumber { get; private set; }
        // نوع تفاصيل الاتصال الخاصة بالشركة.
        public decimal? CompanyContactDetailType { get; private set; }
        // قيمة تفاصيل الاتصال الخاصة بالشركة.
        public string CompanyContactDetailValue { get; private set; }
        // وصف تفاصيل الاتصال الخاصة بالشركة.
        public string CompanyContactDetailDescription { get; private set; }
        // علم التعطيل البديل.
        public decimal? InactiveFlagAlt { get; private set; }
        // سبب التعطيل البديل.
        public string InactiveReasonAlt { get; private set; }
        // رقم المستخدم الذي قام بالتعطيل.
        public decimal? InactiveUser { get; private set; }
        // تاريخ التعطيل البديل.
        public DateTime? InactiveDateAlt { get; private set; }
        #region Methods
        // أضف هنا منطق الدومين الخاص بتفاصيل الاتصال الخاصة بالشركة
        #endregion
    }
}
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;
namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل تفاصيل الاتصال الخاصة بالفرع ويحتوي على معلومات الاتصال الخاصة بكل فرع.
    public class BranchContactDetail : Entity<BranchContactDetailId>
    {
        // المعرف الفريد لتفاصيل الاتصال الخاصة بالفرع (مفتاح رئيسي).
        public BranchContactDetailId Id { get; private set; }
        // رقم الفرع المرتبط بتفاصيل الاتصال.
        public decimal? BranchNumber { get; private set; }
        // نوع تفاصيل الاتصال الخاصة بالفرع.
        public decimal? BranchContactDetailType { get; private set; }
        // قيمة تفاصيل الاتصال الخاصة بالفرع.
        public string BranchContactDetailValue { get; private set; }
        // وصف تفاصيل الاتصال الخاصة بالفرع.
        public string BranchContactDetailDescription { get; private set; }
        // علم التعطيل البديل.
        public decimal? InactiveFlagAlt { get; private set; }
        // سبب التعطيل البديل.
        public string InactiveReasonAlt { get; private set; }
        // رقم المستخدم الذي قام بالتعطيل.
        public decimal? InactiveUser { get; private set; }
        // تاريخ التعطيل البديل.
        public DateTime? InactiveDateAlt { get; private set; }
        #region Methods
        // أضف هنا منطق الدومين الخاص بتفاصيل الاتصال الخاصة بالفرع
        #endregion
    }
}

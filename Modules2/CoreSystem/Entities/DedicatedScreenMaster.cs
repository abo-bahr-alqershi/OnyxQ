using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;
namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل تفاصيل شاشة مخصصة رئيسية ويحتوي على معلومات الحقول والعناصر الرئيسية للشاشة.
    public class DedicatedScreenMaster : Entity<DedicatedScreenMasterId>
    {
        // المعرف الفريد لتفاصيل الشاشة المخصصة الرئيسية (مفتاح رئيسي).
        public DedicatedScreenMasterId Id { get; private set; }
        // رقم النموذج المرتبط.
        public decimal? FormNumber { get; private set; }
        // اسم الشاشة المخصصة.
        public string DedicatedScreenName { get; private set; }
        // وصف الشاشة المخصصة.
        public string DedicatedScreenDescription { get; private set; }
        // رقم ترتيب الشاشة المخصصة.
        public decimal? OrderNumberShort { get; private set; }
        #region Methods
        // أضف هنا منطق الدومين الخاص بتفاصيل الشاشة المخصصة الرئيسية
        #endregion
    }
}

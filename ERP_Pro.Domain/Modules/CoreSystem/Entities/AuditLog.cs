namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل سجل عمليات النظام ويحتوي على تفاصيل العمليات المنفذة.
    public class AuditLog : Entity<AuditLogId>
    {
        // المعرف الفريد لسجل العمليات (مفتاح رئيسي).
        public AuditLogId Id { get; private set; }

        // اسم العملية المنفذة.
        public string OperationName { get; private set; }

        // اسم المستخدم المنفذ للعملية.
        public string UserName { get; private set; }

        // تاريخ ووقت تنفيذ العملية.
        public DateTime? OperationDate { get; private set; }

        // تفاصيل إضافية عن العملية.
        public string Details { get; private set; }

        #region Methods
        // أضف هنا منطق الدومين الخاص بسجل عمليات النظام
        #endregion
    }
}
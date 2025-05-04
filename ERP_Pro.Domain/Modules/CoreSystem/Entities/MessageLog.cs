namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل سجل رسائل النظام ويحتوي على تفاصيل الرسائل والتنبيهات.
    public class MessageLog : Entity<MessageLogId>
    {
        // المعرف الفريد لسجل الرسائل (مفتاح رئيسي).
        public MessageLogId Id { get; private set; }

        // نص الرسالة.
        public string MessageText { get; private set; }

        // نوع الرسالة (تنبيه/ملاحظة/خطأ).
        public string MessageType { get; private set; }

        // تاريخ ووقت إرسال الرسالة.
        public DateTime? SentDate { get; private set; }

        // اسم المستخدم المرسل.
        public string SenderUserName { get; private set; }

        #region Methods
        // أضف هنا منطق الدومين الخاص بسجل رسائل النظام
        #endregion
    }
}
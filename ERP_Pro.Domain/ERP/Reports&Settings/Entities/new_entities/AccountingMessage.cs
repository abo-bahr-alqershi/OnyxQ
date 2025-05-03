/**
 * @class AccountingMessage
 * @description كلاس رسائل المحاسبة المستخدم في النظام لإرسال وتتبع الرسائل المتعلقة بالأنشطة المحاسبية
 * @author OnyxQ Team
 */
public class AccountingMessage
{
    /// <summary>
    /// مصدر الرسالة
    /// </summary>
    public bool? MessageSource { get; private set; }
    
    /// <summary>
    /// رقم الرسالة
    /// </summary>
    public long? MessageNumber { get; private set; }
    
    /// <summary>
    /// موضوع الرسالة
    /// </summary>
    public string? MessageSubject { get; private set; }
    
    /// <summary>
    /// نص الرسالة
    /// </summary>
    public string? MessageText { get; private set; }
    
    /// <summary>
    /// رمز العميل/الحساب
    /// </summary>
    public string? CustomerCode { get; private set; }
    
    /// <summary>
    /// معرف مستخدم الإضافة
    /// </summary>
    public int? AddUserId { get; private set; }
    
    /// <summary>
    /// مؤشر قراءة الرسالة
    /// </summary>
    public bool? IsMessageRead { get; private set; }
    
    /// <summary>
    /// تاريخ الرسالة
    /// </summary>
    public DateTime? MessageDate { get; private set; }
}
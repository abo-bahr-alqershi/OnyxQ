namespace ERP_Pro.Domain.ERP.CoreSystem.Enums;

/// <summary>
/// يمثل هذا التعداد نوع المستند في النظام
/// Represents the document type in the system
/// </summary>
public enum DocumentType
{
    /// <summary>
    /// رخصة تجارية
    /// Commercial License
    /// </summary>
    CommercialLicense = 1,

    /// <summary>
    /// عقد إيجار
    /// Lease Contract
    /// </summary>
    LeaseContract = 2,

    /// <summary>
    /// شهادة سجل تجاري
    /// Commercial Registration Certificate
    /// </summary>
    CommercialRegistration = 3,

    /// <summary>
    /// شهادة غرفة تجارية
    /// Chamber of Commerce Certificate
    /// </summary>
    ChamberOfCommerce = 4,

    /// <summary>
    /// رخصة بلدية
    /// Municipality License
    /// </summary>
    MunicipalityLicense = 5,

    /// <summary>
    /// شهادة الدفاع المدني
    /// Civil Defense Certificate
    /// </summary>
    CivilDefense = 6,

    /// <summary>
    /// شهادة زكاة
    /// Zakat Certificate
    /// </summary>
    ZakatCertificate = 7,

    /// <summary>
    /// شهادة تأمينات اجتماعية
    /// Social Insurance Certificate
    /// </summary>
    SocialInsurance = 8,

    /// <summary>
    /// شهادة سعودة
    /// Saudization Certificate
    /// </summary>
    Saudization = 9,

    /// <summary>
    /// مستندات أخرى
    /// Other Documents
    /// </summary>
    Other = 10
} 
using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// يمثل هذا النموذج معلومات الاتصال بالفرع
/// Represents branch contact information
/// </summary>
public class BranchContactInfo : ValueObject
{
    /// <summary>
    /// رقم الهاتف الرئيسي
    /// Main phone number
    /// </summary>
    public string Phone { get; private set; }

    /// <summary>
    /// رقم الهاتف المحمول
    /// Mobile number
    /// </summary>
    public string Mobile { get; private set; }

    /// <summary>
    /// رقم الفاكس
    /// Fax number
    /// </summary>
    public string Fax { get; private set; }

    /// <summary>
    /// البريد الإلكتروني
    /// Email address
    /// </summary>
    public string Email { get; private set; }

    /// <summary>
    /// اسم مدير الفرع
    /// Branch manager name
    /// </summary>
    public string ManagerName { get; private set; }

    /// <summary>
    /// رقم هاتف مدير الفرع
    /// Branch manager phone
    /// </summary>
    public string ManagerPhone { get; private set; }

    /// <summary>
    /// البريد الإلكتروني لمدير الفرع
    /// Branch manager email
    /// </summary>
    public string ManagerEmail { get; private set; }

    private BranchContactInfo() { } // Required by EF Core

    public BranchContactInfo(
        string phone,
        string mobile,
        string fax,
        string email,
        string managerName = null,
        string managerPhone = null,
        string managerEmail = null)
    {
        if (string.IsNullOrWhiteSpace(phone) && string.IsNullOrWhiteSpace(mobile))
            throw new ArgumentException("At least one phone number must be provided");

        if (!string.IsNullOrWhiteSpace(email) && !IsValidEmail(email))
            throw new ArgumentException("Invalid email address", nameof(email));

        if (!string.IsNullOrWhiteSpace(managerEmail) && !IsValidEmail(managerEmail))
            throw new ArgumentException("Invalid manager email address", nameof(managerEmail));

        Phone = phone;
        Mobile = mobile;
        Fax = fax;
        Email = email;
        ManagerName = managerName;
        ManagerPhone = managerPhone;
        ManagerEmail = managerEmail;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Phone;
        yield return Mobile;
        yield return Fax;
        yield return Email;
        yield return ManagerName;
        yield return ManagerPhone;
        yield return ManagerEmail;
    }

    private bool IsValidEmail(string email)
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }
} 
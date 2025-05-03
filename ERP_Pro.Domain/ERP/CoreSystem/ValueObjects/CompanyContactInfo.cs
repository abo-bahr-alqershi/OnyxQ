using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// Represents a company's contact information
/// يمثل معلومات الاتصال للشركة
/// </summary>
public class CompanyContactInfo : ValueObject
{
    /// <summary>
    /// رقم الهاتف الرئيسي
    /// Main phone number
    /// </summary>
    public string PhoneNumber { get; private set; }

    /// <summary>
    /// رقم الهاتف المحمول
    /// Mobile number
    /// </summary>
    public string Mobile { get; private set; }

    /// <summary>
    /// رقم الفاكس
    /// Fax number
    /// </summary>
    public string FaxNumber { get; private set; }

    /// <summary>
    /// البريد الإلكتروني
    /// Email address
    /// </summary>
    public string Email { get; private set; }

    /// <summary>
    /// الموقع الإلكتروني
    /// Website
    /// </summary>
    public string Website { get; private set; }

    /// <summary>
    /// اسم الشخص المسؤول
    /// Contact person name
    /// </summary>
    public string ContactPerson { get; private set; }

    /// <summary>
    /// منصب الشخص المسؤول
    /// Contact person position
    /// </summary>
    public string ContactPosition { get; private set; }

    private CompanyContactInfo() { } // For EF Core

    public CompanyContactInfo(
        string phoneNumber,
        string mobile,
        string faxNumber,
        string email,
        string website,
        string contactPerson = null,
        string contactPosition = null)
    {
        if (string.IsNullOrWhiteSpace(phoneNumber) && string.IsNullOrWhiteSpace(mobile))
            throw new ArgumentException("At least one phone number must be provided");

        if (!string.IsNullOrWhiteSpace(email) && !IsValidEmail(email))
            throw new ArgumentException("Invalid email address", nameof(email));

        if (!string.IsNullOrWhiteSpace(website) && !IsValidWebsite(website))
            throw new ArgumentException("Invalid website URL", nameof(website));

        PhoneNumber = phoneNumber;
        Mobile = mobile;
        FaxNumber = faxNumber;
        Email = email;
        Website = website;
        ContactPerson = contactPerson;
        ContactPosition = contactPosition;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return PhoneNumber;
        yield return Mobile;
        yield return FaxNumber;
        yield return Email;
        yield return Website;
        yield return ContactPerson;
        yield return ContactPosition;
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

    private bool IsValidWebsite(string website)
    {
        return Uri.TryCreate(website, UriKind.Absolute, out var uriResult)
            && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
    }
} 
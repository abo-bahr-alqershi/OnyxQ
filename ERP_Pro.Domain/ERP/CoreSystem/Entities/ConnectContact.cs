using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a connect contact
/// يمثل جهة اتصال
/// </summary>
public class ConnectContact : AuditableEntity
{
    /// <summary>
    /// The unique identifier for the contact
    /// المعرف الفريد لجهة الاتصال
    /// </summary>
    public ConnectContactId Id { get; private set; }

    /// <summary>
    /// The contact name in English
    /// اسم جهة الاتصال باللغة الإنجليزية
    /// </summary>
    public string NameEn { get; private set; }

    /// <summary>
    /// The contact name in Arabic
    /// اسم جهة الاتصال باللغة العربية
    /// </summary>
    public string NameAr { get; private set; }

    /// <summary>
    /// The contact description in English
    /// وصف جهة الاتصال باللغة الإنجليزية
    /// </summary>
    public string DescriptionEn { get; private set; }

    /// <summary>
    /// The contact description in Arabic
    /// وصف جهة الاتصال باللغة العربية
    /// </summary>
    public string DescriptionAr { get; private set; }

    /// <summary>
    /// The contact type
    /// نوع جهة الاتصال
    /// </summary>
    public string ContactType { get; private set; }

    /// <summary>
    /// Whether the contact is inactive
    /// ما إذا كانت جهة الاتصال غير نشطة
    /// </summary>
    public bool IsInactive { get; private set; }

    private ConnectContact() { } // For EF Core

    public ConnectContact(
        string nameEn,
        string nameAr,
        string descriptionEn,
        string descriptionAr,
        string contactType)
    {
        Id = new ConnectContactId(Guid.NewGuid());
        NameEn = nameEn;
        NameAr = nameAr;
        DescriptionEn = descriptionEn;
        DescriptionAr = descriptionAr;
        ContactType = contactType;
        IsInactive = false;

        AddDomainEvent(new ConnectContactCreatedEvent(this));
    }

    public void Update(
        string nameEn,
        string nameAr,
        string descriptionEn,
        string descriptionAr,
        string contactType)
    {
        NameEn = nameEn;
        NameAr = nameAr;
        DescriptionEn = descriptionEn;
        DescriptionAr = descriptionAr;
        ContactType = contactType;

        AddDomainEvent(new ConnectContactUpdatedEvent(this));
    }

    public void Deactivate()
    {
        if (!IsInactive)
        {
            IsInactive = true;
            AddDomainEvent(new ConnectContactDeactivatedEvent(this));
        }
    }

    public void Activate()
    {
        if (IsInactive)
        {
            IsInactive = false;
            AddDomainEvent(new ConnectContactActivatedEvent(this));
        }
    }
} 
using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a list of value select
/// يمثل اختيار قائمة القيم
/// </summary>
public class ListOfValueSelect : AuditableEntity
{
    /// <summary>
    /// The unique identifier for the select
    /// المعرف الفريد للاختيار
    /// </summary>
    public ListOfValueSelectId Id { get; private set; }

    /// <summary>
    /// The list of value ID
    /// معرف قائمة القيم
    /// </summary>
    public int ListOfValueId { get; private set; }

    /// <summary>
    /// The value code
    /// رمز القيمة
    /// </summary>
    public string ValueCode { get; private set; }

    /// <summary>
    /// The value name in English
    /// اسم القيمة باللغة الإنجليزية
    /// </summary>
    public string NameEn { get; private set; }

    /// <summary>
    /// The value name in Arabic
    /// اسم القيمة باللغة العربية
    /// </summary>
    public string NameAr { get; private set; }

    /// <summary>
    /// The value description in English
    /// وصف القيمة باللغة الإنجليزية
    /// </summary>
    public string DescriptionEn { get; private set; }

    /// <summary>
    /// The value description in Arabic
    /// وصف القيمة باللغة العربية
    /// </summary>
    public string DescriptionAr { get; private set; }

    /// <summary>
    /// The order number
    /// رقم الترتيب
    /// </summary>
    public int OrderNumber { get; private set; }

    /// <summary>
    /// Navigation property for the list of value relationship
    /// خاصية التنقل لعلاقة قائمة القيم
    /// </summary>
    public ListOfValue ListOfValue { get; private set; }

    private ListOfValueSelect() { } // For EF Core

    public ListOfValueSelect(
        int listOfValueId,
        string valueCode,
        string nameEn,
        string nameAr,
        string descriptionEn,
        string descriptionAr,
        int orderNumber)
    {
        Id = new ListOfValueSelectId(Guid.NewGuid());
        ListOfValueId = listOfValueId;
        ValueCode = valueCode;
        NameEn = nameEn;
        NameAr = nameAr;
        DescriptionEn = descriptionEn;
        DescriptionAr = descriptionAr;
        OrderNumber = orderNumber;

        AddDomainEvent(new ListOfValueSelectCreatedEvent(this));
    }

    public void Update(
        int listOfValueId,
        string valueCode,
        string nameEn,
        string nameAr,
        string descriptionEn,
        string descriptionAr,
        int orderNumber)
    {
        ListOfValueId = listOfValueId;
        ValueCode = valueCode;
        NameEn = nameEn;
        NameAr = nameAr;
        DescriptionEn = descriptionEn;
        DescriptionAr = descriptionAr;
        OrderNumber = orderNumber;

        AddDomainEvent(new ListOfValueSelectUpdatedEvent(this));
    }
} 
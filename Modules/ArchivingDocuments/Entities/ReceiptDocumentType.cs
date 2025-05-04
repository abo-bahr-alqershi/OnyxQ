using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Entities
{
/// <summary>
/// ReceiptDocumentType Entity
/// </summary>
public class ReceiptDocumentType : Entity<ReceiptDocumentTypeId>
{
    private ReceiptDocumentType() { }

    /// <summary>
    /// The unique identifier for the ReceiptDocumentType
    /// المعرف الفريد لـ ReceiptDocumentType
    /// </summary>
    public ReceiptDocumentTypeId Id { get; private set; }

    /// <summary>
    /// ReceiptTypeNumber of the ReceiptDocumentType
    /// ReceiptTypeNumber الخاص بـ ReceiptDocumentType
    /// </summary>
    public decimal? ReceiptTypeNumber { get; private set; }

    /// <summary>
    /// ReceiptNameArabic of the ReceiptDocumentType
    /// ReceiptNameArabic الخاص بـ ReceiptDocumentType
    /// </summary>
    public string ReceiptNameArabic { get; private set; }

    /// <summary>
    /// ReceiptNameEnglish of the ReceiptDocumentType
    /// ReceiptNameEnglish الخاص بـ ReceiptDocumentType
    /// </summary>
    public string ReceiptNameEnglish { get; private set; }
}
}

using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// ApprovedShowDocument Entity
/// </summary>
public class ApprovedShowDocument : Entity<ApprovedShowDocumentId>
{
    private ApprovedShowDocument() { }

    /// <summary>
    /// The unique identifier for the ApprovedShowDocument
    /// المعرف الفريد لـ ApprovedShowDocument
    /// </summary>
    public ApprovedShowDocumentId Id { get; private set; }

    /// <summary>
    /// DocTyp of the ApprovedShowDocument
    /// DocTyp الخاص بـ ApprovedShowDocument
    /// </summary>
    public decimal? DocTyp { get; private set; }

    /// <summary>
    /// FieldCount of the ApprovedShowDocument
    /// FieldCount الخاص بـ ApprovedShowDocument
    /// </summary>
    public decimal? FieldCount { get; private set; }

    /// <summary>
    /// DocSlct of the ApprovedShowDocument
    /// DocSlct الخاص بـ ApprovedShowDocument
    /// </summary>
    public string DocSlct { get; private set; }

    /// <summary>
    /// DocSlctWhr of the ApprovedShowDocument
    /// DocSlctWhr الخاص بـ ApprovedShowDocument
    /// </summary>
    public string DocSlctWhr { get; private set; }

    /// <summary>
    /// DocGrpBy of the ApprovedShowDocument
    /// DocGrpBy الخاص بـ ApprovedShowDocument
    /// </summary>
    public string DocGrpBy { get; private set; }

    /// <summary>
    /// DocSlctOrdr of the ApprovedShowDocument
    /// DocSlctOrdr الخاص بـ ApprovedShowDocument
    /// </summary>
    public string DocSlctOrdr { get; private set; }

    /// <summary>
    /// FieldLabel of the ApprovedShowDocument
    /// FieldLabel الخاص بـ ApprovedShowDocument
    /// </summary>
    public string FieldLabel { get; private set; }

    /// <summary>
    /// FieldWidth of the ApprovedShowDocument
    /// FieldWidth الخاص بـ ApprovedShowDocument
    /// </summary>
    public string FieldWidth { get; private set; }

    /// <summary>
    /// FieldDirection of the ApprovedShowDocument
    /// FieldDirection الخاص بـ ApprovedShowDocument
    /// </summary>
    public string FieldDirection { get; private set; }
}
}

using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// ApprovedShowDocumentSub Entity
/// </summary>
public class ApprovedShowDocumentSub : Entity<ApprovedShowDocumentSubId>
{
    private ApprovedShowDocumentSub() { }

    /// <summary>
    /// The unique identifier for the ApprovedShowDocumentSub
    /// المعرف الفريد لـ ApprovedShowDocumentSub
    /// </summary>
    public ApprovedShowDocumentSubId Id { get; private set; }

    /// <summary>
    /// DocTyp of the ApprovedShowDocumentSub
    /// DocTyp الخاص بـ ApprovedShowDocumentSub
    /// </summary>
    public decimal? DocTyp { get; private set; }

    /// <summary>
    /// FieldCount of the ApprovedShowDocumentSub
    /// FieldCount الخاص بـ ApprovedShowDocumentSub
    /// </summary>
    public decimal? FieldCount { get; private set; }

    /// <summary>
    /// DocSlct of the ApprovedShowDocumentSub
    /// DocSlct الخاص بـ ApprovedShowDocumentSub
    /// </summary>
    public string DocSlct { get; private set; }

    /// <summary>
    /// DocSlctWhr of the ApprovedShowDocumentSub
    /// DocSlctWhr الخاص بـ ApprovedShowDocumentSub
    /// </summary>
    public string DocSlctWhr { get; private set; }

    /// <summary>
    /// DocGrpBy of the ApprovedShowDocumentSub
    /// DocGrpBy الخاص بـ ApprovedShowDocumentSub
    /// </summary>
    public string DocGrpBy { get; private set; }

    /// <summary>
    /// DocSlctOrdr of the ApprovedShowDocumentSub
    /// DocSlctOrdr الخاص بـ ApprovedShowDocumentSub
    /// </summary>
    public string DocSlctOrdr { get; private set; }

    /// <summary>
    /// FieldLabel of the ApprovedShowDocumentSub
    /// FieldLabel الخاص بـ ApprovedShowDocumentSub
    /// </summary>
    public string FieldLabel { get; private set; }

    /// <summary>
    /// FieldWidth of the ApprovedShowDocumentSub
    /// FieldWidth الخاص بـ ApprovedShowDocumentSub
    /// </summary>
    public string FieldWidth { get; private set; }

    /// <summary>
    /// FieldDirection of the ApprovedShowDocumentSub
    /// FieldDirection الخاص بـ ApprovedShowDocumentSub
    /// </summary>
    public string FieldDirection { get; private set; }
}
}

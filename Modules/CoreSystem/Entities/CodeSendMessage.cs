using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// CodeSendMessage Entity
/// </summary>
public class CodeSendMessage : Entity<CodeSendMessageId>
{
    private CodeSendMessage() { }

    /// <summary>
    /// The unique identifier for the CodeSendMessage
    /// المعرف الفريد لـ CodeSendMessage
    /// </summary>
    public CodeSendMessageId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the CodeSendMessage
    /// RecordNumber الخاص بـ CodeSendMessage
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// CodeType of the CodeSendMessage
    /// CodeType الخاص بـ CodeSendMessage
    /// </summary>
    public decimal? CodeType { get; private set; }

    /// <summary>
    /// EmpNo of the CodeSendMessage
    /// EmpNo الخاص بـ CodeSendMessage
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// SendType of the CodeSendMessage
    /// SendType الخاص بـ CodeSendMessage
    /// </summary>
    public decimal? SendType { get; private set; }

    /// <summary>
    /// MobileNumber of the CodeSendMessage
    /// MobileNumber الخاص بـ CodeSendMessage
    /// </summary>
    public string MobileNumber { get; private set; }

    /// <summary>
    /// Email of the CodeSendMessage
    /// Email الخاص بـ CodeSendMessage
    /// </summary>
    public string Email { get; private set; }

    /// <summary>
    /// InactiveFlagAlt of the CodeSendMessage
    /// InactiveFlagAlt الخاص بـ CodeSendMessage
    /// </summary>
    public decimal? InactiveFlagAlt { get; private set; }

    /// <summary>
    /// InactiveDateAlt of the CodeSendMessage
    /// InactiveDateAlt الخاص بـ CodeSendMessage
    /// </summary>
    public DateTime? InactiveDateAlt { get; private set; }

    /// <summary>
    /// InactiveUserNumber of the CodeSendMessage
    /// InactiveUserNumber الخاص بـ CodeSendMessage
    /// </summary>
    public decimal? InactiveUserNumber { get; private set; }

    /// <summary>
    /// InactiveReasonAlt of the CodeSendMessage
    /// InactiveReasonAlt الخاص بـ CodeSendMessage
    /// </summary>
    public string InactiveReasonAlt { get; private set; }
}
}

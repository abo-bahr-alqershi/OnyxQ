using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Entities
{
/// <summary>
/// CodeDetail Entity
/// </summary>
public class CodeDetail : Entity<CodeDetailId>
{

    private CodeDetail() { }

    public CodeDetail(CodeDetailId id, decimal? codeNumber)
    {
        Id = id;
        CodeNumber = codeNumber;
    }

    /// <summary>
    /// The unique identifier for the CodeDetail
    /// المعرف الفريد لـ CodeDetail
    /// </summary>
    public CodeDetailId Id { get; private set; }

    /// <summary>
    /// CodeNumber of the CodeDetail
    /// CodeNumber الخاص بـ CodeDetail
    /// </summary>
    public decimal? CodeNumber { get; private set; }

    /// <summary>
    /// CodeLastName of the CodeDetail
    /// CodeLastName الخاص بـ CodeDetail
    /// </summary>
    public string CodeLastName { get; private set; }

    /// <summary>
    /// CodeFirstName of the CodeDetail
    /// CodeFirstName الخاص بـ CodeDetail
    /// </summary>
    public string CodeFirstName { get; private set; }

    /// <summary>
    /// OrderNumberShort of the CodeDetail
    /// OrderNumberShort الخاص بـ CodeDetail
    /// </summary>
    public decimal? OrderNumberShort { get; private set; }

    /// <summary>
    /// Notes of the CodeDetail
    /// Notes الخاص بـ CodeDetail
    /// </summary>
    public string Notes { get; private set; }

    /// <summary>
    /// InactiveFlag of the CodeDetail
    /// InactiveFlag الخاص بـ CodeDetail
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the CodeDetail
    /// InactiveReason الخاص بـ CodeDetail
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the CodeDetail
    /// InactiveDate الخاص بـ CodeDetail
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the CodeDetail
    /// InactivatedByUserId الخاص بـ CodeDetail
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CodeMaster CodeMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

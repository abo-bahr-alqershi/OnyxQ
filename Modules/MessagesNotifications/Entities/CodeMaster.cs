using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Entities
{
/// <summary>
/// CodeMaster Entity
/// </summary>
public class CodeMaster : Entity<CodeMasterId>
{
    private CodeMaster() { }

    /// <summary>
    /// The unique identifier for the CodeMaster
    /// المعرف الفريد لـ CodeMaster
    /// </summary>
    public CodeMasterId Id { get; private set; }

    /// <summary>
    /// CodeType of the CodeMaster
    /// CodeType الخاص بـ CodeMaster
    /// </summary>
    public decimal? CodeType { get; private set; }

    /// <summary>
    /// TypeLastNameShort of the CodeMaster
    /// TypeLastNameShort الخاص بـ CodeMaster
    /// </summary>
    public string TypeLastNameShort { get; private set; }

    /// <summary>
    /// TypeFirstNameShort of the CodeMaster
    /// TypeFirstNameShort الخاص بـ CodeMaster
    /// </summary>
    public string TypeFirstNameShort { get; private set; }

    /// <summary>
    /// OrderNumberShort of the CodeMaster
    /// OrderNumberShort الخاص بـ CodeMaster
    /// </summary>
    public decimal? OrderNumberShort { get; private set; }

    /// <summary>
    /// InactiveFlag of the CodeMaster
    /// InactiveFlag الخاص بـ CodeMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: CodeMaster to CodeDetail
    /// </summary>
    public IReadOnlyCollection<CodeDetail> CodeDetails { get; private set; }
    #endregion
}
}

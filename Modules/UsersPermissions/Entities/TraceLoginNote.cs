using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// TraceLoginNote Entity
/// </summary>
public class TraceLoginNote : Entity<TraceLoginNoteId>
{
    private TraceLoginNote() { }

    /// <summary>
    /// The unique identifier for the TraceLoginNote
    /// المعرف الفريد لـ TraceLoginNote
    /// </summary>
    public TraceLoginNoteId Id { get; private set; }

    /// <summary>
    /// NoteNumberShort of the TraceLoginNote
    /// NoteNumberShort الخاص بـ TraceLoginNote
    /// </summary>
    public decimal? NoteNumberShort { get; private set; }

    /// <summary>
    /// NoteDiscount of the TraceLoginNote
    /// NoteDiscount الخاص بـ TraceLoginNote
    /// </summary>
    public decimal? NoteDiscount { get; private set; }

    /// <summary>
    /// NoteDiscountUserId of the TraceLoginNote
    /// NoteDiscountUserId الخاص بـ TraceLoginNote
    /// </summary>
    public decimal? NoteDiscountUserId { get; private set; }

    /// <summary>
    /// NoteDiscountDate of the TraceLoginNote
    /// NoteDiscountDate الخاص بـ TraceLoginNote
    /// </summary>
    public DateTime? NoteDiscountDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the TraceLoginNote
    /// CompanyNumberShort الخاص بـ TraceLoginNote
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the TraceLoginNote
    /// BranchNumber الخاص بـ TraceLoginNote
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchUser of the TraceLoginNote
    /// BranchUser الخاص بـ TraceLoginNote
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// BranchYear of the TraceLoginNote
    /// BranchYear الخاص بـ TraceLoginNote
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// TerminalName of the TraceLoginNote
    /// TerminalName الخاص بـ TraceLoginNote
    /// </summary>
    public string TerminalName { get; private set; }
}
}

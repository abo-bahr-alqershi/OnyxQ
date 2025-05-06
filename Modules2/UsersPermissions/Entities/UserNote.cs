using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;
namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// UserNote Entity
/// </summary>
public class UserNote : Entity<UserNoteId>
{

    private UserNote() { }

    public UserNote(UserNoteId id, decimal? noteNumber)
    {
        Id = id;
        NoteNumber = noteNumber;
    }

    /// <summary>
    /// The unique identifier for the UserNote
    /// المعرف الفريد لـ UserNote
    /// </summary>
    public UserNoteId Id { get; private set; }

    /// <summary>
    /// NoteNumber of the UserNote
    /// NoteNumber الخاص بـ UserNote
    /// </summary>
    public decimal? NoteNumber { get; private set; }

    /// <summary>
    /// NoteDate of the UserNote
    /// NoteDate الخاص بـ UserNote
    /// </summary>
    public DateTime? NoteDate { get; private set; }

    /// <summary>
    /// NoteDescription of the UserNote
    /// NoteDescription الخاص بـ UserNote
    /// </summary>
    public string NoteDescription { get; private set; }

    /// <summary>
    /// AlertNote of the UserNote
    /// AlertNote الخاص بـ UserNote
    /// </summary>
    public decimal? AlertNote { get; private set; }

    /// <summary>
    /// AlertDate of the UserNote
    /// AlertDate الخاص بـ UserNote
    /// </summary>
    public DateTime? AlertDate { get; private set; }

    /// <summary>
    /// NoteReadFlag of the UserNote
    /// NoteReadFlag الخاص بـ UserNote
    /// </summary>
    public decimal? NoteReadFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the UserNote
    /// CompanyNumberShort الخاص بـ UserNote
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the UserNote
    /// BranchNumber الخاص بـ UserNote
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the UserNote
    /// BranchYear الخاص بـ UserNote
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the UserNote
    /// BranchUser الخاص بـ UserNote
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}


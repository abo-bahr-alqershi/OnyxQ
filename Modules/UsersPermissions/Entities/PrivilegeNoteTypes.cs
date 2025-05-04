using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ArchivingDocuments.Entities;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// PrivilegeNoteTypes Entity
/// </summary>
public class PrivilegeNoteTypes : Entity<PrivilegeNoteTypesId>
{
    private PrivilegeNoteTypes() { }

    /// <summary>
    /// The unique identifier for the PrivilegeNoteTypes
    /// المعرف الفريد لـ PrivilegeNoteTypes
    /// </summary>
    public PrivilegeNoteTypesId Id { get; private set; }

    /// <summary>
    /// UserId of the PrivilegeNoteTypes
    /// UserId الخاص بـ PrivilegeNoteTypes
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// NoteTypeNumber of the PrivilegeNoteTypes
    /// NoteTypeNumber الخاص بـ PrivilegeNoteTypes
    /// </summary>
    public decimal? NoteTypeNumber { get; private set; }

    /// <summary>
    /// AdditionalFlag of the PrivilegeNoteTypes
    /// AdditionalFlag الخاص بـ PrivilegeNoteTypes
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the PrivilegeNoteTypes
    /// ViewFlag الخاص بـ PrivilegeNoteTypes
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to NoteType
    /// </summary>
    public NoteType NoteType { get; private set; }
    #endregion
}
}

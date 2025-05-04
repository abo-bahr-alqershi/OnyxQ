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

    public PrivilegeNoteTypes(PrivilegeNoteTypesId id, decimal? userId)
    {
        Id = id;
        UserId = userId;
    }

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
    /// Reference relationship: ManyToOne
    /// </summary>
    public NoteType NoteType { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

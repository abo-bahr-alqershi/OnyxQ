using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

using ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects;
namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Entities
{
/// <summary>
/// NoteType Entity
/// </summary>
public class NoteType : Entity<NoteTypeId>
{

    private NoteType() { }

    public NoteType(NoteTypeId id, decimal? noteTypeNumber)
    {
        Id = id;
        NoteTypeNumber = noteTypeNumber;
    }

    /// <summary>
    /// The unique identifier for the NoteType
    /// المعرف الفريد لـ NoteType
    /// </summary>
    public NoteTypeId Id { get; private set; }

    /// <summary>
    /// NoteType of the NoteType
    /// NoteType الخاص بـ NoteType
    /// </summary>
    public decimal? NoteType { get; private set; }

    /// <summary>
    /// NoteTypeNumber of the NoteType
    /// NoteTypeNumber الخاص بـ NoteType
    /// </summary>
    public decimal? NoteTypeNumber { get; private set; }

    /// <summary>
    /// NoteNameArabic of the NoteType
    /// NoteNameArabic الخاص بـ NoteType
    /// </summary>
    public string NoteNameArabic { get; private set; }

    /// <summary>
    /// NoteNameEnglish of the NoteType
    /// NoteNameEnglish الخاص بـ NoteType
    /// </summary>
    public string NoteNameEnglish { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}


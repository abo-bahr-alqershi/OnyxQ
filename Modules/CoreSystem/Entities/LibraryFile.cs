using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// LibraryFile Entity
/// </summary>
public class LibraryFile : Entity<LibraryFileId>
{
    private LibraryFile() { }

    /// <summary>
    /// The unique identifier for the LibraryFile
    /// المعرف الفريد لـ LibraryFile
    /// </summary>
    public LibraryFileId Id { get; private set; }

    /// <summary>
    /// FileName of the LibraryFile
    /// FileName الخاص بـ LibraryFile
    /// </summary>
    public string FileName { get; private set; }

    /// <summary>
    /// LibraryVersionUpdate of the LibraryFile
    /// LibraryVersionUpdate الخاص بـ LibraryFile
    /// </summary>
    public string LibraryVersionUpdate { get; private set; }

    /// <summary>
    /// CreatedDate of the LibraryFile
    /// CreatedDate الخاص بـ LibraryFile
    /// </summary>
    public DateTime? CreatedDate { get; private set; }

    /// <summary>
    /// AccessedDate of the LibraryFile
    /// AccessedDate الخاص بـ LibraryFile
    /// </summary>
    public DateTime? AccessedDate { get; private set; }

    /// <summary>
    /// ModifiedDate of the LibraryFile
    /// ModifiedDate الخاص بـ LibraryFile
    /// </summary>
    public DateTime? ModifiedDate { get; private set; }

    /// <summary>
    /// FileSize of the LibraryFile
    /// FileSize الخاص بـ LibraryFile
    /// </summary>
    public decimal? FileSize { get; private set; }
}
}

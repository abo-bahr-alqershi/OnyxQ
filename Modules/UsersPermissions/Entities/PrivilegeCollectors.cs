using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// PrivilegeCollectors Entity
/// </summary>
public class PrivilegeCollectors : Entity<PrivilegeCollectorsId>
{
    private PrivilegeCollectors() { }

    /// <summary>
    /// The unique identifier for the PrivilegeCollectors
    /// المعرف الفريد لـ PrivilegeCollectors
    /// </summary>
    public PrivilegeCollectorsId Id { get; private set; }

    /// <summary>
    /// UserId of the PrivilegeCollectors
    /// UserId الخاص بـ PrivilegeCollectors
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the PrivilegeCollectors
    /// ColumnNumberShort الخاص بـ PrivilegeCollectors
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// AdditionalFlag of the PrivilegeCollectors
    /// AdditionalFlag الخاص بـ PrivilegeCollectors
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the PrivilegeCollectors
    /// ViewFlag الخاص بـ PrivilegeCollectors
    /// </summary>
    public decimal? ViewFlag { get; private set; }
}
}

using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Entities
{
/// <summary>
/// MandatoryScreen Entity
/// </summary>
public class MandatoryScreen : Entity<MandatoryScreenId>
{
    private MandatoryScreen() { }

    /// <summary>
    /// The unique identifier for the MandatoryScreen
    /// المعرف الفريد لـ MandatoryScreen
    /// </summary>
    public MandatoryScreenId Id { get; private set; }

    /// <summary>
    /// FormNumber of the MandatoryScreen
    /// FormNumber الخاص بـ MandatoryScreen
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// TableName of the MandatoryScreen
    /// TableName الخاص بـ MandatoryScreen
    /// </summary>
    public string TableName { get; private set; }

    /// <summary>
    /// ExceptedColumns of the MandatoryScreen
    /// ExceptedColumns الخاص بـ MandatoryScreen
    /// </summary>
    public string ExceptedColumns { get; private set; }
}
}

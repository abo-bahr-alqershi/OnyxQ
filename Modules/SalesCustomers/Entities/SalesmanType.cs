using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesmanType Entity
/// </summary>
public class SalesmanType : Entity<SalesmanTypeId>
{
    private SalesmanType() { }

    /// <summary>
    /// The unique identifier for the SalesmanType
    /// المعرف الفريد لـ SalesmanType
    /// </summary>
    public SalesmanTypeId Id { get; private set; }

    /// <summary>
    /// SalesmanType of the SalesmanType
    /// SalesmanType الخاص بـ SalesmanType
    /// </summary>
    public decimal? SalesmanType { get; private set; }

    /// <summary>
    /// SalesmanTypeNameArabic of the SalesmanType
    /// SalesmanTypeNameArabic الخاص بـ SalesmanType
    /// </summary>
    public string SalesmanTypeNameArabic { get; private set; }

    /// <summary>
    /// SalesmanTypeNameEnglish of the SalesmanType
    /// SalesmanTypeNameEnglish الخاص بـ SalesmanType
    /// </summary>
    public string SalesmanTypeNameEnglish { get; private set; }

    /// <summary>
    /// ConnectionSpecialSalesman of the SalesmanType
    /// ConnectionSpecialSalesman الخاص بـ SalesmanType
    /// </summary>
    public decimal? ConnectionSpecialSalesman { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: SalesmanType to Salesman
    /// </summary>
    public IReadOnlyCollection<Salesman> Salesmans { get; private set; }
    /// <summary>
    /// One-to-many relationship: SalesmanType to SalesmanCollectionConditionDetail
    /// </summary>
    public IReadOnlyCollection<SalesmanCollectionConditionDetail> SalesmanCollectionConditionDetails { get; private set; }
    #endregion
}
}

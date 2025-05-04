using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.Entities
{
/// <summary>
/// InsuranceClassGroupItemOut Entity
/// </summary>
public class InsuranceClassGroupItemOut : Entity<InsuranceClassGroupItemOutId>
{
    private InsuranceClassGroupItemOut() { }

    /// <summary>
    /// The unique identifier for the InsuranceClassGroupItemOut
    /// المعرف الفريد لـ InsuranceClassGroupItemOut
    /// </summary>
    public InsuranceClassGroupItemOutId Id { get; private set; }

    /// <summary>
    /// InsuranceCompanyNumberAlt of the InsuranceClassGroupItemOut
    /// InsuranceCompanyNumberAlt الخاص بـ InsuranceClassGroupItemOut
    /// </summary>
    public decimal? InsuranceCompanyNumberAlt { get; private set; }

    /// <summary>
    /// ClassNumber of the InsuranceClassGroupItemOut
    /// ClassNumber الخاص بـ InsuranceClassGroupItemOut
    /// </summary>
    public string ClassNumber { get; private set; }

    /// <summary>
    /// InsuranceGroupNumber of the InsuranceClassGroupItemOut
    /// InsuranceGroupNumber الخاص بـ InsuranceClassGroupItemOut
    /// </summary>
    public decimal? InsuranceGroupNumber { get; private set; }

    /// <summary>
    /// OutgoingType of the InsuranceClassGroupItemOut
    /// OutgoingType الخاص بـ InsuranceClassGroupItemOut
    /// </summary>
    public decimal? OutgoingType { get; private set; }

    /// <summary>
    /// OutgoingTypeChronic of the InsuranceClassGroupItemOut
    /// OutgoingTypeChronic الخاص بـ InsuranceClassGroupItemOut
    /// </summary>
    public decimal? OutgoingTypeChronic { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to InsuranceCompanyClass
    /// </summary>
    public InsuranceCompanyClass InsuranceCompanyClass { get; private set; }
    /// <summary>
    /// ManyToOne relationship to InsuranceItemGroupMaster
    /// </summary>
    public InsuranceItemGroupMaster InsuranceItemGroupMaster { get; private set; }
    #endregion
}
}

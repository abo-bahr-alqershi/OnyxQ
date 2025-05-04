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
    private readonly List<InsuranceCompanyClass> _insuranceCompanyClass = new List<InsuranceCompanyClass>();
    private readonly List<InsuranceItemGroupMaster> _insuranceItemGroupMaster = new List<InsuranceItemGroupMaster>();

    private InsuranceClassGroupItemOut() { }

    public InsuranceClassGroupItemOut(InsuranceClassGroupItemOutId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the InsuranceClassGroupItemOut
    /// المعرف الفريد لـ InsuranceClassGroupItemOut
    /// </summary>
    public InsuranceClassGroupItemOutId Id { get; private set; }

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
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<InsuranceCompanyClass> InsuranceCompanyClass => _insuranceCompanyClass;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<InsuranceItemGroupMaster> InsuranceItemGroupMaster => _insuranceItemGroupMaster;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

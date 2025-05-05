using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects;
namespace ERP_Pro.Domain.ERP.InsuranceClaims.Entities
{
/// <summary>
/// InsuranceClaimDetail Entity
/// </summary>
public class InsuranceClaimDetail : Entity<InsuranceClaimDetailId>
{

    private InsuranceClaimDetail() { }

    public InsuranceClaimDetail(InsuranceClaimDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the InsuranceClaimDetail
    /// المعرف الفريد لـ InsuranceClaimDetail
    /// </summary>
    public InsuranceClaimDetailId Id { get; private set; }

    /// <summary>
    /// BranchNumber of the InsuranceClaimDetail
    /// BranchNumber الخاص بـ InsuranceClaimDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// DocNo of the InsuranceClaimDetail
    /// DocNo الخاص بـ InsuranceClaimDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// BillNumber of the InsuranceClaimDetail
    /// BillNumber الخاص بـ InsuranceClaimDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the InsuranceClaimDetail
    /// BillSerial الخاص بـ InsuranceClaimDetail
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// BillType of the InsuranceClaimDetail
    /// BillType الخاص بـ InsuranceClaimDetail
    /// </summary>
    public decimal? BillType { get; private set; }

    /// <summary>
    /// BillDate of the InsuranceClaimDetail
    /// BillDate الخاص بـ InsuranceClaimDetail
    /// </summary>
    public DateTime? BillDate { get; private set; }

    /// <summary>
    /// InsurancePersonName of the InsuranceClaimDetail
    /// InsurancePersonName الخاص بـ InsuranceClaimDetail
    /// </summary>
    public string InsurancePersonName { get; private set; }

    /// <summary>
    /// InsuranceCardNumber of the InsuranceClaimDetail
    /// InsuranceCardNumber الخاص بـ InsuranceClaimDetail
    /// </summary>
    public string InsuranceCardNumber { get; private set; }

    /// <summary>
    /// BillAmount of the InsuranceClaimDetail
    /// BillAmount الخاص بـ InsuranceClaimDetail
    /// </summary>
    public decimal? BillAmount { get; private set; }

    /// <summary>
    /// InsuranceLoadAmount of the InsuranceClaimDetail
    /// InsuranceLoadAmount الخاص بـ InsuranceClaimDetail
    /// </summary>
    public decimal? InsuranceLoadAmount { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimit of the InsuranceClaimDetail
    /// InsuranceAdditionalLimit الخاص بـ InsuranceClaimDetail
    /// </summary>
    public decimal? InsuranceAdditionalLimit { get; private set; }

    /// <summary>
    /// DiscAmt of the InsuranceClaimDetail
    /// DiscAmt الخاص بـ InsuranceClaimDetail
    /// </summary>
    public decimal? DiscAmt { get; private set; }

    /// <summary>
    /// NetAmount of the InsuranceClaimDetail
    /// NetAmount الخاص بـ InsuranceClaimDetail
    /// </summary>
    public decimal? NetAmount { get; private set; }

    /// <summary>
    /// InsuranceBenefitNumber of the InsuranceClaimDetail
    /// InsuranceBenefitNumber الخاص بـ InsuranceClaimDetail
    /// </summary>
    public decimal? InsuranceBenefitNumber { get; private set; }

    /// <summary>
    /// InsuranceMedicalNumber of the InsuranceClaimDetail
    /// InsuranceMedicalNumber الخاص بـ InsuranceClaimDetail
    /// </summary>
    public decimal? InsuranceMedicalNumber { get; private set; }

    /// <summary>
    /// InsuranceApprovedCode of the InsuranceClaimDetail
    /// InsuranceApprovedCode الخاص بـ InsuranceClaimDetail
    /// </summary>
    public string InsuranceApprovedCode { get; private set; }

    /// <summary>
    /// InsuranceCompanyNumber of the InsuranceClaimDetail
    /// InsuranceCompanyNumber الخاص بـ InsuranceClaimDetail
    /// </summary>
    public decimal? InsuranceCompanyNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public InsuranceClaimMaster InsuranceClaimMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}


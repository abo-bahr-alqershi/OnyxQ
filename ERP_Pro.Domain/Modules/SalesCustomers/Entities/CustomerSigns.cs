using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerSigns Entity
/// </summary>
public class CustomerSigns : Entity<CustomerSignsId>
{

    private CustomerSigns() { }

    public CustomerSigns(CustomerSignsId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the CustomerSigns
    /// المعرف الفريد لـ CustomerSigns
    /// </summary>
    public CustomerSignsId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the CustomerSigns
    /// RecordNumber الخاص بـ CustomerSigns
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// SignatureImageName of the CustomerSigns
    /// SignatureImageName الخاص بـ CustomerSigns
    /// </summary>
    public string SignatureImageName { get; private set; }

    /// <summary>
    /// TypeCredit of the CustomerSigns
    /// TypeCredit الخاص بـ CustomerSigns
    /// </summary>
    public decimal? TypeCredit { get; private set; }

    /// <summary>
    /// CreditNumber of the CustomerSigns
    /// CreditNumber الخاص بـ CustomerSigns
    /// </summary>
    public string CreditNumber { get; private set; }

    /// <summary>
    /// RepSerial of the CustomerSigns
    /// RepSerial الخاص بـ CustomerSigns
    /// </summary>
    public decimal? RepSerial { get; private set; }

    /// <summary>
    /// ReceiveType of the CustomerSigns
    /// ReceiveType الخاص بـ CustomerSigns
    /// </summary>
    public decimal? ReceiveType { get; private set; }

    /// <summary>
    /// ApprovalField of the CustomerSigns
    /// ApprovalField الخاص بـ CustomerSigns
    /// </summary>
    public decimal? ApprovalField { get; private set; }

    /// <summary>
    /// ApprovalFieldDescription of the CustomerSigns
    /// ApprovalFieldDescription الخاص بـ CustomerSigns
    /// </summary>
    public string ApprovalFieldDescription { get; private set; }

    /// <summary>
    /// ApprovalFieldUserId of the CustomerSigns
    /// ApprovalFieldUserId الخاص بـ CustomerSigns
    /// </summary>
    public decimal? ApprovalFieldUserId { get; private set; }

    /// <summary>
    /// ApprovalFieldDate of the CustomerSigns
    /// ApprovalFieldDate الخاص بـ CustomerSigns
    /// </summary>
    public DateTime? ApprovalFieldDate { get; private set; }

    /// <summary>
    /// TableRowId of the CustomerSigns
    /// TableRowId الخاص بـ CustomerSigns
    /// </summary>
    public string TableRowId { get; private set; }

    /// <summary>
    /// BeneficiaryMobile of the CustomerSigns
    /// BeneficiaryMobile الخاص بـ CustomerSigns
    /// </summary>
    public string BeneficiaryMobile { get; private set; }

    /// <summary>
    /// BeneficiaryNameFull of the CustomerSigns
    /// BeneficiaryNameFull الخاص بـ CustomerSigns
    /// </summary>
    public string BeneficiaryNameFull { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Customer Customer { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

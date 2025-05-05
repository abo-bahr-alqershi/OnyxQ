using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;
namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// UserHead Entity
/// </summary>
public class UserHead : Entity<UserHeadId>
{

    private UserHead() { }

    public UserHead(UserHeadId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the UserHead
    /// المعرف الفريد لـ UserHead
    /// </summary>
    public UserHeadId Id { get; private set; }

    /// <summary>
    /// BranchYear of the UserHead
    /// BranchYear الخاص بـ UserHead
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the UserHead
    /// CompanyNumberShort الخاص بـ UserHead
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the UserHead
    /// BranchNumber الخاص بـ UserHead
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// CompanyNameArabic of the UserHead
    /// CompanyNameArabic الخاص بـ UserHead
    /// </summary>
    public string CompanyNameArabic { get; private set; }

    /// <summary>
    /// CompanyNameEnglish of the UserHead
    /// CompanyNameEnglish الخاص بـ UserHead
    /// </summary>
    public string CompanyNameEnglish { get; private set; }

    /// <summary>
    /// BranchDescriptionArabic of the UserHead
    /// BranchDescriptionArabic الخاص بـ UserHead
    /// </summary>
    public string BranchDescriptionArabic { get; private set; }

    /// <summary>
    /// BranchDescriptionEnglish of the UserHead
    /// BranchDescriptionEnglish الخاص بـ UserHead
    /// </summary>
    public string BranchDescriptionEnglish { get; private set; }

    /// <summary>
    /// BranchAddressArabic of the UserHead
    /// BranchAddressArabic الخاص بـ UserHead
    /// </summary>
    public string BranchAddressArabic { get; private set; }

    /// <summary>
    /// BranchAddressEnglish of the UserHead
    /// BranchAddressEnglish الخاص بـ UserHead
    /// </summary>
    public string BranchAddressEnglish { get; private set; }

    /// <summary>
    /// BranchTelephoneArabic of the UserHead
    /// BranchTelephoneArabic الخاص بـ UserHead
    /// </summary>
    public string BranchTelephoneArabic { get; private set; }

    /// <summary>
    /// BranchTelephoneEnglish of the UserHead
    /// BranchTelephoneEnglish الخاص بـ UserHead
    /// </summary>
    public string BranchTelephoneEnglish { get; private set; }

    /// <summary>
    /// BranchFaxArabic of the UserHead
    /// BranchFaxArabic الخاص بـ UserHead
    /// </summary>
    public string BranchFaxArabic { get; private set; }

    /// <summary>
    /// BranchFaxEnglish of the UserHead
    /// BranchFaxEnglish الخاص بـ UserHead
    /// </summary>
    public string BranchFaxEnglish { get; private set; }

    /// <summary>
    /// BranchBoxArabic of the UserHead
    /// BranchBoxArabic الخاص بـ UserHead
    /// </summary>
    public string BranchBoxArabic { get; private set; }

    /// <summary>
    /// BranchBoxEnglish of the UserHead
    /// BranchBoxEnglish الخاص بـ UserHead
    /// </summary>
    public string BranchBoxEnglish { get; private set; }

    /// <summary>
    /// CompanyImage of the UserHead
    /// CompanyImage الخاص بـ UserHead
    /// </summary>
    public string CompanyImage { get; private set; }

    /// <summary>
    /// BranchUser of the UserHead
    /// BranchUser الخاص بـ UserHead
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ReportHeaderType of the UserHead
    /// ReportHeaderType الخاص بـ UserHead
    /// </summary>
    public decimal? ReportHeaderType { get; private set; }

    /// <summary>
    /// ReportHeaderImage of the UserHead
    /// ReportHeaderImage الخاص بـ UserHead
    /// </summary>
    public byte[] ReportHeaderImage { get; private set; }

    /// <summary>
    /// ReportHeaderImageName of the UserHead
    /// ReportHeaderImageName الخاص بـ UserHead
    /// </summary>
    public string ReportHeaderImageName { get; private set; }

    /// <summary>
    /// ReportHeaderImageNameH of the UserHead
    /// ReportHeaderImageNameH الخاص بـ UserHead
    /// </summary>
    public string ReportHeaderImageNameH { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: OneToOne
    /// </summary>
    public User User { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}


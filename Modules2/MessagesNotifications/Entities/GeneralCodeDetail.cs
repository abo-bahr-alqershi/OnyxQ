using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects;
namespace ERP_Pro.Domain.ERP.MessagesNotifications.Entities
{
/// <summary>
/// GeneralCodeDetail Entity
/// </summary>
public class GeneralCodeDetail : Entity<GeneralCodeDetailId>
{

    private GeneralCodeDetail() { }

    public GeneralCodeDetail(GeneralCodeDetailId id, decimal? subNumber)
    {
        Id = id;
        SubNumber = subNumber;
    }

    /// <summary>
    /// The unique identifier for the GeneralCodeDetail
    /// المعرف الفريد لـ GeneralCodeDetail
    /// </summary>
    public GeneralCodeDetailId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the GeneralCodeDetail
    /// RecordNumber الخاص بـ GeneralCodeDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// SubNumber of the GeneralCodeDetail
    /// SubNumber الخاص بـ GeneralCodeDetail
    /// </summary>
    public decimal? SubNumber { get; private set; }

    /// <summary>
    /// SubLastName of the GeneralCodeDetail
    /// SubLastName الخاص بـ GeneralCodeDetail
    /// </summary>
    public string SubLastName { get; private set; }

    /// <summary>
    /// SubFirstName of the GeneralCodeDetail
    /// SubFirstName الخاص بـ GeneralCodeDetail
    /// </summary>
    public string SubFirstName { get; private set; }

    /// <summary>
    /// SubNumberLength of the GeneralCodeDetail
    /// SubNumberLength الخاص بـ GeneralCodeDetail
    /// </summary>
    public decimal? SubNumberLength { get; private set; }

    /// <summary>
    /// HasPrivilege of the GeneralCodeDetail
    /// HasPrivilege الخاص بـ GeneralCodeDetail
    /// </summary>
    public decimal? HasPrivilege { get; private set; }

    /// <summary>
    /// InactiveFlagAlt of the GeneralCodeDetail
    /// InactiveFlagAlt الخاص بـ GeneralCodeDetail
    /// </summary>
    public decimal? InactiveFlagAlt { get; private set; }

    /// <summary>
    /// InactiveReasonAlt of the GeneralCodeDetail
    /// InactiveReasonAlt الخاص بـ GeneralCodeDetail
    /// </summary>
    public string InactiveReasonAlt { get; private set; }

    /// <summary>
    /// InactiveDateAlt of the GeneralCodeDetail
    /// InactiveDateAlt الخاص بـ GeneralCodeDetail
    /// </summary>
    public DateTime? InactiveDateAlt { get; private set; }

    /// <summary>
    /// InactiveUserId of the GeneralCodeDetail
    /// InactiveUserId الخاص بـ GeneralCodeDetail
    /// </summary>
    public decimal? InactiveUserId { get; private set; }

    /// <summary>
    /// SubNumberDiscountType of the GeneralCodeDetail
    /// SubNumberDiscountType الخاص بـ GeneralCodeDetail
    /// </summary>
    public decimal? SubNumberDiscountType { get; private set; }

    /// <summary>
    /// SubNumberStart of the GeneralCodeDetail
    /// SubNumberStart الخاص بـ GeneralCodeDetail
    /// </summary>
    public string SubNumberStart { get; private set; }

    /// <summary>
    /// JobType of the GeneralCodeDetail
    /// JobType الخاص بـ GeneralCodeDetail
    /// </summary>
    public decimal? JobType { get; private set; }

    /// <summary>
    /// HasRisk of the GeneralCodeDetail
    /// HasRisk الخاص بـ GeneralCodeDetail
    /// </summary>
    public decimal? HasRisk { get; private set; }

    /// <summary>
    /// NationalityNumber of the GeneralCodeDetail
    /// NationalityNumber الخاص بـ GeneralCodeDetail
    /// </summary>
    public decimal? NationalityNumber { get; private set; }

    /// <summary>
    /// DfltSlry of the GeneralCodeDetail
    /// DfltSlry الخاص بـ GeneralCodeDetail
    /// </summary>
    public decimal? DfltSlry { get; private set; }

    /// <summary>
    /// DownLeftCrnr of the GeneralCodeDetail
    /// DownLeftCrnr الخاص بـ GeneralCodeDetail
    /// </summary>
    public decimal? DownLeftCrnr { get; private set; }

    /// <summary>
    /// DownRghtCrnr of the GeneralCodeDetail
    /// DownRghtCrnr الخاص بـ GeneralCodeDetail
    /// </summary>
    public decimal? DownRghtCrnr { get; private set; }

    /// <summary>
    /// TopLeftCorner of the GeneralCodeDetail
    /// TopLeftCorner الخاص بـ GeneralCodeDetail
    /// </summary>
    public decimal? TopLeftCorner { get; private set; }

    /// <summary>
    /// TopRightCorner of the GeneralCodeDetail
    /// TopRightCorner الخاص بـ GeneralCodeDetail
    /// </summary>
    public decimal? TopRightCorner { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public GeneralCodeMaster GeneralCodeMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}


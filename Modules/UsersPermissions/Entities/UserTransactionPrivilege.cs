using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// UserTransactionPrivilege Entity
/// </summary>
public class UserTransactionPrivilege : Entity<UserTransactionPrivilegeId>
{
    private UserTransactionPrivilege() { }

    /// <summary>
    /// The unique identifier for the UserTransactionPrivilege
    /// المعرف الفريد لـ UserTransactionPrivilege
    /// </summary>
    public UserTransactionPrivilegeId Id { get; private set; }

    /// <summary>
    /// UserId of the UserTransactionPrivilege
    /// UserId الخاص بـ UserTransactionPrivilege
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// AllowExceedHolidayBalance of the UserTransactionPrivilege
    /// AllowExceedHolidayBalance الخاص بـ UserTransactionPrivilege
    /// </summary>
    public decimal? AllowExceedHolidayBalance { get; private set; }

    /// <summary>
    /// AllowExceedArticleLimit of the UserTransactionPrivilege
    /// AllowExceedArticleLimit الخاص بـ UserTransactionPrivilege
    /// </summary>
    public decimal? AllowExceedArticleLimit { get; private set; }

    /// <summary>
    /// AllowExceedMedicalMaxLimit of the UserTransactionPrivilege
    /// AllowExceedMedicalMaxLimit الخاص بـ UserTransactionPrivilege
    /// </summary>
    public decimal? AllowExceedMedicalMaxLimit { get; private set; }

    /// <summary>
    /// AllowExceedLoanLimit of the UserTransactionPrivilege
    /// AllowExceedLoanLimit الخاص بـ UserTransactionPrivilege
    /// </summary>
    public decimal? AllowExceedLoanLimit { get; private set; }

    /// <summary>
    /// AllowChangeHolidayDuration of the UserTransactionPrivilege
    /// AllowChangeHolidayDuration الخاص بـ UserTransactionPrivilege
    /// </summary>
    public decimal? AllowChangeHolidayDuration { get; private set; }

    /// <summary>
    /// AllowRetrieveSignatureExternalFile of the UserTransactionPrivilege
    /// AllowRetrieveSignatureExternalFile الخاص بـ UserTransactionPrivilege
    /// </summary>
    public decimal? AllowRetrieveSignatureExternalFile { get; private set; }

    /// <summary>
    /// AllowDeleteFingerprintDeviceLog of the UserTransactionPrivilege
    /// AllowDeleteFingerprintDeviceLog الخاص بـ UserTransactionPrivilege
    /// </summary>
    public decimal? AllowDeleteFingerprintDeviceLog { get; private set; }

    /// <summary>
    /// AllowUpdateEmployeeStartWork of the UserTransactionPrivilege
    /// AllowUpdateEmployeeStartWork الخاص بـ UserTransactionPrivilege
    /// </summary>
    public decimal? AllowUpdateEmployeeStartWork { get; private set; }
}
}

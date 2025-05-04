using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Entities
{
/// <summary>
/// GeneralCardIdentity Entity
/// </summary>
public class GeneralCardIdentity : Entity<GeneralCardIdentityId>
{

    private GeneralCardIdentity() { }

    public GeneralCardIdentity(GeneralCardIdentityId id, string typeCode, decimal? typeNumberShort, decimal? identityType, string identityNumber)
    {
        Id = id;
        TypeCode = typeCode;
        TypeNumberShort = typeNumberShort;
        IdentityType = identityType;
        IdentityNumber = identityNumber;
    }

    /// <summary>
    /// The unique identifier for the GeneralCardIdentity
    /// المعرف الفريد لـ GeneralCardIdentity
    /// </summary>
    public GeneralCardIdentityId Id { get; private set; }

    /// <summary>
    /// TypeCode of the GeneralCardIdentity
    /// TypeCode الخاص بـ GeneralCardIdentity
    /// </summary>
    public string TypeCode { get; private set; }

    /// <summary>
    /// TypeNumberShort of the GeneralCardIdentity
    /// TypeNumberShort الخاص بـ GeneralCardIdentity
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// IdentityType of the GeneralCardIdentity
    /// IdentityType الخاص بـ GeneralCardIdentity
    /// </summary>
    public decimal? IdentityType { get; private set; }

    /// <summary>
    /// IdentityNumber of the GeneralCardIdentity
    /// IdentityNumber الخاص بـ GeneralCardIdentity
    /// </summary>
    public string IdentityNumber { get; private set; }

    /// <summary>
    /// IssuePlaceShort of the GeneralCardIdentity
    /// IssuePlaceShort الخاص بـ GeneralCardIdentity
    /// </summary>
    public string IssuePlaceShort { get; private set; }

    /// <summary>
    /// IssueDate of the GeneralCardIdentity
    /// IssueDate الخاص بـ GeneralCardIdentity
    /// </summary>
    public DateTime? IssueDate { get; private set; }

    /// <summary>
    /// IssueDateHijri of the GeneralCardIdentity
    /// IssueDateHijri الخاص بـ GeneralCardIdentity
    /// </summary>
    public DateTime? IssueDateHijri { get; private set; }

    /// <summary>
    /// ExpenseDate of the GeneralCardIdentity
    /// ExpenseDate الخاص بـ GeneralCardIdentity
    /// </summary>
    public DateTime? ExpenseDate { get; private set; }

    /// <summary>
    /// ExpenseDateHijri of the GeneralCardIdentity
    /// ExpenseDateHijri الخاص بـ GeneralCardIdentity
    /// </summary>
    public DateTime? ExpenseDateHijri { get; private set; }

    /// <summary>
    /// RecordNumber of the GeneralCardIdentity
    /// RecordNumber الخاص بـ GeneralCardIdentity
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

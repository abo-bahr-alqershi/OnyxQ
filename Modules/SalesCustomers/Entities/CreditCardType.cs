using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CreditCardType Entity
/// </summary>
public class CreditCardType : Entity<CreditCardTypeId>
{
    private CreditCardType() { }

    /// <summary>
    /// The unique identifier for the CreditCardType
    /// المعرف الفريد لـ CreditCardType
    /// </summary>
    public CreditCardTypeId Id { get; private set; }

    /// <summary>
    /// CreditCardTypeFull of the CreditCardType
    /// CreditCardTypeFull الخاص بـ CreditCardType
    /// </summary>
    public decimal? CreditCardTypeFull { get; private set; }

    /// <summary>
    /// CardNameArabic of the CreditCardType
    /// CardNameArabic الخاص بـ CreditCardType
    /// </summary>
    public string CardNameArabic { get; private set; }

    /// <summary>
    /// CardNameEnglish of the CreditCardType
    /// CardNameEnglish الخاص بـ CreditCardType
    /// </summary>
    public string CardNameEnglish { get; private set; }

    /// <summary>
    /// CardSecondAddress of the CreditCardType
    /// CardSecondAddress الخاص بـ CreditCardType
    /// </summary>
    public string CardSecondAddress { get; private set; }

    /// <summary>
    /// CardSecondTelephone of the CreditCardType
    /// CardSecondTelephone الخاص بـ CreditCardType
    /// </summary>
    public string CardSecondTelephone { get; private set; }

    /// <summary>
    /// CardSecondEmail of the CreditCardType
    /// CardSecondEmail الخاص بـ CreditCardType
    /// </summary>
    public string CardSecondEmail { get; private set; }

    /// <summary>
    /// VatPercent of the CreditCardType
    /// VatPercent الخاص بـ CreditCardType
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// CreditCardTypeCode of the CreditCardType
    /// CreditCardTypeCode الخاص بـ CreditCardType
    /// </summary>
    public string CreditCardTypeCode { get; private set; }

    /// <summary>
    /// GroupNumber of the CreditCardType
    /// GroupNumber الخاص بـ CreditCardType
    /// </summary>
    public decimal? GroupNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: CreditCardType to CreditCardType
    /// </summary>
    public IReadOnlyCollection<CreditCardType> CreditCardTypes { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CreditCardGroup
    /// </summary>
    public CreditCardGroup CreditCardGroup { get; private set; }
    #endregion
}
}

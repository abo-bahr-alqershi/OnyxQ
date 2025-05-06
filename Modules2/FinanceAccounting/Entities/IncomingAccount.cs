using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// IncomingAccount Entity
/// </summary>
public class IncomingAccount : Entity<IncomingAccountId>
{

    private IncomingAccount() { }

    public IncomingAccount(IncomingAccountId id, decimal? incomeTypeAlt, string guarantorCode)
    {
        Id = id;
        IncomeTypeAlt = incomeTypeAlt;
        GuarantorCode = guarantorCode;
    }

    /// <summary>
    /// The unique identifier for the IncomingAccount
    /// المعرف الفريد لـ IncomingAccount
    /// </summary>
    public IncomingAccountId Id { get; private set; }

    /// <summary>
    /// IncomeTypeAlt of the IncomingAccount
    /// IncomeTypeAlt الخاص بـ IncomingAccount
    /// </summary>
    public decimal? IncomeTypeAlt { get; private set; }

    /// <summary>
    /// GuarantorCode of the IncomingAccount
    /// GuarantorCode الخاص بـ IncomingAccount
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// ManagerCode of the IncomingAccount
    /// ManagerCode الخاص بـ IncomingAccount
    /// </summary>
    public string ManagerCode { get; private set; }

    /// <summary>
    /// WarehouseGroupCode of the IncomingAccount
    /// WarehouseGroupCode الخاص بـ IncomingAccount
    /// </summary>
    public decimal? WarehouseGroupCode { get; private set; }

    /// <summary>
    /// AccountCode of the IncomingAccount
    /// AccountCode الخاص بـ IncomingAccount
    /// </summary>
    public string AccountCode { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}


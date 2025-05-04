using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// AccountProject Entity
/// </summary>
public class AccountProject : Entity<AccountProjectId>
{

    private AccountProject() { }

    public AccountProject(AccountProjectId id, string accountCode, string projectNumber)
    {
        Id = id;
        AccountCode = accountCode;
        ProjectNumber = projectNumber;
    }

    /// <summary>
    /// The unique identifier for the AccountProject
    /// المعرف الفريد لـ AccountProject
    /// </summary>
    public AccountProjectId Id { get; private set; }

    /// <summary>
    /// AccountCode of the AccountProject
    /// AccountCode الخاص بـ AccountProject
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the AccountProject
    /// ProjectNumber الخاص بـ AccountProject
    /// </summary>
    public string ProjectNumber { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

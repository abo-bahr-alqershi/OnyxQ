using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// DirectConnection Entity
/// </summary>
public class DirectConnection : Entity<DirectConnectionId>
{
    private DirectConnection() { }

    /// <summary>
    /// The unique identifier for the DirectConnection
    /// المعرف الفريد لـ DirectConnection
    /// </summary>
    public DirectConnectionId Id { get; private set; }

    /// <summary>
    /// SType of the DirectConnection
    /// SType الخاص بـ DirectConnection
    /// </summary>
    public decimal? SType { get; private set; }

    /// <summary>
    /// DirCode of the DirectConnection
    /// DirCode الخاص بـ DirectConnection
    /// </summary>
    public string DirCode { get; private set; }

    /// <summary>
    /// DirCodeExtrnl of the DirectConnection
    /// DirCodeExtrnl الخاص بـ DirectConnection
    /// </summary>
    public string DirCodeExtrnl { get; private set; }

    /// <summary>
    /// TDescription of the DirectConnection
    /// TDescription الخاص بـ DirectConnection
    /// </summary>
    public string TDescription { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the DirectConnection
    /// CompanyNumberShort الخاص بـ DirectConnection
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the DirectConnection
    /// BranchNumber الخاص بـ DirectConnection
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the DirectConnection
    /// BranchYear الخاص بـ DirectConnection
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the DirectConnection
    /// BranchUser الخاص بـ DirectConnection
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}

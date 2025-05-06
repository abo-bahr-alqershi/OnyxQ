using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

using ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects;
namespace ERP_Pro.Domain.ERP.MessagesNotifications.Entities
{
/// <summary>
/// NewsCss Entity
/// </summary>
public class NewsCss : Entity<NewsCssId>
{

    private NewsCss() { }

    public NewsCss(NewsCssId id, decimal? newsNumber)
    {
        Id = id;
        NewsNumber = newsNumber;
    }

    /// <summary>
    /// The unique identifier for the NewsCss
    /// المعرف الفريد لـ NewsCss
    /// </summary>
    public NewsCssId Id { get; private set; }

    /// <summary>
    /// NewsNumber of the NewsCss
    /// NewsNumber الخاص بـ NewsCss
    /// </summary>
    public decimal? NewsNumber { get; private set; }

    /// <summary>
    /// NewsLastDescription of the NewsCss
    /// NewsLastDescription الخاص بـ NewsCss
    /// </summary>
    public string NewsLastDescription { get; private set; }

    /// <summary>
    /// NewsFullDescription of the NewsCss
    /// NewsFullDescription الخاص بـ NewsCss
    /// </summary>
    public string NewsFullDescription { get; private set; }

    /// <summary>
    /// FDate of the NewsCss
    /// FDate الخاص بـ NewsCss
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the NewsCss
    /// TDate الخاص بـ NewsCss
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// InactiveFlag of the NewsCss
    /// InactiveFlag الخاص بـ NewsCss
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// ImagePath of the NewsCss
    /// ImagePath الخاص بـ NewsCss
    /// </summary>
    public string ImagePath { get; private set; }

    /// <summary>
    /// LinkYoutube of the NewsCss
    /// LinkYoutube الخاص بـ NewsCss
    /// </summary>
    public string LinkYoutube { get; private set; }

    /// <summary>
    /// NewsDescription of the NewsCss
    /// NewsDescription الخاص بـ NewsCss
    /// </summary>
    public string NewsDescription { get; private set; }

    /// <summary>
    /// LinkWebsite of the NewsCss
    /// LinkWebsite الخاص بـ NewsCss
    /// </summary>
    public string LinkWebsite { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Branch Branch { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}


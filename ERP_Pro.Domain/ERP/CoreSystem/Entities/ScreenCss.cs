using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    /// <summary>
    /// Represents a screen CSS styling in the ERP system
    /// يمثل تنسيق CSS للشاشة في نظام تخطيط موارد المؤسسات
    /// Table name: S_SCR_CSS
    /// </summary>
    public class ScreenCss : Entity
    {
        #region Properties

        /// <summary>
        /// Gets the unique identifier
        /// المعرف الفريد
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets the screen code
        /// كود الشاشة
        /// </summary>
        public string ScreenCode { get; private set; }

        /// <summary>
        /// Gets the CSS class name
        /// اسم فئة CSS
        /// </summary>
        public string CssClassName { get; private set; }

        /// <summary>
        /// Gets the CSS style
        /// نمط CSS
        /// </summary>
        public string CssStyle { get; private set; }

        /// <summary>
        /// Gets the CSS description
        /// وصف CSS
        /// </summary>
        public string? CssDescription { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the CSS is inactive
        /// هل CSS غير نشط
        /// </summary>
        public bool IsInactive { get; private set; }

        /// <summary>
        /// Gets the company information
        /// معلومات الشركة
        /// </summary>
        public CompanyInfo CompanyInfo { get; private set; }

        /// <summary>
        /// Gets the audit information
        /// معلومات التدقيق
        /// </summary>
        public AuditInfo AuditInfo { get; private set; }

        #endregion

        #region Constructors

        private ScreenCss() { } // For EF Core

        #endregion

        #region Factory Methods

        public static ScreenCss Create(
            string screenCode,
            string cssClassName,
            string cssStyle,
            string? cssDescription,
            CompanyInfo companyInfo,
            int userId,
            string terminal)
        {
            var screenCss = new ScreenCss
            {
                Id = Guid.NewGuid(),
                ScreenCode = screenCode,
                CssClassName = cssClassName,
                CssStyle = cssStyle,
                CssDescription = cssDescription,
                IsInactive = false,
                CompanyInfo = companyInfo,
                AuditInfo = AuditInfo.Create(userId, terminal)
            };

            screenCss.ValidateState();
            screenCss.AddDomainEvent(new ScreenCssCreatedEvent(screenCss));
            return screenCss;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Deactivates the screen CSS
        /// تعطيل CSS الشاشة
        /// </summary>
        public void Deactivate(int userId, string terminal)
        {
            if (IsInactive)
                throw new DomainException("Screen CSS is already inactive");

            var oldState = IsInactive;
            IsInactive = true;
            AuditInfo = AuditInfo.Update(AuditInfo, userId, terminal);

            AddDomainEvent(new ScreenCssDeactivatedEvent(this, oldState));
        }

        /// <summary>
        /// Activates the screen CSS
        /// تنشيط CSS الشاشة
        /// </summary>
        public void Activate(int userId, string terminal)
        {
            if (!IsInactive)
                throw new DomainException("Screen CSS is already active");

            var oldState = IsInactive;
            IsInactive = false;
            AuditInfo = AuditInfo.Update(AuditInfo, userId, terminal);

            AddDomainEvent(new ScreenCssActivatedEvent(this, oldState));
        }

        /// <summary>
        /// Updates the screen CSS information
        /// تحديث معلومات CSS الشاشة
        /// </summary>
        public void UpdateInformation(
            string cssClassName,
            string cssStyle,
            string? cssDescription,
            int userId,
            string terminal)
        {
            var oldState = (CssClassName, CssStyle, CssDescription);

            CssClassName = cssClassName;
            CssStyle = cssStyle;
            CssDescription = cssDescription;
            AuditInfo = AuditInfo.Update(AuditInfo, userId, terminal);

            ValidateState();
            AddDomainEvent(new ScreenCssInformationUpdatedEvent(
                this,
                oldState.CssClassName,
                oldState.CssStyle,
                oldState.CssDescription));
        }

        #endregion

        #region Private Methods

        private void ValidateState()
        {
            if (string.IsNullOrWhiteSpace(ScreenCode))
                throw new DomainException("Screen code is required");

            if (string.IsNullOrWhiteSpace(CssClassName))
                throw new DomainException("CSS class name is required");

            if (string.IsNullOrWhiteSpace(CssStyle))
                throw new DomainException("CSS style is required");

            if (CompanyInfo == null)
                throw new DomainException("Company information is required");
        }

        #endregion
    }
} 
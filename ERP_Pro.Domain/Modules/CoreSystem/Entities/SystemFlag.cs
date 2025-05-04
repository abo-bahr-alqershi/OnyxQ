using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل العلم في النظام ويحتوي على خصائص العلم وقيمه وتعريفاته.
    public class SystemFlag : Entity<SystemFlagId>
    {

        private SystemFlag() { }

        public SystemFlag(SystemFlagId id, decimal? languageNumber, decimal? flagValue, string flagCode)
        {
            Id = id;
            LanguageNumber = languageNumber;
            FlagValue = flagValue;
            FlagCode = flagCode;
        }

        // المعرف الفريد للعلم (مفتاح رئيسي).
        public SystemFlagId Id { get; private set; }

        // رقم اللغة المرتبط بالعلم.
        public decimal? LanguageNumber { get; private set; }

        // الرقم التسلسلي للعلم.
        public decimal? FlagSerial { get; private set; }

        // قيمة العلم.
        public decimal? FlagValue { get; private set; }

        // كود العلم.
        public string FlagCode { get; private set; }

        // وصف العلم.
        public string FlagDescription { get; private set; }

        // حالة العلم.
        public decimal? FlagStatus { get; private set; }

        // امتياز العلم.
        public decimal? FlagPrivilege { get; private set; }

        // رقم التسمية المختصر للعلم.
        public decimal? LabelNumberShort { get; private set; }

        #region Methods
        // Add domain logic methods here
        #endregion
    }
}

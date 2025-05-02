using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects
{
    public record ReportInfo
    {
        /// <summary> اسم التقرير </summary>
        public string Name { get; }
        /// <summary> اسم التقرير بالإنجليزي </summary>
        public string? NameEn { get; }
        /// <summary> أولوية الظهور في التقارير </summary>
        public int Priority { get; }
        /// <summary> يظهر في الميزانية </summary>
        public bool ShowInBalanceSheet { get; }

        private ReportInfo(string name, string? nameEn, int priority, bool showInBalanceSheet)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new DomainException("Report name is required");

            if (priority < 0)
                throw new DomainException("Report priority cannot be negative");

            Name = name;
            NameEn = nameEn;
            Priority = priority;
            ShowInBalanceSheet = showInBalanceSheet;
        }

        public static ReportInfo Create(
            string name,
            string? nameEn = null,
            int priority = 0,
            bool showInBalanceSheet = false) =>
            new(name, nameEn, priority, showInBalanceSheet);
    }
} 
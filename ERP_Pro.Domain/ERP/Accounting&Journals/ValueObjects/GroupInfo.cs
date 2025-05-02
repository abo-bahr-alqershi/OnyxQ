using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects
{
    public record GroupInfo
    {
        /// <summary> اسم المجموعة بالعربي </summary>
        public string NameAr { get; }
        /// <summary> اسم المجموعة بالإنجليزي </summary>
        public string? NameEn { get; }

        private GroupInfo(string nameAr, string? nameEn)
        {
            if (string.IsNullOrWhiteSpace(nameAr))
                throw new DomainException("Group Arabic name is required");

            NameAr = nameAr;
            NameEn = nameEn;
        }

        public static GroupInfo Create(string nameAr, string? nameEn = null) =>
            new(nameAr, nameEn);
    }
} 
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Cash&Banks&Safes.ValueObjects
{
    public class BankContactInfo : ValueObject
    {
        public string? Telephone { get; private set; }
        public string? Fax { get; private set; }
        public string? POBox { get; private set; }
        public string? Address { get; private set; }
        public string? Email { get; private set; }
        public string? Website { get; private set; }
        public int? CountryNo { get; private set; }
        public int? CityNo { get; private set; }
        public string? BankNetworkCode { get; private set; }

        private BankContactInfo() { }

        public static BankContactInfo Create(
            string? telephone = null,
            string? fax = null,
            string? poBox = null,
            string? address = null,
            string? email = null,
            string? website = null,
            int? countryNo = null,
            int? cityNo = null,
            string? bankNetworkCode = null)
        {
            return new BankContactInfo
            {
                Telephone = telephone,
                Fax = fax,
                POBox = poBox,
                Address = address,
                Email = email,
                Website = website,
                CountryNo = countryNo,
                CityNo = cityNo,
                BankNetworkCode = bankNetworkCode
            };
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Telephone ?? string.Empty;
            yield return Fax ?? string.Empty;
            yield return POBox ?? string.Empty;
            yield return Address ?? string.Empty;
            yield return Email ?? string.Empty;
            yield return Website ?? string.Empty;
            yield return CountryNo ?? 0;
            yield return CityNo ?? 0;
            yield return BankNetworkCode ?? string.Empty;
        }
    }
} 
 
namespace ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects
{
    public class ContractReference : ValueObject
    {
        public long? ContractNo { get; private set; }
        public int? ContractSerial { get; private set; }
        public int? ContractBatch { get; private set; }

        private ContractReference() { }

        public static ContractReference Create(
            long? contractNo = null,
            int? contractSerial = null,
            int? contractBatch = null)
        {
            return new ContractReference
            {
                ContractNo = contractNo,
                ContractSerial = contractSerial,
                ContractBatch = contractBatch
            };
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return ContractNo ?? 0;
            yield return ContractSerial ?? 0;
            yield return ContractBatch ?? 0;
        }
    }
}
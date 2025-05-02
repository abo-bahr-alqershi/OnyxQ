using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects
{
    public class ItemReference : ValueObject
    {
        public long? INo { get; private set; }
        public long? WONo { get; private set; }
        public long? WOSer { get; private set; }

        private ItemReference() { }

        public static ItemReference Create(
            long? iNo = null,
            long? woNo = null,
            long? woSer = null)
        {
            return new ItemReference
            {
                INo = iNo,
                WONo = woNo,
                WOSer = woSer
            };
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return INo ?? 0;
            yield return WONo ?? 0;
            yield return WOSer ?? 0;
        }
    }
} 
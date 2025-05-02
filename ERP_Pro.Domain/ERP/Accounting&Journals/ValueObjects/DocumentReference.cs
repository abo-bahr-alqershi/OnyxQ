using System;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects
{
    public class DocumentReference : ValueObject
    {
        public int? DocTypeRef { get; private set; }
        public int? DocJVTypeRef { get; private set; }
        public long? DocNoRef { get; private set; }
        public long? DocSerRef { get; private set; }
        public DateTime? DocDueDate { get; private set; }
        public long? DocSequenceRef { get; private set; }
        public int? DocBranchNo { get; private set; }
        public string? RefNo { get; private set; }

        private DocumentReference() { }

        public static DocumentReference Create(
            int? docTypeRef = null,
            int? docJVTypeRef = null,
            long? docNoRef = null,
            long? docSerRef = null,
            DateTime? docDueDate = null,
            long? docSequenceRef = null,
            int? docBranchNo = null,
            string? refNo = null)
        {
            return new DocumentReference
            {
                DocTypeRef = docTypeRef,
                DocJVTypeRef = docJVTypeRef,
                DocNoRef = docNoRef,
                DocSerRef = docSerRef,
                DocDueDate = docDueDate,
                DocSequenceRef = docSequenceRef,
                DocBranchNo = docBranchNo,
                RefNo = refNo
            };
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return DocTypeRef ?? 0;
            yield return DocJVTypeRef ?? 0;
            yield return DocNoRef ?? 0;
            yield return DocSerRef ?? 0;
            yield return DocDueDate ?? DateTime.MinValue;
            yield return DocSequenceRef ?? 0;
            yield return DocBranchNo ?? 0;
            yield return RefNo ?? string.Empty;
        }
    }
} 
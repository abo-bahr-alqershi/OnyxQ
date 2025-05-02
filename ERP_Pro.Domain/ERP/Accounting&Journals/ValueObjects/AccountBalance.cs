using System;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects
{
    public class AccountBalance : ValueObject
    {
        public decimal Debit { get; private set; }
        public decimal Credit { get; private set; }
        public decimal? TemporaryDebit { get; private set; }
        public decimal? TemporaryCredit { get; private set; }
        public decimal Balance => Debit - Credit;
        public decimal? TemporaryBalance => (TemporaryDebit ?? 0) - (TemporaryCredit ?? 0);

        private AccountBalance() { }

        public static AccountBalance Create(
            decimal debit = 0,
            decimal credit = 0,
            decimal? temporaryDebit = null,
            decimal? temporaryCredit = null)
        {
            var balance = new AccountBalance
            {
                Debit = debit,
                Credit = credit,
                TemporaryDebit = temporaryDebit,
                TemporaryCredit = temporaryCredit
            };

            balance.ValidateState();
            return balance;
        }

        public AccountBalance AddDebit(decimal amount)
        {
            if (amount < 0)
                throw new DomainException("Debit amount must be non-negative");

            return Create(
                Debit + amount,
                Credit,
                TemporaryDebit,
                TemporaryCredit);
        }

        public AccountBalance AddCredit(decimal amount)
        {
            if (amount < 0)
                throw new DomainException("Credit amount must be non-negative");

            return Create(
                Debit,
                Credit + amount,
                TemporaryDebit,
                TemporaryCredit);
        }

        public AccountBalance AddTemporaryDebit(decimal amount)
        {
            if (amount < 0)
                throw new DomainException("Temporary debit amount must be non-negative");

            return Create(
                Debit,
                Credit,
                (TemporaryDebit ?? 0) + amount,
                TemporaryCredit);
        }

        public AccountBalance AddTemporaryCredit(decimal amount)
        {
            if (amount < 0)
                throw new DomainException("Temporary credit amount must be non-negative");

            return Create(
                Debit,
                Credit,
                TemporaryDebit,
                (TemporaryCredit ?? 0) + amount);
        }

        public AccountBalance ClearTemporaryBalances()
        {
            return Create(Debit, Credit);
        }

        private void ValidateState()
        {
            if (Debit < 0)
                throw new DomainException("Debit balance cannot be negative");

            if (Credit < 0)
                throw new DomainException("Credit balance cannot be negative");

            if (TemporaryDebit.HasValue && TemporaryDebit.Value < 0)
                throw new DomainException("Temporary debit balance cannot be negative");

            if (TemporaryCredit.HasValue && TemporaryCredit.Value < 0)
                throw new DomainException("Temporary credit balance cannot be negative");
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Debit;
            yield return Credit;
            yield return TemporaryDebit ?? 0;
            yield return TemporaryCredit ?? 0;
        }
    }
} 
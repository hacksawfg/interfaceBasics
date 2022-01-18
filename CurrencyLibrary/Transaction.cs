using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyLibrary
{
    public class Transaction
    {
        private readonly List<ICurrency> _currencies = new List<ICurrency>();

        public Transaction(decimal totalAmountOwed)
        {
            TotalAmountOwed = totalAmountOwed;
        }

        public decimal TotalAmountOwed { get; }

        public decimal TotalAmountPaid
        {
            get
            {
                decimal totalPaid = 0;
                foreach (ICurrency currency in _currencies)
                {
                    totalPaid += currency.Value;
                }
                return totalPaid;
            }
        }

        public decimal AmountOwed
        {
            get
            {
                return TotalAmountOwed - TotalAmountPaid;
            }
        }

        public DateTime TransactionDate { get; set; }

        // Make payment method
        public void MakePayment(ICurrency payment)
        {
            _currencies.Add(payment);
        }

        public void MakePayment(params ICurrency[] payments)
        {
            foreach (ICurrency currency in payments)
            {
                _currencies.Add(currency);
            }
        }

        
        // Get payments used


    }
}
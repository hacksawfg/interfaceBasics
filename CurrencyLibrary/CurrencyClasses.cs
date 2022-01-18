using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyLibrary
{
    public class Penny : ICurrency
    {
        public string Name => "Penny";

        public decimal Value => .01m;
    }

    public class Nickel : ICurrency
    {
        public string Name => "Nickel";

        public decimal Value => .05m;
    }

    public class Dime : ICurrency
    {
        public string Name => "Dime";

        public decimal Value => .10m;
    }

    public class Quarter : ICurrency
    {
        public string Name => "Quarter";

        public decimal Value => 0.25m;
    }

    public class Dollar : ICurrency
    {
        public string Name => "Dollar";

        public decimal Value => 1m;
    }

    public class ElectronicPayment : ICurrency
    {
        // Asking for value of electronic payment
        public ElectronicPayment(decimal value)
        {
            Value = value;
        }
        public string Name => "Electronic Payment";

        // No setter so value cannot be changed
        public decimal Value { get; }
    }

    public class CanadianDollar : ICurrency
    {
        public string Name => "Canadian Dollar";

        public decimal Value => 0.8m;

    }

    public class Euro : ICurrency
    {
        public string Name => "Euro";
        public decimal Value => 1.13m;
    }
}
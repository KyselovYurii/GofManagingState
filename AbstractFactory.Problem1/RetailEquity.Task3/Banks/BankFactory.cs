using System;
using RetailEquity.Filters;
using RetailEquity.Task3;

namespace RetailEquity.Banks
{
    class BankFactory
    {
        public IFilter CreateBank(Bank bank, Country country)
        {
            return bank switch
            {
                Bank.Bofa => new BofaBank(),
                Bank.Connacord => new ConnacordBank(),
                Bank.Barclays => new Barclays(country),
                Bank.DeutscheBank => new DeutscheBank(),
                _ => throw new ArgumentException($"Bank '{bank}' is not supported"),
            };
        }
    }
}


using System;
using RetailEquity.Filters;

namespace RetailEquity.Task1.Banks
{
    class BankFactory
    {
        public IFilter CreateBank(Bank bank)
        {
            return bank switch
            {
                Bank.Bofa => new BofaBank(),
                Bank.Connacord => new ConnacordBank(),
                Bank.Barclays => new Barclays(),
                _ => throw new ArgumentException($"Bank '{bank}' is not supported"),
            };
        }
    }
}


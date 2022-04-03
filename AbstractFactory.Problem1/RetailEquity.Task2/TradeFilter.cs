using RetailEquity.Model;
using RetailEquity.Banks;
using System.Collections.Generic;

namespace RetailEquity
{
    public class TradeFilter
    {
        private readonly BankFactory _factory = new BankFactory();

        public IEnumerable<Trade> FilterForBank(IEnumerable<Trade> trades, Bank bank)
        {
            var filter = _factory.CreateBank(bank);
            return filter.Match(trades);
        }
    }
}
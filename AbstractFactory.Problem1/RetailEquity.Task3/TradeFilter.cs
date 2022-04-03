using RetailEquity.Model;
using RetailEquity.Banks;
using System.Collections.Generic;
using RetailEquity.Task3;

namespace RetailEquity
{
    public class TradeFilter
    {
        private readonly BankFactory _factory = new BankFactory();

        public IEnumerable<Trade> FilterForBank(IEnumerable<Trade> trades, Bank bank, Country country)
        {
            var filter = _factory.CreateBank(bank, country);
            return filter.Match(trades);
        }
    }
}
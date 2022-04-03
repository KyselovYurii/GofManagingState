using RetailEquity.Model;
using RetailEquity.Task1.Banks;
using System.Collections.Generic;

namespace RetailEquity
{
    public class TradeFilter
    {
        private BankFactory _factory = new BankFactory();

        public IEnumerable<Trade> FilterForBank(IEnumerable<Trade> trades, Bank bank)
        {
            var filter = _factory.CreateBank(bank);
            return filter.Match(trades);
        }
    }
}
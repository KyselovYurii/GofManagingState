using System;
using AbstartFactory.Cookers;

namespace AbstartFactory
{
    class CookerFactory
    {
        readonly ICooker _cooker;

        public CookerFactory(ICooker cooker)
        {
            _cooker = cooker ?? throw new ArgumentNullException(nameof(cooker));
        }

        public BaseCooker CreateCooker(Country country)
        {
            return country switch
            {
                Country.India => new IndianCooker(_cooker),
                Country.Ukraine => new UkranianCooker(_cooker),
                Country.England => new EnglandCooker(_cooker),
                _ => throw new ArgumentException("There is no suck cooker."),
            };
        }
    }
}

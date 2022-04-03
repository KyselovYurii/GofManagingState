using System;

namespace AbstartFactory
{
    public class MasalaCooker
    {
        private readonly ICooker _cooker;

        public MasalaCooker(ICooker cooker)
        {
            _cooker = cooker;
        }

        public void CookMasala(DateTime currentDate, Country country)
        {
            ICookerFactory factory;
            if (IsSummerDate(currentDate))
            {
                factory = new CookerSummerFactory(_cooker);
            }
            else
            {
                factory = new CookerFactory(_cooker);
            }

            var countryCooker = factory.CreateCooker(country);
            countryCooker.CookMasala();
        }

        private bool IsSummerDate(DateTime currentDate)
        {
            return currentDate.Month >= 6 && currentDate.Month <= 8;
        }
    }
}

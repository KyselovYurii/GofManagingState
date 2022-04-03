namespace AbstartFactory
{
    public class MasalaCooker
    {
        private readonly ICooker _cooker;
        private readonly CookerFactory _cookerFactory;

        public MasalaCooker(ICooker cooker)
        {
            _cooker = cooker;
            _cookerFactory = new CookerFactory(_cooker);
        }

        public void CookMasala(Country country)
        {
            var usedCooler = _cookerFactory.CreateCooker(country);
            usedCooler.CookMasala();
        }
    }
}

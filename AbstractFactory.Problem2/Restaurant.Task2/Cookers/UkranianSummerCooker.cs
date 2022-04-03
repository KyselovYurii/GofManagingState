namespace AbstartFactory.Cookers
{
    class UkranianSummerCooker : BaseCooker
    {
        public UkranianSummerCooker(ICooker cooker) 
            : base(cooker)
        { 
        }

        protected override void FryChicken()
        {
            _cooker.FryChicken(200, Level.Medium);
        }

        protected override void FryRice()
        {
            _cooker.FryRice(150, Level.Medium);
        }

        protected override void PepperChicken()
        {
        }

        protected override void PepperRice()
        {
        }

        protected override void SaltChicken()
        {
            _cooker.SaltChicken(Level.Low);
        }

        protected override void SaltRice()
        {
            _cooker.SaltRice(Level.Low);
        }
    }
}
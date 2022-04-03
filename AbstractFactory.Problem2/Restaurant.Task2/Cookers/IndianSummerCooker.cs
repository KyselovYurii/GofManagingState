namespace AbstartFactory.Cookers
{
    class IndianSummerCooker : BaseCooker
    {
        public IndianSummerCooker(ICooker cooker) 
            : base(cooker)
        { 
        }

        protected override void FryChicken()
        {
            _cooker.FryChicken(100, Level.Low);
        }

        protected override void FryRice()
        {
            _cooker.FryRice(100, Level.Low);
        }

        protected override void PepperChicken()
        {
            _cooker.PepperChicken(Level.Medium);
        }

        protected override void PepperRice()
        {
            _cooker.PepperRice(Level.Medium);
        }

        protected override void SaltChicken()
        {
        }

        protected override void SaltRice()
        {
        }
    }
}
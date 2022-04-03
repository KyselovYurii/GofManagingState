namespace AbstartFactory.Cookers
{
    class EnglandSummerCooker : BaseCooker
    {
        public EnglandSummerCooker(ICooker cooker) 
            : base(cooker)
        { 
        }

        protected override void FryChicken()
        {
            _cooker.FryChicken(50, Level.Low);
        }

        protected override void FryRice()
        {
            _cooker.FryRice(50, Level.Low);
        }

        protected override void PepperChicken()
        {
        }

        protected override void PepperRice()
        {
        }

        protected override void SaltChicken()
        {
        }

        protected override void SaltRice()
        {
        }
    }
}
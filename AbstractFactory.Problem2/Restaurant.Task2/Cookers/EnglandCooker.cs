namespace AbstartFactory.Cookers
{
    class EnglandCooker : BaseCooker
    {
        public EnglandCooker(ICooker cooker) 
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
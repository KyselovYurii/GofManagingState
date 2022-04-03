namespace AbstartFactory.Cookers
{
    class UkranianCooker : BaseCooker
    {
        public UkranianCooker(ICooker cooker) 
            : base(cooker)
        { 
        }

        protected override void FryChicken()
        {
            _cooker.FryChicken(300, Level.Medium);
        }

        protected override void FryRice()
        {
            _cooker.FryRice(500, Level.Strong);
        }

        protected override void PepperChicken()
        {
            _cooker.PepperChicken(Level.Low);
        }

        protected override void PepperRice()
        {
            _cooker.PepperRice(Level.Low);
        }

        protected override void SaltChicken()
        {
            _cooker.SaltChicken(Level.Medium);
        }

        protected override void SaltRice()
        {
            _cooker.SaltRice(Level.Strong);
        }
    }
}
namespace AbstartFactory.Cookers
{
    class IndianCooker : BaseCooker
    {
        public IndianCooker(ICooker cooker) 
            : base(cooker)
        { 
        }

        protected override void FryChicken()
        {
            _cooker.FryChicken(100, Level.Strong);
        }

        protected override void FryRice()
        {
            _cooker.FryRice(200, Level.Strong);
        }

        protected override void PepperChicken()
        {
            _cooker.PepperChicken(Level.Strong);
        }

        protected override void PepperRice()
        {
            _cooker.PepperRice(Level.Strong);
        }

        protected override void SaltChicken()
        {
            _cooker.SaltChicken(Level.Strong);
        }

        protected override void SaltRice()
        {
            _cooker.SaltRice(Level.Strong);
        }
    }
}
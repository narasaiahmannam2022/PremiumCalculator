namespace Premium.Web.Services
{
    public class PremiumCalculatorService : IPremiumCalculatorService
    {
        private readonly IOccupationFactorProvider _factorProvider;

        public PremiumCalculatorService(IOccupationFactorProvider factorProvider)
        {
            _factorProvider = factorProvider;
        }

        // Premium = (DeathSumInsured * RatingFactor * Age) / 1000 * 12
        public decimal CalculatePremium(int ageNextBirthday, decimal deathSumInsured, string occupation)
        {
            if (ageNextBirthday <= 0 || deathSumInsured <= 0 || string.IsNullOrWhiteSpace(occupation))
                return 0M;

            var factor = _factorProvider.GetFactorForOccupation(occupation);
            if (factor <= 0) return 0M;

            var premium = (deathSumInsured * factor * ageNextBirthday) / 1000M * 12M;
            return decimal.Round(premium, 2, System.MidpointRounding.AwayFromZero);
        }
    }
}

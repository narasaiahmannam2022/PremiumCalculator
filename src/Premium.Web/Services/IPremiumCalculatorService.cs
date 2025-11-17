namespace Premium.Web.Services
{
    public interface IPremiumCalculatorService
    {
        decimal CalculatePremium(int ageNextBirthday, decimal deathSumInsured, string occupation);
    }
}

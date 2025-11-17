namespace Premium.Web.Models
{
    public class PremiumRequest
    {
        public int AgeNextBirthday { get; set; }
        public decimal DeathSumInsured { get; set; }
        public string Occupation { get; set; } = string.Empty;
    }
}

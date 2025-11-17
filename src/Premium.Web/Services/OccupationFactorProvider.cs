using System.Collections.Generic;

namespace Premium.Web.Services
{
    public interface IOccupationFactorProvider
    {
        decimal GetFactorForOccupation(string occupation);
        IDictionary<string, string> GetOccupationsWithRatings();
    }

    public class OccupationFactorProvider : IOccupationFactorProvider
    {
        // occupation -> rating
        private static readonly Dictionary<string, string> _occupationRatings = new()
        {
            { "Cleaner", "Light Manual" },
            { "Doctor", "Professional" },
            { "Author", "White Collar" },
            { "Farmer", "Heavy Manual" },
            { "Mechanic", "Heavy Manual" },
            { "Florist", "Light Manual" },
            { "Other", "Heavy Manual" }
        };

        // rating -> factor
        private static readonly Dictionary<string, decimal> _ratingFactors = new()
        {
            { "Professional", 1.5M },
            { "White Collar", 2.25M },
            { "Light Manual", 11.50M },
            { "Heavy Manual", 31.75M }
        };

        public decimal GetFactorForOccupation(string occupation)
        {
            if (string.IsNullOrWhiteSpace(occupation)) return 0M;
            if (!_occupationRatings.TryGetValue(occupation, out var rating)) return 0M;
            if (!_ratingFactors.TryGetValue(rating, out var factor)) return 0M;
            return factor;
        }

        public IDictionary<string, string> GetOccupationsWithRatings()
        {
            return _occupationRatings;
        }
    }
}

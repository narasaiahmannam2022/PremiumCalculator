using System.ComponentModel.DataAnnotations;

namespace Premium.Web.Models
{
    public class MemberViewModel
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(0, 130)]
        public int AgeNextBirthday { get; set; }

        [Required]
        [Display(Name = "Date of Birth (MM/YYYY)")]
        public string DateOfBirthMonthYear { get; set; } = string.Empty;

        [Required]
        public string Occupation { get; set; } = string.Empty;

        [Required]
        [Range(0, double.MaxValue)]
        [Display(Name = "Death Sum Insured")]
        public decimal DeathSumInsured { get; set; }
    }
}

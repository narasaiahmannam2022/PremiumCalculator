using Microsoft.AspNetCore.Mvc;
using Premium.Web.Models;
using Premium.Web.Services;

namespace Premium.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOccupationFactorProvider _occupationProvider;
        private readonly IPremiumCalculatorService _premiumService;

        public HomeController(IOccupationFactorProvider occupationProvider, IPremiumCalculatorService premiumService)
        {
            _occupationProvider = occupationProvider;
            _premiumService = premiumService;
        }

        public IActionResult Index()
        {
            var model = new MemberViewModel();
            ViewBag.Occupations = _occupationProvider.GetOccupationsWithRatings().Keys;
            return View(model);
        }

        [HttpPost]
        public IActionResult Calculate([FromBody] PremiumRequest request)
        {
            if (request == null)
                return BadRequest();

            if (request.AgeNextBirthday <= 0 || request.DeathSumInsured <= 0 || string.IsNullOrWhiteSpace(request.Occupation))
                return BadRequest("All input fields are mandatory and must be valid.");

            var premium = _premiumService.CalculatePremium(request.AgeNextBirthday, request.DeathSumInsured, request.Occupation);
            return Ok(new { premium });
        }
    }
}

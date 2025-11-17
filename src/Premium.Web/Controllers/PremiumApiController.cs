using Microsoft.AspNetCore.Mvc;
using Premium.Web.Models;
using Premium.Web.Services;

namespace Premium.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PremiumController : ControllerBase
    {
        private readonly IPremiumCalculatorService _premiumService;

        public PremiumController(IPremiumCalculatorService premiumService)
        {
            _premiumService = premiumService;
        }

        [HttpPost("calculate")]
        public IActionResult Calculate([FromBody] PremiumRequest request)
        {
            if (request == null) return BadRequest();
            if (request.AgeNextBirthday <= 0 || request.DeathSumInsured <= 0 || string.IsNullOrWhiteSpace(request.Occupation))
                return BadRequest("All input fields are mandatory and must be valid.");

            var premium = _premiumService.CalculatePremium(request.AgeNextBirthday, request.DeathSumInsured, request.Occupation);
            return Ok(new { premium });
        }
    }
}

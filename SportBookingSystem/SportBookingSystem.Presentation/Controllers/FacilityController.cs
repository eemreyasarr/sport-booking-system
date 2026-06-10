using Microsoft.AspNetCore.Mvc;
using SportBookingSystem.Application.DTOs;
using SportBookingSystem.Application.Interfaces;
using SportBookingSystem.Application.Services;

namespace SportBookingSystem.Presentation.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class FacilityController : Controller
    {
        private readonly IFacilityService _facilityService;

        public FacilityController(IFacilityService facilityService)
        {
            _facilityService = facilityService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateFacilityRequest request)
        {
            var facilityResponse = await _facilityService.CreateFacilityAsync(request);

            if (!facilityResponse.Success)
            {
                return BadRequest(facilityResponse);
            }

            return Ok(facilityResponse);
        }
    }
}

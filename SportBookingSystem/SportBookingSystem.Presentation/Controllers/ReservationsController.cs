using Microsoft.AspNetCore.Mvc;
using SportBookingSystem.Application.DTOs;
using SportBookingSystem.Application.Interfaces;

namespace SportBookingSystem.Presentation.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationsController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateReservationRequest request)
        {
            var reservationId = await _reservationService.CreateReservationAsync(request);

            return Ok(new { ReservationId = reservationId });
        }
    }
}

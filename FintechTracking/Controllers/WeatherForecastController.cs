using Microsoft.AspNetCore.Mvc;
using FintechTracking.Services;
using FintechTracking.DTO;


namespace FintechTracking.Controllers
{
    [ApiController]
    [Route("api/tracking")]

    public class TrackingController : ControllerBase
    {
        private readonly FintechTrackingService _trackingService;

        public TrackingController(FintechTrackingService trackingService)
        {
            _trackingService = trackingService;
        }

        [HttpPost("start")]
        public ActionResult StartTracking([FromBody] TrackingDTO trackingDto)
        {
            _trackingService.StartOnboardingTracking(trackingDto);
            return Ok("Tracking started successfully.");
        }

        [HttpPost("update")]
        public ActionResult UpdateTracking([FromBody] TrackingDTO trackingDto)
        {
            _trackingService.UpdateOnboardingTracking(trackingDto);
            return Ok("Tracking updated successfully.");
        }
    }
}

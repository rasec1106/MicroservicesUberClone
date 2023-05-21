using ApiTrip.Models;
using ApiTrip.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiTrip.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TripController : ControllerBase
    {
        private ITripRepository tripRepository;

        public TripController(ITripRepository tripRepository)
        {
            this.tripRepository = tripRepository;
        }
        [Route("/test")]
        [HttpGet]
        public async Task<Trip> testFunction(int id)
        {
            return await tripRepository.testFunction(id);
        }
    }
}

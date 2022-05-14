using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlightController : ControllerBase
    {
        private readonly DataContext _context;
        public FlightController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public ActionResult<IEnumerable<AppFlights>> GetFlight()
        {
            return _context.Vuelos.ToList();
        }
    }
}
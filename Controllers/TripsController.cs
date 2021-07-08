using building_react_and_asp_dot_net_core_applications.Data.Models;
using building_react_and_asp_dot_net_core_applications.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace building_react_and_asp_dot_net_core_applications.Controllers
{
    [Route("api/[controller]")]
    public class TripsController : Controller
    {
        private ITripService _service;
        public TripsController(ITripService service)
        {
            _service = service;
        }

        [HttpPost("AddTrip")]
        public IActionResult AddTrip([FromBody]Trip trip) {
            if (trip != null) {
                _service.AddTrip(trip);
            }
            return Ok();
        }

        [HttpGet("[action]")]
        public IActionResult GetTrips()
        {
            var allTrips = _service.GetAllTrips();
            return Ok(allTrips);
        }

        [HttpPut("UpdateTrip/{id}")]
        public IActionResult UpdateTrip(int id, [FromBody] Trip trip)
        {
            _service.UpdateTrip(id, trip);
            return Ok(trip);
        }

        [HttpDelete("DeleteTrip/{id}")]
        public IActionResult DeleteTrip(int id)
        {
            _service.DeleteTrip(id);
            return Ok();
        }

        [HttpGet("SingleTrip/{id}")]
        public IActionResult GetTripById(int id)
        {
            var trip = _service.GetTripById(id);
            return Ok(trip);
        }
    }
}

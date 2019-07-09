using Hotel.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicHotelApi.Controllers
{
    [Route("hotel")]
    public class HotelSearchController : ControllerBase
    {
        private HotelEngine _engine = new HotelEngine();
        [HttpGet("health")]
        public ActionResult<string> HealthCheck()
        {
            return Ok("Hotel search is up and running");
        }

        [HttpGet("search")]
        public async Task<ActionResult<string>> Search(SearchRequest searchRequest)
        {
            var hotels = await _engine.SearchHotelsAsync(searchRequest);
            return Ok(hotels);
        }
    }
}

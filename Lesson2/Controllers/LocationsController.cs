using EpidemiologyReport.Services;
using EpidemiologyReport.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System.Net;

namespace Lesson2
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        //ILogger<LocationsController> _logger;
        private readonly ILocationBusinesssLogic _locationBusinesssLogic;
        public LocationsController(ILocationBusinesssLogic locationBusinesssLogic)
        {
            _locationBusinesssLogic = locationBusinesssLogic;

        }

        [HttpGet]
        public async Task<List<Location>> GetLocations()
        {
            return await _locationBusinesssLogic.GetAll();
        }

        [HttpGet("{city}")]
        public async Task<List<Location>> GetLocationByCity(string city)
        {
            return await _locationBusinesssLogic.GetByCity(city);
        }

        //[HttpGet("{id}")]
        //public List<Location> GetLocationByPatientId(string id)
        //{
        //    return  _locationBusinesssLogic.GetByPatientId(id);

        //}


        [HttpPost("{id}")]
        public async Task<Location> AddLocation([FromBody] Location newLocation, string id)
        {
            return await _locationBusinesssLogic.AddLocation(newLocation, id);
        }
    }
}

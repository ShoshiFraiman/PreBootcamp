using EpidemiologyReport.Services;
using EpidemiologyReport.Services.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lesson2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        IPatientBusinessLogic _PatientBusinessLogic;
        public PatientsController(IPatientBusinessLogic PatientBusinessLogic)
        {
            _PatientBusinessLogic=PatientBusinessLogic;
        }
        // GET: api/<PatientsLocation>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<PatientsLocation>/5

        [HttpGet("{id}")]
        public async Task<List<Location>> GetLocationByPatientId(string id)
        {
            return await _PatientBusinessLogic.GetByLocationPatientId(id);

        }

        // POST api/<PatientsLocation>
        [HttpPost]
        public async Task Post([FromBody] Patient patient )
        {
             await _PatientBusinessLogic.AddPatient(patient);

        }

        // PUT api/<PatientsLocation>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<PatientsLocation>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}

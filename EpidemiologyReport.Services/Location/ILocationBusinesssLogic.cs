using EpidemiologyReport.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpidemiologyReport.Services
{
    public interface ILocationBusinesssLogic
    {
        public Task<List<Location>> GetAll();
        public Task<List<Location>> GetByCity(string city);
        public  Task<List<Location>> GetByPatientId(string PatientId);
        public Task<Location> AddLocation(Location location, string id);
    }
}

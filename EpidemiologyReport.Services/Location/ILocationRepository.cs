using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EpidemiologyReport.Services.Models;

namespace EpidemiologyReport.Services
{
    public interface ILocationRepository
    {
                public  Task<List<Location>> GetAll();
                public  Task<List<Location>> GetByCity(string city);
                public  Task<List<Location>> GetByPatientId(string PatientId);
        public Task<Location> AddLocation(Location location, string id);
        
    }
}

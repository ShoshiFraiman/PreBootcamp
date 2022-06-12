using EpidemiologyReport.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpidemiologyReport.Services
{
    public interface IPatientRepository
    {
        public Task<List<Location>> GetLocationByPatientId(string PatientId);
        public Task AddPatient(Patient patient);

    }
}

using EpidemiologyReport.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpidemiologyReport.Services
{
    public class PatientBusinessLogic: IPatientBusinessLogic
    {
        IPatientRepository _patientRepository;
        public PatientBusinessLogic(IPatientRepository patientRepository)
        {
            _patientRepository=patientRepository;
        }
        public async Task<List<Location>> GetByLocationPatientId(string PatientId)
        {
          return await _patientRepository.GetLocationByPatientId(PatientId);
        }
        public async Task AddPatient(Patient patient)
        {
             await _patientRepository.AddPatient(patient);
        }
    }
}

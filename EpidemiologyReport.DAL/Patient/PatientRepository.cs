using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EpidemiologyReport.Services;
using EpidemiologyReport.Services.Models;

namespace EpidemiologyReport.DAL
{
    public class PatientRepository: IPatientRepository
    {
        IEpidemiologyReportDB _EpidemiologyReportDB;

        //EpidemiologyReportDB DB =new EpidemiologyReportDB();
        public List<Patient> patients;

        public PatientRepository(IEpidemiologyReportDB EpidemiologyReportDB)
        {
            _EpidemiologyReportDB = EpidemiologyReportDB;
            patients = _EpidemiologyReportDB.patients;
        }
        public async Task<List<Location>> GetLocationByPatientId(string PatientId)
        {
            List<Location> AllLocations = new List<Location>();
            patients.ForEach(patient =>
            {
                if (patient.PatientId.Equals(PatientId))
                {
                    patient.LocationList.ForEach(location => AllLocations.Add(location));

                }

            });
            return await Task.FromResult(AllLocations);
        }
        public  async Task AddPatient(Patient patient)
        {
            patients.Add(patient);
         
        }
    }
}


using EpidemiologyReport.Services;
using EpidemiologyReport.Services.Models;

namespace EpidemiologyReport.DAL
{
    public class LocationRepository:ILocationRepository
    {
        IEpidemiologyReportDB _EpidemiologyReportDB;
        //EpidemiologyReportDB DB=new EpidemiologyReportDB();

        public List<Patient> patients;

        public LocationRepository(IEpidemiologyReportDB EpidemiologyReportDB)
        {
            _EpidemiologyReportDB = EpidemiologyReportDB;

            patients = _EpidemiologyReportDB.patients;
            //patients = DB.patients;
        }
        public async Task<List<Location>> GetAll()
        {
            List<Location> AllLocations = new List<Location>();
            patients.ForEach(patient =>
            {
                patient.LocationList.ForEach(location => AllLocations.Add(location));
            });
            return await Task.FromResult(AllLocations);
        }
        public async Task<List<Location>> GetByCity(string city)
        {

            List<Location> AllLocations = new List<Location>();
            patients.ForEach(patient =>
            {
                patient.LocationList.ForEach(location =>
                {
                    if (location.City.Equals(city))
                        AllLocations.Add(location);
                }
                );
            });
            return await Task.FromResult(AllLocations);
        }

        public async Task<List<Location>> GetByPatientId(string PatientId)
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
          public async Task<Location> AddLocation(Location location, string id)
        {
            patients.ForEach(patient =>
            {

                if (patient.PatientId.Equals(id))
                {
                patient.LocationList.Add(location);

                }

            });
            return await Task.FromResult(location);

        }
    }
}
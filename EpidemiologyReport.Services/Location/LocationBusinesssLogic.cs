using EpidemiologyReport.Services.Models;
namespace EpidemiologyReport.Services
{
    public class LocationBusinesssLogic : ILocationBusinesssLogic
    {
        ILocationRepository _locationRepository;
        public LocationBusinesssLogic(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public async Task<List<Location>> GetAll()
        {
            return await _locationRepository.GetAll();
        }
        public async Task<List<Location>> GetByCity(string city)
        {
            return await _locationRepository.GetByCity(city);
        }
        public async Task<List<Location>> GetByPatientId(string PatientId)
        {
            return await _locationRepository.GetByPatientId(PatientId);
        }
        public async Task<Location> AddLocation(Location location, string id)
        {
            return await _locationRepository.AddLocation(location, id);

        }
    }
}

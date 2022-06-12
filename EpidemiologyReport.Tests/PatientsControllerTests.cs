using EpidemiologyReport.Services.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EpidemiologyReport.Tests
{
    public class PatientsControllerTests
    {
        private readonly WebApplicationFactory<Program> _factory = new WebApplicationFactory<Program>();
        [Fact]
        public async void GetLocationsById_ReturnLocations()
        {
            //// Arrange
            var client = _factory.CreateClient();

            //// Act
            var response = await client.GetAsync("/api/Patients/1");

            ////// Assert
            response.EnsureSuccessStatusCode();
        }
        [Fact]
        public async void AddPatient()
        {
            //// Arrange
            var client = _factory.CreateClient();
            //// Act
             Location l1 = new Location
            {
                City = "bnei brack",
                StartDate = new DateTime(),
                EndDate = new DateTime(),
                SpesipicLocation = "Restaurant"
            };
      
             List<Location> location1 = new List<Location>
        {
            l1
        };
             Patient p1 = new Patient
            {
                PatientId = "1",
                Name = "Yosef",
                LocationList = location1
            };
            JsonContent jsonContent = JsonContent.Create(p1);
            var response = await client.PostAsync("/api/Patients", jsonContent);

            ////// Assert
            response.EnsureSuccessStatusCode();
        }
    }
}

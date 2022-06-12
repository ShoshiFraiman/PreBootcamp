using EpidemiologyReport.Services;
using EpidemiologyReport.Services.Models;
using Lesson2;
using Microsoft.AspNetCore.Mvc.Testing;
using Moq;
using Newtonsoft.Json.Linq;
//using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EpidemiologyReport.Tests
{
    public class LocationsControllerTests
        
    {
        private readonly WebApplicationFactory<Program> _factory= new WebApplicationFactory<Program>();


        public LocationsControllerTests()
        {
        }

        [Fact]
        public async void GetAllLocation_ReturnLocations()
        {  
            //// Arrange
            var client = _factory.CreateClient();

            //// Act
            var response = await client.GetAsync("/api/Locations/GetLocations");

            ////// Assert
            response.EnsureSuccessStatusCode();
        }
        [Fact]

        public async void MockGetLocationByCity_ReturnLocations()
        {
            var mock = new Mock<ILocationBusinesssLogic>();
            List<Location> location1 = new List<Location>
        {
            new Location
            {
                City = "bnei brack",
                StartDate = new DateTime(),
                EndDate = new DateTime(),
                SpesipicLocation = "Restaurant"
            },
        };
            mock.Setup(x=>x.GetByCity("bnei brack")).Returns(Task.FromResult(location1));
            var controller = new LocationsController(mock.Object);
            var actual = controller.GetLocationByCity("bnei brack").Result;
            Assert.Same(actual,location1);
        }
        [Fact]
        public async void GetLocationByCity_ReturnLocations()
        {
          
            //// Arrange
            var client = _factory.CreateClient();

            ////// Act
            var response = await client.GetAsync("/api/Locations/GetLocationByCity/bnei brack");

        response.EnsureSuccessStatusCode();
        }
        [Fact]

        public async void AddLocation_ReturnSuccessCode()
        {
            //// Arrange
            var client = _factory.CreateClient();

            //// Act
            ///
            Location location = new Location
            {
                City = "Ramat Gan",
                StartDate = new DateTime(),
                EndDate = new DateTime(),
                SpesipicLocation = "Hotel"
            };
            JsonContent jsonContent = JsonContent.Create(location);
            var response = await client.PostAsync("/api/Locations/AddLocation/1", jsonContent);

            ////// Assert
            response.EnsureSuccessStatusCode();
        }
    }
}

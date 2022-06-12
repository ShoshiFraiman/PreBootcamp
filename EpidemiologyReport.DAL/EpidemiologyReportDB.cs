using EpidemiologyReport.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpidemiologyReport.DAL
{
    public class EpidemiologyReportDB : IEpidemiologyReportDB
    {
       static Location l1 = new Location 
        {
            City = "bnei brack" ,
            StartDate = new DateTime(),
            EndDate = new DateTime(),
            SpesipicLocation = "Restaurant"
        };
        static Location l2 = new Location
        {
            City = "Jerusalem",
            StartDate = new DateTime(),
            EndDate = new DateTime(),
            SpesipicLocation = "Hotel"
        };
        static Location l3 = new Location
        {
            City = "Tel Aviv",
            StartDate = new DateTime(),
            EndDate = new DateTime(),
            SpesipicLocation = "Restaurant"
        };
        static Location l4 = new Location
        {
            City = "Ramat Gan",
            StartDate = new DateTime(),
            EndDate = new DateTime(),
            SpesipicLocation = "Hotel"
        };
        static List<Location> location1 = new List<Location>
        {
            l1, l2
        };
        static List<Location> location2 = new List<Location>
        {
            l3, l4
        };
     
        static Patient p1 = new Patient
        {
            PatientId = "1",
            Name = "Yosef",
            LocationList = location1
        };
    static Patient p2 = new Patient
    {
        PatientId = "2",
        Name = "Dani",
        LocationList = location2
};

      public List<Patient> patients { get; set; } = new List<Patient>()
        {
          p1,p2
        };
    }
}

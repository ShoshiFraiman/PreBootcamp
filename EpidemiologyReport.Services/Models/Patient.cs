using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpidemiologyReport.Services.Models
{
    public class Patient
    {
        public string PatientId { get; set; }
        public string Name { get; set; }
        public List<Location> LocationList { get; set; }
    }
}

using EpidemiologyReport.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpidemiologyReport.DAL
{
    public interface IEpidemiologyReportDB
    {
        List<Patient> patients { get; set; }

    }
}

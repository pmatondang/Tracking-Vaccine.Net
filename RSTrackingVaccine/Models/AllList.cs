using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RSTrackingVaccine.ServiceReference1;

namespace RSTrackingVaccine.Models
{
    public class AllList
    {
        public IEnumerable<vaksin> ListVaksin { get; set; }

        public IEnumerable<pasien> ListPasien { get; set; }
    }
}
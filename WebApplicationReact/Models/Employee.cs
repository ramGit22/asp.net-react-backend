using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Employee
    {
        public int OmistajaId { get; set; }
        public string Nimi { get; set; }
        public string Omistajarhymä { get; set; }
        public string Osoite { get; set; }

        public string Postitoimipaikka { get; set; }

    }
}
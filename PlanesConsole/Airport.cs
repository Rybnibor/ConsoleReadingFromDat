using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanesConsole
{
    class Airport
    {
        public string City { get; set; }
        public string Continent { get; set; }
        public Airport(string dataCity, string dataContinent)
        {
            City = dataCity;
            Continent = dataContinent;
        }


    }
}

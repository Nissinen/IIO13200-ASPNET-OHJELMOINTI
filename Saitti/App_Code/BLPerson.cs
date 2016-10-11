using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// BLPerson sisältää businessluokat Json demoa varten
/// </summary>
/// 
namespace JAMK.IT { 
    public class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
    }
    public class Politic: Person
    {
        public string Party { get; set; }
        public string Position { get; set; }
    }
    public class Train
    {
        public string trainNumber { get; set; }
        public string cancelled { get; set; }
        public string departureDate { get; set; }
        public string trainType{ get; set; }
    }
    public class Station
    {
        public string stationName { get; set; }
        public string stationShortCode { get; set; }
    }
}
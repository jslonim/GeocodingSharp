using System;
using System.Collections.Generic;
using System.Text;

namespace GeocodingSharp.Service.DTO
{
    public class LocationByZipcodeResponse
    {
        public string Zipcode { get; set; }
        public City City { get; set; }
        public State State { get; set; }
        public County County { get; set; }
    }

    public class City 
    { 
        public string CityLongName { get; set; }
        public string CityShortName { get; set; }
    }

    public class State
    {
        public string StateLongName { get; set; }
        public string StateShortName { get; set; }
    }

    public class County
    {
        public string CountyLongName { get; set; }
        public string CountyShortName { get; set; }
    }
}

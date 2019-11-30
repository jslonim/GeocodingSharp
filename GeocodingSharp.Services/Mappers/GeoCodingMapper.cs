using GeocodingSharp.Service.DTO;
using GeocodingSharp.Service.DTO.Google;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeocodingSharp.Service.Mappers
{
    public static class GeoCodingMapper
    {
        /// <summary>
        /// Converts the google API response into a DTO with State,County and City.
        /// </summary>
        public static LocationByZipcodeResponse GetByZipcodeMapper(GeoCodingByZipcodeResponse origin) 
        {
            LocationByZipcodeResponse target = new LocationByZipcodeResponse();
            target.City = new City();
            target.County = new County();
            target.State = new State();

            //Zipcode
            target.Zipcode = origin.results[0].address_components[0].long_name;

            //City
            target.City.CityLongName = origin.results[0].address_components[1].long_name;
            target.City.CityShortName = origin.results[0].address_components[1].short_name;

            //County
            target.County.CountyLongName = origin.results[0].address_components[2].long_name;
            target.County.CountyShortName = origin.results[0].address_components[2].short_name;

            //State
            target.State.StateLongName = origin.results[0].address_components[3].long_name;
            target.State.StateShortName = origin.results[0].address_components[3].short_name;

            return target;
        }
    }
}

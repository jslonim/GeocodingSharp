using GeocodingSharp.Service.DTO;
using GeocodingSharp.Service.DTO.Google;
using GeocodingSharp.Service.Helpers;
using GeocodingSharp.Service.Interfaces;
using GeocodingSharp.Service.Mappers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GeocodingSharp.Geocoding.Service.Services
{
    public class GeocodingService : BaseService, IGeocodingService
    {
        #region Properties
        private string API_KEY { get; set; }
        #endregion
        #region Constants
        private const string resquestByZipcode = "https://maps.googleapis.com/maps/api/geocode/json?address={zipcode}&key={apikey}";
        #endregion

        public GeocodingService(string _apiKey)
        {
            API_KEY = _apiKey;
        }

        public LocationByZipcodeResponse GetLocationByZipcode(string zipcode)
        {
            string url = resquestByZipcode.Replace("{zipcode}", zipcode).Replace("{apikey}", API_KEY);
            GeoCodingByZipcodeResponse responseDTO = GetAsync<GeoCodingByZipcodeResponse>(url).Result;

            LocationByZipcodeResponse mappedDTO =  GeoCodingMapper.GetByZipcodeMapper(responseDTO);

            return mappedDTO;
        }

        public string GetLocationXMLByZipcode(string zipcode)
        {
            LocationByZipcodeResponse mappedDTO = GetLocationByZipcode(zipcode);

            return XMLHelper.SerializeToXML<LocationByZipcodeResponse>(mappedDTO);
        }

    }
}

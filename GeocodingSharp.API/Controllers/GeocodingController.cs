using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeocodingSharp.Service.DTO;
using GeocodingSharp.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeocodingSharp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeocodingController : ControllerBase
    {
        private IGeocodingService geocodingService;

        public GeocodingController(IGeocodingService _geocodingService)
        {
            geocodingService = _geocodingService;
        }

        [HttpGet]
        [Route("GetLocationByZipcode")]
        public ActionResult getLocationByZipcode(string zipcode)
        {
            LocationByZipcodeResponse response = geocodingService.GetLocationByZipcode(zipcode);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetLocationByZipcodeXML")]
        public ActionResult getLocationXMLByZipcode(string zipcode)
        {
            string response = geocodingService.GetLocationXMLByZipcode(zipcode);
            return Ok(response);
        }
    }
}
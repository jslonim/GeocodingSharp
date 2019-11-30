using GeocodingSharp.Service.DTO;

namespace GeocodingSharp.Service.Interfaces
{
    public interface IGeocodingService
    {
        LocationByZipcodeResponse GetLocationByZipcode(string zipcode);

        string GetLocationXMLByZipcode(string zipcode);
    }
}
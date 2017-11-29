using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace FCalendar.Model
{      
  
        public static class CoordinateConverter
        {
            public static GeoCoordinate ConvertGeocoordinate(Geocoordinate geocoordinate)
            {
                return new GeoCoordinate
                (
                    geocoordinate.Latitude,
                    geocoordinate.Longitude
                    
                );
            }

            

        }

    public class GeoCoordinate
    {
        public GeoCoordinate(double geocoordinateLatitude, double geocoordinateLongitude)
        {
            throw new NotImplementedException();
        }
    }
}

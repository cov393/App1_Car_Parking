using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App1.ContainerFunction
{
    public class MapPageViewModel
    {
        public MapPageViewModel()
        {

        }
        public class ParkingLocations
        {
            public string Latitude { get; set; }
            public string Longitude { get; set; }
        } 
        internal async Task<List<ParkingLocations>> LoadParking()
        {
            List<ParkingLocations> parkingLocations = new List<ParkingLocations>
            {
                new ParkingLocations{Latitude="52.41269236687764", Longitude="-1.5090226627687253"},
                new ParkingLocations {Latitude = "52.41104318148568", Longitude = "-1.5164899320667378" },
                new ParkingLocations{Latitude="52.402570761777", Longitude="-1.5111348242515066"}
            };
            return parkingLocations;
        }
    }
}

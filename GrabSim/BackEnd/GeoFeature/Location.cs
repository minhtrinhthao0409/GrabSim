using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrabSim
{
    class Location
    {
        private double latitude;
        private double longtitude;

        public Location(double latitude, double longtitude)
        {
            this.latitude = latitude;
            this.longtitude = longtitude;
        }

        public static double GetDistnace(Location loc1, Location loc2)
        {
            int R = 6371; // Radius of the earth in km
            double dLat = Deg2Rad(loc2.latitude - loc1.latitude);
            double dLon = Deg2Rad(loc2.longtitude - loc1.longtitude);

            double a =
                    Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Cos(Deg2Rad(loc1.latitude)) * Math.Cos(Deg2Rad(loc2.latitude)) *
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2); // haversine of central angle
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a)); // central angle
            double distance = R * c;

            return distance;
        }

        private static double Deg2Rad(double deg)
        {
            return deg * Math.PI / 180;
        }
    }
   
}

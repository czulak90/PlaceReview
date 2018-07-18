using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceReview.Core.Domain
{
    public class Coordinate
    {
        public double Latitude { get; protected set; }

        protected Coordinate()
        {
        }

        public Coordinate(double latitude, double longitude)
        {
            SetLatitude(latitude);
            SetLongitude(longitude);
        }

        private void SetLatitude(double latitude)
        {
            if (double.IsNaN(latitude))
            {
                throw new Exception("Latitude must be a number.");
            }
            if (latitude > 90 || latitude < -90)
            {
                throw new Exception("Latitude must be greater or equal than -90 and less or equal than 90.");
            }
            Latitude = latitude;
        }

        private void SetLongitude(double longitude)
        {
            if (double.IsNaN(longitude))
            {
                throw new Exception("Longitude must be number.");
            }
            if (longitude > 180 || longitude < -180)
            {
                throw new Exception("Longitude must be greater or equal than -180 and less or equal than 180.");
            }
            Longitude = longitude;
        }

        public static Coordinate Create(double latitude, double longitude) => new Coordinate(latitude, longitude);
    }
}

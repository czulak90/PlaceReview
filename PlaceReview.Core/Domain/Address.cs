using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlaceReview.Core.Domain
{
    public class Address
    {
        private string[] Continents = { "Asia", "Africa", "North America", "South America", "Antarctica", "Europe", "Australia" };
        public string Continent { get; protected set; }
        public string Country { get; protected set; }
        public string City { get; protected set; }
        public string State { get; protected set; }
        public string Street { get; protected set; }
        public string StreetNumber { get; protected set; }
        public string HouseNumber { get; protected set; }

        protected Address()
        {
        }

        protected Address(string continent, string country, string city, string state, string street, string streetNumber, string houseNumber)
        {
            SetContinent(continent);
            SetCountry(country);
            SetCity(city);
            State = state;
            Street = street;
            StreetNumber = streetNumber;
            HouseNumber = houseNumber;
        }

        private void SetContinent(string continent)
        {
            if (!Continents.Contains(continent))
            {
                throw new Exception($"Continent name: '{continent}' is invalid.");
            }
            Continent = continent;
        }

        public void SetCountry(string country)
        {
            if (string.IsNullOrEmpty(country))
            {
                throw new Exception("Country name can not be empty.");
            }
            Country = country;
        }

        public void SetCity(string city)
        {
            if (string.IsNullOrEmpty(city))
            {
                throw new Exception("City name can not be empty.");
            }
            City = city;
        }

        public static Address Create(string continent, string country, string city, string state, string street, string streetNumber, string houseNumber)
            => new Address(continent, country, city, state, street, streetNumber, houseNumber);
    }
}

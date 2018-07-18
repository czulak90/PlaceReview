using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceReview.Infrastructure.DTO
{
    public class PlaceDto
    {
        public Guid Id { get;  set; }
        public string Name { get;  set; }
        public string Descritpion { get;  set; }
        public AddressDto Address { get;  set; }
        public CoordinateDto Coordinate { get;  set; }
        public DateTime UpdatedAt { get;  set; }
        public double AvarageRate { get; set; }
        public int NumbersOfReviews { get; set; }
    }
}

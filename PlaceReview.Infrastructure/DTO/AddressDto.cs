namespace PlaceReview.Infrastructure.DTO
{
    public class AddressDto
    {
        public string Continent { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string HouseNumber { get; set; }
    }
}
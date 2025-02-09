namespace apartment.Types;

public class Location(string area, string city, string postalCode, string country, double latitude, double longitude)
{
    public string Area { get; set; } = area;
    public string City { get; set; } = city;
    public string PostalCode { get; set; } = postalCode;
    public string Country { get; set; } = country;
    public double Latitude { get; set; } = latitude;
    public double Longitude { get; set; } = longitude;
}
using apartment.Types;
using Location = apartment.Types.Location;

namespace apartment.Features.Amenities;

[QueryType]
public static class Query
{
    public static List<Amenity> GetAmenities()
    {
        return new List<Amenity>
        {
            new("Parking", AmenityType.Transport, true, 2, 1),
            new("WiFi", AmenityType.Other, true, 6, 1),
            new("TV", AmenityType.Other, true, 8, 1),
            new("Heating", AmenityType.Other, true, 9, 1),
            new("Air Conditioning", AmenityType.Other, true, 21, 1),
            new("Pool", AmenityType.Recreation, true, 9, 1),
            new("Spa", AmenityType.Recreation, true, 7, 1),
            new("Gym", AmenityType.Recreation, true, 4, 1),
            new("Shopping", AmenityType.Shopping, true, 1, 1),
            new("Restaurant", AmenityType.Shopping, true, 20, 1),
            new("Bar", AmenityType.Shopping, true, 3, 1),
            new("Hairdresser", AmenityType.Other, true, 1, 1),
            new("Massage", AmenityType.Other, true, 12, 1),
            new("Dentist", AmenityType.Healthcare, true, 7, 1),
            new("Doctor", AmenityType.Healthcare, true, 17, 1),
            new("Eye Care", AmenityType.Healthcare, true, 19, 1),
            new("Health Insurance", AmenityType.Healthcare, true, 16, 1),
            new("Insurance", AmenityType.Other, true, 13, 1),
            new("Car Rental", AmenityType.Transport, true, 11, 1),
            new("Bike Rental", AmenityType.Transport, true, 10, 1),
            new("Motorcycle Rental", AmenityType.Transport, true, 9, 1),
            new("Taxi Service", AmenityType.Transport, true, 5, 1),
            new("Bus Station", AmenityType.Transport, true, 15, 1),
            new("Train Station", AmenityType.Transport, true, 7, 1),
            new("Walking Trails", AmenityType.Transport, true, 3, 1),
            new("Cycling Paths", AmenityType.Transport, true, 20, 1),
            new("Driving School", AmenityType.Education, true, 4, 1),
            new("Language School", AmenityType.Education, true, 8, 1),
            new("School", AmenityType.Education, true, 12, 1),
            new("Library", AmenityType.Education, true, 20, 1),
            new("Park", AmenityType.Recreation, true, 3, 1),
            new("Garden", AmenityType.Recreation, true, 8, 1)
        };
    }
}

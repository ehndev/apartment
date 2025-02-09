using apartment.Types;
using Location = apartment.Types.Location;

namespace apartment.Features.Apartments;
[MutationType]
public  class Mutation
{
  
    public Apartment? CreateApartmentAsync([ID] Guid userId, string username)
    {
        return new Apartment("Crystal Rivers", new Location("Athi River", "Machakos", "560028", "Kenya", 12.971599, 77.594563), new List<ContactPerson>
            {
                new("Jane Doe", "+254701234567", "janedoe@email.com"),
                new("John Smith", "+254701234568", "johnsmith@email.com")
            }, new ApartmentDetails("Apartment", 1, 2, 1, true, true), new ShowcaseImages[] { new ("https://example.com/images/apartment1.jpg", "Front view of the apartment"), new ("https://example.com/images/apartment2.jpg", "Living room interior"), new ("https://example.com/images/apartment3.jpg", "Spacious kitchen with modern fittings") }, new RentalPricing(1000, 500, 100), new Amenity[] { new("Parking", AmenityType.Transport, true, 2, 1), new("WiFi", AmenityType.Other, true, 6, 1), new("TV", AmenityType.Other, true, 8, 1), new("Heating", AmenityType.Other, true, 9, 1), new("Air Conditioning", AmenityType.Other, true, 21, 1), new("Pool", AmenityType.Recreation, true, 78, 1), new("Spa", AmenityType.Recreation, true, 12, 1), new("Gym", AmenityType.Recreation, true, 12, 1), new("Shopping", AmenityType.Shopping, true, 114, 1) }
        );
    }

}
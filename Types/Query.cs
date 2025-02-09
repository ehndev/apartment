namespace apartment.Types;

[QueryType]
public static class Query
{
    public static Apartment GetApartment()

    {
        var location = new Location("Athi River", "Machakos", "560028", "Kenya", 12.971599, 77.594563);
        var contactPeople = new List<ContactPerson>
        {
            new("Jane Doe", "+254701234567", "janedoe@email.com"),
            new("John Smith", "+254701234568", "johnsmith@email.com")
        };
        var apartmentDetails = new ApartmentDetails("Apartment", 1, 2, 1, true, true);
        var showcase = new List<ShowcaseImages>
        {
            new ("https://example.com/images/apartment1.jpg", "Front view of the apartment"),
            new ("https://example.com/images/apartment2.jpg", "Living room interior"),
            new ("https://example.com/images/apartment3.jpg", "Spacious kitchen with modern fittings")
        };
        var rentalPricing = new RentalPricing(1000, 500, 100);
        var amenities = new List<Amenity>
        {
            new("Parking", AmenityType.Transport, true, 2, 1),
            new("WiFi", AmenityType.Other, true, 6, 1),
            new("TV", AmenityType.Other, true, 8, 1),
            new("Heating", AmenityType.Other, true, 9, 1),
            new("Air Conditioning", AmenityType.Other, true, 21, 1),
            new("Pool", AmenityType.Recreation, true, 78, 1),
            new("Spa", AmenityType.Recreation, true, 12, 1),
            new("Gym", AmenityType.Recreation, true, 12, 1),
            new("Shopping", AmenityType.Shopping, true, 114, 1),
            new("Restaurant", AmenityType.Shopping, true, 8, 1),
            new("Bar", AmenityType.Shopping, true, 5, 1),
            new("Hairdresser", AmenityType.Other, true, 9, 1),
            new("Mass                    age", AmenityType.Other, true, 12, 1),
            new("Dentist", AmenityType.Healthcare, true, 7, 1),
            new("Doctor", AmenityType.Healthcare, true, 17, 1),
            new("Eye Care", AmenityType.Healthcare, true, 19, 1),
            new("Health Insurance", AmenityType.Healthcare, true, 16, 1),
            new("Insurance", AmenityType.Other, true, 13, 1),
            new("Car", AmenityType.Transport, true, 11, 1),
            new("Bike", AmenityType.Transport, true, 10, 1),
            new("Motorcycle", AmenityType.Transport, true, 9, 1),
            new("Taxi", AmenityType.Transport, true, 5, 1),
            new("Bus", AmenityType.Transport, true, 15, 1),
            new("Train", AmenityType.Transport, true, 7, 1),
            new("Walking", AmenityType.Transport, true, 3, 1),
            new("Cycling", AmenityType.Transport, true, 20, 1),
            new("Driving School", AmenityType.Education, true, 4, 1),
            new("Language School", AmenityType.Education, true, 8, 1),
            new("School", AmenityType.Education, true, 12, 1),
            new("Library", AmenityType.Education, true, 20, 1),
            new("Park", AmenityType.Recreation, true, 3, 1),
            new("Garden", AmenityType.Recreation, true, 8, 1),
            new("Pool", AmenityType.Recreation, true, 9, 1),
            new("Spa", AmenityType.Recreation, true, 7, 1),
            new("Gym", AmenityType.Recreation, true, 4, 1),
            new("Shopping", AmenityType.Shopping, true, 1, 1),
            new("Restaurant", AmenityType.Shopping, true, 20, 1),
            new("Bar", AmenityType.Shopping, true, 3, 1),
            new("Hairdresser", AmenityType.Other, true, 1, 1),
        };
        return new Apartment("Crystal Rivers", location, contactPeople,apartmentDetails,showcase.ToArray(),rentalPricing,amenities.ToArray());
    }
}

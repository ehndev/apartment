namespace apartment.Types;

public record Apartment(string Name,  Location Location ,List<ContactPerson> ContactPeople ,ApartmentDetails ApartmentDetails,ShowcaseImages[] ShowcaseImages, RentalPricing RentalPricing, Amenity[] Amenities);   

using apartment.Types;
using Location = apartment.Types.Location;

namespace apartment.Features.Amenities;
[MutationType]
public  class Mutation
{
  
    public Amenity? CreateApartmentAsync([ID] Guid userId, string username)
    {
        return new Amenity("Parking", AmenityType.Transport, true, 2, 1);
    }

}
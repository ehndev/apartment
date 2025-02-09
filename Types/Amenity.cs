namespace apartment.Types;

public class Amenity(string name, AmenityType type, bool isAvailable, double? distanceInKm , int count )
{
    public string Name { get; set; } = name;
    public AmenityType Type { get; set; } = type;
    public bool IsAvailable { get; set; } = isAvailable;
    public double? DistanceInKm { get; set; } = distanceInKm; 
    public int Count { get; set; } = count;
}

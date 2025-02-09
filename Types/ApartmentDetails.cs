namespace apartment.Types;
public class ApartmentDetails(
    string type,
    int floorNumber,
    int numberOfBedrooms,
    int numberOfBathrooms,
    bool hasBalcony,
    bool hasParking)
{
    public string Type { get; set; } = type;
    public int FloorNumber { get; set; } = floorNumber;
    public int NumberOfBedrooms { get; set; } = numberOfBedrooms;
    public int NumberOfBathrooms { get; set; } = numberOfBathrooms;
    public bool HasBalcony { get; set; } = hasBalcony;
    public bool HasParking { get; set; } = hasParking;
}
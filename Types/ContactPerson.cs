namespace apartment.Types;

public class ContactPerson(string name, string contactInfo, string email)
{
    public string Name { get; set; } = name;
    public string ContactInfo { get; set; } = contactInfo;
    public string Email { get; set; } = email;
}

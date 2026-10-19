

namespace Client.Models;

public class Teachers : Person
{
    public required string KnowledgeArea { get; set; }
    public List<Course> Courses { get; set; } = new();

    public override string ToString()
    {
        return $"Förnamn: {FirstName} Efternamn: {LastName} Email: {Email} TelefonNr: {PhoneNr} Adress: {Address.StreetAddress} Stad: {Address.City} PostNr: {Address.PostalCode} Kunskapsområden: {KnowledgeArea}";
    }

}

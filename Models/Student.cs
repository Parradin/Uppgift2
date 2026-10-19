namespace Client.Models;

public class Student : Person
{
    public override string ToString()
    {
        return $"Förnamn: {FirstName}, Efternamn: {LastName}, Email: {Email}, TelefonNr: {PhoneNr} Adress: {Address.StreetAddress} Stad: {Address.City} Postnr: {Address.PostalCode}";
    }

}

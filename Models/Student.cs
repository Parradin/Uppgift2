namespace Client.Models;

public class Student : Person
{
    public override string ToString()
    {
        return $"Förnamn: {FirstName}";
    }

}

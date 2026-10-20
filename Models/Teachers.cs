

namespace Client.Models;

public class Teachers : Person
{
    public required string KnowledgeArea { get; set; }
    public List<Course> Courses { get; set; } = new();

    public override string ToString()
    {
        string CourseTitles = "";
        int count = 0;

        foreach (Course course in Courses)
        {
            if (count > 0)
            {
                CourseTitles += ", ";
            }

            CourseTitles += course.CourseTitel;
            count++;
        }
        return $"Förnamn: {FirstName} Efternamn: {LastName} Email: {Email} TelefonNr: {PhoneNr} Adress: {Address.StreetAddress} Stad: {Address.City} PostNr: {Address.PostalCode} Kunskapsområden: {KnowledgeArea} Ansvariga kurser: {CourseTitles}";
    }

}

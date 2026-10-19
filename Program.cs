using Client.Models;

class Program
{
    static void Main()
    {
        Address address = new Address
        {
            StreetAddress = "storgatan 1",
            City = "Halmstad",
            PostalCode = "302 40"

        };
        Student student = new Student
        {
            Address = address,
            FirstName = "Steffan",
            LastName = "Parra",
            Email = "steffan.parra@gmail.com",
            PhoneNr = "0762855129"
        };
        Console.WriteLine(student);



    }

}



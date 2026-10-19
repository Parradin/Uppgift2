using Client.Models;

class Program
{
    static void Main()
    {
        Address address = new Address
        {
            StreetAddress = "storgate 1",
            City = "Halmstad",
            PostalCode = "302 40"

        };
        Console.WriteLine(address);



    }

}



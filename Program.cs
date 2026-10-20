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
            PersonalId = "1980-02-15",
            FirstName = "Steffan",
            LastName = "Parra",
            Email = "steffan.parra@gmail.com",
            PhoneNr = "0762855129"
        };
        Teachers teachers = new Teachers
        {
            Address = address,
            PersonalId = "1998-05-27",
            FirstName = "Petter",
            LastName = "Averbo",
            Email = "petter.averbo@gmail.com",
            PhoneNr = "0762548628",
            KnowledgeArea = "Programmering A"
        };
        Course course = new Course
        {
            CourseNr = "C001",
            CourseTitel = "Programmering A",
            StartDate = new DateTime(2026, 10, 20),
            EndDate = new DateTime(2027, 05, 20),
            IsDistance = false
        };
        Course course1 = new Course
        {
            CourseNr = "D002",
            CourseTitel = "Webbutvecklare",
            StartDate = new DateTime(2026, 10, 20),
            EndDate = new DateTime(2027, 05, 20),
            IsDistance = false
        };
        //skapar en lista på alla kurserna
        List<Course> courses = [];

        courses.Add(course);
        courses.Add(course1);


        teachers.Courses.Add(course);
        teachers.Courses.Add(course1);

        foreach (Course courseItem in courses)
        {
            Console.WriteLine(courseItem);
        }

        Console.WriteLine(student);
        Console.WriteLine(teachers);
        Console.WriteLine($"Antal kurser: {teachers.Courses.Count}");
    }

}



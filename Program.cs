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
            PersonalId = "19800215-9875",
            FirstName = "Steffan",
            LastName = "Parra",
            Email = "steffan.parra@gmail.com",
            PhoneNr = "0762855129"
        };
        Teacher teacher = new Teacher
        {
            Address = address,
            PersonalId = "19980527-1234",
            FirstName = "Petter",
            LastName = "Averbo",
            Email = "petter.averbo@gmail.com",
            PhoneNr = "0762548628",
            KnowledgeArea = "Programmering A"
        };
        EducationLeader educationLeader = new EducationLeader
        {
            PersonalId = "19700830-4215",
            Address = address,
            FirstName = "Jessica",
            LastName = "Eliasson",
            Email = "jessica.eliasson@gmail.com",
            PhoneNr = "0762855471",
            KnowledgeArea = "IT",
            DateOfHire = new DateTime(2024, 8, 1)
        };
        Administrator administrator = new Administrator
        {
            PersonalId = "19880830-1245",
            Address = address,
            FirstName = "Roberth",
            LastName = "Birgell",
            Email = "roberth.birgell@gmail.com",
            PhoneNr = "0762514523",
            KnowledgeArea = "Admin",
            DateOfHire = new DateTime(2025, 6, 24)
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
        AddCourse(courses, course);
        AddCourse(courses, course1);
        ListCourses(courses);

        List<Student> students = [];
        AddStudents(students, student);
        ListStudents(students);

        List<EducationLeader> educationLeaders = [];
        AddEducationLeaders(educationLeaders, educationLeader);
        ListEducationLeaders(educationLeaders);

        List<Administrator> administrators = [];
        AddAdministrator(administrators, administrator);
        ListAdministrators(administrators);

        List<Teacher> teachers = [];
        AddTeacher(teachers, teacher);
        ListTeachers(teachers);


        teacher.Courses.Add(course);
        teacher.Courses.Add(course1);

        Console.WriteLine($"Antal kurser: {teacher.Courses.Count}");
    }

    static void ListCourses(List<Course> courses)
    {
        foreach (Course courseItem in courses)
        {
            Console.WriteLine(courseItem);
        }
    }

    static void AddCourse(List<Course> courses, Course course)
    {
        courses.Add(course);
    }

    static void AddStudents(List<Student> students, Student student)
    {
        students.Add(student);
    }

    static void ListStudents(List<Student> students)
    {
        foreach (Student studentItem in students)
        {
            Console.WriteLine(studentItem);
        }
    }

    static void AddEducationLeaders(List<EducationLeader> educationsLeaders, EducationLeader educationLeader)
    {
        educationsLeaders.Add(educationLeader);
    }

    static void ListEducationLeaders(List<EducationLeader> educationLeaders)
    {
        foreach (EducationLeader educationLeaderItem in educationLeaders)
        {
            Console.WriteLine(educationLeaderItem);
        }
    }

    static void AddAdministrator(List<Administrator> administrators, Administrator administrator)
    {
        administrators.Add(administrator);
    }

    static void ListAdministrators(List<Administrator> administrators)
    {
        foreach (Administrator administratorItem in administrators)
        {
            Console.WriteLine(administratorItem);
        }
    }

    static void AddTeacher(List<Teacher> teachers, Teacher teacher)
    {
        teachers.Add(teacher);
    }

    static void ListTeachers(List<Teacher> teachers)
    {
        foreach (Teacher teacherItem in teachers)
        {
            Console.WriteLine(teacherItem);
        }
    }
}



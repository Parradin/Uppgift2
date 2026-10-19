namespace Client.Models;

public class Course
{
    public required string CourseNr { get; set; }
    public required string CourseTitel { get; set; }
    public required DateTime StartDate { get; set; }
    public required DateTime EndDate { get; set; }
    public required string Classroom { get; set; }
    public required string Distance { get; set; }
}

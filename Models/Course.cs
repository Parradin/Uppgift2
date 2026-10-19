namespace Client.Models;

public class Course
{
    public required string CourseNr { get; set; }
    public required string CourseTitel { get; set; }
    public required DateTime StartDate { get; set; }
    public required DateTime EndDate { get; set; }
    //IsDistance visa ifall man har i klassrum eller distans...
    public bool IsDistance { get; set; }
}

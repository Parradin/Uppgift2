using System;

namespace Client.Models;

public class Teachers : Person
{
    public required string KnowledgeArea { get; set; }
    public List<Course> Courses { get; set; } = new();

}

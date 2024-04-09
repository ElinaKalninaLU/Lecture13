using System;
using System.Collections.Generic;

namespace Lecture13.ModelsDB;

public partial class Student
{
    public int StudentId { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
}

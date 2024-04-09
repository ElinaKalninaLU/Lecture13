using System.ComponentModel.DataAnnotations;

namespace Lecture13.Data
{
    public class StudentCourse
    {
        [Key]
        public int Id { get; set; }
        // Composite key properties
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        // Navigation properties

        public Student? Student { get; set; }
        public Course? Course { get; set; }
    }
}

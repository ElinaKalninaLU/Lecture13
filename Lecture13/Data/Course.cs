using System.ComponentModel.DataAnnotations;

namespace Lecture13.Data
{
    public class Course
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }
    }
}

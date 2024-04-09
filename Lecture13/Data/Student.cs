using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lecture13.Data
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50), Required]
        public string Surname { get; set; }

        [NotMapped]
        public string FullName => Name + " " + Surname;
    }
}

using System.ComponentModel.DataAnnotations;

namespace TraininggSystem.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
       public string? StudentName { get; set; }
        [Required]

        public string? StudentEmail { get; set; }
        [Required]
        public string? Password {  get; set; }
        [Required]
        public string? Confirmpassword { get; set;}
    }
}

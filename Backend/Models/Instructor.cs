using System.ComponentModel.DataAnnotations;

namespace TraininggSystem.Models
{
    public class Instructor
    {
        [Key]
        public int InstructorId { get; set; }
        [Required]
        public string? InstructorName { get; set; }
        [Required]

        public string? InstructorEmail { get; set; }
        [Required]

        public string? InstructorPhoneno { get; set; }
        [Required]

        public string? InstructorCourseName { get; set; }
    }
}

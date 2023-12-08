using System.ComponentModel.DataAnnotations;

namespace TraininggSystem.Models
{
    public class Enrolment
    {
        [Key]
        public int EnrolmentId { get; set; }
        [Required]

        [DataType(DataType.DateTime)]
        public DateTime EnrolementDateAndTime { get; set; }
        [Required]

        [DataType(DataType.Currency)]
        public float EnrolmentAmount { get; set; }
        [Required]
        public int CourseId { get; set; }
        [Required]
        public int StudentId { get; set; }
        [Required]
        public int InstructorId { get; set; }
    }
}

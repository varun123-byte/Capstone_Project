using System.ComponentModel.DataAnnotations;

namespace TraininggSystem.Models
{
    public class Courses
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        public string? CourseTitle { get; set; }
        [Required]

        [DataType(DataType.Currency)]
        public double CourseFee { get; set; }
        [Required]

        [DataType(DataType.DateTime)]
        public DateTime? CourseStartDate { get; set; }
        [Required]

        [DataType(DataType.DateTime)]
        public DateTime? CourseEndDate { get; set; }
        [Required]
        public int Credits { get; set; }
    }
}

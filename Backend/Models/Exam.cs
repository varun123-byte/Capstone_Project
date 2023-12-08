using System.ComponentModel.DataAnnotations;

namespace TraininggSystem.Models
{
    public class Exam
    {
        [Key]
        public int ExamId { get; set; }
        [Required]

        public int CertificateId { get; set; }
        [Required]

        public string? ExamName { get; set; }
        [Required]

        [DataType(DataType.DateTime)]
        public DateTime? ExamDateTime { get; set; }
        [Required]
        [DisplayFormat(NullDisplayText = " Fail ")]
        public string? ExamGrade { get; set; }
    }
}

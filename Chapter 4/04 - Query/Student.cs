using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MappedModel
{
    public class Student
    {
        [Key]
        public Guid StudentID { get; set; }
        [Required, StringLength(100)]
        public string FullNames { get; set; }
        [Required, StringLength(1)]
        public string Gender { get; set; } = "M";
        [Required, StringLength(100), RegularExpression(@"^[a-zA-Z]+$")]
        public string Surname { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required, Range(4, 7)]
        public decimal Height { get; set; }
        [Column("WGHT")]
        public decimal? Weight { get; set; }
        public string SystemAge { get; set; }
        public decimal FeesOutstanding { get; set; }
        [NotMapped]
        public int Age => (DateTime.Now.Year - DateOfBirth.Year);
    }
}

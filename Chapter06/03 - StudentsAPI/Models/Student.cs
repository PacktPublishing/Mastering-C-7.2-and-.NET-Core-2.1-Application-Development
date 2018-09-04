using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentsAPI.Models
{
    public class Student
    {
        [Key]
        public Guid StudentID { get; set; }
        [Required, StringLength(100)]
        public string Surname { get; set; }
        [Required, StringLength(100)]
        public string OtherNames { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Required, Range(4, 7)]
        public decimal Height { get; set; }
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
    }
}


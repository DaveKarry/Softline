using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Softline.Models
{
    public class Employer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string Surname { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Midname { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string Position { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string Note { get; set; }

        [Required]
        public bool MaternityLeave { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

    }
}

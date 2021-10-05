using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Softline.DTO
{
    public class EmployerUpdateDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Midname { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public string Note { get; set; }
        [Required]
        public bool MaternityLeave { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
    }
}

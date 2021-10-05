using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Softline.DTO
{
    public class EmployerReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Midname { get; set; }
        public string Position { get; set; }
        public string Note { get; set; }
        public bool MaternityLeave { get; set; }
        public DateTime BirthDate { get; set; }
    }
}

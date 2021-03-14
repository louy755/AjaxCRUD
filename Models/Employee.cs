using System;
using System.ComponentModel.DataAnnotations;

namespace APIAPPAjaxCRUD.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Country { get; set; }
    }
}

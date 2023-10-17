using System.ComponentModel.DataAnnotations;

namespace StudentBlazorTE.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required, EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? Coursecode { get; set; }
        [Required]
        public string? Coursetitle { get; set; }
    }
}

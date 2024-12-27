using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.DTOs
{
    public class StudentCreateDTO
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Range(18, 100, ErrorMessage = "Age must be between 18 and 100.")]
        public int Age { get; set; }

        [Required]
        [StringLength(50)]
        public string Course { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}

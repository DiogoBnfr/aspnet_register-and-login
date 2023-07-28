using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace aspnet_register_and_login.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("First Name")]
        [MaxLength(20, ErrorMessage = "First can't have more than 20 characters")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        [MaxLength(20, ErrorMessage = "First can't have more than 20 characters")]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

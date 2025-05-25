using System.ComponentModel.DataAnnotations;

namespace RetailManagementSystem.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        public string Role { get; set; } // Optional: Admin, Employee, 
    }
}

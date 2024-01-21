using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace SurRon_VIN.Models
{
    public class Users
    {
        public int Id { get; set; }

        [EmailAddress]
        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Username { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        [Phone]
        public string? PhoneNumber { get; set; }

        [Required]
        [MaxLength(12)]
        [MinLength(8)]
        [PasswordPropertyText]
        public string? Password { get; set; }


    }
}

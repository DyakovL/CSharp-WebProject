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
        [MinLength(2)]
        [MaxLength(72)]
        public string? Username { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(72)]
        public string? FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(72)]
        public string? LastName { get; set; }

        [Required]
        public string? PhoneNumber { get; set; }

        [Required]
        [MaxLength(12)]
        [MinLength(8)]
        [PasswordPropertyText]
        public string? Password { get; set; }


    }
}

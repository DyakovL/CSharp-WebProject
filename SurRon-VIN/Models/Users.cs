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
        [MaxLength(12)]
        [MinLength(8)]
        [PasswordPropertyText]
        public string? Password { get; set; }


    }
}

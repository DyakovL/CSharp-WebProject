using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SurRon_VIN.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        [Required]
        public string? Username { get; set; }

        public string? Password { get; set; }
    }
}

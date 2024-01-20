using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SurRon_VIN.Models
{
    public class RegisterMotorcycle
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? MotorcycleType { get; set; }

        public string? Vin { get; set; }

        [Display(Name = "Date Bought")]
        [DataType(DataType.Date)]
        public DateTime DateTime { get; set; }

    }
}

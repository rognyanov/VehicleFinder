namespace VehicleFinder.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public sealed class Extra : BaseEntity
    {
        [Required(ErrorMessage = "Please enter the extra's name.")]
        [MaxLength(50, ErrorMessage = "Extra's name must be under 50 characters long.")]
        public string Name { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}

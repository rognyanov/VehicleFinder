namespace VehicleFinder.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using VehicleFinder.Models.Enums;

    public sealed class Vehicle : BaseEntity
    {
        [Required(ErrorMessage = "Please enter the vehicle's year of manufacturing.")]
        [Range(1900, 2020, ErrorMessage = "Year of manufacturing must be between 1900 and 2020.")]
        public int ManufactureYear { get; set; }

        [Required(ErrorMessage = "Please enter the vehicle's horse power.")]
        [Range(1,int.MaxValue, ErrorMessage = "The horse power must be a positive number.")]
        public int HorsePower { get; set; }

        public BodyStyle BodyStyle { get; set; }

        public Brand Brand { get; set; }

        public Model Model { get; set; }

        public Engine Engine { get; set; }

        public ICollection<Extra> Extras { get; set; }

    }
}

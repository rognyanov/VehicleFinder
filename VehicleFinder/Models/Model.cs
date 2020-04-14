namespace VehicleFinder.Models
{
    using System.ComponentModel.DataAnnotations;

    public sealed class Model : BaseEntity
    {
        [Required(ErrorMessage = "Please enter the model's name.")]
        [MaxLength(50, ErrorMessage = "Model's name must be under 50 characters long.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the vehicle's year of manufacturing.")]
        [Range(1900, 2020, ErrorMessage = "Year of manufacturing must be between 1900 and 2020.")]
        public int Year { get; set; }

    }
}

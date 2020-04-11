using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace VehicleFinder.ViewModels
{
    public sealed class AddVehicleViewModel
    {
        [Required(ErrorMessage = "Please enter the brand's name.")]
        [MaxLength(50, ErrorMessage = "Brand's name must be under 50 characters long.")]
        public string Brand { get; set; }
        [Required(ErrorMessage = "Please enter the model's name.")]
        [MaxLength(50, ErrorMessage = "Model's name must be under 50 characters long.")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Please enter the engine's name.")]
        [MaxLength(50, ErrorMessage = "Engine's name must be under 50 characters long.")]
        public string EngineName { get; set; }
        public string EngineType { get; set; }
        [Required(ErrorMessage = "Please enter the vehicle's year of manufacturing.")]
        [Range(1900, 2020, ErrorMessage = "Year of manufacturing must be between 1900 and 2020.")]
        public int ManufactureYear { get; set; }
        [Required(ErrorMessage = "Please enter the vehicle's year of manufacturing.")]
        [Range(1900, 2020, ErrorMessage = "Year of manufacturing must be between 1900 and 2020.")]
        public int ModelYear { get; set; }
        [Required(ErrorMessage = "Please enter the vehicle's horse power.")]
        [Range(1, int.MaxValue, ErrorMessage = "The horse power must be a positive number.")]
        public int HorsePower { get; set; }
        public string BodyStyle { get; set; }
        public bool HasLeatherUpholstery { get; set; }
        public bool HasHeatedSeats { get; set; }
        public bool HasPanoramicRoof { get; set; }
        public bool HasReversingCamera { get; set; }
        public bool HasDashcam { get; set; }
        public bool HasNavigation { get; set; }

        public ICollection<string> getValidationErrors() 
        {
            var context = new ValidationContext(this);
            var results = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(this, context, results, true);

            return results.Select(r => r.ErrorMessage).ToList();
        } 
    }
}

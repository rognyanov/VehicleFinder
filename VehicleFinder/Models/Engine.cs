namespace VehicleFinder.Models
{
    using System.ComponentModel.DataAnnotations;
    using VehicleFinder.Models.Enums;

    public sealed class Engine : BaseEntity
    {
        [Required(ErrorMessage = "Please enter the engine's name.")]
        [MaxLength(50, ErrorMessage = "Engine's name must be under 50 characters long.")]
        public string Name { get; set; }

        public EngineType EngineType { get; set; }
    }
}

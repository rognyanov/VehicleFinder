namespace VehicleFinder.Models
{
    using System.ComponentModel.DataAnnotations;

    public sealed class Brand : BaseEntity
    {
        [Required(ErrorMessage ="Please enter the brand's name.")]
        [MaxLength(50, ErrorMessage = "Brand's name must be under 50 characters long.")]
        public string Name { get; set; }

    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace Provo_Restaurant_Suggestions.Models
{
    public class Restaurant
    {
#nullable enable
        public string? Name { get; set; } = "Unknown";
#nullable disable
        [Required]
        [Display(Name = "Restaurant Name is invalid.")]
        public string RestaurantName { get; set; }
        [Required]
        public string Dish { get; set; }
        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
        ErrorMessage = "Entered phone format is not valid.")]
        public string Phone { get; set; }
    }
}

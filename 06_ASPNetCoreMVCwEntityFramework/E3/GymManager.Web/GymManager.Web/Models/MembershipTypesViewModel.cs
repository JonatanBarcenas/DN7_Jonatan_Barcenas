using System.ComponentModel.DataAnnotations;

namespace GymManager.Web.Models
{
    public class MembershipTypesViewModel
    {
        public int Id { get; set; }
    
        [StringLength(15)]
        [Required(ErrorMessage = "You must enter the name of the membership")]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        [Range(1, 12, ErrorMessage = "The duration must be a number between 1 and 12.")]
        public int DurationInMonths { get; set; }
    }
}

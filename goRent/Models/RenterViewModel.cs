using System.ComponentModel.DataAnnotations;

namespace goRent.Models
{
    public class RenterViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}

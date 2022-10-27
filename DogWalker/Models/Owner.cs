using System.ComponentModel.DataAnnotations;

namespace DogWalker.Models
{
    public class Owner
    {
        public int Id { get; set; }
        
        
        [EmailAddress]
        [Required(ErrorMessage ="Enter valid email address.")]
        public string Email { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }

        public int NeighborhoodId { get; set; }
        public string Phone { get; set; }
        public Neighborhood Neighborhood { get; set; }
    }
}

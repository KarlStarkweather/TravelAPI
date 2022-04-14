using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TravelAPI.Models
{
    public class Destination
    {
        public Destination()
        {
            this.Reviews = new HashSet<Review>();
        }

        public int DestinationID {get; set; }
        [Required]
        [StringLength(20)]
        public string Name {get; set; }
        [Required]
        [StringLength(20)]
        public string City {get; set; }
        [Required]
        [StringLength(20)]
        public string Country {get; set; }

        public virtual ICollection<Review> Reviews {get; set; }

    }

    
}
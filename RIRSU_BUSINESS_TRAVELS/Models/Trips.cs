using System.ComponentModel.DataAnnotations;

namespace RIRSU_BUSINESS_TRAVELS.Models
{
    public class Trips
    {
        public int Id { get; set; }


        [Required]
        [StringLength(100)]
        public string Purpose { get; set; }


        [Required]
        [StringLength(100)]
        public string Destination { get; set; }

        [Required]
        public DateTime StarDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }
    }
}

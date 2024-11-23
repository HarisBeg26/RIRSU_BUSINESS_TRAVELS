using System.ComponentModel.DataAnnotations;

namespace RIRSU_BUSINESS_TRAVELS.Models
{
    public class Expenses
    {
        public int Id { get; set; }
        public int TripId { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace cashTracker.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        [Required]
        public string? Category { get; set; }
        [Required]
        public string UserId { get; set; }
        public Users User { get; set; }
    }
}

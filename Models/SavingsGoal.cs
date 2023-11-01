using System.ComponentModel.DataAnnotations;

namespace PiggyBank.Models
{
    public class SavingsGoal
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public string Title { get; set; }
        [Required]
        public float GoalPrice { get; set; }
        public string Description { get; set; }
        public string LinkToPage { get; set; }
        public string LinkToImage { get; set; }
    }
}
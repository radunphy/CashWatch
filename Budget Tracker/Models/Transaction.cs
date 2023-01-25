using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CashWatch.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }

        // CategoryId
        [Display(Name = "Category")]
        public int CategoryID { get; set; }

        [ForeignKey(nameof(CategoryID))]
        public Category? Category { get; set; }

        [Column(TypeName = "int")]
        public int Amount { get; set; }

        [Column(TypeName = "nvarchar(75)")]
        public string? Note { get; set; }
        
        [Column(TypeName = "date")]
        public DateTime Date { get; set; } = DateTime.Now;    

    }
}

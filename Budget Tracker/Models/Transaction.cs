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
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category? Category { get; set; }

        [Column(TypeName = "int")]
        public int Amount { get; set; }

        [Column(TypeName = "nvarchar(75)")]
        public string? Note { get; set; }
        [Column(TypeName = "int")]
        public DateTime Date { get; set; } = DateTime.Now;

    }
}

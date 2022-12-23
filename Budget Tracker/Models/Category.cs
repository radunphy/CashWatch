using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CashWatch.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Frequency { get; set; } = "Single Purchase";

        [Column(TypeName = "nvarchar(50)")]
        public string Type { get; set; } = "Expense";


    }
}

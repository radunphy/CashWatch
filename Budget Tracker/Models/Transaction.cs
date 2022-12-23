﻿using System.ComponentModel.DataAnnotations;

namespace CashWatch.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }

        // CategoryId
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int Amount { get; set; }
        public string? Note { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

    }
}

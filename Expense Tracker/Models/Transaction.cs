﻿using System.ComponentModel.DataAnnotations;

namespace Expense_Tracker.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        public int Amount { get; set; }
        public string? Note { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}

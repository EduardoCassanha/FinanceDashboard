using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceDashboard.Models
{
    public class Transaction
    {

        public string Id { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public bool IsIncome { get; set; }

        public Transaction()
        {
            Id = Guid.NewGuid().ToString();
            Date = DateTime.Now;  
        }
    }
}

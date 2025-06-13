using System;

namespace TelecomServiceManager.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsPaid { get; set; }

        // Navigation property (optional)
        // public Customer? Customer { get; set; }
    }
}

using System;

namespace TelecomServiceManager.Models
{
    public class CustomerService
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ServiceId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        // Navigation properties (optional, if you wire up EF Core later)
        // public Customer? Customer { get; set; }
        // public Service? Service { get; set; }
    }
}

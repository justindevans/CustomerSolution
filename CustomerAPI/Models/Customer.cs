using System.ComponentModel.DataAnnotations;

namespace CustomerAPI.Models
{
    public class Customer
    {
        [Key]
        public int customerId { get; set; }
        public string? customerTitle { get; set; }
        public string customerFirstName { get; set; }
        public string customerLastName { get; set; }
        public string customerEmail { get; set; }
        public string customerTelephone { get; set; }
        public string? customerAddr1 { get; set; }
        public string? customerAddr2 { get; set; }
        public string? customerTown { get; set; }
        public string? customerPostcode { get; set; }

    }
}

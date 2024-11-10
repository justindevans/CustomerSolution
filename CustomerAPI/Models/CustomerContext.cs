using Microsoft.EntityFrameworkCore;

namespace CustomerAPI.Models;

public class CustomerContext : DbContext
{
    public CustomerContext(DbContextOptions<CustomerContext> options)
        : base(options)
    {
    }

    // DbSet for Customer entities
    public DbSet<Customer> Customers { get; set; } = null!;
}

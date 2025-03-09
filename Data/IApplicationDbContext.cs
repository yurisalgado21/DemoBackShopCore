using DemoBackShopCore.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoBackShopCore.Context
{
    public interface IApplicationDbContext
    {
        DbSet<Customer> Customers { get; set; }
        public int SaveChanges();
    }
}
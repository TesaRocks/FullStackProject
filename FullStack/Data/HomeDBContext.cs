using FullStack.Models;
using Microsoft.EntityFrameworkCore;

namespace FullStack.Data
{
    public class HomeDBContext : DbContext
    {
        public HomeDBContext(DbContextOptions<HomeDBContext> options) : base(options) { }
        public DbSet<Home> Homes { get; set; }
    }
}

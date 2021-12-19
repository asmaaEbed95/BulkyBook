using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data
{
    public class ApplicaitonDbContext : DbContext
    {
        public ApplicaitonDbContext(DbContextOptions<ApplicaitonDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}

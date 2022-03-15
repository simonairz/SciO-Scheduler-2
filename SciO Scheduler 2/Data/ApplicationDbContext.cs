using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SciO_Scheduler_2.Models;

namespace SciO_Scheduler_2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SciO_Scheduler_2.Models.Gantt> Gantt { get; set; }
    }
}
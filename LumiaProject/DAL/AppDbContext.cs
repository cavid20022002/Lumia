using LumiaProject.Models;
using Microsoft.EntityFrameworkCore;

namespace LumiaProject.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }

        public DbSet<Team>Teams { get; set; }
        public DbSet<Profession> Professions { get; set; }


    }
}

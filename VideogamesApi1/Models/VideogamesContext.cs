using Microsoft.EntityFrameworkCore;

namespace VideogamesApi1.Models
{
    public class VideogamesContext : DbContext
    {
        public VideogamesContext(DbContextOptions<VideogamesContext> options)
            : base(options)
        {

        }

        public DbSet<Videogame> Videogame { get; set; } = null!;
    }
}
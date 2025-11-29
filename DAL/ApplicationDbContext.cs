using API.M.Movies.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace API.M.Movies.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Movie> Movies { get; set; }


    }
}

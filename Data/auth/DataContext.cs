using Microsoft.EntityFrameworkCore;

namespace itsppisapi.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        public DbSet<PPM_GL_MST_USERS> PPM_GL_MST_USERS { get; set; }
        public DbSet<PPM_GL_MENU_MASTER> PPM_GL_MENU_MASTER { get; set; }
        //public DbSet<UserProfile> UserProfile { get; set; }
    }
}

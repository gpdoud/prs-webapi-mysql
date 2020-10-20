using Microsoft.EntityFrameworkCore;

namespace webapi {
    public class PrsDbContext : DbContext {

        public virtual DbSet<User> Users { get; set; }
        
        public PrsDbContext(DbContextOptions<PrsDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder) {

        }
    }
}
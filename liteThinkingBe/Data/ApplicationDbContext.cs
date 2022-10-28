using Microsoft.EntityFrameworkCore;

namespace liteThinkingBe.Data;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() { }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    
    public virtual DbSet<Company> Companies { get; set; }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Facebook.Models;

namespace Facebook.Data;


public class FacebookContext : DbContext
{
    public FacebookContext(DbContextOptions<FacebookContext> opt) : base (opt) {}

    public DbSet<User> users {get; set;}
    public DbSet<Post> posts {get; set;}
    public DbSet<UserLog> userLogs {get;set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<User>
        (
            e =>
            {
                e.Property(p => p.Username).HasColumnType("varchar(250)").IsRequired();

                e.HasIndex(p => p.Username);

                e.Property(p => p.Email).HasColumnType("varchar(100)").IsRequired();
                e.HasIndex(p => p.Email).IsUnique();

                e.Property(p => p.CreatedAt).HasDefaultValueSql("SYSUTCDATETIME()");

                e.HasKey(p => p.Id);
            }
        );
        modelBuilder.Entity<User>().ToTable(tb => tb.HasTrigger("trg_userLog"));

        modelBuilder.Entity<Post>
        (
            e =>
            {
                e.Property(p => p.Content).HasColumnType("varchar(500)").IsRequired();

                e.Property(p => p.CreatedAt).HasDefaultValueSql("SYSUTCDATETIME()");

                e.HasIndex(p => p.CreatedAt);


                e.HasKey(p => p.Id);


            }
        );

        modelBuilder.Entity<Post>
        (
            e =>
            {
                e.HasOne(u => u.User)
                .WithMany(u => u.Posts)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            }
        );

        modelBuilder.Entity<UserLog>
        (
            e =>
            {
                e.Property(p => p.Username).HasColumnType("varchar(250)").IsRequired();
                e.Property(u => u.Email).HasColumnType("varchar(100)").IsRequired();
                e.Property(u => u.CreatedAt).HasDefaultValueSql("SYSUTCDATETIME()");
                e.HasIndex(u => u.CreatedAt);
                e.Property(u => u.State).HasColumnType("varchar(100)").IsRequired();        
            }
        );

        modelBuilder.Entity<UserLog>().HasNoKey();
    }
}
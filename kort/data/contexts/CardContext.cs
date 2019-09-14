using kort.data.entities;
using kort.data.mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace kort.data.contexts
{
    public class CardContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        private ISqliteSettings SQLiteSettings { get; }
        public ILoggerFactory LoggerFactory { get; }

        public CardContext(DbContextOptions<CardContext> options, ISqliteSettings settings, ILoggerFactory loggerFactory) : base(options)
        {
            this.SQLiteSettings = settings;
            this.LoggerFactory = loggerFactory;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseLoggerFactory(this.LoggerFactory)
                    .UseSqlite(this.SQLiteSettings.ConnectionString,
                    c =>
                    {
                        c.CommandTimeout(this.SQLiteSettings.CommandTimeout);
                    });
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>()
                .Property(c => c.Id)
                .IsRequired(true);

            modelBuilder.Entity<Card>()
                .Property(c => c.Front)
                .HasConversion(
                    v => v.ToUnicode(),
                    v => v.ToCardSurface()
                )
                .IsUnicode(true)
                .IsRequired(true);

            modelBuilder.Entity<Card>()
                .Property(c => c.Back)
                .HasConversion(
                    v => v.ToUnicode(),
                    v => v.ToCardSurface()
                )
                .IsUnicode(true);
        }
    }
}
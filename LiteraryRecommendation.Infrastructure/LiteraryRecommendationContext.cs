using LiteraryRecommendation.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace LiteraryRecommendation.Infrastructure
{
    public class LiteraryRecommendationContext : DbContext
    {
        public LiteraryRecommendationContext(DbContextOptions<LiteraryRecommendationContext> options) : base(options){ }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<UserAuthorPreference> UserAuthorPreference { get; set; }
        public DbSet<UserGenrePreference> UserGenrePreference { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId);

            modelBuilder.Entity<Book>()
            .HasOne(b => b.Genre)
            .WithMany(g => g.Books)
            .HasForeignKey(b => b.GenreId);


            modelBuilder.Entity<UserGenrePreference>()
                .HasKey(ugp => ugp.Id);

            modelBuilder.Entity<UserGenrePreference>()
                .HasOne(ugp => ugp.Genre)
                .WithMany()
                .HasForeignKey(uap => uap.UserId)
                .HasForeignKey(ugp => ugp.GenreId);

            modelBuilder.Entity<UserAuthorPreference>()
                .HasKey(uap => uap.Id);

            modelBuilder.Entity<UserAuthorPreference>()
                .HasOne(uap => uap.Author)
                .WithMany() 
                .HasForeignKey(uap => uap.UserId)
                .HasForeignKey(uap => uap.AuthorId);

        }
    }
}

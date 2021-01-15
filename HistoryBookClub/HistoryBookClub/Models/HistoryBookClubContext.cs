using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistoryBookClub.Models
{
    public class HistoryBookClubContext : DbContext
    {
        public HistoryBookClubContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId = 1,
                    Title = "Practicing History",
                    Author = "Barbara Tuchman",
                    YearOfPublication = 1981
                },
                new Book
                {
                    BookId = 2,
                    Title = "Our Oriental Heritage",
                    Author = "Will Durant",
                    YearOfPublication = 1935
                }
            );

            modelBuilder.Entity<Topic>().HasData(
                new Topic
                {
                    TopicId = 1,
                    BookId = 1,
                    Title = "Favourite Quotes",
                    DateCreated = new DateTime(2021, 01, 15)
                },
                new Topic
                {
                    TopicId = 2,
                    BookId = 2,
                    Title = "Favourite Quotes",
                    DateCreated = new DateTime(2021, 01, 15)
                }
            );
        }
    }
}

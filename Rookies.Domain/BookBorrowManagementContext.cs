using Microsoft.EntityFrameworkCore;
using Rookies.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookies.Domain
{
    public class BookBorrowManagementContext : DbContext
    {
        public BookBorrowManagementContext(DbContextOptions<BookBorrowManagementContext> options): base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<BookBorrowingRequest> BookBorrowingRequests { get; set; }
        public DbSet<BookBorrowingRequestDetail> BookBorrowingRequestDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Book>()
                .HasOne<Category>(s => s.Category)
                .WithMany(g => g.Books)
                .HasForeignKey(s => s.CategoryId);


            modelBuilder.Entity<Book>()
                .HasOne<Category>(s => s.Category)
                .WithMany(g => g.Books)
                .HasForeignKey(s => s.CategoryId);

        }

    }
}

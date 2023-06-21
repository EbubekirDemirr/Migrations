using DataAccess.FluentAPİConfiguration;
using Microsoft.EntityFrameworkCore;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class MigrationDbContext : DbContext
    {
        public MigrationDbContext(DbContextOptions<MigrationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<FluentAPİ_Book> FluentAPİ_Books {get; set;}
        public DbSet<FluentAPİ_BookType> FluentAPİ_BookTypes {get; set;}
        public DbSet<FluentAPİ_Category> FluentAPİ_Categories {get; set;}
        public DbSet<FluentAPİ_Publisher> FluentAPİ_Publishers{ get; set; }
        public DbSet<FluentAPİ_Writer> FluentAPİ_Writers{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FluentAPİ_Book>().HasKey(b => b.BookId);
            modelBuilder.Entity<FluentAPİ_BookType>().HasKey(bo => bo.BookTypeId);
            modelBuilder.Entity<FluentAPİ_Category>().HasKey(c=>c.CategoryId);
            modelBuilder.Entity<FluentAPİ_Publisher>().HasKey(p => p.PublisherId);
            modelBuilder.Entity<FluentAPİ_Writer>().HasKey(w => w.WriterId);

            modelBuilder.ApplyConfiguration(new FluentAPİ_BookConfiguration());

            modelBuilder.ApplyConfiguration(new FluentAPİ_BookTypeConfiguration());

            modelBuilder.ApplyConfiguration(new FluentAPİ_WriterAndBookConfiguration());


            
        }
    }
}

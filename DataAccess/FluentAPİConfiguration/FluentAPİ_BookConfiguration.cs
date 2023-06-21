using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.FluentAPİConfiguration
{
    public class FluentAPİ_BookConfiguration : IEntityTypeConfiguration<FluentAPİ_Book>
    {
        public void Configure(EntityTypeBuilder<FluentAPİ_Book> modelBuilder)
        {
            //One to Many Relation

            modelBuilder.HasOne(p => p.FluentAPİ_Publisher)
                .WithMany(b => b.FluentAPİ_Book).HasForeignKey(p => p.PublisherId);


            modelBuilder.HasOne(bo => bo.FluentAPİ_BookType)
                .WithOne(b => b.FluentAPİ_Book).HasForeignKey<FluentAPİ_Book>("Description");
        }
    }
}

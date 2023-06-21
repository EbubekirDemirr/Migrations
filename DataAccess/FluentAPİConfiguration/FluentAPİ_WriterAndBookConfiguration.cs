using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.FluentAPİConfiguration
{
    public class FluentAPİ_WriterAndBookConfiguration: IEntityTypeConfiguration<FluentAPİ_WriterAndBook>
    {
        public void Configure(EntityTypeBuilder<FluentAPİ_WriterAndBook> modelBuilder)
        {
            //Many to Many Relation

            modelBuilder.HasKey(wb => new { wb.BookId, wb.WriterId });

            modelBuilder.HasOne(b => b.FluentAPİ_Book)
                .WithMany(wb => wb.FluentAPİ_WriterAndBooks).HasForeignKey(b => b.BookId);

            modelBuilder.HasOne(w => w.FluentAPİ_Writer)
                .WithMany(wb => wb.FluentAPİ_WriterAndBooks).HasForeignKey(w => w.WriterId);
        }
    }
}

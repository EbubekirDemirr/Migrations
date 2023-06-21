using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.FluentAPİConfiguration
{
    public class FluentAPİ_BookTypeConfiguration: IEntityTypeConfiguration<FluentAPİ_BookType>
    {
        public void Configure(EntityTypeBuilder<FluentAPİ_BookType> modelBuilder)
        {
            modelBuilder.Property(bo => bo.Name).HasColumnName("TypeName");
        }
    }
}

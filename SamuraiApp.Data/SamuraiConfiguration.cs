using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SamuraiApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiApp.Data
{
    public class SamuraiConfiguration : IEntityTypeConfiguration<Samurai>
    {
        public void Configure(EntityTypeBuilder<Samurai> builder)
        {
            builder.HasData(SeedData.SeedSamurai());            
        }
    }
}

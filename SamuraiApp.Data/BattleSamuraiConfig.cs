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
    public class BattleSamuraiConfig : IEntityTypeConfiguration<BattleSamurai>
    {
        public void Configure(EntityTypeBuilder<BattleSamurai> builder)
        {
            builder.HasData(SeedData.SeedBattleSamurai());
        }


    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAM.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BAM.INFRASTRUCTURE.DATA.Configs
{
    public class MarcaConfig : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            builder.ToTable("tblMarca");
            builder.HasKey(c => c.MarcaId);

            //builder.HasMany(p => p.Vehiculo).WithOne();
        }
    }
}

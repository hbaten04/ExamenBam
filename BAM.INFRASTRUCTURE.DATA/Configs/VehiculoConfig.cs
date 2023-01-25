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
    public class VehiculoConfig : IEntityTypeConfiguration<Vehiculo>
    {
        public void Configure(EntityTypeBuilder<Vehiculo> builder)
        {
            builder.ToTable("tblVehiculo");
            builder.HasKey(c => c.VehiculoId);

            /*builder.HasOne(p => p.Marca).WithMany(b => b.Vehiculo).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(p => p.TipoVehiculo).WithMany(b => b.Vehiculo).OnDelete(DeleteBehavior.Cascade);*/


        }
    }
}

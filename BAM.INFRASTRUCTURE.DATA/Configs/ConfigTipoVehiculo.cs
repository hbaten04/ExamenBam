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
    public class ConfigTipoVehiculo : IEntityTypeConfiguration<TipoVehiculo>
    {
        public void Configure(EntityTypeBuilder<TipoVehiculo> builder)
        {
            builder.ToTable("tblTipoVehiculo");
            builder.HasKey(c => c.TipoVehiculoId);

           // builder.HasMany(p => p.Vehiculo).WithOne();
        }
    }
}

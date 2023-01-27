using BAM.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAM.INFRASTRUCTURE.DATA.Configs
{
    public class ConfigCotizacion : IEntityTypeConfiguration<Cotizacion>
    {
        public void Configure(EntityTypeBuilder<Cotizacion> builder)
        {
            builder.ToTable("tblCotizacion");
            builder.HasKey(x => x.CotizacionId);
        }
    }
}

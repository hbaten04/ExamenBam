using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BAM.DOMAIN.Models;
using System.Security.Principal;
using BAM.INFRASTRUCTURE.DATA.Configs;

namespace BAM.INFRASTRUCTURE.DATA.Contexts
{
    public class BAMContext : DbContext
    {

        public BAMContext()
        {

        }

        public BAMContext(DbContextOptions<BAMContext> options) : base(options)
        {

        }
        public DbSet<Vehiculo> vehiculo { get; set; }
        public DbSet<Marca> marca { get; set; }
        public DbSet<TipoVehiculo> tipoVehiculo { get; set; }
        public DbSet<Cotizacion> cotizacion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseSqlServer("Server=colegiodb.database.windows.net;Database=ExamenBD;User Id=admindba;Password=Colegio.12345;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new VehiculoConfig());
            builder.ApplyConfiguration(new MarcaConfig());
            builder.ApplyConfiguration(new ConfigTipoVehiculo());
            builder.ApplyConfiguration(new ConfigCotizacion());
        }
    }
}

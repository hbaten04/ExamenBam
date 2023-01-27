using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAM.DOMAIN.Models
{
    public class Cotizacion
    {
        public Guid CotizacionId { get; set; }
        public string EmailCliente { get; set; }
        public int Plazo { get; set; }
        public decimal Enganche { get; set; }
        public decimal CuotaPago { get; set; }
        public Guid VehiculoId { get; set; }
        public virtual ICollection<Vehiculo>? Vehiculos { get; }

    }
}

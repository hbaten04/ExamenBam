using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAM.DOMAIN.Models
{
    public class Vehiculo
    {
        public Vehiculo()
        {
            Cotizaciones = new HashSet<Cotizacion>();
        }

        public Guid VehiculoId { get; set; }
        public string Motor { get; set; }
        public string Kilometraje { get; set; }
        public string Puertas { get; set; }
        public string NombreVehiculo { get; set; }
        public decimal PrecioVehiculo { get; set; }
        public string Placa { get; set; }
        public string Descripcion { get; set; }

        public Guid MarcaId { get; set; }
        public virtual Marca Marca { get; set; } = null;
        public Guid TipoVehiculoId { get; set; }
        public virtual TipoVehiculo TipoVehiculo { get; set; } = null;
        public virtual ICollection<Cotizacion>? Cotizaciones { get; set; }

    }
}

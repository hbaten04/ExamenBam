
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAM.DOMAIN.Models
{
    public class TipoVehiculo
    {
        public TipoVehiculo()
        {
            Vehiculos = new HashSet<Vehiculo>();
        }
        public Guid TipoVehiculoId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}

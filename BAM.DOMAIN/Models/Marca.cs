using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAM.DOMAIN.Models
{
    public class Marca
    {
        public Marca()
        {
            Vehiculos = new HashSet<Vehiculo>();
        }
        public Guid MarcaId { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Vehiculo>? Vehiculos { get; set; }
    }
}

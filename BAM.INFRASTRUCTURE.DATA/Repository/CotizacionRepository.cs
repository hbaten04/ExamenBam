using BAM.DOMAIN.Interfaces.Repository;
using BAM.DOMAIN.Models;
using BAM.INFRASTRUCTURE.DATA.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAM.INFRASTRUCTURE.DATA.Repository
{
    public class CotizacionRepository : IRepository<Cotizacion, Guid>
    {
        private BAMContext _db;
        public CotizacionRepository(BAMContext db)
        {
            _db = db;

        }
        public Cotizacion Add(Cotizacion entity)
        {
            entity.CotizacionId = Guid.NewGuid();
            _db.cotizacion.Add(entity);

            return entity;
        }

        public void Delete(Guid entityID)
        {
            throw new NotImplementedException();
        }

        public List<Cotizacion> Get()
        {
            throw new NotImplementedException();
        }

        public Cotizacion GetById(Guid entityID)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Cotizacion entity)
        {
            throw new NotImplementedException();
        }
    }
}

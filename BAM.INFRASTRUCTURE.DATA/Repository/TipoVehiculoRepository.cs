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
    public class TipoVehiculoRepository:IRepository<TipoVehiculo, Guid>
    {
        private BAMContext _db;

        public TipoVehiculoRepository(BAMContext db)
        {
            _db = db;
        }

        public TipoVehiculo Add(TipoVehiculo entity)
        {
            entity.TipoVehiculoId = Guid.NewGuid();
            _db.tipoVehiculo.Add(entity);

            return entity;
        }

        public void Delete(Guid entityID)
        {
            throw new NotImplementedException();
        }

        public List<TipoVehiculo> Get()
        {
            return _db.tipoVehiculo.ToList();
        }

        public TipoVehiculo GetById(Guid entityID)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(TipoVehiculo entity)
        {
            throw new NotImplementedException();
        }
    }
}

using BAM.DOMAIN.Interfaces.Repository;
using BAM.DOMAIN.Models;
using BAM.INFRASTRUCTURE.DATA.Contexts;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace BAM.INFRASTRUCTURE.DATA.Repository
{
    public class BamRepository : IRepository<Vehiculo, Guid>
    {
        private BAMContext _db;


        public BamRepository(BAMContext db)
        {
            _db = db;
        }

        public Vehiculo Add(Vehiculo entity)
        {
            entity.VehiculoId = Guid.NewGuid();
            entity.TipoVehiculo = null;
            entity.Marca = null;
            _db.vehiculo.Add(entity);

            return entity;

        }

        public void Delete(Guid entityID)
        {
            var vVehiculo = _db.vehiculo.Where(x => x.VehiculoId == entityID).FirstOrDefault();

            if (vVehiculo != null)
            {
                _db.vehiculo.Remove(vVehiculo);
            }
        }

        public List<Vehiculo> Get()
        {

            return _db.vehiculo.ToList();
        }

        public Vehiculo GetById(Guid entityID)
        {
            return _db.vehiculo.Find(entityID);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Vehiculo entity)
        {
            var vVehiculo = _db.vehiculo.Where(x => x.VehiculoId == entity.VehiculoId).FirstOrDefault();
            entity.TipoVehiculo = null;
            entity.Marca = null;

            if (vVehiculo != null)
            {
                vVehiculo.Motor = entity.Motor;
                vVehiculo.Kilometraje = entity.Kilometraje;
                vVehiculo.NombreVehiculo = entity.NombreVehiculo;
                vVehiculo.PrecioVehiculo = entity.PrecioVehiculo;
                vVehiculo.Placa = entity.Placa;
                vVehiculo.Descripcion = entity.Descripcion;
                vVehiculo.MarcaId = entity.MarcaId;
                vVehiculo.TipoVehiculoId = entity.TipoVehiculoId;

                _db.Entry(vVehiculo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }

        }
    }
}

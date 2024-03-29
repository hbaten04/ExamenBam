﻿using BAM.DOMAIN.Interfaces.Repository;
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
            throw new NotImplementedException();
        }

        public List<Vehiculo> Get()
        {
           
            return _db.vehiculo.ToList();
        }

        public Vehiculo GetById(Guid entityID)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Vehiculo entity)
        {
            var vVehiculo = _db.vehiculo.Where(x => x.VehiculoId == entity.VehiculoId).FirstOrDefault();

            if (vVehiculo != null)
            {
                vVehiculo.Motor = entity.Motor;
                vVehiculo.Kilometraje = entity.Kilometraje;
                vVehiculo.NombreVehiculo = entity.NombreVehiculo;
                vVehiculo.PrecioVehiculo = entity.PrecioVehiculo;
                vVehiculo.Placa = entity.Placa;

                _db.Entry(vVehiculo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAM.DOMAIN;
using BAM.DOMAIN.Models;
using BAM.APLICATION.Interface;
using BAM.DOMAIN.Interfaces.Repository;

namespace BAM.APLICATION.Services
{
    public class VehiculoService : IServiceBam<Vehiculo, Guid>
    {

        private readonly IRepository<Vehiculo, Guid> _repository;

        public VehiculoService(IRepository<Vehiculo, Guid> repository)
        {
            _repository = repository;
        }

        public Vehiculo Add(Vehiculo entity)
        {
            if (entity == null)
                throw new ArgumentNullException("El vehiculo es requerido");

            var vResult = _repository.Add(entity);
            _repository.Save();
            return vResult;
        }

        public void Delete(Guid entityID)
        {
            _repository.Delete(entityID);
            _repository.Save();
        }

        public List<Vehiculo> Get()
        {
            return _repository.Get();
        }

        public Vehiculo GetById(Guid entityID)
        {
            return _repository.GetById(entityID);
        }

        public void Update(Vehiculo entity)
        {
            if (entity == null)
                throw new ArgumentNullException("El vehiculo es requerido");

            _repository.Update(entity);
            _repository.Save();
            
        }
    }
}

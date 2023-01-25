using BAM.APLICATION.Interface;
using BAM.DOMAIN.Interfaces.Repository;
using BAM.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAM.APLICATION.Services
{
    public class TipoVehiculoService : IServiceBam<TipoVehiculo, Guid>
    {
        private readonly IRepository<TipoVehiculo, Guid> _repository;
        public TipoVehiculoService(IRepository<TipoVehiculo, Guid> repository)
        {
            _repository = repository;
        }

        public TipoVehiculo Add(TipoVehiculo entity)
        {
            if (entity == null)
                throw new ArgumentNullException("El tipo de vehiculo es requerido");

            var vResult = _repository.Add(entity);
            _repository.Save();
            return vResult;
        }

        public void Delete(Guid entityID)
        {
            throw new NotImplementedException();
        }

        public List<TipoVehiculo> Get()
        {
            return _repository.Get();
        }

        public TipoVehiculo GetById(Guid entityID)
        {
            return _repository.GetById(entityID);
        }

        public void Update(TipoVehiculo entity)
        {
            throw new NotImplementedException();
        }
    }
}

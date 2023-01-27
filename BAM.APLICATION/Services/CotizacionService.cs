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
 
    public class CotizacionService:IServiceBam<Cotizacion, Guid>
    {
        private readonly IRepository<Cotizacion, Guid> _repository;
        public CotizacionService(IRepository<Cotizacion, Guid> repository)
        {
            _repository = repository;
        }

        public Cotizacion Add(Cotizacion entity)
        {
            var vResult = _repository.Add(entity);
            _repository.Save();
            return vResult;
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

        public void Update(Cotizacion entity)
        {
            throw new NotImplementedException();
        }
    }
}

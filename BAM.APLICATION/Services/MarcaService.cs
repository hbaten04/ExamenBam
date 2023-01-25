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
    public class MarcaService : IServiceBam<Marca, Guid>
    {
        private readonly IRepository<Marca, Guid> _repository;
        public MarcaService(IRepository<Marca, Guid> repository)
        {
            _repository = repository;
        }
        public Marca Add(Marca entity)
        {
            if (entity == null)
                throw new ArgumentNullException("La marca es requerida");

            var vResult = _repository.Add(entity);
            _repository.Save();
            return vResult;
        }

        public void Delete(Guid entityID)
        {
            throw new NotImplementedException();
        }

        public List<Marca> Get()
        {
            return _repository.Get();
        }

        public Marca GetById(Guid entityID)
        {
            return _repository.GetById(entityID);
        }

        public void Update(Marca entity)
        {
            throw new NotImplementedException();
        }
    }
}

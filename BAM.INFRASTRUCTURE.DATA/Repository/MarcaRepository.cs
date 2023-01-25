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
    public class MarcaRepository : IRepository<Marca, Guid>
    {
        private BAMContext _db;

        public MarcaRepository(BAMContext db)
        {
            _db = db;
        }
        public Marca Add(Marca entity)
        {
            entity.MarcaId = Guid.NewGuid();
            _db.marca.Add(entity);

            return entity;
        }

        public void Delete(Guid entityID)
        {
            throw new NotImplementedException();
        }

        public List<Marca> Get()
        {
            return _db.marca.ToList();
        }

        public Marca GetById(Guid entityID)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Marca entity)
        {
            throw new NotImplementedException();
        }
    }
}

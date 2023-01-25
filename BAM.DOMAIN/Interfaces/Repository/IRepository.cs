using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAM.DOMAIN.Interfaces;

namespace BAM.DOMAIN.Interfaces.Repository
{
    public interface IRepository<TEntity, TEntityID> : IAdd<TEntity>, IUpdate<TEntity>, IDelete<TEntityID>, IGet<TEntity, TEntityID>, ITransactions
    {
    }
}

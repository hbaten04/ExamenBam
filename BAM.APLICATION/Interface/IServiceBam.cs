using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAM.DOMAIN.Interfaces;
using BAM.DOMAIN.Interfaces.Repository;

namespace BAM.APLICATION.Interface
{
    public interface IServiceBam<TEntity, TEntityID> : IAdd<TEntity>, IUpdate<TEntity>, IDelete<TEntityID>, IGet<TEntity, TEntityID>
    {

    }
}

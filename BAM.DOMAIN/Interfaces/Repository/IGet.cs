using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAM.DOMAIN.Interfaces.Repository
{
    public interface IGet<TEntity, TEntityID>
    {
        List<TEntity> Get();

        TEntity GetById(TEntityID entityID);
    }
}

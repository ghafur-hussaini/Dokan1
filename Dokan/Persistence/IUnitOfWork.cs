using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dokan.Persistence
{
   public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dokan.Persistence
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly DokanDbContext context;

        public UnitOfWork(DokanDbContext context)
        {
            this.context = context;
        }

        public async Task CompleteAsync()
        {
           await context.SaveChangesAsync();
        }

    }
}

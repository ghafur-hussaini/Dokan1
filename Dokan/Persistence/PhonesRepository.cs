using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dokan.Models;
using Microsoft.EntityFrameworkCore;

namespace Dokan.Persistence
{
    public class PhonesRepository:IPhonesRepository
    {
        private readonly DokanDbContext context;

        public PhonesRepository(DokanDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Phone>> Get(int? id)
        {
            var phones = this.context.Phones.AsQueryable();
            if(id.HasValue)
            phones = phones.Where(p => p.customerID == id);
            return await phones.ToListAsync();
                
        }
    }
}

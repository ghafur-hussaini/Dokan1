using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dokan.Models;
using Microsoft.EntityFrameworkCore;

namespace Dokan.Persistence
{
    public class BillRepository:IBillRepository

    {
        private readonly DokanDbContext context;

        public BillRepository(DokanDbContext context)
        {
            this.context = context;
        }
         public async Task<IEnumerable<Bill>> GetBills()
        {
            return await context.Sales.ToListAsync();
        }
        public void Add(Bill record)
        {
            context.Sales.Add(record);
           
        }
    }
}

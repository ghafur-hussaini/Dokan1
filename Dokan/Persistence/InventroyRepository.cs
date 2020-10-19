using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dokan.Models;
using Microsoft.EntityFrameworkCore;

namespace Dokan.Persistence
{
    public class InventroyRepository:IInventoryRepository
    {
        private readonly DokanDbContext context;

        public InventroyRepository(DokanDbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Inventory>> GetInventory()
        {
          var inventories= await context.inventories.ToListAsync();
            return inventories;
           
        }
    }
}

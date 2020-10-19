using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dokan.Models;

namespace Dokan.Persistence
{
   public interface IBillRepository
    {
        Task<IEnumerable<Bill>> GetBills();
        void Add(Bill record);
    }
}

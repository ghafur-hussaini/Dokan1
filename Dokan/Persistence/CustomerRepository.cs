using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dokan.Models;
using Microsoft.EntityFrameworkCore;

namespace Dokan.Persistence
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly DokanDbContext context;

        public CustomerRepository(DokanDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<MeToYouCustomer>> GetCustomers()
            {
           var customers = await context.Customers.ToListAsync();
            return customers;
            }
       
    }
}

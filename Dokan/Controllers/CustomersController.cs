using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dokan.Models;
using Dokan.Persistence;
using Dokan.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Dokan.Controllers
{
    [Route("/api/customer")]
    public class CustomersController:Controller
    {
        private readonly ICustomerRepository customerRepository;
        private readonly DokanDbContext context;
        private readonly IMapper mapper;

        public CustomersController(ICustomerRepository customerRepository,DokanDbContext context,IMapper mapper)
        {
            this.customerRepository = customerRepository;
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]

        public async Task<IEnumerable<MeToYouCustomer>> GetCustomer()
        {
            var customers = await this.customerRepository.GetCustomers();
            return customers;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer(int id,[FromBody]CustomerResource customer)
        {
            var Customer = await this.context.Customers.FindAsync(id);
           // Customer.Balance = newBalance;
             mapper.Map<CustomerResource, MeToYouCustomer>(customer, Customer);
            await this.context.SaveChangesAsync();
            //var result = mapper.Map<MeToYouCustomer, CustomerResource>(Customer);
            return Ok(Customer);
        }

      
    }
}

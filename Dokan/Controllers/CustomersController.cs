using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dokan.Models;
using Dokan.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace Dokan.Controllers
{
    [Route("/api/Customer")]
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
        //[HttpPut]
        //public async Task<IActionResult> UpdateCustomer(int id, [FromBody] MeToYouCustomer customer)
        //{
        //    var Customer = this.context.Customers.FindAsync(id);
        //   this.mapper.Map<>



        //}
    }
}

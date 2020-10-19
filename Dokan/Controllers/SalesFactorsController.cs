using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dokan.Models;
using Dokan.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace Dokan.Controllers
{
   [Route("/api/salefactor")]
    public class SalesFactorsController:Controller
    {
        private readonly ISalesFactorRepository repository;
        private readonly IUnitOfWork unitOfWork;
        private readonly DokanDbContext context;

        public SalesFactorsController(ISalesFactorRepository repository,IUnitOfWork unitOfWork,DokanDbContext context)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
            this.context = context;
        }
         
        [HttpPost]

        public async Task<IActionResult> CreateFactor([FromBody] Factor factor)
        {
            this.context.Add(factor);
            await context.SaveChangesAsync();
            return Ok(factor);
        }
    }
}

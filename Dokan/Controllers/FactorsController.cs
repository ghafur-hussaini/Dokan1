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
    [Route("/api/salefactor")]
    public class FactorsController : Controller
    {
        private readonly ISalesFactorRepository repository;
        private readonly IUnitOfWork unitOfWork;
        private readonly DokanDbContext context;
        private readonly IMapper mapper;

        public FactorsController(ISalesFactorRepository repository, IUnitOfWork unitOfWork, DokanDbContext context, IMapper mapper)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]

        public async Task<IActionResult> CreateFactor([FromBody] Factor factor)
        {
            this.context.Add(factor);
            await context.SaveChangesAsync();
            return Ok(factor);
        }
        [HttpPut("{id}")]

        public async Task<IActionResult> UpdateFactor(int id,[FromBody] FactorResource completeFactor)
        {
            var factor = await this.context.Factors.FindAsync(id);
            mapper.Map<FactorResource, Factor>(completeFactor, factor);
             await this.context.SaveChangesAsync();
            var result = mapper.Map<Factor, FactorResource>(factor);
            return Ok(result);
        }
        [HttpGet("{id}")]
         
        public async Task<FactorResource> GetFactor(int id)
        {
            var factor = await this.context.Factors.FindAsync(id);
          var result=  mapper.Map<Factor, FactorResource>(factor);
            return result;
        }

    }
}
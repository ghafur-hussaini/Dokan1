using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dokan.Models;
using Dokan.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dokan.Controllers
{
    [Route("/api/metoyou")]
    public class MeToYouController:Controller
    {
        
        private readonly IUnitOfWork unitOfWork;
        private readonly DokanDbContext context;

        public MeToYouController(IUnitOfWork unitOfWork,DokanDbContext context)
        {
           
            this.unitOfWork = unitOfWork;
            this.context = context;
        }
        [HttpPost]

        public async Task<IActionResult> AddRecord([FromBody]MeToYouSales newRecord)
        {
            //newRecord.date = "2020-10-09 17:11:23";

            this.context.MeToYouSales.Add(newRecord);
           await context.SaveChangesAsync();
            return Ok(newRecord);
        }
        [HttpGet]
        public async Task<IEnumerable<MeToYouSales>> GetMetoYouSales()
        {
          return await  this.context.MeToYouSales.ToListAsync();

        }
    }
}

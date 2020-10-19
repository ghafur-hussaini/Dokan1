using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dokan.Models;
using Dokan.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace Dokan.Controllers
{
    [Route("/api/mydates")]
    public class MyDatesController:Controller
    {
        private readonly DokanDbContext context;

        public MyDatesController(DokanDbContext context )
        {
            this.context = context;
        }
        [HttpPost]
        public async Task<IActionResult> AddMyDates([FromBody] Time time)
        {
            this.context.MyTimes.Add(time);
            await this.context.SaveChangesAsync();
            return Ok(time);
        }
    }
}

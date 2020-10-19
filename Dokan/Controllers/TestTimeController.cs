using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dokan.Models;
using Dokan.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace Dokan.Controllers
{
    [Route("/api/time")]
    public class TestTimeController:Controller
    {
        private readonly DokanDbContext context;

        public TestTimeController(DokanDbContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> CreateTimeRecord([FromBody] TestTime testTime)
        {
            var result=  this.context.Dates.Add(testTime);
           await this.context.SaveChangesAsync();
            return Ok(testTime);
        }
    }
}

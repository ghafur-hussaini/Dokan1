using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dokan.Models;
using Dokan.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace Dokan.Controllers
{
    [Route("/api/Incomings")]
    public class ReceivedMeToYouController:Controller
    {
        private readonly DokanDbContext context;

        public ReceivedMeToYouController(DokanDbContext context)
        {
            this.context = context;
        }
        [HttpPost]
        
        public async Task<IActionResult> AddIncomingRecords([FromBody]RecivedMeToYou newRecord)
        {
           await this.context.Incomings.AddAsync(newRecord);
            await this.context.SaveChangesAsync();
            return Ok(newRecord);
        }

    }
}

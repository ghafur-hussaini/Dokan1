using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dokan.Models;
using Dokan.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace Dokan.Controllers
{
    [Route("/api/test")]
    public class TestsController:Controller
    {
        private readonly DokanDbContext context;

        public TestsController(DokanDbContext context)
        {
            this.context = context;
        }
       
    }
}

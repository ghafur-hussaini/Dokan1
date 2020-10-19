using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dokan.Models;
using Dokan.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace Dokan.Controllers
{
    [Route("/api/phone")]
    public class PhonesController : Controller
    {
        private readonly IPhonesRepository repository;

        public PhonesController(IPhonesRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet("{id}")]

        public async Task<IEnumerable<Phone>> GetPhones(int? id)
        {
            return await this.repository.Get(id);

        }
    }
}

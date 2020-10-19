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
    [Route("/api/inventory")]
    public class InventoriesController : Controller
    {
        private readonly IInventoryRepository repository;
        private readonly IMapper mapper;

        public InventoriesController(IInventoryRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IEnumerable<Inventory>> GetInventories()
        {
            var inventories = await this.repository.GetInventory();
            return inventories;
        }
       

        //public async Task<IActionResult> AddBillRecord([FromBody] InventoryResource newStuff)
        //{
        //    mapper.Map<InventoryResource, Inventory>();

        //}


    } 
}

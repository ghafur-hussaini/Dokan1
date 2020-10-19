using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dokan.Models;
using Dokan.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace Dokan.Controllers
{
    [Route("/api/sales")]
    public class SalesController:Controller
    {
        private readonly IBillRepository billRepository;
        private readonly IUnitOfWork unitOfWork;

        public SalesController(IBillRepository billRepository,IUnitOfWork unitOfWork)
        {
            this.billRepository = billRepository;
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IEnumerable<Bill>> GetSales()
        {
            return await billRepository.GetBills();
        }
        [HttpPost]
        
        public async Task<IActionResult> AddBillRecord([FromBody] Bill bill)
        {
            billRepository.Add(bill);
            await  unitOfWork.CompleteAsync();
            return Ok(bill);
            
        }

    }
}

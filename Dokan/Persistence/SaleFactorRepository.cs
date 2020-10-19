using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dokan.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dokan.Persistence
{
    public class SaleFactorRepository:ISalesFactorRepository
    {
        private readonly DokanDbContext context;

        public SaleFactorRepository(DokanDbContext context)
        {
            this.context = context;
        }

        public void Add( Factor factor)
        {
            context.SalesFactors.Add(factor);
            
        }
    }
}

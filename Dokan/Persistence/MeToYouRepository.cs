using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dokan.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dokan.Persistence
{
    public class MeToYouRepository:IMeToYouRepository
    {
        private readonly DokanDbContext context;

        public MeToYouRepository(DokanDbContext context)
        {
            this.context = context;
        }

        public void Add(MeToYouSales newRecord)
        {
            this.context.MeToYouSales.Add(newRecord);
            
        }
    }
}

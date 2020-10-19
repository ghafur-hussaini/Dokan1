using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dokan.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dokan.Persistence
{
   public interface ISalesFactorRepository
    {
        void Add(Factor factor);
    }
}

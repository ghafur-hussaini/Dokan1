using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dokan.Models;

namespace Dokan.Persistence
{
  public  interface IMeToYouRepository
    {
        public void Add(MeToYouSales newRecord);
    }
}

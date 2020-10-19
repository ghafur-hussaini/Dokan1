using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dokan.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public string StuffName { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
    }
}

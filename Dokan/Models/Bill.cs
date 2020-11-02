using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dokan.Models
{
    public class Bill
    {
        [Key] 
        public int number { get; set; }
        public int FactorId { get; set; }
        public string StuffName { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
        public int Sum { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dokan.Models
{
    public class MeToYouSales
    {
        
        public int Id { get; set; }
        public string date { get; set; }
        public string CustomerName { get; set; }
        public int? PhoneNumber { get; set; }
        public int? Amounf { get; set; }
        public int? Cash { get; set; }
        public int? Balance { get; set; }
    }
}

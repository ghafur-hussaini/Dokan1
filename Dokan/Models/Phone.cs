using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dokan.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public int customerID { get; set; }
        public MeToYouCustomer customer { get; set; }
      
    }
}

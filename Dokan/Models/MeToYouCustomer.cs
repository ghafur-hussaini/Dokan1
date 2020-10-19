using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Dokan.Models
{
    public class MeToYouCustomer
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public int Balance { get; set; }
        public ICollection<Phone> Phones { get; set; }
        public MeToYouCustomer()
        {
            Phones = new Collection<Phone>();
        }

    
    }
}

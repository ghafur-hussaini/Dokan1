using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Dokan.Models;

namespace Dokan.Resources
{
    public class CustomerResource
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public int Balance { get; set; }
        public ICollection<Phone> Phones { get; set; }
        public CustomerResource()
        {
            Phones = new Collection<Phone>();
        }

    }
}


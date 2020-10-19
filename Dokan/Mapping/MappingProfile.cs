using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dokan.Models;
using Dokan.Persistence;
using Dokan.Resources;
using Microsoft.EntityFrameworkCore;

namespace Dokan.Mapping
{
    public class MappingProfile : Profile

    {
        public MappingProfile()
        {
            CreateMap<InventoryResource, Inventory>();
            CreateMap<CustomerResource, MeToYouCustomer>();
        }
    }
}
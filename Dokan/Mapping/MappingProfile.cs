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
            //Domain to ApiResource
            CreateMap<InventoryResource, Inventory>();
            CreateMap<MeToYouCustomer, CustomerResource>();
               
            CreateMap<FactorResource, Factor>()
                .ForMember(f => f.FactorId, opt => opt.Ignore());
            //ApiResource to Domain
            CreateMap<Factor, FactorResource>();
            CreateMap<CustomerResource, MeToYouCustomer>()
              // .ForMember(c => c.ID, opt => opt.Ignore())
               .ForMember(c => c.CustomerName, opt => opt.Ignore());

        }
    }
}
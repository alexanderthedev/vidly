using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            /*domain to dto*/
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<MembershipTypes, MembershipTypeDto>();

/* dto to domain */
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}
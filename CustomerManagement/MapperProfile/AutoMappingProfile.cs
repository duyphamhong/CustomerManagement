using AutoMapper;
using CustomerManagement.Models;
using CustomerManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.MapperProfile
{
    public class AutoMappingProfile : Profile
    {
        public AutoMappingProfile()
        {
            CreateMap<TeaOrder, TeaOrderViewModel>();
            CreateMap<TeaOrderViewModel, TeaOrder>();
        }
    }
}

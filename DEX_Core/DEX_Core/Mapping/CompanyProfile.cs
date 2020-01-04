using AutoMapper;
using DEX_Core_WebAPI.Models;
using DEX_Core_WebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEX_Core_WebAPI.Mapping
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            this.CreateMap<Company, CompanyViewModel>();
        }
    }
}

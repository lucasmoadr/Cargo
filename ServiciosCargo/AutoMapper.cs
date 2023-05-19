 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Dto;
using Domain.Entity;
namespace ServicesCargo
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Ship, ShipDto>();
            CreateMap<ShipDto, Ship>();
        }

     
    }
}

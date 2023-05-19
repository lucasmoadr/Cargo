using System;
using System.Collections.Generic;
using Domain.Dto;
using AutoMapper;
using Domain.Entity;

namespace ServicesCargo
{
    public class Services:IServices
    {
        private readonly AutoMapper conversor;
        public Services()
        {
            this.conversor = new AutoMapper();
        }
        public IList<ShipDto> ObtainShips()
        {
            try
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Ship, ShipDto>());
                var mapper = config.CreateMapper();
                // or
                
                

                IList<ShipDto> Ships = new List<ShipDto>();

                Ship ship = new Ship
                {
                    IdShip = 1,
                   NameShip =  "Vapor Prueba",
                YearOfCreation = DateTime.Now.AddDays(-13)
                };

                ShipDto dto = mapper.Map<ShipDto>(ship);
                 Ships.Add(dto);

                Ship ship2 = new Ship
                {
                    IdShip = 1,
                    NameShip = "Vapor Prueba",
                    YearOfCreation = DateTime.Now
                };
                ShipDto dto1 = mapper.Map<ShipDto>(ship2);
                Ships.Add(dto1);

                return Ships;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int SaveInformation(ShipDto ship)
        {
            try
            {
                return 1;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool DeleteShip(int IdShip)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool ModifyName(int IdShip, string Name)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        
    }
}

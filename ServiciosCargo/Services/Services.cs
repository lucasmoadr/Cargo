using System;
using System.Collections.Generic;
using Domain.Dto;
namespace ServicesCargo
{
    public class Services
    {
        public IList<ShipDto> ObtainShips()
        {
            try
            {
                IList<ShipDto> Ships = new List<ShipDto>();

                ShipDto ship = new ShipDto
                {
                    IdVapor = 1,
                    NombreVapor = "Vapor Prueba",
                    YearOfCreation = DateTime.Now.AddDays(-13)
                };

                Ships.Add(ship);

                ShipDto ship1 = new ShipDto
                {
                    IdVapor = 2,
                    NombreVapor = "Vapor Prueba2",
                    YearOfCreation = DateTime.Now
                };
                Ships.Add(ship);

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

        public bool ModifyName(string Name, int IdShip)
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

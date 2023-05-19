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

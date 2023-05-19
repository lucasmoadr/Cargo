using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Dto;

namespace ServicesCargo
{
    public interface IServices
    {

        IList<ShipDto> ObtainShips();

        int SaveInformation(ShipDto ship);

        bool DeleteShip(int IdShip);

        bool ModifyName(int IdShip, string Name);
    }
}

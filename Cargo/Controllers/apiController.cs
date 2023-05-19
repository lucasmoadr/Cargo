using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.Dto;
using ServicesCargo;

namespace Cargo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Consumes("application/json")]
    public class apiController : ControllerBase
    {
        private readonly IServices Service;
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public apiController(IServices Service)
        {
            this.Service = Service;
        }

        private readonly ILogger<apiController> _logger;

        [HttpGet]
        public IList<ShipDto> ObtainShips()
        {
            try
            {
                return Service.ObtainShips();
            }
            catch (Exception)
            {

                throw;
            }
           
           
        }

        [HttpPost]
        public int SaveInformation(ShipDto Ship)
        {
            try
            {
                return Service.SaveInformation(Ship);
            }
            catch (Exception)
            {

                throw;
            }


        }

        [HttpPost]
        public bool DeleteShip(int IdShip)
        {
            try
            {
                return Service.DeleteShip(IdShip);
            }
            catch (Exception)
            {

                throw;
            }


        }

        [HttpPost]
        public bool ModifyName(int IdShip, string Name )
        {
            try
            {
                return Service.ModifyName(IdShip, Name);
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}

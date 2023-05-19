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

        [Route("ObtainShips")]
        [HttpGet]
        public IList<ShipDto> Get()
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
        [Route("SaveInformation")]
        [HttpPost]
        public int Post(ShipDto Ship)
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
        [Route("DeleteShip")]
        [HttpPost]
        public bool Post(int IdShip)
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
        [Route("ModifyName")]
        [HttpPost]
        public bool Post(int IdShip, string Name)
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

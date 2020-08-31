using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using PruebaMasivian.Interfaces;
using PruebaMasivian.Models;
namespace PruebaMasivian.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BetController : ControllerBase
    {       
        public readonly IBetService _betService;
        public BetController(IBetService betService)
        {
            _betService = betService;
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        } 
        [HttpPost("MakeBet")]
        public ActionResult MakeBet([FromBody] Bet bet)
        {
            StringValues idUser;
            Request.Headers.TryGetValue("IdUser", out idUser);
            if (idUser != string.Empty)
                if (_betService.MakeBet(bet))

                    return Ok("se relizo la apuesta");
                else

                    return Ok("No se realizo la apuesta");
            else

                return Ok("el usuario no existe");
        }       
    }
}

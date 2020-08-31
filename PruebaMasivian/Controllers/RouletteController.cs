using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PruebaMasivian.Interfaces;
using PruebaMasivian.Models;
namespace PruebaMasivian.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouletteController : ControllerBase
    {
        public readonly IRouletteService _rouletteService;
        public readonly IBetService _betService;
        public  RouletteController(IRouletteService rouletteService, IBetService betService)
        {
            _rouletteService = rouletteService;
            _betService = betService;
        }     
        [HttpPost("CreateRoulette")]
        public ActionResult CreateRoulette()
        {
            Roulette rouletteinstance = _rouletteService.CreateRoullete();

            return Ok(rouletteinstance.Id);
        }
        [HttpPut("OpenRulette/{id}")]
        public ActionResult OpenRulette(int id)
        {
            if (_rouletteService.OpenRoulete(id))

                return Ok("Se realizo la operacion correctamente");
            else

                return Ok("No se pudo realizar la operacion");       
        }       
        [HttpPost("CloseRoulette/{id}")]
        public ActionResult CloseRoulette(int id)
        {
            _rouletteService.CloseRoulette(id);
          
            return Ok(_betService.GetBetsByRouletteId(id));
        }
        [HttpGet("GetListOfRoulettesWithState")]
        public List<Roulette> GetListOfRoulettesWithState()
        {
            return _rouletteService.GetListRouletteWithState().ToList();           
        }
    }
}

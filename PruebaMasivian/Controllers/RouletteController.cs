using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaMasivian.Interfaces;
using PruebaMasivian.Models;
using StackExchange.Redis;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PruebaMasivian.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouletteController : ControllerBase
    {
        public readonly IRouletteService _rouletteService;
        public  RouletteController(IRouletteService rouletteService)
        {
            _rouletteService = rouletteService;
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
        [HttpPost("BetRultte")]
        public void BetRultte(int id)
        {
        }
        [HttpPost("CloseRoulette")]
        public void CloseRoulette(int id)
        {
        }
        [HttpGet]
        public List<Roulette> GetListOfRoulettesWithState()
        {
            return _rouletteService.GetListRouletteWithState().ToList();           
        }
    }
}

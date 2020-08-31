using PruebaMasivian.Interfaces;
using PruebaMasivian.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace PruebaMasivian.Services
{
    public class RouletteService : IRouletteService
    {
        private readonly IRepository<Roulette> _rouletteRepository;
        public RouletteService(IRepository<Roulette> rouletteRepository)
        {
            _rouletteRepository = rouletteRepository;
        }
        public Roulette CreateRoullete()
        {
            Roulette roulette = new Roulette();
            
            return _rouletteRepository.Add(roulette);
        }
        public IList<Roulette> GetListRouletteWithState()
        {
             return _rouletteRepository.ListAll();
        }
        public string GetRoulette(string id)
        {
            var a=  _rouletteRepository.Add(new Roulette());
            return "";
        }

        public bool OpenRoulete(int id)
        {
            Roulette roulette = _rouletteRepository.GetById(id);
            if (roulette != null && roulette.IsOpen)

                return false;
            else if (roulette != null)
            {
                roulette.IsOpen = true;
                _rouletteRepository.Update(roulette);

                return true;
            }
            else

                return false;                
        }
    }
}

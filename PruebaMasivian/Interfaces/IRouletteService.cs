using PruebaMasivian.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaMasivian.Interfaces
{
    public interface IRouletteService
    {
        public Roulette CreateRoullete();       
        public bool OpenRoulete(int id);
        public string GetRoulette(string id);
        public IList<Roulette> GetListRouletteWithState();
    }
}

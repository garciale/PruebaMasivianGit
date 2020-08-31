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
        public Roulette GetRoulette(int id);
        public IList<Roulette> GetListRouletteWithState();
        public Roulette CloseRoulette(int id);
    }
}

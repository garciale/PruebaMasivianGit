using PruebaMasivian.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaMasivian.Interfaces
{
    public interface IBetService
    {
        public bool MakeBet(Bet bet);
        public IList<Bet> GetBetsByRouletteId(int idRoulette);

    }
}

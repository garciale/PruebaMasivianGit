using PruebaMasivian.Models;
using System.Collections.Generic;
namespace PruebaMasivian.Interfaces
{
    public interface IBetService
    {
        public bool MakeBet(Bet bet);
        public IList<Bet> GetBetsByRouletteId(int idRoulette);
    }
}

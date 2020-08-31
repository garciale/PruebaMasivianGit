using PruebaMasivian.Interfaces;
using PruebaMasivian.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace PruebaMasivian.Services
{
    public class BetService : IBetService
    {
        private readonly IRepository<Bet> _betRepository;
        private readonly IRepository<Roulette> _rouletteRepository;
        public BetService(IRepository<Bet> betRepository,IRepository<Roulette> rouletteRepository)
        {
            _betRepository = betRepository;
            _rouletteRepository = rouletteRepository;
        }
        public IList<Bet> GetBetsByRouletteId(int idRoulette)
        {
           return _betRepository.ListAll().Where(bet=>bet.RouletteId==idRoulette).ToList();
        }
        public bool MakeBet(Bet bet)
        {
            var roulette=_rouletteRepository.GetById(bet.RouletteId);
            if (roulette != null && roulette.IsOpen && bet.Amount > 0 && bet.Amount <= 10000 && bet.Number>=0 && bet.Number<=36)
            {
                bet.BetAt= DateTime.UtcNow.ToString("o");
                _betRepository.Add(bet);

                return true;
            }       
            else

                return false;
        }
    }
}

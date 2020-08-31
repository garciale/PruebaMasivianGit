using Newtonsoft.Json;
using PruebaMasivian.Interfaces;
using PruebaMasivian.Models;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace PruebaMasivian.Data
{
    public class RouletteRepository : IRepository<Roulette>
    {
        private readonly IConnectionMultiplexer _connectionMultiplexer;
        public RouletteRepository(IConnectionMultiplexer connectionMultiplexer)
        {
            _connectionMultiplexer = connectionMultiplexer;
        }
        public  Roulette Add(Roulette entity)
        {
            IDatabase db = _connectionMultiplexer.GetDatabase();
            RedisKey key = new  RedisKey("ListRoulette");
            IList<Roulette> roulettes = ListAll();
            if (roulettes == null){
                entity.Id = 0;
                roulettes = new List<Roulette>() { entity };
            }
            else {
                entity.Id= roulettes.Last().Id + 1;
                roulettes.Add(entity);
            }
            db.StringSet(key,JsonConvert.SerializeObject(roulettes));

            return entity;
        }
        public Roulette Delete(Roulette entity)
        {
            throw new NotImplementedException();
        }
        public Roulette GetById(int id)
        {
           return ListAll().FirstOrDefault(roulettes=>roulettes.Id==id);
        }
        public IList<Roulette> ListAll()
        {
            IDatabase db = _connectionMultiplexer.GetDatabase();
            RedisKey key = new RedisKey("ListRoulette");
            string listJson= db.StringGet(key);

            return listJson!=null ? JsonConvert.DeserializeObject<IList<Roulette>>(listJson) : null;            
        }
        public Roulette Update(Roulette entity)
        {
            IList<Roulette> roulettes = ListAll();
            IDatabase db = _connectionMultiplexer.GetDatabase();
            RedisKey key = new RedisKey("ListRoulette");
            roulettes[roulettes.IndexOf(roulettes.FirstOrDefault(roulettes => roulettes.Id == entity.Id))].IsOpen=entity.IsOpen;
            db.StringSet(key, JsonConvert.SerializeObject(roulettes));

            return entity;
        }
    }
}

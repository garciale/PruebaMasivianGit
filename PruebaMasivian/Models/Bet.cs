namespace PruebaMasivian.Models
{
    public class Bet : BaseEntity
    {
        public int RouletteId { set; get; }
        public int Amount { get; set; }
        public int Number { get; set; }
        public string Color { get; set; }
        public string? BetAt { get; set; }        
    }
}

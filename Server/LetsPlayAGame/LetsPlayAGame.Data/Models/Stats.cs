using System;

namespace LetsPlayAGame.Data.Models
{
    public class Stats
    {
        public Guid Id { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Luck { get; set; }
        public int Charisma { get; set; }

        public Guid CharacterId { get; set; }
        public virtual Character Character { get; set; }
    }
}

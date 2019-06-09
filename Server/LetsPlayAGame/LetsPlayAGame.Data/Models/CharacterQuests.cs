using System;

namespace LetsPlayAGame.Data.Models
{
    public class CharacterQuests
    {
        public Guid Id { get; set; }

        public Guid CharacterId { get; set; }
        public virtual Character Character { get; set; }

        public Guid QuestId { get; set; }
        public virtual Quest Quest { get; set; }
    }
}

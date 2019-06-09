using LetsPlayAGame.Data.Models.Enums;
using System;
using System.Collections.Generic;

namespace LetsPlayAGame.Data.Models
{
    public class Character
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }
        public Race Race { get; set; }
        public int Level { get; set; }
        public string Quote { get; set; }
        public string Story { get; set; }

        public virtual List<CharacterSkills> Skills { get; set; }
        public virtual List<CharacterQuests> Quests { get; set; }
        public virtual Stats Stats { get; set; }

        public Guid UserId { get; set; }
        public virtual User User { get; set; }
    }
}

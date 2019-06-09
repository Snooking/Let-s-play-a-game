using LetsPlayAGame.Data.Models.Enums;
using System;
using System.Collections.Generic;

namespace LetsPlayAGame.Data.Models
{
    public class Quest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public QuestStatus Status { get; set; }

        public virtual List<CharacterQuests> Characters { get; set; }
    }
}

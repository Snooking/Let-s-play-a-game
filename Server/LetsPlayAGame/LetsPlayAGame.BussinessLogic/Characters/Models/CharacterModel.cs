using LetsPlayAGame.Data.Models;
using LetsPlayAGame.Data.Models.Enums;
using System;
using System.Collections.Generic;

namespace LetsPlayAGame.BussinessLogic.Characters.Models
{
    public class CharacterModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }
        public Race Race { get; set; }
        public int Level { get; set; }
        public string Quote { get; set; }
        public string Story { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Luck { get; set; }
        public int Charisma { get; set; }
        public IReadOnlyList<Skill> Skills { get; set; }
        public IReadOnlyList<Skill> Abilities { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace LetsPlayAGame.Data.Models
{
    public class Skill
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsAbility { get; set; }

        public virtual List<CharacterSkills> Characters { get; set; }
    }
}

using System;

namespace LetsPlayAGame.Data.Models
{
    public class CharacterSkills
    {
        public Guid Id { get; set; }

        public Guid CharacterId { get; set; }
        public virtual Character Character { get; set; }

        public Guid SkillId { get; set; }
        public virtual Skill Skill { get; set; }
    }
}

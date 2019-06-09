using LetsPlayAGame.Data.Models;
using LetsPlayAGame.Data.Models.Enums;
using System.Collections.Generic;
using System.Linq;

namespace LetsPlayAGame.Data.Seeders
{
    public class DatabaseSeeder
    {
        public static void Seed(LetsPlayGameDbContext dbContext)
        {
            SeedUsers(dbContext);
            SeedCharacters(dbContext);
            SeedStats(dbContext);
            SeedSkills(dbContext);
            SeedQuests(dbContext);

            dbContext.SaveChanges();
        }

        private static void SeedCharacters(LetsPlayGameDbContext dbContext)
        {
            var character = new Character
            {
                Age = 20,
                Level = 3,
                Name = "Yvandir",
                Quote = "Skromność jest cechą ludzi, którzy nie mają się czym chwalić.",
                Race = Race.Elf,
                Sex = Sex.Male,
                Story = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                User = dbContext.Users.Local.SingleOrDefault(u => u.UserName == "Snooking")
            };

            dbContext.Characters.Add(character);
        }

        private static void SeedUsers(LetsPlayGameDbContext dbContext)
        {
            var user = new User
            {
                UserName = "Snooking"
            };

            dbContext.Users.Add(user);
        }

        private static void SeedStats(LetsPlayGameDbContext dbContext)
        {
            var stats = new Stats
            {
                Strength = 6,
                Dexterity = 4,
                Intelligence = 5,
                Wisdom = 5,
                Luck = 10,
                Charisma = 8,
                Character = dbContext.Characters.Local.SingleOrDefault(u => u.Name == "Yvandir")
            };

            dbContext.Stats.Add(stats);
        }

        private static void SeedSkills(LetsPlayGameDbContext dbContext)
        {
            var skills = new List<Skill>
            {
                new Skill
                {
                    Name = "Fire Ball",
                    IsAbility = false
                },
                new Skill
                {
                    Name = "Thunder Bolt",
                    IsAbility = false
                },
                new Skill
                {
                    Name = "Ice Spear",
                    IsAbility = false
                },
                new Skill
                {
                    Name = "Pickpocketing",
                    IsAbility = true
                },
                new Skill
                {
                    Name = "Lockpicking",
                    IsAbility = true
                },
                new Skill
                {
                    Name = "Blacksmith",
                    IsAbility = true
                }
            };

            dbContext.Skills.AddRange(skills);
        }

        public static void SeedQuests(LetsPlayGameDbContext dbContext)
        {
            var quests = new List<Quest>
            {
                new Quest
                {
                    Name = "The fight with Thanos",
                    Status = QuestStatus.Active
                },
                new Quest
                {
                    Name = "Getting the Gauntlet",
                    Status = QuestStatus.Failed
                },
                new Quest
                {
                    Name = "Time travellers",
                    Status = QuestStatus.Finalized
                },
                new Quest
                {
                    Name = "Saving the world",
                    Status = QuestStatus.Inactive
                }
            };

            dbContext.Quests.AddRange(quests);
        }
    }
}

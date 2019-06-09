using LetsPlayAGame.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LetsPlayAGame.Data
{
    public class LetsPlayGameDbContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Stats> Stats { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Quest> Quests { get; set; }
        public DbSet<CharacterQuests> CharacterQuests { get; set; }
        public DbSet<CharacterSkills> CharacterSkills { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }

        public LetsPlayGameDbContext(DbContextOptions<LetsPlayGameDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnCharacterModelCreating(modelBuilder);
            OnCharacterQuestsModelCreating(modelBuilder);
            OnCharacterSkillsModelCreating(modelBuilder);
            OnQuestModelCreating(modelBuilder);
            OnRoleModelCreating(modelBuilder);
            OnSkillModelCreating(modelBuilder);
            OnStatsModelCreating(modelBuilder);
            OnUserModelCreating(modelBuilder);
            OnUserRolesModelCreating(modelBuilder);
        }

        private void OnCharacterModelCreating(ModelBuilder modelBuilder)
        {
            var characterBuilder = modelBuilder.Entity<Character>();

            characterBuilder.HasOne(c => c.User)
                .WithOne(u => u.Character)
                .HasForeignKey<Character>(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            characterBuilder.HasMany(c => c.Quests)
                .WithOne(cq => cq.Character)
                .OnDelete(DeleteBehavior.Restrict);

            characterBuilder.HasMany(c => c.Skills)
                .WithOne(cs => cs.Character)
                .OnDelete(DeleteBehavior.Restrict);

            characterBuilder.HasOne(c => c.Stats)
                .WithOne(s => s.Character)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private void OnCharacterQuestsModelCreating(ModelBuilder modelBuilder)
        {
            var characterQuestsBuilder = modelBuilder.Entity<CharacterQuests>();

            characterQuestsBuilder.HasOne(cq => cq.Character)
                .WithMany(c => c.Quests)
                .HasForeignKey(cq => cq.CharacterId)
                .OnDelete(DeleteBehavior.Restrict);

            characterQuestsBuilder.HasOne(cq => cq.Quest)
                .WithMany(q => q.Characters)
                .HasForeignKey(cq => cq.QuestId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private void OnCharacterSkillsModelCreating(ModelBuilder modelBuilder)
        {
            var characterSkillsBuilder = modelBuilder.Entity<CharacterSkills>();

            characterSkillsBuilder.HasOne(cs => cs.Character)
                .WithMany(c => c.Skills)
                .HasForeignKey(cs => cs.CharacterId)
                .OnDelete(DeleteBehavior.Restrict);

            characterSkillsBuilder.HasOne(cs => cs.Skill)
                .WithMany(s => s.Characters)
                .HasForeignKey(cs => cs.SkillId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private void OnQuestModelCreating(ModelBuilder modelBuilder)
        {
            var questBuilder = modelBuilder.Entity<Quest>();

            questBuilder.HasMany(q => q.Characters)
                .WithOne(cq => cq.Quest)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private void OnRoleModelCreating(ModelBuilder modelBuilder)
        {
            var roleBuilder = modelBuilder.Entity<Role>();

            roleBuilder.HasMany(r => r.Users)
                .WithOne(ur => ur.Role)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private void OnSkillModelCreating(ModelBuilder modelBuilder)
        {
            var skillBuilder = modelBuilder.Entity<Skill>();

            skillBuilder.HasMany(s => s.Characters)
                .WithOne(cs => cs.Skill)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private void OnStatsModelCreating(ModelBuilder modelBuilder)
        {
            var statsBuilder = modelBuilder.Entity<Stats>();

            statsBuilder.HasOne(s => s.Character)
                .WithOne(c => c.Stats)
                .HasForeignKey<Stats>(s => s.CharacterId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private void OnUserModelCreating(ModelBuilder modelBuilder)
        {
            var userBuilder = modelBuilder.Entity<User>();

            userBuilder.HasOne(u => u.Character)
                .WithOne(c => c.User)
                .OnDelete(DeleteBehavior.Restrict);

            userBuilder.HasMany(u => u.Roles)
                .WithOne(ur => ur.User)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private void OnUserRolesModelCreating(ModelBuilder modelBuilder)
        {
            var userRolesBuilder = modelBuilder.Entity<UserRoles>();

            userRolesBuilder.HasOne(ur => ur.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(ur => ur.RoleId)
                .OnDelete(DeleteBehavior.Restrict);

            userRolesBuilder.HasOne(ur => ur.User)
                .WithMany(u => u.Roles)
                .HasForeignKey(ur => ur.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

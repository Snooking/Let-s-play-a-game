﻿// <auto-generated />
using System;
using LetsPlayAGame.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LetsPlayAGame.Data.Migrations
{
    [DbContext(typeof(LetsPlayGameDbContext))]
    partial class LetsPlayGameDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LetsPlayAGame.Data.Models.Character", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<int>("Level");

                    b.Property<string>("Name");

                    b.Property<string>("Quote");

                    b.Property<int>("Race");

                    b.Property<int>("Sex");

                    b.Property<string>("Story");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("LetsPlayAGame.Data.Models.CharacterQuests", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CharacterId");

                    b.Property<Guid>("QuestId");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("QuestId");

                    b.ToTable("CharacterQuests");
                });

            modelBuilder.Entity("LetsPlayAGame.Data.Models.CharacterSkills", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CharacterId");

                    b.Property<Guid>("SkillId");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("SkillId");

                    b.ToTable("CharacterSkills");
                });

            modelBuilder.Entity("LetsPlayAGame.Data.Models.Quest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Quests");
                });

            modelBuilder.Entity("LetsPlayAGame.Data.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("LetsPlayAGame.Data.Models.Skill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsAbility");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("LetsPlayAGame.Data.Models.Stats", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CharacterId");

                    b.Property<int>("Charisma");

                    b.Property<int>("Dexterity");

                    b.Property<int>("Intelligence");

                    b.Property<int>("Luck");

                    b.Property<int>("Strength");

                    b.Property<int>("Wisdom");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("Stats");
                });

            modelBuilder.Entity("LetsPlayAGame.Data.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LetsPlayAGame.Data.Models.UserRoles", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("RoleId");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("LetsPlayAGame.Data.Models.Character", b =>
                {
                    b.HasOne("LetsPlayAGame.Data.Models.User", "User")
                        .WithOne("Character")
                        .HasForeignKey("LetsPlayAGame.Data.Models.Character", "UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("LetsPlayAGame.Data.Models.CharacterQuests", b =>
                {
                    b.HasOne("LetsPlayAGame.Data.Models.Character", "Character")
                        .WithMany("Quests")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("LetsPlayAGame.Data.Models.Quest", "Quest")
                        .WithMany("Characters")
                        .HasForeignKey("QuestId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("LetsPlayAGame.Data.Models.CharacterSkills", b =>
                {
                    b.HasOne("LetsPlayAGame.Data.Models.Character", "Character")
                        .WithMany("Skills")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("LetsPlayAGame.Data.Models.Skill", "Skill")
                        .WithMany("Characters")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("LetsPlayAGame.Data.Models.Stats", b =>
                {
                    b.HasOne("LetsPlayAGame.Data.Models.Character", "Character")
                        .WithOne("Stats")
                        .HasForeignKey("LetsPlayAGame.Data.Models.Stats", "CharacterId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("LetsPlayAGame.Data.Models.UserRoles", b =>
                {
                    b.HasOne("LetsPlayAGame.Data.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("LetsPlayAGame.Data.Models.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
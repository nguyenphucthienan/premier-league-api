﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PremierLeagueAPI.Persistence;

namespace PremierLeagueAPI.Migrations
{
    [DbContext(typeof(PremierLeagueDbContext))]
    [Migration("20181111041400_AddSquadEntity")]
    partial class AddSquadEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("PremierLeagueAPI.Core.Models.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CardTime");

                    b.Property<int>("CardType");

                    b.Property<int>("ClubId");

                    b.Property<int>("MatchId");

                    b.Property<int>("PlayerId");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.HasIndex("MatchId");

                    b.HasIndex("PlayerId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("PremierLeagueAPI.Core.Models.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<int>("EstablishedYear");

                    b.Property<string>("HomeField");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PhotoUrl");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("PremierLeagueAPI.Core.Models.Goal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClubId");

                    b.Property<int>("GoalTime");

                    b.Property<int>("GoalType");

                    b.Property<bool>("IsOwnGoal");

                    b.Property<int>("MatchId");

                    b.Property<int>("PlayerId");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.HasIndex("MatchId");

                    b.HasIndex("PlayerId");

                    b.ToTable("Goals");
                });

            modelBuilder.Entity("PremierLeagueAPI.Core.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AwayClubId");

                    b.Property<int>("HomeClubId");

                    b.Property<bool>("IsPlayed");

                    b.Property<DateTime>("MatchTime");

                    b.Property<int>("Round");

                    b.Property<int>("SeasonId");

                    b.HasKey("Id");

                    b.HasIndex("AwayClubId");

                    b.HasIndex("HomeClubId");

                    b.HasIndex("SeasonId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("PremierLeagueAPI.Core.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthdate");

                    b.Property<int?>("Height");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Nationality");

                    b.Property<int>("Number");

                    b.Property<string>("PhotoUrl");

                    b.Property<string>("Position");

                    b.Property<int?>("Weight");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("PremierLeagueAPI.Core.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("PremierLeagueAPI.Core.Models.Season", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Season");
                });

            modelBuilder.Entity("PremierLeagueAPI.Core.Models.SeasonClub", b =>
                {
                    b.Property<int>("SeasonId");

                    b.Property<int>("ClubId");

                    b.HasKey("SeasonId", "ClubId");

                    b.HasIndex("ClubId");

                    b.ToTable("SeasonClub");
                });

            modelBuilder.Entity("PremierLeagueAPI.Core.Models.Squad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClubId");

                    b.Property<int>("SeasonId");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.HasIndex("SeasonId");

                    b.ToTable("Squad");
                });

            modelBuilder.Entity("PremierLeagueAPI.Core.Models.SquadPlayer", b =>
                {
                    b.Property<int>("SquadId");

                    b.Property<int>("PlayerId");

                    b.HasKey("SquadId", "PlayerId");

                    b.HasIndex("PlayerId");

                    b.ToTable("SquadPlayer");
                });

            modelBuilder.Entity("PremierLeagueAPI.Core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<DateTime>("LastActive");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("PremierLeagueAPI.Core.Models.UserRole", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("PremierLeagueAPI.Core.Models.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("PremierLeagueAPI.Core.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("PremierLeagueAPI.Core.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("PremierLeagueAPI.Core.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PremierLeagueAPI.Core.Models.Card", b =>
                {
                    b.HasOne("PremierLeagueAPI.Core.Models.Club", "Club")
                        .WithMany("Cards")
                        .HasForeignKey("ClubId");

                    b.HasOne("PremierLeagueAPI.Core.Models.Match", "Match")
                        .WithMany("Cards")
                        .HasForeignKey("MatchId");

                    b.HasOne("PremierLeagueAPI.Core.Models.Player", "Player")
                        .WithMany("Cards")
                        .HasForeignKey("PlayerId");
                });

            modelBuilder.Entity("PremierLeagueAPI.Core.Models.Goal", b =>
                {
                    b.HasOne("PremierLeagueAPI.Core.Models.Club", "Club")
                        .WithMany("Goals")
                        .HasForeignKey("ClubId");

                    b.HasOne("PremierLeagueAPI.Core.Models.Match", "Match")
                        .WithMany("Goals")
                        .HasForeignKey("MatchId");

                    b.HasOne("PremierLeagueAPI.Core.Models.Player", "Player")
                        .WithMany("Goals")
                        .HasForeignKey("PlayerId");
                });

            modelBuilder.Entity("PremierLeagueAPI.Core.Models.Match", b =>
                {
                    b.HasOne("PremierLeagueAPI.Core.Models.Club", "AwayClub")
                        .WithMany("AwayMatches")
                        .HasForeignKey("AwayClubId");

                    b.HasOne("PremierLeagueAPI.Core.Models.Club", "HomeClub")
                        .WithMany("HomeMatches")
                        .HasForeignKey("HomeClubId");

                    b.HasOne("PremierLeagueAPI.Core.Models.Season", "Season")
                        .WithMany()
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PremierLeagueAPI.Core.Models.SeasonClub", b =>
                {
                    b.HasOne("PremierLeagueAPI.Core.Models.Club", "Club")
                        .WithMany("SeasonClubs")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PremierLeagueAPI.Core.Models.Season", "Season")
                        .WithMany("SeasonClubs")
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PremierLeagueAPI.Core.Models.Squad", b =>
                {
                    b.HasOne("PremierLeagueAPI.Core.Models.Club", "Club")
                        .WithMany()
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PremierLeagueAPI.Core.Models.Season", "Season")
                        .WithMany()
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PremierLeagueAPI.Core.Models.SquadPlayer", b =>
                {
                    b.HasOne("PremierLeagueAPI.Core.Models.Player", "Player")
                        .WithMany("SquadPlayers")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PremierLeagueAPI.Core.Models.Squad", "Squad")
                        .WithMany("SquadPlayers")
                        .HasForeignKey("SquadId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PremierLeagueAPI.Core.Models.UserRole", b =>
                {
                    b.HasOne("PremierLeagueAPI.Core.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PremierLeagueAPI.Core.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

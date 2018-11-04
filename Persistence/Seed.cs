using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using PremierLeagueAPI.Models;

namespace PremierLeagueAPI.Persistence
{
    public class Seed
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public Seed(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public void SeedData()
        {
            SeedRolesAndAdminUser();
            SeedClubs();
        }

        private void SeedRolesAndAdminUser()
        {
            if (_userManager.Users.Any())
                return;

            var roles = new List<Role>
            {
                new Role {Name = "Admin"},
                new Role {Name = "Moderator"},
                new Role {Name = "Member"}
            };

            foreach (var role in roles)
            {
                _roleManager.CreateAsync(role).Wait();
            }

            // Create admin user
            var adminUser = new User
            {
                UserName = "admin",
            };

            var result = _userManager.CreateAsync(adminUser, "password").Result;

            if (!result.Succeeded)
                return;

            var admin = _userManager.FindByNameAsync("admin").Result;
            _userManager.AddToRolesAsync(admin, new[] {"Admin", "Moderator"}).Wait();
        }

        private void SeedClubs()
        {
            var clubsData = File.ReadAllText("Persistence/Data/Clubs.json");
            var clubs = JsonConvert.DeserializeObject<List<Club>>(clubsData);

            foreach (var club in clubs)
            {
                // TODO: Add club to database
            }
        }
    }
}
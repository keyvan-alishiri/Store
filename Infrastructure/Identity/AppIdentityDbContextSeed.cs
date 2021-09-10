using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DispalyName = "keyvan",
                    Email = "keyvan.alishiri@gmail.com",
                    UserName = "Admin@test.com",
                    Address = new Address
                    {
                        FirstName = "keyvan",
                        LastName = "Alishiri",
                        Street = "Taleghani",
                        City = "Karaj",
                        State = "Alborz",
                        PostalCode = "31339"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}
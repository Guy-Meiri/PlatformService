using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var appDbContext = serviceScope.ServiceProvider.GetService<AppDbContext>();
                SeedData(appDbContext);
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if (!context.Platforms.Any())
            {
                System.Console.WriteLine("--> Seeding Data");
                context.Platforms.AddRange(
                        new Models.Platform() { Name = "Dot Net", Publisher = "Microsoft", Cost = "Free" },
                        new Models.Platform() { Name = "Sql Server Express", Publisher = "Microsoft", Cost = "Free" },
                        new Models.Platform() { Name = "Kubernetes", Publisher = "Cloud Native Computing Foundation", Cost = "Free" }
                    );
            }
            else
            {
                System.Console.WriteLine("--> We already have data");
            }
        }
    }
}

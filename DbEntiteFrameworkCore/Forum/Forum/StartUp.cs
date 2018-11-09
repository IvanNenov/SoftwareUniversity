using Forum.Data;
using Forum.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Forum
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var context = new ForumDbContext();
            ResetDatabase(context);
            var users = new[]
            {
                new User("Gosho", "123"),
                new User("Pesjo", "12cc3"),
                new User("tre", "sd")
            };

            context.Users.AddRange(users);

            context.SaveChanges();
        }

        private static void ResetDatabase(ForumDbContext context)
        {
            context.Database.EnsureDeleted();

            context.Database.Migrate();

            Seed(context);
        }

        private static void Seed(ForumDbContext context)
        {
            var users = new[]
              {
                new User("Gosho", "123"),
                new User("Pesjo", "12cc3"),
                new User("tre", "sd")
            };
            context.Users.AddRange(users);

            context.SaveChanges();
        }
    }
}

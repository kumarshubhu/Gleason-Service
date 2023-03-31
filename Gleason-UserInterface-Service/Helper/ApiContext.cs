using System;
using Gleason_UserInterface_Service.Models;
using Microsoft.EntityFrameworkCore;

namespace Gleason_UserInterface_Service.Helper
{
    public class ApiContext: DbContext
    {
        protected override void OnConfiguring
       (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "GleasonDb");
        }
        public DbSet<User> Users { get; set; }
    }
}

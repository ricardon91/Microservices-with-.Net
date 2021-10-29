using Microsoft.EntityFrameworkCore;
using PlatformService.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformService.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>option) : base(option)
        {

        }

        public DbSet<Platform> Platforms { get; set; }
    }
}

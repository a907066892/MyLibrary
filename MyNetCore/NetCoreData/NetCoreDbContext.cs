using Microsoft.EntityFrameworkCore;
using NetCoreData.Model;
using System;

namespace NetCoreData
{
    public class NetCoreDbContext : DbContext
    {
        public NetCoreDbContext(DbContextOptions<NetCoreDbContext> options) : base(options)
        {
        }
         public DbSet<User> User { get; set; }
    }
}

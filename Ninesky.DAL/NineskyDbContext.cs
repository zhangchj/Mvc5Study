using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Ninesky.Models;

namespace Ninesky.DAL
{
    public class NineskyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<UserConfig> UserConfig { get; set; }
        public NineskyDbContext()
            : base("DefaultConnection")
        {
        }
    }

}

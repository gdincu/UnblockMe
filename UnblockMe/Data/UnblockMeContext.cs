using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UnblockMe.Models.Entities;

namespace UnblockMe.Data
{
    public class UnblockMeContext : DbContext
    {
        public UnblockMeContext (DbContextOptions<UnblockMeContext> options)
            : base(options)
        {
        }

        public DbSet<UnblockMe.Models.Entities.Vehicle> Vehicle { get; set; }

        public DbSet<UnblockMe.Models.Entities.User> User { get; set; }
    }
}

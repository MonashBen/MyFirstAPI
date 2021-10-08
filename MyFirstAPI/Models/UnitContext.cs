using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyFirstAPI.Models
{
    public class UnitContext : DbContext
    {
        public UnitContext(DbContextOptions<UnitContext> options)
            : base(options)
        {
        }
        
        public DbSet<Unit> Units { get; set; }
    }
}

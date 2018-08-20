using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Umbra.Models
{
    public class UmbraContext : DbContext
    {
        public UmbraContext (DbContextOptions<UmbraContext> options)
            : base(options)
        {
        }

        public DbSet<Umbra.Models.Todo> Todo { get; set; }
    }
}

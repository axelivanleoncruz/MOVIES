using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOVIES.Models;

namespace MOVIES.Data
{
    public class MOVIESContext : DbContext
    {
        public MOVIESContext (DbContextOptions<MOVIESContext> options)
            : base(options)
        {
        }

        public DbSet<MOVIES.Models.Movie> Movie { get; set; } = default!;
    }
}

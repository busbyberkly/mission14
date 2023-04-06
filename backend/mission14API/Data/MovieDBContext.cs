using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission14API.Data
{
    public class MovieDBContext : DbContext
    {
        public MovieDBContext (DbContextOptions<MovieDBContext> options) : base(options) { }
        public DbSet<MovieCollection> Movies { get; set; }
    }
}

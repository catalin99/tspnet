using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace Asp_Belu_Catalin_Rp.Data
{
    public class Asp_Belu_Catalin_RpContext : DbContext
    {
        public Asp_Belu_Catalin_RpContext (DbContextOptions<Asp_Belu_Catalin_RpContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }
    }
}

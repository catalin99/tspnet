using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModelDesignFirst_L1;
using ASPNetCore.Models;

namespace ASPNetCore.Data
{
    public class ASPNetCoreContext : DbContext
    {
        public ASPNetCoreContext (DbContextOptions<ASPNetCoreContext> options)
            : base(options)
        {
        }
        public DbSet<ASPNetCore.Models.PhotoDTO> Photos { get; set; }
        public DbSet<ASPNetCore.Models.MovieDTO> Movies { get; set; }
        public DbSet<ASPNetCore.Models.PropertyCodeDTO> PropertyCodes { get; set; }

    }
}

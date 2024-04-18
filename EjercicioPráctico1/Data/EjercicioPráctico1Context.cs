using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EjercicioPráctico1.Models;

namespace EjercicioPráctico1.Data
{
    public class EjercicioPráctico1Context : DbContext
    {
        public EjercicioPráctico1Context (DbContextOptions<EjercicioPráctico1Context> options)
            : base(options)
        {
        }

        public DbSet<EjercicioPráctico1.Models.Burger> Burger { get; set; } = default!;
    }
}

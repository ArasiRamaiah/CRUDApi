using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDApi.Model;

namespace CRUDApi.Data
{
    public class CRUDApiContext : DbContext
    {
        public CRUDApiContext (DbContextOptions<CRUDApiContext> options)
            : base(options)
        {
        }

        public DbSet<CRUDApi.Model.Product> Product { get; set; } = default!;
        public DbSet<CRUDApi.Model.Customer> Customer { get; set; } = default!;
    }
}

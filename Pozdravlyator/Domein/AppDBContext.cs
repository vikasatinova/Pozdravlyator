using Microsoft.EntityFrameworkCore;
using Pozdravlyator.Domein.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pozdravlyator.Domein
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Birthday> Birthdays { get; set; }
    }
}

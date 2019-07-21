using OnionApp.Domain.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Infrastructure.Data
{
    public class NaturalContext : DbContext
    {
        public DbSet<Bill> Bills { get; set; }
        public DbSet<NaturalPerson> NPersons { get; set; }
    }
}

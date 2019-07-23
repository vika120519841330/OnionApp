using OnionApp.Domain.Core;
using System.Data.Entity;

namespace OnionApp.Infrastructure.Data
{
    // Infrastructure
    public class PersonBillContext : DbContext
    {
        public PersonBillContext() : base("MyDBPersonBill")
        { }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<NaturalPerson> NaturalPersons { get; set; }
        public DbSet<JuridicalPerson> JuridicalPersons { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OnionApp.Domain.Core
{
    //Domain Model NaturalPerson
    public class NaturalPerson : Person
    {
        public string PersonFullName { get; set; }
        public int PersonAge { get; set; }
    }
}

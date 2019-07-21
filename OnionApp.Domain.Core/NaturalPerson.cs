using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
    //Domain Model NaturalPerson
    public class NaturalPerson
    {
        public int ClientId { get; set; }
        public string PersonFullName { get; set; }
        public int PersonAge { get; set; }
    }
}

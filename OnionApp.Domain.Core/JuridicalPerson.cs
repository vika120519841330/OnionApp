using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OnionApp.Domain.Core
{
    //Domain Model JuridicalPerson
    public class JuridicalPerson : Person
    {
        public string PersonFullTitle { get; set; }
        public string TaxpayIdentNum { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Core
{
    //Domain Model JuridicalPerson
    public class JuridicalPerson
    {
        public int ClientId { get; set; }
        public string PersonFullTitle { get; set; }
        public string TaxpayIdentNum { get; set; }
    }
}

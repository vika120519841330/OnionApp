﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OnionApp.Domain.Core
{
    public abstract class Person
    {
        public int PersonId { get; set; }
        public List<Bill> BillsOfPerson;
    }
}

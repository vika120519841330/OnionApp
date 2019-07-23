﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OnionApp.Domain.Core
{
    //Domain Model Bill
    public class Bill
    {
        public int BillId { get; set; }
        public string BillNumber { get; set; }
        public double BillBalance { get; set; }
        public int BillOwner { get; set; }
    }
}

using OnionApp.Domain.Core;
using OnionApp.Domain.Interfaces;
using OnionApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;

namespace OnionApp.Controllers
{
    public class BillController : ApiController
    {
        IBillRepositiry brep = BillRepository.GetStaticBill();
        [HttpGet]
        //[Route("")]
        IEnumerable<Bill> ShowAllBills()
        {
            return brep.ShowAllBills();
        }
        [HttpGet]
        //[Route("{id:int}")]
        Bill GetBill(int id)
        {
            return brep.GetBill(id);
        }
        [HttpPost]
        //[Route("{inst}")]
        Bill OpenBill(Bill inst)
        {
            return brep.OpenBill(inst);
        }
        [HttpPut]
        //[Route("{id:int}/{inst}")]
        Bill DebitCreditBill(int id, int sum)
        {
            return brep.DebitCreditBill(id, sum);
        }
        [HttpDelete]
        //[Route("{id:int}")]
        void CloseBill(int id)
        {
            brep.CloseBill(id);
        }
    }
}

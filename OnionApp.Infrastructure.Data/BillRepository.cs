using OnionApp.Domain.Core;
using OnionApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Data.Entity;

namespace OnionApp.Infrastructure.Data
{
    // Реализация интерфейса (сервиса домена) репозитория
    public class BillRepository : IBillRepositiry
    {
        // Статический обьект и метод класса
        private static BillRepository br;
        public static IBillRepositiry GetStaticBill()
        {
            br = new BillRepository();
            return br;
        }
        // Реализация операций с БД через обьект контекста
        PersonBillContext bc = new PersonBillContext();
        public IEnumerable<Bill> ShowAllBills()
        {
            return bc.Bills;
        }
        public Bill GetBill(int id)
        {
            var tmp = from bd in bc.Bills
                      where bd.BillId == id
                      select bd;
            return tmp.Count() > 0 ? tmp.First() : null;
        }
        public Bill OpenBill([FromBody]Bill inst)
        {
            bc.Bills.Add(inst);
            bc.SaveChanges();
            return inst;
        }
        public Bill DebitCreditBill(int id, int sum)
        {
            Bill tmp = GetBill(id);
            if (tmp != null)
            {
                var temp = tmp.BillBalance + sum;
                if (temp >=0)
                {
                    tmp.BillBalance = tmp.BillBalance + sum;
                }
                else
                {
                    Console.WriteLine("Сумма снятия превышает остаток денежных средств на расчетном счете клиента!!" +
                        "Попробуйте снять другую сумму!!");
                }
                return tmp;
            }
            else
            {
                return null;
            }    
        }
        public void CloseBill(int id)
        {
            Bill tmp = GetBill(id);
            if (tmp != null)
                bc.Bills.Remove(tmp);
        }
    }
}

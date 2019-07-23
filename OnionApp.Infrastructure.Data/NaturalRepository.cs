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
    public class NaturalRepository : INaturalRepository
    {
        // Статический обьект и метод класса
        private static NaturalRepository nr;
        public static INaturalRepository GetStaticClient()
        {
            nr = new NaturalRepository();
            return nr;
        }
        // Реализация операций с БД через обьект контекста
        PersonBillContext nc = new PersonBillContext();
        public IEnumerable<NaturalPerson> ShowAllClients()
        {
            return nc.NaturalPersons;
        }
        public NaturalPerson GetClient(int id)
        {
            var tmp = from dc in nc.NaturalPersons
                      where dc.PersonId == id
                      select dc;
            return tmp.Count() > 0 ? tmp.First(): null;
        }
        public NaturalPerson AddClient([FromBody]NaturalPerson inst)
        {
            nc.NaturalPersons.Add(inst);
            nc.SaveChanges();
            return inst;
        }
        public bool UpdateClient(int id, [FromBody]NaturalPerson inst)
        {
            if (id == inst.PersonId)
            {
                var tmp = from dc in nc.NaturalPersons
                          where dc.PersonId == inst.PersonId
                          select dc;
                var t = tmp.Count() > 0 ? tmp.First() : null;
                if (t != null)
                {
                    t.PersonAge = inst.PersonAge;
                    t.PersonFullName = inst.PersonFullName;
                    t.BillsOfPerson = inst.BillsOfPerson;
                    nc.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public void DeleteCient(int id)
        {
            var tmp = GetClient(id);
            if (tmp != null)
            {
                nc.NaturalPersons.Remove(tmp);
                nc.SaveChanges();
            }   
        }
    }
}
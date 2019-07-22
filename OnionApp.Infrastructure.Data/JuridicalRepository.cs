using OnionApp.Domain.Core;
using OnionApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace OnionApp.Infrastructure.Data
{
    // Реализация интерфейса (сервиса домена) репозитория
    public class JuridicalRepository : IJuridicalRepository
    {
        // Статический обьект и метод класса
        private static JuridicalRepository jr;
        public static IJuridicalRepository GetStaticClient()
        {
            jr = new JuridicalRepository();
            return jr;
        }
        // Реализация операций с БД через обьект контекста
        PersonBillContext jc = new PersonBillContext();
        public IEnumerable<JuridicalPerson> ShowAllClients()
        {
            return jc.JPersons;
        }
        public JuridicalPerson GetClient(int id)
        {
            //var tmp = from dc in jc.JPersons
            //          where dc.PersonId == id
            //          select dc;
            //return tmp.Count() > 0 ? tmp.First() : null;
            JuridicalPerson jurpers = jc.JPersons.Find(id);
            if (jurpers != null)
            {
                return jurpers;
            }
            else
            {
                return null;
            }
        }
        public JuridicalPerson AddClient([FromBody]JuridicalPerson inst)
        {
            jc.JPersons.Add(inst);
            jc.SaveChanges();
            return inst;
        }
        public bool UpdateClient(int id,[FromBody]JuridicalPerson inst)
        {
            //var tmp = from dc in jc.JPersons
            //          where dc.PersonId == inst.PersonId
            //          select dc;
            //var t = tmp.Count() > 0 ? tmp.First() : null;
            //if (t != null)
            //{
            //    t.PersonFullTitle = inst.PersonFullTitle;
            //    t.TaxpayIdentNum = inst.TaxpayIdentNum;
            //    return true;
            //}
            //else
            //    return false;
            if (id == inst.PersonId)
            {
                jc.Entry(inst).State = EntityState.Modified;
                jc.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DeleteCient(int id)
        {
            JuridicalPerson tmp = GetClient(id);
            if (tmp != null)
            {
                jc.JPersons.Remove(tmp);
                jc.SaveChanges();
            }    
        }
    }
}

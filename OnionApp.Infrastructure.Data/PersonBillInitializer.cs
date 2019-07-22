using OnionApp.Domain.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Infrastructure.Data
{
    public class PersonBillInitializer : DropCreateDatabaseAlways<PersonBillContext>
    {
        protected override void Seed(PersonBillContext ndb)
        {
            // Инициализация модели физ.лиц в БД
            ndb.NaturalPersons.Add(
                new NaturalPerson
                {
                    PersonId = 1,
                    PersonFullName = "Иванов Иван Иванович",
                    PersonAge = 28,
                    BillsOfPerson = new List<Bill>
                    {
                        new Bill
                        {
                            BillId = 11,
                            BillBalance = 120,
                            BillNumber = "123456781",
                            BillOwner = 1
                        },
                        new Bill
                        {
                            BillId = 12,
                            BillBalance = 0,
                            BillNumber = "123456782",
                            BillOwner = 1
                        }
                    }
                }); 
            ndb.NaturalPersons.Add(new NaturalPerson
            {
                PersonId = 2,
                PersonFullName = "Петров Петр Петрович",
                PersonAge = 34,
                BillsOfPerson = new List<Bill>
                {
                   new Bill
                   {
                        BillId = 13,
                        BillBalance = 1100,
                        BillNumber = "123456783",
                        BillOwner = 2
                    },
                    new Bill
                    {
                        BillId = 14,
                        BillBalance = 1230,
                        BillNumber = "123456784",
                        BillOwner = 2
                    }
                }
            });
            ndb.NaturalPersons.Add(new NaturalPerson
            {
                PersonId = 3,
                PersonFullName = "Сидоров Николай Петрович",
                PersonAge = 68,
                BillsOfPerson = new List<Bill>
                {
                    new Bill
                    {
                        BillId = 15,
                        BillBalance = 57457,
                        BillNumber = "123456785",
                        BillOwner = 3
                    }
                }
            });
            // Инициализация модели юр.лиц в БД
            ndb.JuridicalPersons.Add(new JuridicalPerson { PersonFullTitle = "Стройтехносистем", TaxpayIdentNum = "123456789" });
            ndb.JuridicalPersons.Add(new JuridicalPerson { PersonFullTitle = "Види", TaxpayIdentNum = "123456788" });
            ndb.JuridicalPersons.Add(new JuridicalPerson { PersonFullTitle = "Промтехнология", TaxpayIdentNum = "123456787" });
            ndb.JuridicalPersons.Add(new JuridicalPerson { PersonFullTitle = "Модная Галактика", TaxpayIdentNum = "123456786" });
            // Инициализация модели расчетных счетов в БД
            ndb.Bills.Add(
                new Bill
                {
                    BillBalance = 120,
                    BillNumber = "123456781",
                    BillOwner = 1
                });
            ndb.Bills.Add(
                new Bill
                {
                    BillBalance = 0,
                    BillNumber = "123456782",
                    BillOwner = 1
                });
            ndb.Bills.Add(
                new Bill
                {
                    BillBalance = 1100,
                    BillNumber = "123456783",
                    BillOwner = 2
                });
            ndb.Bills.Add(
                new Bill
                {
                    BillBalance = 1230,
                    BillNumber = "123456784",
                    BillOwner = 2
                });
             ndb.Bills.Add(
                 new Bill
                {
                    BillBalance = 57457,
                    BillNumber = "123456785",
                    BillOwner = 3
                });
            base.Seed(ndb);
        }
    }
}
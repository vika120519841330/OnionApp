using OnionApp.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Interfaces
{
    // Domain Model NaturalMethods Service
    public interface INaturalMethods
    {
        // метод для получения сведений обо всех клиентах банка
        IEnumerable<NaturalPerson> ShowAllClients();
        // метод для получения сведений по одному выбранному клиенту банка
        NaturalPerson GetClient(int id);
        // метод для добавления нового клиента банка
        NaturalPerson AddClient(NaturalPerson inst);
        // метод для редактирования сведений о клиенте банка
        bool UpdateClient(NaturalPerson inst);
        // метод для удаления клиента банка
        void DeleteCient(int id);
    }
}

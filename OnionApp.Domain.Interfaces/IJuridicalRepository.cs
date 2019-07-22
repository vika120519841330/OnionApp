using OnionApp.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Interfaces
{   
    // Domain Model PersonMethods Service
    public interface IJuridicalRepository 
    {
        // метод для получения сведений обо всех клиентах банка
        IEnumerable<JuridicalPerson> ShowAllClients();
        // метод для получения сведений по одному выбранному клиенту банка
        JuridicalPerson GetClient(int id);
        // метод для добавления нового клиента банка
        JuridicalPerson AddClient(JuridicalPerson inst);
        // метод для редактирования сведений о клиенте банка
        bool UpdateClient(int id, JuridicalPerson inst);
        // метод для удаления клиента банка
        void DeleteCient(int id);
    }
}


using OnionApp.Domain.Core;
using OnionApp.Domain.Interfaces;
using OnionApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnionApp.Controllers
{
    public class JuridicalController : ApiController
    {
        IJuridicalRepository jrep = JuridicalRepository.GetStaticClient();
        // 
        [HttpGet]
        //[Route("")]
        public IEnumerable<JuridicalPerson> ShowAllClients()
        {
            return jrep.ShowAllClients();
        }

        [HttpGet]
        //[Route("{id:int}")]
        public JuridicalPerson GetClient(int id)
        {
            return jrep.GetClient(id);
        }

        [HttpPost]
        //[Route("{inst}")]
        public JuridicalPerson AddClient(JuridicalPerson inst)
        {
            return jrep.AddClient(inst);
        }
        [HttpPut]
        public bool UpdateClient(int id,JuridicalPerson inst)
        {
            return jrep.UpdateClient(id, inst);
        }

        [HttpDelete]
        public void DeleteCient(int id)
        {
            jrep.DeleteCient(id);
        }
    }
}
﻿using OnionApp.Domain.Core;
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
    public class NaturalController : ApiController
    {
        INaturalRepository nrep = NaturalRepository.GetStaticClient();
        [HttpGet]
        //[Route("")]
        public IEnumerable<NaturalPerson> ShowAllClients()
        {
            return nrep.ShowAllClients();
        }

        [HttpGet]
        //[Route("{id:int}")]
        public NaturalPerson GetClient(int id)
        {
            return nrep.GetClient(id);
        }

        [HttpPost]
        //[Route("{inst}")]
        public NaturalPerson AddClient(NaturalPerson inst)
        {
            return nrep.AddClient(inst);
        }
        [HttpPut]
        //[Route("{id:int}/{inst}")]
        public bool UpdateClient(int id, NaturalPerson inst)
        {
            return nrep.UpdateClient(id, inst);
        }

        [HttpDelete]
        //[Route("{id:int}")]
        public void DeleteCient(int id)
        {
            nrep.DeleteCient(id);
        }
    }
}

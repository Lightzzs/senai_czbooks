using Microsoft.EntityFrameworkCore;
using senai_czbooks_webApi.Context;
using senai_czbooks_webApi.Domains;
using senai_czbooks_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_czbooks_webApi.Repositories
{
    public class AutoresRepository : IAutoresRepository
    {

        CzbooksContext ctx = new CzbooksContext();

        public List<Autores> Listar()
        {
            return ctx.Autores.Include(x => x.Livros).ToList();
        }
    }
}

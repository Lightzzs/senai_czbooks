using senai_czbooks_webApi.Context;
using senai_czbooks_webApi.Domains;
using senai_czbooks_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_czbooks_webApi.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        CzbooksContext ctx = new CzbooksContext();

        public void Cadastrar(Categoria novaCategoria)
        {

            ctx.Categorias.Add(novaCategoria);

            ctx.SaveChanges();
        }
    }
}

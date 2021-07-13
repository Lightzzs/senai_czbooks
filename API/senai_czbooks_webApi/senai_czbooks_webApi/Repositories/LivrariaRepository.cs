using senai_czbooks_webApi.Context;
using senai_czbooks_webApi.Domains;
using senai_czbooks_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_czbooks_webApi.Repositories
{
    public class LivrariaRepository : ILivrariaRepository
    {
        CzbooksContext ctx = new CzbooksContext();
        public void Cadastrar(Livraria CadastrarLivraria)
        {
            ctx.Livrarias.Add(CadastrarLivraria);

            ctx.SaveChanges();
        }
    }
}

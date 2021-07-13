using senai_czbooks_webApi.Context;
using senai_czbooks_webApi.Domains;
using senai_czbooks_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_czbooks_webApi.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        CzbooksContext ctx = new CzbooksContext();

        public void Cadastrar(Livro novoLivro)
        {
            ctx.Livros.Add(novoLivro);

            ctx.SaveChanges();
        }

        public List<Livro> ListarTodos()
        {
            return ctx.Livros.ToList();

        }
    }
}

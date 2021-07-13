using Microsoft.EntityFrameworkCore;
using senai_czbooks_webApi.Context;
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

        public List<Livro> ListarMeus(int id)
        {
            return ctx.Livros

                .Include(p => p.IdAutorNavigation)
                .Include(p => p.IdUsuarioNavigation.IdTipoUsuarioNavigation)
                .Include(p => p.IdAutorNavigation.IdUsuarioNavigation)
                .Where(p => p.IdUsuario == id)
                .ToList();

        }

        public List<Livro> ListarTodos()
        {
            return ctx.Livros.ToList();

        }
    }
}

using senai_czbooks_webApi.Context;
using senai_czbooks_webApi.Domains;
using senai_czbooks_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_czbooks_webApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        CzbooksContext ctx = new CzbooksContext();

        public void Cadastrar(Usuario novoUsuario)
        {
            ctx.Usuarios.Add(novoUsuario);

            ctx.SaveChanges();
        }
    

        public Usuario Login(string email, string senha)
        {
            return ctx.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        public List<Usuario> Listar()
        {
            // Retorna uma lista com todas as informações dos tipos de usuários, exceto as senhas
            return ctx.Usuarios
                .Select(u => new Usuario()
                {
                    IdUsuario = u.IdUsuario,
                    Email = u.Email,
                    IdTipoUsuario = u.IdTipoUsuario,

                    IdTipoUsuarioNavigation = new TiposUsuario()
                    {
                        IdTipoUsuario = u.IdTipoUsuarioNavigation.IdTipoUsuario,
                        Descricao = u.IdTipoUsuarioNavigation.Descricao
                    }
                })
                .ToList();
        }
    }
}

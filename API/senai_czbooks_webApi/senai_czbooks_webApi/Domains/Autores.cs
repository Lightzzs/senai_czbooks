using System;
using System.Collections.Generic;

#nullable disable

namespace senai_czbooks_webApi.Domains
{
    public partial class Autores
    {
        public Autores()
        {
            Livros = new HashSet<Livro>();
        }

        public int IdAutor { get; set; }
        public int? IdUsuario { get; set; }
        public string Nome { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Livro> Livros { get; set; }
    }
}

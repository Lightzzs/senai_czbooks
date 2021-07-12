using System;
using System.Collections.Generic;

#nullable disable

namespace senai_czbooks_webApi.Domains
{
    public partial class Categoria
    {
        public Categoria()
        {
            Livros = new HashSet<Livro>();
        }

        public int IdCategoria { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}

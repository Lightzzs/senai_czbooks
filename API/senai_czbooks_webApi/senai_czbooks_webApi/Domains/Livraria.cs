using System;
using System.Collections.Generic;

#nullable disable

namespace senai_czbooks_webApi.Domains
{
    public partial class Livraria
    {
        public Livraria()
        {
            Livros = new HashSet<Livro>();
        }

        public int IdLivraria { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}

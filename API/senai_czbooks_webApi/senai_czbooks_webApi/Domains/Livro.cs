using System;
using System.Collections.Generic;

#nullable disable

namespace senai_czbooks_webApi.Domains
{
    public partial class Livro
    {
        public int IdLivro { get; set; }
        public int? IdAutor { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdLivraria { get; set; }
        public string Titulo { get; set; }
        public string Sinopse { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Preco { get; set; }

        public virtual Autore IdAutorNavigation { get; set; }
        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual Livraria IdLivrariaNavigation { get; set; }
    }
}

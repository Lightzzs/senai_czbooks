using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

#nullable disable

namespace senai_czbooks_webApi.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Autores = new HashSet<Autores>();
        }

        public int IdUsuario { get; set; }
        public int? IdTipoUsuario { get; set; }

        [Required(ErrorMessage = "O Campo senha deve ser informado!")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "A senha deve conter no mínimo 5 caracteres")]
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual TiposUsuario IdTipoUsuarioNavigation { get; set; }
        public virtual ICollection<Autores> Autores { get; set; }
    }
}

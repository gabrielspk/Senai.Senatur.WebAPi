using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.Senatur.WebApi.Domains
{
    public partial class Usuarios
    {
        public int IdUsuario { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "A senha deve conter no mínimo 5 e no máximo 30 caracteres")]
        public string Senha { get; set; }


        public int? IdTipoUsuario { get; set; }

        public TipoUsuario IdTipoUsuarioNavigation { get; set; }
    }
}

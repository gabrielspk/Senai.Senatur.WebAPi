using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using Senai.Senatur.WebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        Senatur_Tarde ctx = new Senatur_Tarde();

        public Usuarios BuscarPorEmailSenha(LoginViewModel usuario)
        {
            return ctx.Usuarios.FirstOrDefault(u => u.Email == usuario.Email && u.Senha == usuario.Senha);
        }

        public List<Usuarios> Listar()
        {
            return ctx.Usuarios.ToList();
        }

    
    }
}

﻿using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        Senatur_Tarde ctx = new Senatur_Tarde();

        public List<Usuarios> Listar()
        {
            return ctx.Usuarios.ToList();
        }
    }
}

﻿using Financeiro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Financeiro.DAO
{
    public class UsuarioDAO
    {
        private FinancasContext context;

        public UsuarioDAO(FinancasContext context)
        {
            this.context = context;
        }

        public void Adiciona(Usuario usuario)
        {
            context.Usuarios.Add(usuario);
            context.SaveChanges();
        }

        public IList<Usuario> ListaUsuario()
        {
            return context.Usuarios.ToList();
        }
    }
}
﻿using Financeiro.DAO;
using Financeiro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebMatrix.WebData;

namespace Financeiro.Controllers
{
    public class UsuarioController : Controller
    {
        private UsuarioDAO usuarioDAO;

        public UsuarioController(UsuarioDAO usuarioDAO)
        {
            this.usuarioDAO = usuarioDAO;
        }

        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Adiciona(UsuarioModel model )
        {
            if (ModelState.IsValid)
            {
                try
                {
                    WebSecurity.CreateUserAndAccount(model.Nome, model.Senha, new { Email = model.Email});

                    return RedirectToAction("Index");
                }
                catch(MembershipCreateUserException e)
                {
                    ModelState.AddModelError("Usuario inválido", e.Message);
                    return View("Form", model);
                }               
            }
            else
            {
                return View("Form", model);
            }
        }

        public ActionResult Index()
        {
            IList<Usuario> usuarios = usuarioDAO.ListaUsuario();
            return View(usuarios);
        }
    }
}
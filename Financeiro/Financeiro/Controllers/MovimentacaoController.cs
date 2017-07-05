using Financeiro.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Financeiro.Controllers
{
    public class MovimentacaoController : Controller
    {
        private MovimentacaoDAO movimentacaoDAO;

        public MovimentacaoController(MovimentacaoDAO movimentacaoDAO)
        {
            this.movimentacaoDAO = movimentacaoDAO;
        }

        public ActionResult Form()
        {
            return View();
        }
    }
}
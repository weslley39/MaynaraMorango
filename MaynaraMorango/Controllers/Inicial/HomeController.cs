using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MaynaraMorango.Models.Home;
using MongoDAO.Repository;
using MongoDB.Bson;
using MongoDB.Driver;
using br.com.arcnet.spedstockweb.Models.Shared;

namespace MaynaraMorango.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        //private MongoCollection<HomeModal> _repository;
        private Repository<HomeModal> _repositorylucas;

        //public void conectar()
        //{
        //    var connectiomongo = ConfigurationManager.AppSettings["MongoDBConnection"];
        //    var dados = MongoDatabase.Create(connectiomongo);


        //    _repositorylucas = new Repository<HomeModal>();
        //    //_repositorylucas = dados.GetCollection<HomeModal>(typeof(HomeModal).Name);
        //}
        public HomeController(Repository<HomeModal> repositorylucas)
        {
            _repositorylucas = repositorylucas;
        }

        public HomeController():this(new Repository<HomeModal>())
        {
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Novousuario(HomeModal modal)
        {

            if (Request.IsAjaxRequest())
            {
                //ajax
            }
            try
            {
                string passwordFormat = "SHA1";
                if (String.IsNullOrEmpty(passwordFormat))
                    passwordFormat = "SHA1";
                string saltAndPassword = modal.Senha;
                string hashedPassword =
                    FormsAuthentication.HashPasswordForStoringInConfigFile(
                        saltAndPassword, passwordFormat);
                modal.Senha = hashedPassword;
                _repositorylucas.Insert(modal);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index",  "Home");
        }

        [HttpPost]
        public ActionResult Logarusuario(HomeModal modal)
        {
            string passwordFormat = "SHA1";
            if (String.IsNullOrEmpty(passwordFormat))
                passwordFormat = "SHA1";
            string saltAndPassword = modal.Senha;
            string hashedPassword =
                FormsAuthentication.HashPasswordForStoringInConfigFile(
                    saltAndPassword, passwordFormat);
            modal.Senha = hashedPassword;
            
            var lala = _repositorylucas.FindOne(x => x.Usuario.Equals(modal.Usuario) && x.Senha.Equals(modal.Senha));
            if (lala != null)
            {
                return RedirectToAction("Index", "Inicial");
            }
            return RedirectToAction("Index", "Home");
        }

    }
}

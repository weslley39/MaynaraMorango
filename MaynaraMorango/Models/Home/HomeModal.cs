using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc.Html;
using MongoDAO;
using MongoDAO.Attributes;

namespace MaynaraMorango.Models.Home
{
    [CollectionName ("Usuarios")]
    public class HomeModal : Entity
    {
        [Display(Name="Nome")]
        [Required(ErrorMessage = "Digite seu Nome")]
        public string Nome { get; set; }

        [Display(Name = "Usuario")]
        [Required(ErrorMessage = "Digite um nome de Usuario")]
        public string Usuario { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Digite uma Senha")]
        public string Senha { get; set; }

        [Display(Name = "Cep")]
        [Required(ErrorMessage = "Digite seu CEP")]
        public string CEP { get; set; }

        [Display(Name = "Endereco")]
        [Required(ErrorMessage = "Digite seu Endereço")]
        public string Logradouro { get; set; }

        [Display(Name = "Numero")]
        [Required(ErrorMessage = "Digite o numero de sua residência")]
        public string Numerolog { get; set; }

        [Display(Name = "Bairro")]
        [Required(ErrorMessage = "Digite seu Bairro")]
        public string Bairro { get; set; }

        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "Digite sua Cidade")]
        public string Cidade { get; set; }

        [Display(Name = "Ponto de Referencia")]
        public string Pontoreferencia { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Digite seu Email")]
        [EmailAddress(ErrorMessage = "Isso não se parece com um E-Mail válido")]
        public string Email { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Digite seu numero de Telefone")]
        public string Telefone { get; set; }

        [Display(Name = "Celular")]
        [Required(ErrorMessage = "Digite seu numero de Celular")]
        public string Celular { get; set; }
    }
}
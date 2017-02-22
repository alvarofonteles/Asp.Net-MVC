using NewPizarriaSys.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewPizarriaSys.UI.Web.Models
{
    public class ClienteModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage=" * Campo Obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage=" * Campo Obrigatório.")]
        //[RegularExpression(@"^[A-Za-z0-9]*\d+[A-Za-z0-9]*$", ErrorMessage="Somente números.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage=" * Campo Obrigatório.")]
        public string Email { get; set; }

        public ClienteModel()
        {

        }

        public ClienteModel(Cliente cliente)
        {
            Id = cliente.Id;
            Nome = cliente.Nome;
            Telefone = cliente.Telefone;
            Email = cliente.Email;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Treinamento_CRM_Educacional.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Cep { get; set; }
    }
}
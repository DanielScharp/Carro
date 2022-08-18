using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carro.Models
{
    public class ResultadoPost
    {
        public int Id { get; set; }
        public bool Sucesso { get; set; }
        public string Menssagem { get; set; }
    }
}
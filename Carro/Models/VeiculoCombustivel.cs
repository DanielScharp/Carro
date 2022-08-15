using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Carro.Models
{
    [Table("veiculo_combustivel")]
    public class VeiculoCombustivel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Veiculo> Veiculos { get; set; }
        
    }
}
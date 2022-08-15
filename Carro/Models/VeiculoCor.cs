using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Carro.Models
{
    [Table("veiculo_cor")]
    public class VeiculoCor
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Veiculo> Veiculos { get; set; }

    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Carro.Models
{
    [Table("veiculo_ocorrencia")]
    public class VeiculoOcorrencia
    {
        [Key]
        public int Id { get; set; }
        public int VeiculoId { get; set; }
        public string Obs { get; set; }
        public DateTime? Data { get; set; }

        [ForeignKey("VeiculoId")]
        public virtual Veiculo Marca { get; set; }
    }
}
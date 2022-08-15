using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Carro.Models
{
    [Table("veiculo")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        public string Marca { get; set; }
        public int CombustivelId { get; set; }
        public int CorId { get; set; }

        [ForeignKey("CorId")]
        public virtual VeiculoCor Cor { get; set; } 

        [ForeignKey("CombustivelId")]
        public virtual VeiculoCombustivel Combustivel { get; set; }


    }
}
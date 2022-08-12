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
        public string Combustivel { get; set; }
        public string Cor { get; set; }

    }
}
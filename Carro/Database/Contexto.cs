using System.Data.Entity;
using Carro.Models;


namespace Carro.Database
{
    public class Contexto : DbContext
    {
        public Contexto() : base("name=MySql")
        {
            //Arquivo ConnectionStrings.config
        }

        public DbSet<Veiculo> Veiculos { get; set; }

        public DbSet<VeiculoOcorrencia> VeiculoOcorrencias { get; set; }

    }
}
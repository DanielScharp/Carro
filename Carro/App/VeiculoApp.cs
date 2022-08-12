using Carro.Models;
using Carro.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carro.App
{
    public class VeiculoApp
    {
        public IEnumerable<Veiculo> Listar()
        {
            using ( var veiculos = new VeiculoRepositorio())
            {
                var lista = veiculos.GetAll().ToList();
                return lista;
            }


        }
        public IEnumerable<Veiculo> Listar(string combustivel)
        {
            using (var veiculos = new VeiculoRepositorio())
            {
                var lista = veiculos.GetAll().Where(x => x.Combustivel == combustivel).ToList();
                return lista;
            }


        }

        public Veiculo Retornar(int id)
        {
            using( var veiculo = new VeiculoRepositorio())
            {
                return veiculo.GetAll().Where(x => x.Id == id).FirstOrDefault();
            }
        }
    }
}
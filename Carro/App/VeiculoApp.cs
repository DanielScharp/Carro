using Carro.Models;
using Carro.Repositorios;
using System.Collections.Generic;
using System.Linq;

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
        public IEnumerable<Veiculo> Listar(int combustivel)
        {
            using (var veiculos = new VeiculoRepositorio())
            {
                var lista = veiculos.GetAll().Where(x => x.CombustivelId == combustivel).ToList();
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

        public void Salvar(Veiculo veiculo)
        {
            using (var veiculos = new VeiculoRepositorio())
            {
                veiculos.Adicionar(veiculo);
                veiculos.SalvarTodos();
            }
            
        }

        public Veiculo Alterar(Veiculo veiculo)
        {
            using (var veiculos = new VeiculoRepositorio())
            {
                veiculos.Atualizar(veiculo);
                veiculos.SalvarTodos();
            }
            return veiculo;

        }

        public List<VeiculoCombustivel> ListaCombustiveis()
        {
            using(var combustiveis = new VeiculoCombustivelRepositorio())
            {
                 return combustiveis.GetAll().ToList();
            }
        }

        public List<VeiculoCor> ListaCores()
        {
            using (var cores = new VeiculoCorRepositorio())
            {
                return cores.GetAll().ToList();
            }
        }

        public List<VeiculoOcorrencia> ListaOcorrencias()
        {
            using (var ocorrencias = new VeiculoOcorrenciaRepositorio())
            {
                return ocorrencias.GetAll().ToList();
            }
        }

        public List<VeiculoOcorrencia> ListaOcorrencias(int veiculoId)
        {
            using(var ocorrencias = new VeiculoOcorrenciaRepositorio())
            {
                return ocorrencias.GetAll().Where(x => x.VeiculoId == veiculoId).ToList();
            }
        }
    }
}
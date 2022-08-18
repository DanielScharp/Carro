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

        public List<VeiculoCor> ListarCores()
        {
            using (var cores = new VeiculoCorRepositorio())
            {
                return cores.GetAll().ToList();
            }
        }

        public List<VeiculoOcorrencia> ListaOcorrencias(int veiculoId)
        {
            using(var ocorrencias = new VeiculoOcorrenciaRepositorio())
            {
                return ocorrencias.GetAll().Where(x => x.VeiculoId == veiculoId).ToList();
            }
        }

        public void SalvarOcorrencia(VeiculoOcorrencia ocorrencia)
        {
            using(var conn = new VeiculoOcorrenciaRepositorio())
            {
                conn.Adicionar(ocorrencia);
                conn.SalvarTodos();
            }
        }

        public List<Veiculo> BuscarVeiculos(Veiculo veiculo)
        {
            using(var conexao = new VeiculoRepositorio())
            {
                
                return conexao.GetAll().Where(x => x.CombustivelId == veiculo.CombustivelId && x.CorId == veiculo.CorId).ToList();
                
            }
        }

    }
}
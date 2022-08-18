using Carro.App;
using Carro.Models;
using System;
using System.Web.Mvc;

namespace Carro.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly VeiculoApp _veiculoApp = new VeiculoApp();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RetornarVeiculo(int id = 0)
        {
            var veiculo = new Veiculo();
            if(id > 0)
            {
                veiculo = _veiculoApp.Retornar(id);
            }
            ViewBag.ListarCombustiveis = new VeiculoApp().ListaCombustiveis(); 
            ViewBag.ListarCores = new VeiculoApp().ListarCores(); 
            return View("_RetornarVeiculo", veiculo);

        }

        public ActionResult ListarVeiculos()
        {
            var lista = _veiculoApp.Listar();
            return View("_ListarVeiculos", lista);
        }

        public ActionResult SalvarVeiculo(Veiculo veiculo)
        {
            try
            {
                /*if(veiculo.CombustivelId == 0 )
                {
                    return Json(new ResultadoPost() { Id = veiculo.Id, Sucesso = false, Menssagem = "Informe o combustivel" }, JsonRequestBehavior.AllowGet);
                }*/
                if (veiculo.Id == 0)
                {
                    _veiculoApp.Salvar(veiculo);
                }
                else
                {
                    _veiculoApp.Alterar(veiculo);

                }
                return Json(new ResultadoPost() { Id = veiculo.Id, Sucesso = true, Menssagem = "Operação efetuada com sucesso!" }, JsonRequestBehavior.AllowGet);
            } catch //(Exception ex) ------> capturar o erro
            {
                return Json(new ResultadoPost() { Id = veiculo.Id, Sucesso = false, Menssagem = "erro ao efetuar a operação" }, JsonRequestBehavior.AllowGet);

            }

        }
    }
}
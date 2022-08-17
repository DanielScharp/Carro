using System.Web.Mvc;
using Carro.App;
using Carro.Models;

namespace Carro.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var lista = new VeiculoApp().Listar();
            return View(lista);
        }

        public ActionResult Veiculo(int id = 0)
        {
            var veiculo = new Veiculo();

            if (id > 0 ) 
            {
            veiculo = new VeiculoApp().Retornar(id);
            }

            var combustiveis = new VeiculoApp().ListaCombustiveis();
            ViewBag.ListarCombustiveis = combustiveis;
            ViewBag.ListarCores = new VeiculoApp().ListaCores();
            

            return View(veiculo);
        }

        public ActionResult BuscaVeiculo(Veiculo busca)
        {
            var veiculo = new VeiculoApp().BuscarVeiculos(busca);
            return View("Index", veiculo);

        }

 

        [HttpPost]
        public ActionResult SalvarOcorrencia(VeiculoOcorrencia ocorrencia)
        {
            new VeiculoApp().SalvarOcorrencia(ocorrencia);
            return Json("ok", JsonRequestBehavior.AllowGet);
        }

        public ActionResult ListarVeiculos()
        {
            var listar = new VeiculoApp().Listar();
            return View(listar);
        }

        public ActionResult ListarOcorrencias(int id)
        {
            var listar = new VeiculoApp().ListaOcorrencias(id);
            return View(listar);

        }

        public ActionResult SalvarVeiculo(Veiculo veiculo)
        {
            if(veiculo.Id == 0)
            {
                new VeiculoApp().Salvar(veiculo);
            } else
            {
                new VeiculoApp().Alterar(veiculo);
            }

            return Json("ok", JsonRequestBehavior.AllowGet);
        }
    }
}
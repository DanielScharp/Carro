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
            ViewBag.ListarOcorrencias = new VeiculoApp().ListaOcorrencias(id);

            return View(veiculo);
        }

        [HttpPost]
        public ActionResult Veiculo(Veiculo veiculo)
        {
            if (veiculo.Id == 0)
            {
                new VeiculoApp().Salvar(veiculo);
            } else
            {
                new VeiculoApp().Alterar(veiculo);            
            }


           
            //Atualizar e permanecer na mesma pagina
            return RedirectToAction("Veiculo", "Home", new { Id = veiculo.Id });

            //Direciona para outra pagina
            //return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult SalvarOcorrencia(VeiculoOcorrencia ocorrencia)
        {
            new VeiculoApp().SalvarOcorrencia(ocorrencia);
            return RedirectToAction("Veiculo", "Home", new { Id = ocorrencia.VeiculoId });
        }
    }
}
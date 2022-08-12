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

            return View(veiculo);
        }
    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_TP.Services;

namespace MVC_TP.Controllers
{
    public class ComidaController : Controller
    {
        protected readonly Repositorio repositorio = new Repositorio();
        // GET: AlunosController
        public ActionResult Index()
        {
            return View(repositorio.GetComidas());
        }

        // GET: AlunosController/Details/5
        public ActionResult Details(int id)
        {
            return View(repositorio.GetComidaByID(id));
        }
    }
}

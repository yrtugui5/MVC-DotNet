using Microsoft.AspNetCore.Mvc;
using MVC_TP.Models;
using MVC_TP.Services;

namespace MVC_TP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiComidasController : ControllerBase
    {
        protected readonly Repositorio repo = new Repositorio();
        // GET: api/<ApiComidasController>
        [HttpGet]
        public IEnumerable<Comida> Get()
        {
            return repo.GetComidas();
        }
    }
}

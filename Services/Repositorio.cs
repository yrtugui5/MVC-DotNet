using MVC_TP.Models;

namespace MVC_TP.Services
{
    public class Repositorio
    {
        private List<Comida> comidas = new List<Comida>();

        public Repositorio()
        {
            comidas.Add(new Comida { id = 1,Nome = "Bolo de Cenoura",PaisOrigem = "Brasil",Tipo = "Doce"});
            comidas.Add(new Comida { id = 2, Nome = "Croissant", PaisOrigem = "France",Tipo = "Salgado" });
            comidas.Add(new Comida { id = 3, Nome = "Cheesecake", PaisOrigem = "Greece",Tipo = "Doce" });
        }
        public List<Comida> GetComidas() { return comidas; }
        public Comida? GetComidaByID(int id) { return comidas.FirstOrDefault(comida => comida.id == id); }
    }
}

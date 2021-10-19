using System.Collections.Generic;
using System.Linq;
using CorujinhaModelo.Dominio;
using CorujinhaModelo.Dominio.Repositorios;

namespace CorujinhaModelo.Repositorio
{
    public class IngredienteRepositorio : IIngredienteRepositorio
    {
        private readonly IList<Ingrediente> _lista;

        public IngredienteRepositorio()
        {
            _lista = new List<Ingrediente>();
        }

        public void Inserir(Ingrediente ingrediente)
        {
            _lista.Add(ingrediente);
        }

        public List<Ingrediente> ObterTodos()
        {
            return _lista.ToList();
        }
    }
}

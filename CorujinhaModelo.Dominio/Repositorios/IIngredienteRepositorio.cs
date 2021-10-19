using System.Collections.Generic;

namespace CorujinhaModelo.Dominio.Repositorios
{
    public interface IIngredienteRepositorio
    {
        void Inserir(Ingrediente ingrediente);
        List<Ingrediente> ObterTodos();
    }
}

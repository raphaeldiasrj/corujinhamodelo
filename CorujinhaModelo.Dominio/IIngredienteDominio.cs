using System.Collections.Generic;

namespace CorujinhaModelo.Dominio
{
    public interface IIngredienteDominio
    {
        void Criar(Ingrediente ingrediente);
        List<Ingrediente> ObterTodos();
    }
}

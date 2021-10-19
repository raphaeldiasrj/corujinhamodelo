using System.Collections.Generic;
using CorujinhaModelo.Dominio.Repositorios;

namespace CorujinhaModelo.Dominio
{
    public class IngredienteDominio : IIngredienteDominio
    {
        private readonly IIngredienteRepositorio _ingredienteRepositorio;

        public IngredienteDominio(IIngredienteRepositorio ingredienteRepositorio)
        {
            _ingredienteRepositorio = ingredienteRepositorio;
        }

        public void Criar(Ingrediente ingrediente)
        {
            //validações de banco e não de modelo...
            //regras de negocio de disparo de email, por exemplo...

            _ingredienteRepositorio.Inserir(ingrediente);
        }

        public List<Ingrediente> ObterTodos()
        {
            return _ingredienteRepositorio.ObterTodos();
        }
    }
}

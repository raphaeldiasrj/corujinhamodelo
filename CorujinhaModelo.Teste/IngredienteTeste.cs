using System;
using System.Collections.Generic;
using CorujinhaModelo.Dominio;
using CorujinhaModelo.Repositorio;
using Xunit;

namespace CorujinhaModelo.Teste
{
    public class IngredienteTeste
    {
        [Fact]
        public void Deve_cadastrar_ingrediente_com_sucesso()
        {
            var ingrediente = new Ingrediente
            {
                Id = Guid.NewGuid(),
                Itens = new List<Item>
                {
                    new Item
                    {
                        Id = Guid.NewGuid(), Nome = "Leite", Validade = new DateTime(2021, 12, 01),
                        Fornecedor = new Fornecedor
                            {Contato = "(21)123456788", Nome = "Zé Delivery do leite", Id = Guid.NewGuid()}
                    },
                    new Item
                    {
                        Id = Guid.NewGuid(), Nome = "Fermento", Validade = new DateTime(2021, 12, 01),
                        Fornecedor = new Fornecedor
                            {Contato = "(21)123456788", Nome = "Zé Delivery do fermento", Id = Guid.NewGuid()}
                    }
                },
                Nome = "Leite fermentado"
            };

            var repositorio = new IngredienteRepositorio();
            repositorio.Inserir(ingrediente);

            Assert.Single(repositorio.ObterTodos());
        }

        [Fact]
        public void Deve_obter_todos_ingredientes_cadastrados()
        {
            var ingrediente1 = new Ingrediente();
            var ingrediente2 = new Ingrediente();
            var ingrediente3 = new Ingrediente();

            var repositorio = new IngredienteRepositorio();
            repositorio.Inserir(ingrediente1);
            repositorio.Inserir(ingrediente2);
            repositorio.Inserir(ingrediente3);


            var lista = repositorio.ObterTodos();

            Assert.Equal(3, lista.Count);
        }

    }
}

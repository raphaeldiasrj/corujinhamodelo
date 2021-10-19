using System;
using System.Collections.Generic;
using CorujinhaModelo.Dominio;
using CorujinhaModelo.Dominio.Repositorios;
using CorujinhaModelo.Repositorio;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace CorujinhaModelo.Teste
{
    public class IngredienteTeste
    {
        private readonly ServiceProvider _serviceProvider;
        public IngredienteTeste()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<IIngredienteRepositorio, IngredienteRepositorio>();
            serviceCollection.AddTransient<IIngredienteDominio, IngredienteDominio>();

            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

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

            var dominio = _serviceProvider.GetService<IIngredienteDominio>();
            dominio.Criar(ingrediente);

            Assert.Single(dominio.ObterTodos());
        }

        [Fact]
        public void Deve_obter_todos_ingredientes_cadastrados()
        {
            var ingrediente1 = new Ingrediente();
            var ingrediente2 = new Ingrediente();
            var ingrediente3 = new Ingrediente();

            var dominio = _serviceProvider.GetService<IIngredienteDominio>();
            dominio.Criar(ingrediente1);
            dominio.Criar(ingrediente2);
            dominio.Criar(ingrediente3);


            var lista = dominio.ObterTodos();

            Assert.Equal(3, lista.Count);
        }

    }
}

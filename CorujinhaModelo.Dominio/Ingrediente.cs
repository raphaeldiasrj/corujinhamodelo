using System;
using System.Collections.Generic;

namespace CorujinhaModelo.Dominio
{
    public class Ingrediente : EntidadeBase<Guid>
    {
        public string Nome { get; set; }
        public List<Item> Itens { get; set; }
    }
}

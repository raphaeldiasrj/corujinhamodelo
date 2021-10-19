using System;

namespace CorujinhaModelo.Dominio
{
    public class Fornecedor : EntidadeBase<Guid>
    {
        public string Nome { get; set; }
        public string Contato { get; set; }
    }
}

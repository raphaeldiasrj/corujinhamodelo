using System;

namespace CorujinhaModelo.Dominio
{
    public class Item : EntidadeBase<Guid>
    {
        public string Nome { get; set; }
        public DateTime Validade { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}

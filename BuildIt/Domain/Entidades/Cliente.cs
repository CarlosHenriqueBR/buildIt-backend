using System.Collections.Generic;
using Domain.Entidades.Base;

namespace Domain.Entidades
{
    public class Cliente : EntityBase
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string CpfCnpj { get; set; }

        public int TipoClienteId { get; set; }
        public TipoCliente TipoCliente { get; set; }

        public ICollection<CaixaEletronica> CaixaEletronica { get; set; }
    }
}
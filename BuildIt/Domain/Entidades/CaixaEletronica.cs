using System.Collections.Generic;
using Domain.Entidades.Base;

namespace Domain.Entidades
{
    public class CaixaEletronica : EntityBase
    {
        public decimal Valor { get; set; }
        public int QuantidadeNotas { get; set; }

        public int NotasId { get; set; }
        public Notas Notas { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public ICollection<Saque> Saque { get; set; }
    }
}
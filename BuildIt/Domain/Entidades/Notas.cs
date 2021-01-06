using System.Collections.Generic;
using System.Reflection.Metadata;
using Domain.Entidades.Base;

namespace Domain.Entidades
{
    public class Notas : EntityBase
    {
        public decimal ValorNota { get; set; }
        public bool Disponivel { get; set; }
        public ICollection<CaixaEletronica> CaixaEletronicas { get; set; }
        public ICollection<NotasSugerida> NotasSugeridas { get; set; }
    }
}
using System;
using System.Collections.Generic;
using Domain.Entidades.Base;

namespace Domain.Entidades
{
    public class Saque : EntityBase
    {
        public Guid CodigoSaque { get; set; }
        public DateTime DataSaque { get; set; } = DateTime.Now;
        public ICollection<CaixaEletronica> CaixaEletronica { get; set; }
    }
}
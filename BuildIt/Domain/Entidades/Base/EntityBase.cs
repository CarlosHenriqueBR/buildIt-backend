using System;

namespace Domain.Entidades.Base
{
    public class EntityBase
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public bool Ativo { get; set; } = true;
    }
}
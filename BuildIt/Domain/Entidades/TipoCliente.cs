using Domain.Entidades.Base;

namespace Domain.Entidades
{
    public class TipoCliente : EntityBase
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
    }
}
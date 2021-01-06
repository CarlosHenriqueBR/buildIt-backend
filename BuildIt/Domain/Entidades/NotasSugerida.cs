using System;
using Domain.Entidades.Base;

namespace Domain.Entidades
{
    public class NotasSugerida : EntityBase
    {
        public NotasSugerida(decimal valorNotaSugerida, int notasId)
        {
            ValorNotaSugerida = valorNotaSugerida;
            NotasId = notasId;
        }
        public NotasSugerida(int id, bool ativo, DateTime dataCadastro, decimal valorNotaSugerida, int notasId)
        {
            Id = id;
            Ativo = ativo;
            DataCadastro = dataCadastro;
            ValorNotaSugerida = valorNotaSugerida;
            NotasId = notasId;
        }

        public decimal ValorNotaSugerida { get; set; }
        
        public int NotasId { get; set; }
        public Notas Notas { get; set; }
    }
}

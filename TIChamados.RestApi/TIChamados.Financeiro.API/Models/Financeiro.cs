using System;

namespace TIChamados.Financeiro.API.Models
{
    public class Financeiro
    {        
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVecimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public Guid ChamadoId { get; set; }        

        public DateTime CreatedAt { get; set; }
    }
}

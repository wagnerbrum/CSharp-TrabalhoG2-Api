using System;

namespace Proj.Domain.Entities
{
    public class ContaLuz : Entity
    {
        public ContaLuz() { }

        public ContaLuz(DateTime dataLeitura, DateTime dataPagamento, int kwGasto, double valorAPagar, double mediaConsumo, int idimovel, Imovel imovel)
        {
            this.dataLeitura = dataLeitura;
            this.dataPagamento = dataPagamento;
            this.kwGasto = kwGasto;
            this.valorAPagar = valorAPagar;
            this.mediaConsumo = mediaConsumo;
            this.idimovel = idimovel;
            this.imovel = imovel;
        }

        public DateTime dataLeitura { get; set; }
        public DateTime dataPagamento { get; set; }
        public int kwGasto { get; set; }
        public double valorAPagar { get; set; }
        public double mediaConsumo { get; set; }
        public int idimovel { get; set; }
        public Imovel imovel { get; set; }
    }
}
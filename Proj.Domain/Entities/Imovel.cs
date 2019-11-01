using System.Collections.Generic;

namespace Proj.Domain.Entities
{
    public class Imovel : Entity
    {
        public Imovel() { }
        public Imovel(int id, string identificacao, string numero, string bairro, string cidade, string estado, List<ContaLuz> contasLuz)
        {
            this.id = id;
            this.identificacao = identificacao;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.contasLuz = contasLuz;
        }

        public string identificacao { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public ICollection<ContaLuz> contasLuz { get; set; }
    }
}
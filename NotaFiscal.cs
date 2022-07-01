using System;

namespace Linq
{
    public class NotaFiscal
    {
        public int Id { get; set; }
        public DateTime DataEmissao { get; set; }
        public TipoFreteEnum TipoFrete { get; set; }
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public StatusEnum Status { get; set; }
        public override string ToString()
        {
            return Id + ", " + DataEmissao + ", " + TipoFrete + ", " + IdCliente + ", " + Status;
        }
    }
}

using System;
using System.Text;

namespace Linq
{
    public class ItensNotaFiscal
    {
        public int Id { get; set; }
        public int IdNotaFiscal { get; set; }
        public NotaFiscal NotaFiscal { get; set; }
        public int IdProduto { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal Total { get; set; }

        public decimal ValorVendido()
        {
            return Total = Quantidade * PrecoUnitario;
        }

        public override string ToString()
        {
            return($"{Produto} {Quantidade} {PrecoUnitario} {ValorVendido()}");
        }
    }
}

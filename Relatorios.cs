using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Relatorios : NotaFiscal
    {
        public NotaFiscal NotaFiscal { get; set; }
        public Cliente Cliente { get; set; }

        public override string ToString()
        {
            var relatorio = ($"********* Pedido {Id} - Emitido em: {DataEmissao:dd/MM/yyyy HH:mm:ss} - Tipo de Frete: {TipoFrete} - Status: {Status}\n--------------- Itens do pedido ---------------\nProduto".PadRight(25) + " qtde.".PadRight(10) + " Valor unitario".PadRight(25) + " Total".PadRight(15));
            return relatorio.ToString();
        }
    }
}

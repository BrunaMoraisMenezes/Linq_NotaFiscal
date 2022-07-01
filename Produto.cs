using System;
using System.Collections.Generic;

namespace Linq
{
    public class Produto
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }

        public override string ToString()
        {
            return NomeProduto;
        }
    }
}

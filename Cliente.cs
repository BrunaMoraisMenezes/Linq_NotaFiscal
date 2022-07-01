using System;

namespace Linq
{
    public class Cliente
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }

        public Cliente()
        {
        }

        public Cliente(int idCliente, string nomeCliente)
        {
            Id = idCliente;
            NomeCliente = nomeCliente;
        }
        public override string ToString()
        {
            return ($"Cliente: {Id} - {NomeCliente}");
        }
    }
}

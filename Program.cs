using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>()
            {
                new Cliente() { Id = 1, NomeCliente = "Pedro" },
                new Cliente() { Id = 2, NomeCliente = "Antonio" },
                new Cliente() { Id = 3, NomeCliente = "João" },
                new Cliente() { Id = 4, NomeCliente = "Rafael" },
                new Cliente() { Id = 5, NomeCliente = "Bruna" },
                new Cliente() { Id = 6, NomeCliente = "Milena" },
                new Cliente() { Id = 7, NomeCliente = "Fabio" },
                new Cliente() { Id = 8, NomeCliente = "Dafine" },
                new Cliente() { Id = 9, NomeCliente = "Leila" },
                new Cliente() { Id = 10, NomeCliente = "Eduarda" }
            };

            List<Produto> produtos = new List<Produto>()
            {
                new Produto() { Id = 1, NomeProduto = "Manga" },
                new Produto() { Id = 2, NomeProduto = "Kiwi" },
                new Produto() { Id = 3, NomeProduto = "Uva" },
                new Produto() { Id = 4, NomeProduto = "Banana" },
                new Produto() { Id = 5, NomeProduto = "Tomate" },
                new Produto() { Id= 6, NomeProduto = "Laranja" },
                new Produto() { Id = 7, NomeProduto = "Pepino" },
                new Produto() { Id = 8, NomeProduto = "Rucula" },
                new Produto() { Id = 9, NomeProduto = "Escarola" },
                new Produto() { Id = 10, NomeProduto = "Abacaxi" },
            };

            List<NotaFiscal> notas = new List<NotaFiscal>()
            {
                new NotaFiscal() { Id = 1, DataEmissao = new DateTime(2022, 03, 13), TipoFrete = TipoFreteEnum.Cif, IdCliente = clientes[0].Id, Status = StatusEnum.Ativo },
                new NotaFiscal() { Id = 2, DataEmissao = new DateTime(2022, 04, 12), TipoFrete = TipoFreteEnum.Fob, IdCliente = clientes[1].Id, Status = StatusEnum.Cancelado },
                new NotaFiscal() { Id = 3, DataEmissao = new DateTime(2022, 05, 11), TipoFrete = TipoFreteEnum.Cif, IdCliente = clientes[2].Id, Status = StatusEnum.Faturado },
                new NotaFiscal() { Id = 4, DataEmissao = new DateTime(2022, 06, 10), TipoFrete = TipoFreteEnum.Cif, IdCliente = clientes[3].Id, Status = StatusEnum.Ativo },
                new NotaFiscal() { Id = 5, DataEmissao = new DateTime(2022, 07, 09), TipoFrete = TipoFreteEnum.Fob, IdCliente = clientes[4].Id, Status = StatusEnum.Faturado },
                new NotaFiscal() { Id = 6, DataEmissao = new DateTime(2022, 08, 08), TipoFrete = TipoFreteEnum.Cif, IdCliente = clientes[5].Id, Status = StatusEnum.Faturado },
                new NotaFiscal() { Id = 7, DataEmissao = new DateTime(2022, 09, 07), TipoFrete = TipoFreteEnum.Fob, IdCliente = clientes[6].Id, Status = StatusEnum.Ativo },
                new NotaFiscal() { Id = 8, DataEmissao = new DateTime(2022, 10, 06), TipoFrete = TipoFreteEnum.Cif, IdCliente = clientes[7].Id, Status = StatusEnum.Cancelado },
                new NotaFiscal() { Id = 9, DataEmissao = new DateTime(2022, 11, 05), TipoFrete = TipoFreteEnum.Fob, IdCliente = clientes[8].Id, Status = StatusEnum.Faturado },
                new NotaFiscal() { Id = 10, DataEmissao = new DateTime(2022, 12, 04), TipoFrete = TipoFreteEnum.Cif, IdCliente = clientes[9].Id, Status = StatusEnum.Faturado }
             };

            List<ItensNotaFiscal> itens = new List<ItensNotaFiscal>()
            {
                new ItensNotaFiscal() { Id = 1, IdNotaFiscal = notas[0].Id, IdProduto = produtos[0].Id, PrecoUnitario = 3.40M, Quantidade = 5 },
                new ItensNotaFiscal() { Id = 2, IdNotaFiscal = notas[1].Id, IdProduto = produtos[1].Id, PrecoUnitario = 3.40M, Quantidade = 5 },
                new ItensNotaFiscal() { Id = 3, IdNotaFiscal = notas[2].Id, IdProduto = produtos[2].Id, PrecoUnitario = 5.60M, Quantidade = 6 },
                new ItensNotaFiscal() { Id = 4, IdNotaFiscal = notas[3].Id, IdProduto = produtos[3].Id, PrecoUnitario = 9.80M, Quantidade = 4 },
                new ItensNotaFiscal() { Id = 5, IdNotaFiscal = notas[4].Id, IdProduto = produtos[4].Id, PrecoUnitario = 2.90M, Quantidade = 12 },
                new ItensNotaFiscal() { Id = 6, IdNotaFiscal = notas[5].Id, IdProduto = produtos[5].Id, PrecoUnitario = 7.40M, Quantidade = 8 },
                new ItensNotaFiscal() { Id = 7, IdNotaFiscal = notas[6].Id, IdProduto = produtos[6].Id, PrecoUnitario = 6.60M, Quantidade = 2 },
                new ItensNotaFiscal() { Id = 8, IdNotaFiscal = notas[7].Id, IdProduto = produtos[7].Id, PrecoUnitario = 1.20M, Quantidade = 7 },
                new ItensNotaFiscal() { Id = 9, IdNotaFiscal = notas[8].Id, IdProduto = produtos[8].Id, PrecoUnitario = 4.78M, Quantidade = 4 },
                new ItensNotaFiscal() { Id = 10, IdNotaFiscal = notas[9].Id, IdProduto = produtos[9].Id, PrecoUnitario = 5.30M, Quantidade = 9 }
            };

            var quantidadeFaturadas = notas.Where(n => n.Status == StatusEnum.Faturado).Count();
            Console.WriteLine("QUANTAS NOTAS FISCAIS FORAM FATURADAS: " + quantidadeFaturadas);

            var quantidadeCanceladas = notas.Where(n => n.DataEmissao == DateTime.Today).Count();
            if (quantidadeCanceladas != 0)

                Console.WriteLine("QUANTAS NOTAS FISCAIS CANCELADAS NO DIA: " + quantidadeCanceladas);
            else
                Console.WriteLine("QUANTAS NOTAS FISCAIS CANCELADAS NO DIA: Não houve cancelamentos de notas");

            var primeiraNotaFiscalAtiva = notas.Where(n => n.Status == StatusEnum.Ativo).OrderBy(n => n.DataEmissao).FirstOrDefault();
            Console.WriteLine("QUAL É A DATA E HORA DA PRIMEIRA NOTA FISCAL ATIVA: " + primeiraNotaFiscalAtiva);

            var quantidadeUnidades = notas.Where(n => n.TipoFrete == TipoFreteEnum.Cif && n.Status == StatusEnum.Faturado).Count();
            Console.WriteLine("QUANTAS UNIDADES DE PRODUTOS FORAM VENDIDAS NAS NOTAS COM TIPO DE FRETE CIF E FORAM FATURADAS: " + quantidadeUnidades);

            var valorFaturado = notas
                .Join(itens, x => x.Id, y => y.IdNotaFiscal, (x, y) => new { x, y })
                .Where(n => n.x.TipoFrete == TipoFreteEnum.Fob && n.x.Status == StatusEnum.Faturado)
                .Sum(n => n.y.ValorVendido());
            Console.WriteLine("QUAL O VALOR VENDIDO COM AS NOTAS COM TIPO DE FRETE FOB: " + valorFaturado);

            var quantidadeAbacaxi = produtos.Where(n => n.NomeProduto.Contains("Abacaxi")).Count();
            Console.WriteLine("QUANTOS ABACAXIS FORAM VENDIDOS: " + quantidadeAbacaxi);

            var lucroFaturado = notas
                .Join(itens, x => x.Id, y => y.IdNotaFiscal, (x, y) => new { x, y })
                .Join(produtos, z => z.y.IdProduto, p => p.Id, (z, p) => new { z, p })
                .Where(n => n.p.NomeProduto.Contains("Abacaxi") || n.p.NomeProduto.Contains("Laranja"))
                .Sum(n => n.z.y.ValorVendido());
            Console.WriteLine("QUAL FOI O LUCRO TOTAL DE ABACAXI E LARANJA: " + lucroFaturado);

            for (int i = 0; i < notas.Count(); i++)
            {
                    Console.WriteLine($"********** Pedido {notas[i].Id} - Emitido em: {notas[i].DataEmissao:dd/MM/yyyy} - Tipo de Frete: {notas[i].TipoFrete} - Situação: {notas[i].Status} **********");
                    Console.WriteLine($"Cliente: {clientes[i].Id}  - {clientes[i].NomeCliente}");
                    Console.WriteLine("---------------Itens do pedido--------------------");
                    Console.WriteLine("Produto                  qtde.     valor unit.           total");
                    Console.WriteLine(produtos[i].NomeProduto + "              " + itens[i].Quantidade + "     " + itens[i].PrecoUnitario + "           " + itens[i].ValorVendido());
                    Console.WriteLine();
            }
        }
    }
}
using Semana06.Modulos;
using Semana07.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana06.Class
{
    internal class ManutencaoItemProduto : Menu
    {
        //CRIANÇÃO DA LISTA
        private List<ItemDePedido> itemDePedidos;

        //CONSTRUTOR
        public ManutencaoItemProduto(List<ItemDePedido> itemDePedidos)
        {
            this.itemDePedidos = itemDePedidos ?? new List<ItemDePedido>();
        }

        public void Cadastra()
        {
            Console.Clear();
            ExibirLogo();
            Console.WriteLine("\nDigite o nome do produto: ");
            string nomeProduto = Console.ReadLine();      
            Console.WriteLine("Digite a quantidade: ");
            string quantidadeProdutoStr = Console.ReadLine();
            int quantidadeProduto = int.Parse(quantidadeProdutoStr);
            Console.WriteLine("Digite o preço: ");
            string precoProdutoStr = Console.ReadLine();
            decimal precoProduto = decimal.Parse(precoProdutoStr);

            ItemDePedido produto = new ItemDePedido(nomeProduto, quantidadeProduto, precoProduto);
            itemDePedidos.Add(produto);
            Console.WriteLine($"O produto {nomeProduto} foi incluído com sucesso!");
            Console.WriteLine("Aperte qualquer tecla para voltar!");
            Console.ReadKey();
        }

        public void Lista()
        {
            Console.Clear();
            ExibirLogo();
            Console.WriteLine("\nProdutos cadastrados:\n");
            itemDePedidos.ForEach(p => Console.WriteLine($"{p.Nome} - {p.Quantidade} - {p.PrecoUnitario:C} - {p.Subtotal:C}"));
            Console.WriteLine("\nAperte qualquer tecla para voltar!");
            Console.ReadKey();
            Console.Clear();
            ExibirLogo();
            ExibirMenu();
        }

    }
}
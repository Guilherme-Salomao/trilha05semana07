using Semana07.Classes;
using System;
using System.Collections.Generic;

namespace Semana07.Modulos
{
    internal class Pedido
    {
        public Cliente Cliente { get; set; }
        public DateTime Data { get; set; }
        public List<ItemDePedido> Itens { get; set; }
        public decimal Total
        {
            get
            {
                decimal total = 0;
                foreach (var item in Itens)
                {
                    total += item.Subtotal; // Supondo que ItemDePedido tenha uma propriedade Subtotal
                }
                return total;
            }
        }
        public Pedido(Cliente cliente, DateTime data, List<ItemDePedido> itens)
        {
            Cliente = cliente;
            Data = data;
            Itens = itens ?? new List<ItemDePedido>();
        }


        public void ExibirPedido()
        {
            Console.WriteLine($"Cliente: {Cliente.Nome}");
            Console.WriteLine($"Data do Pedido: {Data}");
            Console.WriteLine("Itens:");
            foreach (var item in Itens)
            {
                Console.WriteLine($"{item.Nome} - {item.Quantidade} x {item.PrecoUnitario:C} = {item.Subtotal:C}");
            }
            Console.WriteLine($"Total do Pedido: {Total:C}");
        }

        public void AdicionarItem(ItemDePedido item)
        {
            Itens.Add(item);
        }

        public void RemoverItem(ItemDePedido item)
        {
            Itens.Remove(item);
        }
    }
}

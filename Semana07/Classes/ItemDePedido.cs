using Semana06.Modulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana07.Classes
{
    internal class ItemDePedido : Produto
    {
        public Produto Produto;
        public int Quantidade {  get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal Subtotal { get; set; }

        //Construtor
        public ItemDePedido(string nome, int quantidade, decimal precoUnitario) : base(nome)
        {
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
            Subtotal = quantidade * precoUnitario;
        }

        public string ObterItemProduto()
        {
            return $"Nome do Produto: {Nome}, Preço Unitário: {PrecoUnitario} -- Quantidade: {Quantidade} -- Valor Total: {Subtotal}";
        }

    }
}

using System;
using System.Collections.Generic;
using Semana06.Class;

namespace Semana07.Classes
{
    internal class Menu
    {
        public void ExibirLogo()
        {
            Console.WriteLine(@"
░██████╗███████╗███╗░░░███╗░█████╗░███╗░░██╗░█████╗░  ░█████╗░███████╗
██╔════╝██╔════╝████╗░████║██╔══██╗████╗░██║██╔══██╗  ██╔══██╗╚════██║
╚█████╗░█████╗░░██╔████╔██║███████║██╔██╗██║███████║  ██║░░██║░░░░██╔╝
░╚═══██╗██╔══╝░░██║╚██╔╝██║██╔══██║██║╚████║██╔══██║  ██║░░██║░░░██╔╝░
██████╔╝███████╗██║░╚═╝░██║██║░░██║██║░╚███║██║░░██║  ╚█████╔╝░░██╔╝░░
╚═════╝░╚══════╝╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝  ░╚════╝░░░╚═╝░░░");
        }

        //LISTAS CRIADAS
        private List<ItemDePedido> itemDePedidos = new List<ItemDePedido>();


        public void ExibirMenu()
        {
            while (true)
            {
                Console.Clear();
                ExibirLogo();
                Console.WriteLine("\nDigite 1 para registrar um Produto");
                Console.WriteLine("Digite 2 para listar os Produtos");
                Console.WriteLine("Digite -1 para sair");
                Console.Write("\nDigite a sua opção: ");
                string opcaoEscolhida = Console.ReadLine();
                int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

                switch (opcaoEscolhidaNumerica)
                {
                    case 1:
                        ManutencaoItemProduto cadastraProduto = new ManutencaoItemProduto(itemDePedidos);
                        cadastraProduto.Cadastra();
                        break;
                    case 2:
                        ManutencaoItemProduto listaProduto = new ManutencaoItemProduto(itemDePedidos);
                        listaProduto.Lista();
                        break;
                    case -1:
                        Console.WriteLine("Tchau tchau :)");
                        return;
                    default:
                        Console.WriteLine("Opção inválida");
                        Console.ReadKey();
                        break;
                }
            }
        }

    }
}

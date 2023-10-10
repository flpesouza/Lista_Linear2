using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade = 0;
            double preco = 0;
            int tamanho = 10;
            int opcao = 0;

            Lista lista = new Lista(tamanho);

            while (opcao != 5)
            {
                Console.WriteLine("1. Inserir um produto no final da lista\n2. Remover um produto específico da lista. Adicione na classe Lista um método para remover um elemento específico. O método deverá receber o nome do produto e deverá retornar o objeto Produto, ou null (caso o produto não conste na lista): Produto RemoverItem(string nome)\n3. Listar os dados de todos os produtos\n4. Pesquisar se um produto já consta na Lista. Adicione na classe Lista um método para pesquisar um elemento específico. O método deverá receber o nome do produto: bool Pesquisar(string nome)\n5)Sair.\nDigite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do produto: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite a quantidade: ");
                        quantidade = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o preço: ");
                        preco = double.Parse(Console.ReadLine());
                        Produto produto = new Produto(nome, quantidade, preco);
                        lista.InserirFim(produto);
                        break;
                    case 2:
                        Console.WriteLine("Digite o nome do produto: ");
                        nome = Console.ReadLine();
                        if (lista.RemoverItem(nome) != null)
                        {
                            Console.WriteLine("Item removido: " + lista.RemoverItem(nome));
                        }
                        else
                        {
                            Console.WriteLine("Item não encontrado");
                        }
                        break;
                    case 3:
                        lista.Mostrar();
                        break;
                    case 4:
                        Console.WriteLine("Digite o nome que deseja pesquisar: ");
                        nome = Console.ReadLine();
                        Console.WriteLine("Item encontrado: "+lista.Pesquisar(nome));
                        break;
                    case 5:
                        Console.WriteLine("FIM");
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01H___Tipo_Valor__Tipo_Referência_e_Tipos_Anônimos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value types
            int contador1 = 0;
            IncrementaContadorPorValor(contador1); ;
            Console.WriteLine($"Valor de contador1: {contador1.ToString()}");

            // Reference types
            DateTime data1 = new DateTime(2020, 8, 15);
            IncrementaMes(ref data1);
            Console.WriteLine($"Valor de data1: {data1.ToString()}");

            // Nullable value
            int? contador2 = 0;
            IncrementaContadorPorValor(contador2.Value); ;
            Console.WriteLine($"Valor de contador2: {contador2.ToString()}");

            // Tipos anônimos
            var cliente = new { Codigo = 1, Nome = "John" };
            Console.WriteLine($"Cliente - Código: {cliente.Codigo} Nome: {cliente.Nome}");
            Console.WriteLine($"Tipo Cliente: {cliente.GetType().Name}");
            //cliente.Codigo = 10; // Erro: tipos anônimos são somente leitura

            // Tipos anônimos aninhados
            var fornecedor = new {
                               Codigo = 999, Nome = "Emirates Corporation",
                               Endereco = new { Logradouro = "Sheikh Zayed Rd", Numero = 483,
                                                Complemento = "Second floor", Cidade = "Dubai",
                                                Pais = "UAE"}
                             };
            Console.WriteLine($"Fornecedor - Código: {fornecedor.Codigo} Nome: {fornecedor.Nome}");
            Console.WriteLine($"Endereço - Logradouro: {fornecedor.Endereco.Logradouro} {fornecedor.Endereco.Numero} " +
                                                     $"{fornecedor.Endereco.Complemento} {fornecedor.Endereco.Cidade} " +
                                                     $"{fornecedor.Endereco.Pais} ");

            Console.WriteLine($"Tipo Pedido: {fornecedor.GetType().Name}");

            // Matriz de objetos de tipos anônimos
            var alunos = new[] {
            new { Codigo = 1, Nome = "Olivia", Sobrenome = "Gomes" },
            new { Codigo = 2, Nome = "Leon", Sobrenome = "Taylor" },
            new { Codigo = 3, Nome = "Kendall", Sobrenome = "Jackson" }
            }; 
            foreach (var aluno in alunos)
                Console.WriteLine($"Aluno - {aluno.Codigo} {aluno.Nome} {aluno.Sobrenome}");
            Console.WriteLine($"Tipo Alunos: {alunos.GetType().Name}");

            // Matriz de objetos de tipos anônimos com tipos aninhados
            var produtos = new[] {
                           new { Codigo = 1, Descricao = "Caixa", Fornecedor = new { Nome = "X Factory", Telefone = "+55194930444"} },
                           new { Codigo = 2, Descricao = "Cesto", Fornecedor = new { Nome = "Y Factory", Telefone = "+55193953033"} }
                           };
            foreach (var produto in produtos)
                Console.WriteLine($"Produto - {produto.Codigo} {produto.Descricao} - Fornecedor - {produto.Fornecedor.Nome} {produto.Fornecedor.Telefone}");

            // Matrizes aninhadas de objetos de tipos anônimos
            var pedidos = new[] {
                          new { Codigo = 1, Data = DateTime.Now, Produtos = new[] {
                                        new {Codigo = 333, Nome = "Product 1"},
                                        new {Codigo = 444, Nome = "Product 2"},
                                        }
                              },
                          new { Codigo = 2, Data = DateTime.Now, Produtos = new[] {
                                        new {Codigo = 555, Nome = "Product 3"},
                                        new {Codigo = 666, Nome = "Product 4"},
                                        }
                              },
                          };
            foreach (var pedido in pedidos)
            {
                Console.WriteLine($"Pedido - {pedido.Codigo} {pedido.Data}");                
                foreach (var produto in pedido.Produtos)
                    Console.WriteLine($"  {produto.Codigo} {produto.Nome}");
            }            
            Console.ReadLine();
        }

        static void IncrementaContadorPorValor(int contador)
        {
            contador++;
            Console.WriteLine($"Valor de contador interno ao método: {contador.ToString()}");
        }

        static void IncrementaMes(ref DateTime data)
        {
            data = data.AddMonths(1);
            Console.WriteLine($"Valor de data interno ao método: {data.ToString()}");
        }
    }
}

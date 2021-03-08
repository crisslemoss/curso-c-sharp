using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01I___Struct_e_Enum___Exercicio
{
    class Program
    {
        //crie um struct para representar um produto com as propriedades nome, preco, quantidade, e subtotal
        //Utilizando Conole.ReadLine(), leia 3 produtos do usuario e armazene essas leituras em instancias do struct criado
        //Crie um metodo construtor que atribua o subtotal automaticamente (preco * quantidade)
        //Imprima todos os dados dos 3 produtos lidos
        //Imprima o valor total do pedido
        struct Produto
        {
            public string nome;
            public double preco;
            public double quantidade;
            public double subtotal;

            public Produto(string nome, double preco, double quantidade)
            {
                this.nome = nome;
                this.preco = preco;
                this.quantidade = quantidade;
                this.subtotal = (preco * quantidade);
            }
        }
        
        static void Main(string[] args)
        {            
            int count = 0;
            double totalPedido = 0;
            
            Console.WriteLine();
            do
            {
                Console.Write("");

                Console.WriteLine("Nome:");
                string nome = Console.ReadLine();

                Console.WriteLine("Preco:");
                double preco = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Quantidade:");
                double quantidade = Convert.ToDouble(Console.ReadLine());
                
                Produto produto = new Produto(nome, preco, quantidade);
                Console.WriteLine($"Nome: {produto.nome} - Preco: {produto.preco} - Quantidade: {produto.quantidade} - SubTotal: {produto.subtotal}");

                totalPedido += produto.subtotal;

                count++;
            } while (count != 3);

            Console.WriteLine($"Total Pedido: {totalPedido}");
            
            Console.ReadLine();
        }    
    }
}

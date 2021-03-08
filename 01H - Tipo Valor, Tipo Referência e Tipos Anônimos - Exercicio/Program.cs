using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            string line;
            Console.WriteLine("Enter one or more lines of text (press CTRL+Z to exit):");
            Console.WriteLine();
            do
            {
                Console.Write("   ");
                line = Console.ReadLine();
                if (line != null)
                    Console.WriteLine("      " + line);
            } while (line != null);

            //leia 3 valores do usuario Codigo, nome e data de nascimento

            var cliente = new { Codigo = 1, Nome = "John" };
            Console.WriteLine($"Cliente - Código: {cliente.Codigo} Nome: {cliente.Nome}");
            Console.WriteLine($"Tipo Cliente: {cliente.GetType().Name}");

            Console.WriteLine("Digite o Codigo:");
            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o Nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o DataNascimento:");
            DateTime dataNascimento = Convert.ToDateTime(Console.ReadLine());

            
            
            
            Console.Write("\nPress any key to continue... ");

            //crie uma variavel do tipo anonimo com as 3 propriedades

            //Imprima o conteudo completo da variavel\

            //Imprima o tipo da variavel do tipo dianmico

            //Imprima o tipo de cada atributo do tipo dinamico criado

            Console.ReadLine();
        
        }
    }
}

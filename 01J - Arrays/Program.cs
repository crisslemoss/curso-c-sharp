using System;
using System.Linq;

namespace _01J___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] codigosCliente;  // Array de elementos integer
            DateTime[] datasNascimento; // Array de elementos DateTime
            string[] paises; // Array de strings

            codigosCliente = new int[] { 1, 2, 3, 4, 5, 6 };
            foreach (int codigo in codigosCliente)
                Console.Write($"{codigo} ");
            Console.Write($"Qtde de elementos: {codigosCliente.Length}");

            double[] valores = new double[3] { 33.33, 99.9999, 10000 };
            Console.WriteLine("\nValores:");
            foreach (double valor in valores)
                Console.Write($"{valor} ");
            Console.Write($"Qtde de elementos: {valores.Length}");

            // Declarações inválidas
            // Inválido: não especificou a quantidade de elementos
            // int[] array1 = new int[];
            // Inválido: quantidade de elementos diferente do declarado
            // int[] array2 = new int[2] { 1, 2, 3 };
            // Inválido: não é possível inicializar uma variável de tipo 
            // implícito com um inicializador de array
            // var array3 = { 10, 20, 30 };

            // Acesso aos elementos atravé de índices
            int[] idades = { 47, 18, 22, 25, 76 };
            for (int i = 0; i < idades.Length; i++)
                Console.WriteLine(idades[i]);

            // Modificação de conteúdo de elemento
            idades[3] = 99;
            Console.WriteLine($"idades[3]: {idades[3]}");

            // Ordenação de elementos
            string[] cores = { "Verde", "Amarelo", "Marrom", "Azul", "Vermelho"};
            Array.Sort(cores);
            foreach (string cor in cores)
                Console.Write($"{cor} ");
            Console.WriteLine();

            // Inversão na ordem dos elementos
            Array.Reverse(cores);
            foreach (string cor in cores)
                Console.Write($"{cor} ");
            Console.WriteLine();

            // Remoção de N itens a partir de um índice
            Array.Clear(cores, 0, cores.Length);
            Console.WriteLine("Método Clear invocado");
            foreach (string cor in cores)
                Console.Write($"{cor} ");
            Console.WriteLine("Pós Método Clear invocado");

            cores = new string[] { "Verde", "Amarelo", "Marrom", "Azul", "Vermelho"};
            // Localiza um elemento no array
            Console.WriteLine($"Posição do elemento Azul: {Array.IndexOf(cores, "Azul")}");
            Console.WriteLine($"Posição do elemento Azul procurando a partir do 2o elemento, contando 3 elementos: " +
                              $"{Array.IndexOf(cores, "Azul", 2, 3)}");

            // Localiza último índice de um elemento no array
            string[] nomes = { "John", "Mary", "Richard", "John", "James" };
            Console.WriteLine($"Última posição do elemento John: {Array.LastIndexOf(nomes, "John")}");

            // Quantidade de elementos no array nomes
            Console.WriteLine($"Quantidade de elementos no array nomes: {nomes.Count()}");

            // Quantidade de elementos no array nomes iniciando pela letra "J"
            Console.WriteLine($"Quantidade de elementos no array nomes iniciando pela letra 'J': {nomes.Count(element => element.StartsWith("J"))}");

            int[] numbers = { 83, 5, 99, 34, 55 };
            // Estatísticas
            Console.WriteLine($"Maior valor do array: {numbers.Max()} ");
            Console.WriteLine($"Menor valor do array: {numbers.Min()} ");
            Console.WriteLine($"Valor médio do array: {numbers.Average()} ");

            // Clona um array em um novo array e o inicializa
            var newNumbers1 = numbers.Clone();
            foreach (int number in (Array)newNumbers1)
                Console.Write($"{number} ");

            Console.WriteLine();

            int[] newNumbers2 = new int[5];
            // Copia todos os elementos de um array para outro já inicializado
            numbers.CopyTo(newNumbers2, 0);
            foreach (int number in newNumbers2)
                Console.Write($"{number} ");

            Console.WriteLine();

            // Arrays multidimensionais
            
            // Declara e inicializa um array de duas dimensões
            // Uma dimensão com 5 elementos e outra com 2
            string[,] tabela = new string[5, 2];
            tabela[0, 0] = "Time 1";
            tabela[1, 0] = "Time 2";
            tabela[2, 0] = "Time 3";
            tabela[3, 0] = "Time 4";
            tabela[4, 0] = "Time 5";
            tabela[0, 1] = "12 pontos";
            tabela[1, 1] = "10 pontos";
            tabela[2, 1] = "6 pontos";
            tabela[3, 1] = "5 pontos";
            tabela[4, 1] = "0 pontos";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write($"{tabela[i, j]} ");
                Console.WriteLine();
            }

            // Array de 5 dimensões
            Random random = new Random();
            int[,,,,] randomNumbers = new int[2, 2, 2, 2, 2];
            for (int a = 0; a < 2; a++)
                for (int b = 0; b < 2; b++)
                    for (int c = 0; c < 2; c++)
                        for (int d = 0; d < 2; d++)
                            for (int e = 0; e < 2; e++)
                                randomNumbers[a, b, c, d, e] = random.Next(99);

            for (int a = 0; a < 2; a++)
            {
                for (int b = 0; b < 2; b++)
                {
                    for (int c = 0; c < 2; c++)
                    {
                        for (int d = 0; d < 2; d++)
                        {
                            for (int e = 0; e < 2; e++)
                                Console.Write($" {randomNumbers[a, b, c, d, e]}");
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            // Array de arrays
            int[][] nestedArray = new int[2][] { new int[] { 7, 6, 5, 4, 3, 2, 1 }, new int[] { 100, 200, 300, 400, 500 } };
            foreach (int[] array in nestedArray)
            {
                foreach (int number in array)
                    Console.Write($" {number}");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
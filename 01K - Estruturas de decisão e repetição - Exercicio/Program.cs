using System;

namespace _01K___Estruturas_de_decisão_e_repetição
{
    class Program
    {
        public enum Nivel { Alto, Medio, Baixo };

        static void Main(string[] args)
        {
            int x = 1, y = 2;

            // Estrutura de decisão if
            if (x < y)
                Console.WriteLine("x < y");

            // Estrutura de decisão if else
            x = 3;
            if (x < y)
                Console.WriteLine("x < y");
            else
                Console.WriteLine("x >= y");

            // Estrutura de decisão if else if
            x = 2;
            if (x < y)
                Console.WriteLine("x < y");
            else if (x > y)
                Console.WriteLine("x > y");
            else
                Console.WriteLine("x = y");

            // Estrutura de decisão if com blocos com mais de uma linha
            if (x == y)
            {
                Console.WriteLine("x = y");
                Console.WriteLine("x igual a y");
            }

            // Estrutura de decisão de ifs aninhados
            DateTime d1 = new DateTime(2020, 8, 15);
            DateTime d2 = new DateTime(2020, 9, 18);
            DateTime d3 = new DateTime(2021, 3, 20);
            DateTime d4 = new DateTime(2021, 3, 20);
            if (d1 < d2)
            {
                Console.WriteLine("d1 < d2");
                if (d2 < d3)
                {
                    Console.WriteLine("d2 < d3");
                    if (d3 < d4)
                        Console.WriteLine("d3 < d4");
                    else if (d3 > d4)
                        Console.WriteLine("d3 > d4");
                    else
                        Console.WriteLine("d3 == d4");
                }
                else
                    Console.WriteLine("d2 > d3");
            }
            else
                Console.WriteLine("d1 > d2");

            // Estrutura de decisão if com operadores lógicos
            int a = 1, b = 2, c = 3;
            if ((a > b) || (b < c))
                Console.WriteLine("((a > b) || (b < c)) ==> True");
            else
                Console.WriteLine("((a > b) || (b < c)) ==> False");

            if ((a > b) && (b < c))
                Console.WriteLine("((a > b) && (b < c)) ==> True");
            else
                Console.WriteLine("((a > b) && (b < c)) ==> False");

            if (!((a > b) && (b < c)))
                Console.WriteLine("(!((a > b) && (b < c))) ==> True");
            else
                Console.WriteLine("(!((a > b) && (b < c))) ==> False");

            // Operador ternário ou condicional
            int num1 = 10, num2 = 20;
            string resultado = num1 < num2 ? "num1 < num2" : "num2 > num1";
            Console.WriteLine(resultado);

            string resultadoOperadorAninhado = num1 < num2 ? "num1 < num2" :
                                   num1 > num2 ? "num1 > num2" :
                                   num1 == num2 ? "num1 = num2" :
                                   "Sem resultado";
            Console.WriteLine(resultadoOperadorAninhado);

            // Switch case
            Nivel nivel = Nivel.Medio;
            switch (nivel)
            {
                case Nivel.Baixo:
                    Console.WriteLine("Nível baixo");
                    break;
                case Nivel.Medio:
                    Console.WriteLine("Nível médio");
                    break;
                case Nivel.Alto:
                    Console.WriteLine("Nível alto");
                    break;
            }

            // Switch case com default
            char key = (char)Console.Read();
            switch (key)
            {
                case 'a':
                    Console.WriteLine("a");
                    break;
                case 'b':
                    Console.WriteLine("b");
                    break;
                default:
                    Console.WriteLine("Outra tecla que não 'a' ou 'b'");
                    break;
            }

            // Switch com cases combinados
            int number = 3;
            switch (number)
            {
                case 1:
                    Console.WriteLine("Número 1");
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Número 2, 3 ou 4");
                    break;
                case 5:
                    Console.WriteLine("Número 5");
                    break;
                default:
                    Console.WriteLine("Outro número");
                    break;
            }

            // while
            int contador = 0;
            while (contador < 10)
            {
                Console.WriteLine($"Contador: {contador}");
                contador++;
            }

            // while com break
            int cont = 0;
            while (true)
            {
                Console.WriteLine($"Cont: {cont}");
                cont++;
                if (cont > 5)
                    break;
            }

            // while com continue
            DateTime data = new DateTime(2020, 8, 16);
            while (data < DateTime.Parse("30/08/2020"))
            {
                data = data.AddDays(1);
                if ((data == DateTime.Parse("20/08/2020")) || (data == DateTime.Parse("25/08/2020")))
                    continue;
                Console.WriteLine($"Data: {data.ToShortDateString()}");                
            }

            // while com loops aninhados
            int m = 0, n = 1;
            while (m < 3)
            {
                Console.WriteLine("i = {0}", m);
                m++;
                while (n < 3)
                {
                    Console.WriteLine("j = {0}", n);
                    n++;
                }
            }

            // do while
            int k = 0;
            do
            {
                Console.WriteLine("k: {0}", k);
                k++;
                if (k > 10)
                    break;
            } while (k < 10);

            // for
            for (int i = 0; i < 5; i++)
                Console.WriteLine($"i: {i}");
            
            // for com condição e iterador 
            // definidos dentro do bloco de código
            int j = 0;
            for ( ; ; )
            {
                if (j < 5)
                {
                    Console.WriteLine("j: {0}", j);
                    j++;
                }
                else
                    break;
            }

            // for com iterador negativo
            for (int iterador = 5; iterador > 0; iterador--)
                Console.WriteLine("iterador: {0}", iterador);

            // for com múltiplas condições e iteradores
            for (int var1 = 0, var2 = 0; var1 + var2 <= 20; var1++, var2 = var2 + 2)
            {
                Console.WriteLine($"var1: {var1}");
                Console.WriteLine($"var2: {var2}");
                Console.WriteLine($"var1 + var2: {var1 + var2}");
            }

            // foreach
            string[] cidades = new string[] { "Dubai", "Campinas", "Orlando" };
            foreach (string cidade in cidades)            
                Console.WriteLine(cidade);

            // foreach com var
            int[] idades = new[] { 22, 18, 59, 37, 38 };
            foreach (var idade in idades)
                Console.WriteLine($"Idade: {idade}");


            Console.ReadLine();
        }
    }
}
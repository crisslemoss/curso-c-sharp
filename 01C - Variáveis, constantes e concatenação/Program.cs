using System;
using System.Text;
using MyInt = System.Int32;

namespace _01C___Variáveis_e_operadores_básicos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração
            int num1;            

            // Atribuição
            num1 = 10;
            Console.WriteLine(num1.ToString());

            // Declaração e atribuição
            int num2 = 20;
            Console.WriteLine(num2.ToString());

            // Declaração e atribiuição múltiplas
            int a = 1, b = 2, c = 3, d = 4;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            string nome = "Adriano Silveira";
            Console.WriteLine(nome);

            double num3 = 50.11;
            Console.WriteLine(num3.ToString());

            // Sufixos
            float num4 = 30.22f;
            Console.WriteLine(num4.ToString());

            decimal num5 = 40.33m;
            Console.WriteLine(num5.ToString());

            bool condicao = false;
            Console.WriteLine(condicao.ToString());

            double resultado1;
            resultado1 = 7 / 2;
            Console.WriteLine(resultado1); // Porque 3 e não 3.5? Porque 7 é um número inteiro

            double resultado2;
            resultado2 = 7.0 / 2; // É necessário forçar o tipo para ter o resultado adequado
            Console.WriteLine(resultado2);

            //int valorErro = 0.0; // Erro por problema na comparação de tipos
            //Console.WriteLine(valorErro);

            // Alias
            int number1 = 1;
            System.Int32 number2 = 2;
            MyInt number3 = 3;
            
            Console.WriteLine(String.Format("number1: {0} / number2: {1} / number3: {2}", number1, number2, number3));

            // Default Values
            int default_int = default(int);
            Console.WriteLine(String.Format("Valor default de 'int': {0}", default_int));

            bool default_bool = default(bool);
            Console.WriteLine(String.Format("Valor default de 'bool': {0}", default_bool));

            char default_char = default(char);
            Console.WriteLine(String.Format("Valor default de 'char': {0}", default_char));

            MyInt default_myInt = default(MyInt);
            Console.WriteLine(String.Format("Valor default de 'MyInt': {0}", default_myInt));

            // Constantes
            const float pi = 3.14f;
            Console.WriteLine(pi);

            // pi = 10; // Atribuição não permitida por ser uma constante
            // const int idadeabc; // Erro: toda constante deve ter um valor definido em sua declaração

            // Concatenação
            string parte1 = "Parte 1";
            string parte2 = "Parte 2";
            string resultado;

            // Utilizando operador "+"
            resultado = "Utlizando operador +:" + parte1 + " " + parte2;
            Console.WriteLine(resultado);

            // Utilizando método Concat
            resultado = String.Concat("Utilizando método Concat: ", parte1, " ", parte2);
            Console.WriteLine(resultado);

            // Utilizando método Format
            resultado = String.Format("Utilizando {3} método Format: {0} {1} {2}", parte1, parte2, "teste", "yyy");
            Console.WriteLine(resultado);

            // Utilizando método Join
            resultado = String.Join(" ", "Utilizando método Join:", parte1, parte2);
            Console.WriteLine(resultado);

            // Utilizando classe StringBuilder
            StringBuilder sb = new StringBuilder();
            sb.Append("Utilizando StringBuilder: ");
            sb.Append(parte1);
            sb.Append(parte2);
            Console.WriteLine(sb.ToString());

            // Utilizando operador $
            resultado = $"Utilizando operador $: {parte1} {parte2}";
            Console.WriteLine(resultado);

            // Concantenação de literais
            Console.WriteLine("Palavra 1" + " Palavra 2 " + "Palavra 3");

            // Concantenação de literais e variáveis
            int idade = 30;
            Console.WriteLine("Idade: " + idade.ToString());

            Console.ReadLine();
        }
    }
}
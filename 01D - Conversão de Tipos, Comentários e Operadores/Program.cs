using System;

namespace _01D___Comentários_e_Conversão_de_Tipos
{
    class Program
    {
        /// <summary>
        /// Método principal - Descrição do método principal para documentação XML
        /// </summary>
        static void Main(string[] args)
        {
            // Comentário com barras - linha 1
            // Comentário com barras - linha 2
            // Comentário com barras - linha 3

             /*Comentário com barra e asterisco - linha 1
               Comentário com barra e asterisco - linha 2
               Comentário com barra e asterisco - linha 3 */

            //TODO: Tarefa 1
            //HACK: Tarefa 2
            //UNDONE: Tarefa 3            


            // Conversão de tipos (Type Casting)

            // Conversão implícita
            int num1 = 10;
            double num2 = 20.55;
            num2 = num1; // Permitido porque int "cabe" em double
            //num1 = num2; // Erro porque um double não "cabe" em um int
            Console.WriteLine(num2);
                        
            // Conversão explícita
            num2 = 20.80;
            num1 = (int)num2; // Força a conversão de tipo ciente das possíveis perdas de dados
            Console.WriteLine(num1);

            // Conversões utilizando a classe "Convert"
            int num3 = 50;
            Console.WriteLine(Convert.ToString(num3));
            Console.WriteLine(Convert.ToBoolean(num3));

            // Resultado de Type Casting sem conversão
            string linguagem = "C#";
            Console.WriteLine(Convert.ToString(linguagem));

            // InvalidCastException
            char letra = 'A';
            //Console.WriteLine(Convert.ToBoolean(letra));

            // FormatException
            string valor = "100,000.00";
            //Console.WriteLine(Convert.ToDecimal(valor));

            // OverflowException
            int teste = 10000;
            //Console.WriteLine(Convert.ToByte(teste));

            // Operadores
            Console.WriteLine(String.Format("num1: {0} - num2: {1}", num1, num2));
            Console.WriteLine(String.Format("num1 + num2: {0}", num1 + num2));
            Console.WriteLine(String.Format("num1 - num2: {0}", num1 - num2));
            Console.WriteLine(String.Format("num1 * num2: {0}", num1 * num2));
            Console.WriteLine(String.Format("num1 / num2: {0}", num1 / num2));
            Console.WriteLine(String.Format("num1 % num2: {0}", num1 % num2));
            Console.WriteLine(String.Format("num1++: {0}", num1++));
            Console.WriteLine(String.Format("num1--: {0}", num1--));

            // Operação com atribuição
            Console.WriteLine(String.Format("num1: {0}", num1));
            num1 += 10;
            Console.WriteLine(String.Format("num1 += 10: {0}", num1));
            num1 -= 10;
            Console.WriteLine(String.Format("num1 -= 10: {0}", num1));
            num1 *= 10;
            Console.WriteLine(String.Format("num1 *= 10: {0}", num1));
            num1 /= 10;
            Console.WriteLine(String.Format("num1 /= 10: {0}", num1));
            num1 %= 3;
            Console.WriteLine(String.Format("num1 %= 3: {0}", num1));

            // Operadores de comparação
            num1 = 10;
            num2 = 20;
            Console.WriteLine(String.Format("num1: {0} - num2: {1}", num1, num2));
            Console.WriteLine(String.Format("num1 == num2? {0}", num1 == num2));
            Console.WriteLine(String.Format("num1 != num2? {0}", num1 != num2));
            Console.WriteLine(String.Format("num1 > num2? {0}", num1 > num2));
            Console.WriteLine(String.Format("num1 >= num2? {0}", num1 >= num2));
            Console.WriteLine(String.Format("num1 < num2? {0}", num1 < num2));
            Console.WriteLine(String.Format("num1 <= num2? {0}", num1 <= num2));

            // Operadores lógicos
            Console.WriteLine(String.Format("num1: {0} - num2: {1}", num1, num2));
            Console.WriteLine(String.Format("(num1 > num2) && (num1 == num2)? {0}", (num1 > num2) && (num1 == num2)));
            Console.WriteLine(String.Format("(num1 > num2) || (num1 != num2)? {0}", (num1 > num2) || (num1 != num2)));
            Console.WriteLine(String.Format("!(num1 > num2) ? {0}", !(num1 > num2)));

            Console.ReadLine();
        }
    }
}
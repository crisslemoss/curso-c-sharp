using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01F___Tipo_var_e_Nullable_types
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 40; // Tipagem explicita
            Console.WriteLine(String.Format("Tipo de 'x': {0}", x.GetType().ToString()));

            var y = 40; // Tipagem implícita
            Console.WriteLine(String.Format("Tipo de 'y': {0}", y.GetType().ToString()));

            var nome = "John";
            Console.WriteLine(String.Format("Tipo de 'nome': {0}", nome.GetType().ToString()));

            var condicao = true;
            Console.WriteLine(String.Format("Tipo de 'condicao': {0}", condicao.GetType().ToString()));

            var cores = new[] { "azul", "verde", "branco" };
            Console.WriteLine(String.Format("Tipo de 'cores': {0}", cores.GetType().ToString()));

            var idades = new[] { 10, 30, 50, 20};
            Console.WriteLine(String.Format("Tipo de 'idades': {0}", idades.GetType().ToString()));

            var cliente = new { Codigo = 10, Nome = "John" };
            Console.WriteLine(String.Format("Tipo de 'cliente': {0}", cliente.GetType().ToString()));

            for (var i = 0; i < 3; i++)            
                Console.WriteLine(String.Format("Tipo de 'i': {0}", i.GetType().ToString()));

            var cidades = new[] { "Campinas", "Dubai", "Orlando" };
            foreach (var cidade in cidades)
                Console.WriteLine(String.Format("Tipo de 'cidade': {0}", cidade.GetType().ToString()));

            using (var arquivo = new StreamReader(@"E:\Curso CSharp Completo\arquivo.dat"))
            {
                Console.WriteLine(String.Format("Tipo de 'arquivo': {0}", arquivo.GetType().ToString()));
            }

            int a = 1, b = 2; // Permitido           
            //var c = 1, d = 3; // Proibido
            //var e = null; // Proibido

            string[] nomes = { "John", "Paul", "Joane", "Harry", "Margot" };
            var nomesComecandoComJ = from nomeComJ in nomes
                                     where nomeComJ[0] == 'J'
                                     select nomeComJ;
            Console.WriteLine(String.Format("Tipo de 'nomesComecandoComJ': {0}", nomesComecandoComJ.GetType().ToString()));

            foreach (var item in nomesComecandoComJ)
            {
                Console.WriteLine(String.Format("Tipo de 'item': {0}", item.GetType().ToString()));
                Console.WriteLine(item);
            }

            // Nullable types

            bool? cancelado;
            cancelado = null;
            Console.WriteLine(String.Format("Cancelado: {0}", cancelado.HasValue));

            int? contador = null;
            Console.WriteLine(String.Format("Contador: {0}", contador));

            System.Nullable<decimal> valor = 100000;
            Console.WriteLine(String.Format("Valor: {0}", valor));

            long? distancia = null;
            if (distancia.HasValue)
                Console.WriteLine(String.Format("Distância: {0}", valor));
            else
                Console.WriteLine("Distância não definida");

            float? nota = null;
            // Será lançada exceção ao acessar nota.Value
            //Console.WriteLine(String.Format("Nota {0}", nota.Value));

            int? idade = null;
            // Será obtido valor 0 (zero), que é valor default para o tipo int
            Console.WriteLine(String.Format("Idade: {0}", idade.GetValueOrDefault()));

            int? peso = null;
            //int outroPeso1 = peso.Value; // Inválido
            int outroPeso2 = peso ?? 10; // Válido
            Console.WriteLine(String.Format("Outro Peso 2: {0}", outroPeso2));

            /*bool? regra = null;
            if (regra) // Erro na compilação
                Console.WriteLine("regra == true");
            else
                Console.WriteLine("regra == false");*/

            /*bool? regra1 = null;
            if (regra1.Value) // Levanta exceção InvalidOperationException
                Console.WriteLine("regra1 == true");
            else
                Console.WriteLine("regra1 == false");*/

            int? num1 = null;
            int num2 = 1;
            if (num1 < num2)
                Console.WriteLine("num1 < num2");
            else if (num1 > num2)
                Console.WriteLine("num1 > num2");
            else if (num1 == num2)
                Console.WriteLine("num1 == num2");
            else
                Console.WriteLine("Não foi possível comparar");

            if (Nullable.Compare<int>(num1, num2) < 0)
                Console.WriteLine("num1 < num2");
            else if (Nullable.Compare<int>(num1, num2) > 0)
                Console.WriteLine("num1 > num2");
            else if (Nullable.Compare<int>(num1, num2) == 0)
                Console.WriteLine("num1 == num2");
            else
                Console.WriteLine("Não foi possível comparar");

            Console.ReadLine();
        }
    }
}

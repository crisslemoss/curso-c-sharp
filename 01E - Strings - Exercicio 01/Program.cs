//Exercicio - pagina 36
//http://www.elfutec.com/amea/curso/10002246/36

using System;

namespace _01E___Strings___Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //sem utilizar o carctere `@` imprima o texto: "Expectativa de vida por pais '2012'";
            string tabela = @"1 Japao       88
2 Andorra     84.2
3 Singapura   84";
            Console.WriteLine(tabela);

            //utilizando caracteres de escape, imprima a tabela virtual;
            tabela = "Column *\tColumn Pais\tColumn Expectativa de vida geral";
            string linhas = "Row 1\tJapao\t88\r\nRow 2\tAndorra\t84.2\r\nRow 3\tSingapura\t84";

            Console.WriteLine(tabela);
            Console.WriteLine(linhas);
            //sem utilizar caracteres de escape, imprima o texto a serguir:
            //linha 1 - "linha 1";
            //linha 2 - "linha 2".
        }
    }
}

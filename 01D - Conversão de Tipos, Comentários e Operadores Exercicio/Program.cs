//Exercicio - pagina 32
//http://www.elfutec.com/amea/curso/10002246/32
using System;

namespace _01D___Conversão_de_Tipos__Comentários_e_Operadores_Exercicio
{
    static class Program
    {
        static void Main()
        {
            //Declare e atribua valor a uma variavel inteira
            int varInt = 5;

            //Decrare uma varialve de ponto flutuante
            float varFloat;

            //Atribua o valor da 1º variavel aa segunda atraves de type casting implicico
            varFloat = varInt;

            //Faca a atribuicao contraria de type atraves de casting explicito
            varFloat = (float)varInt;

            //Faca um type casting que gere um erro/execao
            //varFloat = 

            //Escreva um trecho de codigo com pelo menos um operador de cada tipo:
            //aritmetico, de atribuicao, de comparacao e logico
            float? aritmetico = null;

            if (varInt > 0 && varFloat > 0)
                aritmetico = varInt * varFloat;
            
            Console.WriteLine(string.Format("Resultado: {0}", aritmetico));
        }
    }
}

using System;
using System.Text;

namespace _01E___Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string exemplo = "  Minha primeira string";
            Console.WriteLine(exemplo);

            string colunas = "Código\tNome\tIdade";
            string linhas = "1\tJohn\t30\r\n2\tPaul\t50";
            Console.WriteLine(colunas);
            Console.WriteLine(linhas);

            // Utilização do caractere "@"
            string texto = @"Linha 1
                             Linha 2
                             Linha 3 
                             \\\ \r \b
                             c:\curso"; // Válido
            Console.WriteLine(texto);

            // Acesso individual a caracteres
            string textoAInverter = "Texto a inverter";
            for (int i = textoAInverter.Length -1; i >= 0; i--)
            {
                System.Console.Write(textoAInverter[i]);
            }
            // Resultado: "retrevni a otxeT"

            string textoNulo = null;
            string textoVazio = String.Empty;
            string textoComEspacos = "        ";
            string textoComConteudo = "Curso C#";

            Console.WriteLine("Texto nulo: " + textoNulo);
            Console.WriteLine("Texto vazio: " + textoVazio);
            Console.WriteLine("Texto com espaços: " + textoComEspacos);
            Console.WriteLine("Texto com conteúdo: " + textoComConteudo);

            string valor = "    ";
            if (String.IsNullOrEmpty(valor)) // Falso
                Console.WriteLine("Valor nulo ou vazio");
            if (String.IsNullOrWhiteSpace(valor)) // Verdadeiro
                Console.WriteLine("Valor nulo ou somente com espaços em branco");

            // Exemplos de utilização de IndexOf
            string textoParaIndexOf = "Curso completo de C#";
            Console.WriteLine(textoParaIndexOf.IndexOf('C')); // Retorna 0
            Console.WriteLine(textoParaIndexOf.IndexOf('m')); // Retorna 8 
            Console.WriteLine(textoParaIndexOf.IndexOf("completo")); // Retorna 6
            Console.WriteLine(textoParaIndexOf.IndexOf('o', 10)); // Retorna 13
            Console.WriteLine(textoParaIndexOf.IndexOf("de", 10)); // Retorna 15 

            // Exemplos de utilização de LastIndexOf
            string textoParaLastIndexOf = "Curso completo de C#";
            Console.WriteLine(textoParaLastIndexOf.LastIndexOf('C')); // Retorna 18
            Console.WriteLine(textoParaLastIndexOf.LastIndexOf('m')); // Retorna 8
            Console.WriteLine(textoParaLastIndexOf.LastIndexOf("completo")); // Retorna 6
            Console.WriteLine(textoParaLastIndexOf.LastIndexOf('o', 10)); // Retorna 7
            Console.WriteLine(textoParaLastIndexOf.LastIndexOf("de", 10)); // Retorna -1*

            // Exemplos de utilização de Replace
            string textoComErroOrtografico = "Joãozinho tinha uma caza. " + 
                                             "Sua caza era de madeira. " +
                                             "Sua caza foi destruída.";
            // Substitui todas as ocorrência de "caza" por "casa"
            Console.WriteLine(textoComErroOrtografico.Replace("caza", "casa"));
            // Substitui todas as ocorrência do caractere 'e' por 'o'
            Console.WriteLine(textoComErroOrtografico.Replace('e', 'o'));

            // Exemplos de utilização de Substring
            string textoCompleto = "Água mole em pedra dura tanto bate até que fura";
            // Retorna toda a string a partir da posição 24: "tanto bate até que fura"
            Console.WriteLine(textoCompleto.Substring(24));
            // Retorna 10 caracteres a partir da posição 24: "tanto bate"
            Console.WriteLine(textoCompleto.Substring(24, 10));

            // Exemplos de utilização de ToUpper e ToLower
            string textoEmMinusculo = "texto em minúsculo";
            // Converte todos os caracteres para maiúsculo
            Console.WriteLine(textoEmMinusculo.ToUpper());
            // Converte todos os caracteres para minúsculo
            string textoEmMaiusculo = "TEXTO EM MAIÚSCULO";
            Console.WriteLine(textoEmMaiusculo.ToLower());
            

            // Exemplos de utiliação de Trim
            string textoParaTrim = "   Texto para trim   ";
            // Remove todos os caracteres em branco à direita e à esquerda
            Console.WriteLine(textoParaTrim.Trim());
            textoParaTrim = "   ,palavra1,palavra2;palavra3;";
            char[] charsToTrim = { ';', ',' };
            // Remove todos os caracteres da coleção 
            // charsToTrim à direita e à esquerda da string
            Console.WriteLine(textoParaTrim.Trim(charsToTrim));

            // Exemplos de utilização de PadLeft e PadRight
            string textoBase = "1234";
            // Preenche com espaços à esquerda da string
            // até que esta chegue a 10 caracteres de tamanho
            Console.WriteLine(textoBase.PadLeft(10));            
            // Preenche com zeros à esquerda da string
            // até que esta chegue a 10 caracteres de tamanho
            Console.WriteLine(textoBase.PadLeft(10, '0'));
            // Preenche com pontos à direita da string
            // até que esta chegue a 10 caracteres de tamanho
            Console.WriteLine(textoBase.PadRight(10, '.'));

            // Exemplos de utilização de Split
            string nomes = "John,Paul,Harper;Avery,Ella;     ,Jacob";
            char[] separators = { ';', ',' };
            // Retorna uma lista de nomes separador por ',' e ';'
            string[] listaNomes = nomes.Split(separators);
            foreach (string nome in listaNomes)
                Console.WriteLine(nome);

            // Exemplos de utilização de Join
            string[] listaClubes = new string[] { "Real Madrid", "Barcelona", "Chelsea", "Liverpool", "PSG", "Milan" };
            // Retorna uma string com todos os clubes da lista separados por ";"
            string clubes = String.Join(";", listaClubes);
            Console.WriteLine(clubes);
            // Retorna uma string com 2 clubes da lista, começando pela posição 2, separados por ";"
            string clubesInglaterrea = String.Join(";", listaClubes, 2, 2);
            Console.WriteLine(clubesInglaterrea);

            // Exemplos de utilização de StartsWith e EndsWith
            string mensagem = "O rato roeu a roupa do rei de roma";
            Console.WriteLine(mensagem.StartsWith("o rato")); // Retorna false
            Console.WriteLine(mensagem.StartsWith("o rato", true, null)); // Retorna true
            Console.WriteLine(mensagem.EndsWith("Roma")); // Retorna false
            Console.WriteLine(mensagem.EndsWith("Roma", true, null)); // Retorna true

            // Exemplos de utilização da classe StringBuilder
            StringBuilder sb = new StringBuilder();
            sb.Append("Palavra1");
            sb.Append('-', 20);
            char[] chars = { 'a', 'b', 'c', 'd', 'e', 'f' };
            sb.Append(chars, 2, 3);
            sb.AppendLine();
            sb.Append("nova linha");
            Console.WriteLine(sb.ToString());
            sb.Clear();
            sb.AppendFormat("Código: {0} - Nome: {1}", 1, "John");
            Console.WriteLine(sb.ToString());
            
            Console.ReadLine();
        }
    }
}
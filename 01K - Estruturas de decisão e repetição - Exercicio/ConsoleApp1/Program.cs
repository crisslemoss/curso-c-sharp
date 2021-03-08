using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*01 - Leia um valor de usuario para um estado(UF)
            Utilizando SWITCH CASE, imprima a regiao do estado lido
            Como resultado padrao, imprima 'Estado invalido'*/
            Console.WriteLine("Digite o estado:");
            string uf = Console.ReadLine();
                        
            switch (uf)
            {
                case "MG":                    
                case "SP":
                case "RJ":
                case "ES":
                    Console.WriteLine("Sudeste");
                    break;
                case "PR":
                case "SC":
                case "RS":
                    Console.WriteLine("Sul");
                    break;
                case "GO":
                case "MS":
                case "MT":                
                    Console.WriteLine("Centro-Oeste");
                    break;
                case "RO":
                case "AC":
                case "AM":                
                case "RR":
                case "PA":
                case "AP":
                case "TO":                
                    Console.WriteLine("Norte");
                    break;
                case "MA":
                case "PI":
                case "CE":
                case "RN":
                case "PB":
                case "PE":
                case "AL":
                case "SE":
                case "BA":
                    Console.WriteLine("Nordeste");
                    break;
                default:
                    Console.WriteLine("Estado invalido");
                    break;
            }
            Console.ReadLine();


            /*
            02 - Leia valore do usuario para um numero
            Utilizando SWITCH CASE, imprima
                <= 5 para numeros de 1 a 5
                > 6 <= 10 para os numeros de 5 a 10
                numero invalido para qualquer outro valor
            */            
            Console.WriteLine("Digite um numero entre 1 e 10:");
            int numero = Convert.ToInt32(Console.ReadLine());
                        
            switch (numero)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("numero menor ou igual a 5");
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("numero maior que 6 e menor ou igual a 10");
                    break;                
                default:
                    Console.WriteLine("Numero invalido");
                    break;
            }
            Console.ReadLine();

            /*
            03 - Leia um valor do usuaro para representar uma idade
            utilizando IF, ELSE E ELSE IF, verifique a faixa de idade e imprima o resultado 
                ate 13, crianca
                de 14 a 18, adolescente
                de 19 a 65, adulto
                de 66 a 150, 3º idade
                qualquer outro valor, idade invalida
            */
            Console.WriteLine("Digite uma idade:");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade <= 13)
                Console.WriteLine("Crianca");
            else if (idade >= 14 && idade <= 18)
                Console.WriteLine("Adolescente");
            else if (idade >= 16 && idade <= 65)
                Console.WriteLine("Adulto");
            else if (idade >= 66 && idade <= 150)
                Console.WriteLine("3º idade");
            else 
                Console.WriteLine("Idade Invalida");

            Console.ReadLine();

            /*
            04 - Crie uma nova aplicacao similar mas utilizando somente o operador ternario ?
            */
            Console.WriteLine("Digite uma idade:");
            idade = Convert.ToInt32(Console.ReadLine());
            String msg;

            msg = (idade <= 13) ? "Crianca" : 
                  (idade >= 14 && idade <= 18) ? "Adolescente" : 
                  (idade >= 16 && idade <= 65)? "Adulto" : 
                  (idade >= 66 && idade <= 150) ? "3º idade" : "Idade Invalida";

            Console.WriteLine(msg);
            Console.ReadLine();


            /*
            05 - Leia uma valor qualquer do usuario 
            Repita a operacao ate que usuario digite 'SAIR'
            A condicao de parada do loop devera ser case insensitive
            */



            /*
            06 - Crie uma nova aplicacao similar mas utilizando do While
            */                        
            string valor; 
            
            do
            {
                Console.WriteLine("Digite qualquer valor ou 'sair':");
                valor = Console.ReadLine().ToLower();
                Console.WriteLine("valor digitado: {0}", valor);
                Console.ReadLine();

            } while (valor == "sair");

            Console.ReadLine();
        }
    }
}

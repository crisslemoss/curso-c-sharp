using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01I___Struct__Enum_e_Arrays
{
    struct Coordenada
    {
        public double x;
        public double y;
    }

    struct CoordenadaComConstrutor
    {
        public double x;
        public double y;

        public CoordenadaComConstrutor(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }

    struct Circunferencia
    {
        public double raio;
        public double diametro;

        public Circunferencia(double raio)
        {
            this.raio = raio;
            this.diametro = 2 * Math.PI * raio;
        }
    }

    enum CoresBasicas
    {
        Vermelho,
        Verde,
        Azul
    }

    enum Naipe
    {
        Copas, // 0 
        Espadas, // 1
        Paus, // 2
        Ouros // 3
    }

    enum Regiao
    {
        Sudeste, // 0
        Sul, // 1
        Norte = 5, // 5
        Nordeste, // 6
        CentroOeste // 7
    }

    enum Categoria: UInt16
    {
        Roupas = 1,
        Eletrônicos = 2,
        Perfumes = 3,
        Brinquedos = 4
    }

    enum TipoPessoa:  Byte
    {
        PessoaFisica = 1,
        //PessoaJuridica = 99999
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Structs

            // Struct inicializado com new
            Coordenada coordenada = new Coordenada();
            coordenada.x = 10;
            coordenada.y = 20;
            Console.WriteLine($"X: {coordenada.x} - Y: {coordenada.y}");

            // Struct acesso sem new
            Coordenada coordenada2;
            coordenada2.x = 99;
            coordenada2.y = 88;
            Console.WriteLine($"Coord. 2 X: {coordenada2.x} - Coord. 2 Y: {coordenada2.y}");

            // Struct inicializado com new e acessando valores padrões de seus campos
            Coordenada coordenada3 = new Coordenada();
            Console.WriteLine($"Coord. 3 X: {coordenada3.x} - Coord. 3 Y: {coordenada3.y}");

            // Struct tentando acessar campos sem inicializar antes com new
            Coordenada coordenada4;
            //Console.WriteLine($"Coord. 4 X: {coordenada4.x} - Coord. 4 Y: {coordenada4.y}");            

            // Struct com construtor
            Circunferencia circunferencia = new Circunferencia(20);
            Console.WriteLine($"Diâmetro de 20: {circunferencia.diametro}");

            // Enum
            CoresBasicas cor = CoresBasicas.Azul;
            Console.WriteLine($"Cor: {cor}");

            int numeroCor = (int)cor;
            Console.WriteLine($"Número da cor: {numeroCor}");

            // Iteração em membros de um enum
            foreach (var item in Enum.GetNames(typeof(Regiao)))
                Console.WriteLine(item);

            // Enum com operador de igualdade
            Categoria categoria = Categoria.Eletrônicos;
            if (categoria == Categoria.Brinquedos)
                Console.WriteLine("Categoria de brinquedos");
            else
                Console.WriteLine("Outras categorias");

            // Enum com switch
            Categoria categoriaProduto = Categoria.Roupas;
            switch (categoriaProduto)
            {
                case Categoria.Brinquedos:
                    Console.WriteLine("** Brinquedos **");
                    break;
                case Categoria.Eletrônicos:
                    Console.WriteLine("** Eletrônicos **");
                    break;
                case Categoria.Perfumes:
                    Console.WriteLine("** Perfumes **");
                    break;
                case Categoria.Roupas:
                    Console.WriteLine("** Roupas **");
                    break;
                }

            Console.ReadLine();
        }
    }
}

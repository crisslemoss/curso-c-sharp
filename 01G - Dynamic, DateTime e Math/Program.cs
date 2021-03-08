using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic__DateTime_e_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic var1;
            var1 = "Teste";
            Console.WriteLine(String.Format("Valor de var1: {0}", var1));
            Console.WriteLine(String.Format("Tipo de var1: {0}", var1.GetType()));

            dynamic mutableVar = 1;
            Console.WriteLine(String.Format("Tipo de mutableVar: {0}", mutableVar.GetType()));

            mutableVar = "Texto";
            Console.WriteLine(String.Format("Tipo de mutableVar: {0}", mutableVar.GetType()));

            mutableVar = DateTime.Now;
            Console.WriteLine(String.Format("Tipo de mutableVar: {0}", mutableVar.GetType()));

            mutableVar = new StringBuilder();
            Console.WriteLine(String.Format("Tipo de mutableVar: {0}", mutableVar.GetType()));

            dynamic dynamicVar = new StringBuilder();
            //dynamicVar.MetodoInexistente(); // Compila mas gera erro de execução
            //string teste = dynamicVar.PropriedadeInexistente; // Compila mas gera erro de execução

            object mensagem = "C# é fortemente tipado";
            //mensagem += 999;
            Console.WriteLine(mensagem);

            dynamic novaMensagem = "C# é fortemente tipado";
            novaMensagem += 999;
            // Resultado: C# é fortemente tipado999
            Console.WriteLine(novaMensagem);

            // Conversão implicita de objetos dynamic
            dynamic dynamicInt = 999;
            Console.WriteLine(String.Format("Valor de dynamicInt: {0}", dynamicInt));
            Console.WriteLine(String.Format("Tipo de dynamicInt: {0}", dynamicInt.GetType()));
            dynamic dynamicString = "texto";
            Console.WriteLine(String.Format("Valor de dynamicString: {0}", dynamicString));
            Console.WriteLine(String.Format("Tipo de dynamicString: {0}", dynamicString.GetType()));
            dynamic dynamicDate = DateTime.Now;
            Console.WriteLine(String.Format("Valor de dynamicDate: {0}", dynamicDate));
            Console.WriteLine(String.Format("Tipo de dynamicDate: {0}", dynamicDate.GetType()));
            dynamic dynamicStackTrace = new System.Diagnostics.StackTrace();
            Console.WriteLine(String.Format("Valor de dynamicStackTrace: {0}", dynamicStackTrace));
            Console.WriteLine(String.Format("Tipo de dynamicStackTrace: {0}", dynamicStackTrace.GetType()));

            int intVar = dynamicInt;
            Console.WriteLine(String.Format("Valor de intVar: {0}", intVar));
            Console.WriteLine(String.Format("Tipo de intVar: {0}", intVar.GetType()));
            string stringVar = dynamicString;
            Console.WriteLine(String.Format("Valor de stringVar: {0}", stringVar));
            Console.WriteLine(String.Format("Tipo de stringVar: {0}", stringVar.GetType()));
            DateTime dateTimeVar = dynamicDate;
            Console.WriteLine(String.Format("Valor de dateTimeVar: {0}", dateTimeVar));
            Console.WriteLine(String.Format("Tipo de dateTimeVar: {0}", dateTimeVar.GetType()));
            System.Diagnostics.StackTrace stackTraceObject = dynamicStackTrace;
            Console.WriteLine(String.Format("Valor de dynamicStackTrace: {0}", dynamicStackTrace));
            Console.WriteLine(String.Format("Tipo de dynamicStackTrace: {0}", dynamicStackTrace.GetType()));          
            
            // DateTime
            DateTime d1 = new DateTime(); // Data "zero": 01/01/0001 00:00:00
            Console.WriteLine($"new DateTime(): {d1.ToString()}");

            DateTime d2 = new DateTime(9999, 12, 31, 23, 59, 59); // Data "final": 31/12/9999 23:59:59
            Console.WriteLine($"new DateTime(9999, 12, 31, 23, 59, 59): {d2.ToString()}");

            DateTime d3 = new DateTime(2020, 8, 6); // 06/08/2020 00:00:00
            Console.WriteLine($"new DateTime(2020, 8, 6): {d3.ToString()}");

            DateTime d4 = new DateTime(2020, 8, 6, 8, 30, 0); // 06/08/2020 08:30:00
            Console.WriteLine($"new DateTime(2020, 8, 6, 8, 30, 0): {d4.ToString()}");

            //DateTime d5 = new DateTime(10000, 12, 31); // Data inválida - Ano inválido
            //DateTime d6 = new DateTime(2020, 02, 30); // Data inválida - Dia/Mês inválido

            // Ticks 
            DateTime d7 = new DateTime(637329492389433409); // 13 / 08 / 2020 21:00:38
            Console.WriteLine($"new DateTime(637329492389433409): {d7.ToString()}");            
            Console.WriteLine($"DateTime.MinValue.Ticks: {DateTime.MinValue.Ticks.ToString()}");
            Console.WriteLine($"DateTime.MaxValue.Ticks: {DateTime.MaxValue.Ticks.ToString()}");

            // Campos estáticos
            Console.WriteLine($"DateTime.Now: {DateTime.Now.ToString()}");
            Console.WriteLine($"DateTime.Today: {DateTime.Today.ToString()}");
            Console.WriteLine($"DateTime.UtcNow: {DateTime.UtcNow.ToString()}");

            // TimeSpan
            DateTime d8 = DateTime.Now;
            TimeSpan ts1 = new TimeSpan(48, 30, 30);
            DateTime d9 = d8.Add(ts1);
            Console.WriteLine($"Now Add TimeSpan(48, 30, 30): {d9.ToString()}");
            DateTime d10 = d8.Subtract(ts1);
            Console.WriteLine($"Now Subtract TimeSpan(48, 30, 30): {d10.ToString()}");
            
            DateTime data1 = new DateTime(2020, 3, 22, 22, 55, 43, 422);
            DateTime data2 = new DateTime(2020, 8, 6, 14, 39, 10, 942);
            // Espaço de tempo entras as duas datas
            TimeSpan intervalo = data2 - data1;
            Console.WriteLine($"{data2} - {data1} = {intervalo.ToString()}");
            Console.WriteLine($"Dias no intervalo: {intervalo.Days}");
            Console.WriteLine($"Total de dias: {intervalo.TotalDays}");
            Console.WriteLine($"Horas no intervalo: {intervalo.Hours}");
            Console.WriteLine($"Total de horas: {intervalo.TotalHours}");
            Console.WriteLine($"Minutos no intervalo: {intervalo.Minutes}");
            Console.WriteLine($"Total de minutos: {intervalo.TotalMinutes}");
            Console.WriteLine($"Segundos no intervalo: {intervalo.Seconds}");
            Console.WriteLine($"Total de segundos: {intervalo.TotalSeconds}");
            Console.WriteLine($"Milisegundos no intervalo: {intervalo.Milliseconds}");
            Console.WriteLine($"Total de milisegundos: {intervalo.TotalMilliseconds}");
            Console.WriteLine($"Ticks no intervalo: {intervalo.Ticks}");

            // Criação de TimeSpan
            TimeSpan newTS = new TimeSpan(19, 55, 23);
            Console.WriteLine($"new TimeSpan(19, 55, 23): {newTS.ToString()}");

            TimeSpan tsZero = TimeSpan.Zero;
            Console.WriteLine($"TimeSpan.Zero: {tsZero.ToString()}");

            // Operações com DateTime e TimeSpan
            DateTime data_1 = new DateTime(2020, 3, 29);
            DateTime data_2 = new DateTime(2020, 11, 2, 14, 55, 2);
            TimeSpan timeSpan = new TimeSpan(14, 2, 55, 3);
            Console.WriteLine($"data_1: {data_1} - data_2: {data_2} - TimeSpan: {timeSpan}");
            Console.WriteLine($"data_2 - data_1: {data_2 - data_1}");
            Console.WriteLine($"data_1 == data_2: {data_1 == data_2}");
            Console.WriteLine($"data_1 != data_2: {data_1 != data_2}");
            Console.WriteLine($"data_1 < data_2: {data_1 < data_2}");
            Console.WriteLine($"data_1 <= data_2: {data_1 <= data_2}");
            Console.WriteLine($"data_1 > data_2: {data_1 > data_2}");
            Console.WriteLine($"data_1 >= data_2: {data_1 >= data_2}");
            Console.WriteLine($"data_2 + timeSpan: {data_2 + timeSpan}");

            // Conversão de Date, Time e DateTime para String
            DateTime dataHora = DateTime.Now;
            Console.WriteLine("Data/Hora atual: " + dataHora.ToString());
            Console.WriteLine("Formato MM/dd/yyyy: " + dataHora.ToString("MM/dd/yyyy"));
            Console.WriteLine("Formato dddd, dd MMMM yyyy: " + dataHora.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine("Formato MM/dd/yyyy h:mm: " + dataHora.ToString("MM/dd/yyyy h:mm"));
            Console.WriteLine("Formato MMMM dd:" + dataHora.ToString("MMMM dd"));
            Console.WriteLine("Formato HH:mm:ss: " + dataHora.ToString("HH:mm:ss"));
            Console.WriteLine("Short Date: " + dataHora.ToShortDateString());
            Console.WriteLine("Long Date: " + dataHora.ToLongDateString());
            Console.WriteLine("Short Time: " + dataHora.ToShortTimeString());
            Console.WriteLine("Long Time: " + dataHora.ToLongTimeString());

            // Conversão de String para Date, Time e DateTime
            string strDate1 = "06/08/2020";
            Console.WriteLine(DateTime.Parse(strDate1).ToString());

            string strDate2 = "31/02/2020";
            if (DateTime.TryParse(strDate2, out dataHora))
                Console.WriteLine($"Data válida: {strDate2}");
            else
                Console.WriteLine($"Data inválida: {strDate2}");

            // Outros métodos e propriedades de Date, Time e DateTime
            DateTime dateTime = DateTime.Now;
            Console.WriteLine($"Now AddDays(10): {dateTime.AddDays(10)}"); // Adicionar dias
            Console.WriteLine($"Now AddHours(72) {dateTime.AddHours(72)}"); // Adicionar horas
            Console.WriteLine($"Now AddMinutes(20): {dateTime.AddMinutes(20)}"); // Adicionar minutos
            Console.WriteLine($"Now AddSeconds(150): {dateTime.AddSeconds(150)}"); // Adicionar segundos
            Console.WriteLine($"Now AddTicks(9999999999): {dateTime.AddTicks(9999999999)}"); // Adicionar ticks
            Console.WriteLine($"dateTime.Hour: {dateTime.Hour}");
            Console.WriteLine($"dateTime.Minute: {dateTime.Minute}");
            Console.WriteLine($"dateTime.Second: {dateTime.Second}");
            Console.WriteLine($"dateTime.Day: {dateTime.Day}");
            Console.WriteLine($"dateTime.Month: {dateTime.Month}");
            Console.WriteLine($"dateTime.Year: {dateTime.Year}");
            Console.WriteLine($"dateTime.Ticks: {dateTime.Ticks}");
            Console.WriteLine($"dateTime.DayOfWeek: {dateTime.DayOfWeek}"); // Dia da semana
            Console.WriteLine($"dateTime.DayOfYear: {dateTime.DayOfYear}"); // Dia do ano
            Console.WriteLine($"dateTime.TimeOfDay: {dateTime.TimeOfDay}"); // Hora atual
            Console.WriteLine($"dateTime.ToUniversalTime: {dateTime.ToUniversalTime()}"); // Obtém horário UTC

            Console.WriteLine($"dateTime.IsLeapYear(2020): {DateTime.IsLeapYear(2020)}"); // Verifica se é ano bisexto
            Console.WriteLine($"DateTime.DaysInMonth(2020, 8): {DateTime.DaysInMonth(2022, 2)}"); // Quantidade de dias em um ano/mês                       

            // Nullable DateTime
            DateTime? nullableDateTime = null;
            if (!nullableDateTime.HasValue)
                Console.WriteLine("nullableDateTime sem valor atribuído");
            nullableDateTime = DateTime.Now;
            if (nullableDateTime.HasValue)
                Console.WriteLine($"nullableDateTime: {nullableDateTime}");


            // Math
            Console.WriteLine($"Math.PI: {Math.PI}"); // Constante PI
            Console.WriteLine($"Math.E: {Math.E}"); // Constante E
            Console.WriteLine($"Math.Abs(-10): {Math.Abs(-10)}"); // Valor absoluto
            Console.WriteLine($"Math.Round(99.99): {Math.Round(99.99)}"); // Arredondamento
            Console.WriteLine($"Math.Round(99.98765, 2): {Math.Round(99.98765, 2)}"); // Arredondamento
            Console.WriteLine($"Math.DivRem(200, 30): {Math.DivRem(200, 30, out int resto)} - Resto: {resto}"); // Divisão e resto no mesmo método
            Console.WriteLine($"Math.Sqrt(196): {Math.Sqrt(196)}"); // Raiz quadrada
            Console.WriteLine($"Math.Max(300, 301): {Math.Max(300, 301)}"); // Maior valor
            Console.WriteLine($"Math.Min(300, 301): {Math.Min(300, 301)}"); // Menor valor
            Console.WriteLine($"Math.Truncate(99.99): {Math.Truncate(99.99)}"); // Parte integral
            Console.WriteLine($"Math.Pow(2, 10): {Math.Pow(2, 10)}"); // Exponenciação
            Console.WriteLine($"Math.Sin(50): {Math.Sin(50)}"); // Seno
            Console.WriteLine($"Math.Cos(200): {Math.Cos(200)}"); // Cosseno
            Console.WriteLine($"Math.Tan(150): {Math.Tan(150)}"); // Tangente
            Console.WriteLine($"Math.Exp(5): {Math.Exp(5)}"); // Exponenciação de E
            Console.WriteLine($"Math.Log(100): {Math.Log(100)}"); // Logaritmo
            Console.WriteLine($"Math.Log10(100): {Math.Log10(100)}"); // Logaritmo base 10

            Console.ReadLine();
        }
    }
}
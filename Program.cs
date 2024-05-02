using System;
using System.Globalization;
using System.Net.NetworkInformation;

namespace Moedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            ArredondandoValor();
        }

        static void Moeda()
        {
            decimal valor = 10.25m;     //usar o decimal quando for se tratar de moeda
        }

        static void FormatandoMoedas()
        {
            decimal valor = 10.25m;

            Console.WriteLine(valor.ToString(CultureInfo.CreateSpecificCulture("pt-BR")));  //Formata o valor para o padrão usado na região especificada
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));  //"C" Formata colocando em padrão de moeda (R$ 10,25)
            Console.WriteLine(valor.ToString("N", CultureInfo.CreateSpecificCulture("pt-BR")));  //"N" Formata sem o cifrão (10,25)
            Console.WriteLine(valor.ToString("P", CultureInfo.CreateSpecificCulture("pt-BR")));  //"P" Formata com a porcentagem (1.025,00%)
        }

        static void ArredondandoValor()
        {
            decimal valor = 10248.25m;

            Console.WriteLine(Math.Round(valor));       //Arredonda o valor (10248)
            Console.WriteLine(Math.Ceiling(valor));     //Arredonda o valor para cima (10249)
            Console.WriteLine(Math.Floor(valor));       //Arredonda o valor para baixo (10248)
        }
    }
}
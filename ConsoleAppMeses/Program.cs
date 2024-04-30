using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMeses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mes = { "Esse dígito é inválido. Tente novamente", "janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };

            Console.WriteLine("Qual o número do mês que você deseja ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("O mês que você escolheu foi:" + mes[m]);

            Console.ReadKey();


        }
    }
}

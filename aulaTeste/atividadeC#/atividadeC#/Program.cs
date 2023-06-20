using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, media;

            Console.WriteLine("=====================");
            Console.WriteLine(":: Calcular Média ::");
            Console.WriteLine("=====================");
            Console.WriteLine("digite o numero1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o numero2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o numero3: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o numero4: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            media = (num1 + num2 + num3 + num4)/4;

            Console.WriteLine("=====================");
            Console.WriteLine("::   A Média é:    ::"+media);
            Console.WriteLine("=====================");













        }
    }
}

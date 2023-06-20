using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, total;

            Console.WriteLine("digite o numero 1: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o numero 2: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            total = numero1 + numero2;
            
            Console.WriteLine("Sua media e " + total);
            Console.WriteLine($"o total e: {total}");
            Console.WriteLine("a soma so {0} e {1} é : {2}",numero1,numero2,total );
            Console.WriteLine("numero 1.........;{0,5}", numero1);
            Console.WriteLine("numero 2.........;{0,5}", numero2);
            Console.WriteLine("total\n......\t......;{0,5:d}",total);

        }
    }
}

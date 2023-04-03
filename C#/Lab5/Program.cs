namespace Task2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static void Main(string[] args)
        {
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.print());
            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.print());
            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.print());
            Duration D4 = new Duration(666);
            Console.WriteLine(D4.print());


            D3 = D1 + D2;
            Console.WriteLine(D3.Seconds);

            D3 = D1 + 7800;
            Console.WriteLine(D3.Seconds);
            if (D1 > D2)
            {
                Console.WriteLine("D1 > D2");
            }
            else
            {
                Console.WriteLine("D1 < D2");
            }
        }
    }
}

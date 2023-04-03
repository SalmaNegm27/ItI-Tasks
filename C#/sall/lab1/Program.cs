namespace lap1
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

            //task1
            //.WriteLine("Hello World");

            //task2(take char return asci)
            //Console.WriteLine("Enter your charcter");
            //char x = char.Parse( Console.ReadLine());

            //Console.WriteLine((int)x);


            ////task3(vice versa)
            //Console.WriteLine("Enter a ASCII");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine((char)x);   


            //task4(take integer and return hexa)
            //Console.WriteLine("enter a number");
            //int num= int.Parse(Console.ReadLine());
            //Console.WriteLine($"{num:x}");

            //task5(return +,-,*,/)
            Console.WriteLine("enter the first number");
            int firstnum = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int secondnum = int.Parse(Console.ReadLine());
            Console.WriteLine($"the sum of two numbers is: {firstnum + secondnum}\nthe substraction of two numbers is: {firstnum - secondnum}\nthe multiplication of two numbers is: {firstnum * secondnum}");

        }
    }
}

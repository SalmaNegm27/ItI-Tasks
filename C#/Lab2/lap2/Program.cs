namespace lap2
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        #region tak1
        public static int sum(int a, int b)
        {
            if (a == b) return (a + b) * 3;
            else return a + b;
        }

        #endregion
        #region task2
        public static int absloute(int x)
        {
            if (x > 51)
                return (x - 51) * 3;
            else
                return (51 - x);

        }

        #endregion
        #region task3
        public static bool Check(short x, short y)
        {
            // ask eng/Naser!!!!!!
            //that would suggest that byte + byte should be defined to return short, and that int + int should return long, neither of which is true.
            short sumition = (short)(x + y);
            if (sumition == 30)
                return true;
            else
                return false;
        }
        #endregion
        #region task4
        public static bool CheckMultiple(ushort x)
        {
            if (x % 3 == 0 || x % 7 == 0) return true;
            else return false;
        }
        #endregion
        #region task5
        public static bool CheckRange(ushort x, ushort y)
        {
            // you can use ienumrable
            if (x >= 100 && x <= 200 && y >= 100 && y <= 200)
                return true;
            else return false;
        }

        #endregion
        #region task6
        public static bool CheckRange(ushort x, ushort y, ushort z)
        {
            // you can use ienumrable
            if (x >= 20 && x <= 50 || y >= 20 && y <= 50 || z >= 20 && z <= 50)
                return true;
            else return false;
        }
        #endregion
        #region task7
        public static void CheckLargestNum(int x, int y, int z)
        {
            Console.WriteLine("The Max Number is: " + Math.Max(x, Math.Max(y, z)));
        }
        #endregion
        #region task8
        public static int CheckNearset(int x, int y)
        {
            const int n = 100;
            int val1 = Math.Abs(x - n);
            int val2 = Math.Abs(y - n);

            return val1 == val2 ? 0 : (val1 < val2 ? x : y);

        }

        #endregion
        #region task9
        public static bool CheckRange(int x, int y)
        {
            const int val1 = 50;
            const int val2 = 60;
            return x >= val1 && x <= val2 && y >= val1 && y <= val2 ? true : false;
        }
        #endregion
        #region task10
        public static int CheckLarger(int x, int y)
        {
            const int val1 = 20;
            const int val2 = 30;

            return x >= val1 && x <= val2 && y >= val1 && y <= val2 ? Math.Max(x, y) : 0;
        }
        #endregion
        #region task11

        public static string RepeatingStr(string str, int x)
        {
            return string.Concat(Enumerable.Repeat(str, x));

        }
        #endregion
        #region task12
        public static bool CheckFiveNumber(int x, int y)
        {
            const int n = 5;
            return (x == n || y == n || x + y == n || x - y == n) ? true : false;
        }

        #endregion
        #region task13
        public static bool CheckDivision(ushort x)
        {
            return x % 3 == 0 || x % 7 == 0 ? true : false;
        }

        #endregion
        #region task14
        public static string Division(int x)
        {
            if (x % 3 == 0 && x % 5 == 0)
                return "Fizz Buzz";
            else if (x % 3 == 0)
                return "Fizz";
            else if (x % 5 == 0)
                return "Buzz";
            else
                return "The Number Cant Division By 7 or 3";

        }
        #endregion
        #region task15
        public static bool ChackSumation(int x, int y, int z)
        {
            if (x + y == z) return true;
            else if (x + z == y) return true;
            else if (y + z == x) return true;
            else return false;
        }
        #endregion
        #region task16
        public static bool ChackGreaterNumber(int x, int y, int z)
        {
            return (y > x) && (z > y) ? true : false;
        }
        #endregion
        #region task17
        public static void MultiplicationTable(int x)
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{x} * {i} = {x * i}");
        }

        #endregion
        #region task18
        public static void MinMax(int x, int y, int z)
        {
            Console.WriteLine("Max Value is:" + Math.Max(x, Math.Max(y, z)));
            Console.WriteLine("Min Value is:" + Math.Min(x, Math.Min(y, z)));
        }

        #endregion
        #region task19
        public static void SumExceed()
        {
            int sum = 0;
            while (sum < 400)
            {
                Console.Write("enter number less than 400:");
                int num1 = int.Parse(Console.ReadLine());
                sum += num1;
            }
        }

        #endregion
        #region task20

        public static void SelectionMenu(int x, int y)
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Choose from a,b,c,d,e");
                string str = Console.ReadLine();
                switch (str)
                {
                    case "a":
                    case "A":
                        Console.WriteLine("The Sumition of two Numbers :" + (x + y));


                        break;

                    case "b":
                    case "B":

                        Console.WriteLine("The Substriction of two Numbers:" + (x - y));


                        break;
                    case "c":
                    case "C":
                        Console.WriteLine("The Multiplication of two Numbers:" + (x * y));


                        break;
                    case "d":
                    case "D":
                        if (x == 0 || y == 0)
                        {
                            Console.WriteLine("Cant division by zero");

                        }
                        else
                        {

                            Console.WriteLine("The Division of two Numbers:" + (x / y));
                        }


                        break;
                    case "e":
                    case "E":
                        Console.WriteLine("Bye Bye");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Choose a valid character");
                        break;
                }
            }
            while (flag);
        }
        #endregion

        #region task21
        public static void EvenandOdd(int x, int y)
        {
            int sumeven = 0;
            int sumodd = 0;
            Console.WriteLine("Even");
            for (int i = x; i <= y; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                    sumeven += i;

                }
            }
            Console.WriteLine("\n" + sumeven);

            Console.WriteLine("\nOdd");
            for (int i = x; i <= y; i++)
            {
                if (i % 2 != 0)
                {

                    Console.Write(i + " ");
                    sumodd += i;
                }

            }
            Console.WriteLine("\n" + sumodd);


            Console.WriteLine(sumeven + sumodd);



        }


        #endregion

        public static void Main(string[] args)
            {
            //Console.WriteLine("Enter String you want repeat");
            //string str1 = Console.ReadLine();
            //Console.Write("enter the first  number:");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("enter the second number:");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.Write("enter the second number:");
            //int num3 = int.Parse(Console.ReadLine());

            #region task1
            //Console.WriteLine("Enter the first number:");
            //int firstnumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second number:");
            //int secondnumber =int.Parse(Console.ReadLine());
            //Console.WriteLine(sum(firstnumber, secondnumber));

            #endregion

            #region task2
            //Console.WriteLine("Enter a number from 0 to 51");
            //int  number = int.Parse(Console.ReadLine());
            //Console.WriteLine(Absloute(number));

            #endregion
            #region task3
            //Console.WriteLine("Enter the first number:");
            //short firstnumber = short.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second number:");
            //short secondnumber = short.Parse(Console.ReadLine());
            //Console.WriteLine(Check(firstnumber, secondnumber)); 
            #endregion
            #region task4
            //Console.Write("Enter a Number to check multiplication:");
            //ushort num = ushort.Parse(Console.ReadLine());
            //Console.WriteLine(CheckMultiple(num)); 
            #endregion
            #region task5
            //Console.Write("Enter The First  Comprison Number:");
            //ushort num1 = ushort.Parse(Console.ReadLine());
            //Console.Write("Enter The Second Comprison Number:");
            //ushort num2 = ushort.Parse(Console.ReadLine());
            //Console.WriteLine(CheckRange(num1,num2));
            #endregion
            #region task6
            //Console.Write("Enter The First  Comprison Number:");
            //ushort num1 = ushort.Parse(Console.ReadLine());
            //Console.Write("Enter The Second Comprison Number:");
            //ushort num2 = ushort.Parse(Console.ReadLine());
            //Console.Write("Enter The Third Comprison Number:");
            //ushort num3 = ushort.Parse(Console.ReadLine());

            //Console.WriteLine(CheckRange(num1, num2,num3)); 
            #endregion
            #region task7
            //Console.Write("Enter The First  Comprison Number:");
            //ushort num1 = ushort.Parse(Console.ReadLine());
            //Console.Write("Enter The Second Comprison Number:");
            //ushort num2 = ushort.Parse(Console.ReadLine());
            //Console.Write("Enter The Third Comprison Number:");
            //ushort num3 = ushort.Parse(Console.ReadLine());

            //CheckLargestNum(num1,num2, num3); 
            #endregion
            #region task8
            //Console.Write("enter the first  number:");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("enter the second number:");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine( CheckNearset(num1,num2)); 
            #endregion
            #region task9
            //Console.WriteLine(CheckRange(num1, num2)); 
            #endregion
            #region task10
            //Console.WriteLine(CheckLarger(num1, num2));  
            #endregion
            #region task11
            //Console.WriteLine(RepeatingStr(str1, num1));  
            #endregion
            #region task12
            //Console.WriteLine(CheckFiveNumber(num1, num2)); 
            #endregion
            #region task13
            //Console.Write("enter the first  number:");
            //ushort num1 = ushort.Parse(Console.ReadLine());
            //Console.WriteLine(CheckDivision(num1)); 
            #endregion
            #region task14
            //Console.WriteLine(Division(num1)); 
            #endregion
            #region task15
            //Console.WriteLine(ChackSumation(num1,num2,num3));

            #endregion
            #region task16
            //Console.WriteLine(ChackGreaterNumber(num1,num2,num3)); 
            #endregion
            #region task17
            //MultiplicationTable(num1); 
            #endregion
            #region task18
            //MinMax(num1, num2, num3);

            #endregion
            #region task19
            //SumExceed(); 
            #endregion
            #region task20
            //SelectionMenu(num1, num2); 
            #endregion
            #region task21
            //EvenandOdd(num1, num2); 
            #endregion

            int[] arr = {};
            Console.WriteLine(arr.GetHashCode());
        }

    }
}




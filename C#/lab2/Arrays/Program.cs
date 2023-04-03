namespace Arrays
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlTypes;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void DeplicatedArray(int[] arr)
        {
            //n*n complxicity not recomended for inside for 
            for(int i =0; i<arr.Length; i++)
            {
                int count = 0;
                for (int j =0; j<arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        count++;
                }
                Console.WriteLine($"{arr[i]} accurs :{count} Times");
            }

        }
        
        #region task7
        public static void CheckUniqueness()
        {
            bool flag = true;
            int[] arr = new int[10];
            do
            {
                Console.WriteLine("Please enter a unique elment");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                // arr.distinct.count return number of distincit elment

                if (arr.Length != arr.Distinct().Count())
                {
                    Console.WriteLine("Not Unique!!!!");
                }
                else { flag = false; }

            }
            while (flag);

        } 
        #endregion
        #region task8
        public static double GetPower(double x, double y)
        {
            return Math.Pow(x, y);
        }

        #endregion
        static void Main(string[] args)
        {
            #region task1
            //Task1 arrtask1 = new Task1();
            //arrtask1.FillArray();
            //arrtask1.DisplayArray();
            //arrtask1.SumArray();
            //arrtask1.GetEven();
            //arrtask1.GetOdd();
            //arrtask1.GetMax();
            //arrtask1.GetMin();
            //arrtask1.GetAvg();
            #endregion
            #region task2,3
            Task2 task2 = new Task2();
            //task2.EnterDim();
            //task2.FillArray();
            //task2.DisplayArray();
            //task2.SumArrar();
            //task2.AvgArray();
            //task2.SelectionMenue();

            #endregion
            #region task5
            //Task5 task5 = new Task5();
            //task5.ConcatArr(); 
            #endregion

            //Console.WriteLine("Enter array size");
            //int[] array = new int[int.Parse(Console.ReadLine())];
            //    Console.WriteLine("Fill Array");
            //for(int i=0;i<array.Length;i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());

            //}
            //DeplicatedArray(array);

            #region tas7
            CheckUniqueness(); 
            #endregion

            #region task8
            //Console.Write("Enter the base number");
            //double num1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter the Power number");
            //double num2 = double.Parse(Console.ReadLine());
            //Console.WriteLine(GetPower(num1,num2)); 
            #endregion


        }
    }
}

namespace Arrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    struct Task1
    {
        int[] arr;
        public void setArr(int[] _arr)
        {
            arr = _arr;
        }
        public int[] Getarr()
        {
            return arr;
        }

        public  void FillArray()
        {
              Console.WriteLine("Enter array size"); 
             arr = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}]=");
                arr[i] = int.Parse(Console.ReadLine());
                //Console.WriteLine($"arr[{i}]= {arr[i]}");
            }
        }
        public  void DisplayArray()
        {

            Console.WriteLine("Array Values ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}]={arr[i]}");
            }
        }
        public void SumArray()
        {
            int sum = 0;
            for(int i =0; i<arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"The Sumation of Array: {sum}");
        }
        public void GetEven()
        {
            Console.Write("The Even  number : ");
            for ( int i=0; i<arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public void GetOdd()
        {
            Console.Write("The Odd  number : ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                    Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

        }
        public void GetMax()
        {
            int max = arr[0];
            Console.Write("The Max  number : ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
                Console.WriteLine(max);
        }
        public void GetMin()
        {
            int min = arr[0];
            Console.Write("The Min  number : ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine(min);
        }
        public void GetAvg()
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            float avg = sum/ arr.Length;
            Console.WriteLine($"The Average  of Array: {avg}");
        }

        



    }
}

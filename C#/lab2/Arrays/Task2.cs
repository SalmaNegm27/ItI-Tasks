namespace Arrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   struct Task2
    {
        int[,] arr;
        public void EnterDim()
        {
            Console.Write("Enter Number of Rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter Number of Coloums: ");
            int cols = int.Parse(Console.ReadLine());
            arr= new int[rows, cols];
        }
        public void FillArray()
        {
           
            Console.WriteLine("Fill Array");
            for(int i=0; i < arr.GetLength(0); i++)
            {
                
                for(int j=0; j < arr.GetLength(1);j++)
                {
                    Console.Write($"Array of [{i}][{j}] = ");
                    arr[i,j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("----------------------");
            }

        }
        public void DisplayArray()
        {
            Console.WriteLine("Array Of Values");
            for (int i = 0; i < arr.GetLength(0); i++)
            {

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                     
                }
            }
            Console.WriteLine();
        }

        public void SumArrar()
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
              for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
            }
                Console.WriteLine(sum);
        }

        public void AvgArray()
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    sum += arr[i, j];
                }

            }
            float avg = sum / arr.Length;
            Console.WriteLine(avg);
        }
        public void SelectionMenue()
        {
                bool flag = true;
            do
            {
                Console.WriteLine("Selecet from 1,2,3,4,5.6");
                char x = char.Parse(Console.ReadLine());
                switch (x)
                {
                    case '1':
                        EnterDim();
                        break;
                    case '2':
                        FillArray();
                        break;
                    case '3':
                        DisplayArray();
                        break;
                    case '4':
                        SumArrar();
                        break;
                    case '5':
                        AvgArray();
                        break;
                    case '6':
                        Console.WriteLine("Exist");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Make sure you choose correct choice");
                        break;
                }

            } while (flag);

            }



    }
}

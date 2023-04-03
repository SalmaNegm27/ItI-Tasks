namespace Arrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public struct Task5
    {
        public void  ConcatArr()
        {
            Console.Write("Enter the size of the first array");
            int[] arr1 = new int[int.Parse(Console.ReadLine())];
            for(int i =0; i< arr1.Length; i++)
            {
                Console.Write($"arrar[{i}] =");
                arr1[i]= int.Parse(Console.ReadLine());
                //Console.WriteLine($"arr1[{i}]={arr1[i]}");
            }
            Console.WriteLine("-----------");
            Console.Write("Enter the size of the second array");
            int[] arr2 = new int[int.Parse(Console.ReadLine())];
            for (int j = 0; j < arr2.Length; j++)
            {
                Console.Write($"arrar[{j}] = ");
                arr2[j] = int.Parse(Console.ReadLine());
                //Console.WriteLine($"arr2[{j}]={arr2[j]}");
            }

            int[] result = arr1.Concat(arr2).ToArray();
            Console.WriteLine(String.Join(",", result));
        }

    }

    }


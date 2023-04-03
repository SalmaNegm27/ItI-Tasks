namespace Lap6
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.ExceptionServices;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void GetEmployeeWithLongestClientArray(Employee[] arr)
        {
            for (int i=0; i<arr.Length; i++)
            {
                arr[i].ShowEmployeeDetail();
            }
        }
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[2];
          
              employees[0] = new HREmployees() { ID= 1 , Name ="salma" ,Salary =100};
            employees[1] = new PREmployees() { ID = 2, Name = "Nada", Salary = 200 };



            HREmployees hrone = new HREmployees();
            hrone.Salary = 4000;
            HREmployees hrtwo = new HREmployees();
            hrtwo.Salary = 1000;

            HREmployees hrthree = hrone + hrtwo;
            Console.WriteLine(hrthree.Salary);
            if (hrone > hrtwo)
            {
                Console.WriteLine("hrone > hrtwo");
            }
            else
            {
                Console.WriteLine("hrone < hrtwo");
            }




        }
    }
}

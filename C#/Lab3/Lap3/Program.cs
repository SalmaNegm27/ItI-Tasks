namespace Lap3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {

        static void Main(string[] args)
        {
            #region getter and setter
            //Employee employess = new Employee();
            //employess.SetId(1);
            //employess.SetGender("F");
            //employess.SetSalary(5000);
            //employess.SetHiringdate(new Hiringdate(10,2,200));
            //employess.SetSecurityLevel(SecurityLevel.Secretery);
            //Console.WriteLine(employess.Print()); 
            #endregion
            try
            {
                Company company = new Company("E-Commerce", new Department[]
            {
                 new Department(1,"Tanta", "Amr", new Employee[]
            {
               new Employee(1,"nada","F",4000,new Hiringdate(10,10,2000),SecurityLevel.Guest),
               new Employee(2,"mohamed","M",6000,new Hiringdate(1,12,2022),SecurityLevel.Devrloper),
               new Employee(3,"moatz","F",8000,new Hiringdate(10,8,2020),SecurityLevel.Secretery)
            }) ,
                 new Department(2,"Alex", "Amr", new Employee[]
            {
               new Employee(3,"hany","F",7000,new Hiringdate(12,9,2000),SecurityLevel.Secretery),
               new Employee(4,"negm","M",1000,new Hiringdate(20,10,2022),SecurityLevel.DBA),
               new Employee(5,"saly","F",9000,new Hiringdate(6,3,2020),SecurityLevel.Guest)
            })
           });
                #region department variable

                //Department department = new Department("Alex", "Salma Negm", new Employee[]
                //{
                //   new Employee(1,"F",4000,new Hiringdate(10,10,2000),SecurityLevel.Guest),
                //   new Employee(2,"M",6000,new Hiringdate(1,12,2022),SecurityLevel.Guest),
                //   new Employee(3,"F",8000,new Hiringdate(10,8,2020),SecurityLevel.Guest)
                //});
                //Console.WriteLine(department.Print()); 
                #endregion
                Console.WriteLine(company.Print());

                Console.WriteLine("Choose from a,b,c,d,e,f,g");
                char str = char.Parse(Console.ReadLine());
                switch (str)
                {
                    case 'a':
                    case 'A':
                        company.DisplayDeptName();
                        break;
                    case 'b':
                    case 'B':
                        Console.WriteLine("salmaaa");
                        break;
                    case 'c':
                    case 'C':
                        Console.WriteLine("Display total Number of employees in compant");
                        break;
                    case 'd':
                    case 'D':
                        Console.WriteLine("Search for Employee ID in Dept");
                        break;
                    case 'e':
                    case 'E':
                        Console.WriteLine();
                        break;
                    case 'f':
                    case 'F':
                        Console.WriteLine("Delete");
                        break;
                    case 'g':
                    case 'G':
                        Console.WriteLine("Exist");
                        break;
                    default:
                        Console.WriteLine("choose a valid character");
                        break;

                }
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}

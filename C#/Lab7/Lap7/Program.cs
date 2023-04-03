namespace Lap7
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
            Student std = new Student(1,"@salma negm","salma","Nada123","negm.com");
            Authentcation authentcation = new Authentcation(std);
            Console.WriteLine(authentcation.LoginMethod("salma", "Nada123", "negm.com")); 
            Console.WriteLine(authentcation.LoginMethod("salma", "Nada321", "negm.com"));


            authentcation.ForgetPassword("salma");


            authentcation.ResetPassword(1,"Nada123","Salma123");
            Console.WriteLine(std.UserPass);


            
        }
    }
}

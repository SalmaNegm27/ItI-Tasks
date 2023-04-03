namespace Lap7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Authentcation
    {
        public Student Student { get; set; }
        public Authentcation(Student student)
        {
            Student = student;
        }

        public  bool LoginMethod(string userName,string userPass , string userEmail)
        { 
           if(Student.UserName == userName && Student.UserPass== userPass && Student.Email ==userEmail)  return true;    
           return false;
        }
        public bool LoginMethod(string userEmail, string userPass)
        {
            if (Student.UserPass == userPass && Student.Email == userEmail) return true;
            return false;

        }

        public bool LoginMethod(int id , string userPass) {
            if (Student.ID == id && Student.UserPass == userPass) return true;
            return false;

        }

        public bool LoginMethod( string userEmail ,int id)
        {
            if (Student.Email == userEmail &&Student.ID == id ) return true;
            return false;

        }

        public void ForgetPassword(string userName)
        {
         
            if (Student.UserName == userName)
            {
                Console.WriteLine(Student.UserPass);
               
            }
            else
                Console.WriteLine($"User with UserName {userName} Not Found !!!"); 
        }

        public void ForgetPassword(string userEmail , int id)
        {

            if (Student.Email == userEmail && Student.ID == id)
            {
                Console.WriteLine(Student.UserPass);

            }
            else
                Console.WriteLine($"User with UserName {userEmail} and Id {id} Not Found !!!");
        }

        public void ForgetPassword( int id)
        {

            if (Student.ID == id)
            {
                Console.WriteLine(Student.UserPass);

            }
            else
                Console.WriteLine($"User with U Id {id} Not Found !!!");
        }

        public bool ResetPassword(int id , string oldPassword , string newPassword)
        {
            if(Student.ID == id && Student.UserPass== oldPassword)
            {
                Student.UserPass = newPassword;
                return true;
            }

            return false;

        } 
        public bool ResetPassword(string userEmail , string oldPassword , string newPassword)
        {
            if(Student.Email==userEmail && Student.UserPass== oldPassword)
            {
                Student.UserPass = newPassword;
                return true;
            }

            return false;

        }

        public bool ResetPassword(int id ,string userEmail , string oldPassword , string newPassword)
        {
            if(Student.ID==id &&Student.Email==userEmail && Student.UserPass== oldPassword)
            {
                Student.UserPass = newPassword;
                return true;
            }

            return false;

        }

        

    }
}

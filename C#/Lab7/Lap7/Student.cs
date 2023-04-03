namespace Lap7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string Email { get; set; }


        public Student(int iD, string name, string userName, string userPass, string email)
        {
            ID = iD;
            Name = name;
            UserName = userName;
            UserPass = userPass;
            Email = email;
        }

        public string Print()
        {
            return $"Student {Name} with id {ID} , the UserName is {UserName} , and E-mail {Email}";
             
        }
       //public override bool LoginMethod(string username, int userpass, string useremail)
       // {
       //     if (username == UserName && useremail== UserEmail && userpass == UserPass) return true;
       //     return false;
       // }

       // public bool LogimMethod(string username,int userpass)
       // {
       //     if (username == UserName && userpass == UserPass) return true;
       //     return false;
       // }

       // public bool LogimMethod(int id, int userpass)
       // {
       //     if (id == ID && userpass == UserPass) return true;
       //     return false;
       // }

       // public bool LogimMethod(int id, string useremail)
       // {
       //     if (id == ID && useremail == UserEmail) return true;
       //     return false;
       // }

      
    }

}

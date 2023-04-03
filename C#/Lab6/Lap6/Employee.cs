namespace Lap6
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Employee
    {
        private int _id;
        private string _name;
        private int _salary;
        Client[] _clients;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public Client[] Clients
        {
            get { return _clients; }
            set { _clients = value; }
        }
        public Employee()
        {
            ID= 0;
            Name= "";
            Salary= 0;
        }
       
        public Employee(int id, string name, int salary)
        {
            _id = id;
            _name = name;
            _salary = salary;
        }
        public Employee(int id , string name , int salary , Client[] clients)
        {
            _id = id;
            _name = name;
            _salary = salary;
            _clients = clients;

        }


        public abstract string ShowEmployeeDetail();

    }
}

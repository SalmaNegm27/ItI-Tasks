namespace Lap6
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Client
    {
        private int _id;
        private string _name;
        private string _city;

        public string  City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public Client(int id , string name , string city)
        {
            _id= id;
            _name= name;
            _city= city;
        }
        public string ShowClientDetail()
        {
            return $"Client Name is {Name} with ID {ID} in City {City}";
        }

    }
}

namespace Lap3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;

    struct Hiringdate
    {
        int day;
        int month;
        int year;

        public Hiringdate(int _day , int _month , int _year)
        {
            day= _day;
            month= _month;
            year= _year;
        }
        public void SetDay(int _day)
        {
            if ( _day >=1 && _day <=31 )
            {
                day = _day;
            }
           else
                Console.WriteLine("Not valid day");
        }
        public int GetDay() { return day; }

        public void SetMonth(int _month)
        {
            if (_month >= 1 && _month <= 12)
            {
                month = _month;
            }
            else
                Console.WriteLine("Not valid Month");
        }
        public void SetYear(int _year)
        {
            if (_year >=1990 && _year <= 2023)
            {
                year= _year; 
            }
            else
                Console.WriteLine("Not valid Year");
        }
        public string Print()
        {
            return $"{day}/{month}/{year}";
            
        }


    }
     enum SecurityLevel
      {
         Guest,
         Devrloper,
         Secretery,
         DBA
      }

    struct Employee
    {
        int id;
        string name;
        string gender;
        double salary;
        Hiringdate hiringdate;
        SecurityLevel securityLevel;

        public Employee(int _id,string _name, string _gender, double _salary , Hiringdate _hiringdate,SecurityLevel _securityLevel)
        {
           
            id = _id;
            name = _name;
            gender= _gender;
            salary= _salary;
            hiringdate= _hiringdate;
            securityLevel = _securityLevel;

        }

       #region Getter and Setter before prop
		//public void SetId(int _id)
       // public int GetId() { return id; }
        //public void SetGender(string _gender)
        //{
        //    if (_gender == "M" || _gender == "F")
        //    {
        //        gender = _gender; 
        //    }
        //    else
        //    {

        //        Console.WriteLine("Please Enter Valid Gender");
        //    }
        //}

        //public string GetGender() { return gender; }
        //public void SetSalary(double _salary)
        //{
        //    salary= _salary;
        //}
        //public double GetSalary() { return salary; }
        //public Hiringdate GetHiringdate()
        //{
        //    return hiringdate;
        //}
        //public void SetHiringdate(Hiringdate _hiringdate)
        //{
        //    hiringdate = _hiringdate;
        //}
        //public SecurityLevel GetSecurityLevel() { return securityLevel; }
        //public void SetSecurityLevel(SecurityLevel _securityLevel)
        //{
        //    securityLevel = _securityLevel;
        //}


	#endregion 
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Gender
        {
            get { return gender; }
            // we can use enum here also
            set
            {
                if (gender == "M" || gender == "F")
                {
                    gender = value;
                }
                else
                {

                    Console.WriteLine("Please Enter Valid Gender");
                }
            }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public Hiringdate Hiringdate
        {
            get { return hiringdate; }
            set { hiringdate = value; }
        }
        public SecurityLevel SecurityLevel
        {
            get { return securityLevel; }
            set { securityLevel = value; }
        }


        public string  Print()
        {
           return  $"id={ID},salary={Salary},gender={Gender}, hiringdate ={Hiringdate.Print()},SecurityLevel={SecurityLevel}";
        }

    }
}

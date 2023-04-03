namespace Lap3
{
    using System;
    using System.CodeDom;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    struct  Department
    {
        int id;
        string deptName;
        string manger;
        Employee[] employees;

        public Department(int _id,string _deptName, string _mamger, Employee[] _employees)
        {
            id= _id;
            int[] arr = new int[_employees.Length];
            for (int i = 0; i< _employees.Length; i++)
            {
                arr[i] = _employees[i].ID;
            }
            if (arr.Distinct().Count() < arr.Length)
                throw new Exception($"The department with name{_deptName} has depllicated id");
            deptName= _deptName;
            manger= _mamger;
            employees= _employees;
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string DeptName
        {
            get { return deptName; }
            set { deptName = value; }
        
        }
        public string Manger
        {
            get { return manger; }
            set { manger = value; }

        }

        public Employee[] Employees
        {
            get { return employees; }
            set { employees = value; }
        }

        public string this[int _deptId]
        {
            get
            {
                for (int i = 0; i < employees.Length; i++)
                {
                    if (employees[i].ID == _deptId)
                    {
                        return employees[i].Name;
                    }

                }
                return $"No Employess For THis {_deptId}";
            }
            set
            {
                for (int i =0; i<employees.Length; i++)
                {
                    if (employees[i].ID == _deptId)
                    {
                        employees[i].Name = value;
                    }
                }
            }
        }

       
        public string Print()
        {
            string str = "";
            for(int i=0; i<employees.Length; i++ )
            {
                str += employees[i].Print()+"\n";
            }
            return $"Department Name ={DeptName}, MangerName={Manger},Employees:\n{str}";
        }

    }
}

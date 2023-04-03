namespace Lap3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Policy;
    using System.Text;
    using System.Threading.Tasks;

    struct Company
    {
        private string companyName;
        Department[] departments;

        public Company(string _companyName, Department[] _departments)
        {
            companyName = _companyName;
            departments = _departments;
            int[] arr = new int[_departments.Length];
            string[] arr2 = new string[_departments.Length];

            for (int i = 0; i < _departments.Length; i++)
            {
                arr[i] = _departments[i].ID;
                arr2[i] = _departments[i].DeptName;
            }
           
                if (arr2.Distinct().Count() < arr2.Length)
                {
                    throw new Exception($"The department with name {_companyName} has depllicated Department  Name");  
            }
            if (arr.Distinct().Count() < arr.Length)
                throw new Exception($"The department with name {_companyName} has depllicated Department  id");
        }
        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public Department[] Department
        {
            get
            {
                return departments;
            }
            set {departments = value;}
        }

       

        public void DisplayDeptName()
        {
            for (int i =0; i< departments.Length; i++)
            {
                Console.WriteLine(departments[i].DeptName);
            }
        }



        //public string this [string _compName]
        //{
        //    set
        //    {
        //        for (int i=0; i<departments.Length; i++) {
        //            if (departments[i].DeptName == _compName)
        //            {
        //                departments[i].DeptName = value;
        //            }

        //        }
        //    }
        //    get
        //    {
        //        for (int i =0; i<departments.Length; i++)
        //        {
        //            if (departments[i].DeptName == _compName)
        //                return departments[i].DeptName;
        //        }
        //        return $"No Result";
        //    }

        //}
        public string Print()
        {
            string str = "";
            for (int i = 0; i < departments.Length; i++)
            {
            #region Validate deotName
                //for (int j = 0; j < departments.Length; j++)
                //{
                //    if (departments[i].DeptName == departments[j].DeptName)
                //    {
                //        Console.WriteLine("the department cant be duplicated");

                //    }


                #endregion  
                str += departments[i].Print()+"\n";
            }
            
                return $"Company Name is {companyName} , Departments:\n{str} ";

        }

        

    }
}

namespace Lap6
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HREmployees : Employee
    {
        public HREmployees() : base()
        {
        }

        public override string ShowEmployeeDetail()
        {
            return $"HREmployee Id {ID} , HREmployee Name{Name} , HREmployee Salary {Salary}";
        }
        public static HREmployees operator +(HREmployees h1, HREmployees h2)
        {
            return new HREmployees()

            {
                Salary = h1.Salary + h2.Salary

            };
        }

        public static bool operator >(HREmployees d1, HREmployees d2)
        {
            return d1.Salary > d2.Salary;
        }
        public static bool operator <(HREmployees d1, HREmployees d2)
        {
            return d1.Salary > d2.Salary;
        }

    }
}


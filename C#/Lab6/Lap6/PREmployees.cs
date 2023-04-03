namespace Lap6
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PREmployees : Employee
    {
        public PREmployees() : base()
        {
        }

        public override string ShowEmployeeDetail()
        {
            return $"PREmployee Id {ID} , PREmployee Name{Name} , PREmployees Salary {Salary}";
        }
    }
}

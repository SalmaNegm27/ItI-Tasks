namespace Task1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CheckingAccount : Account
    {
        public double Fee { get; set; }

        public override void Credit(double amount)
        {
            base.Credit(amount);
            AccoutBalance -= Fee;
        }
        public override void Depit(double amount)
        {
            base.Depit(amount);
            AccoutBalance -= Fee;

            //// best synatx عشان لو الراجل ضحك علينا مثلا
            //base.Depit(amount + Fee);
         

        }

    }
}

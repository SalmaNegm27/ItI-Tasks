namespace Task1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Account
    {
        public double AccoutBalance { get; set; }

        public virtual void Credit(double amount)
        {
            AccoutBalance += amount;
        }

        public virtual void Depit(double amount)
        {
            #region using return with if else concept

            if (amount > AccoutBalance)
            {
                Console.WriteLine("Depit amount exceed account balance");
                return;
            }
            
                AccoutBalance -= amount;

            #endregion

            if (amount > AccoutBalance)
            {
                Console.WriteLine("Depit amount exceed account balance");
            }
            else
                AccoutBalance -= amount;

        }
        public double GetBalance() { return AccoutBalance; }


    }
}

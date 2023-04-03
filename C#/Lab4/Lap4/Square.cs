namespace Lap4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Square : Rectangle
    {
        
        public override float CalcArea()
        {
            return Dim1 * 2;
        }
        public override string Draw()
        {
            return "Square";
        }


    }
}

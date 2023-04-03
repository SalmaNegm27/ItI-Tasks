namespace Lap4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Shape
    {
        private string color;
        public float Area { get; set; }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public abstract float CalcArea();



        public abstract string Draw();



    }
}

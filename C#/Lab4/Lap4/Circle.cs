namespace Lap4
{
    using System;
    using System.CodeDom;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Circle : Shape
    {
        private float _radious;

        private  float bi ;

        public float Bi
        {
            get { return bi; }
            set { bi = value; }
        }


        public float Radious
        {
            get { return _radious; }
            set { _radious = value; }
        }
        public Circle() :this(10)
        {
           
            bi = 3.14f;
        }
        public Circle(float radious)
        {
            _radious= radious;
            bi = 3.14f;
        }

        #region before abstract
        //public float CalcArea()
        //{
        //    return bi * Radious * Radious;
        //} 
        #endregion

        public override float CalcArea()
        {
            return bi * Radious * Radious;
        }

        public override string Draw()
        {
            return "Circle";
        }
    }
}

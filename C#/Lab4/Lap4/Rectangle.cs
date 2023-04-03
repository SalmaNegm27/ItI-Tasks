namespace Lap4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Rectangle : Shape
    {
        private float _dim1;

        private float _dim2;

        public float Dim2
        {
            get { return _dim2; }
            set { _dim2 = value; }
        }

        public float Dim1
        {
            get { return _dim1; }
            set { _dim1 = value; }
        }

        public Rectangle() :this (10 ,10)
        {
           
        }
        public Rectangle(float dim1 , float dim2)
        {
            _dim1= dim1;
            _dim2 = dim2;
        }

        #region before abstract
        //public new float CalcArea()
        //{
        //    return _dim1 * _dim2;
        //} 
        #endregion

        public override float CalcArea()
        {
            return _dim1 * _dim2;
        }

        public override string Draw()
        {
            return "Rectangle";
        }
    }
}

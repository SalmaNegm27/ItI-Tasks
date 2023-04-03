namespace Lap4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Triangle : Shape
    {
        private float _dim1;

        private float _dim2;

        private float _dim3;

        public float Dim3
        {
            get { return _dim2; }
            set { _dim2 = value; }
        }

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


        public Triangle() : this (10,10,10)
        {
           
        }
        public Triangle(int dim1) :this (dim1 ,10,10)
        {
            

        }
        public Triangle(int dim1 , int dim2) :this (dim1 ,dim2 ,10)
        {
            
        }
        public Triangle(int dim1, int dim2 , int dim3)
        {
            _dim1 = dim1;
            _dim2 = dim2;
            _dim3 = dim3;

        }

        #region Before abstract class
        //public float CalcArea()
        //{
        //    return _dim1 * _dim2 * _dim3;
        //} 
        #endregion

        public override float CalcArea()
        {
            return _dim1 * _dim2 * _dim3;
        }

        public override string Draw()
        {
            return "Triangle";
        }
    }
}

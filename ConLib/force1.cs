
namespace ConLib
{
    public struct force1
    {
        double n;   // В Ньютонах !!!

        // Конструктор 
        public force1(double f)
        { n = f; }   // force1() 


        #region Properties

        public double N
        {
            get { return n; }
            set { n = value; }
        }   // N 

        public double Kg
        {
            get { return n / 10.0; }
            set { n = value * 10.0; }
        }   // N 

        #endregion Properties

        #region Operators

        // operator *(force1 f1, double dbl) 
        public static force1 operator *(force1 f1, double dbl)
        {
            force1 f2 = new force1();
            f2.N = f1.N * dbl;
            return f2;
        }   // operator *(force1 f1, double dbl)

        #endregion Operators

        #region Conversion

        // user-defined conversion from force1 to double 
        public static implicit operator double(force1 f)
        {
            return f.N;
        }   // conversion from force1 to double 


        // user-defined conversion from double to force1 
        public static implicit operator force1(double d)
        {
            return new force1(d);
        }   // conversion from double to dim1 

        #endregion Conversion
    }   // struct force1 
}       // namespace ConLib 

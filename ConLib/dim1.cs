
namespace ConLib
{
    public struct dim1
    {
        // Поле 
        double mm;  // В миллиметрах 

        ////Конструктор  - в структуре нельзя конструктор без параметров !!! 
        //public dim1()
        //{   mm = 0.0;   }   // dim1() 

        // Конструктор 
        public dim1(double val_mm)
        {   mm = val_mm;    }   // dim1(double val_mm) 


        #region Properties

        public double Mm
        {
            get { return mm; }
            set { mm = value; }
        }   // Mm 


        public double Cm
        {
            get { return mm / 10.0; }
            set { mm = value * 10.0; }
        }   // Cm 


        public double M
        {
            get { return mm / 1000.0; }
            set { mm = value * 1000.0; }
        }   // M 

        #endregion Properties

        #region Operators
        // operator *(dim1 d1, dim1 d2) 
        public static dim2 operator *(dim1 d1, dim1 d2)
        {
            dim2 d3 = new dim2();
            d3.Mm_sq = d1.Mm * d2.Mm;
            return d3;
        }   // operator *(dim1 d1, dim1 d2) 


        // operator *(Dim1 d1, double dbl) 
        public static dim1 operator *(dim1 d1, double dbl)
        {
            dim1 d3 = new dim1();
            d3.Mm = d1.Mm * dbl;
            return d3;
        }   // operator *(dim1 d1, double dbl) 


        // operator +(dim1 d1, dim1 d2) 
        public static moment1 operator *(dim1 d1, force1 f1)
        {
            moment1 m1 = new moment1();
            m1.M_Nm = d1.M * f1.N;
            return m1;
        }   // operator *(dim1 d1, dim1 d2) 

        #endregion Operators

        #region Conversion
        // user-defined conversion from Fraction to double 
        public static implicit operator double(dim1 d)
        {
            return d.Mm;
        }   // conversion from dim1 to double 

        // user-defined conversion from double to dim1 
        public static implicit operator dim1(double d)
        {
            return new dim1(d);
        }   // conversion from double to dim1 
        #endregion Conversion

    }   // struct dim1 
}       // namespace ConLib 

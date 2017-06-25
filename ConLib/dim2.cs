
namespace ConLib
{
    public struct dim2
    {
        // Поле
        double mm_sq;   // В миллиметрах квадратных 
        
        //// Конструктор 
        //public dim2()
        //{   mm_sq = 0.0;    }   // Dim2()
        

        // Конструктор 
        public dim2(double val_mm_sq)
        {   mm_sq = val_mm_sq;  }   // Dim2(double val_mm_sq)


        #region Properties

        public double Mm_sq
        {
            get { return mm_sq; }
            set { mm_sq = value; }
        }   // Mm_sq 


        public double Cm_sq
        {
            get { return mm_sq / 100.0; }
            set { mm_sq = value * 100.0; }
        }   // Cm_sq 

        #endregion Properties

        #region Operators

        // operator *(dim1 d1, dim1 d2) 
        public static stress operator /(dim2 d2, force1 f1)
        {
            stress s = new stress();
            s.N_mmsq = f1.N / d2.Mm_sq;
            return s;
        }   // operator *(dim1 d1, dim1 d2) 
        
        
        
        // operator -(dim2 d1, dim2 d2) 
        public static dim2 operator -(dim2 d1, dim2 d2)
        {
            dim2 d3 = new dim2();
            d3.Mm_sq = d1.Mm_sq - d2.Mm_sq;
            return d3;
        }   // operator -(dim2 d1, dim2 d2) 
        
        #endregion Operators

        #region Conversion

        // user-defined conversion from Fraction to double 
        public static implicit operator double(dim2 d)
        {            
            return d.Mm_sq;
        }   // conversion from Dim1 to double 

        // user-defined conversion from double to Dim1 
        public static implicit operator dim2(double d)
        {
            return new dim2(d);
        }   // conversion from double to Dim1 

        #endregion Conversion

    }   // struct dim2 
}       // namespace ConLib 

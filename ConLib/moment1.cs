
namespace ConLib
{
    public struct moment1
    {
        double m;   // В Ньютонах * Метр !!!
                
        // Конструктор 
        public moment1(double f)    // В Ньютонах * Метр !!!
        { m = f; }   // moment1() 


        #region Properties
        
        public double M_Nm
        {
            get { return m; }
            set { m = value; }
        }   // M_Nm 
        
        public double M_Kgcm
        {
            get { return m * 10.0; }
            set { m = value / 10.0; }
        }   // N 

        #endregion Properties





        #region Conversion

        // user-defined conversion from force1 to double 
        public static implicit operator double(moment1 m)
        {
            return m.M_Nm;
        }   // conversion from force1 to double 


        // user-defined conversion from double to force1 
        public static implicit operator moment1(double m)
        {
            return new moment1(m);
        }   // conversion from double to dim1 

        #endregion Conversion

    }   // struct force1 
}       // namespace ConLib 
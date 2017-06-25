
namespace ConLib
{
    public struct stress
    {
        double a; // Напряжение в МПа = N/mm^2 
        
        // // Конструктор 
        //public stress()
        //{ a = 0.0; }   // force1() 

        // Конструктор 
        public stress(double f)
        { a = f; }   // force1() 


        // Свойства 

        public double N_mmsq    // МПа = N/mm^2 
        {
            get { return a; }
            set { a = value; }
        }   // N_mmsq 
         

        public double Kg_cmsq   // Kg / cm^2 
        {
            get { return a * 10.0; }
            set { a = value / 10.0; }
        }   // Kg_cmsq 


            // Operators 
        //// operator *(dim1 d1, dim1 d2) 
        //public static stress operator /(dim2 d2, force1 f1)
        //{
        //    stress s = new stress();
        //    s.N_mmsq = d2.Mm_sq / f1.N;
        //    return s;
        //}   // operator *(dim1 d1, dim1 d2) 
        

        //// operator *(dim1 d1, dim1 d2) 
        //public static stress operator /(dim2 d2, force1 f1)
        //{
        //    stress s = new stress();
        //    s.N_mmsq = d2.Mm_sq / f1.N;
        //    return s;
        //}   // operator *(dim1 d1, dim1 d2) 


            // Conversion 
        // user-defined conversion from Fraction to double 
        public static implicit operator double(stress s)
        {
            return s.N_mmsq;
        }   // conversion from dim1 to double 

        // user-defined conversion from double to dim1 
        public static implicit operator stress(double s)
        {
            return new stress(s);
        }   // conversion from double to dim1 
        
    }   // class stress 
}       // namespace ConLib 

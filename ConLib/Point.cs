using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//using 

namespace ConLib
{
    class Point
    {
        // Поля 
        double x_mm, y_mm;

        // Конструктор 
        public Point()
        {
            x_mm = 0.0;
            y_mm = 0.0;
        }   // Point() 

        // конструктор с аргументами
        public Point(double xValue, double yValue)
        {
            // здесь происходит неявное обращение к конструктору Object
            Lib.s("Point's constructor with args now RUNS");
            x_mm = xValue;
            y_mm = yValue;
        }   // end of - public Point(int xValue, int yValue)


        // Свойства 
        public double X_Mm
        {
            get { return x_mm; }
            set { x_mm = value; }
        }   // X_Mm 

        public double Y_Mm
        {
            get { return y_mm; }
            set { y_mm = value; }
        }   // Y_Mm 

    }   // class Point 
}       // namespace ConLib 

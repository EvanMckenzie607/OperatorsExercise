using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    public class Methods
    {
        public static double Addition()
        {

            double a = 17;
            double b = 4;
            double add = a + b;
            return add;


        }


        public static double Sub()
        {

            double a = 17;
            double b = 4;
            double minus = a - b;
            return minus;
        }

        public static double Mulx()
        {
            double a = 17;
            double b = 4;
            double prod = a * b;
            return prod;

        }

        public static double Divide()
        {
            double a = 17;
            double b = 4;
            double quo = 17 / 4;
            return quo;

        }

        public static double Remain()
        {

            double a = 17;
            double b = 4;
            double R = 17 % 4;
            if (a == 17 && b == 4)
            {
            

            }
            return R;
        }

        public static float AreaOfCircle()
        {
            
            double radius = Double.Parse(Console.ReadLine());
            radius = Math.PI * Math.Pow(radius, 2);
            return (float)radius;
            
          





        }

    }


}




